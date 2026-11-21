using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FE4 RID: 4068
	public struct PhoneInputTime : IFlatbufferObject
	{
		// Token: 0x170027E7 RID: 10215
		// (get) Token: 0x0600B0E0 RID: 45280 RVA: 0x002D4F6E File Offset: 0x002D316E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B0E1 RID: 45281 RVA: 0x002D4F7B File Offset: 0x002D317B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B0E2 RID: 45282 RVA: 0x002D4F84 File Offset: 0x002D3184
		public static PhoneInputTime GetRootAsPhoneInputTime(ByteBuffer _bb)
		{
			return PhoneInputTime.GetRootAsPhoneInputTime(_bb, default(PhoneInputTime));
		}

		// Token: 0x0600B0E3 RID: 45283 RVA: 0x002D4FA0 File Offset: 0x002D31A0
		public static PhoneInputTime GetRootAsPhoneInputTime(ByteBuffer _bb, PhoneInputTime obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B0E4 RID: 45284 RVA: 0x002D4FBD File Offset: 0x002D31BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B0E5 RID: 45285 RVA: 0x002D4FCC File Offset: 0x002D31CC
		public PhoneInputTime __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170027E8 RID: 10216
		// (get) Token: 0x0600B0E6 RID: 45286 RVA: 0x002D4FDC File Offset: 0x002D31DC
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

		// Token: 0x170027E9 RID: 10217
		// (get) Token: 0x0600B0E7 RID: 45287 RVA: 0x002D5018 File Offset: 0x002D3218
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

		// Token: 0x170027EA RID: 10218
		// (get) Token: 0x0600B0E8 RID: 45288 RVA: 0x002D5054 File Offset: 0x002D3254
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

		// Token: 0x170027EB RID: 10219
		// (get) Token: 0x0600B0E9 RID: 45289 RVA: 0x002D5090 File Offset: 0x002D3290
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

		// Token: 0x040055AC RID: 21932
		private Table __p;
	}
}
