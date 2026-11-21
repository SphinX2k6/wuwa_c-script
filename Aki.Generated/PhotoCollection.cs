using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FEA RID: 4074
	public struct PhotoCollection : IFlatbufferObject
	{
		// Token: 0x17002813 RID: 10259
		// (get) Token: 0x0600B154 RID: 45396 RVA: 0x002D5E32 File Offset: 0x002D4032
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B155 RID: 45397 RVA: 0x002D5E3F File Offset: 0x002D403F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B156 RID: 45398 RVA: 0x002D5E48 File Offset: 0x002D4048
		public static PhotoCollection GetRootAsPhotoCollection(ByteBuffer _bb)
		{
			return PhotoCollection.GetRootAsPhotoCollection(_bb, default(PhotoCollection));
		}

		// Token: 0x0600B157 RID: 45399 RVA: 0x002D5E64 File Offset: 0x002D4064
		public static PhotoCollection GetRootAsPhotoCollection(ByteBuffer _bb, PhotoCollection obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B158 RID: 45400 RVA: 0x002D5E81 File Offset: 0x002D4081
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B159 RID: 45401 RVA: 0x002D5E90 File Offset: 0x002D4090
		public PhotoCollection __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002814 RID: 10260
		// (get) Token: 0x0600B15A RID: 45402 RVA: 0x002D5EA0 File Offset: 0x002D40A0
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

		// Token: 0x0600B15B RID: 45403 RVA: 0x002D5EDC File Offset: 0x002D40DC
		public int WhiteList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002815 RID: 10261
		// (get) Token: 0x0600B15C RID: 45404 RVA: 0x002D5F1C File Offset: 0x002D411C
		public int WhiteListLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600B15D RID: 45405 RVA: 0x002D5F47 File Offset: 0x002D4147
		public Span<int> GetWhiteListBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600B15E RID: 45406 RVA: 0x002D5F56 File Offset: 0x002D4156
		public int[] GetWhiteListArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600B15F RID: 45407 RVA: 0x002D5F70 File Offset: 0x002D4170
		public int BlackList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002816 RID: 10262
		// (get) Token: 0x0600B160 RID: 45408 RVA: 0x002D5FB0 File Offset: 0x002D41B0
		public int BlackListLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600B161 RID: 45409 RVA: 0x002D5FDB File Offset: 0x002D41DB
		public Span<int> GetBlackListBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600B162 RID: 45410 RVA: 0x002D5FEA File Offset: 0x002D41EA
		public int[] GetBlackListArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600B163 RID: 45411 RVA: 0x002D6001 File Offset: 0x002D4201
		[NullableContext(1)]
		public int[] BlackList()
		{
			return this.GetBlackListArray();
		}

		// Token: 0x0600B164 RID: 45412 RVA: 0x002D6009 File Offset: 0x002D4209
		[NullableContext(1)]
		public IEnumerable<int> BlackListIter()
		{
			PhotoCollection.<BlackListIter>d__21 <BlackListIter>d__ = new PhotoCollection.<BlackListIter>d__21(-2);
			<BlackListIter>d__.<>3__<>4__this = this;
			return <BlackListIter>d__;
		}

		// Token: 0x0600B165 RID: 45413 RVA: 0x002D601E File Offset: 0x002D421E
		[NullableContext(1)]
		public int[] WhiteList()
		{
			return this.GetWhiteListArray();
		}

		// Token: 0x0600B166 RID: 45414 RVA: 0x002D6026 File Offset: 0x002D4226
		[NullableContext(1)]
		public IEnumerable<int> WhiteListIter()
		{
			PhotoCollection.<WhiteListIter>d__23 <WhiteListIter>d__ = new PhotoCollection.<WhiteListIter>d__23(-2);
			<WhiteListIter>d__.<>3__<>4__this = this;
			return <WhiteListIter>d__;
		}

		// Token: 0x040055B2 RID: 21938
		private Table __p;
	}
}
