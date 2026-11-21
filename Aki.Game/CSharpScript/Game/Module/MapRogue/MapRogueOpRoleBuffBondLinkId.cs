using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.RogueBattle;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x02004591 RID: 17809
	[NullableContext(1)]
	[Nullable(0)]
	public class MapRogueOpRoleBuffBondLinkId : MapRogueOp
	{
		// Token: 0x17005A97 RID: 23191
		// (get) Token: 0x0602CE2F RID: 183855 RVA: 0x00C8F46F File Offset: 0x00C8D66F
		// (set) Token: 0x0602CE30 RID: 183856 RVA: 0x00C8F477 File Offset: 0x00C8D677
		public override int StepSize { get; set; } = 2;

		// Token: 0x0602CE31 RID: 183857 RVA: 0x00C8F480 File Offset: 0x00C8D680
		public MapRogueOpRoleBuffBondLinkId()
		{
			this.Priority = ERogueOpPriority.RoleBuff;
		}

		// Token: 0x0602CE32 RID: 183858 RVA: 0x00C8F498 File Offset: 0x00C8D698
		public override string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(39, 5);
			defaultInterpolatedStringHandler.AppendLiteral("[RoleBuff] IncId:");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.IncId);
			defaultInterpolatedStringHandler.AppendLiteral(" Type:");
			RollBuffBondLinkIdOp rollBuffBondLinkIdOp = this.Data.RollBuffBondLinkIdOp;
			RogueResDataType? value;
			if (rollBuffBondLinkIdOp == null)
			{
				value = null;
			}
			else
			{
				RogueResOption rogueResOption = rollBuffBondLinkIdOp.RogueResOption;
				value = ((rogueResOption != null) ? new RogueResDataType?(rogueResOption.RogueResDataType) : null);
			}
			defaultInterpolatedStringHandler.AppendFormatted<RogueResDataType?>(value);
			defaultInterpolatedStringHandler.AppendLiteral(" Cur:");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.CurrentSelectCount);
			defaultInterpolatedStringHandler.AppendLiteral(" Max:");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.MaxSelectCount);
			defaultInterpolatedStringHandler.AppendLiteral(" Lock:");
			defaultInterpolatedStringHandler.AppendFormatted<bool>(this.Lock);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x0602CE33 RID: 183859 RVA: 0x00C8F565 File Offset: 0x00C8D765
		protected override void OnUpdate(MapRogueGameInfo gameInfo)
		{
			Action updateViewFunc = this.UpdateViewFunc;
			if (updateViewFunc != null)
			{
				updateViewFunc();
			}
			this.Lock = false;
		}

		// Token: 0x0602CE34 RID: 183860 RVA: 0x00C8F57F File Offset: 0x00C8D77F
		protected override void OnStartExecute(MapRogueGameInfo gameInfo)
		{
			if (this.Data.RollBuffBondLinkIdOp.RogueResOption == null)
			{
				return;
			}
			this.OpenAndCloseLastView(EUiViewName.RogueBattleRoleBuffSelectView);
		}

		// Token: 0x0602CE35 RID: 183861 RVA: 0x00C8F59F File Offset: 0x00C8D79F
		public IList<RogueResGainData> GetGainDataList()
		{
			return new List<RogueResGainData>(this.Data.RollBuffBondLinkIdOp.RogueResOption.RogueResGainDatas);
		}

		// Token: 0x0602CE36 RID: 183862 RVA: 0x00C8F5BC File Offset: 0x00C8D7BC
		protected override void OnExecute(MapRogueGameInfo gameInfo)
		{
			if (this.CurrentStep == 1)
			{
				RoleBondInfoView roleBondInfoView = this.Data.RollBuffBondLinkIdOp.RoleBondInfoView;
				RogueResBondRole value = RogueBattleConfig.Instance.GetRogueResBondRole(roleBondInfoView.ParentId).Value;
				int upStar = roleBondInfoView.NewStar - roleBondInfoView.OldStar;
				bool flag = false;
				foreach (int num in value.GetBondIdsArray())
				{
					RoleBondInfo roleBondInfo = null;
					foreach (RoleBondInfo roleBondInfo2 in roleBondInfoView.OldRoleBondInfos)
					{
						if (roleBondInfo2.ConfigId == num)
						{
							roleBondInfo = roleBondInfo2;
							break;
						}
					}
					if (roleBondInfo == null)
					{
						roleBondInfo = RogueBattleModel.Instance.GetRoleBondDataById(num);
					}
					if (RogueBattleModel.Instance.GetRoleBondPreviewDataById(roleBondInfo.ConfigId, upStar, new int?(roleBondInfo.Level), new int?(roleBondInfo.CurStar)).Level != roleBondInfo.Level)
					{
						flag = true;
						break;
					}
				}
				if (flag)
				{
					this.OpenAndCloseLastView(EUiViewName.RogueBattleRoleStarUpView);
					return;
				}
				base.Execute(gameInfo, null);
				return;
			}
			else
			{
				if (this.CurrentStep != 2)
				{
					if (this.CurrentStep == 3)
					{
						base.ExecuteOp(delegate(bool success)
						{
							if (!success)
							{
								this.Lock = false;
							}
						});
					}
					return;
				}
				if (this.Data.RollBuffBondLinkIdOp.LinkId.Count == 0)
				{
					base.Execute(gameInfo, null);
					return;
				}
				this.OpenAndCloseLastView(EUiViewName.RogueBattleLinkUnlockView);
				return;
			}
		}

		// Token: 0x0602CE37 RID: 183863 RVA: 0x00C8F744 File Offset: 0x00C8D944
		private void OpenAndCloseLastView(EUiViewName viewName)
		{
			UiManager.Instance.OpenView(viewName, this.IncId, delegate(bool isSuccess, int viewId)
			{
				this.CloseLastView();
				if (isSuccess)
				{
					this.LastViewName = new EUiViewName?(viewName);
				}
			});
		}

		// Token: 0x0602CE38 RID: 183864 RVA: 0x00C8F78C File Offset: 0x00C8D98C
		private void CloseLastView()
		{
			if (this.LastViewName == null)
			{
				return;
			}
			if (UiManager.Instance.IsViewOpen(this.LastViewName.Value) || UiManager.Instance.IsViewHide(this.LastViewName.Value))
			{
				UiManager.Instance.CloseView(this.LastViewName.Value, null);
			}
			this.LastViewName = null;
		}

		// Token: 0x0602CE39 RID: 183865 RVA: 0x00C8F7F7 File Offset: 0x00C8D9F7
		public void Select(int index)
		{
			if (this.Lock)
			{
				return;
			}
			this.Lock = true;
			this.OpExecuteClientId = index;
		}

		// Token: 0x0602CE3A RID: 183866 RVA: 0x00C8F810 File Offset: 0x00C8DA10
		protected override void OnFinish(MapRogueGameInfo gameInfo)
		{
		}

		// Token: 0x0602CE3B RID: 183867 RVA: 0x00C8F812 File Offset: 0x00C8DA12
		protected override void OnDelete(MapRogueGameInfo gameInfo)
		{
			this.CloseLastView();
		}

		// Token: 0x0602CE3C RID: 183868 RVA: 0x00C8F81C File Offset: 0x00C8DA1C
		protected override bool OnBeforeStartExecuteCheck(MapRogueGameInfo gameInfo)
		{
			using (List<MapRogueOp>.Enumerator enumerator = MapRogueModel.Instance.GetOpDataByType(RogueResOpType.RollBuffBondLinkId).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsStartExecute)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x040180C1 RID: 98497
		[Nullable(2)]
		public Action UpdateViewFunc;

		// Token: 0x040180C3 RID: 98499
		public int MaxSelectCount;

		// Token: 0x040180C4 RID: 98500
		public int CurrentSelectCount;

		// Token: 0x040180C5 RID: 98501
		private bool Lock;

		// Token: 0x040180C6 RID: 98502
		private EUiViewName? LastViewName;
	}
}
