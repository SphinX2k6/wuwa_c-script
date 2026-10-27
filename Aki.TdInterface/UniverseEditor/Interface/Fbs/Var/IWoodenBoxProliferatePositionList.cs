using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B2F RID: 15151
	public struct IWoodenBoxProliferatePositionList : IFlatbufferObject
	{
		// Token: 0x170067F9 RID: 26617
		// (get) Token: 0x06014B3D RID: 84797 RVA: 0x00302DE2 File Offset: 0x00300FE2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014B3E RID: 84798 RVA: 0x00302DEF File Offset: 0x00300FEF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014B3F RID: 84799 RVA: 0x00302DF8 File Offset: 0x00300FF8
		public static IWoodenBoxProliferatePositionList GetRootAsIWoodenBoxProliferatePositionList(ByteBuffer _bb)
		{
			return IWoodenBoxProliferatePositionList.GetRootAsIWoodenBoxProliferatePositionList(_bb, default(IWoodenBoxProliferatePositionList));
		}

		// Token: 0x06014B40 RID: 84800 RVA: 0x00302E14 File Offset: 0x00301014
		public static IWoodenBoxProliferatePositionList GetRootAsIWoodenBoxProliferatePositionList(ByteBuffer _bb, IWoodenBoxProliferatePositionList obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014B41 RID: 84801 RVA: 0x00302E31 File Offset: 0x00301031
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014B42 RID: 84802 RVA: 0x00302E40 File Offset: 0x00301040
		public IWoodenBoxProliferatePositionList __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170067FA RID: 26618
		// (get) Token: 0x06014B43 RID: 84803 RVA: 0x00302E50 File Offset: 0x00301050
		public EWoodenBoxProliferateSpawnType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EWoodenBoxProliferateSpawnType.RandomInRange;
				}
				return (EWoodenBoxProliferateSpawnType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06014B44 RID: 84804 RVA: 0x00302E8C File Offset: 0x0030108C
		public IVectorInfo? Positions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170067FB RID: 26619
		// (get) Token: 0x06014B45 RID: 84805 RVA: 0x00302EEC File Offset: 0x003010EC
		public int PositionsLength
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

		// Token: 0x06014B46 RID: 84806 RVA: 0x00302F17 File Offset: 0x00301117
		public static Offset<IWoodenBoxProliferatePositionList> CreateIWoodenBoxProliferatePositionList(FlatBufferBuilder builder, EWoodenBoxProliferateSpawnType Type = EWoodenBoxProliferateSpawnType.RandomInRange, VectorOffset PositionsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IWoodenBoxProliferatePositionList.AddPositions(builder, PositionsOffset);
			IWoodenBoxProliferatePositionList.AddType(builder, Type);
			return IWoodenBoxProliferatePositionList.EndIWoodenBoxProliferatePositionList(builder);
		}

		// Token: 0x06014B47 RID: 84807 RVA: 0x00302F34 File Offset: 0x00301134
		public static void StartIWoodenBoxProliferatePositionList(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06014B48 RID: 84808 RVA: 0x00302F3D File Offset: 0x0030113D
		public static void AddType(FlatBufferBuilder builder, EWoodenBoxProliferateSpawnType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06014B49 RID: 84809 RVA: 0x00302F48 File Offset: 0x00301148
		public static void AddPositions(FlatBufferBuilder builder, VectorOffset positionsOffset)
		{
			builder.AddOffset(1, positionsOffset.Value, 0);
		}

		// Token: 0x06014B4A RID: 84810 RVA: 0x00302F58 File Offset: 0x00301158
		public static VectorOffset CreatePositionsVector(FlatBufferBuilder builder, Offset<IVectorInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06014B4B RID: 84811 RVA: 0x00302F98 File Offset: 0x00301198
		public static VectorOffset CreatePositionsVectorBlock(FlatBufferBuilder builder, Offset<IVectorInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IVectorInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06014B4C RID: 84812 RVA: 0x00302FB2 File Offset: 0x003011B2
		public static VectorOffset CreatePositionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IVectorInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IVectorInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06014B4D RID: 84813 RVA: 0x00302FD0 File Offset: 0x003011D0
		public static VectorOffset CreatePositionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IVectorInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06014B4E RID: 84814 RVA: 0x00302FE9 File Offset: 0x003011E9
		public static void StartPositionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06014B4F RID: 84815 RVA: 0x00302FF4 File Offset: 0x003011F4
		public static Offset<IWoodenBoxProliferatePositionList> EndIWoodenBoxProliferatePositionList(FlatBufferBuilder builder)
		{
			return new Offset<IWoodenBoxProliferatePositionList>(builder.EndTable());
		}

		// Token: 0x06014B50 RID: 84816 RVA: 0x00303004 File Offset: 0x00301204
		public IWoodenBoxProliferatePositionListT UnPack()
		{
			IWoodenBoxProliferatePositionListT woodenBoxProliferatePositionListT = new IWoodenBoxProliferatePositionListT();
			this.UnPackTo(woodenBoxProliferatePositionListT);
			return woodenBoxProliferatePositionListT;
		}

		// Token: 0x06014B51 RID: 84817 RVA: 0x00303020 File Offset: 0x00301220
		public void UnPackTo(IWoodenBoxProliferatePositionListT _o)
		{
			_o.Type = this.Type;
			_o.Positions = new List<IVectorInfoT>();
			for (int i = 0; i < this.PositionsLength; i++)
			{
				_o.Positions.Add((this.Positions(i) != null) ? this.Positions(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06014B52 RID: 84818 RVA: 0x0030308C File Offset: 0x0030128C
		public static Offset<IWoodenBoxProliferatePositionList> Pack(FlatBufferBuilder builder, IWoodenBoxProliferatePositionListT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWoodenBoxProliferatePositionList>);
			}
			VectorOffset positionsOffset = default(VectorOffset);
			if (_o.Positions != null)
			{
				Offset<IVectorInfo>[] array = new Offset<IVectorInfo>[_o.Positions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IVectorInfo.Pack(builder, _o.Positions[i]);
				}
				positionsOffset = IWoodenBoxProliferatePositionList.CreatePositionsVector(builder, array);
			}
			return IWoodenBoxProliferatePositionList.CreateIWoodenBoxProliferatePositionList(builder, _o.Type, positionsOffset);
		}

		// Token: 0x0400B00F RID: 45071
		private Table __p;
	}
}
