using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E25 RID: 3621
	public struct HonamiStoryMascot : IFlatbufferObject
	{
		// Token: 0x17001845 RID: 6213
		// (get) Token: 0x06008689 RID: 34441 RVA: 0x00276FB0 File Offset: 0x002751B0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600868A RID: 34442 RVA: 0x00276FBD File Offset: 0x002751BD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600868B RID: 34443 RVA: 0x00276FC4 File Offset: 0x002751C4
		public static HonamiStoryMascot GetRootAsHonamiStoryMascot(ByteBuffer _bb)
		{
			return HonamiStoryMascot.GetRootAsHonamiStoryMascot(_bb, default(HonamiStoryMascot));
		}

		// Token: 0x0600868C RID: 34444 RVA: 0x00276FE0 File Offset: 0x002751E0
		public static HonamiStoryMascot GetRootAsHonamiStoryMascot(ByteBuffer _bb, HonamiStoryMascot obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600868D RID: 34445 RVA: 0x00276FFD File Offset: 0x002751FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600868E RID: 34446 RVA: 0x0027700C File Offset: 0x0027520C
		public HonamiStoryMascot __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001846 RID: 6214
		// (get) Token: 0x0600868F RID: 34447 RVA: 0x0027701C File Offset: 0x0027521C
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

		// Token: 0x17001847 RID: 6215
		// (get) Token: 0x06008690 RID: 34448 RVA: 0x00277058 File Offset: 0x00275258
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

		// Token: 0x17001848 RID: 6216
		// (get) Token: 0x06008691 RID: 34449 RVA: 0x00277094 File Offset: 0x00275294
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

		// Token: 0x17001849 RID: 6217
		// (get) Token: 0x06008692 RID: 34450 RVA: 0x002770D0 File Offset: 0x002752D0
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

		// Token: 0x1700184A RID: 6218
		// (get) Token: 0x06008693 RID: 34451 RVA: 0x00277110 File Offset: 0x00275310
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

		// Token: 0x06008694 RID: 34452 RVA: 0x00277148 File Offset: 0x00275348
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06008695 RID: 34453 RVA: 0x00277158 File Offset: 0x00275358
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700184B RID: 6219
		// (get) Token: 0x06008696 RID: 34454 RVA: 0x00277170 File Offset: 0x00275370
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

		// Token: 0x06008697 RID: 34455 RVA: 0x002771A8 File Offset: 0x002753A8
		public Span<byte> GetFeatureDescBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06008698 RID: 34456 RVA: 0x002771B8 File Offset: 0x002753B8
		public byte[] GetFeatureDescArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700184C RID: 6220
		// (get) Token: 0x06008699 RID: 34457 RVA: 0x002771D0 File Offset: 0x002753D0
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

		// Token: 0x0600869A RID: 34458 RVA: 0x00277208 File Offset: 0x00275408
		public Span<byte> GetClueDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600869B RID: 34459 RVA: 0x00277218 File Offset: 0x00275418
		public byte[] GetClueDescArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700184D RID: 6221
		// (get) Token: 0x0600869C RID: 34460 RVA: 0x00277230 File Offset: 0x00275430
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

		// Token: 0x0600869D RID: 34461 RVA: 0x00277268 File Offset: 0x00275468
		public Span<byte> GetPictureBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600869E RID: 34462 RVA: 0x00277278 File Offset: 0x00275478
		public byte[] GetPictureArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x1700184E RID: 6222
		// (get) Token: 0x0600869F RID: 34463 RVA: 0x00277290 File Offset: 0x00275490
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

		// Token: 0x060086A0 RID: 34464 RVA: 0x002772C8 File Offset: 0x002754C8
		public Span<byte> GetTogglePictureBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x060086A1 RID: 34465 RVA: 0x002772D8 File Offset: 0x002754D8
		public byte[] GetTogglePictureArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x040053A0 RID: 21408
		private Table __p;
	}
}
