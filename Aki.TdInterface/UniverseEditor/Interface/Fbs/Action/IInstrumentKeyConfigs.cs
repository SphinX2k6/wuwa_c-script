using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200696F RID: 26991
	public struct IInstrumentKeyConfigs : IFlatbufferObject
	{
		// Token: 0x1700C82B RID: 51243
		// (get) Token: 0x0602F204 RID: 193028 RVA: 0x0066BA13 File Offset: 0x00669C13
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F205 RID: 193029 RVA: 0x0066BA20 File Offset: 0x00669C20
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F206 RID: 193030 RVA: 0x0066BA28 File Offset: 0x00669C28
		public static IInstrumentKeyConfigs GetRootAsIInstrumentKeyConfigs(ByteBuffer _bb)
		{
			return IInstrumentKeyConfigs.GetRootAsIInstrumentKeyConfigs(_bb, default(IInstrumentKeyConfigs));
		}

		// Token: 0x0602F207 RID: 193031 RVA: 0x0066BA44 File Offset: 0x00669C44
		public static IInstrumentKeyConfigs GetRootAsIInstrumentKeyConfigs(ByteBuffer _bb, IInstrumentKeyConfigs obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F208 RID: 193032 RVA: 0x0066BA61 File Offset: 0x00669C61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F209 RID: 193033 RVA: 0x0066BA70 File Offset: 0x00669C70
		public IInstrumentKeyConfigs __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602F20A RID: 193034 RVA: 0x0066BA80 File Offset: 0x00669C80
		public IInstrumentKeyAttribute? Grids(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IInstrumentKeyAttribute?(default(IInstrumentKeyAttribute).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700C82C RID: 51244
		// (get) Token: 0x0602F20B RID: 193035 RVA: 0x0066BAE0 File Offset: 0x00669CE0
		public int GridsLength
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

		// Token: 0x1700C82D RID: 51245
		// (get) Token: 0x0602F20C RID: 193036 RVA: 0x0066BB0C File Offset: 0x00669D0C
		public IInstrumentBoardSize? BoardSize
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IInstrumentBoardSize?(default(IInstrumentBoardSize).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602F20D RID: 193037 RVA: 0x0066BB69 File Offset: 0x00669D69
		public static Offset<IInstrumentKeyConfigs> CreateIInstrumentKeyConfigs(FlatBufferBuilder builder, VectorOffset GridsOffset = default(VectorOffset), Offset<IInstrumentBoardSize> BoardSizeOffset = default(Offset<IInstrumentBoardSize>))
		{
			builder.StartTable(2);
			IInstrumentKeyConfigs.AddBoardSize(builder, BoardSizeOffset);
			IInstrumentKeyConfigs.AddGrids(builder, GridsOffset);
			return IInstrumentKeyConfigs.EndIInstrumentKeyConfigs(builder);
		}

		// Token: 0x0602F20E RID: 193038 RVA: 0x0066BB86 File Offset: 0x00669D86
		public static void StartIInstrumentKeyConfigs(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602F20F RID: 193039 RVA: 0x0066BB8F File Offset: 0x00669D8F
		public static void AddGrids(FlatBufferBuilder builder, VectorOffset gridsOffset)
		{
			builder.AddOffset(0, gridsOffset.Value, 0);
		}

		// Token: 0x0602F210 RID: 193040 RVA: 0x0066BBA0 File Offset: 0x00669DA0
		public static VectorOffset CreateGridsVector(FlatBufferBuilder builder, Offset<IInstrumentKeyAttribute>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602F211 RID: 193041 RVA: 0x0066BBE0 File Offset: 0x00669DE0
		public static VectorOffset CreateGridsVectorBlock(FlatBufferBuilder builder, Offset<IInstrumentKeyAttribute>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IInstrumentKeyAttribute>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F212 RID: 193042 RVA: 0x0066BBFA File Offset: 0x00669DFA
		public static VectorOffset CreateGridsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IInstrumentKeyAttribute>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IInstrumentKeyAttribute>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F213 RID: 193043 RVA: 0x0066BC18 File Offset: 0x00669E18
		public static VectorOffset CreateGridsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IInstrumentKeyAttribute>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602F214 RID: 193044 RVA: 0x0066BC31 File Offset: 0x00669E31
		public static void StartGridsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602F215 RID: 193045 RVA: 0x0066BC3C File Offset: 0x00669E3C
		public static void AddBoardSize(FlatBufferBuilder builder, Offset<IInstrumentBoardSize> boardSizeOffset)
		{
			builder.AddOffset(1, boardSizeOffset.Value, 0);
		}

		// Token: 0x0602F216 RID: 193046 RVA: 0x0066BC4C File Offset: 0x00669E4C
		public static Offset<IInstrumentKeyConfigs> EndIInstrumentKeyConfigs(FlatBufferBuilder builder)
		{
			return new Offset<IInstrumentKeyConfigs>(builder.EndTable());
		}

		// Token: 0x0602F217 RID: 193047 RVA: 0x0066BC5C File Offset: 0x00669E5C
		public IInstrumentKeyConfigsT UnPack()
		{
			IInstrumentKeyConfigsT instrumentKeyConfigsT = new IInstrumentKeyConfigsT();
			this.UnPackTo(instrumentKeyConfigsT);
			return instrumentKeyConfigsT;
		}

		// Token: 0x0602F218 RID: 193048 RVA: 0x0066BC78 File Offset: 0x00669E78
		public void UnPackTo(IInstrumentKeyConfigsT _o)
		{
			_o.Grids = new List<IInstrumentKeyAttributeT>();
			for (int i = 0; i < this.GridsLength; i++)
			{
				_o.Grids.Add((this.Grids(i) != null) ? this.Grids(i).Value.UnPack() : null);
			}
			_o.BoardSize = ((this.BoardSize != null) ? this.BoardSize.Value.UnPack() : null);
		}

		// Token: 0x0602F219 RID: 193049 RVA: 0x0066BD08 File Offset: 0x00669F08
		public static Offset<IInstrumentKeyConfigs> Pack(FlatBufferBuilder builder, IInstrumentKeyConfigsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInstrumentKeyConfigs>);
			}
			VectorOffset gridsOffset = default(VectorOffset);
			if (_o.Grids != null)
			{
				Offset<IInstrumentKeyAttribute>[] array = new Offset<IInstrumentKeyAttribute>[_o.Grids.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IInstrumentKeyAttribute.Pack(builder, _o.Grids[i]);
				}
				gridsOffset = IInstrumentKeyConfigs.CreateGridsVector(builder, array);
			}
			Offset<IInstrumentBoardSize> boardSizeOffset = (_o.BoardSize == null) ? default(Offset<IInstrumentBoardSize>) : IInstrumentBoardSize.Pack(builder, _o.BoardSize);
			return IInstrumentKeyConfigs.CreateIInstrumentKeyConfigs(builder, gridsOffset, boardSizeOffset);
		}

		// Token: 0x040110F3 RID: 69875
		private Table __p;
	}
}
