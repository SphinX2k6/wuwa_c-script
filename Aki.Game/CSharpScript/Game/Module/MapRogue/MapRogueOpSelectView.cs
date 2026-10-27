using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020055BC RID: 21948
	[NullableContext(1)]
	[Nullable(0)]
	public class MapRogueOpSelectView : MapRogueOp
	{
		// Token: 0x170086D1 RID: 34513
		// (get) Token: 0x06037F40 RID: 229184 RVA: 0x00D41B40 File Offset: 0x00D3FD40
		// (set) Token: 0x06037F41 RID: 229185 RVA: 0x00D41B48 File Offset: 0x00D3FD48
		public override int StepSize { get; set; } = 1;

		// Token: 0x170086D2 RID: 34514
		// (get) Token: 0x06037F42 RID: 229186 RVA: 0x00D41B51 File Offset: 0x00D3FD51
		public bool IsMax
		{
			get
			{
				return this.CurrentSelectCount >= this.MaxSelectCount;
			}
		}

		// Token: 0x06037F43 RID: 229187 RVA: 0x00D41B64 File Offset: 0x00D3FD64
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

		// Token: 0x06037F44 RID: 229188 RVA: 0x00D41C34 File Offset: 0x00D3FE34
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

		// Token: 0x06037F45 RID: 229189 RVA: 0x00D41C8E File Offset: 0x00D3FE8E
		public IList<RogueResGainData> GetGainDataList()
		{
			return this.Data.SelectViewOp.RogueResOption.RogueResGainDatas.ToList<RogueResGainData>();
		}

		// Token: 0x06037F46 RID: 229190 RVA: 0x00D41CAA File Offset: 0x00D3FEAA
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

		// Token: 0x06037F47 RID: 229191 RVA: 0x00D41CD5 File Offset: 0x00D3FED5
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

		// Token: 0x06037F48 RID: 229192 RVA: 0x00D41CFC File Offset: 0x00D3FEFC
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

		// Token: 0x06037F49 RID: 229193 RVA: 0x00D41DB5 File Offset: 0x00D3FFB5
		protected override void OnExecute(MapRogueGameInfo gameInfo)
		{
		}

		// Token: 0x06037F4A RID: 229194 RVA: 0x00D41DB7 File Offset: 0x00D3FFB7
		protected override void OnFinish(MapRogueGameInfo gameInfo)
		{
		}

		// Token: 0x06037F4B RID: 229195 RVA: 0x00D41DB9 File Offset: 0x00D3FFB9
		protected override void OnDelete(MapRogueGameInfo gameInfo)
		{
			Action closeViewFunc = this.CloseViewFunc;
			if (closeViewFunc == null)
			{
				return;
			}
			closeViewFunc();
		}

		// Token: 0x0401D63C RID: 120380
		[Nullable(2)]
		public Action CloseViewFunc;

		// Token: 0x0401D63D RID: 120381
		[Nullable(2)]
		public Action UpdateViewFunc;

		// Token: 0x0401D63F RID: 120383
		public int MaxSelectCount;

		// Token: 0x0401D640 RID: 120384
		public int CurrentSelectCount;

		// Token: 0x0401D641 RID: 120385
		public bool CanGiveUp;

		// Token: 0x0401D642 RID: 120386
		private bool Lock;
	}
}
