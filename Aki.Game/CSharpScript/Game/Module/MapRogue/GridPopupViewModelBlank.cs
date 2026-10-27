using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x0200563D RID: 22077
	[NullableContext(1)]
	[Nullable(0)]
	public class GridPopupViewModelBlank : GridPopupViewModelBase
	{
		// Token: 0x17008736 RID: 34614
		// (get) Token: 0x06038227 RID: 229927 RVA: 0x00D4C006 File Offset: 0x00D4A206
		public override bool HasBtnDetail
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06038228 RID: 229928 RVA: 0x00D4C009 File Offset: 0x00D4A209
		public GridPopupViewModelBlank(MapGridData gridData, MapRogueGameInfo gameInfo) : base(gridData, gameInfo)
		{
		}

		// Token: 0x06038229 RID: 229929 RVA: 0x00D4C014 File Offset: 0x00D4A214
		public override UniTask Init()
		{
			GridPopupViewModelBlank.<Init>d__4 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<GridPopupViewModelBlank.<Init>d__4>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x0603822A RID: 229930 RVA: 0x00D4C058 File Offset: 0x00D4A258
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

		// Token: 0x0603822B RID: 229931 RVA: 0x00D4C0B0 File Offset: 0x00D4A2B0
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

		// Token: 0x0401D881 RID: 120961
		protected PopupComponentFunctionButton Button;
	}
}
