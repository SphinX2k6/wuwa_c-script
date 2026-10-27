using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Fight.Struct;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x0200712F RID: 28975
	[NullableContext(1)]
	[Nullable(0)]
	public class TagModifier
	{
		// Token: 0x06046BEB RID: 289771 RVA: 0x011D2A14 File Offset: 0x011D0C14
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

		// Token: 0x06046BEC RID: 289772 RVA: 0x011D2B0C File Offset: 0x011D0D0C
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

		// Token: 0x06046BED RID: 289773 RVA: 0x011D2BD8 File Offset: 0x011D0DD8
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

		// Token: 0x04025249 RID: 152137
		private readonly HashSet<int> AddTagSet = new HashSet<int>();

		// Token: 0x0402524A RID: 152138
		private readonly HashSet<int> CheckTagSet = new HashSet<int>();

		// Token: 0x0402524B RID: 152139
		private bool CheckHasTag;

		// Token: 0x0402524C RID: 152140
		private bool CheckAll;

		// Token: 0x0402524D RID: 152141
		private bool HasAddTag;
	}
}
