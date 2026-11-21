using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x02004613 RID: 17939
	[NullableContext(1)]
	[Nullable(0)]
	public class GridPopupViewModelBlank : GridPopupViewModelBase
	{
		// Token: 0x17005AFD RID: 23293
		// (get) Token: 0x0602D125 RID: 184613 RVA: 0x00C99D4E File Offset: 0x00C97F4E
		public override bool HasBtnDetail
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0602D126 RID: 184614 RVA: 0x00C99D51 File Offset: 0x00C97F51
		public GridPopupViewModelBlank(MapGridData gridData, MapRogueGameInfo gameInfo) : base(gridData, gameInfo)
		{
		}

		// Token: 0x0602D127 RID: 184615 RVA: 0x00C99D5C File Offset: 0x00C97F5C
		public override UniTask Init()
		{
			GridPopupViewModelBlank.<Init>d__4 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<GridPopupViewModelBlank.<Init>d__4>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x0602D128 RID: 184616 RVA: 0x00C99DA0 File Offset: 0x00C97FA0
		public override void RefreshFunctional()
		{
			bool flag = this.GameInfo.MoveState == EMovePathType.CanMove;
			this.Button.SetUiActive(flag);
			if (!flag)
			{
				return;
			}
			this.Button.SetButtonTextByTextId("RogueRes_Block_Move", Array.Empty<string>());
			this.Button.SetButtonFunction(new Action<int>(this.ButtonFunction));
		}

		// Token: 0x0602D129 RID: 184617 RVA: 0x00C99DF8 File Offset: 0x00C97FF8
		private void ButtonFunction(int _)
		{
			if (this.IsEnd)
			{
				return;
			}
			this.IsEnd = true;
			this.GameInfo.RequestMove(null);
			this.View.CloseMeAsync();
		}

		// Token: 0x0401830C RID: 99084
		protected PopupComponentFunctionButton Button;
	}
}
