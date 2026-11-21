using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061DD RID: 25053
	public struct IWuWaGoMovableFloor : IFlatbufferObject
	{
		// Token: 0x1700BACB RID: 47819
		// (get) Token: 0x0602A9AD RID: 174509 RVA: 0x005CF2D6 File Offset: 0x005CD4D6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A9AE RID: 174510 RVA: 0x005CF2E3 File Offset: 0x005CD4E3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A9AF RID: 174511 RVA: 0x005CF2EC File Offset: 0x005CD4EC
		public static IWuWaGoMovableFloor GetRootAsIWuWaGoMovableFloor(ByteBuffer _bb)
		{
			return IWuWaGoMovableFloor.GetRootAsIWuWaGoMovableFloor(_bb, default(IWuWaGoMovableFloor));
		}

		// Token: 0x0602A9B0 RID: 174512 RVA: 0x005CF308 File Offset: 0x005CD508
		public static IWuWaGoMovableFloor GetRootAsIWuWaGoMovableFloor(ByteBuffer _bb, IWuWaGoMovableFloor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A9B1 RID: 174513 RVA: 0x005CF325 File Offset: 0x005CD525
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A9B2 RID: 174514 RVA: 0x005CF334 File Offset: 0x005CD534
		public IWuWaGoMovableFloor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BACC RID: 47820
		// (get) Token: 0x0602A9B3 RID: 174515 RVA: 0x005CF344 File Offset: 0x005CD544
		public EWuWaGoEntityType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EWuWaGoEntityType.LevelCenter;
				}
				return (EWuWaGoEntityType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BACD RID: 47821
		// (get) Token: 0x0602A9B4 RID: 174516 RVA: 0x005CF380 File Offset: 0x005CD580
		public IWuWaGoGridLinkData? LinkData
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IWuWaGoGridLinkData?(default(IWuWaGoGridLinkData).__assign(num + this.__p.bb_pos, this.__p.bb));
			}
		}

		// Token: 0x1700BACE RID: 47822
		// (get) Token: 0x0602A9B5 RID: 174517 RVA: 0x005CF3D4 File Offset: 0x005CD5D4
		public IWuWaGoGridLinkData? GearLinkData
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IWuWaGoGridLinkData?(default(IWuWaGoGridLinkData).__assign(num + this.__p.bb_pos, this.__p.bb));
			}
		}

		// Token: 0x0602A9B6 RID: 174518 RVA: 0x005CF428 File Offset: 0x005CD628
		public IWuWaGoMovableGridStatePos? MoveData(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IWuWaGoMovableGridStatePos?(default(IWuWaGoMovableGridStatePos).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700BACF RID: 47823
		// (get) Token: 0x0602A9B7 RID: 174519 RVA: 0x005CF48C File Offset: 0x005CD68C
		public int MoveDataLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602A9B8 RID: 174520 RVA: 0x005CF4B8 File Offset: 0x005CD6B8
		public static Offset<IWuWaGoMovableFloor> CreateIWuWaGoMovableFloor(FlatBufferBuilder builder, EWuWaGoEntityType Type = EWuWaGoEntityType.LevelCenter, IWuWaGoGridLinkDataT LinkData = null, IWuWaGoGridLinkDataT GearLinkData = null, VectorOffset MoveDataOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			IWuWaGoMovableFloor.AddMoveData(builder, MoveDataOffset);
			IWuWaGoMovableFloor.AddGearLinkData(builder, IWuWaGoGridLinkData.Pack(builder, GearLinkData));
			IWuWaGoMovableFloor.AddLinkData(builder, IWuWaGoGridLinkData.Pack(builder, LinkData));
			IWuWaGoMovableFloor.AddType(builder, Type);
			return IWuWaGoMovableFloor.EndIWuWaGoMovableFloor(builder);
		}

		// Token: 0x0602A9B9 RID: 174521 RVA: 0x005CF4F0 File Offset: 0x005CD6F0
		public static void StartIWuWaGoMovableFloor(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602A9BA RID: 174522 RVA: 0x005CF4F9 File Offset: 0x005CD6F9
		public static void AddType(FlatBufferBuilder builder, EWuWaGoEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A9BB RID: 174523 RVA: 0x005CF504 File Offset: 0x005CD704
		public static void AddLinkData(FlatBufferBuilder builder, Offset<IWuWaGoGridLinkData> linkDataOffset)
		{
			builder.AddStruct(1, linkDataOffset.Value, 0);
		}

		// Token: 0x0602A9BC RID: 174524 RVA: 0x005CF514 File Offset: 0x005CD714
		public static void AddGearLinkData(FlatBufferBuilder builder, Offset<IWuWaGoGridLinkData> gearLinkDataOffset)
		{
			builder.AddStruct(2, gearLinkDataOffset.Value, 0);
		}

		// Token: 0x0602A9BD RID: 174525 RVA: 0x005CF524 File Offset: 0x005CD724
		public static void AddMoveData(FlatBufferBuilder builder, VectorOffset moveDataOffset)
		{
			builder.AddOffset(3, moveDataOffset.Value, 0);
		}

		// Token: 0x0602A9BE RID: 174526 RVA: 0x005CF534 File Offset: 0x005CD734
		public static VectorOffset CreateMoveDataVector(FlatBufferBuilder builder, Offset<IWuWaGoMovableGridStatePos>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602A9BF RID: 174527 RVA: 0x005CF574 File Offset: 0x005CD774
		public static VectorOffset CreateMoveDataVectorBlock(FlatBufferBuilder builder, Offset<IWuWaGoMovableGridStatePos>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IWuWaGoMovableGridStatePos>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A9C0 RID: 174528 RVA: 0x005CF58E File Offset: 0x005CD78E
		public static VectorOffset CreateMoveDataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IWuWaGoMovableGridStatePos>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IWuWaGoMovableGridStatePos>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A9C1 RID: 174529 RVA: 0x005CF5AC File Offset: 0x005CD7AC
		public static VectorOffset CreateMoveDataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IWuWaGoMovableGridStatePos>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602A9C2 RID: 174530 RVA: 0x005CF5C5 File Offset: 0x005CD7C5
		public static void StartMoveDataVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602A9C3 RID: 174531 RVA: 0x005CF5D0 File Offset: 0x005CD7D0
		public static Offset<IWuWaGoMovableFloor> EndIWuWaGoMovableFloor(FlatBufferBuilder builder)
		{
			return new Offset<IWuWaGoMovableFloor>(builder.EndTable());
		}

		// Token: 0x0602A9C4 RID: 174532 RVA: 0x005CF5E0 File Offset: 0x005CD7E0
		public IWuWaGoMovableFloorT UnPack()
		{
			IWuWaGoMovableFloorT wuWaGoMovableFloorT = new IWuWaGoMovableFloorT();
			this.UnPackTo(wuWaGoMovableFloorT);
			return wuWaGoMovableFloorT;
		}

		// Token: 0x0602A9C5 RID: 174533 RVA: 0x005CF5FC File Offset: 0x005CD7FC
		public void UnPackTo(IWuWaGoMovableFloorT _o)
		{
			_o.Type = this.Type;
			_o.LinkData = ((this.LinkData != null) ? this.LinkData.Value.UnPack() : null);
			_o.GearLinkData = ((this.GearLinkData != null) ? this.GearLinkData.Value.UnPack() : null);
			_o.MoveData = new List<IWuWaGoMovableGridStatePosT>();
			for (int i = 0; i < this.MoveDataLength; i++)
			{
				_o.MoveData.Add((this.MoveData(i) != null) ? this.MoveData(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0602A9C6 RID: 174534 RVA: 0x005CF6C8 File Offset: 0x005CD8C8
		public static Offset<IWuWaGoMovableFloor> Pack(FlatBufferBuilder builder, IWuWaGoMovableFloorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWuWaGoMovableFloor>);
			}
			VectorOffset moveDataOffset = default(VectorOffset);
			if (_o.MoveData != null)
			{
				Offset<IWuWaGoMovableGridStatePos>[] array = new Offset<IWuWaGoMovableGridStatePos>[_o.MoveData.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IWuWaGoMovableGridStatePos.Pack(builder, _o.MoveData[i]);
				}
				moveDataOffset = IWuWaGoMovableFloor.CreateMoveDataVector(builder, array);
			}
			return IWuWaGoMovableFloor.CreateIWuWaGoMovableFloor(builder, _o.Type, _o.LinkData, _o.GearLinkData, moveDataOffset);
		}

		// Token: 0x04010047 RID: 65607
		private Table __p;
	}
}
