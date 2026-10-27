using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F57 RID: 28503
	public struct ISelfEntity : IFlatbufferObject
	{
		// Token: 0x1700D3C8 RID: 54216
		// (get) Token: 0x060325AB RID: 206251 RVA: 0x006CC7ED File Offset: 0x006CA9ED
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060325AC RID: 206252 RVA: 0x006CC7FA File Offset: 0x006CA9FA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060325AD RID: 206253 RVA: 0x006CC804 File Offset: 0x006CAA04
		public static ISelfEntity GetRootAsISelfEntity(ByteBuffer _bb)
		{
			return ISelfEntity.GetRootAsISelfEntity(_bb, default(ISelfEntity));
		}

		// Token: 0x060325AE RID: 206254 RVA: 0x006CC820 File Offset: 0x006CAA20
		public static ISelfEntity GetRootAsISelfEntity(ByteBuffer _bb, ISelfEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060325AF RID: 206255 RVA: 0x006CC83D File Offset: 0x006CAA3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060325B0 RID: 206256 RVA: 0x006CC84C File Offset: 0x006CAA4C
		public ISelfEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D3C9 RID: 54217
		// (get) Token: 0x060325B1 RID: 206257 RVA: 0x006CC85C File Offset: 0x006CAA5C
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

		// Token: 0x060325B2 RID: 206258 RVA: 0x006CC898 File Offset: 0x006CAA98
		public static Offset<ISelfEntity> CreateISelfEntity(FlatBufferBuilder builder, ETargetEntityType Type = ETargetEntityType.Target)
		{
			builder.StartTable(1);
			ISelfEntity.AddType(builder, Type);
			return ISelfEntity.EndISelfEntity(builder);
		}

		// Token: 0x060325B3 RID: 206259 RVA: 0x006CC8AE File Offset: 0x006CAAAE
		public static void StartISelfEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060325B4 RID: 206260 RVA: 0x006CC8B7 File Offset: 0x006CAAB7
		public static void AddType(FlatBufferBuilder builder, ETargetEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060325B5 RID: 206261 RVA: 0x006CC8C2 File Offset: 0x006CAAC2
		public static Offset<ISelfEntity> EndISelfEntity(FlatBufferBuilder builder)
		{
			return new Offset<ISelfEntity>(builder.EndTable());
		}

		// Token: 0x060325B6 RID: 206262 RVA: 0x006CC8D0 File Offset: 0x006CAAD0
		public ISelfEntityT UnPack()
		{
			ISelfEntityT selfEntityT = new ISelfEntityT();
			this.UnPackTo(selfEntityT);
			return selfEntityT;
		}

		// Token: 0x060325B7 RID: 206263 RVA: 0x006CC8EB File Offset: 0x006CAAEB
		public void UnPackTo(ISelfEntityT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060325B8 RID: 206264 RVA: 0x006CC8FC File Offset: 0x006CAAFC
		public static Offset<ISelfEntity> Pack(FlatBufferBuilder builder, ISelfEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISelfEntity>);
			}
			return ISelfEntity.CreateISelfEntity(builder, _o.Type);
		}

		// Token: 0x04011951 RID: 72017
		private Table __p;
	}
}
