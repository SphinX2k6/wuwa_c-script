using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F0E RID: 3854
	public struct PhotographHandBook : IFlatbufferObject
	{
		// Token: 0x17002812 RID: 10258
		// (get) Token: 0x0600AC1F RID: 44063 RVA: 0x002BB304 File Offset: 0x002B9504
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AC20 RID: 44064 RVA: 0x002BB311 File Offset: 0x002B9511
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AC21 RID: 44065 RVA: 0x002BB318 File Offset: 0x002B9518
		public static PhotographHandBook GetRootAsPhotographHandBook(ByteBuffer _bb)
		{
			return PhotographHandBook.GetRootAsPhotographHandBook(_bb, default(PhotographHandBook));
		}

		// Token: 0x0600AC22 RID: 44066 RVA: 0x002BB334 File Offset: 0x002B9534
		public static PhotographHandBook GetRootAsPhotographHandBook(ByteBuffer _bb, PhotographHandBook obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AC23 RID: 44067 RVA: 0x002BB351 File Offset: 0x002B9551
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AC24 RID: 44068 RVA: 0x002BB360 File Offset: 0x002B9560
		public PhotographHandBook __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002813 RID: 10259
		// (get) Token: 0x0600AC25 RID: 44069 RVA: 0x002BB370 File Offset: 0x002B9570
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

		// Token: 0x17002814 RID: 10260
		// (get) Token: 0x0600AC26 RID: 44070 RVA: 0x002BB3AC File Offset: 0x002B95AC
		public int Type
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

		// Token: 0x17002815 RID: 10261
		// (get) Token: 0x0600AC27 RID: 44071 RVA: 0x002BB3E8 File Offset: 0x002B95E8
		public string Name
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

		// Token: 0x0600AC28 RID: 44072 RVA: 0x002BB41F File Offset: 0x002B961F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600AC29 RID: 44073 RVA: 0x002BB42E File Offset: 0x002B962E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002816 RID: 10262
		// (get) Token: 0x0600AC2A RID: 44074 RVA: 0x002BB448 File Offset: 0x002B9648
		public string MaleTexture
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

		// Token: 0x0600AC2B RID: 44075 RVA: 0x002BB480 File Offset: 0x002B9680
		public Span<byte> GetMaleTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600AC2C RID: 44076 RVA: 0x002BB490 File Offset: 0x002B9690
		public byte[] GetMaleTextureArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002817 RID: 10263
		// (get) Token: 0x0600AC2D RID: 44077 RVA: 0x002BB4A8 File Offset: 0x002B96A8
		public string FemaleTexture
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

		// Token: 0x0600AC2E RID: 44078 RVA: 0x002BB4E0 File Offset: 0x002B96E0
		public Span<byte> GetFemaleTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600AC2F RID: 44079 RVA: 0x002BB4F0 File Offset: 0x002B96F0
		public byte[] GetFemaleTextureArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002818 RID: 10264
		// (get) Token: 0x0600AC30 RID: 44080 RVA: 0x002BB508 File Offset: 0x002B9708
		public string Descrtption
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

		// Token: 0x0600AC31 RID: 44081 RVA: 0x002BB540 File Offset: 0x002B9740
		public Span<byte> GetDescrtptionBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600AC32 RID: 44082 RVA: 0x002BB550 File Offset: 0x002B9750
		public byte[] GetDescrtptionArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002819 RID: 10265
		// (get) Token: 0x0600AC33 RID: 44083 RVA: 0x002BB568 File Offset: 0x002B9768
		public string AreaIcon
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

		// Token: 0x0600AC34 RID: 44084 RVA: 0x002BB5A0 File Offset: 0x002B97A0
		public Span<byte> GetAreaIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600AC35 RID: 44085 RVA: 0x002BB5B0 File Offset: 0x002B97B0
		public byte[] GetAreaIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700281A RID: 10266
		// (get) Token: 0x0600AC36 RID: 44086 RVA: 0x002BB5C8 File Offset: 0x002B97C8
		public string AreaNumber
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

		// Token: 0x0600AC37 RID: 44087 RVA: 0x002BB600 File Offset: 0x002B9800
		public Span<byte> GetAreaNumberBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600AC38 RID: 44088 RVA: 0x002BB610 File Offset: 0x002B9810
		public byte[] GetAreaNumberArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x1700281B RID: 10267
		// (get) Token: 0x0600AC39 RID: 44089 RVA: 0x002BB628 File Offset: 0x002B9828
		public string RoleName
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

		// Token: 0x0600AC3A RID: 44090 RVA: 0x002BB660 File Offset: 0x002B9860
		public Span<byte> GetRoleNameBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600AC3B RID: 44091 RVA: 0x002BB670 File Offset: 0x002B9870
		public byte[] GetRoleNameArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x1700281C RID: 10268
		// (get) Token: 0x0600AC3C RID: 44092 RVA: 0x002BB688 File Offset: 0x002B9888
		public int QuestId
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AC3D RID: 44093 RVA: 0x002BB6C8 File Offset: 0x002B98C8
		public int ShowQuestList(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700281D RID: 10269
		// (get) Token: 0x0600AC3E RID: 44094 RVA: 0x002BB708 File Offset: 0x002B9908
		public int ShowQuestListLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600AC3F RID: 44095 RVA: 0x002BB734 File Offset: 0x002B9934
		public Span<int> GetShowQuestListBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x0600AC40 RID: 44096 RVA: 0x002BB744 File Offset: 0x002B9944
		public int[] GetShowQuestListArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x0600AC41 RID: 44097 RVA: 0x002BB75C File Offset: 0x002B995C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ShowQuestListIter()或GetShowQuestListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ShowQuestList()
		{
			PhotographHandBook photographHandBook = this;
			return photographHandBook.GetShowQuestListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600AC42 RID: 44098 RVA: 0x002BB780 File Offset: 0x002B9980
		[NullableContext(1)]
		public readonly IEnumerable<int> ShowQuestListIter()
		{
			PhotographHandBook.<ShowQuestListIter>d__48 <ShowQuestListIter>d__ = new PhotographHandBook.<ShowQuestListIter>d__48(-2);
			<ShowQuestListIter>d__.<>3__<>4__this = this;
			return <ShowQuestListIter>d__;
		}

		// Token: 0x04004FD6 RID: 20438
		private Table __p;
	}
}
