using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E3F RID: 24127
	public struct IProcessedValueConstant : IFlatbufferObject
	{
		// Token: 0x1700B467 RID: 46183
		// (get) Token: 0x060294D0 RID: 169168 RVA: 0x005A9B79 File Offset: 0x005A7D79
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060294D1 RID: 169169 RVA: 0x005A9B86 File Offset: 0x005A7D86
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060294D2 RID: 169170 RVA: 0x005A9B90 File Offset: 0x005A7D90
		public static IProcessedValueConstant GetRootAsIProcessedValueConstant(ByteBuffer _bb)
		{
			return IProcessedValueConstant.GetRootAsIProcessedValueConstant(_bb, default(IProcessedValueConstant));
		}

		// Token: 0x060294D3 RID: 169171 RVA: 0x005A9BAC File Offset: 0x005A7DAC
		public static IProcessedValueConstant GetRootAsIProcessedValueConstant(ByteBuffer _bb, IProcessedValueConstant obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060294D4 RID: 169172 RVA: 0x005A9BC9 File Offset: 0x005A7DC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060294D5 RID: 169173 RVA: 0x005A9BD8 File Offset: 0x005A7DD8
		public IProcessedValueConstant __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B468 RID: 46184
		// (get) Token: 0x060294D6 RID: 169174 RVA: 0x005A9BE8 File Offset: 0x005A7DE8
		public EProcessedValueType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EProcessedValueType.Constant;
				}
				return (EProcessedValueType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B469 RID: 46185
		// (get) Token: 0x060294D7 RID: 169175 RVA: 0x005A9C24 File Offset: 0x005A7E24
		public float Value
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060294D8 RID: 169176 RVA: 0x005A9C64 File Offset: 0x005A7E64
		public static Offset<IProcessedValueConstant> CreateIProcessedValueConstant(FlatBufferBuilder builder, EProcessedValueType Type = EProcessedValueType.Constant, float Value = 0f)
		{
			builder.StartTable(2);
			IProcessedValueConstant.AddValue(builder, Value);
			IProcessedValueConstant.AddType(builder, Type);
			return IProcessedValueConstant.EndIProcessedValueConstant(builder);
		}

		// Token: 0x060294D9 RID: 169177 RVA: 0x005A9C81 File Offset: 0x005A7E81
		public static void StartIProcessedValueConstant(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060294DA RID: 169178 RVA: 0x005A9C8A File Offset: 0x005A7E8A
		public static void AddType(FlatBufferBuilder builder, EProcessedValueType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060294DB RID: 169179 RVA: 0x005A9C95 File Offset: 0x005A7E95
		public static void AddValue(FlatBufferBuilder builder, float value)
		{
			builder.AddFloat(1, value, 0.0);
		}

		// Token: 0x060294DC RID: 169180 RVA: 0x005A9CA8 File Offset: 0x005A7EA8
		public static Offset<IProcessedValueConstant> EndIProcessedValueConstant(FlatBufferBuilder builder)
		{
			return new Offset<IProcessedValueConstant>(builder.EndTable());
		}

		// Token: 0x060294DD RID: 169181 RVA: 0x005A9CB8 File Offset: 0x005A7EB8
		public IProcessedValueConstantT UnPack()
		{
			IProcessedValueConstantT processedValueConstantT = new IProcessedValueConstantT();
			this.UnPackTo(processedValueConstantT);
			return processedValueConstantT;
		}

		// Token: 0x060294DE RID: 169182 RVA: 0x005A9CD3 File Offset: 0x005A7ED3
		public void UnPackTo(IProcessedValueConstantT _o)
		{
			_o.Type = this.Type;
			_o.Value = this.Value;
		}

		// Token: 0x060294DF RID: 169183 RVA: 0x005A9CF0 File Offset: 0x005A7EF0
		public static Offset<IProcessedValueConstant> Pack(FlatBufferBuilder builder, IProcessedValueConstantT _o)
		{
			if (_o == null)
			{
				return default(Offset<IProcessedValueConstant>);
			}
			return IProcessedValueConstant.CreateIProcessedValueConstant(builder, _o.Type, _o.Value);
		}

		// Token: 0x0400F83F RID: 63551
		private Table __p;
	}
}
