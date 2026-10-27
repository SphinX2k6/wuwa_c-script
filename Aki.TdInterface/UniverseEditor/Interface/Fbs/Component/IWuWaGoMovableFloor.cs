using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BC7 RID: 23495
	public struct IWuWaGoMovableFloor : IFlatbufferObject
	{
		// Token: 0x1700B183 RID: 45443
		// (get) Token: 0x060283E9 RID: 164841 RVA: 0x00587846 File Offset: 0x00585A46
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060283EA RID: 164842 RVA: 0x00587853 File Offset: 0x00585A53
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060283EB RID: 164843 RVA: 0x0058785C File Offset: 0x00585A5C
		public static IWuWaGoMovableFloor GetRootAsIWuWaGoMovableFloor(ByteBuffer _bb)
		{
			return IWuWaGoMovableFloor.GetRootAsIWuWaGoMovableFloor(_bb, default(IWuWaGoMovableFloor));
		}

		// Token: 0x060283EC RID: 164844 RVA: 0x00587878 File Offset: 0x00585A78
		public static IWuWaGoMovableFloor GetRootAsIWuWaGoMovableFloor(ByteBuffer _bb, IWuWaGoMovableFloor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060283ED RID: 164845 RVA: 0x00587895 File Offset: 0x00585A95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060283EE RID: 164846 RVA: 0x005878A4 File Offset: 0x00585AA4
		public IWuWaGoMovableFloor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B184 RID: 45444
		// (get) Token: 0x060283EF RID: 164847 RVA: 0x005878B4 File Offset: 0x00585AB4
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

		// Token: 0x1700B185 RID: 45445
		// (get) Token: 0x060283F0 RID: 164848 RVA: 0x005878F0 File Offset: 0x00585AF0
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

		// Token: 0x1700B186 RID: 45446
		// (get) Token: 0x060283F1 RID: 164849 RVA: 0x00587944 File Offset: 0x00585B44
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

		// Token: 0x060283F2 RID: 164850 RVA: 0x00587998 File Offset: 0x00585B98
		public IWuWaGoMovableGridStatePos? MoveData(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IWuWaGoMovableGridStatePos?(default(IWuWaGoMovableGridStatePos).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B187 RID: 45447
		// (get) Token: 0x060283F3 RID: 164851 RVA: 0x005879FC File Offset: 0x00585BFC
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

		// Token: 0x060283F4 RID: 164852 RVA: 0x00587A28 File Offset: 0x00585C28
		public static Offset<IWuWaGoMovableFloor> CreateIWuWaGoMovableFloor(FlatBufferBuilder builder, EWuWaGoEntityType Type = EWuWaGoEntityType.LevelCenter, IWuWaGoGridLinkDataT LinkData = null, IWuWaGoGridLinkDataT GearLinkData = null, VectorOffset MoveDataOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			IWuWaGoMovableFloor.AddMoveData(builder, MoveDataOffset);
			IWuWaGoMovableFloor.AddGearLinkData(builder, IWuWaGoGridLinkData.Pack(builder, GearLinkData));
			IWuWaGoMovableFloor.AddLinkData(builder, IWuWaGoGridLinkData.Pack(builder, LinkData));
			IWuWaGoMovableFloor.AddType(builder, Type);
			return IWuWaGoMovableFloor.EndIWuWaGoMovableFloor(builder);
		}

		// Token: 0x060283F5 RID: 164853 RVA: 0x00587A60 File Offset: 0x00585C60
		public static void StartIWuWaGoMovableFloor(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060283F6 RID: 164854 RVA: 0x00587A69 File Offset: 0x00585C69
		public static void AddType(FlatBufferBuilder builder, EWuWaGoEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060283F7 RID: 164855 RVA: 0x00587A74 File Offset: 0x00585C74
		public static void AddLinkData(FlatBufferBuilder builder, Offset<IWuWaGoGridLinkData> linkDataOffset)
		{
			builder.AddStruct(1, linkDataOffset.Value, 0);
		}

		// Token: 0x060283F8 RID: 164856 RVA: 0x00587A84 File Offset: 0x00585C84
		public static void AddGearLinkData(FlatBufferBuilder builder, Offset<IWuWaGoGridLinkData> gearLinkDataOffset)
		{
			builder.AddStruct(2, gearLinkDataOffset.Value, 0);
		}

		// Token: 0x060283F9 RID: 164857 RVA: 0x00587A94 File Offset: 0x00585C94
		public static void AddMoveData(FlatBufferBuilder builder, VectorOffset moveDataOffset)
		{
			builder.AddOffset(3, moveDataOffset.Value, 0);
		}

		// Token: 0x060283FA RID: 164858 RVA: 0x00587AA4 File Offset: 0x00585CA4
		public static VectorOffset CreateMoveDataVector(FlatBufferBuilder builder, Offset<IWuWaGoMovableGridStatePos>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060283FB RID: 164859 RVA: 0x00587AE4 File Offset: 0x00585CE4
		public static VectorOffset CreateMoveDataVectorBlock(FlatBufferBuilder builder, Offset<IWuWaGoMovableGridStatePos>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IWuWaGoMovableGridStatePos>>(data);
			return builder.EndVector();
		}

		// Token: 0x060283FC RID: 164860 RVA: 0x00587AFE File Offset: 0x00585CFE
		public static VectorOffset CreateMoveDataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IWuWaGoMovableGridStatePos>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IWuWaGoMovableGridStatePos>>(data);
			return builder.EndVector();
		}

		// Token: 0x060283FD RID: 164861 RVA: 0x00587B1C File Offset: 0x00585D1C
		public static VectorOffset CreateMoveDataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IWuWaGoMovableGridStatePos>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060283FE RID: 164862 RVA: 0x00587B35 File Offset: 0x00585D35
		public static void StartMoveDataVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060283FF RID: 164863 RVA: 0x00587B40 File Offset: 0x00585D40
		public static Offset<IWuWaGoMovableFloor> EndIWuWaGoMovableFloor(FlatBufferBuilder builder)
		{
			return new Offset<IWuWaGoMovableFloor>(builder.EndTable());
		}

		// Token: 0x06028400 RID: 164864 RVA: 0x00587B50 File Offset: 0x00585D50
		public IWuWaGoMovableFloorT UnPack()
		{
			IWuWaGoMovableFloorT wuWaGoMovableFloorT = new IWuWaGoMovableFloorT();
			this.UnPackTo(wuWaGoMovableFloorT);
			return wuWaGoMovableFloorT;
		}

		// Token: 0x06028401 RID: 164865 RVA: 0x00587B6C File Offset: 0x00585D6C
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

		// Token: 0x06028402 RID: 164866 RVA: 0x00587C38 File Offset: 0x00585E38
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

		// Token: 0x0400F341 RID: 62273
		private Table __p;
	}
}
