using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Battle;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Morale
{
	// Token: 0x02004392 RID: 17298
	[NullableContext(1)]
	[Nullable(0)]
	public class MoraleBuffView : UiViewBase
	{
		// Token: 0x1700577E RID: 22398
		// (get) Token: 0x0602BB22 RID: 178978 RVA: 0x00C4391A File Offset: 0x00C41B1A
		[Nullable(2)]
		public new MoraleBuffViewParams OpenParam
		{
			[NullableContext(2)]
			get
			{
				return this.OpenParam as MoraleBuffViewParams;
			}
		}

		// Token: 0x0602BB23 RID: 178979 RVA: 0x00C43927 File Offset: 0x00C41B27
		public MoraleBuffView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602BB24 RID: 178980 RVA: 0x00C43954 File Offset: 0x00C41B54
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
				new ValueTuple<int, Type>(17, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(9, new Action(this.OnButtonBuffDetail))
			};
		}

		// Token: 0x0602BB25 RID: 178981 RVA: 0x00C43B28 File Offset: 0x00C41D28
		private void InitDataParam()
		{
			this.BuffDataList = new List<MoraleBuffData>(MoraleModel.Instance.BuffList);
			MoraleBuffData moraleBuffData = null;
			foreach (MoraleBuffData moraleBuffData2 in this.BuffDataList)
			{
				int id = moraleBuffData2.Id;
				MoraleBuffViewParams openParam = this.OpenParam;
				int? num = (openParam != null) ? openParam.BuffId : null;
				if (id == num.GetValueOrDefault() & num != null)
				{
					moraleBuffData = moraleBuffData2;
					break;
				}
			}
			this.SelectBuff = (moraleBuffData ?? MoraleModel.Instance.GetStageBuffData());
			this.SetSelectBuff(this.SelectBuff);
		}

		// Token: 0x0602BB26 RID: 178982 RVA: 0x00C43BE8 File Offset: 0x00C41DE8
		protected override UniTask OnBeforeStartAsync()
		{
			MoraleBuffView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MoraleBuffView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602BB27 RID: 178983 RVA: 0x00C43C2C File Offset: 0x00C41E2C
		private UniTask InitBuffList()
		{
			MoraleBuffView.<InitBuffList>d__16 <InitBuffList>d__;
			<InitBuffList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBuffList>d__.<>4__this = this;
			<InitBuffList>d__.<>1__state = -1;
			<InitBuffList>d__.<>t__builder.Start<MoraleBuffView.<InitBuffList>d__16>(ref <InitBuffList>d__);
			return <InitBuffList>d__.<>t__builder.Task;
		}

		// Token: 0x0602BB28 RID: 178984 RVA: 0x00C43C6F File Offset: 0x00C41E6F
		protected override void OnAddEventListener()
		{
		}

		// Token: 0x0602BB29 RID: 178985 RVA: 0x00C43C71 File Offset: 0x00C41E71
		protected override void OnRemoveEventListener()
		{
		}

		// Token: 0x0602BB2A RID: 178986 RVA: 0x00C43C74 File Offset: 0x00C41E74
		protected override void OnBeforeShow()
		{
			this.UpdateData();
			UUIScrollViewWithScrollbarComponent scroll = base.GetScrollViewWithScrollbar(13);
			scroll.OnLateUpdate.Bind(delegate(float _)
			{
				TimerSystem.Instance.Next(new TTimerAction(this.UpdateProgressAndJump), null, null);
				scroll.OnLateUpdate.Unbind();
			});
		}

		// Token: 0x0602BB2B RID: 178987 RVA: 0x00C43CC0 File Offset: 0x00C41EC0
		protected void UpdateProgressAndJump(float _)
		{
			if (base.IsDestroyOrDestroying)
			{
				return;
			}
			this.UpdateLvProgress(null, null);
			this.UpdateScrollJumpPos();
		}

		// Token: 0x0602BB2C RID: 178988 RVA: 0x00C43CF4 File Offset: 0x00C41EF4
		private void UpdateData()
		{
			foreach (MoraleBuffItem moraleBuffItem in this.BuffItemList)
			{
				moraleBuffItem.UpdateData();
			}
			if (this.SelectBuff != null)
			{
				this.BuffInfoPanel.UpdateData(this.SelectBuff);
			}
			this.MoraleLvPanel.UpdateData();
			this.UnbreakableLvPanel.UpdateData();
			List<MoraleBuffData> buffList = MoraleModel.Instance.BuffList;
			int num = 0;
			using (List<MoraleBuffData>.Enumerator enumerator2 = buffList.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					if (enumerator2.Current.IsActiveOrTempActive())
					{
						num++;
					}
				}
			}
			UUIArtText artText = base.GetArtText(7);
			if (artText != null)
			{
				artText.SetText(num.ToString());
			}
			UUIArtText artText2 = base.GetArtText(8);
			if (artText2 != null)
			{
				artText2.SetText(buffList.Count.ToString());
			}
			this.UpdateLvProgress(null, null);
			this.UpdateExpAddDesc();
			this.UpdateAreaBuffRedDot();
		}

		// Token: 0x0602BB2D RID: 178989 RVA: 0x00C43E20 File Offset: 0x00C42020
		public void UpdateScrollJumpPos()
		{
			if (this.SelectBuff == null)
			{
				return;
			}
			int num = Math.Max(0, this.SelectBuff.Index - 2);
			MoraleBuffItem moraleBuffItem = (num < this.BuffItemList.Count) ? this.BuffItemList[num] : null;
			if (moraleBuffItem == null)
			{
				return;
			}
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(13);
			FVector relativeLocation = scrollViewWithScrollbar.ContentUIItem.Get().RelativeLocation;
			FVector2D fvector2D = new FVector2D(ref relativeLocation);
			scrollViewWithScrollbar.ScrollToLeft(ref fvector2D, moraleBuffItem.GetRootItem(), false);
		}

		// Token: 0x0602BB2E RID: 178990 RVA: 0x00C43EA2 File Offset: 0x00C420A2
		private void SetSelectBuff(MoraleBuffData buff)
		{
			this.SelectBuff = buff;
			this.UpdateSelectBuffState();
		}

		// Token: 0x0602BB2F RID: 178991 RVA: 0x00C43EB4 File Offset: 0x00C420B4
		private void UpdateSelectBuffState()
		{
			foreach (MoraleBuffData moraleBuffData in this.BuffDataList)
			{
				int id = moraleBuffData.Id;
				MoraleBuffData selectBuff = this.SelectBuff;
				int? num = (selectBuff != null) ? new int?(selectBuff.Id) : null;
				moraleBuffData.SetSelectState(id == num.GetValueOrDefault() & num != null);
			}
		}

		// Token: 0x0602BB30 RID: 178992 RVA: 0x00C43F3C File Offset: 0x00C4213C
		private void OnButtonBuffDetail()
		{
			this.RoleAttrAddPanel.SetActive(true);
		}

		// Token: 0x0602BB31 RID: 178993 RVA: 0x00C43F4C File Offset: 0x00C4214C
		private void OnClickBuff(MoraleBuffData buff)
		{
			this.SetSelectBuff(buff);
			this.BuffInfoPanel.UpdateData(buff);
			foreach (MoraleBuffItem moraleBuffItem in this.BuffItemList)
			{
				moraleBuffItem.UpdateToggleState();
			}
		}

		// Token: 0x0602BB32 RID: 178994 RVA: 0x00C43FB0 File Offset: 0x00C421B0
		private void OnBtnClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602BB33 RID: 178995 RVA: 0x00C43FBC File Offset: 0x00C421BC
		public void UpdateLvProgress(int? moraleLv = null, int? tempMoraleLv = null)
		{
			UUISprite sprite = base.GetSprite(2);
			float num = (sprite != null) ? sprite.GetWidth() : 0f;
			if (num <= 0f)
			{
				return;
			}
			int num2 = moraleLv ?? MoraleBattleModel.Instance.GetMoraleLevel();
			float lvProgress = this.GetLvProgress(num2);
			if (sprite != null)
			{
				sprite.SetFillAmount(lvProgress);
			}
			if (sprite != null)
			{
				sprite.SetUIActive(true);
			}
			int num3 = tempMoraleLv ?? MoraleBattleModel.Instance.GetTempMoraleLevel();
			bool flag = num3 > 0 || lvProgress < 1f;
			UUISprite sprite2 = base.GetSprite(3);
			if (sprite2 != null)
			{
				sprite2.SetUIActive(flag);
			}
			if (!flag)
			{
				return;
			}
			float stretchLeft = num * lvProgress;
			if (sprite2 != null)
			{
				sprite2.SetStretchLeft(stretchLeft);
			}
			int lv = num2 + num3;
			float lvProgress2 = this.GetLvProgress(lv);
			float num4 = 1f - lvProgress2;
			float stretchRight = num * num4;
			if (sprite2 != null)
			{
				sprite2.SetStretchRight(stretchRight);
			}
		}

		// Token: 0x0602BB34 RID: 178996 RVA: 0x00C440B4 File Offset: 0x00C422B4
		public float GetLvProgress(int lv)
		{
			int num = this.BuffItemList.Count * 2 - 1;
			MoraleBuffData stageBuffDataByLv = MoraleModel.Instance.GetStageBuffDataByLv(lv);
			int num2 = Math.Max(stageBuffDataByLv.StartStageLv - 1, 0);
			int num3 = (stageBuffDataByLv.Index > 0) ? 2 : 1;
			float num4 = (float)(lv - num2) / (float)(stageBuffDataByLv.EndStageLv - num2) * (float)num3;
			return ((float)Math.Max(stageBuffDataByLv.Index * 2 - 1, 0) + num4) / (float)num;
		}

		// Token: 0x0602BB35 RID: 178997 RVA: 0x00C44128 File Offset: 0x00C42328
		public void UpdateExpAddDesc()
		{
			UUIText text = base.GetText(16);
			float num = (float)MoraleBattleModel.Instance.GetExpRatio() / 100f;
			bool flag = num > 100f;
			if (text != null)
			{
				text.SetUIActive(flag);
			}
			if (flag)
			{
				LguiUtil.Instance.SetLocalTextNew(text, "Morale_title_37", new <>z__ReadOnlySingleElementList<object>(num.ToString()));
			}
		}

		// Token: 0x0602BB36 RID: 178998 RVA: 0x00C44184 File Offset: 0x00C42384
		public void UpdateAreaBuffRedDot()
		{
			bool uiactive = MoraleModel.Instance.RedDotAreaBuff();
			UUIItem item = base.GetItem(17);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(uiactive);
		}

		// Token: 0x0602BB37 RID: 178999 RVA: 0x00C441AF File Offset: 0x00C423AF
		private void OnCloseRoleAttrAddPanel()
		{
			MoraleModel.Instance.ClearNewActiveAreaBuff();
			this.UpdateAreaBuffRedDot();
		}

		// Token: 0x040178FB RID: 96507
		public PopupCaptionItem PopupCaption;

		// Token: 0x040178FC RID: 96508
		public MoraleBuffInfoPanel BuffInfoPanel;

		// Token: 0x040178FD RID: 96509
		public List<MoraleBuffItem> BuffItemList = new List<MoraleBuffItem>();

		// Token: 0x040178FE RID: 96510
		public Dictionary<int, MoraleBuffItem> BuffItemMap = new Dictionary<int, MoraleBuffItem>();

		// Token: 0x040178FF RID: 96511
		public MoraleLvInfoItem MoraleLvPanel;

		// Token: 0x04017900 RID: 96512
		public MoraleUnbreakableLvInfoItem UnbreakableLvPanel;

		// Token: 0x04017901 RID: 96513
		[Nullable(2)]
		public MoraleBuffData SelectBuff;

		// Token: 0x04017902 RID: 96514
		public List<MoraleBuffData> BuffDataList = new List<MoraleBuffData>();

		// Token: 0x04017903 RID: 96515
		public MoraleBuffAddPanel RoleAttrAddPanel;

		// Token: 0x0200A07B RID: 41083
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04031DC4 RID: 204228
			public const int ItemCaption = 0;

			// Token: 0x04031DC5 RID: 204229
			public const int ItemInfo = 1;

			// Token: 0x04031DC6 RID: 204230
			public const int SpriteMoraleLvProgress = 2;

			// Token: 0x04031DC7 RID: 204231
			public const int SpriteTempMoraleLvProgress = 3;

			// Token: 0x04031DC8 RID: 204232
			public const int ItemBuffRoot = 4;

			// Token: 0x04031DC9 RID: 204233
			public const int ItemBuffTemplateDown = 5;

			// Token: 0x04031DCA RID: 204234
			public const int ItemBuffTemplateUp = 6;

			// Token: 0x04031DCB RID: 204235
			public const int ArtTextCurrentProgress = 7;

			// Token: 0x04031DCC RID: 204236
			public const int ArtTextTotalProgress = 8;

			// Token: 0x04031DCD RID: 204237
			public const int ButtonBuffDetail = 9;

			// Token: 0x04031DCE RID: 204238
			public const int ItemUnbreakableLv = 10;

			// Token: 0x04031DCF RID: 204239
			public const int ItemMoraleLv = 11;

			// Token: 0x04031DD0 RID: 204240
			public const int ItemBuffDetailPos = 12;

			// Token: 0x04031DD1 RID: 204241
			public const int ScrollBuff = 13;

			// Token: 0x04031DD2 RID: 204242
			public const int TextLvAddDesc = 14;

			// Token: 0x04031DD3 RID: 204243
			public const int ItemRoleAttrAdd = 15;

			// Token: 0x04031DD4 RID: 204244
			public const int TextExpAddDesc = 16;

			// Token: 0x04031DD5 RID: 204245
			public const int ItemAreaBuffRedDot = 17;
		}
	}
}
