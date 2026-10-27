using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ED3 RID: 3795
	public struct PhantomBattleGym : IFlatbufferObject
	{
		// Token: 0x17002649 RID: 9801
		// (get) Token: 0x0600A742 RID: 42818 RVA: 0x002B0398 File Offset: 0x002AE598
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A743 RID: 42819 RVA: 0x002B03A5 File Offset: 0x002AE5A5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A744 RID: 42820 RVA: 0x002B03AC File Offset: 0x002AE5AC
		public static PhantomBattleGym GetRootAsPhantomBattleGym(ByteBuffer _bb)
		{
			return PhantomBattleGym.GetRootAsPhantomBattleGym(_bb, default(PhantomBattleGym));
		}

		// Token: 0x0600A745 RID: 42821 RVA: 0x002B03C8 File Offset: 0x002AE5C8
		public static PhantomBattleGym GetRootAsPhantomBattleGym(ByteBuffer _bb, PhantomBattleGym obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A746 RID: 42822 RVA: 0x002B03E5 File Offset: 0x002AE5E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A747 RID: 42823 RVA: 0x002B03F4 File Offset: 0x002AE5F4
		public PhantomBattleGym __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700264A RID: 9802
		// (get) Token: 0x0600A748 RID: 42824 RVA: 0x002B0404 File Offset: 0x002AE604
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

		// Token: 0x1700264B RID: 9803
		// (get) Token: 0x0600A749 RID: 42825 RVA: 0x002B0440 File Offset: 0x002AE640
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

		// Token: 0x1700264C RID: 9804
		// (get) Token: 0x0600A74A RID: 42826 RVA: 0x002B047C File Offset: 0x002AE67C
		public int Level
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

		// Token: 0x1700264D RID: 9805
		// (get) Token: 0x0600A74B RID: 42827 RVA: 0x002B04B8 File Offset: 0x002AE6B8
		public string Name
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

		// Token: 0x0600A74C RID: 42828 RVA: 0x002B04F0 File Offset: 0x002AE6F0
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600A74D RID: 42829 RVA: 0x002B0500 File Offset: 0x002AE700
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700264E RID: 9806
		// (get) Token: 0x0600A74E RID: 42830 RVA: 0x002B0518 File Offset: 0x002AE718
		public bool IfRepeat
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700264F RID: 9807
		// (get) Token: 0x0600A74F RID: 42831 RVA: 0x002B0558 File Offset: 0x002AE758
		public string TextureBg
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

		// Token: 0x0600A750 RID: 42832 RVA: 0x002B0590 File Offset: 0x002AE790
		public Span<byte> GetTextureBgBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600A751 RID: 42833 RVA: 0x002B05A0 File Offset: 0x002AE7A0
		public byte[] GetTextureBgArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002650 RID: 9808
		// (get) Token: 0x0600A752 RID: 42834 RVA: 0x002B05B8 File Offset: 0x002AE7B8
		public string Icon
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

		// Token: 0x0600A753 RID: 42835 RVA: 0x002B05F0 File Offset: 0x002AE7F0
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600A754 RID: 42836 RVA: 0x002B0600 File Offset: 0x002AE800
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002651 RID: 9809
		// (get) Token: 0x0600A755 RID: 42837 RVA: 0x002B0618 File Offset: 0x002AE818
		public string IconLock
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A756 RID: 42838 RVA: 0x002B0650 File Offset: 0x002AE850
		public Span<byte> GetIconLockBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600A757 RID: 42839 RVA: 0x002B0660 File Offset: 0x002AE860
		public byte[] GetIconLockArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002652 RID: 9810
		// (get) Token: 0x0600A758 RID: 42840 RVA: 0x002B0678 File Offset: 0x002AE878
		public string IconBg
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A759 RID: 42841 RVA: 0x002B06B0 File Offset: 0x002AE8B0
		public Span<byte> GetIconBgBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600A75A RID: 42842 RVA: 0x002B06C0 File Offset: 0x002AE8C0
		public byte[] GetIconBgArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002653 RID: 9811
		// (get) Token: 0x0600A75B RID: 42843 RVA: 0x002B06D8 File Offset: 0x002AE8D8
		public string IconRoman
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A75C RID: 42844 RVA: 0x002B0710 File Offset: 0x002AE910
		public Span<byte> GetIconRomanBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600A75D RID: 42845 RVA: 0x002B0720 File Offset: 0x002AE920
		public byte[] GetIconRomanArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x04004F91 RID: 20369
		private Table __p;
	}
}
