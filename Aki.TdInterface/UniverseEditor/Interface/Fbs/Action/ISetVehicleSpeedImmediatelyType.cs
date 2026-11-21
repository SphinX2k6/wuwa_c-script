using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007872 RID: 30834
	public struct ISetVehicleSpeedImmediatelyType : IFlatbufferObject
	{
		// Token: 0x1700E221 RID: 57889
		// (get) Token: 0x060363B1 RID: 222129 RVA: 0x00743B64 File Offset: 0x00741D64
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060363B2 RID: 222130 RVA: 0x00743B71 File Offset: 0x00741D71
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060363B3 RID: 222131 RVA: 0x00743B78 File Offset: 0x00741D78
		public static ISetVehicleSpeedImmediatelyType GetRootAsISetVehicleSpeedImmediatelyType(ByteBuffer _bb)
		{
			return ISetVehicleSpeedImmediatelyType.GetRootAsISetVehicleSpeedImmediatelyType(_bb, default(ISetVehicleSpeedImmediatelyType));
		}

		// Token: 0x060363B4 RID: 222132 RVA: 0x00743B94 File Offset: 0x00741D94
		public static ISetVehicleSpeedImmediatelyType GetRootAsISetVehicleSpeedImmediatelyType(ByteBuffer _bb, ISetVehicleSpeedImmediatelyType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060363B5 RID: 222133 RVA: 0x00743BB1 File Offset: 0x00741DB1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060363B6 RID: 222134 RVA: 0x00743BC0 File Offset: 0x00741DC0
		public ISetVehicleSpeedImmediatelyType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E222 RID: 57890
		// (get) Token: 0x060363B7 RID: 222135 RVA: 0x00743BD0 File Offset: 0x00741DD0
		public ESetVehicleSpeedImmediatelyType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESetVehicleSpeedImmediatelyType.TotalSpeed;
				}
				return (ESetVehicleSpeedImmediatelyType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060363B8 RID: 222136 RVA: 0x00743C0C File Offset: 0x00741E0C
		public static Offset<ISetVehicleSpeedImmediatelyType> CreateISetVehicleSpeedImmediatelyType(FlatBufferBuilder builder, ESetVehicleSpeedImmediatelyType Type = ESetVehicleSpeedImmediatelyType.TotalSpeed)
		{
			builder.StartTable(1);
			ISetVehicleSpeedImmediatelyType.AddType(builder, Type);
			return ISetVehicleSpeedImmediatelyType.EndISetVehicleSpeedImmediatelyType(builder);
		}

		// Token: 0x060363B9 RID: 222137 RVA: 0x00743C22 File Offset: 0x00741E22
		public static void StartISetVehicleSpeedImmediatelyType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060363BA RID: 222138 RVA: 0x00743C2B File Offset: 0x00741E2B
		public static void AddType(FlatBufferBuilder builder, ESetVehicleSpeedImmediatelyType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060363BB RID: 222139 RVA: 0x00743C36 File Offset: 0x00741E36
		public static Offset<ISetVehicleSpeedImmediatelyType> EndISetVehicleSpeedImmediatelyType(FlatBufferBuilder builder)
		{
			return new Offset<ISetVehicleSpeedImmediatelyType>(builder.EndTable());
		}

		// Token: 0x060363BC RID: 222140 RVA: 0x00743C44 File Offset: 0x00741E44
		public ISetVehicleSpeedImmediatelyTypeT UnPack()
		{
			ISetVehicleSpeedImmediatelyTypeT setVehicleSpeedImmediatelyTypeT = new ISetVehicleSpeedImmediatelyTypeT();
			this.UnPackTo(setVehicleSpeedImmediatelyTypeT);
			return setVehicleSpeedImmediatelyTypeT;
		}

		// Token: 0x060363BD RID: 222141 RVA: 0x00743C5F File Offset: 0x00741E5F
		public void UnPackTo(ISetVehicleSpeedImmediatelyTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060363BE RID: 222142 RVA: 0x00743C70 File Offset: 0x00741E70
		public static Offset<ISetVehicleSpeedImmediatelyType> Pack(FlatBufferBuilder builder, ISetVehicleSpeedImmediatelyTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetVehicleSpeedImmediatelyType>);
			}
			return ISetVehicleSpeedImmediatelyType.CreateISetVehicleSpeedImmediatelyType(builder, _o.Type);
		}

		// Token: 0x04012AFC RID: 76540
		private Table __p;
	}
}
