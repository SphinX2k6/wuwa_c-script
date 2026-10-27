using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.RogueBattle;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020055BB RID: 21947
	[NullableContext(1)]
	[Nullable(0)]
	public class MapRogueOpRoleBuffBondLinkId : MapRogueOp
	{
		// Token: 0x170086D0 RID: 34512
		// (get) Token: 0x06037F31 RID: 229169 RVA: 0x00D41727 File Offset: 0x00D3F927
		// (set) Token: 0x06037F32 RID: 229170 RVA: 0x00D4172F File Offset: 0x00D3F92F
		public override int StepSize { get; set; } = 2;

		// Token: 0x06037F33 RID: 229171 RVA: 0x00D41738 File Offset: 0x00D3F938
		public MapRogueOpRoleBuffBondLinkId()
		{
			this.Priority = ERogueOpPriority.RoleBuff;
		}

		// Token: 0x06037F34 RID: 229172 RVA: 0x00D41750 File Offset: 0x00D3F950
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

		// Token: 0x06037F35 RID: 229173 RVA: 0x00D4181D File Offset: 0x00D3FA1D
		protected override void OnUpdate(MapRogueGameInfo gameInfo)
		{
			Action updateViewFunc = this.UpdateViewFunc;
			if (updateViewFunc != null)
			{
				updateViewFunc();
			}
			this.Lock = false;
		}

		// Token: 0x06037F36 RID: 229174 RVA: 0x00D41837 File Offset: 0x00D3FA37
		protected override void OnStartExecute(MapRogueGameInfo gameInfo)
		{
			if (this.Data.RollBuffBondLinkIdOp.RogueResOption == null)
			{
				return;
			}
			this.OpenAndCloseLastView(EUiViewName.RogueBattleRoleBuffSelectView);
		}

		// Token: 0x06037F37 RID: 229175 RVA: 0x00D41857 File Offset: 0x00D3FA57
		public IList<RogueResGainData> GetGainDataList()
		{
			return this.Data.RollBuffBondLinkIdOp.RogueResOption.RogueResGainDatas.ToList<RogueResGainData>();
		}

		// Token: 0x06037F38 RID: 229176 RVA: 0x00D41874 File Offset: 0x00D3FA74
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

		// Token: 0x06037F39 RID: 229177 RVA: 0x00D419FC File Offset: 0x00D3FBFC
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

		// Token: 0x06037F3A RID: 229178 RVA: 0x00D41A44 File Offset: 0x00D3FC44
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

		// Token: 0x06037F3B RID: 229179 RVA: 0x00D41AAF File Offset: 0x00D3FCAF
		public void Select(int index)
		{
			if (this.Lock)
			{
				return;
			}
			this.Lock = true;
			this.OpExecuteClientId = index;
		}

		// Token: 0x06037F3C RID: 229180 RVA: 0x00D41AC8 File Offset: 0x00D3FCC8
		protected override void OnFinish(MapRogueGameInfo gameInfo)
		{
		}

		// Token: 0x06037F3D RID: 229181 RVA: 0x00D41ACA File Offset: 0x00D3FCCA
		protected override void OnDelete(MapRogueGameInfo gameInfo)
		{
			this.CloseLastView();
		}

		// Token: 0x06037F3E RID: 229182 RVA: 0x00D41AD4 File Offset: 0x00D3FCD4
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

		// Token: 0x0401D636 RID: 120374
		[Nullable(2)]
		public Action UpdateViewFunc;

		// Token: 0x0401D638 RID: 120376
		public int MaxSelectCount;

		// Token: 0x0401D639 RID: 120377
		public int CurrentSelectCount;

		// Token: 0x0401D63A RID: 120378
		private bool Lock;

		// Token: 0x0401D63B RID: 120379
		private EUiViewName? LastViewName;
	}
}
