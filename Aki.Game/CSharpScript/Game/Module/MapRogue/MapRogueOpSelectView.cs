using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x02004592 RID: 17810
	[NullableContext(1)]
	[Nullable(0)]
	public class MapRogueOpSelectView : MapRogueOp
	{
		// Token: 0x17005A98 RID: 23192
		// (get) Token: 0x0602CE3E RID: 183870 RVA: 0x00C8F888 File Offset: 0x00C8DA88
		// (set) Token: 0x0602CE3F RID: 183871 RVA: 0x00C8F890 File Offset: 0x00C8DA90
		public override int StepSize { get; set; } = 1;

		// Token: 0x17005A99 RID: 23193
		// (get) Token: 0x0602CE40 RID: 183872 RVA: 0x00C8F899 File Offset: 0x00C8DA99
		public bool IsMax
		{
			get
			{
				return this.CurrentSelectCount >= this.MaxSelectCount;
			}
		}

		// Token: 0x0602CE41 RID: 183873 RVA: 0x00C8F8AC File Offset: 0x00C8DAAC
		public override string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(41, 5);
			defaultInterpolatedStringHandler.AppendLiteral("[SelectView] IncId:");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.IncId);
			defaultInterpolatedStringHandler.AppendLiteral(" Type:");
			SelectViewOp selectViewOp = this.Data.SelectViewOp;
			RogueResDataType? value;
			if (selectViewOp == null)
			{
				value = null;
			}
			else
			{
				RogueResOption rogueResOption = selectViewOp.RogueResOption;
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

		// Token: 0x0602CE42 RID: 183874 RVA: 0x00C8F97C File Offset: 0x00C8DB7C
		protected override void OnUpdate(MapRogueGameInfo gameInfo)
		{
			RogueResOption rogueResOption = this.Data.SelectViewOp.RogueResOption;
			this.MaxSelectCount = rogueResOption.MaxSelectCount;
			this.CurrentSelectCount = rogueResOption.UseSelectCount;
			this.CanGiveUp = rogueResOption.CanGiveUp;
			Action updateViewFunc = this.UpdateViewFunc;
			if (updateViewFunc != null)
			{
				updateViewFunc();
			}
			this.Lock = false;
		}

		// Token: 0x0602CE43 RID: 183875 RVA: 0x00C8F9D6 File Offset: 0x00C8DBD6
		public IList<RogueResGainData> GetGainDataList()
		{
			return new List<RogueResGainData>(this.Data.SelectViewOp.RogueResOption.RogueResGainDatas);
		}

		// Token: 0x0602CE44 RID: 183876 RVA: 0x00C8F9F2 File Offset: 0x00C8DBF2
		public void Select(int index)
		{
			if (this.Lock)
			{
				return;
			}
			this.Lock = true;
			this.OpExecuteClientId = index;
			base.ExecuteOp(delegate(bool success)
			{
				if (!success)
				{
					this.Lock = false;
				}
			});
		}

		// Token: 0x0602CE45 RID: 183877 RVA: 0x00C8FA1D File Offset: 0x00C8DC1D
		public void SelectAll(List<int> indexList)
		{
			if (this.Lock)
			{
				return;
			}
			this.Lock = true;
			base.ExecuteOpMultiSelect(indexList, delegate(bool success)
			{
				if (!success)
				{
					this.Lock = false;
				}
			});
		}

		// Token: 0x0602CE46 RID: 183878 RVA: 0x00C8FA44 File Offset: 0x00C8DC44
		protected override void OnStartExecute(MapRogueGameInfo gameInfo)
		{
			RogueResOption rogueResOption = this.Data.SelectViewOp.RogueResOption;
			if (rogueResOption == null)
			{
				return;
			}
			RogueResDataType rogueResDataType = rogueResOption.RogueResDataType;
			switch (rogueResDataType)
			{
			case RogueResDataType.Token:
				UiManager.Instance.OpenView(EUiViewName.RogueBattleSelectTokenView, this.IncId, null);
				break;
			case RogueResDataType.TokenShop:
			case RogueResDataType.Phantom:
				break;
			case RogueResDataType.Role:
				UiManager.Instance.OpenView(EUiViewName.RogueBattleBuyRoleView, this.IncId, null);
				return;
			case RogueResDataType.RoleBuff:
				UiManager.Instance.OpenView(EUiViewName.RogueBattleRoleBuffSelectView, this.IncId, null);
				return;
			default:
				if (rogueResDataType == RogueResDataType.Complex)
				{
					UiManager.Instance.OpenView(EUiViewName.MapRogueRewardView, this.IncId, null);
					return;
				}
				break;
			}
		}

		// Token: 0x0602CE47 RID: 183879 RVA: 0x00C8FAFD File Offset: 0x00C8DCFD
		protected override void OnExecute(MapRogueGameInfo gameInfo)
		{
		}

		// Token: 0x0602CE48 RID: 183880 RVA: 0x00C8FAFF File Offset: 0x00C8DCFF
		protected override void OnFinish(MapRogueGameInfo gameInfo)
		{
		}

		// Token: 0x0602CE49 RID: 183881 RVA: 0x00C8FB01 File Offset: 0x00C8DD01
		protected override void OnDelete(MapRogueGameInfo gameInfo)
		{
			Action closeViewFunc = this.CloseViewFunc;
			if (closeViewFunc == null)
			{
				return;
			}
			closeViewFunc();
		}

		// Token: 0x040180C7 RID: 98503
		[Nullable(2)]
		public Action CloseViewFunc;

		// Token: 0x040180C8 RID: 98504
		[Nullable(2)]
		public Action UpdateViewFunc;

		// Token: 0x040180CA RID: 98506
		public int MaxSelectCount;

		// Token: 0x040180CB RID: 98507
		public int CurrentSelectCount;

		// Token: 0x040180CC RID: 98508
		public bool CanGiveUp;

		// Token: 0x040180CD RID: 98509
		private bool Lock;
	}
}
