using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Battle;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02004A3A RID: 19002
	[NullableContext(1)]
	[Nullable(0)]
	public class FlagChallengeBuffView : UiViewBase
	{
		// Token: 0x17005FC5 RID: 24517
		// (get) Token: 0x0602F982 RID: 194946 RVA: 0x00D46044 File Offset: 0x00D44244
		[Nullable(2)]
		public new FlagChallengeBuffViewParams OpenParam
		{
			[NullableContext(2)]
			get
			{
				return this.OpenParam as FlagChallengeBuffViewParams;
			}
		}

		// Token: 0x0602F983 RID: 194947 RVA: 0x00D46051 File Offset: 0x00D44251
		public FlagChallengeBuffView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602F984 RID: 194948 RVA: 0x00D46070 File Offset: 0x00D44270
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUISprite)),
				new ValueTuple<int, Type>(3, typeof(UUISprite)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIArtText)),
				new ValueTuple<int, Type>(8, typeof(UUIArtText)),
				new ValueTuple<int, Type>(9, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(10, typeof(UUIItem)),
				new ValueTuple<int, Type>(11, typeof(UUIItem)),
				new ValueTuple<int, Type>(12, typeof(UUIItem)),
				new ValueTuple<int, Type>(13, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(14, typeof(UUIText)),
				new ValueTuple<int, Type>(15, typeof(UUIItem)),
				new ValueTuple<int, Type>(16, typeof(UUIText)),
				new ValueTuple<int, Type>(17, typeof(UUIItem)),
				new ValueTuple<int, Type>(18, typeof(UUIText))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(9, new Action(this.OnBuffDetailButtonClick))
			};
		}

		// Token: 0x0602F985 RID: 194949 RVA: 0x00D46258 File Offset: 0x00D44458
		protected override UniTask OnBeforeStartAsync()
		{
			FlagChallengeBuffView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FlagChallengeBuffView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602F986 RID: 194950 RVA: 0x00D4629C File Offset: 0x00D4449C
		protected override void OnBeforeShow()
		{
			this.RefreshView();
			UUIScrollViewWithScrollbarComponent scroll = base.GetScrollViewWithScrollbar(13);
			scroll.OnLateUpdate.Bind(delegate(float _)
			{
				TimerSystem.Instance.Next(new TTimerAction(this.UpdateProgressAndJump), null, null);
				UUIScrollViewWithScrollbarComponent scroll = scroll;
				if (scroll == null)
				{
					return;
				}
				scroll.OnLateUpdate.Unbind();
			});
		}

		// Token: 0x0602F987 RID: 194951 RVA: 0x00D462E6 File Offset: 0x00D444E6
		protected override void OnBeforeDestroy()
		{
			FlagChallengeModel.Instance.GetFlagChallengeData(this.ActivityId).ClearBuffNewlyUnlocked();
		}

		// Token: 0x0602F988 RID: 194952 RVA: 0x00D46300 File Offset: 0x00D44500
		private UniTask InitBuffList()
		{
			FlagChallengeBuffView.<InitBuffList>d__16 <InitBuffList>d__;
			<InitBuffList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBuffList>d__.<>4__this = this;
			<InitBuffList>d__.<>1__state = -1;
			<InitBuffList>d__.<>t__builder.Start<FlagChallengeBuffView.<InitBuffList>d__16>(ref <InitBuffList>d__);
			return <InitBuffList>d__.<>t__builder.Task;
		}

		// Token: 0x0602F989 RID: 194953 RVA: 0x00D46344 File Offset: 0x00D44544
		private void RefreshView()
		{
			foreach (FlagChallengeBuffItem flagChallengeBuffItem in this.BuffItemList)
			{
				flagChallengeBuffItem.RefreshView();
			}
			if (this.SelectBuff != null)
			{
				this.BuffInfoPanel.RefreshView(this.SelectBuff);
				this.BuffInfoPanel.SetUiActive(true);
			}
			else
			{
				this.BuffInfoPanel.SetUiActive(false);
			}
			this.LevelInfoItem.RefreshView();
			int num = 0;
			using (List<FlagChallengeBuffData>.Enumerator enumerator2 = this.BuffDataList.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					if (enumerator2.Current.IsActiveOrTempActive())
					{
						num++;
					}
				}
			}
			base.GetArtText(7).SetText(num.ToString());
			base.GetArtText(8).SetText(this.BuffDataList.Count.ToString());
			this.RefreshBoxLevel();
		}

		// Token: 0x0602F98A RID: 194954 RVA: 0x00D46454 File Offset: 0x00D44654
		private void RefreshBoxLevel()
		{
			UUIText text = base.GetText(18);
			if (!FlagChallengeUtils.IsInFlagChallengeDungeon())
			{
				text.SetUIActive(false);
				return;
			}
			text.SetUIActive(true);
			int boxLevel = FlagChallengeBattleModel.Instance.GetBoxLevel();
			LguiUtil.Instance.SetLocalTextNew(text, "Morale_32_Buff_ChestLv", new <>z__ReadOnlySingleElementList<object>(boxLevel));
		}

		// Token: 0x0602F98B RID: 194955 RVA: 0x00D464A8 File Offset: 0x00D446A8
		private void UpdateProgressAndJump(float delta)
		{
			if (base.IsDestroyOrDestroying)
			{
				return;
			}
			this.UpdateLevelProgress(null, null);
			this.UpdateScrollJumpPos();
		}

		// Token: 0x0602F98C RID: 194956 RVA: 0x00D464DC File Offset: 0x00D446DC
		private void UpdateLevelProgress(int? fixedLevel = null, int? tempLevel = null)
		{
			UUISprite sprite = base.GetSprite(2);
			float num = (sprite != null) ? sprite.GetWidth() : 0f;
			if (num <= 0f)
			{
				return;
			}
			int num2 = fixedLevel ?? FlagChallengeModel.Instance.GetCalculatedLevel(this.ActivityId);
			float levelProgress = this.GetLevelProgress(num2);
			if (sprite != null)
			{
				sprite.SetFillAmount(levelProgress);
			}
			if (sprite != null)
			{
				sprite.SetUIActive(true);
			}
			int num3 = tempLevel ?? FlagChallengeModel.Instance.GetTempLevel(this.ActivityId);
			bool flag = num3 > 0 || levelProgress < 1f;
			UUISprite sprite2 = base.GetSprite(3);
			if (sprite2 != null)
			{
				sprite2.SetUIActive(flag);
			}
			if (!flag)
			{
				return;
			}
			float stretchLeft = num * levelProgress;
			if (sprite2 != null)
			{
				sprite2.SetStretchLeft(stretchLeft);
			}
			int level = num2 + num3;
			float levelProgress2 = this.GetLevelProgress(level);
			float num4 = 1f - levelProgress2;
			float stretchRight = num * num4;
			if (sprite2 != null)
			{
				sprite2.SetStretchRight(stretchRight);
			}
		}

		// Token: 0x0602F98D RID: 194957 RVA: 0x00D465E0 File Offset: 0x00D447E0
		public float GetLevelProgress(int level)
		{
			int num = this.BuffItemList.Count * 2 - 1;
			FlagChallengeBuffData buffDataByLevel = FlagChallengeModel.Instance.GetFlagChallengeData(this.ActivityId).GetBuffDataByLevel(level);
			int num2 = Math.Max(buffDataByLevel.GetStartLevel() - 1, 0);
			int num3 = (buffDataByLevel.GetIndex() > 0) ? 2 : 1;
			int num4 = (level - num2) / (buffDataByLevel.GetEndLevel() - num2) * num3;
			return (float)((Math.Max(buffDataByLevel.GetIndex() * 2 - 1, 0) + num4) / num);
		}

		// Token: 0x0602F98E RID: 194958 RVA: 0x00D46658 File Offset: 0x00D44858
		private void UpdateScrollJumpPos()
		{
			if (this.SelectBuff == null)
			{
				return;
			}
			int num = 2;
			int num2 = Math.Max(0, this.SelectBuff.GetIndex() - num);
			if (num2 >= this.BuffItemList.Count)
			{
				return;
			}
			FlagChallengeBuffItem flagChallengeBuffItem = this.BuffItemList[num2];
			if (flagChallengeBuffItem == null)
			{
				return;
			}
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(13);
			FVector relativeLocation = scrollViewWithScrollbar.ContentUIItem.Get().RelativeLocation;
			FVector2D fvector2D = new FVector2D(ref relativeLocation);
			scrollViewWithScrollbar.ScrollToLeft(ref fvector2D, flagChallengeBuffItem.GetRootItem(), false);
		}

		// Token: 0x0602F98F RID: 194959 RVA: 0x00D466DB File Offset: 0x00D448DB
		[NullableContext(2)]
		private void SetSelectBuff(FlagChallengeBuffData buff)
		{
			this.SelectBuff = buff;
			this.UpdateSelectBuffState();
		}

		// Token: 0x0602F990 RID: 194960 RVA: 0x00D466EC File Offset: 0x00D448EC
		private void UpdateSelectBuffState()
		{
			foreach (FlagChallengeBuffData flagChallengeBuffData in this.BuffDataList)
			{
				int id = flagChallengeBuffData.Id;
				FlagChallengeBuffData selectBuff = this.SelectBuff;
				int? num = (selectBuff != null) ? new int?(selectBuff.Id) : null;
				flagChallengeBuffData.IsSelected = (id == num.GetValueOrDefault() & num != null);
			}
		}

		// Token: 0x0602F991 RID: 194961 RVA: 0x00D46774 File Offset: 0x00D44974
		private void OnCloseClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602F992 RID: 194962 RVA: 0x00D46780 File Offset: 0x00D44980
		private void OnHelpClick()
		{
			int buffHelpId = FlagChallengeConfig.Instance.GetBuffHelpId();
			HelpController.Instance.OpenHelpById(buffHelpId);
		}

		// Token: 0x0602F993 RID: 194963 RVA: 0x00D467A4 File Offset: 0x00D449A4
		private void OnBuffItemClick(FlagChallengeBuffData data)
		{
			this.SetSelectBuff(data);
			this.BuffInfoPanel.RefreshView(data);
			foreach (FlagChallengeBuffItem flagChallengeBuffItem in this.BuffItemList)
			{
				flagChallengeBuffItem.UpdateToggleState();
			}
			FlagChallengeModel.Instance.GetFlagChallengeData(this.ActivityId).SetBuffNewlyUnlockedState(data.Id, false);
		}

		// Token: 0x0602F994 RID: 194964 RVA: 0x00D46824 File Offset: 0x00D44A24
		private void OnBuffDetailButtonClick()
		{
			this.RoleAttrAddPanel.SetActive(true);
		}

		// Token: 0x040193D9 RID: 103385
		private int ActivityId;

		// Token: 0x040193DA RID: 103386
		private List<FlagChallengeBuffData> BuffDataList;

		// Token: 0x040193DB RID: 103387
		[Nullable(2)]
		private FlagChallengeBuffData SelectBuff;

		// Token: 0x040193DC RID: 103388
		private PopupCaptionItem PopupCaption;

		// Token: 0x040193DD RID: 103389
		private FlagChallengeBuffInfoPanel BuffInfoPanel;

		// Token: 0x040193DE RID: 103390
		private FlagChallengeLevelInfoItem LevelInfoItem;

		// Token: 0x040193DF RID: 103391
		private FlagChallengeBuffAddPanel RoleAttrAddPanel;

		// Token: 0x040193E0 RID: 103392
		private readonly List<FlagChallengeBuffItem> BuffItemList = new List<FlagChallengeBuffItem>();

		// Token: 0x040193E1 RID: 103393
		private readonly Dictionary<int, FlagChallengeBuffItem> BuffItemMap = new Dictionary<int, FlagChallengeBuffItem>();
	}
}
