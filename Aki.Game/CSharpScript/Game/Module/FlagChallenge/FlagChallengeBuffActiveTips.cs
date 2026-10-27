using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02005A53 RID: 23123
	[NullableContext(1)]
	[Nullable(0)]
	public class FlagChallengeBuffActiveTips : UiTickViewBase
	{
		// Token: 0x17008BF6 RID: 35830
		// (get) Token: 0x0603A9F6 RID: 240118 RVA: 0x00DF499A File Offset: 0x00DF2B9A
		[Nullable(2)]
		public new FlagChallengeBuffActiveTipsParams OpenParam
		{
			[NullableContext(2)]
			get
			{
				return this.OpenParam as FlagChallengeBuffActiveTipsParams;
			}
		}

		// Token: 0x0603A9F7 RID: 240119 RVA: 0x00DF49A7 File Offset: 0x00DF2BA7
		public FlagChallengeBuffActiveTips(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603A9F8 RID: 240120 RVA: 0x00DF49BC File Offset: 0x00DF2BBC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUISprite)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIText)),
				new ValueTuple<int, Type>(9, typeof(UUIItem)),
				new ValueTuple<int, Type>(10, typeof(UUIItem)),
				new ValueTuple<int, Type>(11, typeof(UUIItem))
			};
		}

		// Token: 0x0603A9F9 RID: 240121 RVA: 0x00DF4ACC File Offset: 0x00DF2CCC
		protected override void OnStart()
		{
			int activityId = this.OpenParam.ActivityId;
			this.Data = FlagChallengeModel.Instance.GetFlagChallengeData(activityId);
			this.ShowBuffList = this.Data.GetBuffActiveTipsList();
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			UUIItem item2 = base.GetItem(5);
			if (item2 != null)
			{
				item2.SetUIActive(true);
			}
			UUIItem item3 = base.GetItem(4);
			if (item3 != null)
			{
				item3.SetUIActive(false);
			}
			FlagChallengeBuffActiveTipsInfo flagChallengeBuffActiveTipsInfo = null;
			if (this.ShowBuffList.Count > 0)
			{
				flagChallengeBuffActiveTipsInfo = this.ShowBuffList[0];
				this.ShowBuffList.RemoveAt(0);
			}
			if (flagChallengeBuffActiveTipsInfo == null)
			{
				base.CloseMe(null);
				return;
			}
			this.UpdateData(flagChallengeBuffActiveTipsInfo);
		}

		// Token: 0x0603A9FA RID: 240122 RVA: 0x00DF4B7B File Offset: 0x00DF2D7B
		protected override void OnBeforeDestroy()
		{
			FlagChallengeData data = this.Data;
			if (data == null)
			{
				return;
			}
			data.ClearBuffActiveTipsList();
		}

		// Token: 0x0603A9FB RID: 240123 RVA: 0x00DF4B90 File Offset: 0x00DF2D90
		public void UpdateData(FlagChallengeBuffActiveTipsInfo buffInfo)
		{
			this.CurShowInfo = buffInfo;
			if (this.CurShowInfo == null)
			{
				base.CloseMe(null);
				return;
			}
			this.TipCountDown = (float)FlagChallengeConfig.Instance.GetBuffShowTime();
			FlagChallengeBuffData buffData = this.Data.GetBuffData(this.CurShowInfo.BuffId);
			if (buffData == null)
			{
				return;
			}
			base.GetText(1).ShowTextNew(buffData.Config.BuffName);
			base.GetText(2).ShowTextNew(buffData.Config.BuffDesc);
			this.UpdateState();
		}

		// Token: 0x0603A9FC RID: 240124 RVA: 0x00DF4C1C File Offset: 0x00DF2E1C
		public void UpdateState()
		{
			switch (this.CurShowInfo.State)
			{
			case EFlagChallengeBuffStatus.NotActive:
				this.SetStateNotActive();
				return;
			case EFlagChallengeBuffStatus.Active:
				this.SetStateActive();
				return;
			case EFlagChallengeBuffStatus.TempActive:
				this.SetStateTempActive();
				return;
			default:
				return;
			}
		}

		// Token: 0x0603A9FD RID: 240125 RVA: 0x00DF4C5C File Offset: 0x00DF2E5C
		public void SetStateActive()
		{
			this.SetLockShow(false);
			this.SetTagName("Morale_title_24");
			this.SetTagBg("SP_ItemNewBg");
			this.SetCheckState(9);
			this.SetInvalidLine(false);
			this.SetTitleChangeColor(false);
		}

		// Token: 0x0603A9FE RID: 240126 RVA: 0x00DF4C91 File Offset: 0x00DF2E91
		public void SetStateTempActive()
		{
			this.SetLockShow(true);
			this.SetTagName("Morale_title_25");
			this.SetTagBg("SP_ItemNewBg");
			this.SetCheckState(9);
			this.SetInvalidLine(false);
			this.SetTitleChangeColor(false);
		}

		// Token: 0x0603A9FF RID: 240127 RVA: 0x00DF4CC6 File Offset: 0x00DF2EC6
		public void SetStateNotActive()
		{
			this.SetLockShow(false);
			this.SetTagName("Morale_title_26");
			this.SetTagBg("SP_InvalidationBg");
			this.SetCheckState(10);
			this.SetInvalidLine(true);
			this.SetTitleChangeColor(true);
		}

		// Token: 0x0603AA00 RID: 240128 RVA: 0x00DF4CFB File Offset: 0x00DF2EFB
		private void SetLockShow(bool show)
		{
			base.GetItem(7).SetUIActive(show);
		}

		// Token: 0x0603AA01 RID: 240129 RVA: 0x00DF4D0A File Offset: 0x00DF2F0A
		private void SetTagName(string key)
		{
			UUIText text = base.GetText(8);
			if (text == null)
			{
				return;
			}
			text.ShowTextNew(key);
		}

		// Token: 0x0603AA02 RID: 240130 RVA: 0x00DF4D20 File Offset: 0x00DF2F20
		private void SetTagBg(string resId)
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resId);
			UUISprite sprite = base.GetSprite(6);
			this.SetSpriteByPath(resourcePath, sprite, false, null, null);
		}

		// Token: 0x0603AA03 RID: 240131 RVA: 0x00DF4D54 File Offset: 0x00DF2F54
		private void SetCheckState(int index)
		{
			foreach (int num in new List<int>
			{
				9,
				10
			})
			{
				base.GetItem(num).SetUIActive(num == index);
			}
		}

		// Token: 0x0603AA04 RID: 240132 RVA: 0x00DF4DC0 File Offset: 0x00DF2FC0
		private void SetInvalidLine(bool show)
		{
			base.GetItem(11).SetUIActive(show);
		}

		// Token: 0x0603AA05 RID: 240133 RVA: 0x00DF4DD0 File Offset: 0x00DF2FD0
		private void SetTitleChangeColor(bool useChangeColor)
		{
			UUIText text = base.GetText(1);
			if (text != null)
			{
				UUIItem uuiitem = text;
				FColor? fcolor = new FColor?(text.changeColor);
				uuiitem.SetChangeColor(useChangeColor, fcolor);
			}
		}

		// Token: 0x0603AA06 RID: 240134 RVA: 0x00DF4DFD File Offset: 0x00DF2FFD
		protected override void OnTick(float delta)
		{
			if (this.TipCountDown <= 0f)
			{
				return;
			}
			this.TipCountDown -= delta;
			if (this.TipCountDown <= 0f)
			{
				this.CloseViewOrShowNextData();
			}
		}

		// Token: 0x0603AA07 RID: 240135 RVA: 0x00DF4E2E File Offset: 0x00DF302E
		private void CloseViewOrShowNextData()
		{
			if (this.ShowBuffList.Count > 0)
			{
				this.ShowNextBuff();
				return;
			}
			base.CloseMe(null);
		}

		// Token: 0x0603AA08 RID: 240136 RVA: 0x00DF4E50 File Offset: 0x00DF3050
		private UniTask ShowNextBuff()
		{
			FlagChallengeBuffActiveTips.<ShowNextBuff>d__23 <ShowNextBuff>d__;
			<ShowNextBuff>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowNextBuff>d__.<>4__this = this;
			<ShowNextBuff>d__.<>1__state = -1;
			<ShowNextBuff>d__.<>t__builder.Start<FlagChallengeBuffActiveTips.<ShowNextBuff>d__23>(ref <ShowNextBuff>d__);
			return <ShowNextBuff>d__.<>t__builder.Task;
		}

		// Token: 0x0401E8EB RID: 125163
		public float TipCountDown;

		// Token: 0x0401E8EC RID: 125164
		public List<FlagChallengeBuffActiveTipsInfo> ShowBuffList = new List<FlagChallengeBuffActiveTipsInfo>();

		// Token: 0x0401E8ED RID: 125165
		[Nullable(2)]
		public FlagChallengeBuffActiveTipsInfo CurShowInfo;

		// Token: 0x0401E8EE RID: 125166
		[Nullable(2)]
		private FlagChallengeData Data;
	}
}
