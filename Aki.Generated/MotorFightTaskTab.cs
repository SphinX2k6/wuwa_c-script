using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E51 RID: 3665
	public struct MotorFightTaskTab : IFlatbufferObject
	{
		// Token: 0x17002143 RID: 8515
		// (get) Token: 0x06009994 RID: 39316 RVA: 0x00291A31 File Offset: 0x0028FC31
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009995 RID: 39317 RVA: 0x00291A3E File Offset: 0x0028FC3E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009996 RID: 39318 RVA: 0x00291A48 File Offset: 0x0028FC48
		public static MotorFightTaskTab GetRootAsMotorFightTaskTab(ByteBuffer _bb)
		{
			return MotorFightTaskTab.GetRootAsMotorFightTaskTab(_bb, default(MotorFightTaskTab));
		}

		// Token: 0x06009997 RID: 39319 RVA: 0x00291A64 File Offset: 0x0028FC64
		public static MotorFightTaskTab GetRootAsMotorFightTaskTab(ByteBuffer _bb, MotorFightTaskTab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009998 RID: 39320 RVA: 0x00291A81 File Offset: 0x0028FC81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009999 RID: 39321 RVA: 0x00291A90 File Offset: 0x0028FC90
		public MotorFightTaskTab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002144 RID: 8516
		// (get) Token: 0x0600999A RID: 39322 RVA: 0x00291AA0 File Offset: 0x0028FCA0
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

		// Token: 0x17002145 RID: 8517
		// (get) Token: 0x0600999B RID: 39323 RVA: 0x00291ADC File Offset: 0x0028FCDC
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

		// Token: 0x17002146 RID: 8518
		// (get) Token: 0x0600999C RID: 39324 RVA: 0x00291B18 File Offset: 0x0028FD18
		public string TabTitle
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

		// Token: 0x0600999D RID: 39325 RVA: 0x00291B4F File Offset: 0x0028FD4F
		public Span<byte> GetTabTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600999E RID: 39326 RVA: 0x00291B5E File Offset: 0x0028FD5E
		public byte[] GetTabTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004EFA RID: 20218
		private Table __p;
	}
}
