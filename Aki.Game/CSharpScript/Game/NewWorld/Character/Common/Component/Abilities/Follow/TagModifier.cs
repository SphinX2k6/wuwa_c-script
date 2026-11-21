using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Fight.Struct;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x0200635D RID: 25437
	[NullableContext(1)]
	[Nullable(0)]
	public class TagModifier
	{
		// Token: 0x0603DA39 RID: 252473 RVA: 0x011DB574 File Offset: 0x011D9774
		public static TagModifier Create(SFollowShooterTagConfig config, Dictionary<int, HashSet<int>> listenTagToCheckIndexMap, int dataIndex)
		{
			TagModifier tagModifier = new TagModifier();
			foreach (FGameplayTag tag in config.AddTags.GameplayTags)
			{
				tagModifier.AddTagSet.Add(tag.TagId());
			}
			foreach (FGameplayTag tag2 in config.CheckTags.GameplayTags)
			{
				int num = tag2.TagId();
				HashSet<int> hashSet;
				if (!listenTagToCheckIndexMap.TryGetValue(num, out hashSet))
				{
					hashSet = new HashSet<int>();
					listenTagToCheckIndexMap[num] = hashSet;
				}
				hashSet.Add(dataIndex);
				tagModifier.CheckTagSet.Add(num);
			}
			tagModifier.CheckHasTag = config.CheckHasTag;
			tagModifier.CheckAll = (config.LogicType == ETagLogicType.All);
			return tagModifier;
		}

		// Token: 0x0603DA3A RID: 252474 RVA: 0x011DB678 File Offset: 0x011D9878
		public void TriggerModifyTag([Nullable(2)] BaseTagComponent currentRoleTagComp, BaseTagComponent selfTagComp)
		{
			if (this.CheckNeedAdd(currentRoleTagComp))
			{
				if (!this.HasAddTag)
				{
					this.HasAddTag = true;
					foreach (int tagId in this.AddTagSet)
					{
						selfTagComp.TagContainer.UpdateExactTag(ETagChannel.Common, tagId, 1);
					}
				}
				return;
			}
			if (this.HasAddTag)
			{
				this.HasAddTag = false;
				foreach (int tagId2 in this.AddTagSet)
				{
					selfTagComp.TagContainer.UpdateExactTag(ETagChannel.Common, tagId2, -1);
				}
			}
		}

		// Token: 0x0603DA3B RID: 252475 RVA: 0x011DB744 File Offset: 0x011D9944
		[NullableContext(2)]
		private bool CheckNeedAdd(BaseTagComponent currentRoleTagComp)
		{
			if (currentRoleTagComp == null)
			{
				return false;
			}
			bool flag = this.CheckAll ? currentRoleTagComp.HasAllTag(this.CheckTagSet) : currentRoleTagComp.HasAnyTag(this.CheckTagSet);
			if (!this.CheckHasTag)
			{
				return !flag;
			}
			return flag;
		}

		// Token: 0x04020B29 RID: 133929
		private readonly HashSet<int> AddTagSet = new HashSet<int>();

		// Token: 0x04020B2A RID: 133930
		private readonly HashSet<int> CheckTagSet = new HashSet<int>();

		// Token: 0x04020B2B RID: 133931
		private bool CheckHasTag;

		// Token: 0x04020B2C RID: 133932
		private bool CheckAll;

		// Token: 0x04020B2D RID: 133933
		private bool HasAddTag;
	}
}
