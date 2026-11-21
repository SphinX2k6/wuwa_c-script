using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.MapRogue;
using CSharpScript.Game.Module.Roguelike;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003EC3 RID: 16067
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueBattleRoleBuffSelectView : UiViewBase
	{
		// Token: 0x06028C24 RID: 166948 RVA: 0x00B6F338 File Offset: 0x00B6D538
		public RogueBattleRoleBuffSelectView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06028C25 RID: 166949 RVA: 0x00B6F344 File Offset: 0x00B6D544
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUITexture)),
				new ValueTuple<int, Type>(2, typeof(UUIVerticalLayout)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(6, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(7, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(8, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(4, new Action(this.OnBtnConfirm)),
				new ValueTuple<int, Delegate>(5, new Action(this.OnBtnDetail))
			};
		}

		// Token: 0x06028C26 RID: 166950 RVA: 0x00B6F460 File Offset: 0x00B6D660
		private void OnBtnConfirm()
		{
			int incId = (int)this.OpenParam;
			((MapRogueOpRoleBuffBondLinkId)MapRogueModel.Instance.GetOpData(incId)).Select(this.BuffLayout.GetSelectedGridIndex());
			MapRogueModel.Instance.ExecuteOpData(incId, null);
		}

		// Token: 0x06028C27 RID: 166951 RVA: 0x00B6F4A8 File Offset: 0x00B6D6A8
		private unsafe void OnBtnDetail()
		{
			int parentId = ((MapRogueOpRoleBuffBondLinkId)MapRogueModel.Instance.GetOpData((int)this.OpenParam)).Data.RollBuffBondLinkIdOp.RoleBondInfoView.ParentId;
			RogueResBondRole? rogueResBondRole = RogueBattleConfig.Instance.GetRogueResBondRole(parentId);
			if (rogueResBondRole != null)
			{
				RoleController instance = RoleController.Instance;
				ERoleAgentType agentType = ERoleAgentType.Preview;
				int selectRoleId = 0;
				int num = 1;
				List<int> list = new List<int>(num);
				CollectionsMarshal.SetCount<int>(list, num);
				Span<int> span = CollectionsMarshal.AsSpan<int>(list);
				int index = 0;
				*span[index] = rogueResBondRole.Value.TrialRoleId;
				instance.OpenRoleMainView(agentType, selectRoleId, list, new EUiTabViewName?(EUiTabViewName.RoleSkillTabView), null);
			}
		}

		// Token: 0x06028C28 RID: 166952 RVA: 0x00B6F544 File Offset: 0x00B6D744
		private void OnSelectBuff(int index)
		{
			if (index == this.BuffLayout.GetSelectedGridIndex())
			{
				GenericLayout<RogueBattleRoleBuffItem, RogueResGainData> buffLayout = this.BuffLayout;
				if (buffLayout != null)
				{
					buffLayout.DeselectCurrentGridProxy();
				}
				base.GetButton(4).SetSelfInteractive(false);
				return;
			}
			GenericLayout<RogueBattleRoleBuffItem, RogueResGainData> buffLayout2 = this.BuffLayout;
			if (buffLayout2 != null)
			{
				buffLayout2.SelectGridProxy(index, false);
			}
			base.GetButton(4).SetSelfInteractive(true);
		}

		// Token: 0x06028C29 RID: 166953 RVA: 0x00B6F5A0 File Offset: 0x00B6D7A0
		private void OnClickDetail(int index)
		{
			MapRogueOpRoleBuffBondLinkId mapRogueOpRoleBuffBondLinkId = (MapRogueOpRoleBuffBondLinkId)MapRogueModel.Instance.GetOpData((int)this.OpenParam);
			IList<RogueResGainData> gainDataList = mapRogueOpRoleBuffBondLinkId.GetGainDataList();
			List<int> list = new List<int>();
			for (int i = 0; i < gainDataList.Count; i++)
			{
				RogueResGainData rogueResGainData = gainDataList[i];
				if (rogueResGainData.RogueResRoleBuff != null)
				{
					list.Add(rogueResGainData.RogueResRoleBuff.ConfigId);
				}
			}
			IRogueBattleRoleAffixDetailOpenParam param = new RogueBattleRoleAffixDetailOpenParam
			{
				Index = index,
				AffixIds = list,
				RoleId = mapRogueOpRoleBuffBondLinkId.Data.RollBuffBondLinkIdOp.RogueResOption.RoleId
			};
			UiManager.Instance.OpenView(EUiViewName.RogueBattleRoleAffixDetailView, param, null);
		}

		// Token: 0x06028C2A RID: 166954 RVA: 0x00B6F64F File Offset: 0x00B6D84F
		private RogueBattleRoleBuffItem CreateItem()
		{
			return new RogueBattleRoleBuffItem
			{
				OnSelectCallback = new Action<int>(this.OnSelectBuff),
				OnClickBtnDetailCallback = new Action<int>(this.OnClickDetail)
			};
		}

		// Token: 0x06028C2B RID: 166955 RVA: 0x00B6F67C File Offset: 0x00B6D87C
		protected override UniTask OnBeforeStartAsync()
		{
			RogueBattleRoleBuffSelectView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueBattleRoleBuffSelectView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06028C2C RID: 166956 RVA: 0x00B6F6BF File Offset: 0x00B6D8BF
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		}

		// Token: 0x06028C2D RID: 166957 RVA: 0x00B6F6DD File Offset: 0x00B6D8DD
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		}

		// Token: 0x06028C2E RID: 166958 RVA: 0x00B6F6FB File Offset: 0x00B6D8FB
		private void OnActivitySequenceEmitEvent(string param)
		{
			if (param == "Enter")
			{
				this.RefreshStar();
			}
		}

		// Token: 0x06028C2F RID: 166959 RVA: 0x00B6F710 File Offset: 0x00B6D910
		private void InitExtendToggle()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(6);
			EToggleState state = (RogueBattleModel.Instance.DescMode == EDescModel.DETAIL) ? EToggleState.ETT_UnChecked : EToggleState.ETT_Checked;
			if (extendToggle != null)
			{
				extendToggle.SetToggleState(state, false, false, false);
			}
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.OnStateChange.Add(new Action<EToggleState>(this.OnExtendToggleStateChange));
		}

		// Token: 0x06028C30 RID: 166960 RVA: 0x00B6F762 File Offset: 0x00B6D962
		private void OnExtendToggleStateChange(EToggleState _)
		{
			RogueBattleModel.Instance.ChangeDescMode();
		}

		// Token: 0x06028C31 RID: 166961 RVA: 0x00B6F770 File Offset: 0x00B6D970
		private void RefreshStar()
		{
			RoleBondInfoView roleBondInfoView = MapRogueModel.Instance.GetOpData((int)this.OpenParam).Data.RollBuffBondLinkIdOp.RoleBondInfoView;
			int maxRoleStar = RogueBattleModel.Instance.MaxRoleStar;
			int oldStar = roleBondInfoView.OldStar;
			int newStar = roleBondInfoView.NewStar;
			List<ERogueRoleStarState> list = new List<ERogueRoleStarState>();
			for (int i = 0; i < maxRoleStar; i++)
			{
				if (i < newStar)
				{
					if (i >= oldStar)
					{
						list.Add(ERogueRoleStarState.LightOn);
					}
					else
					{
						list.Add(ERogueRoleStarState.Active);
					}
				}
				else
				{
					list.Add(ERogueRoleStarState.InActive);
				}
			}
			this.StarLayout.RefreshByData(list, null, true);
		}

		// Token: 0x06028C32 RID: 166962 RVA: 0x00B6F800 File Offset: 0x00B6DA00
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams.Length == 0)
			{
				return null;
			}
			GenericLayout<RogueBattleRoleBuffItem, RogueResGainData> buffLayout = this.BuffLayout;
			RogueBattleRoleBuffItem rogueBattleRoleBuffItem = (buffLayout != null) ? buffLayout.GetLayoutItemByIndex(0) : null;
			if (rogueBattleRoleBuffItem == null)
			{
				return null;
			}
			return rogueBattleRoleBuffItem.GetGuideUiItemAndUiItemForShowEx(configParams);
		}

		// Token: 0x040162BE RID: 90814
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RogueBattleRoleBuffItem, RogueResGainData> BuffLayout;

		// Token: 0x040162BF RID: 90815
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<RogueBattleRoleStarItem, ERogueRoleStarState> StarLayout;

		// Token: 0x040162C0 RID: 90816
		[Nullable(2)]
		private RogueBattleTopPanel TopPanel;
	}
}
