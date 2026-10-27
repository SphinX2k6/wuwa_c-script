using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x0200563B RID: 22075
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class GridPopupViewModelBase
	{
		// Token: 0x06038211 RID: 229905 RVA: 0x00D4BD0F File Offset: 0x00D49F0F
		public GridPopupViewModelBase(MapGridData gridData, MapRogueGameInfo gameInfo)
		{
			this.GridData = gridData;
			this.GameInfo = gameInfo;
		}

		// Token: 0x06038212 RID: 229906 RVA: 0x00D4BD25 File Offset: 0x00D49F25
		public void BindView(GridPopupView view)
		{
			this.View = view;
		}

		// Token: 0x06038213 RID: 229907 RVA: 0x00D4BD30 File Offset: 0x00D49F30
		public bool EventAvailable()
		{
			bool flag = this.GameInfo.MoveState == EMovePathType.CanMove;
			bool flag2 = this.GridData.IsUnlock();
			return flag && flag2;
		}

		// Token: 0x06038214 RID: 229908 RVA: 0x00D4BD59 File Offset: 0x00D49F59
		public virtual UniTask Init()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x06038215 RID: 229909 RVA: 0x00D4BD60 File Offset: 0x00D49F60
		[NullableContext(2)]
		public virtual string GetSubTxtInfo()
		{
			return null;
		}

		// Token: 0x17008734 RID: 34612
		// (get) Token: 0x06038216 RID: 229910
		public abstract bool HasBtnDetail { get; }

		// Token: 0x06038217 RID: 229911 RVA: 0x00D4BD63 File Offset: 0x00D49F63
		public virtual void GetBtnDetailFunc()
		{
		}

		// Token: 0x06038218 RID: 229912 RVA: 0x00D4BD65 File Offset: 0x00D49F65
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

		// Token: 0x06038219 RID: 229913 RVA: 0x00D4BD94 File Offset: 0x00D49F94
		public virtual void RefreshTop()
		{
		}

		// Token: 0x0603821A RID: 229914 RVA: 0x00D4BD96 File Offset: 0x00D49F96
		public virtual void RefreshBottom()
		{
		}

		// Token: 0x0603821B RID: 229915 RVA: 0x00D4BD98 File Offset: 0x00D49F98
		public virtual void RefreshFunctional()
		{
		}

		// Token: 0x0603821C RID: 229916 RVA: 0x00D4BD9A File Offset: 0x00D49F9A
		public void MoveButtonFunction(int _)
		{
			if (this.IsEnd)
			{
				return;
			}
			this.IsEnd = true;
			this.GameInfo.RequestMove(new Action<bool>(this.<MoveButtonFunction>g__confirmCloseSelf|16_0));
		}

		// Token: 0x0603821D RID: 229917 RVA: 0x00D4BDC3 File Offset: 0x00D49FC3
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			return null;
		}

		// Token: 0x0603821E RID: 229918 RVA: 0x00D4BDC6 File Offset: 0x00D49FC6
		[CompilerGenerated]
		private void <MoveButtonFunction>g__confirmCloseSelf|16_0(bool confirm)
		{
			this.IsEnd = confirm;
			if (confirm)
			{
				this.View.CloseMeAsync();
			}
		}

		// Token: 0x0401D878 RID: 120952
		protected GridPopupView View;

		// Token: 0x0401D879 RID: 120953
		public bool IsEnd;

		// Token: 0x0401D87A RID: 120954
		public MapGridData GridData;

		// Token: 0x0401D87B RID: 120955
		public MapRogueGameInfo GameInfo;
	}
}
