using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;

namespace CSharpScript.Game.Module.SlidingBlocks
{
	// Token: 0x02004B79 RID: 19321
	public class SlidingBlocksDefine
	{
		// Token: 0x0401AAD6 RID: 109270
		[Nullable(1)]
		public const string BoxMeshPath = "/Engine/BasicShapes/Cube.Cube";

		// Token: 0x0401AAD7 RID: 109271
		public const int TetrominoFallingSpeed = 1;

		// Token: 0x0200AD73 RID: 44403
		public enum EGameStage
		{
			// Token: 0x04034ADF RID: 215775
			None,
			// Token: 0x04034AE0 RID: 215776
			Init,
			// Token: 0x04034AE1 RID: 215777
			GameRunning,
			// Token: 0x04034AE2 RID: 215778
			WaitSettlement,
			// Token: 0x04034AE3 RID: 215779
			Settlement,
			// Token: 0x04034AE4 RID: 215780
			WaitDestroy,
			// Token: 0x04034AE5 RID: 215781
			GameEnd
		}

		// Token: 0x0200AD74 RID: 44404
		public enum EGameEndReason
		{
			// Token: 0x04034AE7 RID: 215783
			None,
			// Token: 0x04034AE8 RID: 215784
			InitFail,
			// Token: 0x04034AE9 RID: 215785
			NormalModeEnd,
			// Token: 0x04034AEA RID: 215786
			MainLineModeEnd,
			// Token: 0x04034AEB RID: 215787
			SqueezePlayer,
			// Token: 0x04034AEC RID: 215788
			MinoOverHeight,
			// Token: 0x04034AED RID: 215789
			ClickClose
		}

		// Token: 0x0200AD75 RID: 44405
		[EnumExtensions]
		public enum EAddMinoReason
		{
			// Token: 0x04034AEF RID: 215791
			[EnumStringMember("LineClearFall")]
			LineClearFall,
			// Token: 0x04034AF0 RID: 215792
			[EnumStringMember("CreatePresetMino")]
			CreatePresetMino,
			// Token: 0x04034AF1 RID: 215793
			[EnumStringMember("TetrominoLock")]
			TetrominoLock
		}

		// Token: 0x0200AD76 RID: 44406
		[EnumExtensions]
		public enum ERemoveMinoReason
		{
			// Token: 0x04034AF3 RID: 215795
			[EnumStringMember("LineClearFall")]
			LineClearFall,
			// Token: 0x04034AF4 RID: 215796
			[EnumStringMember("LineClear")]
			LineClear
		}

		// Token: 0x0200AD77 RID: 44407
		public enum ECheckCanMoveResult
		{
			// Token: 0x04034AF6 RID: 215798
			None,
			// Token: 0x04034AF7 RID: 215799
			BeyondGrid,
			// Token: 0x04034AF8 RID: 215800
			Occupation
		}

		// Token: 0x0200AD78 RID: 44408
		[EnumExtensions]
		public enum ETetrominoType
		{
			// Token: 0x04034AFA RID: 215802
			[EnumStringMember("I块")]
			I块,
			// Token: 0x04034AFB RID: 215803
			[EnumStringMember("J块")]
			J块,
			// Token: 0x04034AFC RID: 215804
			[EnumStringMember("L块")]
			L块,
			// Token: 0x04034AFD RID: 215805
			[EnumStringMember("O块")]
			O块,
			// Token: 0x04034AFE RID: 215806
			[EnumStringMember("S块")]
			S块,
			// Token: 0x04034AFF RID: 215807
			[EnumStringMember("T块")]
			T块,
			// Token: 0x04034B00 RID: 215808
			[EnumStringMember("Z块")]
			Z块,
			// Token: 0x04034B01 RID: 215809
			[EnumStringMember("五连I块")]
			五连I块,
			// Token: 0x04034B02 RID: 215810
			[EnumStringMember("五连T块")]
			五连T块,
			// Token: 0x04034B03 RID: 215811
			[EnumStringMember("五连U块")]
			五连U块,
			// Token: 0x04034B04 RID: 215812
			[EnumStringMember("五连V块")]
			五连V块,
			// Token: 0x04034B05 RID: 215813
			[EnumStringMember("五连W块")]
			五连W块,
			// Token: 0x04034B06 RID: 215814
			[EnumStringMember("五连X块")]
			五连X块,
			// Token: 0x04034B07 RID: 215815
			[EnumStringMember("五连F块")]
			五连F块,
			// Token: 0x04034B08 RID: 215816
			[EnumStringMember("五连F1块")]
			五连F1块,
			// Token: 0x04034B09 RID: 215817
			[EnumStringMember("五连S块")]
			五连S块,
			// Token: 0x04034B0A RID: 215818
			[EnumStringMember("五连Z块")]
			五连Z块,
			// Token: 0x04034B0B RID: 215819
			[EnumStringMember("五连J块")]
			五连J块,
			// Token: 0x04034B0C RID: 215820
			[EnumStringMember("五连L块")]
			五连L块,
			// Token: 0x04034B0D RID: 215821
			[EnumStringMember("五连Y块")]
			五连Y块,
			// Token: 0x04034B0E RID: 215822
			[EnumStringMember("五连Y1块")]
			五连Y1块,
			// Token: 0x04034B0F RID: 215823
			[EnumStringMember("五连N块")]
			五连N块,
			// Token: 0x04034B10 RID: 215824
			[EnumStringMember("五连N1块")]
			五连N1块,
			// Token: 0x04034B11 RID: 215825
			[EnumStringMember("五连P块")]
			五连P块,
			// Token: 0x04034B12 RID: 215826
			[EnumStringMember("五连Q块")]
			五连Q块,
			// Token: 0x04034B13 RID: 215827
			[EnumStringMember("三连I块")]
			三连I块,
			// Token: 0x04034B14 RID: 215828
			[EnumStringMember("三连V块")]
			三连V块,
			// Token: 0x04034B15 RID: 215829
			[EnumStringMember("二连方块")]
			二连方块
		}

		// Token: 0x0200AD79 RID: 44409
		public enum ETetrominoBorad
		{
			// Token: 0x04034B17 RID: 215831
			二乘二 = 2,
			// Token: 0x04034B18 RID: 215832
			三乘三,
			// Token: 0x04034B19 RID: 215833
			四乘四,
			// Token: 0x04034B1A RID: 215834
			五乘五
		}

		// Token: 0x0200AD7A RID: 44410
		public enum EMinoParent
		{
			// Token: 0x04034B1C RID: 215836
			Board,
			// Token: 0x04034B1D RID: 215837
			Tetromino
		}

		// Token: 0x0200AD7B RID: 44411
		public enum ETetrominoRotateState
		{
			// Token: 0x04034B1F RID: 215839
			角度0,
			// Token: 0x04034B20 RID: 215840
			角度90,
			// Token: 0x04034B21 RID: 215841
			角度180,
			// Token: 0x04034B22 RID: 215842
			角度270
		}
	}
}
