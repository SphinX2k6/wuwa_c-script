using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x02006733 RID: 26419
	[NullableContext(1)]
	[Nullable(0)]
	public class DropCatchGameplayInput<[Nullable(2)] TValue>
	{
		// Token: 0x06041EEF RID: 270063 RVA: 0x00FFE99D File Offset: 0x00FFCB9D
		[NullableContext(2)]
		public void Init(Action<EDropCatchGameplayInputSource?> activeSourceCallback = null)
		{
			this.ActiveSourceCallback = activeSourceCallback;
		}

		// Token: 0x06041EF0 RID: 270064 RVA: 0x00FFE9A8 File Offset: 0x00FFCBA8
		public void Set(EDropCatchGameplayInputSource source, TValue value)
		{
			TValue tvalue;
			if (this.Values.TryGetValue(source, out tvalue) && tvalue.Equals(value))
			{
				return;
			}
			if (this.Values.ContainsKey(source))
			{
				this.Values[source] = value;
				return;
			}
			this.Values.Add(source, value);
		}

		// Token: 0x06041EF1 RID: 270065 RVA: 0x00FFEA04 File Offset: 0x00FFCC04
		public TValue Get(TValue fallback)
		{
			TValue result;
			if (this.ActiveSource != null && this.Values.TryGetValue(this.ActiveSource.Value, out result))
			{
				return result;
			}
			return fallback;
		}

		// Token: 0x06041EF2 RID: 270066 RVA: 0x00FFEA3B File Offset: 0x00FFCC3B
		public void Delete(EDropCatchGameplayInputSource source)
		{
			this.Values.Remove(source);
		}

		// Token: 0x06041EF3 RID: 270067 RVA: 0x00FFEA4A File Offset: 0x00FFCC4A
		public void OnTick()
		{
			this.RefreshActiveSource();
		}

		// Token: 0x06041EF4 RID: 270068 RVA: 0x00FFEA54 File Offset: 0x00FFCC54
		public void RefreshActiveSource()
		{
			foreach (EDropCatchGameplayInputSource edropCatchGameplayInputSource in DropCatchDefine.Instance.InputPriority)
			{
				TValue tvalue;
				if (this.Values.TryGetValue(edropCatchGameplayInputSource, out tvalue))
				{
					this.ActiveSource = new EDropCatchGameplayInputSource?(edropCatchGameplayInputSource);
					break;
				}
			}
			Action<EDropCatchGameplayInputSource?> activeSourceCallback = this.ActiveSourceCallback;
			if (activeSourceCallback == null)
			{
				return;
			}
			activeSourceCallback(this.ActiveSource);
		}

		// Token: 0x040225AA RID: 140714
		private readonly Dictionary<EDropCatchGameplayInputSource, TValue> Values = new Dictionary<EDropCatchGameplayInputSource, TValue>();

		// Token: 0x040225AB RID: 140715
		private EDropCatchGameplayInputSource? ActiveSource;

		// Token: 0x040225AC RID: 140716
		[Nullable(2)]
		private Action<EDropCatchGameplayInputSource?> ActiveSourceCallback;
	}
}
