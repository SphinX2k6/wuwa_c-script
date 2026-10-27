using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006528 RID: 25896
	public struct IDangoAbyssActivatePortal : IFlatbufferObject
	{
		// Token: 0x1700C094 RID: 49300
		// (get) Token: 0x0602CEE7 RID: 184039 RVA: 0x0062B9CA File Offset: 0x00629BCA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CEE8 RID: 184040 RVA: 0x0062B9D7 File Offset: 0x00629BD7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CEE9 RID: 184041 RVA: 0x0062B9E0 File Offset: 0x00629BE0
		public static IDangoAbyssActivatePortal GetRootAsIDangoAbyssActivatePortal(ByteBuffer _bb)
		{
			return IDangoAbyssActivatePortal.GetRootAsIDangoAbyssActivatePortal(_bb, default(IDangoAbyssActivatePortal));
		}

		// Token: 0x0602CEEA RID: 184042 RVA: 0x0062B9FC File Offset: 0x00629BFC
		public static IDangoAbyssActivatePortal GetRootAsIDangoAbyssActivatePortal(ByteBuffer _bb, IDangoAbyssActivatePortal obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CEEB RID: 184043 RVA: 0x0062BA19 File Offset: 0x00629C19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CEEC RID: 184044 RVA: 0x0062BA28 File Offset: 0x00629C28
		public IDangoAbyssActivatePortal __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602CEED RID: 184045 RVA: 0x0062BA38 File Offset: 0x00629C38
		public static void StartIDangoAbyssActivatePortal(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0602CEEE RID: 184046 RVA: 0x0062BA41 File Offset: 0x00629C41
		public static Offset<IDangoAbyssActivatePortal> EndIDangoAbyssActivatePortal(FlatBufferBuilder builder)
		{
			return new Offset<IDangoAbyssActivatePortal>(builder.EndTable());
		}

		// Token: 0x0602CEEF RID: 184047 RVA: 0x0062BA50 File Offset: 0x00629C50
		public IDangoAbyssActivatePortalT UnPack()
		{
			IDangoAbyssActivatePortalT dangoAbyssActivatePortalT = new IDangoAbyssActivatePortalT();
			this.UnPackTo(dangoAbyssActivatePortalT);
			return dangoAbyssActivatePortalT;
		}

		// Token: 0x0602CEF0 RID: 184048 RVA: 0x0062BA6B File Offset: 0x00629C6B
		public void UnPackTo(IDangoAbyssActivatePortalT _o)
		{
		}

		// Token: 0x0602CEF1 RID: 184049 RVA: 0x0062BA70 File Offset: 0x00629C70
		public static Offset<IDangoAbyssActivatePortal> Pack(FlatBufferBuilder builder, IDangoAbyssActivatePortalT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDangoAbyssActivatePortal>);
			}
			IDangoAbyssActivatePortal.StartIDangoAbyssActivatePortal(builder);
			return IDangoAbyssActivatePortal.EndIDangoAbyssActivatePortal(builder);
		}

		// Token: 0x04010B78 RID: 68472
		private Table __p;
	}
}
