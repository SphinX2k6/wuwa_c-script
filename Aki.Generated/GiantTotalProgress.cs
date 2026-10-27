using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CFF RID: 3327
	public struct GiantTotalProgress : IFlatbufferObject
	{
		// Token: 0x170015A9 RID: 5545
		// (get) Token: 0x06007AAD RID: 31405 RVA: 0x0024B9D4 File Offset: 0x00249BD4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007AAE RID: 31406 RVA: 0x0024B9E1 File Offset: 0x00249BE1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007AAF RID: 31407 RVA: 0x0024B9E8 File Offset: 0x00249BE8
		public static GiantTotalProgress GetRootAsGiantTotalProgress(ByteBuffer _bb)
		{
			return GiantTotalProgress.GetRootAsGiantTotalProgress(_bb, default(GiantTotalProgress));
		}

		// Token: 0x06007AB0 RID: 31408 RVA: 0x0024BA04 File Offset: 0x00249C04
		public static GiantTotalProgress GetRootAsGiantTotalProgress(ByteBuffer _bb, GiantTotalProgress obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007AB1 RID: 31409 RVA: 0x0024BA21 File Offset: 0x00249C21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007AB2 RID: 31410 RVA: 0x0024BA30 File Offset: 0x00249C30
		public GiantTotalProgress __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170015AA RID: 5546
		// (get) Token: 0x06007AB3 RID: 31411 RVA: 0x0024BA40 File Offset: 0x00249C40
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

		// Token: 0x170015AB RID: 5547
		// (get) Token: 0x06007AB4 RID: 31412 RVA: 0x0024BA7C File Offset: 0x00249C7C
		public int ActivityId
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

		// Token: 0x170015AC RID: 5548
		// (get) Token: 0x06007AB5 RID: 31413 RVA: 0x0024BAB8 File Offset: 0x00249CB8
		public int Goal
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170015AD RID: 5549
		// (get) Token: 0x06007AB6 RID: 31414 RVA: 0x0024BAF4 File Offset: 0x00249CF4
		public int DropId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170015AE RID: 5550
		// (get) Token: 0x06007AB7 RID: 31415 RVA: 0x0024BB34 File Offset: 0x00249D34
		public string AttitudeDesc
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007AB8 RID: 31416 RVA: 0x0024BB6C File Offset: 0x00249D6C
		public Span<byte> GetAttitudeDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06007AB9 RID: 31417 RVA: 0x0024BB7C File Offset: 0x00249D7C
		public byte[] GetAttitudeDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170015AF RID: 5551
		// (get) Token: 0x06007ABA RID: 31418 RVA: 0x0024BB94 File Offset: 0x00249D94
		public string AssistDesc
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007ABB RID: 31419 RVA: 0x0024BBCC File Offset: 0x00249DCC
		public Span<byte> GetAssistDescBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06007ABC RID: 31420 RVA: 0x0024BBDC File Offset: 0x00249DDC
		public byte[] GetAssistDescArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170015B0 RID: 5552
		// (get) Token: 0x06007ABD RID: 31421 RVA: 0x0024BBF4 File Offset: 0x00249DF4
		public string NodeDesc
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007ABE RID: 31422 RVA: 0x0024BC2C File Offset: 0x00249E2C
		public Span<byte> GetNodeDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06007ABF RID: 31423 RVA: 0x0024BC3C File Offset: 0x00249E3C
		public byte[] GetNodeDescArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x04004D73 RID: 19827
		private Table __p;
	}
}
