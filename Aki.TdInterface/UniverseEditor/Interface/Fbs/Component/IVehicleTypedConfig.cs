using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200613F RID: 24895
	public struct IVehicleTypedConfig : IFlatbufferObject
	{
		// Token: 0x1700B972 RID: 47474
		// (get) Token: 0x0602A3F0 RID: 173040 RVA: 0x005C3D92 File Offset: 0x005C1F92
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A3F1 RID: 173041 RVA: 0x005C3D9F File Offset: 0x005C1F9F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A3F2 RID: 173042 RVA: 0x005C3DA8 File Offset: 0x005C1FA8
		public static IVehicleTypedConfig GetRootAsIVehicleTypedConfig(ByteBuffer _bb)
		{
			return IVehicleTypedConfig.GetRootAsIVehicleTypedConfig(_bb, default(IVehicleTypedConfig));
		}

		// Token: 0x0602A3F3 RID: 173043 RVA: 0x005C3DC4 File Offset: 0x005C1FC4
		public static IVehicleTypedConfig GetRootAsIVehicleTypedConfig(ByteBuffer _bb, IVehicleTypedConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A3F4 RID: 173044 RVA: 0x005C3DE1 File Offset: 0x005C1FE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A3F5 RID: 173045 RVA: 0x005C3DF0 File Offset: 0x005C1FF0
		public IVehicleTypedConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B973 RID: 47475
		// (get) Token: 0x0602A3F6 RID: 173046 RVA: 0x005C3E00 File Offset: 0x005C2000
		public EVehicleType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVehicleType.Gongduola;
				}
				return (EVehicleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602A3F7 RID: 173047 RVA: 0x005C3E3C File Offset: 0x005C203C
		public static Offset<IVehicleTypedConfig> CreateIVehicleTypedConfig(FlatBufferBuilder builder, EVehicleType Type = EVehicleType.Gongduola)
		{
			builder.StartTable(1);
			IVehicleTypedConfig.AddType(builder, Type);
			return IVehicleTypedConfig.EndIVehicleTypedConfig(builder);
		}

		// Token: 0x0602A3F8 RID: 173048 RVA: 0x005C3E52 File Offset: 0x005C2052
		public static void StartIVehicleTypedConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602A3F9 RID: 173049 RVA: 0x005C3E5B File Offset: 0x005C205B
		public static void AddType(FlatBufferBuilder builder, EVehicleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A3FA RID: 173050 RVA: 0x005C3E66 File Offset: 0x005C2066
		public static Offset<IVehicleTypedConfig> EndIVehicleTypedConfig(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleTypedConfig>(builder.EndTable());
		}

		// Token: 0x0602A3FB RID: 173051 RVA: 0x005C3E74 File Offset: 0x005C2074
		public IVehicleTypedConfigT UnPack()
		{
			IVehicleTypedConfigT vehicleTypedConfigT = new IVehicleTypedConfigT();
			this.UnPackTo(vehicleTypedConfigT);
			return vehicleTypedConfigT;
		}

		// Token: 0x0602A3FC RID: 173052 RVA: 0x005C3E8F File Offset: 0x005C208F
		public void UnPackTo(IVehicleTypedConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602A3FD RID: 173053 RVA: 0x005C3EA0 File Offset: 0x005C20A0
		public static Offset<IVehicleTypedConfig> Pack(FlatBufferBuilder builder, IVehicleTypedConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVehicleTypedConfig>);
			}
			return IVehicleTypedConfig.CreateIVehicleTypedConfig(builder, _o.Type);
		}

		// Token: 0x0400FF52 RID: 65362
		private Table __p;
	}
}
