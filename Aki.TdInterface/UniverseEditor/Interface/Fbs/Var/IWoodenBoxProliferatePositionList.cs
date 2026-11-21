using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F31 RID: 16177
	public struct IWoodenBoxProliferatePositionList : IFlatbufferObject
	{
		// Token: 0x17006D94 RID: 28052
		// (get) Token: 0x06015FE7 RID: 90087 RVA: 0x00329072 File Offset: 0x00327272
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015FE8 RID: 90088 RVA: 0x0032907F File Offset: 0x0032727F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015FE9 RID: 90089 RVA: 0x00329088 File Offset: 0x00327288
		public static IWoodenBoxProliferatePositionList GetRootAsIWoodenBoxProliferatePositionList(ByteBuffer _bb)
		{
			return IWoodenBoxProliferatePositionList.GetRootAsIWoodenBoxProliferatePositionList(_bb, default(IWoodenBoxProliferatePositionList));
		}

		// Token: 0x06015FEA RID: 90090 RVA: 0x003290A4 File Offset: 0x003272A4
		public static IWoodenBoxProliferatePositionList GetRootAsIWoodenBoxProliferatePositionList(ByteBuffer _bb, IWoodenBoxProliferatePositionList obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015FEB RID: 90091 RVA: 0x003290C1 File Offset: 0x003272C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015FEC RID: 90092 RVA: 0x003290D0 File Offset: 0x003272D0
		public IWoodenBoxProliferatePositionList __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006D95 RID: 28053
		// (get) Token: 0x06015FED RID: 90093 RVA: 0x003290E0 File Offset: 0x003272E0
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

		// Token: 0x06015FEE RID: 90094 RVA: 0x0032911C File Offset: 0x0032731C
		public IVectorInfo? Positions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17006D96 RID: 28054
		// (get) Token: 0x06015FEF RID: 90095 RVA: 0x0032917C File Offset: 0x0032737C
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

		// Token: 0x06015FF0 RID: 90096 RVA: 0x003291A7 File Offset: 0x003273A7
		public static Offset<IWoodenBoxProliferatePositionList> CreateIWoodenBoxProliferatePositionList(FlatBufferBuilder builder, EWoodenBoxProliferateSpawnType Type = EWoodenBoxProliferateSpawnType.RandomInRange, VectorOffset PositionsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IWoodenBoxProliferatePositionList.AddPositions(builder, PositionsOffset);
			IWoodenBoxProliferatePositionList.AddType(builder, Type);
			return IWoodenBoxProliferatePositionList.EndIWoodenBoxProliferatePositionList(builder);
		}

		// Token: 0x06015FF1 RID: 90097 RVA: 0x003291C4 File Offset: 0x003273C4
		public static void StartIWoodenBoxProliferatePositionList(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06015FF2 RID: 90098 RVA: 0x003291CD File Offset: 0x003273CD
		public static void AddType(FlatBufferBuilder builder, EWoodenBoxProliferateSpawnType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015FF3 RID: 90099 RVA: 0x003291D8 File Offset: 0x003273D8
		public static void AddPositions(FlatBufferBuilder builder, VectorOffset positionsOffset)
		{
			builder.AddOffset(1, positionsOffset.Value, 0);
		}

		// Token: 0x06015FF4 RID: 90100 RVA: 0x003291E8 File Offset: 0x003273E8
		public static VectorOffset CreatePositionsVector(FlatBufferBuilder builder, Offset<IVectorInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06015FF5 RID: 90101 RVA: 0x00329228 File Offset: 0x00327428
		public static VectorOffset CreatePositionsVectorBlock(FlatBufferBuilder builder, Offset<IVectorInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IVectorInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06015FF6 RID: 90102 RVA: 0x00329242 File Offset: 0x00327442
		public static VectorOffset CreatePositionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IVectorInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IVectorInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06015FF7 RID: 90103 RVA: 0x00329260 File Offset: 0x00327460
		public static VectorOffset CreatePositionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IVectorInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06015FF8 RID: 90104 RVA: 0x00329279 File Offset: 0x00327479
		public static void StartPositionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06015FF9 RID: 90105 RVA: 0x00329284 File Offset: 0x00327484
		public static Offset<IWoodenBoxProliferatePositionList> EndIWoodenBoxProliferatePositionList(FlatBufferBuilder builder)
		{
			return new Offset<IWoodenBoxProliferatePositionList>(builder.EndTable());
		}

		// Token: 0x06015FFA RID: 90106 RVA: 0x00329294 File Offset: 0x00327494
		public IWoodenBoxProliferatePositionListT UnPack()
		{
			IWoodenBoxProliferatePositionListT woodenBoxProliferatePositionListT = new IWoodenBoxProliferatePositionListT();
			this.UnPackTo(woodenBoxProliferatePositionListT);
			return woodenBoxProliferatePositionListT;
		}

		// Token: 0x06015FFB RID: 90107 RVA: 0x003292B0 File Offset: 0x003274B0
		public void UnPackTo(IWoodenBoxProliferatePositionListT _o)
		{
			_o.Type = this.Type;
			_o.Positions = new List<IVectorInfoT>();
			for (int i = 0; i < this.PositionsLength; i++)
			{
				_o.Positions.Add((this.Positions(i) != null) ? this.Positions(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06015FFC RID: 90108 RVA: 0x0032931C File Offset: 0x0032751C
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

		// Token: 0x0400B97C RID: 47484
		private Table __p;
	}
}
