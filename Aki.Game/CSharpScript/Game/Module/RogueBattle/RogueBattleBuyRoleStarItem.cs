using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003E14 RID: 15892
	public class RogueBattleBuyRoleStarItem : GridProxyAbstract<bool>
	{
		// Token: 0x06028913 RID: 166163 RVA: 0x00B620D0 File Offset: 0x00B602D0
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

		// Token: 0x06028914 RID: 166164 RVA: 0x00B62156 File Offset: 0x00B60356
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		}

		// Token: 0x06028915 RID: 166165 RVA: 0x00B62169 File Offset: 0x00B60369
		public override void Refresh(bool isOn, bool isSelected, int gridIndex)
		{
			base.GetSprite(0).SetUIActive(true);
			base.GetSprite(1).SetUIActive(isOn);
			this.SetPreviewAnimOn(false);
		}

		// Token: 0x06028916 RID: 166166 RVA: 0x00B6218C File Offset: 0x00B6038C
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

		// Token: 0x04016031 RID: 90161
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;
	}
}
