using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E3A RID: 3642
	public struct HotKeyMap : IFlatbufferObject
	{
		// Token: 0x170018E3 RID: 6371
		// (get) Token: 0x06008830 RID: 34864 RVA: 0x0027A975 File Offset: 0x00278B75
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008831 RID: 34865 RVA: 0x0027A982 File Offset: 0x00278B82
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008832 RID: 34866 RVA: 0x0027A98C File Offset: 0x00278B8C
		public static HotKeyMap GetRootAsHotKeyMap(ByteBuffer _bb)
		{
			return HotKeyMap.GetRootAsHotKeyMap(_bb, default(HotKeyMap));
		}

		// Token: 0x06008833 RID: 34867 RVA: 0x0027A9A8 File Offset: 0x00278BA8
		public static HotKeyMap GetRootAsHotKeyMap(ByteBuffer _bb, HotKeyMap obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008834 RID: 34868 RVA: 0x0027A9C5 File Offset: 0x00278BC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008835 RID: 34869 RVA: 0x0027A9D4 File Offset: 0x00278BD4
		public HotKeyMap __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170018E4 RID: 6372
		// (get) Token: 0x06008836 RID: 34870 RVA: 0x0027A9E4 File Offset: 0x00278BE4
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

		// Token: 0x170018E5 RID: 6373
		// (get) Token: 0x06008837 RID: 34871 RVA: 0x0027AA20 File Offset: 0x00278C20
		public string ActionName
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

		// Token: 0x06008838 RID: 34872 RVA: 0x0027AA57 File Offset: 0x00278C57
		public Span<byte> GetActionNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06008839 RID: 34873 RVA: 0x0027AA66 File Offset: 0x00278C66
		public byte[] GetActionNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170018E6 RID: 6374
		// (get) Token: 0x0600883A RID: 34874 RVA: 0x0027AA80 File Offset: 0x00278C80
		public string AxisName
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

		// Token: 0x0600883B RID: 34875 RVA: 0x0027AAB7 File Offset: 0x00278CB7
		public Span<byte> GetAxisNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600883C RID: 34876 RVA: 0x0027AAC6 File Offset: 0x00278CC6
		public byte[] GetAxisNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170018E7 RID: 6375
		// (get) Token: 0x0600883D RID: 34877 RVA: 0x0027AAE0 File Offset: 0x00278CE0
		public int AxisDirection
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

		// Token: 0x170018E8 RID: 6376
		// (get) Token: 0x0600883E RID: 34878 RVA: 0x0027AB20 File Offset: 0x00278D20
		public string TextId
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

		// Token: 0x0600883F RID: 34879 RVA: 0x0027AB58 File Offset: 0x00278D58
		public Span<byte> GetTextIdBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06008840 RID: 34880 RVA: 0x0027AB68 File Offset: 0x00278D68
		public byte[] GetTextIdArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170018E9 RID: 6377
		// (get) Token: 0x06008841 RID: 34881 RVA: 0x0027AB80 File Offset: 0x00278D80
		public string Type
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

		// Token: 0x06008842 RID: 34882 RVA: 0x0027ABB8 File Offset: 0x00278DB8
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06008843 RID: 34883 RVA: 0x0027ABC8 File Offset: 0x00278DC8
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170018EA RID: 6378
		// (get) Token: 0x06008844 RID: 34884 RVA: 0x0027ABE0 File Offset: 0x00278DE0
		public int LongPressTime
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170018EB RID: 6379
		// (get) Token: 0x06008845 RID: 34885 RVA: 0x0027AC20 File Offset: 0x00278E20
		public int ReleaseFailureTime
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170018EC RID: 6380
		// (get) Token: 0x06008846 RID: 34886 RVA: 0x0027AC60 File Offset: 0x00278E60
		public string BindButtonTag
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

		// Token: 0x06008847 RID: 34887 RVA: 0x0027AC98 File Offset: 0x00278E98
		public Span<byte> GetBindButtonTagBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06008848 RID: 34888 RVA: 0x0027ACA8 File Offset: 0x00278EA8
		public byte[] GetBindButtonTagArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170018ED RID: 6381
		// (get) Token: 0x06008849 RID: 34889 RVA: 0x0027ACC0 File Offset: 0x00278EC0
		public int ApplicableType
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170018EE RID: 6382
		// (get) Token: 0x0600884A RID: 34890 RVA: 0x0027AD00 File Offset: 0x00278F00
		public bool IsOccupancyFightInput
		{
			get
			{
				int num = this.__p.__offset(24);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170018EF RID: 6383
		// (get) Token: 0x0600884B RID: 34891 RVA: 0x0027AD40 File Offset: 0x00278F40
		public bool HideInShowMouse
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x040053B9 RID: 21433
		private Table __p;
	}
}
