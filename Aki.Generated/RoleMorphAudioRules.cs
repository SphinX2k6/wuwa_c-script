using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001055 RID: 4181
	public struct RoleMorphAudioRules : IFlatbufferObject
	{
		// Token: 0x170032DF RID: 13023
		// (get) Token: 0x0600C9A8 RID: 51624 RVA: 0x002FD068 File Offset: 0x002FB268
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C9A9 RID: 51625 RVA: 0x002FD075 File Offset: 0x002FB275
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C9AA RID: 51626 RVA: 0x002FD07C File Offset: 0x002FB27C
		public static RoleMorphAudioRules GetRootAsRoleMorphAudioRules(ByteBuffer _bb)
		{
			return RoleMorphAudioRules.GetRootAsRoleMorphAudioRules(_bb, default(RoleMorphAudioRules));
		}

		// Token: 0x0600C9AB RID: 51627 RVA: 0x002FD098 File Offset: 0x002FB298
		public static RoleMorphAudioRules GetRootAsRoleMorphAudioRules(ByteBuffer _bb, RoleMorphAudioRules obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C9AC RID: 51628 RVA: 0x002FD0B5 File Offset: 0x002FB2B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C9AD RID: 51629 RVA: 0x002FD0C4 File Offset: 0x002FB2C4
		public RoleMorphAudioRules __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170032E0 RID: 13024
		// (get) Token: 0x0600C9AE RID: 51630 RVA: 0x002FD0D4 File Offset: 0x002FB2D4
		public int MorphId
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

		// Token: 0x170032E1 RID: 13025
		// (get) Token: 0x0600C9AF RID: 51631 RVA: 0x002FD110 File Offset: 0x002FB310
		public string EnterMorphSwitch
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

		// Token: 0x0600C9B0 RID: 51632 RVA: 0x002FD147 File Offset: 0x002FB347
		public Span<byte> GetEnterMorphSwitchBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600C9B1 RID: 51633 RVA: 0x002FD156 File Offset: 0x002FB356
		public byte[] GetEnterMorphSwitchArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170032E2 RID: 13026
		// (get) Token: 0x0600C9B2 RID: 51634 RVA: 0x002FD170 File Offset: 0x002FB370
		public string ExitMorphEvent
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

		// Token: 0x0600C9B3 RID: 51635 RVA: 0x002FD1A7 File Offset: 0x002FB3A7
		public Span<byte> GetExitMorphEventBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C9B4 RID: 51636 RVA: 0x002FD1B6 File Offset: 0x002FB3B6
		public byte[] GetExitMorphEventArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C9B5 RID: 51637 RVA: 0x002FD1D0 File Offset: 0x002FB3D0
		public int IgnoredTypeList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170032E3 RID: 13027
		// (get) Token: 0x0600C9B6 RID: 51638 RVA: 0x002FD210 File Offset: 0x002FB410
		public int IgnoredTypeListLength
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

		// Token: 0x0600C9B7 RID: 51639 RVA: 0x002FD23C File Offset: 0x002FB43C
		public Span<int> GetIgnoredTypeListBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600C9B8 RID: 51640 RVA: 0x002FD24C File Offset: 0x002FB44C
		public int[] GetIgnoredTypeListArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x0600C9B9 RID: 51641 RVA: 0x002FD264 File Offset: 0x002FB464
		public string IgnoredEventList(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170032E4 RID: 13028
		// (get) Token: 0x0600C9BA RID: 51642 RVA: 0x002FD2A0 File Offset: 0x002FB4A0
		public int IgnoredEventListLength
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

		// Token: 0x0600C9BB RID: 51643 RVA: 0x002FD2CC File Offset: 0x002FB4CC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用IgnoredEventListIter()或GetIgnoredEventListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] IgnoredEventList()
		{
			return this.IgnoredEventListIter().ToArray<string>();
		}

		// Token: 0x0600C9BC RID: 51644 RVA: 0x002FD2D9 File Offset: 0x002FB4D9
		[NullableContext(1)]
		public readonly IEnumerable<string> IgnoredEventListIter()
		{
			RoleMorphAudioRules.<IgnoredEventListIter>d__27 <IgnoredEventListIter>d__ = new RoleMorphAudioRules.<IgnoredEventListIter>d__27(-2);
			<IgnoredEventListIter>d__.<>3__<>4__this = this;
			return <IgnoredEventListIter>d__;
		}

		// Token: 0x0600C9BD RID: 51645 RVA: 0x002FD2F0 File Offset: 0x002FB4F0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用IgnoredTypeListIter()或GetIgnoredTypeListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] IgnoredTypeList()
		{
			RoleMorphAudioRules roleMorphAudioRules = this;
			return roleMorphAudioRules.GetIgnoredTypeListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C9BE RID: 51646 RVA: 0x002FD314 File Offset: 0x002FB514
		[NullableContext(1)]
		public readonly IEnumerable<int> IgnoredTypeListIter()
		{
			RoleMorphAudioRules.<IgnoredTypeListIter>d__29 <IgnoredTypeListIter>d__ = new RoleMorphAudioRules.<IgnoredTypeListIter>d__29(-2);
			<IgnoredTypeListIter>d__.<>3__<>4__this = this;
			return <IgnoredTypeListIter>d__;
		}

		// Token: 0x04005156 RID: 20822
		private Table __p;
	}
}
