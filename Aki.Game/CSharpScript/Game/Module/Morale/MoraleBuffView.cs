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
	// Token: 0x020053AF RID: 21423
	[NullableContext(1)]
	[Nullable(0)]
	public class MoraleBuffView : UiViewBase
	{
		// Token: 0x170083B2 RID: 33714
		// (get) Token: 0x06036BDC RID: 224220 RVA: 0x00CF4872 File Offset: 0x00CF2A72
		[Nullable(2)]
		public new MoraleBuffViewParams OpenParam
		{
			[NullableContext(2)]
			get
			{
				return this.OpenParam as MoraleBuffViewParams;
			}
		}

		// Token: 0x06036BDD RID: 224221 RVA: 0x00CF487F File Offset: 0x00CF2A7F
		public MoraleBuffView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06036BDE RID: 224222 RVA: 0x00CF48AC File Offset: 0x00CF2AAC
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

		// Token: 0x06036BDF RID: 224223 RVA: 0x00CF4A80 File Offset: 0x00CF2C80
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

		// Token: 0x06036BE0 RID: 224224 RVA: 0x00CF4B40 File Offset: 0x00CF2D40
		protected override UniTask OnBeforeStartAsync()
		{
			MoraleBuffView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MoraleBuffView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036BE1 RID: 224225 RVA: 0x00CF4B84 File Offset: 0x00CF2D84
		private UniTask InitBuffList()
		{
			MoraleBuffView.<InitBuffList>d__16 <InitBuffList>d__;
			<InitBuffList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBuffList>d__.<>4__this = this;
			<InitBuffList>d__.<>1__state = -1;
			<InitBuffList>d__.<>t__builder.Start<MoraleBuffView.<InitBuffList>d__16>(ref <InitBuffList>d__);
			return <InitBuffList>d__.<>t__builder.Task;
		}

		// Token: 0x06036BE2 RID: 224226 RVA: 0x00CF4BC7 File Offset: 0x00CF2DC7
		protected override void OnAddEventListener()
		{
		}

		// Token: 0x06036BE3 RID: 224227 RVA: 0x00CF4BC9 File Offset: 0x00CF2DC9
		protected override void OnRemoveEventListener()
		{
		}

		// Token: 0x06036BE4 RID: 224228 RVA: 0x00CF4BCC File Offset: 0x00CF2DCC
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

		// Token: 0x06036BE5 RID: 224229 RVA: 0x00CF4C18 File Offset: 0x00CF2E18
		protected void UpdateProgressAndJump(float _)
		{
			if (base.IsDestroyOrDestroying)
			{
				return;
			}
			this.UpdateLvProgress(null, null);
			this.UpdateScrollJumpPos();
		}

		// Token: 0x06036BE6 RID: 224230 RVA: 0x00CF4C4C File Offset: 0x00CF2E4C
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

		// Token: 0x06036BE7 RID: 224231 RVA: 0x00CF4D78 File Offset: 0x00CF2F78
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

		// Token: 0x06036BE8 RID: 224232 RVA: 0x00CF4DFA File Offset: 0x00CF2FFA
		private void SetSelectBuff(MoraleBuffData buff)
		{
			this.SelectBuff = buff;
			this.UpdateSelectBuffState();
		}

		// Token: 0x06036BE9 RID: 224233 RVA: 0x00CF4E0C File Offset: 0x00CF300C
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

		// Token: 0x06036BEA RID: 224234 RVA: 0x00CF4E94 File Offset: 0x00CF3094
		private void OnButtonBuffDetail()
		{
			this.RoleAttrAddPanel.SetActive(true);
		}

		// Token: 0x06036BEB RID: 224235 RVA: 0x00CF4EA4 File Offset: 0x00CF30A4
		private void OnClickBuff(MoraleBuffData buff)
		{
			this.SetSelectBuff(buff);
			this.BuffInfoPanel.UpdateData(buff);
			foreach (MoraleBuffItem moraleBuffItem in this.BuffItemList)
			{
				moraleBuffItem.UpdateToggleState();
			}
		}

		// Token: 0x06036BEC RID: 224236 RVA: 0x00CF4F08 File Offset: 0x00CF3108
		private void OnBtnClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x06036BED RID: 224237 RVA: 0x00CF4F14 File Offset: 0x00CF3114
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

		// Token: 0x06036BEE RID: 224238 RVA: 0x00CF500C File Offset: 0x00CF320C
		public float GetLvProgress(int lv)
		{
			int num = this.BuffItemList.Count * 2 - 1;
			MoraleBuffData stageBuffDataByLv = MoraleModel.Instance.GetStageBuffDataByLv(lv);
			int num2 = Math.Max(stageBuffDataByLv.StartStageLv - 1, 0);
			int num3 = (stageBuffDataByLv.Index > 0) ? 2 : 1;
			float num4 = (float)(lv - num2) / (float)(stageBuffDataByLv.EndStageLv - num2) * (float)num3;
			return ((float)Math.Max(stageBuffDataByLv.Index * 2 - 1, 0) + num4) / (float)num;
		}

		// Token: 0x06036BEF RID: 224239 RVA: 0x00CF5080 File Offset: 0x00CF3280
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

		// Token: 0x06036BF0 RID: 224240 RVA: 0x00CF50DC File Offset: 0x00CF32DC
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

		// Token: 0x06036BF1 RID: 224241 RVA: 0x00CF5107 File Offset: 0x00CF3307
		private void OnCloseRoleAttrAddPanel()
		{
			MoraleModel.Instance.ClearNewActiveAreaBuff();
			this.UpdateAreaBuffRedDot();
		}

		// Token: 0x0401CE63 RID: 118371
		public PopupCaptionItem PopupCaption;

		// Token: 0x0401CE64 RID: 118372
		public MoraleBuffInfoPanel BuffInfoPanel;

		// Token: 0x0401CE65 RID: 118373
		public List<MoraleBuffItem> BuffItemList = new List<MoraleBuffItem>();

		// Token: 0x0401CE66 RID: 118374
		public Dictionary<int, MoraleBuffItem> BuffItemMap = new Dictionary<int, MoraleBuffItem>();

		// Token: 0x0401CE67 RID: 118375
		public MoraleLvInfoItem MoraleLvPanel;

		// Token: 0x0401CE68 RID: 118376
		public MoraleUnbreakableLvInfoItem UnbreakableLvPanel;

		// Token: 0x0401CE69 RID: 118377
		[Nullable(2)]
		public MoraleBuffData SelectBuff;

		// Token: 0x0401CE6A RID: 118378
		public List<MoraleBuffData> BuffDataList = new List<MoraleBuffData>();

		// Token: 0x0401CE6B RID: 118379
		public MoraleBuffAddPanel RoleAttrAddPanel;

		// Token: 0x0200B643 RID: 46659
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x0403736F RID: 226159
			public const int ItemCaption = 0;

			// Token: 0x04037370 RID: 226160
			public const int ItemInfo = 1;

			// Token: 0x04037371 RID: 226161
			public const int SpriteMoraleLvProgress = 2;

			// Token: 0x04037372 RID: 226162
			public const int SpriteTempMoraleLvProgress = 3;

			// Token: 0x04037373 RID: 226163
			public const int ItemBuffRoot = 4;

			// Token: 0x04037374 RID: 226164
			public const int ItemBuffTemplateDown = 5;

			// Token: 0x04037375 RID: 226165
			public const int ItemBuffTemplateUp = 6;

			// Token: 0x04037376 RID: 226166
			public const int ArtTextCurrentProgress = 7;

			// Token: 0x04037377 RID: 226167
			public const int ArtTextTotalProgress = 8;

			// Token: 0x04037378 RID: 226168
			public const int ButtonBuffDetail = 9;

			// Token: 0x04037379 RID: 226169
			public const int ItemUnbreakableLv = 10;

			// Token: 0x0403737A RID: 226170
			public const int ItemMoraleLv = 11;

			// Token: 0x0403737B RID: 226171
			public const int ItemBuffDetailPos = 12;

			// Token: 0x0403737C RID: 226172
			public const int ScrollBuff = 13;

			// Token: 0x0403737D RID: 226173
			public const int TextLvAddDesc = 14;

			// Token: 0x0403737E RID: 226174
			public const int ItemRoleAttrAdd = 15;

			// Token: 0x0403737F RID: 226175
			public const int TextExpAddDesc = 16;

			// Token: 0x04037380 RID: 226176
			public const int ItemAreaBuffRedDot = 17;
		}
	}
}
