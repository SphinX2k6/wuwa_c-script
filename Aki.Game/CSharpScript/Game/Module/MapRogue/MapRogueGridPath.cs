using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020045EF RID: 17903
	[NullableContext(1)]
	[Nullable(0)]
	public class MapRogueGridPath : UiPanelBase
	{
		// Token: 0x0602D031 RID: 184369 RVA: 0x00C9607A File Offset: 0x00C9427A
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite))
			};
		}

		// Token: 0x0602D032 RID: 184370 RVA: 0x00C9609D File Offset: 0x00C9429D
		protected override void OnStart()
		{
		}

		// Token: 0x0602D033 RID: 184371 RVA: 0x00C9609F File Offset: 0x00C9429F
		public void SetShape(EShapeType shape, bool useArrow)
		{
			if (useArrow)
			{
				this.SetBgSprite(this.shapeArrowTypeMap[shape]);
				return;
			}
			this.SetBgSprite(this.shapeTypeMap[shape]);
		}

		// Token: 0x0602D034 RID: 184372 RVA: 0x00C960CC File Offset: 0x00C942CC
		protected void SetBgSprite(string path)
		{
			UUISprite sprite = base.GetSprite(0);
			this.SetSpriteByPath(path, sprite, false, null, null);
		}

		// Token: 0x04018255 RID: 98901
		public readonly Dictionary<EShapeType, string> shapeTypeMap = new Dictionary<EShapeType, string>
		{
			{
				EShapeType.UpDown,
				"/Game/Aki/UI/UIResources/UiRogue/Atlas/RogueMap/MapArrow/SP_RoadStraight1.SP_RoadStraight1"
			},
			{
				EShapeType.DownUp,
				"/Game/Aki/UI/UIResources/UiRogue/Atlas/RogueMap/MapArrow/SP_RoadStraight1.SP_RoadStraight1"
			},
			{
				EShapeType.LeftRight,
				"/Game/Aki/UI/UIResources/UiRogue/Atlas/RogueMap/MapArrow/SP_RoadStraight2.SP_RoadStraight2"
			},
			{
				EShapeType.RightLeft,
				"/Game/Aki/UI/UIResources/UiRogue/Atlas/RogueMap/MapArrow/SP_RoadStraight2.SP_RoadStraight2"
			},
			{
				EShapeType.UpRight,
				"/Game/Aki/UI/UIResources/UiRogue/Atlas/RogueMap/MapArrow/SP_RoadCorner1.SP_RoadCorner1"
			},
			{
				EShapeType.RightUp,
				"/Game/Aki/UI/UIResources/UiRogue/Atlas/RogueMap/MapArrow/SP_RoadCorner1.SP_RoadCorner1"
			},
			{
				EShapeType.UpLeft,
				"/Game/Aki/UI/UIResources/UiRogue/Atlas/RogueMap/MapArrow/SP_RoadCorner3.SP_RoadCorner3"
			},
			{
				EShapeType.LeftUp,
				"/Game/Aki/UI/UIResources/UiRogue/Atlas/RogueMap/MapArrow/SP_RoadCorner3.SP_RoadCorner3"
			},
			{
				EShapeType.DownRight,
				"/Game/Aki/UI/UIResources/UiRogue/Atlas/RogueMap/MapArrow/SP_RoadCorner4.SP_RoadCorner4"
			},
			{
				EShapeType.RightDown,
				"/Game/Aki/UI/UIResources/UiRogue/Atlas/RogueMap/MapArrow/SP_RoadCorner4.SP_RoadCorner4"
			},
			{
				EShapeType.DownLeft,
				"/Game/Aki/UI/UIResources/UiRogue/Atlas/RogueMap/MapArrow/SP_RoadCorner2.SP_RoadCorner2"
			},
			{
				EShapeType.LeftDown,
				"/Game/Aki/UI/UIResources/UiRogue/Atlas/RogueMap/MapArrow/SP_RoadCorner2.SP_RoadCorner2"
			}
		};

		// Token: 0x04018256 RID: 98902
		public readonly Dictionary<EShapeType, string> shapeArrowTypeMap = new Dictionary<EShapeType, string>
		{
			{
				EShapeType.UpDown,
				"/Game/Aki/UI/UIResources/UiRogue/Atlas/RogueMap/MapArrow/SP_RoadStraightArrow1.SP_RoadStraightArrow1"
			},
			{
				EShapeType.DownUp,
				"/Game/Aki/UI/UIResources/UiRogue/Atlas/RogueMap/MapArrow/SP_RoadStraightArrow2.SP_RoadStraightArrow2"
			},
			{
				EShapeType.LeftRight,
				"/Game/Aki/UI/UIResources/UiRogue/Atlas/RogueMap/MapArrow/SP_RoadStraightArrow4.SP_RoadStraightArrow4"
			},
			{
				EShapeType.RightLeft,
				"/Game/Aki/UI/UIResources/UiRogue/Atlas/RogueMap/MapArrow/SP_RoadStraightArrow3.SP_RoadStraightArrow3"
			},
			{
				EShapeType.UpRight,
				"/Game/Aki/UI/UIResources/UiRogue/Atlas/RogueMap/MapArrow/SP_RoadCornerArrow3a.SP_RoadCornerArrow3a"
			},
			{
				EShapeType.RightUp,
				"/Game/Aki/UI/UIResources/UiRogue/Atlas/RogueMap/MapArrow/SP_RoadCornerArrow4a.SP_RoadCornerArrow4a"
			},
			{
				EShapeType.UpLeft,
				"/Game/Aki/UI/UIResources/UiRogue/Atlas/RogueMap/MapArrow/SP_RoadCornerArrow1.SP_RoadCornerArrow1"
			},
			{
				EShapeType.LeftUp,
				"/Game/Aki/UI/UIResources/UiRogue/Atlas/RogueMap/MapArrow/SP_RoadCornerArrow4.SP_RoadCornerArrow4"
			},
			{
				EShapeType.DownRight,
				"/Game/Aki/UI/UIResources/UiRogue/Atlas/RogueMap/MapArrow/SP_RoadCornerArrow3.SP_RoadCornerArrow3"
			},
			{
				EShapeType.RightDown,
				"/Game/Aki/UI/UIResources/UiRogue/Atlas/RogueMap/MapArrow/SP_RoadCornerArrow2.SP_RoadCornerArrow2"
			},
			{
				EShapeType.DownLeft,
				"/Game/Aki/UI/UIResources/UiRogue/Atlas/RogueMap/MapArrow/SP_RoadCornerArrow1a.SP_RoadCornerArrow1a"
			},
			{
				EShapeType.LeftDown,
				"/Game/Aki/UI/UIResources/UiRogue/Atlas/RogueMap/MapArrow/SP_RoadCornerArrow2a.SP_RoadCornerArrow2a"
			}
		};
	}
}
