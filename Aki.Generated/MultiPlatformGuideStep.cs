using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E76 RID: 3702
	public struct MultiPlatformGuideStep : IFlatbufferObject
	{
		// Token: 0x170022B4 RID: 8884
		// (get) Token: 0x06009D95 RID: 40341 RVA: 0x0029A797 File Offset: 0x00298997
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009D96 RID: 40342 RVA: 0x0029A7A4 File Offset: 0x002989A4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009D97 RID: 40343 RVA: 0x0029A7AC File Offset: 0x002989AC
		public static MultiPlatformGuideStep GetRootAsMultiPlatformGuideStep(ByteBuffer _bb)
		{
			return MultiPlatformGuideStep.GetRootAsMultiPlatformGuideStep(_bb, default(MultiPlatformGuideStep));
		}

		// Token: 0x06009D98 RID: 40344 RVA: 0x0029A7C8 File Offset: 0x002989C8
		public static MultiPlatformGuideStep GetRootAsMultiPlatformGuideStep(ByteBuffer _bb, MultiPlatformGuideStep obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009D99 RID: 40345 RVA: 0x0029A7E5 File Offset: 0x002989E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009D9A RID: 40346 RVA: 0x0029A7F4 File Offset: 0x002989F4
		public MultiPlatformGuideStep __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170022B5 RID: 8885
		// (get) Token: 0x06009D9B RID: 40347 RVA: 0x0029A804 File Offset: 0x00298A04
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

		// Token: 0x06009D9C RID: 40348 RVA: 0x0029A840 File Offset: 0x00298A40
		public int KeyboardStepId(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170022B6 RID: 8886
		// (get) Token: 0x06009D9D RID: 40349 RVA: 0x0029A880 File Offset: 0x00298A80
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

		// Token: 0x06009D9E RID: 40350 RVA: 0x0029A8AB File Offset: 0x00298AAB
		public Span<int> GetKeyboardStepIdBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06009D9F RID: 40351 RVA: 0x0029A8BA File Offset: 0x00298ABA
		public int[] GetKeyboardStepIdArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x06009DA0 RID: 40352 RVA: 0x0029A8D4 File Offset: 0x00298AD4
		public int GamepadStepId(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170022B7 RID: 8887
		// (get) Token: 0x06009DA1 RID: 40353 RVA: 0x0029A914 File Offset: 0x00298B14
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

		// Token: 0x06009DA2 RID: 40354 RVA: 0x0029A93F File Offset: 0x00298B3F
		public Span<int> GetGamepadStepIdBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06009DA3 RID: 40355 RVA: 0x0029A94E File Offset: 0x00298B4E
		public int[] GetGamepadStepIdArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x06009DA4 RID: 40356 RVA: 0x0029A968 File Offset: 0x00298B68
		public int MobileStepId(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170022B8 RID: 8888
		// (get) Token: 0x06009DA5 RID: 40357 RVA: 0x0029A9A8 File Offset: 0x00298BA8
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

		// Token: 0x06009DA6 RID: 40358 RVA: 0x0029A9D4 File Offset: 0x00298BD4
		public Span<int> GetMobileStepIdBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06009DA7 RID: 40359 RVA: 0x0029A9E4 File Offset: 0x00298BE4
		public int[] GetMobileStepIdArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x06009DA8 RID: 40360 RVA: 0x0029A9FC File Offset: 0x00298BFC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用GamepadStepIdIter()或GetGamepadStepIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] GamepadStepId()
		{
			MultiPlatformGuideStep multiPlatformGuideStep = this;
			return multiPlatformGuideStep.GetGamepadStepIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009DA9 RID: 40361 RVA: 0x0029AA20 File Offset: 0x00298C20
		[NullableContext(1)]
		public readonly IEnumerable<int> GamepadStepIdIter()
		{
			MultiPlatformGuideStep.<GamepadStepIdIter>d__26 <GamepadStepIdIter>d__ = new MultiPlatformGuideStep.<GamepadStepIdIter>d__26(-2);
			<GamepadStepIdIter>d__.<>3__<>4__this = this;
			return <GamepadStepIdIter>d__;
		}

		// Token: 0x06009DAA RID: 40362 RVA: 0x0029AA38 File Offset: 0x00298C38
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用KeyboardStepIdIter()或GetKeyboardStepIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] KeyboardStepId()
		{
			MultiPlatformGuideStep multiPlatformGuideStep = this;
			return multiPlatformGuideStep.GetKeyboardStepIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009DAB RID: 40363 RVA: 0x0029AA5C File Offset: 0x00298C5C
		[NullableContext(1)]
		public readonly IEnumerable<int> KeyboardStepIdIter()
		{
			MultiPlatformGuideStep.<KeyboardStepIdIter>d__28 <KeyboardStepIdIter>d__ = new MultiPlatformGuideStep.<KeyboardStepIdIter>d__28(-2);
			<KeyboardStepIdIter>d__.<>3__<>4__this = this;
			return <KeyboardStepIdIter>d__;
		}

		// Token: 0x06009DAC RID: 40364 RVA: 0x0029AA74 File Offset: 0x00298C74
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MobileStepIdIter()或GetMobileStepIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] MobileStepId()
		{
			MultiPlatformGuideStep multiPlatformGuideStep = this;
			return multiPlatformGuideStep.GetMobileStepIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009DAD RID: 40365 RVA: 0x0029AA98 File Offset: 0x00298C98
		[NullableContext(1)]
		public readonly IEnumerable<int> MobileStepIdIter()
		{
			MultiPlatformGuideStep.<MobileStepIdIter>d__30 <MobileStepIdIter>d__ = new MultiPlatformGuideStep.<MobileStepIdIter>d__30(-2);
			<MobileStepIdIter>d__.<>3__<>4__this = this;
			return <MobileStepIdIter>d__;
		}

		// Token: 0x04004F24 RID: 20260
		private Table __p;
	}
}
