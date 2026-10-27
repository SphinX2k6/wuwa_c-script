using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EA5 RID: 3749
	public struct OpenAndCloseViewHotKey : IFlatbufferObject
	{
		// Token: 0x1700242F RID: 9263
		// (get) Token: 0x0600A19F RID: 41375 RVA: 0x002A3420 File Offset: 0x002A1620
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A1A0 RID: 41376 RVA: 0x002A342D File Offset: 0x002A162D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A1A1 RID: 41377 RVA: 0x002A3434 File Offset: 0x002A1634
		public static OpenAndCloseViewHotKey GetRootAsOpenAndCloseViewHotKey(ByteBuffer _bb)
		{
			return OpenAndCloseViewHotKey.GetRootAsOpenAndCloseViewHotKey(_bb, default(OpenAndCloseViewHotKey));
		}

		// Token: 0x0600A1A2 RID: 41378 RVA: 0x002A3450 File Offset: 0x002A1650
		public static OpenAndCloseViewHotKey GetRootAsOpenAndCloseViewHotKey(ByteBuffer _bb, OpenAndCloseViewHotKey obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A1A3 RID: 41379 RVA: 0x002A346D File Offset: 0x002A166D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A1A4 RID: 41380 RVA: 0x002A347C File Offset: 0x002A167C
		public OpenAndCloseViewHotKey __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002430 RID: 9264
		// (get) Token: 0x0600A1A5 RID: 41381 RVA: 0x002A348C File Offset: 0x002A168C
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

		// Token: 0x17002431 RID: 9265
		// (get) Token: 0x0600A1A6 RID: 41382 RVA: 0x002A34C8 File Offset: 0x002A16C8
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

		// Token: 0x0600A1A7 RID: 41383 RVA: 0x002A34FF File Offset: 0x002A16FF
		public Span<byte> GetActionNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A1A8 RID: 41384 RVA: 0x002A350E File Offset: 0x002A170E
		public byte[] GetActionNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002432 RID: 9266
		// (get) Token: 0x0600A1A9 RID: 41385 RVA: 0x002A3528 File Offset: 0x002A1728
		public int InputControllerType
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

		// Token: 0x17002433 RID: 9267
		// (get) Token: 0x0600A1AA RID: 41386 RVA: 0x002A3564 File Offset: 0x002A1764
		public string ViewName
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

		// Token: 0x0600A1AB RID: 41387 RVA: 0x002A359C File Offset: 0x002A179C
		public Span<byte> GetViewNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600A1AC RID: 41388 RVA: 0x002A35AC File Offset: 0x002A17AC
		public byte[] GetViewNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A1AD RID: 41389 RVA: 0x002A35C4 File Offset: 0x002A17C4
		public int EffectiveTypeList(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002434 RID: 9268
		// (get) Token: 0x0600A1AE RID: 41390 RVA: 0x002A3604 File Offset: 0x002A1804
		public int EffectiveTypeListLength
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

		// Token: 0x0600A1AF RID: 41391 RVA: 0x002A3630 File Offset: 0x002A1830
		public Span<int> GetEffectiveTypeListBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600A1B0 RID: 41392 RVA: 0x002A3640 File Offset: 0x002A1840
		public int[] GetEffectiveTypeListArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17002435 RID: 9269
		// (get) Token: 0x0600A1B1 RID: 41393 RVA: 0x002A3658 File Offset: 0x002A1858
		public string HandleType
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

		// Token: 0x0600A1B2 RID: 41394 RVA: 0x002A3690 File Offset: 0x002A1890
		public Span<byte> GetHandleTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600A1B3 RID: 41395 RVA: 0x002A36A0 File Offset: 0x002A18A0
		public byte[] GetHandleTypeArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002436 RID: 9270
		// (get) Token: 0x0600A1B4 RID: 41396 RVA: 0x002A36B8 File Offset: 0x002A18B8
		public bool IsPressTrigger
		{
			get
			{
				int num = this.__p.__offset(16);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002437 RID: 9271
		// (get) Token: 0x0600A1B5 RID: 41397 RVA: 0x002A36F8 File Offset: 0x002A18F8
		public int PressStartTime
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

		// Token: 0x17002438 RID: 9272
		// (get) Token: 0x0600A1B6 RID: 41398 RVA: 0x002A3738 File Offset: 0x002A1938
		public int PressTriggerTime
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002439 RID: 9273
		// (get) Token: 0x0600A1B7 RID: 41399 RVA: 0x002A3778 File Offset: 0x002A1978
		public bool IsReleaseTrigger
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700243A RID: 9274
		// (get) Token: 0x0600A1B8 RID: 41400 RVA: 0x002A37B8 File Offset: 0x002A19B8
		public int ReleaseInvalidTime
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700243B RID: 9275
		// (get) Token: 0x0600A1B9 RID: 41401 RVA: 0x002A37F8 File Offset: 0x002A19F8
		public bool IsPressClose
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700243C RID: 9276
		// (get) Token: 0x0600A1BA RID: 41402 RVA: 0x002A3838 File Offset: 0x002A1A38
		public bool IsReleaseClose
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600A1BB RID: 41403 RVA: 0x002A3878 File Offset: 0x002A1A78
		public string ViewParam(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700243D RID: 9277
		// (get) Token: 0x0600A1BC RID: 41404 RVA: 0x002A38B4 File Offset: 0x002A1AB4
		public int ViewParamLength
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A1BD RID: 41405 RVA: 0x002A38E0 File Offset: 0x002A1AE0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EffectiveTypeListIter()或GetEffectiveTypeListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] EffectiveTypeList()
		{
			OpenAndCloseViewHotKey openAndCloseViewHotKey = this;
			return openAndCloseViewHotKey.GetEffectiveTypeListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600A1BE RID: 41406 RVA: 0x002A3904 File Offset: 0x002A1B04
		[NullableContext(1)]
		public readonly IEnumerable<int> EffectiveTypeListIter()
		{
			OpenAndCloseViewHotKey.<EffectiveTypeListIter>d__47 <EffectiveTypeListIter>d__ = new OpenAndCloseViewHotKey.<EffectiveTypeListIter>d__47(-2);
			<EffectiveTypeListIter>d__.<>3__<>4__this = this;
			return <EffectiveTypeListIter>d__;
		}

		// Token: 0x0600A1BF RID: 41407 RVA: 0x002A3919 File Offset: 0x002A1B19
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ViewParamIter()或GetViewParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] ViewParam()
		{
			return this.ViewParamIter().ToArray<string>();
		}

		// Token: 0x0600A1C0 RID: 41408 RVA: 0x002A3926 File Offset: 0x002A1B26
		[NullableContext(1)]
		public readonly IEnumerable<string> ViewParamIter()
		{
			OpenAndCloseViewHotKey.<ViewParamIter>d__49 <ViewParamIter>d__ = new OpenAndCloseViewHotKey.<ViewParamIter>d__49(-2);
			<ViewParamIter>d__.<>3__<>4__this = this;
			return <ViewParamIter>d__;
		}

		// Token: 0x04004F59 RID: 20313
		private Table __p;
	}
}
