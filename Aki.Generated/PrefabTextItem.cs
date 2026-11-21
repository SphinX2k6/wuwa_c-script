using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001038 RID: 4152
	public struct PrefabTextItem : IFlatbufferObject
	{
		// Token: 0x17002B19 RID: 11033
		// (get) Token: 0x0600B8C6 RID: 47302 RVA: 0x002E665B File Offset: 0x002E485B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B8C7 RID: 47303 RVA: 0x002E6668 File Offset: 0x002E4868
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B8C8 RID: 47304 RVA: 0x002E6670 File Offset: 0x002E4870
		public static PrefabTextItem GetRootAsPrefabTextItem(ByteBuffer _bb)
		{
			return PrefabTextItem.GetRootAsPrefabTextItem(_bb, default(PrefabTextItem));
		}

		// Token: 0x0600B8C9 RID: 47305 RVA: 0x002E668C File Offset: 0x002E488C
		public static PrefabTextItem GetRootAsPrefabTextItem(ByteBuffer _bb, PrefabTextItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B8CA RID: 47306 RVA: 0x002E66A9 File Offset: 0x002E48A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B8CB RID: 47307 RVA: 0x002E66B8 File Offset: 0x002E48B8
		public PrefabTextItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002B1A RID: 11034
		// (get) Token: 0x0600B8CC RID: 47308 RVA: 0x002E66C8 File Offset: 0x002E48C8
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

		// Token: 0x17002B1B RID: 11035
		// (get) Token: 0x0600B8CD RID: 47309 RVA: 0x002E6708 File Offset: 0x002E4908
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

		// Token: 0x17002B1C RID: 11036
		// (get) Token: 0x0600B8CE RID: 47310 RVA: 0x002E6748 File Offset: 0x002E4948
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

		// Token: 0x0600B8CF RID: 47311 RVA: 0x002E677F File Offset: 0x002E497F
		public Span<byte> GetItemPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B8D0 RID: 47312 RVA: 0x002E678E File Offset: 0x002E498E
		public byte[] GetItemPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B1D RID: 11037
		// (get) Token: 0x0600B8D1 RID: 47313 RVA: 0x002E67A8 File Offset: 0x002E49A8
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

		// Token: 0x0600B8D2 RID: 47314 RVA: 0x002E67E0 File Offset: 0x002E49E0
		public Span<byte> GetTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600B8D3 RID: 47315 RVA: 0x002E67F0 File Offset: 0x002E49F0
		public byte[] GetTextArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04005605 RID: 22021
		private Table __p;
	}
}
