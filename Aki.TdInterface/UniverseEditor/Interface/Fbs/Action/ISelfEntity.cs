using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200771A RID: 30490
	public struct ISelfEntity : IFlatbufferObject
	{
		// Token: 0x1700DF94 RID: 57236
		// (get) Token: 0x060357E9 RID: 219113 RVA: 0x0072C02D File Offset: 0x0072A22D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060357EA RID: 219114 RVA: 0x0072C03A File Offset: 0x0072A23A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060357EB RID: 219115 RVA: 0x0072C044 File Offset: 0x0072A244
		public static ISelfEntity GetRootAsISelfEntity(ByteBuffer _bb)
		{
			return ISelfEntity.GetRootAsISelfEntity(_bb, default(ISelfEntity));
		}

		// Token: 0x060357EC RID: 219116 RVA: 0x0072C060 File Offset: 0x0072A260
		public static ISelfEntity GetRootAsISelfEntity(ByteBuffer _bb, ISelfEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060357ED RID: 219117 RVA: 0x0072C07D File Offset: 0x0072A27D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060357EE RID: 219118 RVA: 0x0072C08C File Offset: 0x0072A28C
		public ISelfEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DF95 RID: 57237
		// (get) Token: 0x060357EF RID: 219119 RVA: 0x0072C09C File Offset: 0x0072A29C
		public ETargetEntityType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETargetEntityType.Target;
				}
				return (ETargetEntityType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060357F0 RID: 219120 RVA: 0x0072C0D8 File Offset: 0x0072A2D8
		public static Offset<ISelfEntity> CreateISelfEntity(FlatBufferBuilder builder, ETargetEntityType Type = ETargetEntityType.Target)
		{
			builder.StartTable(1);
			ISelfEntity.AddType(builder, Type);
			return ISelfEntity.EndISelfEntity(builder);
		}

		// Token: 0x060357F1 RID: 219121 RVA: 0x0072C0EE File Offset: 0x0072A2EE
		public static void StartISelfEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060357F2 RID: 219122 RVA: 0x0072C0F7 File Offset: 0x0072A2F7
		public static void AddType(FlatBufferBuilder builder, ETargetEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060357F3 RID: 219123 RVA: 0x0072C102 File Offset: 0x0072A302
		public static Offset<ISelfEntity> EndISelfEntity(FlatBufferBuilder builder)
		{
			return new Offset<ISelfEntity>(builder.EndTable());
		}

		// Token: 0x060357F4 RID: 219124 RVA: 0x0072C110 File Offset: 0x0072A310
		public ISelfEntityT UnPack()
		{
			ISelfEntityT selfEntityT = new ISelfEntityT();
			this.UnPackTo(selfEntityT);
			return selfEntityT;
		}

		// Token: 0x060357F5 RID: 219125 RVA: 0x0072C12B File Offset: 0x0072A32B
		public void UnPackTo(ISelfEntityT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060357F6 RID: 219126 RVA: 0x0072C13C File Offset: 0x0072A33C
		public static Offset<ISelfEntity> Pack(FlatBufferBuilder builder, ISelfEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISelfEntity>);
			}
			return ISelfEntity.CreateISelfEntity(builder, _o.Type);
		}

		// Token: 0x04012931 RID: 76081
		private Table __p;
	}
}
