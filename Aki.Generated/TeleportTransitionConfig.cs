using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200111C RID: 4380
	public struct TeleportTransitionConfig : IFlatbufferObject
	{
		// Token: 0x170039F0 RID: 14832
		// (get) Token: 0x0600DD5F RID: 56671 RVA: 0x0032AACD File Offset: 0x00328CCD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DD60 RID: 56672 RVA: 0x0032AADA File Offset: 0x00328CDA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DD61 RID: 56673 RVA: 0x0032AAE4 File Offset: 0x00328CE4
		public static TeleportTransitionConfig GetRootAsTeleportTransitionConfig(ByteBuffer _bb)
		{
			return TeleportTransitionConfig.GetRootAsTeleportTransitionConfig(_bb, default(TeleportTransitionConfig));
		}

		// Token: 0x0600DD62 RID: 56674 RVA: 0x0032AB00 File Offset: 0x00328D00
		public static TeleportTransitionConfig GetRootAsTeleportTransitionConfig(ByteBuffer _bb, TeleportTransitionConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DD63 RID: 56675 RVA: 0x0032AB1D File Offset: 0x00328D1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DD64 RID: 56676 RVA: 0x0032AB2C File Offset: 0x00328D2C
		public TeleportTransitionConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170039F1 RID: 14833
		// (get) Token: 0x0600DD65 RID: 56677 RVA: 0x0032AB3C File Offset: 0x00328D3C
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

		// Token: 0x170039F2 RID: 14834
		// (get) Token: 0x0600DD66 RID: 56678 RVA: 0x0032AB78 File Offset: 0x00328D78
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DD67 RID: 56679 RVA: 0x0032ABAF File Offset: 0x00328DAF
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600DD68 RID: 56680 RVA: 0x0032ABBE File Offset: 0x00328DBE
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170039F3 RID: 14835
		// (get) Token: 0x0600DD69 RID: 56681 RVA: 0x0032ABD8 File Offset: 0x00328DD8
		public string Data
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

		// Token: 0x0600DD6A RID: 56682 RVA: 0x0032AC0F File Offset: 0x00328E0F
		public Span<byte> GetDataBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600DD6B RID: 56683 RVA: 0x0032AC1E File Offset: 0x00328E1E
		public byte[] GetDataArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04005259 RID: 21081
		private Table __p;
	}
}
