using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.GeneralLogicTree.BaseBehaviorTree
{
	// Token: 0x020059EB RID: 23019
	[NullableContext(1)]
	[Nullable(0)]
	public class BehaviorTreeTagContainer
	{
		// Token: 0x0603A54A RID: 238922 RVA: 0x00DE0208 File Offset: 0x00DDE408
		public virtual void AddTag(EBehaviorTreeTag tag, string reason = "")
		{
			HashSet<string> hashSet;
			if (!this.Tags.TryGetValue(tag, out hashSet))
			{
				hashSet = (this.Tags[tag] = new HashSet<string>());
			}
			hashSet.Add(reason);
		}

		// Token: 0x0603A54B RID: 238923 RVA: 0x00DE0240 File Offset: 0x00DDE440
		public virtual void RemoveTag(EBehaviorTreeTag tag, string reason = "")
		{
			HashSet<string> hashSet;
			if (!this.Tags.TryGetValue(tag, out hashSet))
			{
				return;
			}
			hashSet.Remove(reason);
			if (hashSet.Count == 0)
			{
				this.Tags.Remove(tag);
			}
		}

		// Token: 0x0603A54C RID: 238924 RVA: 0x00DE027B File Offset: 0x00DDE47B
		public bool ContainTag(EBehaviorTreeTag tag)
		{
			return this.Tags.ContainsKey(tag);
		}

		// Token: 0x0401E69C RID: 124572
		protected const string DEFAULET_REASON = "";

		// Token: 0x0401E69D RID: 124573
		private readonly Dictionary<EBehaviorTreeTag, HashSet<string>> Tags = new Dictionary<EBehaviorTreeTag, HashSet<string>>();
	}
}
