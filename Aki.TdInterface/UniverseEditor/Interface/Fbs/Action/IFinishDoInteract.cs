using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E24 RID: 28196
	public struct IFinishDoInteract : IFlatbufferObject
	{
		// Token: 0x1700CEAC RID: 52908
		// (get) Token: 0x06030B0B RID: 199435 RVA: 0x0069BE5E File Offset: 0x0069A05E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030B0C RID: 199436 RVA: 0x0069BE6B File Offset: 0x0069A06B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030B0D RID: 199437 RVA: 0x0069BE74 File Offset: 0x0069A074
		public static IFinishDoInteract GetRootAsIFinishDoInteract(ByteBuffer _bb)
		{
			return IFinishDoInteract.GetRootAsIFinishDoInteract(_bb, default(IFinishDoInteract));
		}

		// Token: 0x06030B0E RID: 199438 RVA: 0x0069BE90 File Offset: 0x0069A090
		public static IFinishDoInteract GetRootAsIFinishDoInteract(ByteBuffer _bb, IFinishDoInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030B0F RID: 199439 RVA: 0x0069BEAD File Offset: 0x0069A0AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030B10 RID: 199440 RVA: 0x0069BEBC File Offset: 0x0069A0BC
		public IFinishDoInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06030B11 RID: 199441 RVA: 0x0069BECC File Offset: 0x0069A0CC
		public static void StartIFinishDoInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x06030B12 RID: 199442 RVA: 0x0069BED5 File Offset: 0x0069A0D5
		public static Offset<IFinishDoInteract> EndIFinishDoInteract(FlatBufferBuilder builder)
		{
			return new Offset<IFinishDoInteract>(builder.EndTable());
		}

		// Token: 0x06030B13 RID: 199443 RVA: 0x0069BEE4 File Offset: 0x0069A0E4
		public IFinishDoInteractT UnPack()
		{
			IFinishDoInteractT finishDoInteractT = new IFinishDoInteractT();
			this.UnPackTo(finishDoInteractT);
			return finishDoInteractT;
		}

		// Token: 0x06030B14 RID: 199444 RVA: 0x0069BEFF File Offset: 0x0069A0FF
		public void UnPackTo(IFinishDoInteractT _o)
		{
		}

		// Token: 0x06030B15 RID: 199445 RVA: 0x0069BF04 File Offset: 0x0069A104
		public static Offset<IFinishDoInteract> Pack(FlatBufferBuilder builder, IFinishDoInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFinishDoInteract>);
			}
			IFinishDoInteract.StartIFinishDoInteract(builder);
			return IFinishDoInteract.EndIFinishDoInteract(builder);
		}

		// Token: 0x04011CE7 RID: 72935
		private Table __p;
	}
}
