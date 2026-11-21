using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051BD RID: 20925
	public struct ISelfEntity : IFlatbufferObject
	{
		// Token: 0x170095DF RID: 38367
		// (get) Token: 0x06020F19 RID: 134937 RVA: 0x0048E5AD File Offset: 0x0048C7AD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020F1A RID: 134938 RVA: 0x0048E5BA File Offset: 0x0048C7BA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020F1B RID: 134939 RVA: 0x0048E5C4 File Offset: 0x0048C7C4
		public static ISelfEntity GetRootAsISelfEntity(ByteBuffer _bb)
		{
			return ISelfEntity.GetRootAsISelfEntity(_bb, default(ISelfEntity));
		}

		// Token: 0x06020F1C RID: 134940 RVA: 0x0048E5E0 File Offset: 0x0048C7E0
		public static ISelfEntity GetRootAsISelfEntity(ByteBuffer _bb, ISelfEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020F1D RID: 134941 RVA: 0x0048E5FD File Offset: 0x0048C7FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020F1E RID: 134942 RVA: 0x0048E60C File Offset: 0x0048C80C
		public ISelfEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170095E0 RID: 38368
		// (get) Token: 0x06020F1F RID: 134943 RVA: 0x0048E61C File Offset: 0x0048C81C
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

		// Token: 0x06020F20 RID: 134944 RVA: 0x0048E658 File Offset: 0x0048C858
		public static Offset<ISelfEntity> CreateISelfEntity(FlatBufferBuilder builder, ETargetEntityType Type = ETargetEntityType.Target)
		{
			builder.StartTable(1);
			ISelfEntity.AddType(builder, Type);
			return ISelfEntity.EndISelfEntity(builder);
		}

		// Token: 0x06020F21 RID: 134945 RVA: 0x0048E66E File Offset: 0x0048C86E
		public static void StartISelfEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06020F22 RID: 134946 RVA: 0x0048E677 File Offset: 0x0048C877
		public static void AddType(FlatBufferBuilder builder, ETargetEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020F23 RID: 134947 RVA: 0x0048E682 File Offset: 0x0048C882
		public static Offset<ISelfEntity> EndISelfEntity(FlatBufferBuilder builder)
		{
			return new Offset<ISelfEntity>(builder.EndTable());
		}

		// Token: 0x06020F24 RID: 134948 RVA: 0x0048E690 File Offset: 0x0048C890
		public ISelfEntityT UnPack()
		{
			ISelfEntityT selfEntityT = new ISelfEntityT();
			this.UnPackTo(selfEntityT);
			return selfEntityT;
		}

		// Token: 0x06020F25 RID: 134949 RVA: 0x0048E6AB File Offset: 0x0048C8AB
		public void UnPackTo(ISelfEntityT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06020F26 RID: 134950 RVA: 0x0048E6BC File Offset: 0x0048C8BC
		public static Offset<ISelfEntity> Pack(FlatBufferBuilder builder, ISelfEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISelfEntity>);
			}
			return ISelfEntity.CreateISelfEntity(builder, _o.Type);
		}

		// Token: 0x0400E1B3 RID: 57779
		private Table __p;
	}
}
