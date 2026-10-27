using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CC1 RID: 19649
	public struct ISelfEntity : IFlatbufferObject
	{
		// Token: 0x17008EA6 RID: 36518
		// (get) Token: 0x0601F2D5 RID: 127701 RVA: 0x0045A6B5 File Offset: 0x004588B5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F2D6 RID: 127702 RVA: 0x0045A6C2 File Offset: 0x004588C2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F2D7 RID: 127703 RVA: 0x0045A6CC File Offset: 0x004588CC
		public static ISelfEntity GetRootAsISelfEntity(ByteBuffer _bb)
		{
			return ISelfEntity.GetRootAsISelfEntity(_bb, default(ISelfEntity));
		}

		// Token: 0x0601F2D8 RID: 127704 RVA: 0x0045A6E8 File Offset: 0x004588E8
		public static ISelfEntity GetRootAsISelfEntity(ByteBuffer _bb, ISelfEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F2D9 RID: 127705 RVA: 0x0045A705 File Offset: 0x00458905
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F2DA RID: 127706 RVA: 0x0045A714 File Offset: 0x00458914
		public ISelfEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008EA7 RID: 36519
		// (get) Token: 0x0601F2DB RID: 127707 RVA: 0x0045A724 File Offset: 0x00458924
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

		// Token: 0x0601F2DC RID: 127708 RVA: 0x0045A760 File Offset: 0x00458960
		public static Offset<ISelfEntity> CreateISelfEntity(FlatBufferBuilder builder, ETargetEntityType Type = ETargetEntityType.Target)
		{
			builder.StartTable(1);
			ISelfEntity.AddType(builder, Type);
			return ISelfEntity.EndISelfEntity(builder);
		}

		// Token: 0x0601F2DD RID: 127709 RVA: 0x0045A776 File Offset: 0x00458976
		public static void StartISelfEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601F2DE RID: 127710 RVA: 0x0045A77F File Offset: 0x0045897F
		public static void AddType(FlatBufferBuilder builder, ETargetEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F2DF RID: 127711 RVA: 0x0045A78A File Offset: 0x0045898A
		public static Offset<ISelfEntity> EndISelfEntity(FlatBufferBuilder builder)
		{
			return new Offset<ISelfEntity>(builder.EndTable());
		}

		// Token: 0x0601F2E0 RID: 127712 RVA: 0x0045A798 File Offset: 0x00458998
		public ISelfEntityT UnPack()
		{
			ISelfEntityT selfEntityT = new ISelfEntityT();
			this.UnPackTo(selfEntityT);
			return selfEntityT;
		}

		// Token: 0x0601F2E1 RID: 127713 RVA: 0x0045A7B3 File Offset: 0x004589B3
		public void UnPackTo(ISelfEntityT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601F2E2 RID: 127714 RVA: 0x0045A7C4 File Offset: 0x004589C4
		public static Offset<ISelfEntity> Pack(FlatBufferBuilder builder, ISelfEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISelfEntity>);
			}
			return ISelfEntity.CreateISelfEntity(builder, _o.Type);
		}

		// Token: 0x0400D686 RID: 54918
		private Table __p;
	}
}
