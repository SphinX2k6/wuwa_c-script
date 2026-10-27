using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F06 RID: 3846
	public struct PhotoDropDown : IFlatbufferObject
	{
		// Token: 0x170027B1 RID: 10161
		// (get) Token: 0x0600AB46 RID: 43846 RVA: 0x002B9315 File Offset: 0x002B7515
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AB47 RID: 43847 RVA: 0x002B9322 File Offset: 0x002B7522
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AB48 RID: 43848 RVA: 0x002B932C File Offset: 0x002B752C
		public static PhotoDropDown GetRootAsPhotoDropDown(ByteBuffer _bb)
		{
			return PhotoDropDown.GetRootAsPhotoDropDown(_bb, default(PhotoDropDown));
		}

		// Token: 0x0600AB49 RID: 43849 RVA: 0x002B9348 File Offset: 0x002B7548
		public static PhotoDropDown GetRootAsPhotoDropDown(ByteBuffer _bb, PhotoDropDown obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AB4A RID: 43850 RVA: 0x002B9365 File Offset: 0x002B7565
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AB4B RID: 43851 RVA: 0x002B9374 File Offset: 0x002B7574
		public PhotoDropDown __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170027B2 RID: 10162
		// (get) Token: 0x0600AB4C RID: 43852 RVA: 0x002B9384 File Offset: 0x002B7584
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

		// Token: 0x170027B3 RID: 10163
		// (get) Token: 0x0600AB4D RID: 43853 RVA: 0x002B93C0 File Offset: 0x002B75C0
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

		// Token: 0x170027B4 RID: 10164
		// (get) Token: 0x0600AB4E RID: 43854 RVA: 0x002B93FC File Offset: 0x002B75FC
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

		// Token: 0x0600AB4F RID: 43855 RVA: 0x002B9433 File Offset: 0x002B7633
		public Span<byte> GetTextIdBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600AB50 RID: 43856 RVA: 0x002B9442 File Offset: 0x002B7642
		public byte[] GetTextIdArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170027B5 RID: 10165
		// (get) Token: 0x0600AB51 RID: 43857 RVA: 0x002B945C File Offset: 0x002B765C
		public bool IsShowInLowDevice
		{
			get
			{
				int num = this.__p.__offset(10);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600AB52 RID: 43858 RVA: 0x002B949C File Offset: 0x002B769C
		public string Param(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170027B6 RID: 10166
		// (get) Token: 0x0600AB53 RID: 43859 RVA: 0x002B94D8 File Offset: 0x002B76D8
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

		// Token: 0x0600AB54 RID: 43860 RVA: 0x002B9504 File Offset: 0x002B7704
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ParamIter()或GetParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Param()
		{
			return this.ParamIter().ToArray<string>();
		}

		// Token: 0x0600AB55 RID: 43861 RVA: 0x002B9511 File Offset: 0x002B7711
		[NullableContext(1)]
		public readonly IEnumerable<string> ParamIter()
		{
			PhotoDropDown.<ParamIter>d__22 <ParamIter>d__ = new PhotoDropDown.<ParamIter>d__22(-2);
			<ParamIter>d__.<>3__<>4__this = this;
			return <ParamIter>d__;
		}

		// Token: 0x04004FCE RID: 20430
		private Table __p;
	}
}
