using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006029 RID: 24617
	public struct ISystemModuleDataSyncData : IFlatbufferObject
	{
		// Token: 0x1700B6A3 RID: 46755
		// (get) Token: 0x06029853 RID: 170067 RVA: 0x005AAB57 File Offset: 0x005A8D57
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029854 RID: 170068 RVA: 0x005AAB64 File Offset: 0x005A8D64
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029855 RID: 170069 RVA: 0x005AAB6C File Offset: 0x005A8D6C
		public static ISystemModuleDataSyncData GetRootAsISystemModuleDataSyncData(ByteBuffer _bb)
		{
			return ISystemModuleDataSyncData.GetRootAsISystemModuleDataSyncData(_bb, default(ISystemModuleDataSyncData));
		}

		// Token: 0x06029856 RID: 170070 RVA: 0x005AAB88 File Offset: 0x005A8D88
		public static ISystemModuleDataSyncData GetRootAsISystemModuleDataSyncData(ByteBuffer _bb, ISystemModuleDataSyncData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029857 RID: 170071 RVA: 0x005AABA5 File Offset: 0x005A8DA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029858 RID: 170072 RVA: 0x005AABB4 File Offset: 0x005A8DB4
		public ISystemModuleDataSyncData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B6A4 RID: 46756
		// (get) Token: 0x06029859 RID: 170073 RVA: 0x005AABC4 File Offset: 0x005A8DC4
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

		// Token: 0x0602985A RID: 170074 RVA: 0x005AAC00 File Offset: 0x005A8E00
		public static Offset<ISystemModuleDataSyncData> CreateISystemModuleDataSyncData(FlatBufferBuilder builder, ESyncDataSystemType Type = ESyncDataSystemType.MotorRacing)
		{
			builder.StartTable(1);
			ISystemModuleDataSyncData.AddType(builder, Type);
			return ISystemModuleDataSyncData.EndISystemModuleDataSyncData(builder);
		}

		// Token: 0x0602985B RID: 170075 RVA: 0x005AAC16 File Offset: 0x005A8E16
		public static void StartISystemModuleDataSyncData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602985C RID: 170076 RVA: 0x005AAC1F File Offset: 0x005A8E1F
		public static void AddType(FlatBufferBuilder builder, ESyncDataSystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602985D RID: 170077 RVA: 0x005AAC2A File Offset: 0x005A8E2A
		public static Offset<ISystemModuleDataSyncData> EndISystemModuleDataSyncData(FlatBufferBuilder builder)
		{
			return new Offset<ISystemModuleDataSyncData>(builder.EndTable());
		}

		// Token: 0x0602985E RID: 170078 RVA: 0x005AAC38 File Offset: 0x005A8E38
		public ISystemModuleDataSyncDataT UnPack()
		{
			ISystemModuleDataSyncDataT systemModuleDataSyncDataT = new ISystemModuleDataSyncDataT();
			this.UnPackTo(systemModuleDataSyncDataT);
			return systemModuleDataSyncDataT;
		}

		// Token: 0x0602985F RID: 170079 RVA: 0x005AAC53 File Offset: 0x005A8E53
		public void UnPackTo(ISystemModuleDataSyncDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06029860 RID: 170080 RVA: 0x005AAC64 File Offset: 0x005A8E64
		public static Offset<ISystemModuleDataSyncData> Pack(FlatBufferBuilder builder, ISystemModuleDataSyncDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISystemModuleDataSyncData>);
			}
			return ISystemModuleDataSyncData.CreateISystemModuleDataSyncData(builder, _o.Type);
		}

		// Token: 0x0400FD67 RID: 64871
		private Table __p;
	}
}
