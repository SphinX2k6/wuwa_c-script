using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EE7 RID: 3815
	public struct MatchThreeRole : IFlatbufferObject
	{
		// Token: 0x17001F17 RID: 7959
		// (get) Token: 0x0600992F RID: 39215 RVA: 0x002A0FCB File Offset: 0x0029F1CB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009930 RID: 39216 RVA: 0x002A0FD8 File Offset: 0x0029F1D8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009931 RID: 39217 RVA: 0x002A0FE0 File Offset: 0x0029F1E0
		public static MatchThreeRole GetRootAsMatchThreeRole(ByteBuffer _bb)
		{
			return MatchThreeRole.GetRootAsMatchThreeRole(_bb, default(MatchThreeRole));
		}

		// Token: 0x06009932 RID: 39218 RVA: 0x002A0FFC File Offset: 0x0029F1FC
		public static MatchThreeRole GetRootAsMatchThreeRole(ByteBuffer _bb, MatchThreeRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009933 RID: 39219 RVA: 0x002A1019 File Offset: 0x0029F219
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009934 RID: 39220 RVA: 0x002A1028 File Offset: 0x0029F228
		public MatchThreeRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001F18 RID: 7960
		// (get) Token: 0x06009935 RID: 39221 RVA: 0x002A1038 File Offset: 0x0029F238
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

		// Token: 0x17001F19 RID: 7961
		// (get) Token: 0x06009936 RID: 39222 RVA: 0x002A1074 File Offset: 0x0029F274
		public int PreLevel
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

		// Token: 0x06009937 RID: 39223 RVA: 0x002A10B0 File Offset: 0x0029F2B0
		public int Skills(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001F1A RID: 7962
		// (get) Token: 0x06009938 RID: 39224 RVA: 0x002A10F0 File Offset: 0x0029F2F0
		public int SkillsLength
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

		// Token: 0x06009939 RID: 39225 RVA: 0x002A111B File Offset: 0x0029F31B
		public Span<int> GetSkillsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600993A RID: 39226 RVA: 0x002A112A File Offset: 0x0029F32A
		public int[] GetSkillsArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17001F1B RID: 7963
		// (get) Token: 0x0600993B RID: 39227 RVA: 0x002A1144 File Offset: 0x0029F344
		public int SpecialTile
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001F1C RID: 7964
		// (get) Token: 0x0600993C RID: 39228 RVA: 0x002A1184 File Offset: 0x0029F384
		public string Name
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

		// Token: 0x0600993D RID: 39229 RVA: 0x002A11BC File Offset: 0x0029F3BC
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600993E RID: 39230 RVA: 0x002A11CC File Offset: 0x0029F3CC
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001F1D RID: 7965
		// (get) Token: 0x0600993F RID: 39231 RVA: 0x002A11E4 File Offset: 0x0029F3E4
		public string SpineAtlasPath
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

		// Token: 0x06009940 RID: 39232 RVA: 0x002A121C File Offset: 0x0029F41C
		public Span<byte> GetSpineAtlasPathBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06009941 RID: 39233 RVA: 0x002A122C File Offset: 0x0029F42C
		public byte[] GetSpineAtlasPathArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001F1E RID: 7966
		// (get) Token: 0x06009942 RID: 39234 RVA: 0x002A1244 File Offset: 0x0029F444
		public string SpineSkeletonDataPath
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

		// Token: 0x06009943 RID: 39235 RVA: 0x002A127C File Offset: 0x0029F47C
		public Span<byte> GetSpineSkeletonDataPathBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06009944 RID: 39236 RVA: 0x002A128C File Offset: 0x0029F48C
		public byte[] GetSpineSkeletonDataPathArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17001F1F RID: 7967
		// (get) Token: 0x06009945 RID: 39237 RVA: 0x002A12A4 File Offset: 0x0029F4A4
		public string RoleIcon
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

		// Token: 0x06009946 RID: 39238 RVA: 0x002A12DC File Offset: 0x0029F4DC
		public Span<byte> GetRoleIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06009947 RID: 39239 RVA: 0x002A12EC File Offset: 0x0029F4EC
		public byte[] GetRoleIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17001F20 RID: 7968
		// (get) Token: 0x06009948 RID: 39240 RVA: 0x002A1304 File Offset: 0x0029F504
		public string RoleSelIcon
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

		// Token: 0x06009949 RID: 39241 RVA: 0x002A133C File Offset: 0x0029F53C
		public Span<byte> GetRoleSelIconBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600994A RID: 39242 RVA: 0x002A134C File Offset: 0x0029F54C
		public byte[] GetRoleSelIconArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x0600994B RID: 39243 RVA: 0x002A1364 File Offset: 0x0029F564
		[NullableContext(1)]
		public int[] Skills()
		{
			return this.GetSkillsArray();
		}

		// Token: 0x0600994C RID: 39244 RVA: 0x002A136C File Offset: 0x0029F56C
		[NullableContext(1)]
		public IEnumerable<int> SkillsIter()
		{
			MatchThreeRole.<SkillsIter>d__40 <SkillsIter>d__ = new MatchThreeRole.<SkillsIter>d__40(-2);
			<SkillsIter>d__.<>3__<>4__this = this;
			return <SkillsIter>d__;
		}

		// Token: 0x04005488 RID: 21640
		private Table __p;
	}
}
