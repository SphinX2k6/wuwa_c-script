using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.GeneralLogicTree.BaseBehaviorTree
{
	// Token: 0x020049C4 RID: 18884
	[NullableContext(1)]
	[Nullable(0)]
	public class BehaviorTreeTagContainer
	{
		// Token: 0x0602F471 RID: 193649 RVA: 0x00D2FA74 File Offset: 0x00D2DC74
		public virtual void AddTag(EBehaviorTreeTag tag, string reason = "")
		{
			HashSet<string> hashSet;
			if (!this.Tags.TryGetValue(tag, out hashSet))
			{
				hashSet = (this.Tags[tag] = new HashSet<string>());
			}
			hashSet.Add(reason);
		}

		// Token: 0x0602F472 RID: 193650 RVA: 0x00D2FAAC File Offset: 0x00D2DCAC
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

		// Token: 0x0602F473 RID: 193651 RVA: 0x00D2FAE7 File Offset: 0x00D2DCE7
		public bool ContainTag(EBehaviorTreeTag tag)
		{
			return this.Tags.ContainsKey(tag);
		}

		// Token: 0x0401913B RID: 102715
		protected const string DEFAULET_REASON = "";

		// Token: 0x0401913C RID: 102716
		private readonly Dictionary<EBehaviorTreeTag, HashSet<string>> Tags = new Dictionary<EBehaviorTreeTag, HashSet<string>>();
	}
}
