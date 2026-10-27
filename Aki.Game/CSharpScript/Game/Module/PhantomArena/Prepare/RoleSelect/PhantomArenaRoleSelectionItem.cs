using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.RoleSelect
{
	// Token: 0x02005152 RID: 20818
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PhantomArenaRoleSelectionItem : LoopScrollSmallItemGrid<IPhantomArenaRoleSelectionItemData>
	{
		// Token: 0x0603538B RID: 217995 RVA: 0x00C99A20 File Offset: 0x00C97C20
		protected override void OnRefresh(IPhantomArenaRoleSelectionItemData data, bool isSelected, int gridIndex)
		{
			int roleConfigId = PhantomArenaConfig.Instance.GetPhantomBattleCardRole(data.CardRoleId).RoleConfigId;
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(roleConfigId);
			CharacterSmallItemGrid parameters = new CharacterSmallItemGrid
			{
				Data = data,
				ItemConfigId = new int?(roleConfigId),
				SkinId = new int?(roleConfig.Value.SkinId),
				ElementId = new int?(roleConfig.Value.ElementId),
				IsLockVisible = new bool?(!PhantomArenaModel.Instance.IsRoleUnlock(data.CardRoleId)),
				IsRedDotVisible = new bool?(data.CanReceived)
			};
			base.Apply<CharacterSmallItemGrid>(parameters);
			this.SetSelected(isSelected, false);
		}

		// Token: 0x0603538C RID: 217996 RVA: 0x00C99ADF File Offset: 0x00C97CDF
		public override void OnSelected(bool fireEvent)
		{
			this.SetSelected(true, true);
		}

		// Token: 0x0603538D RID: 217997 RVA: 0x00C99AE9 File Offset: 0x00C97CE9
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelected(false, true);
		}

		// Token: 0x0603538E RID: 217998 RVA: 0x00C99AF3 File Offset: 0x00C97CF3
		[return: Nullable(2)]
		public override object GetKey(IPhantomArenaRoleSelectionItemData data, int gridIndex)
		{
			return data.CardRoleId;
		}
	}
}
