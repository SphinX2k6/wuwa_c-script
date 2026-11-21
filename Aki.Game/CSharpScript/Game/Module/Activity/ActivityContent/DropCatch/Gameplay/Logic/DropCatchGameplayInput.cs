using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x02005683 RID: 22147
	[NullableContext(1)]
	[Nullable(0)]
	public class DropCatchGameplayInput<[Nullable(2)] TValue>
	{
		// Token: 0x06036A3B RID: 223803 RVA: 0x00F3FD69 File Offset: 0x00F3DF69
		[NullableContext(2)]
		public void Init(Action<EDropCatchGameplayInputSource?> activeSourceCallback = null)
		{
			this.ActiveSourceCallback = activeSourceCallback;
		}

		// Token: 0x06036A3C RID: 223804 RVA: 0x00F3FD74 File Offset: 0x00F3DF74
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

		// Token: 0x06036A3D RID: 223805 RVA: 0x00F3FDD0 File Offset: 0x00F3DFD0
		public TValue Get(TValue fallback)
		{
			TValue result;
			if (this.ActiveSource != null && this.Values.TryGetValue(this.ActiveSource.Value, out result))
			{
				return result;
			}
			return fallback;
		}

		// Token: 0x06036A3E RID: 223806 RVA: 0x00F3FE07 File Offset: 0x00F3E007
		public void Delete(EDropCatchGameplayInputSource source)
		{
			this.Values.Remove(source);
		}

		// Token: 0x06036A3F RID: 223807 RVA: 0x00F3FE16 File Offset: 0x00F3E016
		public void OnTick()
		{
			this.RefreshActiveSource();
		}

		// Token: 0x06036A40 RID: 223808 RVA: 0x00F3FE20 File Offset: 0x00F3E020
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

		// Token: 0x0401CE03 RID: 118275
		private readonly Dictionary<EDropCatchGameplayInputSource, TValue> Values = new Dictionary<EDropCatchGameplayInputSource, TValue>();

		// Token: 0x0401CE04 RID: 118276
		private EDropCatchGameplayInputSource? ActiveSource;

		// Token: 0x0401CE05 RID: 118277
		[Nullable(2)]
		private Action<EDropCatchGameplayInputSource?> ActiveSourceCallback;
	}
}
