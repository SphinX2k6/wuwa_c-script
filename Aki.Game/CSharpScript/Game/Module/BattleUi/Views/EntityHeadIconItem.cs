using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CFE RID: 19710
	[NullableContext(2)]
	[Nullable(0)]
	public class EntityHeadIconItem : UiPanelBase
	{
		// Token: 0x060315FE RID: 202238 RVA: 0x00DCCAF4 File Offset: 0x00DCACF4
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

		// Token: 0x060315FF RID: 202239 RVA: 0x00DCCB32 File Offset: 0x00DCAD32
		public virtual void Update()
		{
			this.RefreshAlpha();
		}

		// Token: 0x06031600 RID: 202240 RVA: 0x00DCCB3C File Offset: 0x00DCAD3C
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

		// Token: 0x06031601 RID: 202241 RVA: 0x00DCCB84 File Offset: 0x00DCAD84
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

		// Token: 0x0401A26A RID: 107114
		protected int EntityId;

		// Token: 0x0401A26B RID: 107115
		protected EntityHandle EntityHandle;

		// Token: 0x0401A26C RID: 107116
		protected PawnHeadInfoComponent PawnHeadInfoComponent;

		// Token: 0x0401A26D RID: 107117
		protected bool HeadDialogVisible;
	}
}
