using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Morale
{
	// Token: 0x0200439E RID: 17310
	public class MoraleSumAreaTitleItem : UiPanelBase
	{
		// Token: 0x0602BB98 RID: 179096 RVA: 0x00C458D8 File Offset: 0x00C43AD8
		[NullableContext(1)]
		public UniTask Init(UUIItem item, MoraleAreaData areaData)
		{
			MoraleSumAreaTitleItem.<Init>d__3 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.item = item;
			<Init>d__.areaData = areaData;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<MoraleSumAreaTitleItem.<Init>d__3>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x0602BB99 RID: 179097 RVA: 0x00C4592C File Offset: 0x00C43B2C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUISprite)),
				new ValueTuple<int, Type>(2, typeof(UUISprite)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUISprite)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUISprite)),
				new ValueTuple<int, Type>(8, typeof(UUIText)),
				new ValueTuple<int, Type>(9, typeof(UUIItem))
			};
		}

		// Token: 0x0602BB9A RID: 179098 RVA: 0x00C45A21 File Offset: 0x00C43C21
		protected override void OnStart()
		{
		}

		// Token: 0x0602BB9B RID: 179099 RVA: 0x00C45A23 File Offset: 0x00C43C23
		protected override void OnBeforeShow()
		{
		}

		// Token: 0x0602BB9C RID: 179100 RVA: 0x00C45A28 File Offset: 0x00C43C28
		public void UpdateData()
		{
			UUIText text = base.GetText(4);
			LguiUtil.Instance.SetLocalTextNew(text, "Morale_title_4", Array.Empty<object>());
			string textStringId = "Morale_title_16";
			int uiActiveFlagNum = this.AreaData.GetUiActiveFlagNum();
			int uiTotalFlagNum = this.AreaData.GetUiTotalFlagNum();
			UUIText text2 = base.GetText(3);
			LguiUtil.Instance.SetLocalTextNew(text2, textStringId, new <>z__ReadOnlyArray<object>(new object[]
			{
				uiActiveFlagNum,
				uiTotalFlagNum
			}));
			bool areaActiveState = this.AreaData.IsAllUiFlagActive();
			this.SetAreaActiveState(areaActiveState);
			bool flag = this.IsShowBoxProgress();
			this.SetBoxProgressActive(flag);
			if (flag)
			{
				int allBoxReceivedCount = this.AreaData.GetAllBoxReceivedCount();
				int allBoxTotalCount = this.AreaData.GetAllBoxTotalCount();
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(allBoxReceivedCount);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(allBoxTotalCount);
				string newText = defaultInterpolatedStringHandler.ToStringAndClear();
				UUIText text3 = base.GetText(8);
				if (text3 != null)
				{
					text3.SetText(newText, true);
				}
			}
			bool uiactive = this.AreaData.IsExistFlagRewardCanGet();
			UUIItem item = base.GetItem(9);
			if (item != null)
			{
				item.SetUIActive(uiactive);
			}
			bool uiactive2 = this.AreaData.IsPlayerInArea();
			UUISprite sprite = base.GetSprite(7);
			if (sprite != null)
			{
				sprite.SetUIActive(uiactive2);
			}
			this.CheckHighFlagNewActiveBefore();
		}

		// Token: 0x0602BB9D RID: 179101 RVA: 0x00C45B74 File Offset: 0x00C43D74
		public bool IsShowBoxProgress()
		{
			return this.AreaData.IsExistBox() && this.AreaData.HighDifficultyFlagSomeActive();
		}

		// Token: 0x0602BB9E RID: 179102 RVA: 0x00C45B90 File Offset: 0x00C43D90
		public UniTask CheckPlayHighMonsterKillEffect()
		{
			MoraleSumAreaTitleItem.<CheckPlayHighMonsterKillEffect>d__9 <CheckPlayHighMonsterKillEffect>d__;
			<CheckPlayHighMonsterKillEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CheckPlayHighMonsterKillEffect>d__.<>4__this = this;
			<CheckPlayHighMonsterKillEffect>d__.<>1__state = -1;
			<CheckPlayHighMonsterKillEffect>d__.<>t__builder.Start<MoraleSumAreaTitleItem.<CheckPlayHighMonsterKillEffect>d__9>(ref <CheckPlayHighMonsterKillEffect>d__);
			return <CheckPlayHighMonsterKillEffect>d__.<>t__builder.Task;
		}

		// Token: 0x0602BB9F RID: 179103 RVA: 0x00C45BD3 File Offset: 0x00C43DD3
		public void SetAreaActiveState(bool active)
		{
			UUISprite sprite = base.GetSprite(1);
			if (sprite != null)
			{
				sprite.SetUIActive(active);
			}
			UUISprite sprite2 = base.GetSprite(5);
			if (sprite2 == null)
			{
				return;
			}
			sprite2.SetUIActive(active);
		}

		// Token: 0x0602BBA0 RID: 179104 RVA: 0x00C45BFA File Offset: 0x00C43DFA
		public void SetBoxProgressActive(bool active)
		{
			UUIItem item = base.GetItem(6);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(active);
		}

		// Token: 0x0602BBA1 RID: 179105 RVA: 0x00C45C0E File Offset: 0x00C43E0E
		public void CheckHighFlagNewActiveBefore()
		{
			if (!this.AreaData.HighDifficultyFlagSomeNewActive())
			{
				return;
			}
			this.SetAreaActiveState(false);
			this.SetBoxProgressActive(false);
		}

		// Token: 0x0602BBA2 RID: 179106 RVA: 0x00C45C2C File Offset: 0x00C43E2C
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx([Nullable(new byte[]
		{
			2,
			1
		})] string[] configParams)
		{
			if (configParams == null || configParams.Length == 0)
			{
				return null;
			}
			if (!(configParams[0] == "FirstFinishedAreaBox"))
			{
				return null;
			}
			UUIItem item = base.GetItem(6);
			if (item == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				item,
				item
			};
		}

		// Token: 0x04017915 RID: 96533
		[Nullable(1)]
		public MoraleAreaData AreaData;

		// Token: 0x04017916 RID: 96534
		[Nullable(2)]
		public LevelSequencePlayer Sequence;

		// Token: 0x0200A09A RID: 41114
		private class EChildType
		{
			// Token: 0x04031E61 RID: 204385
			public const int ItemSelf = 0;

			// Token: 0x04031E62 RID: 204386
			public const int SpriteFinish = 1;

			// Token: 0x04031E63 RID: 204387
			public const int SpriteAreaIndex = 2;

			// Token: 0x04031E64 RID: 204388
			public const int TextAreaProgress = 3;

			// Token: 0x04031E65 RID: 204389
			public const int TextAreaName = 4;

			// Token: 0x04031E66 RID: 204390
			public const int SpriteActive = 5;

			// Token: 0x04031E67 RID: 204391
			public const int ItemBoxProgressRoot = 6;

			// Token: 0x04031E68 RID: 204392
			public const int SpritePlayerPos = 7;

			// Token: 0x04031E69 RID: 204393
			public const int TextBoxProgress = 8;

			// Token: 0x04031E6A RID: 204394
			public const int ItemBoxCanGetTips = 9;
		}
	}
}
