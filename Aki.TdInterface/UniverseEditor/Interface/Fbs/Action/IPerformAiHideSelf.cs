using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C78 RID: 27768
	public struct IPerformAiHideSelf : IFlatbufferObject
	{
		// Token: 0x1700CED5 RID: 52949
		// (get) Token: 0x06030EED RID: 200429 RVA: 0x006A508D File Offset: 0x006A328D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030EEE RID: 200430 RVA: 0x006A509A File Offset: 0x006A329A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030EEF RID: 200431 RVA: 0x006A50A4 File Offset: 0x006A32A4
		public static IPerformAiHideSelf GetRootAsIPerformAiHideSelf(ByteBuffer _bb)
		{
			return IPerformAiHideSelf.GetRootAsIPerformAiHideSelf(_bb, default(IPerformAiHideSelf));
		}

		// Token: 0x06030EF0 RID: 200432 RVA: 0x006A50C0 File Offset: 0x006A32C0
		public static IPerformAiHideSelf GetRootAsIPerformAiHideSelf(ByteBuffer _bb, IPerformAiHideSelf obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030EF1 RID: 200433 RVA: 0x006A50DD File Offset: 0x006A32DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030EF2 RID: 200434 RVA: 0x006A50EC File Offset: 0x006A32EC
		public IPerformAiHideSelf __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06030EF3 RID: 200435 RVA: 0x006A50FC File Offset: 0x006A32FC
		public static void StartIPerformAiHideSelf(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x06030EF4 RID: 200436 RVA: 0x006A5105 File Offset: 0x006A3305
		public static Offset<IPerformAiHideSelf> EndIPerformAiHideSelf(FlatBufferBuilder builder)
		{
			return new Offset<IPerformAiHideSelf>(builder.EndTable());
		}

		// Token: 0x06030EF5 RID: 200437 RVA: 0x006A5114 File Offset: 0x006A3314
		public IPerformAiHideSelfT UnPack()
		{
			IPerformAiHideSelfT performAiHideSelfT = new IPerformAiHideSelfT();
			this.UnPackTo(performAiHideSelfT);
			return performAiHideSelfT;
		}

		// Token: 0x06030EF6 RID: 200438 RVA: 0x006A512F File Offset: 0x006A332F
		public void UnPackTo(IPerformAiHideSelfT _o)
		{
		}

		// Token: 0x06030EF7 RID: 200439 RVA: 0x006A5134 File Offset: 0x006A3334
		public static Offset<IPerformAiHideSelf> Pack(FlatBufferBuilder builder, IPerformAiHideSelfT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPerformAiHideSelf>);
			}
			IPerformAiHideSelf.StartIPerformAiHideSelf(builder);
			return IPerformAiHideSelf.EndIPerformAiHideSelf(builder);
		}

		// Token: 0x040115CA RID: 71114
		private Table __p;
	}
}
