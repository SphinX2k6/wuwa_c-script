using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EA0 RID: 28320
	public struct IResetPosByPosEntity : IFlatbufferObject
	{
		// Token: 0x1700D2DD RID: 53981
		// (get) Token: 0x060320DB RID: 205019 RVA: 0x006C4FE2 File Offset: 0x006C31E2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060320DC RID: 205020 RVA: 0x006C4FEF File Offset: 0x006C31EF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060320DD RID: 205021 RVA: 0x006C4FF8 File Offset: 0x006C31F8
		public static IResetPosByPosEntity GetRootAsIResetPosByPosEntity(ByteBuffer _bb)
		{
			return IResetPosByPosEntity.GetRootAsIResetPosByPosEntity(_bb, default(IResetPosByPosEntity));
		}

		// Token: 0x060320DE RID: 205022 RVA: 0x006C5014 File Offset: 0x006C3214
		public static IResetPosByPosEntity GetRootAsIResetPosByPosEntity(ByteBuffer _bb, IResetPosByPosEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060320DF RID: 205023 RVA: 0x006C5031 File Offset: 0x006C3231
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060320E0 RID: 205024 RVA: 0x006C5040 File Offset: 0x006C3240
		public IResetPosByPosEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D2DE RID: 53982
		// (get) Token: 0x060320E1 RID: 205025 RVA: 0x006C5050 File Offset: 0x006C3250
		public EResetPosType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EResetPosType.PosEntity;
				}
				return (EResetPosType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D2DF RID: 53983
		// (get) Token: 0x060320E2 RID: 205026 RVA: 0x006C508C File Offset: 0x006C328C
		public int Entity
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060320E3 RID: 205027 RVA: 0x006C50C8 File Offset: 0x006C32C8
		public static Offset<IResetPosByPosEntity> CreateIResetPosByPosEntity(FlatBufferBuilder builder, EResetPosType Type = EResetPosType.PosEntity, int Entity = 0)
		{
			builder.StartTable(2);
			IResetPosByPosEntity.AddEntity(builder, Entity);
			IResetPosByPosEntity.AddType(builder, Type);
			return IResetPosByPosEntity.EndIResetPosByPosEntity(builder);
		}

		// Token: 0x060320E4 RID: 205028 RVA: 0x006C50E5 File Offset: 0x006C32E5
		public static void StartIResetPosByPosEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060320E5 RID: 205029 RVA: 0x006C50EE File Offset: 0x006C32EE
		public static void AddType(FlatBufferBuilder builder, EResetPosType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060320E6 RID: 205030 RVA: 0x006C50F9 File Offset: 0x006C32F9
		public static void AddEntity(FlatBufferBuilder builder, int entity)
		{
			builder.AddInt(1, entity, 0);
		}

		// Token: 0x060320E7 RID: 205031 RVA: 0x006C5104 File Offset: 0x006C3304
		public static Offset<IResetPosByPosEntity> EndIResetPosByPosEntity(FlatBufferBuilder builder)
		{
			return new Offset<IResetPosByPosEntity>(builder.EndTable());
		}

		// Token: 0x060320E8 RID: 205032 RVA: 0x006C5114 File Offset: 0x006C3314
		public IResetPosByPosEntityT UnPack()
		{
			IResetPosByPosEntityT resetPosByPosEntityT = new IResetPosByPosEntityT();
			this.UnPackTo(resetPosByPosEntityT);
			return resetPosByPosEntityT;
		}

		// Token: 0x060320E9 RID: 205033 RVA: 0x006C512F File Offset: 0x006C332F
		public void UnPackTo(IResetPosByPosEntityT _o)
		{
			_o.Type = this.Type;
			_o.Entity = this.Entity;
		}

		// Token: 0x060320EA RID: 205034 RVA: 0x006C514C File Offset: 0x006C334C
		public static Offset<IResetPosByPosEntity> Pack(FlatBufferBuilder builder, IResetPosByPosEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<IResetPosByPosEntity>);
			}
			return IResetPosByPosEntity.CreateIResetPosByPosEntity(builder, _o.Type, _o.Entity);
		}

		// Token: 0x04011893 RID: 71827
		private Table __p;
	}
}
