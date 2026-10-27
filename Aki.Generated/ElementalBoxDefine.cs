using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C24 RID: 3108
	public struct ElementalBoxDefine : IFlatbufferObject
	{
		// Token: 0x17000E9C RID: 3740
		// (get) Token: 0x060067BC RID: 26556 RVA: 0x00220605 File Offset: 0x0021E805
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060067BD RID: 26557 RVA: 0x00220612 File Offset: 0x0021E812
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060067BE RID: 26558 RVA: 0x0022061C File Offset: 0x0021E81C
		public static ElementalBoxDefine GetRootAsElementalBoxDefine(ByteBuffer _bb)
		{
			return ElementalBoxDefine.GetRootAsElementalBoxDefine(_bb, default(ElementalBoxDefine));
		}

		// Token: 0x060067BF RID: 26559 RVA: 0x00220638 File Offset: 0x0021E838
		public static ElementalBoxDefine GetRootAsElementalBoxDefine(ByteBuffer _bb, ElementalBoxDefine obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060067C0 RID: 26560 RVA: 0x00220655 File Offset: 0x0021E855
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060067C1 RID: 26561 RVA: 0x00220664 File Offset: 0x0021E864
		public ElementalBoxDefine __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000E9D RID: 3741
		// (get) Token: 0x060067C2 RID: 26562 RVA: 0x00220674 File Offset: 0x0021E874
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

		// Token: 0x17000E9E RID: 3742
		// (get) Token: 0x060067C3 RID: 26563 RVA: 0x002206B0 File Offset: 0x0021E8B0
		public string ElementalType
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

		// Token: 0x060067C4 RID: 26564 RVA: 0x002206E7 File Offset: 0x0021E8E7
		public Span<byte> GetElementalTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060067C5 RID: 26565 RVA: 0x002206F6 File Offset: 0x0021E8F6
		public byte[] GetElementalTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000E9F RID: 3743
		// (get) Token: 0x060067C6 RID: 26566 RVA: 0x00220710 File Offset: 0x0021E910
		public int Priority
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000EA0 RID: 3744
		// (get) Token: 0x060067C7 RID: 26567 RVA: 0x0022074C File Offset: 0x0021E94C
		public string InitState
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

		// Token: 0x060067C8 RID: 26568 RVA: 0x00220784 File Offset: 0x0021E984
		public Span<byte> GetInitStateBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060067C9 RID: 26569 RVA: 0x00220794 File Offset: 0x0021E994
		public byte[] GetInitStateArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000EA1 RID: 3745
		// (get) Token: 0x060067CA RID: 26570 RVA: 0x002207AC File Offset: 0x0021E9AC
		public string CustomBoxPrefab
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

		// Token: 0x060067CB RID: 26571 RVA: 0x002207E4 File Offset: 0x0021E9E4
		public Span<byte> GetCustomBoxPrefabBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060067CC RID: 26572 RVA: 0x002207F4 File Offset: 0x0021E9F4
		public byte[] GetCustomBoxPrefabArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04004C64 RID: 19556
		private Table __p;
	}
}
