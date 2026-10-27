using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069F9 RID: 27129
	public struct ILifePointColorBoard : IFlatbufferObject
	{
		// Token: 0x1700C94B RID: 51531
		// (get) Token: 0x0602F77D RID: 194429 RVA: 0x00677068 File Offset: 0x00675268
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F77E RID: 194430 RVA: 0x00677075 File Offset: 0x00675275
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F77F RID: 194431 RVA: 0x0067707C File Offset: 0x0067527C
		public static ILifePointColorBoard GetRootAsILifePointColorBoard(ByteBuffer _bb)
		{
			return ILifePointColorBoard.GetRootAsILifePointColorBoard(_bb, default(ILifePointColorBoard));
		}

		// Token: 0x0602F780 RID: 194432 RVA: 0x00677098 File Offset: 0x00675298
		public static ILifePointColorBoard GetRootAsILifePointColorBoard(ByteBuffer _bb, ILifePointColorBoard obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F781 RID: 194433 RVA: 0x006770B5 File Offset: 0x006752B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F782 RID: 194434 RVA: 0x006770C4 File Offset: 0x006752C4
		public ILifePointColorBoard __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602F783 RID: 194435 RVA: 0x006770D4 File Offset: 0x006752D4
		public IColorPiece? Config(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IColorPiece?(default(IColorPiece).__assign(this.__p.__vector(num) + j, this.__p.bb));
		}

		// Token: 0x1700C94C RID: 51532
		// (get) Token: 0x0602F784 RID: 194436 RVA: 0x00677128 File Offset: 0x00675328
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

		// Token: 0x0602F785 RID: 194437 RVA: 0x00677154 File Offset: 0x00675354
		public EPieceColorType Colors(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return EPieceColorType.White;
			}
			return (EPieceColorType)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700C94D RID: 51533
		// (get) Token: 0x0602F786 RID: 194438 RVA: 0x00677194 File Offset: 0x00675394
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

		// Token: 0x0602F787 RID: 194439 RVA: 0x006771BF File Offset: 0x006753BF
		public Span<EPieceColorType> GetColorsBytes()
		{
			return this.__p.__vector_as_span<EPieceColorType>(6, 1);
		}

		// Token: 0x0602F788 RID: 194440 RVA: 0x006771D0 File Offset: 0x006753D0
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

		// Token: 0x1700C94E RID: 51534
		// (get) Token: 0x0602F789 RID: 194441 RVA: 0x0067723C File Offset: 0x0067543C
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

		// Token: 0x0602F78A RID: 194442 RVA: 0x00677278 File Offset: 0x00675478
		public static Offset<ILifePointColorBoard> CreateILifePointColorBoard(FlatBufferBuilder builder, VectorOffset ConfigOffset = default(VectorOffset), VectorOffset ColorsOffset = default(VectorOffset), EPieceColorType TargetColor = EPieceColorType.White)
		{
			builder.StartTable(3);
			ILifePointColorBoard.AddColors(builder, ColorsOffset);
			ILifePointColorBoard.AddConfig(builder, ConfigOffset);
			ILifePointColorBoard.AddTargetColor(builder, TargetColor);
			return ILifePointColorBoard.EndILifePointColorBoard(builder);
		}

		// Token: 0x0602F78B RID: 194443 RVA: 0x0067729C File Offset: 0x0067549C
		public static void StartILifePointColorBoard(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602F78C RID: 194444 RVA: 0x006772A5 File Offset: 0x006754A5
		public static void AddConfig(FlatBufferBuilder builder, VectorOffset configOffset)
		{
			builder.AddOffset(0, configOffset.Value, 0);
		}

		// Token: 0x0602F78D RID: 194445 RVA: 0x006772B5 File Offset: 0x006754B5
		public static void StartConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0602F78E RID: 194446 RVA: 0x006772C0 File Offset: 0x006754C0
		public static void AddColors(FlatBufferBuilder builder, VectorOffset colorsOffset)
		{
			builder.AddOffset(1, colorsOffset.Value, 0);
		}

		// Token: 0x0602F78F RID: 194447 RVA: 0x006772D0 File Offset: 0x006754D0
		public static VectorOffset CreateColorsVector(FlatBufferBuilder builder, EPieceColorType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602F790 RID: 194448 RVA: 0x00677307 File Offset: 0x00675507
		public static VectorOffset CreateColorsVectorBlock(FlatBufferBuilder builder, EPieceColorType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<EPieceColorType>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F791 RID: 194449 RVA: 0x00677321 File Offset: 0x00675521
		public static VectorOffset CreateColorsVectorBlock(FlatBufferBuilder builder, ArraySegment<EPieceColorType> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<EPieceColorType>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F792 RID: 194450 RVA: 0x0067733F File Offset: 0x0067553F
		public static VectorOffset CreateColorsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<EPieceColorType>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602F793 RID: 194451 RVA: 0x00677358 File Offset: 0x00675558
		public static void StartColorsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0602F794 RID: 194452 RVA: 0x00677363 File Offset: 0x00675563
		public static void AddTargetColor(FlatBufferBuilder builder, EPieceColorType targetColor)
		{
			builder.AddByte(2, (byte)targetColor, 0);
		}

		// Token: 0x0602F795 RID: 194453 RVA: 0x0067736E File Offset: 0x0067556E
		public static Offset<ILifePointColorBoard> EndILifePointColorBoard(FlatBufferBuilder builder)
		{
			return new Offset<ILifePointColorBoard>(builder.EndTable());
		}

		// Token: 0x0602F796 RID: 194454 RVA: 0x0067737C File Offset: 0x0067557C
		public ILifePointColorBoardT UnPack()
		{
			ILifePointColorBoardT lifePointColorBoardT = new ILifePointColorBoardT();
			this.UnPackTo(lifePointColorBoardT);
			return lifePointColorBoardT;
		}

		// Token: 0x0602F797 RID: 194455 RVA: 0x00677398 File Offset: 0x00675598
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

		// Token: 0x0602F798 RID: 194456 RVA: 0x00677434 File Offset: 0x00675634
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

		// Token: 0x040111F9 RID: 70137
		private Table __p;
	}
}
