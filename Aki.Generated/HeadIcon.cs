using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E0B RID: 3595
	public struct HeadIcon : IFlatbufferObject
	{
		// Token: 0x17001753 RID: 5971
		// (get) Token: 0x0600844F RID: 33871 RVA: 0x00271F3E File Offset: 0x0027013E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008450 RID: 33872 RVA: 0x00271F4B File Offset: 0x0027014B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008451 RID: 33873 RVA: 0x00271F54 File Offset: 0x00270154
		public static HeadIcon GetRootAsHeadIcon(ByteBuffer _bb)
		{
			return HeadIcon.GetRootAsHeadIcon(_bb, default(HeadIcon));
		}

		// Token: 0x06008452 RID: 33874 RVA: 0x00271F70 File Offset: 0x00270170
		public static HeadIcon GetRootAsHeadIcon(ByteBuffer _bb, HeadIcon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008453 RID: 33875 RVA: 0x00271F8D File Offset: 0x0027018D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008454 RID: 33876 RVA: 0x00271F9C File Offset: 0x0027019C
		public HeadIcon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001754 RID: 5972
		// (get) Token: 0x06008455 RID: 33877 RVA: 0x00271FAC File Offset: 0x002701AC
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

		// Token: 0x17001755 RID: 5973
		// (get) Token: 0x06008456 RID: 33878 RVA: 0x00271FE8 File Offset: 0x002701E8
		public string IconPath
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

		// Token: 0x06008457 RID: 33879 RVA: 0x0027201F File Offset: 0x0027021F
		public Span<byte> GetIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06008458 RID: 33880 RVA: 0x0027202E File Offset: 0x0027022E
		public byte[] GetIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001756 RID: 5974
		// (get) Token: 0x06008459 RID: 33881 RVA: 0x00272048 File Offset: 0x00270248
		public string BigIconPath
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

		// Token: 0x0600845A RID: 33882 RVA: 0x0027207F File Offset: 0x0027027F
		public Span<byte> GetBigIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600845B RID: 33883 RVA: 0x0027208E File Offset: 0x0027028E
		public byte[] GetBigIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04005383 RID: 21379
		private Table __p;
	}
}
