using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EDC RID: 28380
	public struct IRogueActivatePortal : IFlatbufferObject
	{
		// Token: 0x1700D32A RID: 54058
		// (get) Token: 0x0603226D RID: 205421 RVA: 0x006C754A File Offset: 0x006C574A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603226E RID: 205422 RVA: 0x006C7557 File Offset: 0x006C5757
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603226F RID: 205423 RVA: 0x006C7560 File Offset: 0x006C5760
		public static IRogueActivatePortal GetRootAsIRogueActivatePortal(ByteBuffer _bb)
		{
			return IRogueActivatePortal.GetRootAsIRogueActivatePortal(_bb, default(IRogueActivatePortal));
		}

		// Token: 0x06032270 RID: 205424 RVA: 0x006C757C File Offset: 0x006C577C
		public static IRogueActivatePortal GetRootAsIRogueActivatePortal(ByteBuffer _bb, IRogueActivatePortal obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032271 RID: 205425 RVA: 0x006C7599 File Offset: 0x006C5799
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032272 RID: 205426 RVA: 0x006C75A8 File Offset: 0x006C57A8
		public IRogueActivatePortal __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06032273 RID: 205427 RVA: 0x006C75B8 File Offset: 0x006C57B8
		public static void StartIRogueActivatePortal(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x06032274 RID: 205428 RVA: 0x006C75C1 File Offset: 0x006C57C1
		public static Offset<IRogueActivatePortal> EndIRogueActivatePortal(FlatBufferBuilder builder)
		{
			return new Offset<IRogueActivatePortal>(builder.EndTable());
		}

		// Token: 0x06032275 RID: 205429 RVA: 0x006C75D0 File Offset: 0x006C57D0
		public IRogueActivatePortalT UnPack()
		{
			IRogueActivatePortalT rogueActivatePortalT = new IRogueActivatePortalT();
			this.UnPackTo(rogueActivatePortalT);
			return rogueActivatePortalT;
		}

		// Token: 0x06032276 RID: 205430 RVA: 0x006C75EB File Offset: 0x006C57EB
		public void UnPackTo(IRogueActivatePortalT _o)
		{
		}

		// Token: 0x06032277 RID: 205431 RVA: 0x006C75F0 File Offset: 0x006C57F0
		public static Offset<IRogueActivatePortal> Pack(FlatBufferBuilder builder, IRogueActivatePortalT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRogueActivatePortal>);
			}
			IRogueActivatePortal.StartIRogueActivatePortal(builder);
			return IRogueActivatePortal.EndIRogueActivatePortal(builder);
		}

		// Token: 0x040118D2 RID: 71890
		private Table __p;
	}
}
