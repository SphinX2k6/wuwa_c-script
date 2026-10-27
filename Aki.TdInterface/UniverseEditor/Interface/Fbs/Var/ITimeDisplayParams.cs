using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AF0 RID: 15088
	public struct ITimeDisplayParams : IFlatbufferObject
	{
		// Token: 0x1700677A RID: 26490
		// (get) Token: 0x060148EE RID: 84206 RVA: 0x002FE564 File Offset: 0x002FC764
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060148EF RID: 84207 RVA: 0x002FE571 File Offset: 0x002FC771
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060148F0 RID: 84208 RVA: 0x002FE578 File Offset: 0x002FC778
		public static ITimeDisplayParams GetRootAsITimeDisplayParams(ByteBuffer _bb)
		{
			return ITimeDisplayParams.GetRootAsITimeDisplayParams(_bb, default(ITimeDisplayParams));
		}

		// Token: 0x060148F1 RID: 84209 RVA: 0x002FE594 File Offset: 0x002FC794
		public static ITimeDisplayParams GetRootAsITimeDisplayParams(ByteBuffer _bb, ITimeDisplayParams obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060148F2 RID: 84210 RVA: 0x002FE5B1 File Offset: 0x002FC7B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060148F3 RID: 84211 RVA: 0x002FE5C0 File Offset: 0x002FC7C0
		public ITimeDisplayParams __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700677B RID: 26491
		// (get) Token: 0x060148F4 RID: 84212 RVA: 0x002FE5D0 File Offset: 0x002FC7D0
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

		// Token: 0x060148F5 RID: 84213 RVA: 0x002FE60C File Offset: 0x002FC80C
		public static Offset<ITimeDisplayParams> CreateITimeDisplayParams(FlatBufferBuilder builder, ETimeDisplayDataSource Type = ETimeDisplayDataSource.Constant)
		{
			builder.StartTable(1);
			ITimeDisplayParams.AddType(builder, Type);
			return ITimeDisplayParams.EndITimeDisplayParams(builder);
		}

		// Token: 0x060148F6 RID: 84214 RVA: 0x002FE622 File Offset: 0x002FC822
		public static void StartITimeDisplayParams(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060148F7 RID: 84215 RVA: 0x002FE62B File Offset: 0x002FC82B
		public static void AddType(FlatBufferBuilder builder, ETimeDisplayDataSource type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060148F8 RID: 84216 RVA: 0x002FE636 File Offset: 0x002FC836
		public static Offset<ITimeDisplayParams> EndITimeDisplayParams(FlatBufferBuilder builder)
		{
			return new Offset<ITimeDisplayParams>(builder.EndTable());
		}

		// Token: 0x060148F9 RID: 84217 RVA: 0x002FE644 File Offset: 0x002FC844
		public ITimeDisplayParamsT UnPack()
		{
			ITimeDisplayParamsT timeDisplayParamsT = new ITimeDisplayParamsT();
			this.UnPackTo(timeDisplayParamsT);
			return timeDisplayParamsT;
		}

		// Token: 0x060148FA RID: 84218 RVA: 0x002FE65F File Offset: 0x002FC85F
		public void UnPackTo(ITimeDisplayParamsT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060148FB RID: 84219 RVA: 0x002FE670 File Offset: 0x002FC870
		public static Offset<ITimeDisplayParams> Pack(FlatBufferBuilder builder, ITimeDisplayParamsT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITimeDisplayParams>);
			}
			return ITimeDisplayParams.CreateITimeDisplayParams(builder, _o.Type);
		}

		// Token: 0x0400AFB3 RID: 44979
		private Table __p;
	}
}
