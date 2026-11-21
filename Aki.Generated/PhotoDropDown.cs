using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FEB RID: 4075
	public struct PhotoDropDown : IFlatbufferObject
	{
		// Token: 0x17002817 RID: 10263
		// (get) Token: 0x0600B167 RID: 45415 RVA: 0x002D603B File Offset: 0x002D423B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B168 RID: 45416 RVA: 0x002D6048 File Offset: 0x002D4248
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B169 RID: 45417 RVA: 0x002D6050 File Offset: 0x002D4250
		public static PhotoDropDown GetRootAsPhotoDropDown(ByteBuffer _bb)
		{
			return PhotoDropDown.GetRootAsPhotoDropDown(_bb, default(PhotoDropDown));
		}

		// Token: 0x0600B16A RID: 45418 RVA: 0x002D606C File Offset: 0x002D426C
		public static PhotoDropDown GetRootAsPhotoDropDown(ByteBuffer _bb, PhotoDropDown obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B16B RID: 45419 RVA: 0x002D6089 File Offset: 0x002D4289
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B16C RID: 45420 RVA: 0x002D6098 File Offset: 0x002D4298
		public PhotoDropDown __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002818 RID: 10264
		// (get) Token: 0x0600B16D RID: 45421 RVA: 0x002D60A8 File Offset: 0x002D42A8
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

		// Token: 0x17002819 RID: 10265
		// (get) Token: 0x0600B16E RID: 45422 RVA: 0x002D60E4 File Offset: 0x002D42E4
		public int SetupType
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

		// Token: 0x1700281A RID: 10266
		// (get) Token: 0x0600B16F RID: 45423 RVA: 0x002D6120 File Offset: 0x002D4320
		public string TextId
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

		// Token: 0x0600B170 RID: 45424 RVA: 0x002D6157 File Offset: 0x002D4357
		public Span<byte> GetTextIdBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B171 RID: 45425 RVA: 0x002D6166 File Offset: 0x002D4366
		public byte[] GetTextIdArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700281B RID: 10267
		// (get) Token: 0x0600B172 RID: 45426 RVA: 0x002D6180 File Offset: 0x002D4380
		public bool IsShowInLowDevice
		{
			get
			{
				int num = this.__p.__offset(10);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600B173 RID: 45427 RVA: 0x002D61C0 File Offset: 0x002D43C0
		public string Param(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700281C RID: 10268
		// (get) Token: 0x0600B174 RID: 45428 RVA: 0x002D61FC File Offset: 0x002D43FC
		public int ParamLength
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

		// Token: 0x0600B175 RID: 45429 RVA: 0x002D6228 File Offset: 0x002D4428
		[NullableContext(1)]
		public string[] Param()
		{
			return this.ParamIter().ToArray<string>();
		}

		// Token: 0x0600B176 RID: 45430 RVA: 0x002D6235 File Offset: 0x002D4435
		[NullableContext(1)]
		public IEnumerable<string> ParamIter()
		{
			PhotoDropDown.<ParamIter>d__22 <ParamIter>d__ = new PhotoDropDown.<ParamIter>d__22(-2);
			<ParamIter>d__.<>3__<>4__this = this;
			return <ParamIter>d__;
		}

		// Token: 0x040055B3 RID: 21939
		private Table __p;
	}
}
