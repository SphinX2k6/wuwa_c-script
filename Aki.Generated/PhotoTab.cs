using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FFF RID: 4095
	public struct PhotoTab : IFlatbufferObject
	{
		// Token: 0x17002903 RID: 10499
		// (get) Token: 0x0600B37E RID: 45950 RVA: 0x002DADAD File Offset: 0x002D8FAD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B37F RID: 45951 RVA: 0x002DADBA File Offset: 0x002D8FBA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B380 RID: 45952 RVA: 0x002DADC4 File Offset: 0x002D8FC4
		public static PhotoTab GetRootAsPhotoTab(ByteBuffer _bb)
		{
			return PhotoTab.GetRootAsPhotoTab(_bb, default(PhotoTab));
		}

		// Token: 0x0600B381 RID: 45953 RVA: 0x002DADE0 File Offset: 0x002D8FE0
		public static PhotoTab GetRootAsPhotoTab(ByteBuffer _bb, PhotoTab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B382 RID: 45954 RVA: 0x002DADFD File Offset: 0x002D8FFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B383 RID: 45955 RVA: 0x002DAE0C File Offset: 0x002D900C
		public PhotoTab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002904 RID: 10500
		// (get) Token: 0x0600B384 RID: 45956 RVA: 0x002DAE1C File Offset: 0x002D901C
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

		// Token: 0x17002905 RID: 10501
		// (get) Token: 0x0600B385 RID: 45957 RVA: 0x002DAE58 File Offset: 0x002D9058
		public int Type
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

		// Token: 0x17002906 RID: 10502
		// (get) Token: 0x0600B386 RID: 45958 RVA: 0x002DAE94 File Offset: 0x002D9094
		public int SortId
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

		// Token: 0x17002907 RID: 10503
		// (get) Token: 0x0600B387 RID: 45959 RVA: 0x002DAED0 File Offset: 0x002D90D0
		public string Icon
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

		// Token: 0x0600B388 RID: 45960 RVA: 0x002DAF08 File Offset: 0x002D9108
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600B389 RID: 45961 RVA: 0x002DAF18 File Offset: 0x002D9118
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0600B38A RID: 45962 RVA: 0x002DAF30 File Offset: 0x002D9130
		public int PhotoSubTabList(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002908 RID: 10504
		// (get) Token: 0x0600B38B RID: 45963 RVA: 0x002DAF70 File Offset: 0x002D9170
		public int PhotoSubTabListLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600B38C RID: 45964 RVA: 0x002DAF9C File Offset: 0x002D919C
		public Span<int> GetPhotoSubTabListBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600B38D RID: 45965 RVA: 0x002DAFAC File Offset: 0x002D91AC
		public int[] GetPhotoSubTabListArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17002909 RID: 10505
		// (get) Token: 0x0600B38E RID: 45966 RVA: 0x002DAFC4 File Offset: 0x002D91C4
		public string DetalPanelResId
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

		// Token: 0x0600B38F RID: 45967 RVA: 0x002DAFFC File Offset: 0x002D91FC
		public Span<byte> GetDetalPanelResIdBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600B390 RID: 45968 RVA: 0x002DB00C File Offset: 0x002D920C
		public byte[] GetDetalPanelResIdArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x0600B391 RID: 45969 RVA: 0x002DB024 File Offset: 0x002D9224
		[NullableContext(1)]
		public int[] PhotoSubTabList()
		{
			return this.GetPhotoSubTabListArray();
		}

		// Token: 0x0600B392 RID: 45970 RVA: 0x002DB02C File Offset: 0x002D922C
		[NullableContext(1)]
		public IEnumerable<int> PhotoSubTabListIter()
		{
			PhotoTab.<PhotoSubTabListIter>d__28 <PhotoSubTabListIter>d__ = new PhotoTab.<PhotoSubTabListIter>d__28(-2);
			<PhotoSubTabListIter>d__.<>3__<>4__this = this;
			return <PhotoSubTabListIter>d__;
		}

		// Token: 0x040055C8 RID: 21960
		private Table __p;
	}
}
