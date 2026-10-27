using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070A6 RID: 28838
	public struct ISetVehicleSpeedImmediatelyType : IFlatbufferObject
	{
		// Token: 0x1700D63E RID: 54846
		// (get) Token: 0x0603310F RID: 209167 RVA: 0x006E3558 File Offset: 0x006E1758
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033110 RID: 209168 RVA: 0x006E3565 File Offset: 0x006E1765
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033111 RID: 209169 RVA: 0x006E356C File Offset: 0x006E176C
		public static ISetVehicleSpeedImmediatelyType GetRootAsISetVehicleSpeedImmediatelyType(ByteBuffer _bb)
		{
			return ISetVehicleSpeedImmediatelyType.GetRootAsISetVehicleSpeedImmediatelyType(_bb, default(ISetVehicleSpeedImmediatelyType));
		}

		// Token: 0x06033112 RID: 209170 RVA: 0x006E3588 File Offset: 0x006E1788
		public static ISetVehicleSpeedImmediatelyType GetRootAsISetVehicleSpeedImmediatelyType(ByteBuffer _bb, ISetVehicleSpeedImmediatelyType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033113 RID: 209171 RVA: 0x006E35A5 File Offset: 0x006E17A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033114 RID: 209172 RVA: 0x006E35B4 File Offset: 0x006E17B4
		public ISetVehicleSpeedImmediatelyType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D63F RID: 54847
		// (get) Token: 0x06033115 RID: 209173 RVA: 0x006E35C4 File Offset: 0x006E17C4
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

		// Token: 0x06033116 RID: 209174 RVA: 0x006E3600 File Offset: 0x006E1800
		public static Offset<ISetVehicleSpeedImmediatelyType> CreateISetVehicleSpeedImmediatelyType(FlatBufferBuilder builder, ESetVehicleSpeedImmediatelyType Type = ESetVehicleSpeedImmediatelyType.TotalSpeed)
		{
			builder.StartTable(1);
			ISetVehicleSpeedImmediatelyType.AddType(builder, Type);
			return ISetVehicleSpeedImmediatelyType.EndISetVehicleSpeedImmediatelyType(builder);
		}

		// Token: 0x06033117 RID: 209175 RVA: 0x006E3616 File Offset: 0x006E1816
		public static void StartISetVehicleSpeedImmediatelyType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06033118 RID: 209176 RVA: 0x006E361F File Offset: 0x006E181F
		public static void AddType(FlatBufferBuilder builder, ESetVehicleSpeedImmediatelyType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033119 RID: 209177 RVA: 0x006E362A File Offset: 0x006E182A
		public static Offset<ISetVehicleSpeedImmediatelyType> EndISetVehicleSpeedImmediatelyType(FlatBufferBuilder builder)
		{
			return new Offset<ISetVehicleSpeedImmediatelyType>(builder.EndTable());
		}

		// Token: 0x0603311A RID: 209178 RVA: 0x006E3638 File Offset: 0x006E1838
		public ISetVehicleSpeedImmediatelyTypeT UnPack()
		{
			ISetVehicleSpeedImmediatelyTypeT setVehicleSpeedImmediatelyTypeT = new ISetVehicleSpeedImmediatelyTypeT();
			this.UnPackTo(setVehicleSpeedImmediatelyTypeT);
			return setVehicleSpeedImmediatelyTypeT;
		}

		// Token: 0x0603311B RID: 209179 RVA: 0x006E3653 File Offset: 0x006E1853
		public void UnPackTo(ISetVehicleSpeedImmediatelyTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603311C RID: 209180 RVA: 0x006E3664 File Offset: 0x006E1864
		public static Offset<ISetVehicleSpeedImmediatelyType> Pack(FlatBufferBuilder builder, ISetVehicleSpeedImmediatelyTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetVehicleSpeedImmediatelyType>);
			}
			return ISetVehicleSpeedImmediatelyType.CreateISetVehicleSpeedImmediatelyType(builder, _o.Type);
		}

		// Token: 0x04011B0E RID: 72462
		private Table __p;
	}
}
