using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B96 RID: 27542
	public struct IDangoAbyssActivatePortal : IFlatbufferObject
	{
		// Token: 0x1700CA26 RID: 51750
		// (get) Token: 0x0602F685 RID: 194181 RVA: 0x00677E76 File Offset: 0x00676076
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F686 RID: 194182 RVA: 0x00677E83 File Offset: 0x00676083
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F687 RID: 194183 RVA: 0x00677E8C File Offset: 0x0067608C
		public static IDangoAbyssActivatePortal GetRootAsIDangoAbyssActivatePortal(ByteBuffer _bb)
		{
			return IDangoAbyssActivatePortal.GetRootAsIDangoAbyssActivatePortal(_bb, default(IDangoAbyssActivatePortal));
		}

		// Token: 0x0602F688 RID: 194184 RVA: 0x00677EA8 File Offset: 0x006760A8
		public static IDangoAbyssActivatePortal GetRootAsIDangoAbyssActivatePortal(ByteBuffer _bb, IDangoAbyssActivatePortal obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F689 RID: 194185 RVA: 0x00677EC5 File Offset: 0x006760C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F68A RID: 194186 RVA: 0x00677ED4 File Offset: 0x006760D4
		public IDangoAbyssActivatePortal __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602F68B RID: 194187 RVA: 0x00677EE4 File Offset: 0x006760E4
		public static void StartIDangoAbyssActivatePortal(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0602F68C RID: 194188 RVA: 0x00677EED File Offset: 0x006760ED
		public static Offset<IDangoAbyssActivatePortal> EndIDangoAbyssActivatePortal(FlatBufferBuilder builder)
		{
			return new Offset<IDangoAbyssActivatePortal>(builder.EndTable());
		}

		// Token: 0x0602F68D RID: 194189 RVA: 0x00677EFC File Offset: 0x006760FC
		public IDangoAbyssActivatePortalT UnPack()
		{
			IDangoAbyssActivatePortalT dangoAbyssActivatePortalT = new IDangoAbyssActivatePortalT();
			this.UnPackTo(dangoAbyssActivatePortalT);
			return dangoAbyssActivatePortalT;
		}

		// Token: 0x0602F68E RID: 194190 RVA: 0x00677F17 File Offset: 0x00676117
		public void UnPackTo(IDangoAbyssActivatePortalT _o)
		{
		}

		// Token: 0x0602F68F RID: 194191 RVA: 0x00677F1C File Offset: 0x0067611C
		public static Offset<IDangoAbyssActivatePortal> Pack(FlatBufferBuilder builder, IDangoAbyssActivatePortalT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDangoAbyssActivatePortal>);
			}
			IDangoAbyssActivatePortal.StartIDangoAbyssActivatePortal(builder);
			return IDangoAbyssActivatePortal.EndIDangoAbyssActivatePortal(builder);
		}

		// Token: 0x04011991 RID: 72081
		private Table __p;
	}
}
