using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.MapRogue;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003EC5 RID: 16069
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueBattleRoleStarUpView : UiViewBase
	{
		// Token: 0x06028C34 RID: 166964 RVA: 0x00B6F899 File Offset: 0x00B6DA99
		public RogueBattleRoleStarUpView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06028C35 RID: 166965 RVA: 0x00B6F8A4 File Offset: 0x00B6DAA4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUITexture)),
				new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(6, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(7, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(4, new Action(this.OnBtnConfirm)),
				new ValueTuple<int, Delegate>(5, new Action(this.OnBtnRoleDetail))
			};
		}

		// Token: 0x06028C36 RID: 166966 RVA: 0x00B6F9A8 File Offset: 0x00B6DBA8
		protected override UniTask OnBeforeStartAsync()
		{
			RogueBattleRoleStarUpView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueBattleRoleStarUpView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06028C37 RID: 166967 RVA: 0x00B6F9EB File Offset: 0x00B6DBEB
		protected override void OnAfterShow()
		{
			GenericScrollViewNew<RogueBattleFetterUpItem, IRogueBattleRoleBondUpdateInfo> fetterScrollView = this.FetterScrollView;
			if (fetterScrollView == null)
			{
				return;
			}
			fetterScrollView.GetScrollItemList().ForEach(delegate(RogueBattleFetterUpItem item)
			{
				item.PlayExpAnimation();
			});
		}

		// Token: 0x06028C38 RID: 166968 RVA: 0x00B6FA21 File Offset: 0x00B6DC21
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		}

		// Token: 0x06028C39 RID: 166969 RVA: 0x00B6FA3F File Offset: 0x00B6DC3F
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		}

		// Token: 0x06028C3A RID: 166970 RVA: 0x00B6FA60 File Offset: 0x00B6DC60
		private unsafe void OnBtnRoleDetail()
		{
			int parentId = (MapRogueModel.Instance.GetOpData((int)this.OpenParam) as MapRogueOpRoleBuffBondLinkId).Data.RollBuffBondLinkIdOp.RoleBondInfoView.ParentId;
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

		// Token: 0x06028C3B RID: 166971 RVA: 0x00B6FAFB File Offset: 0x00B6DCFB
		private void OnActivitySequenceEmitEvent(string param)
		{
			if (param == "Enter")
			{
				GenericScrollViewNew<RogueBattleFetterUpItem, IRogueBattleRoleBondUpdateInfo> fetterScrollView = this.FetterScrollView;
				if (fetterScrollView != null)
				{
					fetterScrollView.PlayTurnAnimation();
				}
				this.RefreshStar();
			}
		}

		// Token: 0x06028C3C RID: 166972 RVA: 0x00B6FB21 File Offset: 0x00B6DD21
		private void OnBtnConfirm()
		{
			MapRogueModel.Instance.ExecuteOpData((int)this.OpenParam, null);
		}

		// Token: 0x06028C3D RID: 166973 RVA: 0x00B6FB3C File Offset: 0x00B6DD3C
		protected List<IRogueBattleRoleBondUpdateInfo> BuildFetterData()
		{
			List<IRogueBattleRoleBondUpdateInfo> list = new List<IRogueBattleRoleBondUpdateInfo>();
			RoleBondInfoView roleBondInfoView = MapRogueModel.Instance.GetOpData((int)this.OpenParam).Data.RollBuffBondLinkIdOp.RoleBondInfoView;
			RogueResBondRole? rogueResBondRole = RogueBattleConfig.Instance.GetRogueResBondRole(roleBondInfoView.ParentId);
			int num = roleBondInfoView.NewStar - roleBondInfoView.OldStar;
			foreach (int num2 in rogueResBondRole.Value.BondIdsIter())
			{
				RoleBondInfo roleBondInfo = null;
				foreach (RoleBondInfo roleBondInfo2 in roleBondInfoView.OldRoleBondInfos)
				{
					if (roleBondInfo2.ConfigId == num2)
					{
						roleBondInfo = roleBondInfo2;
						break;
					}
				}
				if (roleBondInfo == null)
				{
					roleBondInfo = RogueBattleModel.Instance.GetRoleBondDataById(num2);
				}
				RoleBondInfo roleBondPreviewDataById = RogueBattleModel.Instance.GetRoleBondPreviewDataById(roleBondInfo.ConfigId, num, new int?(roleBondInfo.Level), new int?(roleBondInfo.CurStar));
				RogueBattleRoleBondUpdateInfo item = new RogueBattleRoleBondUpdateInfo
				{
					OldRoleBondInfo = roleBondInfo,
					NewRoleBondInfo = roleBondPreviewDataById,
					AddStar = num
				};
				list.Add(item);
			}
			List<IRogueBattleRoleBondUpdateInfo> list2 = list;
			Comparison<IRogueBattleRoleBondUpdateInfo> comparison;
			if ((comparison = RogueBattleRoleStarUpView.<>O.<0>__SortRogueBattleRoleBondUpdateInfo) == null)
			{
				comparison = (RogueBattleRoleStarUpView.<>O.<0>__SortRogueBattleRoleBondUpdateInfo = new Comparison<IRogueBattleRoleBondUpdateInfo>(RogueBattleDefine.SortRogueBattleRoleBondUpdateInfo));
			}
			list2.Sort(comparison);
			return list;
		}

		// Token: 0x06028C3E RID: 166974 RVA: 0x00B6FCB8 File Offset: 0x00B6DEB8
		public void RefreshStar()
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

		// Token: 0x040162CA RID: 90826
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<RogueBattleFetterUpItem, IRogueBattleRoleBondUpdateInfo> FetterScrollView;

		// Token: 0x040162CB RID: 90827
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<RogueBattleRoleStarItem, ERogueRoleStarState> StarLayout;

		// Token: 0x02009A72 RID: 39538
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04030218 RID: 197144
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Comparison<IRogueBattleRoleBondUpdateInfo> <0>__SortRogueBattleRoleBondUpdateInfo;
		}
	}
}
