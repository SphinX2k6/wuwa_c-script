using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F8A RID: 3978
	public struct OpenAndCloseViewHotKey : IFlatbufferObject
	{
		// Token: 0x17002494 RID: 9364
		// (get) Token: 0x0600A7BF RID: 42943 RVA: 0x002C08A8 File Offset: 0x002BEAA8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A7C0 RID: 42944 RVA: 0x002C08B5 File Offset: 0x002BEAB5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A7C1 RID: 42945 RVA: 0x002C08BC File Offset: 0x002BEABC
		public static OpenAndCloseViewHotKey GetRootAsOpenAndCloseViewHotKey(ByteBuffer _bb)
		{
			return OpenAndCloseViewHotKey.GetRootAsOpenAndCloseViewHotKey(_bb, default(OpenAndCloseViewHotKey));
		}

		// Token: 0x0600A7C2 RID: 42946 RVA: 0x002C08D8 File Offset: 0x002BEAD8
		public static OpenAndCloseViewHotKey GetRootAsOpenAndCloseViewHotKey(ByteBuffer _bb, OpenAndCloseViewHotKey obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A7C3 RID: 42947 RVA: 0x002C08F5 File Offset: 0x002BEAF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A7C4 RID: 42948 RVA: 0x002C0904 File Offset: 0x002BEB04
		public OpenAndCloseViewHotKey __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002495 RID: 9365
		// (get) Token: 0x0600A7C5 RID: 42949 RVA: 0x002C0914 File Offset: 0x002BEB14
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

		// Token: 0x17002496 RID: 9366
		// (get) Token: 0x0600A7C6 RID: 42950 RVA: 0x002C0950 File Offset: 0x002BEB50
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

		// Token: 0x0600A7C7 RID: 42951 RVA: 0x002C0987 File Offset: 0x002BEB87
		public Span<byte> GetActionNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A7C8 RID: 42952 RVA: 0x002C0996 File Offset: 0x002BEB96
		public byte[] GetActionNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002497 RID: 9367
		// (get) Token: 0x0600A7C9 RID: 42953 RVA: 0x002C09B0 File Offset: 0x002BEBB0
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

		// Token: 0x17002498 RID: 9368
		// (get) Token: 0x0600A7CA RID: 42954 RVA: 0x002C09EC File Offset: 0x002BEBEC
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

		// Token: 0x0600A7CB RID: 42955 RVA: 0x002C0A24 File Offset: 0x002BEC24
		public Span<byte> GetViewNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600A7CC RID: 42956 RVA: 0x002C0A34 File Offset: 0x002BEC34
		public byte[] GetViewNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A7CD RID: 42957 RVA: 0x002C0A4C File Offset: 0x002BEC4C
		public int EffectiveTypeList(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002499 RID: 9369
		// (get) Token: 0x0600A7CE RID: 42958 RVA: 0x002C0A8C File Offset: 0x002BEC8C
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

		// Token: 0x0600A7CF RID: 42959 RVA: 0x002C0AB8 File Offset: 0x002BECB8
		public Span<int> GetEffectiveTypeListBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600A7D0 RID: 42960 RVA: 0x002C0AC8 File Offset: 0x002BECC8
		public int[] GetEffectiveTypeListArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x1700249A RID: 9370
		// (get) Token: 0x0600A7D1 RID: 42961 RVA: 0x002C0AE0 File Offset: 0x002BECE0
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

		// Token: 0x0600A7D2 RID: 42962 RVA: 0x002C0B18 File Offset: 0x002BED18
		public Span<byte> GetHandleTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600A7D3 RID: 42963 RVA: 0x002C0B28 File Offset: 0x002BED28
		public byte[] GetHandleTypeArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700249B RID: 9371
		// (get) Token: 0x0600A7D4 RID: 42964 RVA: 0x002C0B40 File Offset: 0x002BED40
		public bool IsPressTrigger
		{
			get
			{
				int num = this.__p.__offset(16);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700249C RID: 9372
		// (get) Token: 0x0600A7D5 RID: 42965 RVA: 0x002C0B80 File Offset: 0x002BED80
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

		// Token: 0x1700249D RID: 9373
		// (get) Token: 0x0600A7D6 RID: 42966 RVA: 0x002C0BC0 File Offset: 0x002BEDC0
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

		// Token: 0x1700249E RID: 9374
		// (get) Token: 0x0600A7D7 RID: 42967 RVA: 0x002C0C00 File Offset: 0x002BEE00
		public bool IsReleaseTrigger
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700249F RID: 9375
		// (get) Token: 0x0600A7D8 RID: 42968 RVA: 0x002C0C40 File Offset: 0x002BEE40
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

		// Token: 0x170024A0 RID: 9376
		// (get) Token: 0x0600A7D9 RID: 42969 RVA: 0x002C0C80 File Offset: 0x002BEE80
		public bool IsPressClose
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170024A1 RID: 9377
		// (get) Token: 0x0600A7DA RID: 42970 RVA: 0x002C0CC0 File Offset: 0x002BEEC0
		public bool IsReleaseClose
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600A7DB RID: 42971 RVA: 0x002C0D00 File Offset: 0x002BEF00
		public string ViewParam(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170024A2 RID: 9378
		// (get) Token: 0x0600A7DC RID: 42972 RVA: 0x002C0D3C File Offset: 0x002BEF3C
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

		// Token: 0x0600A7DD RID: 42973 RVA: 0x002C0D68 File Offset: 0x002BEF68
		[NullableContext(1)]
		public int[] EffectiveTypeList()
		{
			return this.GetEffectiveTypeListArray();
		}

		// Token: 0x0600A7DE RID: 42974 RVA: 0x002C0D70 File Offset: 0x002BEF70
		[NullableContext(1)]
		public IEnumerable<int> EffectiveTypeListIter()
		{
			OpenAndCloseViewHotKey.<EffectiveTypeListIter>d__47 <EffectiveTypeListIter>d__ = new OpenAndCloseViewHotKey.<EffectiveTypeListIter>d__47(-2);
			<EffectiveTypeListIter>d__.<>3__<>4__this = this;
			return <EffectiveTypeListIter>d__;
		}

		// Token: 0x0600A7DF RID: 42975 RVA: 0x002C0D85 File Offset: 0x002BEF85
		[NullableContext(1)]
		public string[] ViewParam()
		{
			return this.ViewParamIter().ToArray<string>();
		}

		// Token: 0x0600A7E0 RID: 42976 RVA: 0x002C0D92 File Offset: 0x002BEF92
		[NullableContext(1)]
		public IEnumerable<string> ViewParamIter()
		{
			OpenAndCloseViewHotKey.<ViewParamIter>d__49 <ViewParamIter>d__ = new OpenAndCloseViewHotKey.<ViewParamIter>d__49(-2);
			<ViewParamIter>d__.<>3__<>4__this = this;
			return <ViewParamIter>d__;
		}

		// Token: 0x0400553E RID: 21822
		private Table __p;
	}
}
