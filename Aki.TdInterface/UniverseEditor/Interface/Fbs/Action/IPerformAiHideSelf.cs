using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073DF RID: 29663
	public struct IPerformAiHideSelf : IFlatbufferObject
	{
		// Token: 0x1700D9F0 RID: 55792
		// (get) Token: 0x06033E48 RID: 212552 RVA: 0x006FF58D File Offset: 0x006FD78D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033E49 RID: 212553 RVA: 0x006FF59A File Offset: 0x006FD79A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033E4A RID: 212554 RVA: 0x006FF5A4 File Offset: 0x006FD7A4
		public static IPerformAiHideSelf GetRootAsIPerformAiHideSelf(ByteBuffer _bb)
		{
			return IPerformAiHideSelf.GetRootAsIPerformAiHideSelf(_bb, default(IPerformAiHideSelf));
		}

		// Token: 0x06033E4B RID: 212555 RVA: 0x006FF5C0 File Offset: 0x006FD7C0
		public static IPerformAiHideSelf GetRootAsIPerformAiHideSelf(ByteBuffer _bb, IPerformAiHideSelf obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033E4C RID: 212556 RVA: 0x006FF5DD File Offset: 0x006FD7DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033E4D RID: 212557 RVA: 0x006FF5EC File Offset: 0x006FD7EC
		public IPerformAiHideSelf __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06033E4E RID: 212558 RVA: 0x006FF5FC File Offset: 0x006FD7FC
		public static void StartIPerformAiHideSelf(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x06033E4F RID: 212559 RVA: 0x006FF605 File Offset: 0x006FD805
		public static Offset<IPerformAiHideSelf> EndIPerformAiHideSelf(FlatBufferBuilder builder)
		{
			return new Offset<IPerformAiHideSelf>(builder.EndTable());
		}

		// Token: 0x06033E50 RID: 212560 RVA: 0x006FF614 File Offset: 0x006FD814
		public IPerformAiHideSelfT UnPack()
		{
			IPerformAiHideSelfT performAiHideSelfT = new IPerformAiHideSelfT();
			this.UnPackTo(performAiHideSelfT);
			return performAiHideSelfT;
		}

		// Token: 0x06033E51 RID: 212561 RVA: 0x006FF62F File Offset: 0x006FD82F
		public void UnPackTo(IPerformAiHideSelfT _o)
		{
		}

		// Token: 0x06033E52 RID: 212562 RVA: 0x006FF634 File Offset: 0x006FD834
		public static Offset<IPerformAiHideSelf> Pack(FlatBufferBuilder builder, IPerformAiHideSelfT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPerformAiHideSelf>);
			}
			IPerformAiHideSelf.StartIPerformAiHideSelf(builder);
			return IPerformAiHideSelf.EndIPerformAiHideSelf(builder);
		}

		// Token: 0x04012522 RID: 75042
		private Table __p;
	}
}
