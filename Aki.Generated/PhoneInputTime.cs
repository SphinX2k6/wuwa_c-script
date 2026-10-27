using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EFF RID: 3839
	public struct PhoneInputTime : IFlatbufferObject
	{
		// Token: 0x17002781 RID: 10113
		// (get) Token: 0x0600AABF RID: 43711 RVA: 0x002B81CE File Offset: 0x002B63CE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AAC0 RID: 43712 RVA: 0x002B81DB File Offset: 0x002B63DB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AAC1 RID: 43713 RVA: 0x002B81E4 File Offset: 0x002B63E4
		public static PhoneInputTime GetRootAsPhoneInputTime(ByteBuffer _bb)
		{
			return PhoneInputTime.GetRootAsPhoneInputTime(_bb, default(PhoneInputTime));
		}

		// Token: 0x0600AAC2 RID: 43714 RVA: 0x002B8200 File Offset: 0x002B6400
		public static PhoneInputTime GetRootAsPhoneInputTime(ByteBuffer _bb, PhoneInputTime obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AAC3 RID: 43715 RVA: 0x002B821D File Offset: 0x002B641D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AAC4 RID: 43716 RVA: 0x002B822C File Offset: 0x002B642C
		public PhoneInputTime __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002782 RID: 10114
		// (get) Token: 0x0600AAC5 RID: 43717 RVA: 0x002B823C File Offset: 0x002B643C
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

		// Token: 0x17002783 RID: 10115
		// (get) Token: 0x0600AAC6 RID: 43718 RVA: 0x002B8278 File Offset: 0x002B6478
		public int StartChatNum
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

		// Token: 0x17002784 RID: 10116
		// (get) Token: 0x0600AAC7 RID: 43719 RVA: 0x002B82B4 File Offset: 0x002B64B4
		public int EndChatNum
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

		// Token: 0x17002785 RID: 10117
		// (get) Token: 0x0600AAC8 RID: 43720 RVA: 0x002B82F0 File Offset: 0x002B64F0
		public int DelayTime
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

		// Token: 0x04004FC7 RID: 20423
		private Table __p;
	}
}
