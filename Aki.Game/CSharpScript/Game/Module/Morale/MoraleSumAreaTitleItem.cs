using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Morale
{
	// Token: 0x020053BB RID: 21435
	public class MoraleSumAreaTitleItem : UiPanelBase
	{
		// Token: 0x06036C52 RID: 224338 RVA: 0x00CF6830 File Offset: 0x00CF4A30
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

		// Token: 0x06036C53 RID: 224339 RVA: 0x00CF6884 File Offset: 0x00CF4A84
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

		// Token: 0x06036C54 RID: 224340 RVA: 0x00CF6979 File Offset: 0x00CF4B79
		protected override void OnStart()
		{
		}

		// Token: 0x06036C55 RID: 224341 RVA: 0x00CF697B File Offset: 0x00CF4B7B
		protected override void OnBeforeShow()
		{
		}

		// Token: 0x06036C56 RID: 224342 RVA: 0x00CF6980 File Offset: 0x00CF4B80
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

		// Token: 0x06036C57 RID: 224343 RVA: 0x00CF6ACC File Offset: 0x00CF4CCC
		public bool IsShowBoxProgress()
		{
			return this.AreaData.IsExistBox() && this.AreaData.HighDifficultyFlagSomeActive();
		}

		// Token: 0x06036C58 RID: 224344 RVA: 0x00CF6AE8 File Offset: 0x00CF4CE8
		public UniTask CheckPlayHighMonsterKillEffect()
		{
			MoraleSumAreaTitleItem.<CheckPlayHighMonsterKillEffect>d__9 <CheckPlayHighMonsterKillEffect>d__;
			<CheckPlayHighMonsterKillEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CheckPlayHighMonsterKillEffect>d__.<>4__this = this;
			<CheckPlayHighMonsterKillEffect>d__.<>1__state = -1;
			<CheckPlayHighMonsterKillEffect>d__.<>t__builder.Start<MoraleSumAreaTitleItem.<CheckPlayHighMonsterKillEffect>d__9>(ref <CheckPlayHighMonsterKillEffect>d__);
			return <CheckPlayHighMonsterKillEffect>d__.<>t__builder.Task;
		}

		// Token: 0x06036C59 RID: 224345 RVA: 0x00CF6B2B File Offset: 0x00CF4D2B
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

		// Token: 0x06036C5A RID: 224346 RVA: 0x00CF6B52 File Offset: 0x00CF4D52
		public void SetBoxProgressActive(bool active)
		{
			UUIItem item = base.GetItem(6);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(active);
		}

		// Token: 0x06036C5B RID: 224347 RVA: 0x00CF6B66 File Offset: 0x00CF4D66
		public void CheckHighFlagNewActiveBefore()
		{
			if (!this.AreaData.HighDifficultyFlagSomeNewActive())
			{
				return;
			}
			this.SetAreaActiveState(false);
			this.SetBoxProgressActive(false);
		}

		// Token: 0x06036C5C RID: 224348 RVA: 0x00CF6B84 File Offset: 0x00CF4D84
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

		// Token: 0x0401CE7D RID: 118397
		[Nullable(1)]
		public MoraleAreaData AreaData;

		// Token: 0x0401CE7E RID: 118398
		[Nullable(2)]
		public LevelSequencePlayer Sequence;

		// Token: 0x0200B662 RID: 46690
		private class EChildType
		{
			// Token: 0x0403740C RID: 226316
			public const int ItemSelf = 0;

			// Token: 0x0403740D RID: 226317
			public const int SpriteFinish = 1;

			// Token: 0x0403740E RID: 226318
			public const int SpriteAreaIndex = 2;

			// Token: 0x0403740F RID: 226319
			public const int TextAreaProgress = 3;

			// Token: 0x04037410 RID: 226320
			public const int TextAreaName = 4;

			// Token: 0x04037411 RID: 226321
			public const int SpriteActive = 5;

			// Token: 0x04037412 RID: 226322
			public const int ItemBoxProgressRoot = 6;

			// Token: 0x04037413 RID: 226323
			public const int SpritePlayerPos = 7;

			// Token: 0x04037414 RID: 226324
			public const int TextBoxProgress = 8;

			// Token: 0x04037415 RID: 226325
			public const int ItemBoxCanGetTips = 9;
		}
	}
}
