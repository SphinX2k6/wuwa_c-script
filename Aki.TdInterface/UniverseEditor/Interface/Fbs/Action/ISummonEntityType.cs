using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A07 RID: 31239
	public struct ISummonEntityType : IFlatbufferObject
	{
		// Token: 0x1700E4EE RID: 58606
		// (get) Token: 0x060370A8 RID: 225448 RVA: 0x0075B52F File Offset: 0x0075972F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060370A9 RID: 225449 RVA: 0x0075B53C File Offset: 0x0075973C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060370AA RID: 225450 RVA: 0x0075B544 File Offset: 0x00759744
		public static ISummonEntityType GetRootAsISummonEntityType(ByteBuffer _bb)
		{
			return ISummonEntityType.GetRootAsISummonEntityType(_bb, default(ISummonEntityType));
		}

		// Token: 0x060370AB RID: 225451 RVA: 0x0075B560 File Offset: 0x00759760
		public static ISummonEntityType GetRootAsISummonEntityType(ByteBuffer _bb, ISummonEntityType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060370AC RID: 225452 RVA: 0x0075B57D File Offset: 0x0075977D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060370AD RID: 225453 RVA: 0x0075B58C File Offset: 0x0075978C
		public ISummonEntityType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E4EF RID: 58607
		// (get) Token: 0x060370AE RID: 225454 RVA: 0x0075B59C File Offset: 0x0075979C
		public ESummonEntityType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESummonEntityType.Vehicle;
				}
				return (ESummonEntityType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060370AF RID: 225455 RVA: 0x0075B5D8 File Offset: 0x007597D8
		public static Offset<ISummonEntityType> CreateISummonEntityType(FlatBufferBuilder builder, ESummonEntityType Type = ESummonEntityType.Vehicle)
		{
			builder.StartTable(1);
			ISummonEntityType.AddType(builder, Type);
			return ISummonEntityType.EndISummonEntityType(builder);
		}

		// Token: 0x060370B0 RID: 225456 RVA: 0x0075B5EE File Offset: 0x007597EE
		public static void StartISummonEntityType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060370B1 RID: 225457 RVA: 0x0075B5F7 File Offset: 0x007597F7
		public static void AddType(FlatBufferBuilder builder, ESummonEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060370B2 RID: 225458 RVA: 0x0075B602 File Offset: 0x00759802
		public static Offset<ISummonEntityType> EndISummonEntityType(FlatBufferBuilder builder)
		{
			return new Offset<ISummonEntityType>(builder.EndTable());
		}

		// Token: 0x060370B3 RID: 225459 RVA: 0x0075B610 File Offset: 0x00759810
		public ISummonEntityTypeT UnPack()
		{
			ISummonEntityTypeT summonEntityTypeT = new ISummonEntityTypeT();
			this.UnPackTo(summonEntityTypeT);
			return summonEntityTypeT;
		}

		// Token: 0x060370B4 RID: 225460 RVA: 0x0075B62B File Offset: 0x0075982B
		public void UnPackTo(ISummonEntityTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060370B5 RID: 225461 RVA: 0x0075B63C File Offset: 0x0075983C
		public static Offset<ISummonEntityType> Pack(FlatBufferBuilder builder, ISummonEntityTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISummonEntityType>);
			}
			return ISummonEntityType.CreateISummonEntityType(builder, _o.Type);
		}

		// Token: 0x04012D24 RID: 77092
		private Table __p;
	}
}
