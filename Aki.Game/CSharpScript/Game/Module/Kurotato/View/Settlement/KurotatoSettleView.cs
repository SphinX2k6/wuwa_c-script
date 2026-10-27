using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.Encircle;
using CSharpScript.Game.Module.Kurotato.Data;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Settlement
{
	// Token: 0x02005730 RID: 22320
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoSettleView : UiViewBase
	{
		// Token: 0x06038BD6 RID: 232406 RVA: 0x00D77740 File Offset: 0x00D75940
		public KurotatoSettleView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06038BD7 RID: 232407 RVA: 0x00D77790 File Offset: 0x00D75990
		protected unsafe override void OnRegisterComponent()
		{
			int num = 17;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(USpineSkeletonAnimationComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIGridLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickBtnShare));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickBtnSwitch));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038BD8 RID: 232408 RVA: 0x00D77A51 File Offset: 0x00D75C51
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnFirstShare, new Action(this.OnFirstShare));
		}

		// Token: 0x06038BD9 RID: 232409 RVA: 0x00D77A6F File Offset: 0x00D75C6F
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnFirstShare, new Action(this.OnFirstShare));
		}

		// Token: 0x06038BDA RID: 232410 RVA: 0x00D77A90 File Offset: 0x00D75C90
		protected override UniTask OnBeforeStartAsync()
		{
			KurotatoSettleView.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoSettleView.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038BDB RID: 232411 RVA: 0x00D77AD4 File Offset: 0x00D75CD4
		private void SetupParams()
		{
			IKurotatoSettlementData settlementData = KurotatoModel.Instance.GetSettlementData();
			int? num;
			if (settlementData == null)
			{
				num = null;
			}
			else
			{
				List<int> unlockRoles = settlementData.UnlockRoles;
				num = ((unlockRoles != null) ? new int?(unlockRoles.Count) : null);
			}
			int? num2 = num;
			bool flag;
			if (num2.GetValueOrDefault() <= 0)
			{
				int? num3;
				if (settlementData == null)
				{
					num3 = null;
				}
				else
				{
					List<int> unlockWeapons = settlementData.UnlockWeapons;
					num3 = ((unlockWeapons != null) ? new int?(unlockWeapons.Count) : null);
				}
				num2 = num3;
				if (num2.GetValueOrDefault() <= 0)
				{
					int? num4;
					if (settlementData == null)
					{
						num4 = null;
					}
					else
					{
						List<int> unlockItems = settlementData.UnlockItems;
						num4 = ((unlockItems != null) ? new int?(unlockItems.Count) : null);
					}
					num2 = num4;
					flag = (num2.GetValueOrDefault() > 0);
					goto IL_BF;
				}
			}
			flag = true;
			IL_BF:
			this.PageState = (flag ? EKurotatoSettlePageState.Unlock : EKurotatoSettlePageState.Info);
			int curLevelId = KurotatoModel.Instance.GetCurLevelId();
			KurotatoActivityData activityData = KurotatoActivityController.Instance.GetActivityData();
			this.NextLevelId = ((activityData != null) ? activityData.GetNextLevelId(curLevelId) : 0);
			this.PassTime = TimeUtil.Instance.DateFormat2(DateTimeOffset.FromUnixTimeMilliseconds((long)TimeUtil.Instance.GetServerTimeStamp()).DateTime);
			KurotatoActivityData activityData2 = KurotatoActivityController.Instance.GetActivityData();
			KurotatoLevelData kurotatoLevelData = (activityData2 != null) ? activityData2.GetKurotatoLevelData(curLevelId) : null;
			this.IsEndlessLevel = (kurotatoLevelData != null && kurotatoLevelData.IsEndless);
		}

		// Token: 0x06038BDC RID: 232412 RVA: 0x00D77C2C File Offset: 0x00D75E2C
		private UniTask CreateRightPanelAsync()
		{
			KurotatoSettleView.<CreateRightPanelAsync>d__18 <CreateRightPanelAsync>d__;
			<CreateRightPanelAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateRightPanelAsync>d__.<>4__this = this;
			<CreateRightPanelAsync>d__.<>1__state = -1;
			<CreateRightPanelAsync>d__.<>t__builder.Start<KurotatoSettleView.<CreateRightPanelAsync>d__18>(ref <CreateRightPanelAsync>d__);
			return <CreateRightPanelAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038BDD RID: 232413 RVA: 0x00D77C70 File Offset: 0x00D75E70
		private UniTask CreateBtnNextPageAsync()
		{
			KurotatoSettleView.<CreateBtnNextPageAsync>d__19 <CreateBtnNextPageAsync>d__;
			<CreateBtnNextPageAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateBtnNextPageAsync>d__.<>4__this = this;
			<CreateBtnNextPageAsync>d__.<>1__state = -1;
			<CreateBtnNextPageAsync>d__.<>t__builder.Start<KurotatoSettleView.<CreateBtnNextPageAsync>d__19>(ref <CreateBtnNextPageAsync>d__);
			return <CreateBtnNextPageAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038BDE RID: 232414 RVA: 0x00D77CB4 File Offset: 0x00D75EB4
		private UniTask CreateBtnExitAsync()
		{
			KurotatoSettleView.<CreateBtnExitAsync>d__20 <CreateBtnExitAsync>d__;
			<CreateBtnExitAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateBtnExitAsync>d__.<>4__this = this;
			<CreateBtnExitAsync>d__.<>1__state = -1;
			<CreateBtnExitAsync>d__.<>t__builder.Start<KurotatoSettleView.<CreateBtnExitAsync>d__20>(ref <CreateBtnExitAsync>d__);
			return <CreateBtnExitAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038BDF RID: 232415 RVA: 0x00D77CF8 File Offset: 0x00D75EF8
		private UniTask CreateBtnStartAsync()
		{
			KurotatoSettleView.<CreateBtnStartAsync>d__21 <CreateBtnStartAsync>d__;
			<CreateBtnStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateBtnStartAsync>d__.<>4__this = this;
			<CreateBtnStartAsync>d__.<>1__state = -1;
			<CreateBtnStartAsync>d__.<>t__builder.Start<KurotatoSettleView.<CreateBtnStartAsync>d__21>(ref <CreateBtnStartAsync>d__);
			return <CreateBtnStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038BE0 RID: 232416 RVA: 0x00D77D3B File Offset: 0x00D75F3B
		protected override void OnStart()
		{
			this.CreateAttrLayout();
			this.CreateSkillScrollList();
			this.RefreshTitle();
			this.RefreshRoleInfo();
			this.RefreshAttrList();
			this.RefreshSkillList();
			this.RefreshRoleAttrInfo();
			this.RefreshButtons();
			this.RefreshShare();
			this.PlaySettlementAudio();
		}

		// Token: 0x06038BE1 RID: 232417 RVA: 0x00D77D79 File Offset: 0x00D75F79
		private void CreateAttrLayout()
		{
			this.AttrLayout = new GenericLayout<AttributeItem, IKurotatoRoleSkillInfo>(base.GetGridLayout(5), new Func<AttributeItem>(this.InitAttrItem), null, false, true);
		}

		// Token: 0x06038BE2 RID: 232418 RVA: 0x00D77D9C File Offset: 0x00D75F9C
		private void CreateSkillScrollList()
		{
			this.SkillScrollList = new GenericScrollViewNew<SkillItem, string>(base.GetScrollViewWithScrollbar(8), new Func<SkillItem>(this.InitSkillItem), null, false, null);
		}

		// Token: 0x06038BE3 RID: 232419 RVA: 0x00D77DBF File Offset: 0x00D75FBF
		private AttributeItem InitAttrItem()
		{
			return new AttributeItem();
		}

		// Token: 0x06038BE4 RID: 232420 RVA: 0x00D77DC6 File Offset: 0x00D75FC6
		private SkillItem InitSkillItem()
		{
			return new SkillItem();
		}

		// Token: 0x06038BE5 RID: 232421 RVA: 0x00D77DD0 File Offset: 0x00D75FD0
		private void RefreshAttrList()
		{
			IKurotatoSettlementData settlementData = KurotatoModel.Instance.GetSettlementData();
			Dictionary<int, int> dictionary = (settlementData != null) ? settlementData.PropertyMap : null;
			List<IKurotatoRoleSkillInfo> list = new List<IKurotatoRoleSkillInfo>();
			foreach (KurotatoProperty kurotatoProperty in KurotatoConfig.Instance.GetAllProperty())
			{
				if (kurotatoProperty.RoleType == 1)
				{
					int? num = null;
					int value;
					if (dictionary != null && dictionary.TryGetValue(kurotatoProperty.Id, out value))
					{
						num = new int?(value);
					}
					list.Add(new KurotatoRoleSkillInfo
					{
						AttrId = kurotatoProperty.Id,
						Value = (num ?? KurotatoModel.Instance.GetSystemPropertyValue(kurotatoProperty.Id)),
						IsRecommend = false
					});
				}
			}
			this.AttrLayout.RefreshByData(list, null, false);
		}

		// Token: 0x06038BE6 RID: 232422 RVA: 0x00D77EC8 File Offset: 0x00D760C8
		private void RefreshSkillList()
		{
			int roleId = KurotatoModel.Instance.GetRoleId();
			KurotatoCharacter value = KurotatoConfig.Instance.GetCharacterById(roleId).Value;
			List<string> data = new List<string>
			{
				KurotatoUtil.GetCardDesc(value.Desc, value.DescParamsIter().ToList<string>(), 0, 0, false)
			};
			this.SkillScrollList.RefreshByData(data, null, false);
		}

		// Token: 0x06038BE7 RID: 232423 RVA: 0x00D77F2C File Offset: 0x00D7612C
		private void RefreshRoleInfo()
		{
			int roleId = KurotatoModel.Instance.GetRoleId();
			KurotatoCharacter value = KurotatoConfig.Instance.GetCharacterById(roleId).Value;
			RoleDataBase roleDataByKurotatoRoleId = KurotatoModel.Instance.GetRoleDataByKurotatoRoleId(roleId);
			RoleSkin value2 = SkinConfig.Instance.GetRoleSkinConfig(roleDataByKurotatoRoleId.GetRoleSkinId()).Value;
			USpineSkeletonAnimationComponent roleSpine = base.GetSpine(0);
			UUIItem uuiitem = roleSpine.GetOwner().GetComponentByClass(UUIItem.StaticClass()) as UUIItem;
			float[] spineParamArray = value2.GetSpineParamArray();
			uuiitem.SetAnchorOffsetX(spineParamArray[0]);
			uuiitem.SetAnchorOffsetY(spineParamArray[1]);
			uuiitem.SetUIItemScale(new FVector(spineParamArray[2], spineParamArray[2], spineParamArray[2]));
			base.SetSpineAssetByPath(value2.FormationSpineAtlas, value2.FormationSpineSkeletonData, roleSpine).ContinueWith(delegate()
			{
				roleSpine.SetAnimation(0, ESpineAnimation.Idle.ToEnumString(), true);
			}).Forget();
			base.GetText(2).ShowTextNew(value.Name);
			base.GetText(3).SetText(ConfigMultiTextLang.GetLocalTextNew("Kurotato_Lv", null) + KurotatoModel.Instance.BattleData.GetRoleLevel().ToString(), true);
		}

		// Token: 0x06038BE8 RID: 232424 RVA: 0x00D7805D File Offset: 0x00D7625D
		private void RefreshRoleAttrInfo()
		{
			GenericLayout<AttributeItem, IKurotatoRoleSkillInfo> attrLayout = this.AttrLayout;
			if (attrLayout != null)
			{
				attrLayout.SetActive(!this.IsShowingSkill);
			}
			base.GetItem(7).SetUIActive(this.IsShowingSkill);
		}

		// Token: 0x06038BE9 RID: 232425 RVA: 0x00D7808B File Offset: 0x00D7628B
		private void RefreshTitle()
		{
			if (this.PageState == EKurotatoSettlePageState.Unlock)
			{
				base.GetText(16).ShowTextNew("Kurotato_FinishprefabTilte_GetAll");
				return;
			}
			base.GetText(16).ShowTextNew("Kurotato_FinishprefabTilte_All");
		}

		// Token: 0x06038BEA RID: 232426 RVA: 0x00D780BC File Offset: 0x00D762BC
		private void PlaySettlementAudio()
		{
			if (this.IsEndlessLevel)
			{
				AudioSystem.Instance.PostEvent("play_ui_tudou_settlement_start");
				return;
			}
			IKurotatoSettlementData settlementData = KurotatoModel.Instance.GetSettlementData();
			bool flag = settlementData != null && settlementData.IsPass;
			AudioSystem.Instance.PostEvent(flag ? "play_ui_tudou_settlement_success_start" : "play_ui_tudou_settlement_fail_start");
		}

		// Token: 0x06038BEB RID: 232427 RVA: 0x00D78114 File Offset: 0x00D76314
		private void RefreshButtons()
		{
			this.BtnNextPage.GetRootItem().SetUIActive(this.PageState == EKurotatoSettlePageState.Unlock);
			this.BtnExit.GetRootItem().SetUIActive(this.PageState == EKurotatoSettlePageState.Info);
			this.BtnStart.GetRootItem().SetUIActive(this.PageState == EKurotatoSettlePageState.Info && this.NextLevelId != 0);
			IKurotatoSettlementData settlementData = KurotatoModel.Instance.GetSettlementData();
			if (settlementData != null && settlementData.IsPass && this.NextLevelId != 0)
			{
				this.BtnStart.SetLocalTextNew("PrefabTextItem_2819293743_Text", Array.Empty<object>());
				return;
			}
			this.BtnStart.SetLocalTextNew("Kurotato_finishbutton_back", Array.Empty<object>());
		}

		// Token: 0x06038BEC RID: 232428 RVA: 0x00D781C4 File Offset: 0x00D763C4
		private void RefreshShare()
		{
			UUIButtonComponent button = base.GetButton(1);
			if (button != null)
			{
				UUIItem uuiitem = button.RootUIComp.Get();
				if (uuiitem != null)
				{
					uuiitem.SetUIActive(this.IsEndlessLevel);
				}
			}
			UUIItem item = base.GetItem(15);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x06038BED RID: 232429 RVA: 0x00D78210 File Offset: 0x00D76410
		private void SetShareState(bool isShow)
		{
			UUIButtonComponent button = base.GetButton(1);
			if (button != null)
			{
				UUIItem uuiitem = button.RootUIComp.Get();
				if (uuiitem != null)
				{
					uuiitem.SetUIActive(isShow);
				}
			}
			UUIItem item = base.GetItem(15);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIButtonComponent button2 = base.GetButton(4);
			if (button2 != null)
			{
				UUIItem uuiitem2 = button2.RootUIComp.Get();
				if (uuiitem2 != null)
				{
					uuiitem2.SetUIActive(isShow);
				}
			}
			UUIItem item2 = base.GetItem(11);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(isShow);
		}

		// Token: 0x06038BEE RID: 232430 RVA: 0x00D78290 File Offset: 0x00D76490
		private void OpenShareView()
		{
			UiAsyncTask task = new UiAsyncTask("OpenShareView", delegate()
			{
				KurotatoSettleView.<<OpenShareView>b__36_0>d <<OpenShareView>b__36_0>d;
				<<OpenShareView>b__36_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<OpenShareView>b__36_0>d.<>4__this = this;
				<<OpenShareView>b__36_0>d.<>1__state = -1;
				<<OpenShareView>b__36_0>d.<>t__builder.Start<KurotatoSettleView.<<OpenShareView>b__36_0>d>(ref <<OpenShareView>b__36_0>d);
				return <<OpenShareView>b__36_0>d.<>t__builder.Task;
			}, null);
			base.RunAsyncTask(task).Forget();
		}

		// Token: 0x06038BEF RID: 232431 RVA: 0x00D782C4 File Offset: 0x00D764C4
		private UniTask OpenShareViewAsync()
		{
			KurotatoSettleView.<OpenShareViewAsync>d__37 <OpenShareViewAsync>d__;
			<OpenShareViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenShareViewAsync>d__.<>4__this = this;
			<OpenShareViewAsync>d__.<>1__state = -1;
			<OpenShareViewAsync>d__.<>t__builder.Start<KurotatoSettleView.<OpenShareViewAsync>d__37>(ref <OpenShareViewAsync>d__);
			return <OpenShareViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038BF0 RID: 232432 RVA: 0x00D78307 File Offset: 0x00D76507
		private void OnClickBtnShare()
		{
			this.OpenShareView();
		}

		// Token: 0x06038BF1 RID: 232433 RVA: 0x00D7830F File Offset: 0x00D7650F
		private void OnFirstShare()
		{
			this.RefreshShare();
		}

		// Token: 0x06038BF2 RID: 232434 RVA: 0x00D78317 File Offset: 0x00D76517
		private void OnClickBtnSwitch()
		{
			this.IsShowingSkill = !this.IsShowingSkill;
			this.RefreshRoleAttrInfo();
		}

		// Token: 0x0401DC4F RID: 121935
		private readonly KurotatoSettleRightPanel RightPanel = new KurotatoSettleRightPanel();

		// Token: 0x0401DC50 RID: 121936
		private readonly ButtonItem BtnNextPage = new ButtonItem(null);

		// Token: 0x0401DC51 RID: 121937
		private readonly ButtonItem BtnExit = new ButtonItem(null);

		// Token: 0x0401DC52 RID: 121938
		private readonly ButtonItem BtnStart = new ButtonItem(null);

		// Token: 0x0401DC53 RID: 121939
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<AttributeItem, IKurotatoRoleSkillInfo> AttrLayout;

		// Token: 0x0401DC54 RID: 121940
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<SkillItem, string> SkillScrollList;

		// Token: 0x0401DC55 RID: 121941
		private bool IsShowingSkill;

		// Token: 0x0401DC56 RID: 121942
		private EKurotatoSettlePageState PageState;

		// Token: 0x0401DC57 RID: 121943
		private int NextLevelId;

		// Token: 0x0401DC58 RID: 121944
		private string PassTime = "";

		// Token: 0x0401DC59 RID: 121945
		private bool IsEndlessLevel;

		// Token: 0x0200B8F9 RID: 47353
		[NullableContext(0)]
		private class EComps
		{
			// Token: 0x04037F21 RID: 229153
			public const int SpineRole = 0;

			// Token: 0x04037F22 RID: 229154
			public const int BtnShare = 1;

			// Token: 0x04037F23 RID: 229155
			public const int TextName = 2;

			// Token: 0x04037F24 RID: 229156
			public const int TextLv = 3;

			// Token: 0x04037F25 RID: 229157
			public const int BtnSwitch = 4;

			// Token: 0x04037F26 RID: 229158
			public const int PanelGrid = 5;

			// Token: 0x04037F27 RID: 229159
			public const int PanelAttribute = 6;

			// Token: 0x04037F28 RID: 229160
			public const int PanelSkill = 7;

			// Token: 0x04037F29 RID: 229161
			public const int ScrollSkill = 8;

			// Token: 0x04037F2A RID: 229162
			public const int PanelInfo = 9;

			// Token: 0x04037F2B RID: 229163
			public const int PanelRight = 10;

			// Token: 0x04037F2C RID: 229164
			public const int PanelBtn = 11;

			// Token: 0x04037F2D RID: 229165
			public const int BtnNextPage = 12;

			// Token: 0x04037F2E RID: 229166
			public const int BtnExit = 13;

			// Token: 0x04037F2F RID: 229167
			public const int BtnStart = 14;

			// Token: 0x04037F30 RID: 229168
			public const int ItemFirstShareBubble = 15;

			// Token: 0x04037F31 RID: 229169
			public const int TextTittle = 16;
		}
	}
}
