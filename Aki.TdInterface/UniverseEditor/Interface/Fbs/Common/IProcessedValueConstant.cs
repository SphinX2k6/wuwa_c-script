using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200647F RID: 25727
	public struct IProcessedValueConstant : IFlatbufferObject
	{
		// Token: 0x1700BDD0 RID: 48592
		// (get) Token: 0x0602BB6C RID: 179052 RVA: 0x005F2A21 File Offset: 0x005F0C21
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BB6D RID: 179053 RVA: 0x005F2A2E File Offset: 0x005F0C2E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BB6E RID: 179054 RVA: 0x005F2A38 File Offset: 0x005F0C38
		public static IProcessedValueConstant GetRootAsIProcessedValueConstant(ByteBuffer _bb)
		{
			return IProcessedValueConstant.GetRootAsIProcessedValueConstant(_bb, default(IProcessedValueConstant));
		}

		// Token: 0x0602BB6F RID: 179055 RVA: 0x005F2A54 File Offset: 0x005F0C54
		public static IProcessedValueConstant GetRootAsIProcessedValueConstant(ByteBuffer _bb, IProcessedValueConstant obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BB70 RID: 179056 RVA: 0x005F2A71 File Offset: 0x005F0C71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BB71 RID: 179057 RVA: 0x005F2A80 File Offset: 0x005F0C80
		public IProcessedValueConstant __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BDD1 RID: 48593
		// (get) Token: 0x0602BB72 RID: 179058 RVA: 0x005F2A90 File Offset: 0x005F0C90
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

		// Token: 0x1700BDD2 RID: 48594
		// (get) Token: 0x0602BB73 RID: 179059 RVA: 0x005F2ACC File Offset: 0x005F0CCC
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

		// Token: 0x0602BB74 RID: 179060 RVA: 0x005F2B0C File Offset: 0x005F0D0C
		public static Offset<IProcessedValueConstant> CreateIProcessedValueConstant(FlatBufferBuilder builder, EProcessedValueType Type = EProcessedValueType.Constant, float Value = 0f)
		{
			builder.StartTable(2);
			IProcessedValueConstant.AddValue(builder, Value);
			IProcessedValueConstant.AddType(builder, Type);
			return IProcessedValueConstant.EndIProcessedValueConstant(builder);
		}

		// Token: 0x0602BB75 RID: 179061 RVA: 0x005F2B29 File Offset: 0x005F0D29
		public static void StartIProcessedValueConstant(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602BB76 RID: 179062 RVA: 0x005F2B32 File Offset: 0x005F0D32
		public static void AddType(FlatBufferBuilder builder, EProcessedValueType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602BB77 RID: 179063 RVA: 0x005F2B3D File Offset: 0x005F0D3D
		public static void AddValue(FlatBufferBuilder builder, float value)
		{
			builder.AddFloat(1, value, 0.0);
		}

		// Token: 0x0602BB78 RID: 179064 RVA: 0x005F2B50 File Offset: 0x005F0D50
		public static Offset<IProcessedValueConstant> EndIProcessedValueConstant(FlatBufferBuilder builder)
		{
			return new Offset<IProcessedValueConstant>(builder.EndTable());
		}

		// Token: 0x0602BB79 RID: 179065 RVA: 0x005F2B60 File Offset: 0x005F0D60
		public IProcessedValueConstantT UnPack()
		{
			IProcessedValueConstantT processedValueConstantT = new IProcessedValueConstantT();
			this.UnPackTo(processedValueConstantT);
			return processedValueConstantT;
		}

		// Token: 0x0602BB7A RID: 179066 RVA: 0x005F2B7B File Offset: 0x005F0D7B
		public void UnPackTo(IProcessedValueConstantT _o)
		{
			_o.Type = this.Type;
			_o.Value = this.Value;
		}

		// Token: 0x0602BB7B RID: 179067 RVA: 0x005F2B98 File Offset: 0x005F0D98
		public static Offset<IProcessedValueConstant> Pack(FlatBufferBuilder builder, IProcessedValueConstantT _o)
		{
			if (_o == null)
			{
				return default(Offset<IProcessedValueConstant>);
			}
			return IProcessedValueConstant.CreateIProcessedValueConstant(builder, _o.Type, _o.Value);
		}

		// Token: 0x0401059C RID: 66972
		private Table __p;
	}
}
