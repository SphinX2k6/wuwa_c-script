using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component
{
	// Token: 0x0200631C RID: 25372
	[NullableContext(1)]
	[Nullable(0)]
	public class CharacterConfigParams
	{
		// Token: 0x0603D6AB RID: 251563 RVA: 0x011C23C8 File Offset: 0x011C05C8
		public CharacterConfigParams(FName name, int priority, UKuroDataBag dataBag, FGameplayTagContainer activateTags, EConfigApplyTypeNew applyType, BaseTagComponent tagComp, UKuroConfigHelperNew configHelper)
		{
			this.Name = name;
			this.Priority = priority;
			this.DataBag = dataBag;
			this.ApplyType = applyType;
			this.TagComp = tagComp;
			this.ConfigHelper = configHelper;
			TArray<FGameplayTag> gameplayTags = activateTags.GameplayTags;
			for (int i = gameplayTags.Num() - 1; i >= 0; i--)
			{
				this.Tags.Add(gameplayTags.Get(i).TagId());
			}
		}

		// Token: 0x0603D6AC RID: 251564 RVA: 0x011C2448 File Offset: 0x011C0648
		public void TryActivate()
		{
			if (this.Activated)
			{
				return;
			}
			foreach (int tagId in this.Tags)
			{
				if (!this.TagComp.HasTag(tagId))
				{
					return;
				}
			}
			this.Activated = true;
			this.ConfigHelper.AddSubConfigByBag(this.Name, this.Priority, this.DataBag, this.ApplyType);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Movement;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "CharacterConfig AddSubConfigByBag";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Name", this.Name);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x0603D6AD RID: 251565 RVA: 0x011C2508 File Offset: 0x011C0708
		public void Inactivate()
		{
			if (!this.Activated)
			{
				return;
			}
			this.Activated = false;
			this.ConfigHelper.RemoveSubConfig(this.Name);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Movement;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "CharacterConfig RemoveSubConfig";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Name", this.Name);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x04020913 RID: 133395
		private bool Activated;

		// Token: 0x04020914 RID: 133396
		private readonly List<int> Tags = new List<int>();

		// Token: 0x04020915 RID: 133397
		public FName Name;

		// Token: 0x04020916 RID: 133398
		private readonly int Priority;

		// Token: 0x04020917 RID: 133399
		private readonly UKuroDataBag DataBag;

		// Token: 0x04020918 RID: 133400
		private readonly EConfigApplyTypeNew ApplyType;

		// Token: 0x04020919 RID: 133401
		private readonly BaseTagComponent TagComp;

		// Token: 0x0402091A RID: 133402
		private readonly UKuroConfigHelperNew ConfigHelper;
	}
}
