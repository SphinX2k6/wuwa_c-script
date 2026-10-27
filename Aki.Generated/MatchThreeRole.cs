using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E02 RID: 3586
	public struct MatchThreeRole : IFlatbufferObject
	{
		// Token: 0x17001EB3 RID: 7859
		// (get) Token: 0x06009313 RID: 37651 RVA: 0x00283101 File Offset: 0x00281301
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009314 RID: 37652 RVA: 0x0028310E File Offset: 0x0028130E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009315 RID: 37653 RVA: 0x00283118 File Offset: 0x00281318
		public static MatchThreeRole GetRootAsMatchThreeRole(ByteBuffer _bb)
		{
			return MatchThreeRole.GetRootAsMatchThreeRole(_bb, default(MatchThreeRole));
		}

		// Token: 0x06009316 RID: 37654 RVA: 0x00283134 File Offset: 0x00281334
		public static MatchThreeRole GetRootAsMatchThreeRole(ByteBuffer _bb, MatchThreeRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009317 RID: 37655 RVA: 0x00283151 File Offset: 0x00281351
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009318 RID: 37656 RVA: 0x00283160 File Offset: 0x00281360
		public MatchThreeRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001EB4 RID: 7860
		// (get) Token: 0x06009319 RID: 37657 RVA: 0x00283170 File Offset: 0x00281370
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

		// Token: 0x17001EB5 RID: 7861
		// (get) Token: 0x0600931A RID: 37658 RVA: 0x002831AC File Offset: 0x002813AC
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

		// Token: 0x0600931B RID: 37659 RVA: 0x002831E8 File Offset: 0x002813E8
		public int Skills(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001EB6 RID: 7862
		// (get) Token: 0x0600931C RID: 37660 RVA: 0x00283228 File Offset: 0x00281428
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

		// Token: 0x0600931D RID: 37661 RVA: 0x00283253 File Offset: 0x00281453
		public Span<int> GetSkillsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600931E RID: 37662 RVA: 0x00283262 File Offset: 0x00281462
		public int[] GetSkillsArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17001EB7 RID: 7863
		// (get) Token: 0x0600931F RID: 37663 RVA: 0x0028327C File Offset: 0x0028147C
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

		// Token: 0x17001EB8 RID: 7864
		// (get) Token: 0x06009320 RID: 37664 RVA: 0x002832BC File Offset: 0x002814BC
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

		// Token: 0x06009321 RID: 37665 RVA: 0x002832F4 File Offset: 0x002814F4
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06009322 RID: 37666 RVA: 0x00283304 File Offset: 0x00281504
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001EB9 RID: 7865
		// (get) Token: 0x06009323 RID: 37667 RVA: 0x0028331C File Offset: 0x0028151C
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

		// Token: 0x06009324 RID: 37668 RVA: 0x00283354 File Offset: 0x00281554
		public Span<byte> GetSpineAtlasPathBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06009325 RID: 37669 RVA: 0x00283364 File Offset: 0x00281564
		public byte[] GetSpineAtlasPathArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001EBA RID: 7866
		// (get) Token: 0x06009326 RID: 37670 RVA: 0x0028337C File Offset: 0x0028157C
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

		// Token: 0x06009327 RID: 37671 RVA: 0x002833B4 File Offset: 0x002815B4
		public Span<byte> GetSpineSkeletonDataPathBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06009328 RID: 37672 RVA: 0x002833C4 File Offset: 0x002815C4
		public byte[] GetSpineSkeletonDataPathArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17001EBB RID: 7867
		// (get) Token: 0x06009329 RID: 37673 RVA: 0x002833DC File Offset: 0x002815DC
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

		// Token: 0x0600932A RID: 37674 RVA: 0x00283414 File Offset: 0x00281614
		public Span<byte> GetRoleIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600932B RID: 37675 RVA: 0x00283424 File Offset: 0x00281624
		public byte[] GetRoleIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17001EBC RID: 7868
		// (get) Token: 0x0600932C RID: 37676 RVA: 0x0028343C File Offset: 0x0028163C
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

		// Token: 0x0600932D RID: 37677 RVA: 0x00283474 File Offset: 0x00281674
		public Span<byte> GetRoleSelIconBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600932E RID: 37678 RVA: 0x00283484 File Offset: 0x00281684
		public byte[] GetRoleSelIconArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x0600932F RID: 37679 RVA: 0x0028349C File Offset: 0x0028169C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SkillsIter()或GetSkillsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Skills()
		{
			MatchThreeRole matchThreeRole = this;
			return matchThreeRole.GetSkillsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009330 RID: 37680 RVA: 0x002834C0 File Offset: 0x002816C0
		[NullableContext(1)]
		public readonly IEnumerable<int> SkillsIter()
		{
			MatchThreeRole.<SkillsIter>d__40 <SkillsIter>d__ = new MatchThreeRole.<SkillsIter>d__40(-2);
			<SkillsIter>d__.<>3__<>4__this = this;
			return <SkillsIter>d__;
		}

		// Token: 0x04004EA3 RID: 20131
		private Table __p;
	}
}
