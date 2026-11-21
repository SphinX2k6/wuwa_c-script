using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020045E8 RID: 17896
	[NullableContext(1)]
	[Nullable(0)]
	public class MapRogueGridDecoration : UiPanelBase
	{
		// Token: 0x0602D01C RID: 184348 RVA: 0x00C95977 File Offset: 0x00C93B77
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite))
			};
		}

		// Token: 0x0602D01D RID: 184349 RVA: 0x00C9599C File Offset: 0x00C93B9C
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

		// Token: 0x0602D01E RID: 184350 RVA: 0x00C959E0 File Offset: 0x00C93BE0
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

		// Token: 0x0602D01F RID: 184351 RVA: 0x00C95A6C File Offset: 0x00C93C6C
		public void SetVision(bool bHasVision)
		{
			this.SetActive(bHasVision);
		}

		// Token: 0x0401822A RID: 98858
		private const string GRID_TAKE_SPRITE = "/Game/Aki/UI/UIResources/UiRogue/Atlas/RogueMap/SP_PieceFlag.SP_PieceFlag";
	}
}
