using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070A9 RID: 28841
	public struct ILifePointColorBoard : IFlatbufferObject
	{
		// Token: 0x1700D34B RID: 54091
		// (get) Token: 0x0603213D RID: 205117 RVA: 0x006C73C0 File Offset: 0x006C55C0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603213E RID: 205118 RVA: 0x006C73CD File Offset: 0x006C55CD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603213F RID: 205119 RVA: 0x006C73D4 File Offset: 0x006C55D4
		public static ILifePointColorBoard GetRootAsILifePointColorBoard(ByteBuffer _bb)
		{
			return ILifePointColorBoard.GetRootAsILifePointColorBoard(_bb, default(ILifePointColorBoard));
		}

		// Token: 0x06032140 RID: 205120 RVA: 0x006C73F0 File Offset: 0x006C55F0
		public static ILifePointColorBoard GetRootAsILifePointColorBoard(ByteBuffer _bb, ILifePointColorBoard obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032141 RID: 205121 RVA: 0x006C740D File Offset: 0x006C560D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032142 RID: 205122 RVA: 0x006C741C File Offset: 0x006C561C
		public ILifePointColorBoard __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06032143 RID: 205123 RVA: 0x006C742C File Offset: 0x006C562C
		public IColorPiece? Config(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IColorPiece?(default(IColorPiece).__assign(this.__p.__vector(num) + j, this.__p.bb));
		}

		// Token: 0x1700D34C RID: 54092
		// (get) Token: 0x06032144 RID: 205124 RVA: 0x006C7480 File Offset: 0x006C5680
		public int ConfigLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06032145 RID: 205125 RVA: 0x006C74AC File Offset: 0x006C56AC
		public EPieceColorType Colors(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return EPieceColorType.White;
			}
			return (EPieceColorType)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700D34D RID: 54093
		// (get) Token: 0x06032146 RID: 205126 RVA: 0x006C74EC File Offset: 0x006C56EC
		public int ColorsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06032147 RID: 205127 RVA: 0x006C7517 File Offset: 0x006C5717
		public Span<EPieceColorType> GetColorsBytes()
		{
			return this.__p.__vector_as_span<EPieceColorType>(6, 1);
		}

		// Token: 0x06032148 RID: 205128 RVA: 0x006C7528 File Offset: 0x006C5728
		public EPieceColorType[] GetColorsArray()
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			EPieceColorType[] array = new EPieceColorType[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (EPieceColorType)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x1700D34E RID: 54094
		// (get) Token: 0x06032149 RID: 205129 RVA: 0x006C7594 File Offset: 0x006C5794
		public EPieceColorType TargetColor
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return EPieceColorType.White;
				}
				return (EPieceColorType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603214A RID: 205130 RVA: 0x006C75D0 File Offset: 0x006C57D0
		public static Offset<ILifePointColorBoard> CreateILifePointColorBoard(FlatBufferBuilder builder, VectorOffset ConfigOffset = default(VectorOffset), VectorOffset ColorsOffset = default(VectorOffset), EPieceColorType TargetColor = EPieceColorType.White)
		{
			builder.StartTable(3);
			ILifePointColorBoard.AddColors(builder, ColorsOffset);
			ILifePointColorBoard.AddConfig(builder, ConfigOffset);
			ILifePointColorBoard.AddTargetColor(builder, TargetColor);
			return ILifePointColorBoard.EndILifePointColorBoard(builder);
		}

		// Token: 0x0603214B RID: 205131 RVA: 0x006C75F4 File Offset: 0x006C57F4
		public static void StartILifePointColorBoard(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0603214C RID: 205132 RVA: 0x006C75FD File Offset: 0x006C57FD
		public static void AddConfig(FlatBufferBuilder builder, VectorOffset configOffset)
		{
			builder.AddOffset(0, configOffset.Value, 0);
		}

		// Token: 0x0603214D RID: 205133 RVA: 0x006C760D File Offset: 0x006C580D
		public static void StartConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0603214E RID: 205134 RVA: 0x006C7618 File Offset: 0x006C5818
		public static void AddColors(FlatBufferBuilder builder, VectorOffset colorsOffset)
		{
			builder.AddOffset(1, colorsOffset.Value, 0);
		}

		// Token: 0x0603214F RID: 205135 RVA: 0x006C7628 File Offset: 0x006C5828
		public static VectorOffset CreateColorsVector(FlatBufferBuilder builder, EPieceColorType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06032150 RID: 205136 RVA: 0x006C765F File Offset: 0x006C585F
		public static VectorOffset CreateColorsVectorBlock(FlatBufferBuilder builder, EPieceColorType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<EPieceColorType>(data);
			return builder.EndVector();
		}

		// Token: 0x06032151 RID: 205137 RVA: 0x006C7679 File Offset: 0x006C5879
		public static VectorOffset CreateColorsVectorBlock(FlatBufferBuilder builder, ArraySegment<EPieceColorType> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<EPieceColorType>(data);
			return builder.EndVector();
		}

		// Token: 0x06032152 RID: 205138 RVA: 0x006C7697 File Offset: 0x006C5897
		public static VectorOffset CreateColorsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<EPieceColorType>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06032153 RID: 205139 RVA: 0x006C76B0 File Offset: 0x006C58B0
		public static void StartColorsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06032154 RID: 205140 RVA: 0x006C76BB File Offset: 0x006C58BB
		public static void AddTargetColor(FlatBufferBuilder builder, EPieceColorType targetColor)
		{
			builder.AddByte(2, (byte)targetColor, 0);
		}

		// Token: 0x06032155 RID: 205141 RVA: 0x006C76C6 File Offset: 0x006C58C6
		public static Offset<ILifePointColorBoard> EndILifePointColorBoard(FlatBufferBuilder builder)
		{
			return new Offset<ILifePointColorBoard>(builder.EndTable());
		}

		// Token: 0x06032156 RID: 205142 RVA: 0x006C76D4 File Offset: 0x006C58D4
		public ILifePointColorBoardT UnPack()
		{
			ILifePointColorBoardT lifePointColorBoardT = new ILifePointColorBoardT();
			this.UnPackTo(lifePointColorBoardT);
			return lifePointColorBoardT;
		}

		// Token: 0x06032157 RID: 205143 RVA: 0x006C76F0 File Offset: 0x006C58F0
		public void UnPackTo(ILifePointColorBoardT _o)
		{
			_o.Config = new List<IColorPieceT>();
			for (int i = 0; i < this.ConfigLength; i++)
			{
				_o.Config.Add((this.Config(i) != null) ? this.Config(i).Value.UnPack() : null);
			}
			_o.Colors = new List<EPieceColorType>();
			for (int j = 0; j < this.ColorsLength; j++)
			{
				_o.Colors.Add(this.Colors(j));
			}
			_o.TargetColor = this.TargetColor;
		}

		// Token: 0x06032158 RID: 205144 RVA: 0x006C778C File Offset: 0x006C598C
		public static Offset<ILifePointColorBoard> Pack(FlatBufferBuilder builder, ILifePointColorBoardT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILifePointColorBoard>);
			}
			VectorOffset configOffset = default(VectorOffset);
			if (_o.Config != null)
			{
				ILifePointColorBoard.StartConfigVector(builder, _o.Config.Count);
				for (int i = _o.Config.Count - 1; i >= 0; i--)
				{
					IColorPiece.Pack(builder, _o.Config[i]);
				}
				configOffset = builder.EndVector();
			}
			VectorOffset colorsOffset = default(VectorOffset);
			if (_o.Colors != null)
			{
				EPieceColorType[] data = _o.Colors.ToArray();
				colorsOffset = ILifePointColorBoard.CreateColorsVector(builder, data);
			}
			return ILifePointColorBoard.CreateILifePointColorBoard(builder, configOffset, colorsOffset, _o.TargetColor);
		}

		// Token: 0x04012063 RID: 73827
		private Table __p;
	}
}
