using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D1C RID: 23836
	[NullableContext(2)]
	[Nullable(0)]
	public class EntityHeadIconItem : UiPanelBase
	{
		// Token: 0x0603C6A5 RID: 247461 RVA: 0x00E7C474 File Offset: 0x00E7A674
		public void InitEntityId(int entityId)
		{
			this.EntityId = entityId;
			this.EntityHandle = CharacterModel.Instance.GetHandle(entityId);
			EntityHandle entityHandle = this.EntityHandle;
			PawnHeadInfoComponent pawnHeadInfoComponent;
			if (entityHandle == null)
			{
				pawnHeadInfoComponent = null;
			}
			else
			{
				WorldEntity entity = entityHandle.Entity;
				pawnHeadInfoComponent = ((entity != null) ? entity.GetComponent<PawnHeadInfoComponent>() : null);
			}
			this.PawnHeadInfoComponent = pawnHeadInfoComponent;
		}

		// Token: 0x0603C6A6 RID: 247462 RVA: 0x00E7C4B2 File Offset: 0x00E7A6B2
		public virtual void Update()
		{
			this.RefreshAlpha();
		}

		// Token: 0x0603C6A7 RID: 247463 RVA: 0x00E7C4BC File Offset: 0x00E7A6BC
		protected void RefreshAlpha()
		{
			if (this.RootItem == null)
			{
				return;
			}
			bool headDialogVisible = this.GetHeadDialogVisible();
			if (headDialogVisible == this.HeadDialogVisible)
			{
				return;
			}
			this.HeadDialogVisible = headDialogVisible;
			this.RootItem.SetAlpha(headDialogVisible ? 0.2f : 1f);
		}

		// Token: 0x0603C6A8 RID: 247464 RVA: 0x00E7C504 File Offset: 0x00E7A704
		protected bool GetHeadDialogVisible()
		{
			EntityHandle entityHandle = this.EntityHandle;
			if (entityHandle == null || !entityHandle.Valid)
			{
				return false;
			}
			PawnHeadInfoComponent pawnHeadInfoComponent = this.PawnHeadInfoComponent;
			return pawnHeadInfoComponent != null && pawnHeadInfoComponent.IsDialogTextActive();
		}

		// Token: 0x0401F7B1 RID: 128945
		protected int EntityId;

		// Token: 0x0401F7B2 RID: 128946
		protected EntityHandle EntityHandle;

		// Token: 0x0401F7B3 RID: 128947
		protected PawnHeadInfoComponent PawnHeadInfoComponent;

		// Token: 0x0401F7B4 RID: 128948
		protected bool HeadDialogVisible;
	}
}
