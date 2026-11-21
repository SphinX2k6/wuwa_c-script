using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012A2 RID: 4770
	public struct TrapDefenseReward : IFlatbufferObject
	{
		// Token: 0x17003FD4 RID: 16340
		// (get) Token: 0x0600F1D8 RID: 61912 RVA: 0x00365598 File Offset: 0x00363798
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F1D9 RID: 61913 RVA: 0x003655A5 File Offset: 0x003637A5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F1DA RID: 61914 RVA: 0x003655AC File Offset: 0x003637AC
		public static TrapDefenseReward GetRootAsTrapDefenseReward(ByteBuffer _bb)
		{
			return TrapDefenseReward.GetRootAsTrapDefenseReward(_bb, default(TrapDefenseReward));
		}

		// Token: 0x0600F1DB RID: 61915 RVA: 0x003655C8 File Offset: 0x003637C8
		public static TrapDefenseReward GetRootAsTrapDefenseReward(ByteBuffer _bb, TrapDefenseReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F1DC RID: 61916 RVA: 0x003655E5 File Offset: 0x003637E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F1DD RID: 61917 RVA: 0x003655F4 File Offset: 0x003637F4
		public TrapDefenseReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003FD5 RID: 16341
		// (get) Token: 0x0600F1DE RID: 61918 RVA: 0x00365604 File Offset: 0x00363804
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

		// Token: 0x17003FD6 RID: 16342
		// (get) Token: 0x0600F1DF RID: 61919 RVA: 0x00365640 File Offset: 0x00363840
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

		// Token: 0x17003FD7 RID: 16343
		// (get) Token: 0x0600F1E0 RID: 61920 RVA: 0x0036567C File Offset: 0x0036387C
		public int Type
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003FD8 RID: 16344
		// (get) Token: 0x0600F1E1 RID: 61921 RVA: 0x003656B8 File Offset: 0x003638B8
		public bool IsPermanent
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003FD9 RID: 16345
		// (get) Token: 0x0600F1E2 RID: 61922 RVA: 0x003656F8 File Offset: 0x003638F8
		public int RewardId
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

		// Token: 0x17003FDA RID: 16346
		// (get) Token: 0x0600F1E3 RID: 61923 RVA: 0x00365738 File Offset: 0x00363938
		public string Desc
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

		// Token: 0x0600F1E4 RID: 61924 RVA: 0x00365770 File Offset: 0x00363970
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600F1E5 RID: 61925 RVA: 0x00365780 File Offset: 0x00363980
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x040058F5 RID: 22773
		private Table __p;
	}
}
