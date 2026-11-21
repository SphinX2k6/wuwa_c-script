using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007660 RID: 30304
	public struct IRogueActivatePortal : IFlatbufferObject
	{
		// Token: 0x1700DE81 RID: 56961
		// (get) Token: 0x060352AD RID: 217773 RVA: 0x0072327E File Offset: 0x0072147E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060352AE RID: 217774 RVA: 0x0072328B File Offset: 0x0072148B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060352AF RID: 217775 RVA: 0x00723294 File Offset: 0x00721494
		public static IRogueActivatePortal GetRootAsIRogueActivatePortal(ByteBuffer _bb)
		{
			return IRogueActivatePortal.GetRootAsIRogueActivatePortal(_bb, default(IRogueActivatePortal));
		}

		// Token: 0x060352B0 RID: 217776 RVA: 0x007232B0 File Offset: 0x007214B0
		public static IRogueActivatePortal GetRootAsIRogueActivatePortal(ByteBuffer _bb, IRogueActivatePortal obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060352B1 RID: 217777 RVA: 0x007232CD File Offset: 0x007214CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060352B2 RID: 217778 RVA: 0x007232DC File Offset: 0x007214DC
		public IRogueActivatePortal __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x060352B3 RID: 217779 RVA: 0x007232EC File Offset: 0x007214EC
		public static void StartIRogueActivatePortal(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x060352B4 RID: 217780 RVA: 0x007232F5 File Offset: 0x007214F5
		public static Offset<IRogueActivatePortal> EndIRogueActivatePortal(FlatBufferBuilder builder)
		{
			return new Offset<IRogueActivatePortal>(builder.EndTable());
		}

		// Token: 0x060352B5 RID: 217781 RVA: 0x00723304 File Offset: 0x00721504
		public IRogueActivatePortalT UnPack()
		{
			IRogueActivatePortalT rogueActivatePortalT = new IRogueActivatePortalT();
			this.UnPackTo(rogueActivatePortalT);
			return rogueActivatePortalT;
		}

		// Token: 0x060352B6 RID: 217782 RVA: 0x0072331F File Offset: 0x0072151F
		public void UnPackTo(IRogueActivatePortalT _o)
		{
		}

		// Token: 0x060352B7 RID: 217783 RVA: 0x00723324 File Offset: 0x00721524
		public static Offset<IRogueActivatePortal> Pack(FlatBufferBuilder builder, IRogueActivatePortalT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRogueActivatePortal>);
			}
			IRogueActivatePortal.StartIRogueActivatePortal(builder);
			return IRogueActivatePortal.EndIRogueActivatePortal(builder);
		}

		// Token: 0x04012857 RID: 75863
		private Table __p;
	}
}
