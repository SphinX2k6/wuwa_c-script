using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x02005612 RID: 22034
	[NullableContext(1)]
	[Nullable(0)]
	public class MapRogueGridDecoration : UiPanelBase
	{
		// Token: 0x0603811E RID: 229662 RVA: 0x00D47C2F File Offset: 0x00D45E2F
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite))
			};
		}

		// Token: 0x0603811F RID: 229663 RVA: 0x00D47C54 File Offset: 0x00D45E54
		private void SetSprite(string path)
		{
			UUISprite sprite = base.GetSprite(0);
			this.SetSpriteByPath(path, sprite, false, null, delegate(bool success)
			{
				if (success)
				{
					sprite.SetUIActive(true);
				}
			});
		}

		// Token: 0x06038120 RID: 229664 RVA: 0x00D47C98 File Offset: 0x00D45E98
		public void Refresh(MapGridData data)
		{
			bool flag = data.ExtraPathIndex >= 0;
			base.GetSprite(0).SetUIActive(false);
			if (data.IsExplore && data.GridEventId != 0)
			{
				this.SetSprite("/Game/Aki/UI/UIResources/UiRogue/Atlas/RogueMap/SP_PieceFlag.SP_PieceFlag");
				return;
			}
			if (flag)
			{
				RogueResGridMapType? gridMapTypeConfigById = MapRogueConfig.Instance.GetGridMapTypeConfigById(data.GridTypeId);
				if (gridMapTypeConfigById != null)
				{
					List<string> list = new List<string>(gridMapTypeConfigById.Value.DecorationPath().Keys);
					this.SetSprite(list[data.ExtraPathIndex]);
				}
			}
		}

		// Token: 0x06038121 RID: 229665 RVA: 0x00D47D24 File Offset: 0x00D45F24
		public void SetVision(bool bHasVision)
		{
			this.SetActive(bHasVision);
		}

		// Token: 0x0401D79F RID: 120735
		private const string GRID_TAKE_SPRITE = "/Game/Aki/UI/UIResources/UiRogue/Atlas/RogueMap/SP_PieceFlag.SP_PieceFlag";
	}
}
