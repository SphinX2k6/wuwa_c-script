using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001002 RID: 4098
	public struct PhotoWindDirection : IFlatbufferObject
	{
		// Token: 0x17002916 RID: 10518
		// (get) Token: 0x0600B3B3 RID: 46003 RVA: 0x002DB430 File Offset: 0x002D9630
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B3B4 RID: 46004 RVA: 0x002DB43D File Offset: 0x002D963D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B3B5 RID: 46005 RVA: 0x002DB444 File Offset: 0x002D9644
		public static PhotoWindDirection GetRootAsPhotoWindDirection(ByteBuffer _bb)
		{
			return PhotoWindDirection.GetRootAsPhotoWindDirection(_bb, default(PhotoWindDirection));
		}

		// Token: 0x0600B3B6 RID: 46006 RVA: 0x002DB460 File Offset: 0x002D9660
		public static PhotoWindDirection GetRootAsPhotoWindDirection(ByteBuffer _bb, PhotoWindDirection obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B3B7 RID: 46007 RVA: 0x002DB47D File Offset: 0x002D967D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B3B8 RID: 46008 RVA: 0x002DB48C File Offset: 0x002D968C
		public PhotoWindDirection __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002917 RID: 10519
		// (get) Token: 0x0600B3B9 RID: 46009 RVA: 0x002DB49C File Offset: 0x002D969C
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

		// Token: 0x17002918 RID: 10520
		// (get) Token: 0x0600B3BA RID: 46010 RVA: 0x002DB4D8 File Offset: 0x002D96D8
		public string Icon
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

		// Token: 0x0600B3BB RID: 46011 RVA: 0x002DB50F File Offset: 0x002D970F
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B3BC RID: 46012 RVA: 0x002DB51E File Offset: 0x002D971E
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002919 RID: 10521
		// (get) Token: 0x0600B3BD RID: 46013 RVA: 0x002DB538 File Offset: 0x002D9738
		public string Name
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

		// Token: 0x0600B3BE RID: 46014 RVA: 0x002DB56F File Offset: 0x002D976F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B3BF RID: 46015 RVA: 0x002DB57E File Offset: 0x002D977E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700291A RID: 10522
		// (get) Token: 0x0600B3C0 RID: 46016 RVA: 0x002DB598 File Offset: 0x002D9798
		public bool IsDefault
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700291B RID: 10523
		// (get) Token: 0x0600B3C1 RID: 46017 RVA: 0x002DB5D8 File Offset: 0x002D97D8
		public int Direction
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

		// Token: 0x1700291C RID: 10524
		// (get) Token: 0x0600B3C2 RID: 46018 RVA: 0x002DB618 File Offset: 0x002D9818
		public int DefaultStrength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 50;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040055CB RID: 21963
		private Table __p;
	}
}
