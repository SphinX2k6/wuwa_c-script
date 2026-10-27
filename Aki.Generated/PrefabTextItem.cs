using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F53 RID: 3923
	public struct PrefabTextItem : IFlatbufferObject
	{
		// Token: 0x17002AB3 RID: 10931
		// (get) Token: 0x0600B2A5 RID: 45733 RVA: 0x002C9E0F File Offset: 0x002C800F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B2A6 RID: 45734 RVA: 0x002C9E1C File Offset: 0x002C801C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B2A7 RID: 45735 RVA: 0x002C9E24 File Offset: 0x002C8024
		public static PrefabTextItem GetRootAsPrefabTextItem(ByteBuffer _bb)
		{
			return PrefabTextItem.GetRootAsPrefabTextItem(_bb, default(PrefabTextItem));
		}

		// Token: 0x0600B2A8 RID: 45736 RVA: 0x002C9E40 File Offset: 0x002C8040
		public static PrefabTextItem GetRootAsPrefabTextItem(ByteBuffer _bb, PrefabTextItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B2A9 RID: 45737 RVA: 0x002C9E5D File Offset: 0x002C805D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B2AA RID: 45738 RVA: 0x002C9E6C File Offset: 0x002C806C
		public PrefabTextItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002AB4 RID: 10932
		// (get) Token: 0x0600B2AB RID: 45739 RVA: 0x002C9E7C File Offset: 0x002C807C
		public long ItemId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0L;
				}
				return this.__p.bb.GetLong(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002AB5 RID: 10933
		// (get) Token: 0x0600B2AC RID: 45740 RVA: 0x002C9EBC File Offset: 0x002C80BC
		public long PrefabPathHash
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0L;
				}
				return this.__p.bb.GetLong(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002AB6 RID: 10934
		// (get) Token: 0x0600B2AD RID: 45741 RVA: 0x002C9EFC File Offset: 0x002C80FC
		public string ItemPath
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

		// Token: 0x0600B2AE RID: 45742 RVA: 0x002C9F33 File Offset: 0x002C8133
		public Span<byte> GetItemPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B2AF RID: 45743 RVA: 0x002C9F42 File Offset: 0x002C8142
		public byte[] GetItemPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AB7 RID: 10935
		// (get) Token: 0x0600B2B0 RID: 45744 RVA: 0x002C9F5C File Offset: 0x002C815C
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

		// Token: 0x0600B2B1 RID: 45745 RVA: 0x002C9F94 File Offset: 0x002C8194
		public Span<byte> GetTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600B2B2 RID: 45746 RVA: 0x002C9FA4 File Offset: 0x002C81A4
		public byte[] GetTextArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04005020 RID: 20512
		private Table __p;
	}
}
