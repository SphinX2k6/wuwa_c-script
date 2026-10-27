using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007232 RID: 29234
	public struct ISummonEntityType : IFlatbufferObject
	{
		// Token: 0x1700D8F5 RID: 55541
		// (get) Token: 0x06033DA6 RID: 212390 RVA: 0x006FA1CF File Offset: 0x006F83CF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033DA7 RID: 212391 RVA: 0x006FA1DC File Offset: 0x006F83DC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033DA8 RID: 212392 RVA: 0x006FA1E4 File Offset: 0x006F83E4
		public static ISummonEntityType GetRootAsISummonEntityType(ByteBuffer _bb)
		{
			return ISummonEntityType.GetRootAsISummonEntityType(_bb, default(ISummonEntityType));
		}

		// Token: 0x06033DA9 RID: 212393 RVA: 0x006FA200 File Offset: 0x006F8400
		public static ISummonEntityType GetRootAsISummonEntityType(ByteBuffer _bb, ISummonEntityType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033DAA RID: 212394 RVA: 0x006FA21D File Offset: 0x006F841D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033DAB RID: 212395 RVA: 0x006FA22C File Offset: 0x006F842C
		public ISummonEntityType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D8F6 RID: 55542
		// (get) Token: 0x06033DAC RID: 212396 RVA: 0x006FA23C File Offset: 0x006F843C
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

		// Token: 0x06033DAD RID: 212397 RVA: 0x006FA278 File Offset: 0x006F8478
		public static Offset<ISummonEntityType> CreateISummonEntityType(FlatBufferBuilder builder, ESummonEntityType Type = ESummonEntityType.Vehicle)
		{
			builder.StartTable(1);
			ISummonEntityType.AddType(builder, Type);
			return ISummonEntityType.EndISummonEntityType(builder);
		}

		// Token: 0x06033DAE RID: 212398 RVA: 0x006FA28E File Offset: 0x006F848E
		public static void StartISummonEntityType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06033DAF RID: 212399 RVA: 0x006FA297 File Offset: 0x006F8497
		public static void AddType(FlatBufferBuilder builder, ESummonEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033DB0 RID: 212400 RVA: 0x006FA2A2 File Offset: 0x006F84A2
		public static Offset<ISummonEntityType> EndISummonEntityType(FlatBufferBuilder builder)
		{
			return new Offset<ISummonEntityType>(builder.EndTable());
		}

		// Token: 0x06033DB1 RID: 212401 RVA: 0x006FA2B0 File Offset: 0x006F84B0
		public ISummonEntityTypeT UnPack()
		{
			ISummonEntityTypeT summonEntityTypeT = new ISummonEntityTypeT();
			this.UnPackTo(summonEntityTypeT);
			return summonEntityTypeT;
		}

		// Token: 0x06033DB2 RID: 212402 RVA: 0x006FA2CB File Offset: 0x006F84CB
		public void UnPackTo(ISummonEntityTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06033DB3 RID: 212403 RVA: 0x006FA2DC File Offset: 0x006F84DC
		public static Offset<ISummonEntityType> Pack(FlatBufferBuilder builder, ISummonEntityTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISummonEntityType>);
			}
			return ISummonEntityType.CreateISummonEntityType(builder, _o.Type);
		}

		// Token: 0x04011D22 RID: 72994
		private Table __p;
	}
}
