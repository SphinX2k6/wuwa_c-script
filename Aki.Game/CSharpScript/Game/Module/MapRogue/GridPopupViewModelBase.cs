using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x02004611 RID: 17937
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class GridPopupViewModelBase
	{
		// Token: 0x0602D10F RID: 184591 RVA: 0x00C99A57 File Offset: 0x00C97C57
		public GridPopupViewModelBase(MapGridData gridData, MapRogueGameInfo gameInfo)
		{
			this.GridData = gridData;
			this.GameInfo = gameInfo;
		}

		// Token: 0x0602D110 RID: 184592 RVA: 0x00C99A6D File Offset: 0x00C97C6D
		public void BindView(GridPopupView view)
		{
			this.View = view;
		}

		// Token: 0x0602D111 RID: 184593 RVA: 0x00C99A78 File Offset: 0x00C97C78
		public bool EventAvailable()
		{
			bool flag = this.GameInfo.MoveState == EMovePathType.CanMove;
			bool flag2 = this.GridData.IsUnlock();
			return flag && flag2;
		}

		// Token: 0x0602D112 RID: 184594 RVA: 0x00C99AA1 File Offset: 0x00C97CA1
		public virtual UniTask Init()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x0602D113 RID: 184595 RVA: 0x00C99AA8 File Offset: 0x00C97CA8
		[NullableContext(2)]
		public virtual string GetSubTxtInfo()
		{
			return null;
		}

		// Token: 0x17005AFB RID: 23291
		// (get) Token: 0x0602D114 RID: 184596
		public abstract bool HasBtnDetail { get; }

		// Token: 0x0602D115 RID: 184597 RVA: 0x00C99AAB File Offset: 0x00C97CAB
		public virtual void GetBtnDetailFunc()
		{
		}

		// Token: 0x0602D116 RID: 184598 RVA: 0x00C99AAD File Offset: 0x00C97CAD
		public void OnClickedClose()
		{
			if (this.IsEnd)
			{
				return;
			}
			this.IsEnd = true;
			this.GameInfo.GameStage = EMapRogueGameStage.Norm;
			GridPopupView view = this.View;
			if (view == null)
			{
				return;
			}
			view.CloseMeAsync();
		}

		// Token: 0x0602D117 RID: 184599 RVA: 0x00C99ADC File Offset: 0x00C97CDC
		public virtual void RefreshTop()
		{
		}

		// Token: 0x0602D118 RID: 184600 RVA: 0x00C99ADE File Offset: 0x00C97CDE
		public virtual void RefreshBottom()
		{
		}

		// Token: 0x0602D119 RID: 184601 RVA: 0x00C99AE0 File Offset: 0x00C97CE0
		public virtual void RefreshFunctional()
		{
		}

		// Token: 0x0602D11A RID: 184602 RVA: 0x00C99AE2 File Offset: 0x00C97CE2
		public void MoveButtonFunction(int _)
		{
			if (this.IsEnd)
			{
				return;
			}
			this.IsEnd = true;
			this.GameInfo.RequestMove(new Action<bool>(this.<MoveButtonFunction>g__confirmCloseSelf|16_0));
		}

		// Token: 0x0602D11B RID: 184603 RVA: 0x00C99B0B File Offset: 0x00C97D0B
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			return null;
		}

		// Token: 0x0602D11C RID: 184604 RVA: 0x00C99B0E File Offset: 0x00C97D0E
		[CompilerGenerated]
		private void <MoveButtonFunction>g__confirmCloseSelf|16_0(bool confirm)
		{
			this.IsEnd = confirm;
			if (confirm)
			{
				this.View.CloseMeAsync();
			}
		}

		// Token: 0x04018303 RID: 99075
		protected GridPopupView View;

		// Token: 0x04018304 RID: 99076
		public bool IsEnd;

		// Token: 0x04018305 RID: 99077
		public MapGridData GridData;

		// Token: 0x04018306 RID: 99078
		public MapRogueGameInfo GameInfo;
	}
}
