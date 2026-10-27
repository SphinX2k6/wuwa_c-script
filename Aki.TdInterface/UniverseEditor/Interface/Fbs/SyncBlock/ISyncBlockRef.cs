using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.SyncBlock
{
	// Token: 0x02003B87 RID: 15239
	public struct ISyncBlockRef : IFlatbufferObject
	{
		// Token: 0x1700687E RID: 26750
		// (get) Token: 0x06014E15 RID: 85525 RVA: 0x00307D88 File Offset: 0x00305F88
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014E16 RID: 85526 RVA: 0x00307D95 File Offset: 0x00305F95
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014E17 RID: 85527 RVA: 0x00307D9C File Offset: 0x00305F9C
		public static ISyncBlockRef GetRootAsISyncBlockRef(ByteBuffer _bb)
		{
			return ISyncBlockRef.GetRootAsISyncBlockRef(_bb, default(ISyncBlockRef));
		}

		// Token: 0x06014E18 RID: 85528 RVA: 0x00307DB8 File Offset: 0x00305FB8
		public static ISyncBlockRef GetRootAsISyncBlockRef(ByteBuffer _bb, ISyncBlockRef obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014E19 RID: 85529 RVA: 0x00307DD5 File Offset: 0x00305FD5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014E1A RID: 85530 RVA: 0x00307DE4 File Offset: 0x00305FE4
		public ISyncBlockRef __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06014E1B RID: 85531 RVA: 0x00307DF4 File Offset: 0x00305FF4
		public static void StartISyncBlockRef(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x06014E1C RID: 85532 RVA: 0x00307DFD File Offset: 0x00305FFD
		public static Offset<ISyncBlockRef> EndISyncBlockRef(FlatBufferBuilder builder)
		{
			return new Offset<ISyncBlockRef>(builder.EndTable());
		}

		// Token: 0x06014E1D RID: 85533 RVA: 0x00307E0C File Offset: 0x0030600C
		public ISyncBlockRefT UnPack()
		{
			ISyncBlockRefT syncBlockRefT = new ISyncBlockRefT();
			this.UnPackTo(syncBlockRefT);
			return syncBlockRefT;
		}

		// Token: 0x06014E1E RID: 85534 RVA: 0x00307E27 File Offset: 0x00306027
		public void UnPackTo(ISyncBlockRefT _o)
		{
		}

		// Token: 0x06014E1F RID: 85535 RVA: 0x00307E2C File Offset: 0x0030602C
		public static Offset<ISyncBlockRef> Pack(FlatBufferBuilder builder, ISyncBlockRefT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISyncBlockRef>);
			}
			ISyncBlockRef.StartISyncBlockRef(builder);
			return ISyncBlockRef.EndISyncBlockRef(builder);
		}

		// Token: 0x0400B0D7 RID: 45271
		private Table __p;
	}
}
