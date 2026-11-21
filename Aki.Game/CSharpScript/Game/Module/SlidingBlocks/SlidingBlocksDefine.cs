using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;

namespace CSharpScript.Game.Module.SlidingBlocks
{
	// Token: 0x02003B23 RID: 15139
	public class SlidingBlocksDefine
	{
		// Token: 0x0401542A RID: 87082
		[Nullable(1)]
		public const string BoxMeshPath = "/Engine/BasicShapes/Cube.Cube";

		// Token: 0x0401542B RID: 87083
		public const int TetrominoFallingSpeed = 1;

		// Token: 0x02009794 RID: 38804
		public enum EGameStage
		{
			// Token: 0x0402F489 RID: 193673
			None,
			// Token: 0x0402F48A RID: 193674
			Init,
			// Token: 0x0402F48B RID: 193675
			GameRunning,
			// Token: 0x0402F48C RID: 193676
			WaitSettlement,
			// Token: 0x0402F48D RID: 193677
			Settlement,
			// Token: 0x0402F48E RID: 193678
			WaitDestroy,
			// Token: 0x0402F48F RID: 193679
			GameEnd
		}

		// Token: 0x02009795 RID: 38805
		public enum EGameEndReason
		{
			// Token: 0x0402F491 RID: 193681
			None,
			// Token: 0x0402F492 RID: 193682
			InitFail,
			// Token: 0x0402F493 RID: 193683
			NormalModeEnd,
			// Token: 0x0402F494 RID: 193684
			MainLineModeEnd,
			// Token: 0x0402F495 RID: 193685
			SqueezePlayer,
			// Token: 0x0402F496 RID: 193686
			MinoOverHeight,
			// Token: 0x0402F497 RID: 193687
			ClickClose
		}

		// Token: 0x02009796 RID: 38806
		[EnumExtensions]
		public enum EAddMinoReason
		{
			// Token: 0x0402F499 RID: 193689
			[EnumStringMember("LineClearFall")]
			LineClearFall,
			// Token: 0x0402F49A RID: 193690
			[EnumStringMember("CreatePresetMino")]
			CreatePresetMino,
			// Token: 0x0402F49B RID: 193691
			[EnumStringMember("TetrominoLock")]
			TetrominoLock
		}

		// Token: 0x02009797 RID: 38807
		[EnumExtensions]
		public enum ERemoveMinoReason
		{
			// Token: 0x0402F49D RID: 193693
			[EnumStringMember("LineClearFall")]
			LineClearFall,
			// Token: 0x0402F49E RID: 193694
			[EnumStringMember("LineClear")]
			LineClear
		}

		// Token: 0x02009798 RID: 38808
		public enum ECheckCanMoveResult
		{
			// Token: 0x0402F4A0 RID: 193696
			None,
			// Token: 0x0402F4A1 RID: 193697
			BeyondGrid,
			// Token: 0x0402F4A2 RID: 193698
			Occupation
		}

		// Token: 0x02009799 RID: 38809
		[EnumExtensions]
		public enum ETetrominoType
		{
			// Token: 0x0402F4A4 RID: 193700
			[EnumStringMember("I块")]
			I块,
			// Token: 0x0402F4A5 RID: 193701
			[EnumStringMember("J块")]
			J块,
			// Token: 0x0402F4A6 RID: 193702
			[EnumStringMember("L块")]
			L块,
			// Token: 0x0402F4A7 RID: 193703
			[EnumStringMember("O块")]
			O块,
			// Token: 0x0402F4A8 RID: 193704
			[EnumStringMember("S块")]
			S块,
			// Token: 0x0402F4A9 RID: 193705
			[EnumStringMember("T块")]
			T块,
			// Token: 0x0402F4AA RID: 193706
			[EnumStringMember("Z块")]
			Z块,
			// Token: 0x0402F4AB RID: 193707
			[EnumStringMember("五连I块")]
			五连I块,
			// Token: 0x0402F4AC RID: 193708
			[EnumStringMember("五连T块")]
			五连T块,
			// Token: 0x0402F4AD RID: 193709
			[EnumStringMember("五连U块")]
			五连U块,
			// Token: 0x0402F4AE RID: 193710
			[EnumStringMember("五连V块")]
			五连V块,
			// Token: 0x0402F4AF RID: 193711
			[EnumStringMember("五连W块")]
			五连W块,
			// Token: 0x0402F4B0 RID: 193712
			[EnumStringMember("五连X块")]
			五连X块,
			// Token: 0x0402F4B1 RID: 193713
			[EnumStringMember("五连F块")]
			五连F块,
			// Token: 0x0402F4B2 RID: 193714
			[EnumStringMember("五连F1块")]
			五连F1块,
			// Token: 0x0402F4B3 RID: 193715
			[EnumStringMember("五连S块")]
			五连S块,
			// Token: 0x0402F4B4 RID: 193716
			[EnumStringMember("五连Z块")]
			五连Z块,
			// Token: 0x0402F4B5 RID: 193717
			[EnumStringMember("五连J块")]
			五连J块,
			// Token: 0x0402F4B6 RID: 193718
			[EnumStringMember("五连L块")]
			五连L块,
			// Token: 0x0402F4B7 RID: 193719
			[EnumStringMember("五连Y块")]
			五连Y块,
			// Token: 0x0402F4B8 RID: 193720
			[EnumStringMember("五连Y1块")]
			五连Y1块,
			// Token: 0x0402F4B9 RID: 193721
			[EnumStringMember("五连N块")]
			五连N块,
			// Token: 0x0402F4BA RID: 193722
			[EnumStringMember("五连N1块")]
			五连N1块,
			// Token: 0x0402F4BB RID: 193723
			[EnumStringMember("五连P块")]
			五连P块,
			// Token: 0x0402F4BC RID: 193724
			[EnumStringMember("五连Q块")]
			五连Q块,
			// Token: 0x0402F4BD RID: 193725
			[EnumStringMember("三连I块")]
			三连I块,
			// Token: 0x0402F4BE RID: 193726
			[EnumStringMember("三连V块")]
			三连V块,
			// Token: 0x0402F4BF RID: 193727
			[EnumStringMember("二连方块")]
			二连方块
		}

		// Token: 0x0200979A RID: 38810
		public enum ETetrominoBorad
		{
			// Token: 0x0402F4C1 RID: 193729
			二乘二 = 2,
			// Token: 0x0402F4C2 RID: 193730
			三乘三,
			// Token: 0x0402F4C3 RID: 193731
			四乘四,
			// Token: 0x0402F4C4 RID: 193732
			五乘五
		}

		// Token: 0x0200979B RID: 38811
		public enum EMinoParent
		{
			// Token: 0x0402F4C6 RID: 193734
			Board,
			// Token: 0x0402F4C7 RID: 193735
			Tetromino
		}

		// Token: 0x0200979C RID: 38812
		public enum ETetrominoRotateState
		{
			// Token: 0x0402F4C9 RID: 193737
			角度0,
			// Token: 0x0402F4CA RID: 193738
			角度90,
			// Token: 0x0402F4CB RID: 193739
			角度180,
			// Token: 0x0402F4CC RID: 193740
			角度270
		}
	}
}
