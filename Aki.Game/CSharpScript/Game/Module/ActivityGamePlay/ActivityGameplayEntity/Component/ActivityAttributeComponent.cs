using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ActivityGamePlay.ActivityGameplayEntity.Component
{
	// Token: 0x0200693C RID: 26940
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityAttributeComponent : ActivityGameplayComponentBase
	{
		// Token: 0x06043254 RID: 275028 RVA: 0x0105E1D8 File Offset: 0x0105C3D8
		public void SetAttribute(int attrId, int value)
		{
			int num;
			int oldValue = this.AttributeMap.TryGetValue(attrId, out num) ? num : 0;
			this.AttributeMap[attrId] = value;
			HashSet<TActivityAttributeChangedCallback> hashSet;
			if (!this.ChangedCallbacks.TryGetValue(attrId, out hashSet))
			{
				return;
			}
			foreach (TActivityAttributeChangedCallback tactivityAttributeChangedCallback in hashSet)
			{
				tactivityAttributeChangedCallback(oldValue, value);
			}
		}

		// Token: 0x06043255 RID: 275029 RVA: 0x0105E258 File Offset: 0x0105C458
		public int GetAttribute(int attrId)
		{
			int result;
			if (!this.AttributeMap.TryGetValue(attrId, out result))
			{
				return 0;
			}
			return result;
		}

		// Token: 0x06043256 RID: 275030 RVA: 0x0105E278 File Offset: 0x0105C478
		public bool HasAttribute(int attrId)
		{
			return this.AttributeMap.ContainsKey(attrId);
		}

		// Token: 0x06043257 RID: 275031 RVA: 0x0105E288 File Offset: 0x0105C488
		public void AddChangedListener(int attrId, TActivityAttributeChangedCallback callback)
		{
			HashSet<TActivityAttributeChangedCallback> hashSet;
			if (!this.ChangedCallbacks.TryGetValue(attrId, out hashSet))
			{
				hashSet = new HashSet<TActivityAttributeChangedCallback>();
				this.ChangedCallbacks[attrId] = hashSet;
			}
			hashSet.Add(callback);
		}

		// Token: 0x06043258 RID: 275032 RVA: 0x0105E2C0 File Offset: 0x0105C4C0
		public void RemoveChangedListener(int attrId, TActivityAttributeChangedCallback callback)
		{
			HashSet<TActivityAttributeChangedCallback> hashSet;
			if (this.ChangedCallbacks.TryGetValue(attrId, out hashSet))
			{
				hashSet.Remove(callback);
			}
		}

		// Token: 0x06043259 RID: 275033 RVA: 0x0105E2E5 File Offset: 0x0105C4E5
		public void ClearData()
		{
			this.AttributeMap.Clear();
		}

		// Token: 0x0604325A RID: 275034 RVA: 0x0105E2F2 File Offset: 0x0105C4F2
		protected override void OnEnd()
		{
			this.AttributeMap.Clear();
			this.ChangedCallbacks.Clear();
		}

		// Token: 0x04022F5C RID: 143196
		private readonly Dictionary<int, int> AttributeMap = new Dictionary<int, int>();

		// Token: 0x04022F5D RID: 143197
		private readonly Dictionary<int, HashSet<TActivityAttributeChangedCallback>> ChangedCallbacks = new Dictionary<int, HashSet<TActivityAttributeChangedCallback>>();
	}
}
