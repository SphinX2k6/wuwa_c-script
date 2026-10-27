using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A1C RID: 23068
	public struct ISystemModuleDataSyncData : IFlatbufferObject
	{
		// Token: 0x1700AD6B RID: 44395
		// (get) Token: 0x060272DB RID: 160475 RVA: 0x00563B93 File Offset: 0x00561D93
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060272DC RID: 160476 RVA: 0x00563BA0 File Offset: 0x00561DA0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060272DD RID: 160477 RVA: 0x00563BA8 File Offset: 0x00561DA8
		public static ISystemModuleDataSyncData GetRootAsISystemModuleDataSyncData(ByteBuffer _bb)
		{
			return ISystemModuleDataSyncData.GetRootAsISystemModuleDataSyncData(_bb, default(ISystemModuleDataSyncData));
		}

		// Token: 0x060272DE RID: 160478 RVA: 0x00563BC4 File Offset: 0x00561DC4
		public static ISystemModuleDataSyncData GetRootAsISystemModuleDataSyncData(ByteBuffer _bb, ISystemModuleDataSyncData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060272DF RID: 160479 RVA: 0x00563BE1 File Offset: 0x00561DE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060272E0 RID: 160480 RVA: 0x00563BF0 File Offset: 0x00561DF0
		public ISystemModuleDataSyncData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AD6C RID: 44396
		// (get) Token: 0x060272E1 RID: 160481 RVA: 0x00563C00 File Offset: 0x00561E00
		public ESyncDataSystemType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESyncDataSystemType.MotorRacing;
				}
				return (ESyncDataSystemType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060272E2 RID: 160482 RVA: 0x00563C3C File Offset: 0x00561E3C
		public static Offset<ISystemModuleDataSyncData> CreateISystemModuleDataSyncData(FlatBufferBuilder builder, ESyncDataSystemType Type = ESyncDataSystemType.MotorRacing)
		{
			builder.StartTable(1);
			ISystemModuleDataSyncData.AddType(builder, Type);
			return ISystemModuleDataSyncData.EndISystemModuleDataSyncData(builder);
		}

		// Token: 0x060272E3 RID: 160483 RVA: 0x00563C52 File Offset: 0x00561E52
		public static void StartISystemModuleDataSyncData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060272E4 RID: 160484 RVA: 0x00563C5B File Offset: 0x00561E5B
		public static void AddType(FlatBufferBuilder builder, ESyncDataSystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060272E5 RID: 160485 RVA: 0x00563C66 File Offset: 0x00561E66
		public static Offset<ISystemModuleDataSyncData> EndISystemModuleDataSyncData(FlatBufferBuilder builder)
		{
			return new Offset<ISystemModuleDataSyncData>(builder.EndTable());
		}

		// Token: 0x060272E6 RID: 160486 RVA: 0x00563C74 File Offset: 0x00561E74
		public ISystemModuleDataSyncDataT UnPack()
		{
			ISystemModuleDataSyncDataT systemModuleDataSyncDataT = new ISystemModuleDataSyncDataT();
			this.UnPackTo(systemModuleDataSyncDataT);
			return systemModuleDataSyncDataT;
		}

		// Token: 0x060272E7 RID: 160487 RVA: 0x00563C8F File Offset: 0x00561E8F
		public void UnPackTo(ISystemModuleDataSyncDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060272E8 RID: 160488 RVA: 0x00563CA0 File Offset: 0x00561EA0
		public static Offset<ISystemModuleDataSyncData> Pack(FlatBufferBuilder builder, ISystemModuleDataSyncDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISystemModuleDataSyncData>);
			}
			return ISystemModuleDataSyncData.CreateISystemModuleDataSyncData(builder, _o.Type);
		}

		// Token: 0x0400F070 RID: 61552
		private Table __p;
	}
}
