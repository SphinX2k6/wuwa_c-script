using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FCE RID: 4046
	public struct PhantomGain : IFlatbufferObject
	{
		// Token: 0x17002739 RID: 10041
		// (get) Token: 0x0600AEDE RID: 44766 RVA: 0x002D0816 File Offset: 0x002CEA16
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AEDF RID: 44767 RVA: 0x002D0823 File Offset: 0x002CEA23
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AEE0 RID: 44768 RVA: 0x002D082C File Offset: 0x002CEA2C
		public static PhantomGain GetRootAsPhantomGain(ByteBuffer _bb)
		{
			return PhantomGain.GetRootAsPhantomGain(_bb, default(PhantomGain));
		}

		// Token: 0x0600AEE1 RID: 44769 RVA: 0x002D0848 File Offset: 0x002CEA48
		public static PhantomGain GetRootAsPhantomGain(ByteBuffer _bb, PhantomGain obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AEE2 RID: 44770 RVA: 0x002D0865 File Offset: 0x002CEA65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AEE3 RID: 44771 RVA: 0x002D0874 File Offset: 0x002CEA74
		public PhantomGain __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700273A RID: 10042
		// (get) Token: 0x0600AEE4 RID: 44772 RVA: 0x002D0884 File Offset: 0x002CEA84
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

		// Token: 0x1700273B RID: 10043
		// (get) Token: 0x0600AEE5 RID: 44773 RVA: 0x002D08C0 File Offset: 0x002CEAC0
		public int MonsterInfoId
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

		// Token: 0x1700273C RID: 10044
		// (get) Token: 0x0600AEE6 RID: 44774 RVA: 0x002D08FC File Offset: 0x002CEAFC
		public int ActivityId
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

		// Token: 0x1700273D RID: 10045
		// (get) Token: 0x0600AEE7 RID: 44775 RVA: 0x002D0938 File Offset: 0x002CEB38
		public int UnLockReward
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

		// Token: 0x1700273E RID: 10046
		// (get) Token: 0x0600AEE8 RID: 44776 RVA: 0x002D0978 File Offset: 0x002CEB78
		public int Sort
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700273F RID: 10047
		// (get) Token: 0x0600AEE9 RID: 44777 RVA: 0x002D09B8 File Offset: 0x002CEBB8
		public string Name
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

		// Token: 0x0600AEEA RID: 44778 RVA: 0x002D09F0 File Offset: 0x002CEBF0
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600AEEB RID: 44779 RVA: 0x002D0A00 File Offset: 0x002CEC00
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002740 RID: 10048
		// (get) Token: 0x0600AEEC RID: 44780 RVA: 0x002D0A18 File Offset: 0x002CEC18
		public string TexPhantom
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

		// Token: 0x0600AEED RID: 44781 RVA: 0x002D0A50 File Offset: 0x002CEC50
		public Span<byte> GetTexPhantomBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600AEEE RID: 44782 RVA: 0x002D0A60 File Offset: 0x002CEC60
		public byte[] GetTexPhantomArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x04005590 RID: 21904
		private Table __p;
	}
}
