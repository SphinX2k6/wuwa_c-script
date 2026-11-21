using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FF3 RID: 4083
	public struct PhotographHandBook : IFlatbufferObject
	{
		// Token: 0x17002878 RID: 10360
		// (get) Token: 0x0600B240 RID: 45632 RVA: 0x002D7FB0 File Offset: 0x002D61B0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B241 RID: 45633 RVA: 0x002D7FBD File Offset: 0x002D61BD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B242 RID: 45634 RVA: 0x002D7FC4 File Offset: 0x002D61C4
		public static PhotographHandBook GetRootAsPhotographHandBook(ByteBuffer _bb)
		{
			return PhotographHandBook.GetRootAsPhotographHandBook(_bb, default(PhotographHandBook));
		}

		// Token: 0x0600B243 RID: 45635 RVA: 0x002D7FE0 File Offset: 0x002D61E0
		public static PhotographHandBook GetRootAsPhotographHandBook(ByteBuffer _bb, PhotographHandBook obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B244 RID: 45636 RVA: 0x002D7FFD File Offset: 0x002D61FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B245 RID: 45637 RVA: 0x002D800C File Offset: 0x002D620C
		public PhotographHandBook __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002879 RID: 10361
		// (get) Token: 0x0600B246 RID: 45638 RVA: 0x002D801C File Offset: 0x002D621C
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

		// Token: 0x1700287A RID: 10362
		// (get) Token: 0x0600B247 RID: 45639 RVA: 0x002D8058 File Offset: 0x002D6258
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

		// Token: 0x1700287B RID: 10363
		// (get) Token: 0x0600B248 RID: 45640 RVA: 0x002D8094 File Offset: 0x002D6294
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

		// Token: 0x0600B249 RID: 45641 RVA: 0x002D80CB File Offset: 0x002D62CB
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B24A RID: 45642 RVA: 0x002D80DA File Offset: 0x002D62DA
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700287C RID: 10364
		// (get) Token: 0x0600B24B RID: 45643 RVA: 0x002D80F4 File Offset: 0x002D62F4
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

		// Token: 0x0600B24C RID: 45644 RVA: 0x002D812C File Offset: 0x002D632C
		public Span<byte> GetMaleTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600B24D RID: 45645 RVA: 0x002D813C File Offset: 0x002D633C
		public byte[] GetMaleTextureArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700287D RID: 10365
		// (get) Token: 0x0600B24E RID: 45646 RVA: 0x002D8154 File Offset: 0x002D6354
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

		// Token: 0x0600B24F RID: 45647 RVA: 0x002D818C File Offset: 0x002D638C
		public Span<byte> GetFemaleTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B250 RID: 45648 RVA: 0x002D819C File Offset: 0x002D639C
		public byte[] GetFemaleTextureArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700287E RID: 10366
		// (get) Token: 0x0600B251 RID: 45649 RVA: 0x002D81B4 File Offset: 0x002D63B4
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

		// Token: 0x0600B252 RID: 45650 RVA: 0x002D81EC File Offset: 0x002D63EC
		public Span<byte> GetDescrtptionBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600B253 RID: 45651 RVA: 0x002D81FC File Offset: 0x002D63FC
		public byte[] GetDescrtptionArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700287F RID: 10367
		// (get) Token: 0x0600B254 RID: 45652 RVA: 0x002D8214 File Offset: 0x002D6414
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

		// Token: 0x0600B255 RID: 45653 RVA: 0x002D824C File Offset: 0x002D644C
		public Span<byte> GetAreaIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600B256 RID: 45654 RVA: 0x002D825C File Offset: 0x002D645C
		public byte[] GetAreaIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002880 RID: 10368
		// (get) Token: 0x0600B257 RID: 45655 RVA: 0x002D8274 File Offset: 0x002D6474
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

		// Token: 0x0600B258 RID: 45656 RVA: 0x002D82AC File Offset: 0x002D64AC
		public Span<byte> GetAreaNumberBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600B259 RID: 45657 RVA: 0x002D82BC File Offset: 0x002D64BC
		public byte[] GetAreaNumberArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002881 RID: 10369
		// (get) Token: 0x0600B25A RID: 45658 RVA: 0x002D82D4 File Offset: 0x002D64D4
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

		// Token: 0x0600B25B RID: 45659 RVA: 0x002D830C File Offset: 0x002D650C
		public Span<byte> GetRoleNameBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600B25C RID: 45660 RVA: 0x002D831C File Offset: 0x002D651C
		public byte[] GetRoleNameArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002882 RID: 10370
		// (get) Token: 0x0600B25D RID: 45661 RVA: 0x002D8334 File Offset: 0x002D6534
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

		// Token: 0x0600B25E RID: 45662 RVA: 0x002D8374 File Offset: 0x002D6574
		public int ShowQuestList(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002883 RID: 10371
		// (get) Token: 0x0600B25F RID: 45663 RVA: 0x002D83B4 File Offset: 0x002D65B4
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

		// Token: 0x0600B260 RID: 45664 RVA: 0x002D83E0 File Offset: 0x002D65E0
		public Span<int> GetShowQuestListBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x0600B261 RID: 45665 RVA: 0x002D83F0 File Offset: 0x002D65F0
		public int[] GetShowQuestListArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x0600B262 RID: 45666 RVA: 0x002D8408 File Offset: 0x002D6608
		[NullableContext(1)]
		public int[] ShowQuestList()
		{
			return this.GetShowQuestListArray();
		}

		// Token: 0x0600B263 RID: 45667 RVA: 0x002D8410 File Offset: 0x002D6610
		[NullableContext(1)]
		public IEnumerable<int> ShowQuestListIter()
		{
			PhotographHandBook.<ShowQuestListIter>d__48 <ShowQuestListIter>d__ = new PhotographHandBook.<ShowQuestListIter>d__48(-2);
			<ShowQuestListIter>d__.<>3__<>4__this = this;
			return <ShowQuestListIter>d__;
		}

		// Token: 0x040055BB RID: 21947
		private Table __p;
	}
}
