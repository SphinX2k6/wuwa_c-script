using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D85 RID: 3461
	public struct FloroRanchBuff : IFlatbufferObject
	{
		// Token: 0x170012FC RID: 4860
		// (get) Token: 0x0600787D RID: 30845 RVA: 0x00257DBC File Offset: 0x00255FBC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600787E RID: 30846 RVA: 0x00257DC9 File Offset: 0x00255FC9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600787F RID: 30847 RVA: 0x00257DD0 File Offset: 0x00255FD0
		public static FloroRanchBuff GetRootAsFloroRanchBuff(ByteBuffer _bb)
		{
			return FloroRanchBuff.GetRootAsFloroRanchBuff(_bb, default(FloroRanchBuff));
		}

		// Token: 0x06007880 RID: 30848 RVA: 0x00257DEC File Offset: 0x00255FEC
		public static FloroRanchBuff GetRootAsFloroRanchBuff(ByteBuffer _bb, FloroRanchBuff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007881 RID: 30849 RVA: 0x00257E09 File Offset: 0x00256009
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007882 RID: 30850 RVA: 0x00257E18 File Offset: 0x00256018
		public FloroRanchBuff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170012FD RID: 4861
		// (get) Token: 0x06007883 RID: 30851 RVA: 0x00257E28 File Offset: 0x00256028
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

		// Token: 0x170012FE RID: 4862
		// (get) Token: 0x06007884 RID: 30852 RVA: 0x00257E64 File Offset: 0x00256064
		public string Name
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

		// Token: 0x06007885 RID: 30853 RVA: 0x00257E9B File Offset: 0x0025609B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007886 RID: 30854 RVA: 0x00257EAA File Offset: 0x002560AA
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170012FF RID: 4863
		// (get) Token: 0x06007887 RID: 30855 RVA: 0x00257EC4 File Offset: 0x002560C4
		public int Time
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return -1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001300 RID: 4864
		// (get) Token: 0x06007888 RID: 30856 RVA: 0x00257F00 File Offset: 0x00256100
		public int Superposition
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

		// Token: 0x17001301 RID: 4865
		// (get) Token: 0x06007889 RID: 30857 RVA: 0x00257F40 File Offset: 0x00256140
		public bool RefreshTime
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001302 RID: 4866
		// (get) Token: 0x0600788A RID: 30858 RVA: 0x00257F80 File Offset: 0x00256180
		public bool FollowRemove
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001303 RID: 4867
		// (get) Token: 0x0600788B RID: 30859 RVA: 0x00257FC0 File Offset: 0x002561C0
		public bool Caculagraph
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001304 RID: 4868
		// (get) Token: 0x0600788C RID: 30860 RVA: 0x00258000 File Offset: 0x00256200
		public bool IsShowOnTip
		{
			get
			{
				int num = this.__p.__offset(18);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001305 RID: 4869
		// (get) Token: 0x0600788D RID: 30861 RVA: 0x00258040 File Offset: 0x00256240
		public bool IsShowEffect
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x040052E3 RID: 21219
		private Table __p;
	}
}
