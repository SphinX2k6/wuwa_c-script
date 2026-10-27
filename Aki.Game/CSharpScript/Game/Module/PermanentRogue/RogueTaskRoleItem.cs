using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x02005344 RID: 21316
	public class RogueTaskRoleItem : UiPanelBase
	{
		// Token: 0x0603676B RID: 223083 RVA: 0x00CE59C9 File Offset: 0x00CE3BC9
		public RogueTaskRoleItem(int roleId, bool bIsLock)
		{
			this.RoleId = roleId;
			this.IsLock = bIsLock;
		}

		// Token: 0x0603676C RID: 223084 RVA: 0x00CE59E6 File Offset: 0x00CE3BE6
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x0603676D RID: 223085 RVA: 0x00CE5A20 File Offset: 0x00CE3C20
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

		// Token: 0x0603676E RID: 223086 RVA: 0x00CE5A8D File Offset: 0x00CE3C8D
		protected override void OnBeforeDestroy()
		{
			this.LevelSequencePlayer = null;
		}

		// Token: 0x0603676F RID: 223087 RVA: 0x00CE5A98 File Offset: 0x00CE3C98
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

		// Token: 0x0401CD02 RID: 118018
		protected int RoleId;

		// Token: 0x0401CD03 RID: 118019
		protected bool IsLock = true;

		// Token: 0x0401CD04 RID: 118020
		[Nullable(2)]
		public LevelSequencePlayer LevelSequencePlayer;
	}
}
