using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004E4B RID: 20043
	public class RogueBattleBuyRoleStarItem : GridProxyAbstract<bool>
	{
		// Token: 0x06033AA8 RID: 211624 RVA: 0x00C18BA8 File Offset: 0x00C16DA8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUISprite)),
				new ValueTuple<int, Type>(2, typeof(UUISprite)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem))
			};
		}

		// Token: 0x06033AA9 RID: 211625 RVA: 0x00C18C2E File Offset: 0x00C16E2E
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		}

		// Token: 0x06033AAA RID: 211626 RVA: 0x00C18C41 File Offset: 0x00C16E41
		public override void Refresh(bool isOn, bool isSelected, int gridIndex)
		{
			base.GetSprite(0).SetUIActive(true);
			base.GetSprite(1).SetUIActive(isOn);
			this.SetPreviewAnimOn(false);
		}

		// Token: 0x06033AAB RID: 211627 RVA: 0x00C18C64 File Offset: 0x00C16E64
		public void SetPreviewAnimOn(bool bOn)
		{
			base.GetSprite(2).SetUIActive(bOn);
			base.GetItem(3).SetUIActive(bOn);
			base.GetItem(4).SetUIActive(bOn);
			if (bOn)
			{
				if (this.LevelSequencePlayer.GetCurrentSequence() == "Light")
				{
					this.LevelSequencePlayer.ReplaySequenceByKey("Light");
					return;
				}
				this.LevelSequencePlayer.StopPlayingSequence(false, true);
				this.LevelSequencePlayer.PlayLevelSequenceByName("Light", false, null, false);
				return;
			}
			else
			{
				LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
				if (levelSequencePlayer == null)
				{
					return;
				}
				levelSequencePlayer.StopSequenceByKey("Light", false, false);
				return;
			}
		}

		// Token: 0x0401B65E RID: 112222
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;
	}
}
