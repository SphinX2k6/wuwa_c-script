using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F5B RID: 3931
	public struct MultiPlatformGuideStep : IFlatbufferObject
	{
		// Token: 0x17002319 RID: 8985
		// (get) Token: 0x0600A3B5 RID: 41909 RVA: 0x002B7F24 File Offset: 0x002B6124
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A3B6 RID: 41910 RVA: 0x002B7F31 File Offset: 0x002B6131
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A3B7 RID: 41911 RVA: 0x002B7F38 File Offset: 0x002B6138
		public static MultiPlatformGuideStep GetRootAsMultiPlatformGuideStep(ByteBuffer _bb)
		{
			return MultiPlatformGuideStep.GetRootAsMultiPlatformGuideStep(_bb, default(MultiPlatformGuideStep));
		}

		// Token: 0x0600A3B8 RID: 41912 RVA: 0x002B7F54 File Offset: 0x002B6154
		public static MultiPlatformGuideStep GetRootAsMultiPlatformGuideStep(ByteBuffer _bb, MultiPlatformGuideStep obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A3B9 RID: 41913 RVA: 0x002B7F71 File Offset: 0x002B6171
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A3BA RID: 41914 RVA: 0x002B7F80 File Offset: 0x002B6180
		public MultiPlatformGuideStep __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700231A RID: 8986
		// (get) Token: 0x0600A3BB RID: 41915 RVA: 0x002B7F90 File Offset: 0x002B6190
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

		// Token: 0x0600A3BC RID: 41916 RVA: 0x002B7FCC File Offset: 0x002B61CC
		public int KeyboardStepId(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700231B RID: 8987
		// (get) Token: 0x0600A3BD RID: 41917 RVA: 0x002B800C File Offset: 0x002B620C
		public int KeyboardStepIdLength
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

		// Token: 0x0600A3BE RID: 41918 RVA: 0x002B8037 File Offset: 0x002B6237
		public Span<int> GetKeyboardStepIdBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600A3BF RID: 41919 RVA: 0x002B8046 File Offset: 0x002B6246
		public int[] GetKeyboardStepIdArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600A3C0 RID: 41920 RVA: 0x002B8060 File Offset: 0x002B6260
		public int GamepadStepId(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700231C RID: 8988
		// (get) Token: 0x0600A3C1 RID: 41921 RVA: 0x002B80A0 File Offset: 0x002B62A0
		public int GamepadStepIdLength
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

		// Token: 0x0600A3C2 RID: 41922 RVA: 0x002B80CB File Offset: 0x002B62CB
		public Span<int> GetGamepadStepIdBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600A3C3 RID: 41923 RVA: 0x002B80DA File Offset: 0x002B62DA
		public int[] GetGamepadStepIdArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600A3C4 RID: 41924 RVA: 0x002B80F4 File Offset: 0x002B62F4
		public int MobileStepId(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700231D RID: 8989
		// (get) Token: 0x0600A3C5 RID: 41925 RVA: 0x002B8134 File Offset: 0x002B6334
		public int MobileStepIdLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A3C6 RID: 41926 RVA: 0x002B8160 File Offset: 0x002B6360
		public Span<int> GetMobileStepIdBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600A3C7 RID: 41927 RVA: 0x002B8170 File Offset: 0x002B6370
		public int[] GetMobileStepIdArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x0600A3C8 RID: 41928 RVA: 0x002B8188 File Offset: 0x002B6388
		[NullableContext(1)]
		public int[] GamepadStepId()
		{
			return this.GetGamepadStepIdArray();
		}

		// Token: 0x0600A3C9 RID: 41929 RVA: 0x002B8190 File Offset: 0x002B6390
		[NullableContext(1)]
		public IEnumerable<int> GamepadStepIdIter()
		{
			MultiPlatformGuideStep.<GamepadStepIdIter>d__26 <GamepadStepIdIter>d__ = new MultiPlatformGuideStep.<GamepadStepIdIter>d__26(-2);
			<GamepadStepIdIter>d__.<>3__<>4__this = this;
			return <GamepadStepIdIter>d__;
		}

		// Token: 0x0600A3CA RID: 41930 RVA: 0x002B81A5 File Offset: 0x002B63A5
		[NullableContext(1)]
		public int[] KeyboardStepId()
		{
			return this.GetKeyboardStepIdArray();
		}

		// Token: 0x0600A3CB RID: 41931 RVA: 0x002B81AD File Offset: 0x002B63AD
		[NullableContext(1)]
		public IEnumerable<int> KeyboardStepIdIter()
		{
			MultiPlatformGuideStep.<KeyboardStepIdIter>d__28 <KeyboardStepIdIter>d__ = new MultiPlatformGuideStep.<KeyboardStepIdIter>d__28(-2);
			<KeyboardStepIdIter>d__.<>3__<>4__this = this;
			return <KeyboardStepIdIter>d__;
		}

		// Token: 0x0600A3CC RID: 41932 RVA: 0x002B81C2 File Offset: 0x002B63C2
		[NullableContext(1)]
		public int[] MobileStepId()
		{
			return this.GetMobileStepIdArray();
		}

		// Token: 0x0600A3CD RID: 41933 RVA: 0x002B81CA File Offset: 0x002B63CA
		[NullableContext(1)]
		public IEnumerable<int> MobileStepIdIter()
		{
			MultiPlatformGuideStep.<MobileStepIdIter>d__30 <MobileStepIdIter>d__ = new MultiPlatformGuideStep.<MobileStepIdIter>d__30(-2);
			<MobileStepIdIter>d__.<>3__<>4__this = this;
			return <MobileStepIdIter>d__;
		}

		// Token: 0x04005509 RID: 21769
		private Table __p;
	}
}
