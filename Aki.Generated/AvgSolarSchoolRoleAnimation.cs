using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BF2 RID: 3058
	public struct AvgSolarSchoolRoleAnimation : IFlatbufferObject
	{
		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06004F63 RID: 20323 RVA: 0x001FA8E4 File Offset: 0x001F8AE4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004F64 RID: 20324 RVA: 0x001FA8F1 File Offset: 0x001F8AF1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004F65 RID: 20325 RVA: 0x001FA8F8 File Offset: 0x001F8AF8
		public static AvgSolarSchoolRoleAnimation GetRootAsAvgSolarSchoolRoleAnimation(ByteBuffer _bb)
		{
			return AvgSolarSchoolRoleAnimation.GetRootAsAvgSolarSchoolRoleAnimation(_bb, default(AvgSolarSchoolRoleAnimation));
		}

		// Token: 0x06004F66 RID: 20326 RVA: 0x001FA914 File Offset: 0x001F8B14
		public static AvgSolarSchoolRoleAnimation GetRootAsAvgSolarSchoolRoleAnimation(ByteBuffer _bb, AvgSolarSchoolRoleAnimation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004F67 RID: 20327 RVA: 0x001FA931 File Offset: 0x001F8B31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004F68 RID: 20328 RVA: 0x001FA940 File Offset: 0x001F8B40
		public AvgSolarSchoolRoleAnimation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06004F69 RID: 20329 RVA: 0x001FA950 File Offset: 0x001F8B50
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

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06004F6A RID: 20330 RVA: 0x001FA98C File Offset: 0x001F8B8C
		public int AvgTalkerId
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

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06004F6B RID: 20331 RVA: 0x001FA9C8 File Offset: 0x001F8BC8
		public string AnimationName
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

		// Token: 0x06004F6C RID: 20332 RVA: 0x001FA9FF File Offset: 0x001F8BFF
		public Span<byte> GetAnimationNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004F6D RID: 20333 RVA: 0x001FAA0E File Offset: 0x001F8C0E
		public byte[] GetAnimationNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06004F6E RID: 20334 RVA: 0x001FAA28 File Offset: 0x001F8C28
		public string BodyAnimation
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

		// Token: 0x06004F6F RID: 20335 RVA: 0x001FAA60 File Offset: 0x001F8C60
		public Span<byte> GetBodyAnimationBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004F70 RID: 20336 RVA: 0x001FAA70 File Offset: 0x001F8C70
		public byte[] GetBodyAnimationArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06004F71 RID: 20337 RVA: 0x001FAA88 File Offset: 0x001F8C88
		public string MouthAnimation
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

		// Token: 0x06004F72 RID: 20338 RVA: 0x001FAAC0 File Offset: 0x001F8CC0
		public Span<byte> GetMouthAnimationBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06004F73 RID: 20339 RVA: 0x001FAAD0 File Offset: 0x001F8CD0
		public byte[] GetMouthAnimationArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06004F74 RID: 20340 RVA: 0x001FAAE8 File Offset: 0x001F8CE8
		public string MouthOpenSmallAnimation
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

		// Token: 0x06004F75 RID: 20341 RVA: 0x001FAB20 File Offset: 0x001F8D20
		public Span<byte> GetMouthOpenSmallAnimationBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06004F76 RID: 20342 RVA: 0x001FAB30 File Offset: 0x001F8D30
		public byte[] GetMouthOpenSmallAnimationArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06004F77 RID: 20343 RVA: 0x001FAB48 File Offset: 0x001F8D48
		public string MouthOpenLargeAnimation
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

		// Token: 0x06004F78 RID: 20344 RVA: 0x001FAB80 File Offset: 0x001F8D80
		public Span<byte> GetMouthOpenLargeAnimationBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06004F79 RID: 20345 RVA: 0x001FAB90 File Offset: 0x001F8D90
		public byte[] GetMouthOpenLargeAnimationArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06004F7A RID: 20346 RVA: 0x001FABA8 File Offset: 0x001F8DA8
		public string EyeAnimation
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

		// Token: 0x06004F7B RID: 20347 RVA: 0x001FABE0 File Offset: 0x001F8DE0
		public Span<byte> GetEyeAnimationBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06004F7C RID: 20348 RVA: 0x001FABF0 File Offset: 0x001F8DF0
		public byte[] GetEyeAnimationArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06004F7D RID: 20349 RVA: 0x001FAC08 File Offset: 0x001F8E08
		public string BlinkAnimation
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

		// Token: 0x06004F7E RID: 20350 RVA: 0x001FAC40 File Offset: 0x001F8E40
		public Span<byte> GetBlinkAnimationBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06004F7F RID: 20351 RVA: 0x001FAC50 File Offset: 0x001F8E50
		public byte[] GetBlinkAnimationArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x040050DA RID: 20698
		private Table __p;
	}
}
