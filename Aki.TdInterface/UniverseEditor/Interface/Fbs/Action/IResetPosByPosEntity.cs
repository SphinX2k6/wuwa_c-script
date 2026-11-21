using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007624 RID: 30244
	public struct IResetPosByPosEntity : IFlatbufferObject
	{
		// Token: 0x1700DE34 RID: 56884
		// (get) Token: 0x0603511B RID: 217371 RVA: 0x00720D16 File Offset: 0x0071EF16
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603511C RID: 217372 RVA: 0x00720D23 File Offset: 0x0071EF23
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603511D RID: 217373 RVA: 0x00720D2C File Offset: 0x0071EF2C
		public static IResetPosByPosEntity GetRootAsIResetPosByPosEntity(ByteBuffer _bb)
		{
			return IResetPosByPosEntity.GetRootAsIResetPosByPosEntity(_bb, default(IResetPosByPosEntity));
		}

		// Token: 0x0603511E RID: 217374 RVA: 0x00720D48 File Offset: 0x0071EF48
		public static IResetPosByPosEntity GetRootAsIResetPosByPosEntity(ByteBuffer _bb, IResetPosByPosEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603511F RID: 217375 RVA: 0x00720D65 File Offset: 0x0071EF65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035120 RID: 217376 RVA: 0x00720D74 File Offset: 0x0071EF74
		public IResetPosByPosEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DE35 RID: 56885
		// (get) Token: 0x06035121 RID: 217377 RVA: 0x00720D84 File Offset: 0x0071EF84
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

		// Token: 0x1700DE36 RID: 56886
		// (get) Token: 0x06035122 RID: 217378 RVA: 0x00720DC0 File Offset: 0x0071EFC0
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

		// Token: 0x06035123 RID: 217379 RVA: 0x00720DFC File Offset: 0x0071EFFC
		public static Offset<IResetPosByPosEntity> CreateIResetPosByPosEntity(FlatBufferBuilder builder, EResetPosType Type = EResetPosType.PosEntity, int Entity = 0)
		{
			builder.StartTable(2);
			IResetPosByPosEntity.AddEntity(builder, Entity);
			IResetPosByPosEntity.AddType(builder, Type);
			return IResetPosByPosEntity.EndIResetPosByPosEntity(builder);
		}

		// Token: 0x06035124 RID: 217380 RVA: 0x00720E19 File Offset: 0x0071F019
		public static void StartIResetPosByPosEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06035125 RID: 217381 RVA: 0x00720E22 File Offset: 0x0071F022
		public static void AddType(FlatBufferBuilder builder, EResetPosType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035126 RID: 217382 RVA: 0x00720E2D File Offset: 0x0071F02D
		public static void AddEntity(FlatBufferBuilder builder, int entity)
		{
			builder.AddInt(1, entity, 0);
		}

		// Token: 0x06035127 RID: 217383 RVA: 0x00720E38 File Offset: 0x0071F038
		public static Offset<IResetPosByPosEntity> EndIResetPosByPosEntity(FlatBufferBuilder builder)
		{
			return new Offset<IResetPosByPosEntity>(builder.EndTable());
		}

		// Token: 0x06035128 RID: 217384 RVA: 0x00720E48 File Offset: 0x0071F048
		public IResetPosByPosEntityT UnPack()
		{
			IResetPosByPosEntityT resetPosByPosEntityT = new IResetPosByPosEntityT();
			this.UnPackTo(resetPosByPosEntityT);
			return resetPosByPosEntityT;
		}

		// Token: 0x06035129 RID: 217385 RVA: 0x00720E63 File Offset: 0x0071F063
		public void UnPackTo(IResetPosByPosEntityT _o)
		{
			_o.Type = this.Type;
			_o.Entity = this.Entity;
		}

		// Token: 0x0603512A RID: 217386 RVA: 0x00720E80 File Offset: 0x0071F080
		public static Offset<IResetPosByPosEntity> Pack(FlatBufferBuilder builder, IResetPosByPosEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<IResetPosByPosEntity>);
			}
			return IResetPosByPosEntity.CreateIResetPosByPosEntity(builder, _o.Type, _o.Entity);
		}

		// Token: 0x04012818 RID: 75800
		private Table __p;
	}
}
