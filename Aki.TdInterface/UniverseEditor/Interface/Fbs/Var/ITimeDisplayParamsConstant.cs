using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AF3 RID: 15091
	public struct ITimeDisplayParamsConstant : IFlatbufferObject
	{
		// Token: 0x1700677D RID: 26493
		// (get) Token: 0x06014900 RID: 84224 RVA: 0x002FE6D9 File Offset: 0x002FC8D9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014901 RID: 84225 RVA: 0x002FE6E6 File Offset: 0x002FC8E6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014902 RID: 84226 RVA: 0x002FE6F0 File Offset: 0x002FC8F0
		public static ITimeDisplayParamsConstant GetRootAsITimeDisplayParamsConstant(ByteBuffer _bb)
		{
			return ITimeDisplayParamsConstant.GetRootAsITimeDisplayParamsConstant(_bb, default(ITimeDisplayParamsConstant));
		}

		// Token: 0x06014903 RID: 84227 RVA: 0x002FE70C File Offset: 0x002FC90C
		public static ITimeDisplayParamsConstant GetRootAsITimeDisplayParamsConstant(ByteBuffer _bb, ITimeDisplayParamsConstant obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014904 RID: 84228 RVA: 0x002FE729 File Offset: 0x002FC929
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014905 RID: 84229 RVA: 0x002FE738 File Offset: 0x002FC938
		public ITimeDisplayParamsConstant __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700677E RID: 26494
		// (get) Token: 0x06014906 RID: 84230 RVA: 0x002FE748 File Offset: 0x002FC948
		public ETimeDisplayDataSource Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETimeDisplayDataSource.Constant;
				}
				return (ETimeDisplayDataSource)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700677F RID: 26495
		// (get) Token: 0x06014907 RID: 84231 RVA: 0x002FE784 File Offset: 0x002FC984
		public int Value
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

		// Token: 0x06014908 RID: 84232 RVA: 0x002FE7C0 File Offset: 0x002FC9C0
		public static Offset<ITimeDisplayParamsConstant> CreateITimeDisplayParamsConstant(FlatBufferBuilder builder, ETimeDisplayDataSource Type = ETimeDisplayDataSource.Constant, int Value = 0)
		{
			builder.StartTable(2);
			ITimeDisplayParamsConstant.AddValue(builder, Value);
			ITimeDisplayParamsConstant.AddType(builder, Type);
			return ITimeDisplayParamsConstant.EndITimeDisplayParamsConstant(builder);
		}

		// Token: 0x06014909 RID: 84233 RVA: 0x002FE7DD File Offset: 0x002FC9DD
		public static void StartITimeDisplayParamsConstant(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601490A RID: 84234 RVA: 0x002FE7E6 File Offset: 0x002FC9E6
		public static void AddType(FlatBufferBuilder builder, ETimeDisplayDataSource type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601490B RID: 84235 RVA: 0x002FE7F1 File Offset: 0x002FC9F1
		public static void AddValue(FlatBufferBuilder builder, int value)
		{
			builder.AddInt(1, value, 0);
		}

		// Token: 0x0601490C RID: 84236 RVA: 0x002FE7FC File Offset: 0x002FC9FC
		public static Offset<ITimeDisplayParamsConstant> EndITimeDisplayParamsConstant(FlatBufferBuilder builder)
		{
			return new Offset<ITimeDisplayParamsConstant>(builder.EndTable());
		}

		// Token: 0x0601490D RID: 84237 RVA: 0x002FE80C File Offset: 0x002FCA0C
		public ITimeDisplayParamsConstantT UnPack()
		{
			ITimeDisplayParamsConstantT timeDisplayParamsConstantT = new ITimeDisplayParamsConstantT();
			this.UnPackTo(timeDisplayParamsConstantT);
			return timeDisplayParamsConstantT;
		}

		// Token: 0x0601490E RID: 84238 RVA: 0x002FE827 File Offset: 0x002FCA27
		public void UnPackTo(ITimeDisplayParamsConstantT _o)
		{
			_o.Type = this.Type;
			_o.Value = this.Value;
		}

		// Token: 0x0601490F RID: 84239 RVA: 0x002FE844 File Offset: 0x002FCA44
		public static Offset<ITimeDisplayParamsConstant> Pack(FlatBufferBuilder builder, ITimeDisplayParamsConstantT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITimeDisplayParamsConstant>);
			}
			return ITimeDisplayParamsConstant.CreateITimeDisplayParamsConstant(builder, _o.Type, _o.Value);
		}

		// Token: 0x0400AFB5 RID: 44981
		private Table __p;
	}
}
