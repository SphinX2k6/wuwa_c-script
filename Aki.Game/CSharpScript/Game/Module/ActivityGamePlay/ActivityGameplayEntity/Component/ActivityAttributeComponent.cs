using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ActivityGamePlay.ActivityGameplayEntity.Component
{
	// Token: 0x0200588D RID: 22669
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityAttributeComponent : ActivityGameplayComponentBase
	{
		// Token: 0x06037DB1 RID: 228785 RVA: 0x00F9F848 File Offset: 0x00F9DA48
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

		// Token: 0x06037DB2 RID: 228786 RVA: 0x00F9F8C8 File Offset: 0x00F9DAC8
		public int GetAttribute(int attrId)
		{
			int result;
			if (!this.AttributeMap.TryGetValue(attrId, out result))
			{
				return 0;
			}
			return result;
		}

		// Token: 0x06037DB3 RID: 228787 RVA: 0x00F9F8E8 File Offset: 0x00F9DAE8
		public bool HasAttribute(int attrId)
		{
			return this.AttributeMap.ContainsKey(attrId);
		}

		// Token: 0x06037DB4 RID: 228788 RVA: 0x00F9F8F8 File Offset: 0x00F9DAF8
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

		// Token: 0x06037DB5 RID: 228789 RVA: 0x00F9F930 File Offset: 0x00F9DB30
		public void RemoveChangedListener(int attrId, TActivityAttributeChangedCallback callback)
		{
			HashSet<TActivityAttributeChangedCallback> hashSet;
			if (this.ChangedCallbacks.TryGetValue(attrId, out hashSet))
			{
				hashSet.Remove(callback);
			}
		}

		// Token: 0x06037DB6 RID: 228790 RVA: 0x00F9F955 File Offset: 0x00F9DB55
		public void ClearData()
		{
			this.AttributeMap.Clear();
		}

		// Token: 0x06037DB7 RID: 228791 RVA: 0x00F9F962 File Offset: 0x00F9DB62
		protected override void OnEnd()
		{
			this.AttributeMap.Clear();
			this.ChangedCallbacks.Clear();
		}

		// Token: 0x0401D7B9 RID: 120761
		private readonly Dictionary<int, int> AttributeMap = new Dictionary<int, int>();

		// Token: 0x0401D7BA RID: 120762
		private readonly Dictionary<int, HashSet<TActivityAttributeChangedCallback>> ChangedCallbacks = new Dictionary<int, HashSet<TActivityAttributeChangedCallback>>();
	}
}
