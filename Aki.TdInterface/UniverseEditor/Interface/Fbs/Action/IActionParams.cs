using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066E5 RID: 26341
	public struct IActionParams : IFlatbufferObject
	{
		// Token: 0x1700BF8C RID: 49036
		// (get) Token: 0x0602C458 RID: 181336 RVA: 0x00607089 File Offset: 0x00605289
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C459 RID: 181337 RVA: 0x00607096 File Offset: 0x00605296
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C45A RID: 181338 RVA: 0x006070A0 File Offset: 0x006052A0
		public static IActionParams GetRootAsIActionParams(ByteBuffer _bb)
		{
			return IActionParams.GetRootAsIActionParams(_bb, default(IActionParams));
		}

		// Token: 0x0602C45B RID: 181339 RVA: 0x006070BC File Offset: 0x006052BC
		public static IActionParams GetRootAsIActionParams(ByteBuffer _bb, IActionParams obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C45C RID: 181340 RVA: 0x006070D9 File Offset: 0x006052D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C45D RID: 181341 RVA: 0x006070E8 File Offset: 0x006052E8
		public IActionParams __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602C45E RID: 181342 RVA: 0x006070F8 File Offset: 0x006052F8
		public static void StartIActionParams(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0602C45F RID: 181343 RVA: 0x00607101 File Offset: 0x00605301
		public static Offset<IActionParams> EndIActionParams(FlatBufferBuilder builder)
		{
			return new Offset<IActionParams>(builder.EndTable());
		}

		// Token: 0x0602C460 RID: 181344 RVA: 0x00607110 File Offset: 0x00605310
		public IActionParamsT UnPack()
		{
			IActionParamsT actionParamsT = new IActionParamsT();
			this.UnPackTo(actionParamsT);
			return actionParamsT;
		}

		// Token: 0x0602C461 RID: 181345 RVA: 0x0060712B File Offset: 0x0060532B
		public void UnPackTo(IActionParamsT _o)
		{
		}

		// Token: 0x0602C462 RID: 181346 RVA: 0x00607130 File Offset: 0x00605330
		public static Offset<IActionParams> Pack(FlatBufferBuilder builder, IActionParamsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActionParams>);
			}
			IActionParams.StartIActionParams(builder);
			return IActionParams.EndIActionParams(builder);
		}

		// Token: 0x04011052 RID: 69714
		private Table __p;
	}
}
