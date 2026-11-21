using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007022 RID: 28706
	public struct IInstrumentKeyConfigs : IFlatbufferObject
	{
		// Token: 0x1700D22E RID: 53806
		// (get) Token: 0x06031BD4 RID: 203732 RVA: 0x006BBEFB File Offset: 0x006BA0FB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031BD5 RID: 203733 RVA: 0x006BBF08 File Offset: 0x006BA108
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031BD6 RID: 203734 RVA: 0x006BBF10 File Offset: 0x006BA110
		public static IInstrumentKeyConfigs GetRootAsIInstrumentKeyConfigs(ByteBuffer _bb)
		{
			return IInstrumentKeyConfigs.GetRootAsIInstrumentKeyConfigs(_bb, default(IInstrumentKeyConfigs));
		}

		// Token: 0x06031BD7 RID: 203735 RVA: 0x006BBF2C File Offset: 0x006BA12C
		public static IInstrumentKeyConfigs GetRootAsIInstrumentKeyConfigs(ByteBuffer _bb, IInstrumentKeyConfigs obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031BD8 RID: 203736 RVA: 0x006BBF49 File Offset: 0x006BA149
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031BD9 RID: 203737 RVA: 0x006BBF58 File Offset: 0x006BA158
		public IInstrumentKeyConfigs __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06031BDA RID: 203738 RVA: 0x006BBF68 File Offset: 0x006BA168
		public IInstrumentKeyAttribute? Grids(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IInstrumentKeyAttribute?(default(IInstrumentKeyAttribute).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D22F RID: 53807
		// (get) Token: 0x06031BDB RID: 203739 RVA: 0x006BBFC8 File Offset: 0x006BA1C8
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

		// Token: 0x1700D230 RID: 53808
		// (get) Token: 0x06031BDC RID: 203740 RVA: 0x006BBFF4 File Offset: 0x006BA1F4
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

		// Token: 0x06031BDD RID: 203741 RVA: 0x006BC051 File Offset: 0x006BA251
		public static Offset<IInstrumentKeyConfigs> CreateIInstrumentKeyConfigs(FlatBufferBuilder builder, VectorOffset GridsOffset = default(VectorOffset), Offset<IInstrumentBoardSize> BoardSizeOffset = default(Offset<IInstrumentBoardSize>))
		{
			builder.StartTable(2);
			IInstrumentKeyConfigs.AddBoardSize(builder, BoardSizeOffset);
			IInstrumentKeyConfigs.AddGrids(builder, GridsOffset);
			return IInstrumentKeyConfigs.EndIInstrumentKeyConfigs(builder);
		}

		// Token: 0x06031BDE RID: 203742 RVA: 0x006BC06E File Offset: 0x006BA26E
		public static void StartIInstrumentKeyConfigs(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031BDF RID: 203743 RVA: 0x006BC077 File Offset: 0x006BA277
		public static void AddGrids(FlatBufferBuilder builder, VectorOffset gridsOffset)
		{
			builder.AddOffset(0, gridsOffset.Value, 0);
		}

		// Token: 0x06031BE0 RID: 203744 RVA: 0x006BC088 File Offset: 0x006BA288
		public static VectorOffset CreateGridsVector(FlatBufferBuilder builder, Offset<IInstrumentKeyAttribute>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06031BE1 RID: 203745 RVA: 0x006BC0C8 File Offset: 0x006BA2C8
		public static VectorOffset CreateGridsVectorBlock(FlatBufferBuilder builder, Offset<IInstrumentKeyAttribute>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IInstrumentKeyAttribute>>(data);
			return builder.EndVector();
		}

		// Token: 0x06031BE2 RID: 203746 RVA: 0x006BC0E2 File Offset: 0x006BA2E2
		public static VectorOffset CreateGridsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IInstrumentKeyAttribute>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IInstrumentKeyAttribute>>(data);
			return builder.EndVector();
		}

		// Token: 0x06031BE3 RID: 203747 RVA: 0x006BC100 File Offset: 0x006BA300
		public static VectorOffset CreateGridsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IInstrumentKeyAttribute>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06031BE4 RID: 203748 RVA: 0x006BC119 File Offset: 0x006BA319
		public static void StartGridsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06031BE5 RID: 203749 RVA: 0x006BC124 File Offset: 0x006BA324
		public static void AddBoardSize(FlatBufferBuilder builder, Offset<IInstrumentBoardSize> boardSizeOffset)
		{
			builder.AddOffset(1, boardSizeOffset.Value, 0);
		}

		// Token: 0x06031BE6 RID: 203750 RVA: 0x006BC134 File Offset: 0x006BA334
		public static Offset<IInstrumentKeyConfigs> EndIInstrumentKeyConfigs(FlatBufferBuilder builder)
		{
			return new Offset<IInstrumentKeyConfigs>(builder.EndTable());
		}

		// Token: 0x06031BE7 RID: 203751 RVA: 0x006BC144 File Offset: 0x006BA344
		public IInstrumentKeyConfigsT UnPack()
		{
			IInstrumentKeyConfigsT instrumentKeyConfigsT = new IInstrumentKeyConfigsT();
			this.UnPackTo(instrumentKeyConfigsT);
			return instrumentKeyConfigsT;
		}

		// Token: 0x06031BE8 RID: 203752 RVA: 0x006BC160 File Offset: 0x006BA360
		public void UnPackTo(IInstrumentKeyConfigsT _o)
		{
			_o.Grids = new List<IInstrumentKeyAttributeT>();
			for (int i = 0; i < this.GridsLength; i++)
			{
				_o.Grids.Add((this.Grids(i) != null) ? this.Grids(i).Value.UnPack() : null);
			}
			_o.BoardSize = ((this.BoardSize != null) ? this.BoardSize.Value.UnPack() : null);
		}

		// Token: 0x06031BE9 RID: 203753 RVA: 0x006BC1F0 File Offset: 0x006BA3F0
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

		// Token: 0x04011F5F RID: 73567
		private Table __p;
	}
}
