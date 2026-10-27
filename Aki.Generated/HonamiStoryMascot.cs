using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D40 RID: 3392
	public struct HonamiStoryMascot : IFlatbufferObject
	{
		// Token: 0x170017E2 RID: 6114
		// (get) Token: 0x0600806F RID: 32879 RVA: 0x002587B4 File Offset: 0x002569B4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008070 RID: 32880 RVA: 0x002587C1 File Offset: 0x002569C1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008071 RID: 32881 RVA: 0x002587C8 File Offset: 0x002569C8
		public static HonamiStoryMascot GetRootAsHonamiStoryMascot(ByteBuffer _bb)
		{
			return HonamiStoryMascot.GetRootAsHonamiStoryMascot(_bb, default(HonamiStoryMascot));
		}

		// Token: 0x06008072 RID: 32882 RVA: 0x002587E4 File Offset: 0x002569E4
		public static HonamiStoryMascot GetRootAsHonamiStoryMascot(ByteBuffer _bb, HonamiStoryMascot obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008073 RID: 32883 RVA: 0x00258801 File Offset: 0x00256A01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008074 RID: 32884 RVA: 0x00258810 File Offset: 0x00256A10
		public HonamiStoryMascot __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170017E3 RID: 6115
		// (get) Token: 0x06008075 RID: 32885 RVA: 0x00258820 File Offset: 0x00256A20
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

		// Token: 0x170017E4 RID: 6116
		// (get) Token: 0x06008076 RID: 32886 RVA: 0x0025885C File Offset: 0x00256A5C
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

		// Token: 0x170017E5 RID: 6117
		// (get) Token: 0x06008077 RID: 32887 RVA: 0x00258898 File Offset: 0x00256A98
		public int DropId
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

		// Token: 0x170017E6 RID: 6118
		// (get) Token: 0x06008078 RID: 32888 RVA: 0x002588D4 File Offset: 0x00256AD4
		public int AreaId
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

		// Token: 0x170017E7 RID: 6119
		// (get) Token: 0x06008079 RID: 32889 RVA: 0x00258914 File Offset: 0x00256B14
		public string Name
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

		// Token: 0x0600807A RID: 32890 RVA: 0x0025894C File Offset: 0x00256B4C
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600807B RID: 32891 RVA: 0x0025895C File Offset: 0x00256B5C
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170017E8 RID: 6120
		// (get) Token: 0x0600807C RID: 32892 RVA: 0x00258974 File Offset: 0x00256B74
		public string FeatureDesc
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

		// Token: 0x0600807D RID: 32893 RVA: 0x002589AC File Offset: 0x00256BAC
		public Span<byte> GetFeatureDescBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600807E RID: 32894 RVA: 0x002589BC File Offset: 0x00256BBC
		public byte[] GetFeatureDescArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170017E9 RID: 6121
		// (get) Token: 0x0600807F RID: 32895 RVA: 0x002589D4 File Offset: 0x00256BD4
		public string ClueDesc
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

		// Token: 0x06008080 RID: 32896 RVA: 0x00258A0C File Offset: 0x00256C0C
		public Span<byte> GetClueDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06008081 RID: 32897 RVA: 0x00258A1C File Offset: 0x00256C1C
		public byte[] GetClueDescArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170017EA RID: 6122
		// (get) Token: 0x06008082 RID: 32898 RVA: 0x00258A34 File Offset: 0x00256C34
		public string Picture
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

		// Token: 0x06008083 RID: 32899 RVA: 0x00258A6C File Offset: 0x00256C6C
		public Span<byte> GetPictureBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06008084 RID: 32900 RVA: 0x00258A7C File Offset: 0x00256C7C
		public byte[] GetPictureArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170017EB RID: 6123
		// (get) Token: 0x06008085 RID: 32901 RVA: 0x00258A94 File Offset: 0x00256C94
		public string TogglePicture
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

		// Token: 0x06008086 RID: 32902 RVA: 0x00258ACC File Offset: 0x00256CCC
		public Span<byte> GetTogglePictureBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06008087 RID: 32903 RVA: 0x00258ADC File Offset: 0x00256CDC
		public byte[] GetTogglePictureArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x04004DBB RID: 19899
		private Table __p;
	}
}
