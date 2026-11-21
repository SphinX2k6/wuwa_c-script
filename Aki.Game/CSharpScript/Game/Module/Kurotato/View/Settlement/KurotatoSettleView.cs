using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Game.Module.Activity.ActivityContent.Encircle;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Kurotato.Data;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Settlement
{
	// Token: 0x02004707 RID: 18183
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoSettleView : UiViewBase
	{
		// Token: 0x0602DAE6 RID: 187110 RVA: 0x00CC5DEC File Offset: 0x00CC3FEC
		public KurotatoSettleView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0602DAE7 RID: 187111 RVA: 0x00CC5E3C File Offset: 0x00CC403C
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

		// Token: 0x0602DAE8 RID: 187112 RVA: 0x00CC60FD File Offset: 0x00CC42FD
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnFirstShare, new Action(this.OnFirstShare));
		}

		// Token: 0x0602DAE9 RID: 187113 RVA: 0x00CC611B File Offset: 0x00CC431B
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnFirstShare, new Action(this.OnFirstShare));
		}

		// Token: 0x0602DAEA RID: 187114 RVA: 0x00CC613C File Offset: 0x00CC433C
		protected override UniTask OnBeforeStartAsync()
		{
			KurotatoSettleView.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoSettleView.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602DAEB RID: 187115 RVA: 0x00CC6180 File Offset: 0x00CC4380
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

		// Token: 0x0602DAEC RID: 187116 RVA: 0x00CC62D8 File Offset: 0x00CC44D8
		private UniTask CreateRightPanelAsync()
		{
			KurotatoSettleView.<CreateRightPanelAsync>d__18 <CreateRightPanelAsync>d__;
			<CreateRightPanelAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateRightPanelAsync>d__.<>4__this = this;
			<CreateRightPanelAsync>d__.<>1__state = -1;
			<CreateRightPanelAsync>d__.<>t__builder.Start<KurotatoSettleView.<CreateRightPanelAsync>d__18>(ref <CreateRightPanelAsync>d__);
			return <CreateRightPanelAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602DAED RID: 187117 RVA: 0x00CC631C File Offset: 0x00CC451C
		private UniTask CreateBtnNextPageAsync()
		{
			KurotatoSettleView.<CreateBtnNextPageAsync>d__19 <CreateBtnNextPageAsync>d__;
			<CreateBtnNextPageAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateBtnNextPageAsync>d__.<>4__this = this;
			<CreateBtnNextPageAsync>d__.<>1__state = -1;
			<CreateBtnNextPageAsync>d__.<>t__builder.Start<KurotatoSettleView.<CreateBtnNextPageAsync>d__19>(ref <CreateBtnNextPageAsync>d__);
			return <CreateBtnNextPageAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602DAEE RID: 187118 RVA: 0x00CC6360 File Offset: 0x00CC4560
		private UniTask CreateBtnExitAsync()
		{
			KurotatoSettleView.<CreateBtnExitAsync>d__20 <CreateBtnExitAsync>d__;
			<CreateBtnExitAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateBtnExitAsync>d__.<>4__this = this;
			<CreateBtnExitAsync>d__.<>1__state = -1;
			<CreateBtnExitAsync>d__.<>t__builder.Start<KurotatoSettleView.<CreateBtnExitAsync>d__20>(ref <CreateBtnExitAsync>d__);
			return <CreateBtnExitAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602DAEF RID: 187119 RVA: 0x00CC63A4 File Offset: 0x00CC45A4
		private UniTask CreateBtnStartAsync()
		{
			KurotatoSettleView.<CreateBtnStartAsync>d__21 <CreateBtnStartAsync>d__;
			<CreateBtnStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateBtnStartAsync>d__.<>4__this = this;
			<CreateBtnStartAsync>d__.<>1__state = -1;
			<CreateBtnStartAsync>d__.<>t__builder.Start<KurotatoSettleView.<CreateBtnStartAsync>d__21>(ref <CreateBtnStartAsync>d__);
			return <CreateBtnStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602DAF0 RID: 187120 RVA: 0x00CC63E7 File Offset: 0x00CC45E7
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

		// Token: 0x0602DAF1 RID: 187121 RVA: 0x00CC6425 File Offset: 0x00CC4625
		private void CreateAttrLayout()
		{
			this.AttrLayout = new GenericLayout<AttributeItem, IKurotatoRoleSkillInfo>(base.GetGridLayout(5), new Func<AttributeItem>(this.InitAttrItem), null, false, true);
		}

		// Token: 0x0602DAF2 RID: 187122 RVA: 0x00CC6448 File Offset: 0x00CC4648
		private void CreateSkillScrollList()
		{
			this.SkillScrollList = new GenericScrollViewNew<SkillItem, string>(base.GetScrollViewWithScrollbar(8), new Func<SkillItem>(this.InitSkillItem), null, false, null);
		}

		// Token: 0x0602DAF3 RID: 187123 RVA: 0x00CC646B File Offset: 0x00CC466B
		private AttributeItem InitAttrItem()
		{
			return new AttributeItem();
		}

		// Token: 0x0602DAF4 RID: 187124 RVA: 0x00CC6472 File Offset: 0x00CC4672
		private SkillItem InitSkillItem()
		{
			return new SkillItem();
		}

		// Token: 0x0602DAF5 RID: 187125 RVA: 0x00CC647C File Offset: 0x00CC467C
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

		// Token: 0x0602DAF6 RID: 187126 RVA: 0x00CC6574 File Offset: 0x00CC4774
		private void RefreshSkillList()
		{
			int roleId = KurotatoModel.Instance.GetRoleId();
			KurotatoCharacter value = KurotatoConfig.Instance.GetCharacterById(roleId).Value;
			List<string> data = new List<string>
			{
				KurotatoUtil.GetCardDesc(value.Desc, new List<string>(value.DescParamsIter()), 0, 0, false)
			};
			this.SkillScrollList.RefreshByData(data, null, false);
		}

		// Token: 0x0602DAF7 RID: 187127 RVA: 0x00CC65D8 File Offset: 0x00CC47D8
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

		// Token: 0x0602DAF8 RID: 187128 RVA: 0x00CC6709 File Offset: 0x00CC4909
		private void RefreshRoleAttrInfo()
		{
			GenericLayout<AttributeItem, IKurotatoRoleSkillInfo> attrLayout = this.AttrLayout;
			if (attrLayout != null)
			{
				attrLayout.SetActive(!this.IsShowingSkill);
			}
			base.GetItem(7).SetUIActive(this.IsShowingSkill);
		}

		// Token: 0x0602DAF9 RID: 187129 RVA: 0x00CC6737 File Offset: 0x00CC4937
		private void RefreshTitle()
		{
			if (this.PageState == EKurotatoSettlePageState.Unlock)
			{
				base.GetText(16).ShowTextNew("Kurotato_FinishprefabTilte_GetAll");
				return;
			}
			base.GetText(16).ShowTextNew("Kurotato_FinishprefabTilte_All");
		}

		// Token: 0x0602DAFA RID: 187130 RVA: 0x00CC6768 File Offset: 0x00CC4968
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

		// Token: 0x0602DAFB RID: 187131 RVA: 0x00CC67C0 File Offset: 0x00CC49C0
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

		// Token: 0x0602DAFC RID: 187132 RVA: 0x00CC6870 File Offset: 0x00CC4A70
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

		// Token: 0x0602DAFD RID: 187133 RVA: 0x00CC68BC File Offset: 0x00CC4ABC
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

		// Token: 0x0602DAFE RID: 187134 RVA: 0x00CC693C File Offset: 0x00CC4B3C
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

		// Token: 0x0602DAFF RID: 187135 RVA: 0x00CC6970 File Offset: 0x00CC4B70
		private UniTask OpenShareViewAsync()
		{
			KurotatoSettleView.<OpenShareViewAsync>d__37 <OpenShareViewAsync>d__;
			<OpenShareViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenShareViewAsync>d__.<>4__this = this;
			<OpenShareViewAsync>d__.<>1__state = -1;
			<OpenShareViewAsync>d__.<>t__builder.Start<KurotatoSettleView.<OpenShareViewAsync>d__37>(ref <OpenShareViewAsync>d__);
			return <OpenShareViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602DB00 RID: 187136 RVA: 0x00CC69B3 File Offset: 0x00CC4BB3
		private void OnClickBtnShare()
		{
			this.OpenShareView();
		}

		// Token: 0x0602DB01 RID: 187137 RVA: 0x00CC69BB File Offset: 0x00CC4BBB
		private void OnFirstShare()
		{
			this.RefreshShare();
		}

		// Token: 0x0602DB02 RID: 187138 RVA: 0x00CC69C3 File Offset: 0x00CC4BC3
		private void OnClickBtnSwitch()
		{
			this.IsShowingSkill = !this.IsShowingSkill;
			this.RefreshRoleAttrInfo();
		}

		// Token: 0x040186E5 RID: 100069
		private readonly KurotatoSettleRightPanel RightPanel = new KurotatoSettleRightPanel();

		// Token: 0x040186E6 RID: 100070
		private readonly ButtonItem BtnNextPage = new ButtonItem(null);

		// Token: 0x040186E7 RID: 100071
		private readonly ButtonItem BtnExit = new ButtonItem(null);

		// Token: 0x040186E8 RID: 100072
		private readonly ButtonItem BtnStart = new ButtonItem(null);

		// Token: 0x040186E9 RID: 100073
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<AttributeItem, IKurotatoRoleSkillInfo> AttrLayout;

		// Token: 0x040186EA RID: 100074
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<SkillItem, string> SkillScrollList;

		// Token: 0x040186EB RID: 100075
		private bool IsShowingSkill;

		// Token: 0x040186EC RID: 100076
		private EKurotatoSettlePageState PageState;

		// Token: 0x040186ED RID: 100077
		private int NextLevelId;

		// Token: 0x040186EE RID: 100078
		private string PassTime = "";

		// Token: 0x040186EF RID: 100079
		private bool IsEndlessLevel;

		// Token: 0x0200A31A RID: 41754
		[NullableContext(0)]
		private class EComps
		{
			// Token: 0x04032931 RID: 207153
			public const int SpineRole = 0;

			// Token: 0x04032932 RID: 207154
			public const int BtnShare = 1;

			// Token: 0x04032933 RID: 207155
			public const int TextName = 2;

			// Token: 0x04032934 RID: 207156
			public const int TextLv = 3;

			// Token: 0x04032935 RID: 207157
			public const int BtnSwitch = 4;

			// Token: 0x04032936 RID: 207158
			public const int PanelGrid = 5;

			// Token: 0x04032937 RID: 207159
			public const int PanelAttribute = 6;

			// Token: 0x04032938 RID: 207160
			public const int PanelSkill = 7;

			// Token: 0x04032939 RID: 207161
			public const int ScrollSkill = 8;

			// Token: 0x0403293A RID: 207162
			public const int PanelInfo = 9;

			// Token: 0x0403293B RID: 207163
			public const int PanelRight = 10;

			// Token: 0x0403293C RID: 207164
			public const int PanelBtn = 11;

			// Token: 0x0403293D RID: 207165
			public const int BtnNextPage = 12;

			// Token: 0x0403293E RID: 207166
			public const int BtnExit = 13;

			// Token: 0x0403293F RID: 207167
			public const int BtnStart = 14;

			// Token: 0x04032940 RID: 207168
			public const int ItemFirstShareBubble = 15;

			// Token: 0x04032941 RID: 207169
			public const int TextTittle = 16;
		}
	}
}
