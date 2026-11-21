using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200111F RID: 4383
	public struct RoleAnimAudio : IFlatbufferObject
	{
		// Token: 0x17003263 RID: 12899
		// (get) Token: 0x0600CD71 RID: 52593 RVA: 0x003133D1 File Offset: 0x003115D1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CD72 RID: 52594 RVA: 0x003133DE File Offset: 0x003115DE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CD73 RID: 52595 RVA: 0x003133E8 File Offset: 0x003115E8
		public static RoleAnimAudio GetRootAsRoleAnimAudio(ByteBuffer _bb)
		{
			return RoleAnimAudio.GetRootAsRoleAnimAudio(_bb, default(RoleAnimAudio));
		}

		// Token: 0x0600CD74 RID: 52596 RVA: 0x00313404 File Offset: 0x00311604
		public static RoleAnimAudio GetRootAsRoleAnimAudio(ByteBuffer _bb, RoleAnimAudio obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CD75 RID: 52597 RVA: 0x00313421 File Offset: 0x00311621
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CD76 RID: 52598 RVA: 0x00313430 File Offset: 0x00311630
		public RoleAnimAudio __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003264 RID: 12900
		// (get) Token: 0x0600CD77 RID: 52599 RVA: 0x00313440 File Offset: 0x00311640
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003265 RID: 12901
		// (get) Token: 0x0600CD78 RID: 52600 RVA: 0x0031347C File Offset: 0x0031167C
		public int RoleId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003266 RID: 12902
		// (get) Token: 0x0600CD79 RID: 52601 RVA: 0x003134B8 File Offset: 0x003116B8
		public string ActionName
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CD7A RID: 52602 RVA: 0x003134EF File Offset: 0x003116EF
		public Span<byte> GetActionNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600CD7B RID: 52603 RVA: 0x003134FE File Offset: 0x003116FE
		public byte[] GetActionNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003267 RID: 12903
		// (get) Token: 0x0600CD7C RID: 52604 RVA: 0x00313518 File Offset: 0x00311718
		public string AudioPath
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CD7D RID: 52605 RVA: 0x00313550 File Offset: 0x00311750
		public Span<byte> GetAudioPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600CD7E RID: 52606 RVA: 0x00313560 File Offset: 0x00311760
		public byte[] GetAudioPathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003268 RID: 12904
		// (get) Token: 0x0600CD7F RID: 52607 RVA: 0x00313578 File Offset: 0x00311778
		public bool CanInterrupt
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0400571C RID: 22300
		private Table __p;
	}
}
