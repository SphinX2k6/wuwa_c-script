using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x02004314 RID: 17172
	public class RogueTaskRoleItem : UiPanelBase
	{
		// Token: 0x0602B667 RID: 177767 RVA: 0x00C33399 File Offset: 0x00C31599
		public RogueTaskRoleItem(int roleId, bool bIsLock)
		{
			this.RoleId = roleId;
			this.IsLock = bIsLock;
		}

		// Token: 0x0602B668 RID: 177768 RVA: 0x00C333B6 File Offset: 0x00C315B6
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x0602B669 RID: 177769 RVA: 0x00C333F0 File Offset: 0x00C315F0
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(this.IsLock);
			}
			base.SetTextureByPath(RoleConfig.Instance.GetRoleConfig(this.RoleId).Value.FormationRoleCard, base.GetTexture(0), null, null);
		}

		// Token: 0x0602B66A RID: 177770 RVA: 0x00C3345D File Offset: 0x00C3165D
		protected override void OnBeforeDestroy()
		{
			this.LevelSequencePlayer = null;
		}

		// Token: 0x0602B66B RID: 177771 RVA: 0x00C33468 File Offset: 0x00C31668
		public void SetCharUnlock()
		{
			if (!this.IsLock)
			{
				return;
			}
			this.IsLock = false;
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlayLevelSequenceByName("Unlock", false, null, false);
		}

		// Token: 0x04017738 RID: 96056
		protected int RoleId;

		// Token: 0x04017739 RID: 96057
		protected bool IsLock = true;

		// Token: 0x0401773A RID: 96058
		[Nullable(2)]
		public LevelSequencePlayer LevelSequencePlayer;
	}
}
