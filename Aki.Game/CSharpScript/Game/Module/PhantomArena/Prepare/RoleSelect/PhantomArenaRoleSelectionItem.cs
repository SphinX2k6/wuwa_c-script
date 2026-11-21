using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.RoleSelect
{
	// Token: 0x02004122 RID: 16674
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PhantomArenaRoleSelectionItem : LoopScrollSmallItemGrid<IPhantomArenaRoleSelectionItemData>
	{
		// Token: 0x0602A287 RID: 172679 RVA: 0x00BE6F20 File Offset: 0x00BE5120
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

		// Token: 0x0602A288 RID: 172680 RVA: 0x00BE6FDF File Offset: 0x00BE51DF
		public override void OnSelected(bool fireEvent)
		{
			this.SetSelected(true, true);
		}

		// Token: 0x0602A289 RID: 172681 RVA: 0x00BE6FE9 File Offset: 0x00BE51E9
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelected(false, true);
		}

		// Token: 0x0602A28A RID: 172682 RVA: 0x00BE6FF3 File Offset: 0x00BE51F3
		[return: Nullable(2)]
		public override object GetKey(IPhantomArenaRoleSelectionItemData data, int gridIndex)
		{
			return data.CardRoleId;
		}
	}
}
