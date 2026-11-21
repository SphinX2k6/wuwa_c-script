using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010A9 RID: 4265
	public struct RhythmEffect : IFlatbufferObject
	{
		// Token: 0x17002EA5 RID: 11941
		// (get) Token: 0x0600C29A RID: 49818 RVA: 0x002FB3F0 File Offset: 0x002F95F0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C29B RID: 49819 RVA: 0x002FB3FD File Offset: 0x002F95FD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C29C RID: 49820 RVA: 0x002FB404 File Offset: 0x002F9604
		public static RhythmEffect GetRootAsRhythmEffect(ByteBuffer _bb)
		{
			return RhythmEffect.GetRootAsRhythmEffect(_bb, default(RhythmEffect));
		}

		// Token: 0x0600C29D RID: 49821 RVA: 0x002FB420 File Offset: 0x002F9620
		public static RhythmEffect GetRootAsRhythmEffect(ByteBuffer _bb, RhythmEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C29E RID: 49822 RVA: 0x002FB43D File Offset: 0x002F963D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C29F RID: 49823 RVA: 0x002FB44C File Offset: 0x002F964C
		public RhythmEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002EA6 RID: 11942
		// (get) Token: 0x0600C2A0 RID: 49824 RVA: 0x002FB45C File Offset: 0x002F965C
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

		// Token: 0x17002EA7 RID: 11943
		// (get) Token: 0x0600C2A1 RID: 49825 RVA: 0x002FB498 File Offset: 0x002F9698
		public int Type
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

		// Token: 0x17002EA8 RID: 11944
		// (get) Token: 0x0600C2A2 RID: 49826 RVA: 0x002FB4D4 File Offset: 0x002F96D4
		public string Param1
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

		// Token: 0x0600C2A3 RID: 49827 RVA: 0x002FB50B File Offset: 0x002F970B
		public Span<byte> GetParam1Bytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C2A4 RID: 49828 RVA: 0x002FB51A File Offset: 0x002F971A
		public byte[] GetParam1Array()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002EA9 RID: 11945
		// (get) Token: 0x0600C2A5 RID: 49829 RVA: 0x002FB534 File Offset: 0x002F9734
		public string Param2
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

		// Token: 0x0600C2A6 RID: 49830 RVA: 0x002FB56C File Offset: 0x002F976C
		public Span<byte> GetParam2Bytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C2A7 RID: 49831 RVA: 0x002FB57C File Offset: 0x002F977C
		public byte[] GetParam2Array()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002EAA RID: 11946
		// (get) Token: 0x0600C2A8 RID: 49832 RVA: 0x002FB594 File Offset: 0x002F9794
		public string Param3
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

		// Token: 0x0600C2A9 RID: 49833 RVA: 0x002FB5CC File Offset: 0x002F97CC
		public Span<byte> GetParam3Bytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600C2AA RID: 49834 RVA: 0x002FB5DC File Offset: 0x002F97DC
		public byte[] GetParam3Array()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04005683 RID: 22147
		private Table __p;
	}
}
