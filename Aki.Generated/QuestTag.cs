using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F77 RID: 3959
	public struct QuestTag : IFlatbufferObject
	{
		// Token: 0x17002BE6 RID: 11238
		// (get) Token: 0x0600B628 RID: 46632 RVA: 0x002D0EC9 File Offset: 0x002CF0C9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B629 RID: 46633 RVA: 0x002D0ED6 File Offset: 0x002CF0D6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B62A RID: 46634 RVA: 0x002D0EE0 File Offset: 0x002CF0E0
		public static QuestTag GetRootAsQuestTag(ByteBuffer _bb)
		{
			return QuestTag.GetRootAsQuestTag(_bb, default(QuestTag));
		}

		// Token: 0x0600B62B RID: 46635 RVA: 0x002D0EFC File Offset: 0x002CF0FC
		public static QuestTag GetRootAsQuestTag(ByteBuffer _bb, QuestTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B62C RID: 46636 RVA: 0x002D0F19 File Offset: 0x002CF119
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B62D RID: 46637 RVA: 0x002D0F28 File Offset: 0x002CF128
		public QuestTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002BE7 RID: 11239
		// (get) Token: 0x0600B62E RID: 46638 RVA: 0x002D0F38 File Offset: 0x002CF138
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

		// Token: 0x17002BE8 RID: 11240
		// (get) Token: 0x0600B62F RID: 46639 RVA: 0x002D0F74 File Offset: 0x002CF174
		public string Name
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

		// Token: 0x0600B630 RID: 46640 RVA: 0x002D0FAB File Offset: 0x002CF1AB
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B631 RID: 46641 RVA: 0x002D0FBA File Offset: 0x002CF1BA
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BE9 RID: 11241
		// (get) Token: 0x0600B632 RID: 46642 RVA: 0x002D0FD4 File Offset: 0x002CF1D4
		public string BgSpritePath
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

		// Token: 0x0600B633 RID: 46643 RVA: 0x002D100B File Offset: 0x002CF20B
		public Span<byte> GetBgSpritePathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B634 RID: 46644 RVA: 0x002D101A File Offset: 0x002CF21A
		public byte[] GetBgSpritePathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BEA RID: 11242
		// (get) Token: 0x0600B635 RID: 46645 RVA: 0x002D1034 File Offset: 0x002CF234
		public string Text
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

		// Token: 0x0600B636 RID: 46646 RVA: 0x002D106C File Offset: 0x002CF26C
		public Span<byte> GetTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600B637 RID: 46647 RVA: 0x002D107C File Offset: 0x002CF27C
		public byte[] GetTextArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BEB RID: 11243
		// (get) Token: 0x0600B638 RID: 46648 RVA: 0x002D1094 File Offset: 0x002CF294
		public bool UseOriginalSize
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002BEC RID: 11244
		// (get) Token: 0x0600B639 RID: 46649 RVA: 0x002D10D4 File Offset: 0x002CF2D4
		public string PrefabPath
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

		// Token: 0x0600B63A RID: 46650 RVA: 0x002D110C File Offset: 0x002CF30C
		public Span<byte> GetPrefabPathBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600B63B RID: 46651 RVA: 0x002D111C File Offset: 0x002CF31C
		public byte[] GetPrefabPathArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04005045 RID: 20549
		private Table __p;
	}
}
