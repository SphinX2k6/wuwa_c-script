using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x020039EB RID: 14827
	public struct BooleanValue : IFlatbufferObject
	{
		// Token: 0x170065C5 RID: 26053
		// (get) Token: 0x060140E5 RID: 82149 RVA: 0x002F0022 File Offset: 0x002EE222
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060140E6 RID: 82150 RVA: 0x002F002F File Offset: 0x002EE22F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060140E7 RID: 82151 RVA: 0x002F0038 File Offset: 0x002EE238
		public static BooleanValue GetRootAsBooleanValue(ByteBuffer _bb)
		{
			return BooleanValue.GetRootAsBooleanValue(_bb, default(BooleanValue));
		}

		// Token: 0x060140E8 RID: 82152 RVA: 0x002F0054 File Offset: 0x002EE254
		public static BooleanValue GetRootAsBooleanValue(ByteBuffer _bb, BooleanValue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060140E9 RID: 82153 RVA: 0x002F0071 File Offset: 0x002EE271
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060140EA RID: 82154 RVA: 0x002F0080 File Offset: 0x002EE280
		public BooleanValue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170065C6 RID: 26054
		// (get) Token: 0x060140EB RID: 82155 RVA: 0x002F0090 File Offset: 0x002EE290
		public bool Value
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060140EC RID: 82156 RVA: 0x002F00CF File Offset: 0x002EE2CF
		public static Offset<BooleanValue> CreateBooleanValue(FlatBufferBuilder builder, bool value = false)
		{
			builder.StartTable(1);
			BooleanValue.AddValue(builder, value);
			return BooleanValue.EndBooleanValue(builder);
		}

		// Token: 0x060140ED RID: 82157 RVA: 0x002F00E5 File Offset: 0x002EE2E5
		public static void StartBooleanValue(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060140EE RID: 82158 RVA: 0x002F00EE File Offset: 0x002EE2EE
		public static void AddValue(FlatBufferBuilder builder, bool value)
		{
			builder.AddBool(0, value, false);
		}

		// Token: 0x060140EF RID: 82159 RVA: 0x002F00F9 File Offset: 0x002EE2F9
		public static Offset<BooleanValue> EndBooleanValue(FlatBufferBuilder builder)
		{
			return new Offset<BooleanValue>(builder.EndTable());
		}

		// Token: 0x060140F0 RID: 82160 RVA: 0x002F0108 File Offset: 0x002EE308
		public BooleanValueT UnPack()
		{
			BooleanValueT booleanValueT = new BooleanValueT();
			this.UnPackTo(booleanValueT);
			return booleanValueT;
		}

		// Token: 0x060140F1 RID: 82161 RVA: 0x002F0123 File Offset: 0x002EE323
		public void UnPackTo(BooleanValueT _o)
		{
			_o.Value = this.Value;
		}

		// Token: 0x060140F2 RID: 82162 RVA: 0x002F0134 File Offset: 0x002EE334
		public static Offset<BooleanValue> Pack(FlatBufferBuilder builder, BooleanValueT _o)
		{
			if (_o == null)
			{
				return default(Offset<BooleanValue>);
			}
			return BooleanValue.CreateBooleanValue(builder, _o.Value);
		}

		// Token: 0x0400ADDE RID: 44510
		private Table __p;
	}
}
