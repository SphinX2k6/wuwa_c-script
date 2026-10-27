using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001151 RID: 4433
	public struct TransitionPopup : IFlatbufferObject
	{
		// Token: 0x17003B5E RID: 15198
		// (get) Token: 0x0600E155 RID: 57685 RVA: 0x003338C4 File Offset: 0x00331AC4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E156 RID: 57686 RVA: 0x003338D1 File Offset: 0x00331AD1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E157 RID: 57687 RVA: 0x003338D8 File Offset: 0x00331AD8
		public static TransitionPopup GetRootAsTransitionPopup(ByteBuffer _bb)
		{
			return TransitionPopup.GetRootAsTransitionPopup(_bb, default(TransitionPopup));
		}

		// Token: 0x0600E158 RID: 57688 RVA: 0x003338F4 File Offset: 0x00331AF4
		public static TransitionPopup GetRootAsTransitionPopup(ByteBuffer _bb, TransitionPopup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E159 RID: 57689 RVA: 0x00333911 File Offset: 0x00331B11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E15A RID: 57690 RVA: 0x00333920 File Offset: 0x00331B20
		public TransitionPopup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003B5F RID: 15199
		// (get) Token: 0x0600E15B RID: 57691 RVA: 0x00333930 File Offset: 0x00331B30
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

		// Token: 0x17003B60 RID: 15200
		// (get) Token: 0x0600E15C RID: 57692 RVA: 0x0033396C File Offset: 0x00331B6C
		public int Style
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

		// Token: 0x17003B61 RID: 15201
		// (get) Token: 0x0600E15D RID: 57693 RVA: 0x003339A8 File Offset: 0x00331BA8
		public string Title
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

		// Token: 0x0600E15E RID: 57694 RVA: 0x003339DF File Offset: 0x00331BDF
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600E15F RID: 57695 RVA: 0x003339EE File Offset: 0x00331BEE
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003B62 RID: 15202
		// (get) Token: 0x0600E160 RID: 57696 RVA: 0x00333A08 File Offset: 0x00331C08
		public string ContentText
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

		// Token: 0x0600E161 RID: 57697 RVA: 0x00333A40 File Offset: 0x00331C40
		public Span<byte> GetContentTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600E162 RID: 57698 RVA: 0x00333A50 File Offset: 0x00331C50
		public byte[] GetContentTextArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04005296 RID: 21142
		private Table __p;
	}
}
