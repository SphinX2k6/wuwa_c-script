using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D3E RID: 3390
	public struct HonamiStoryMapMark : IFlatbufferObject
	{
		// Token: 0x170017D8 RID: 6104
		// (get) Token: 0x06008053 RID: 32851 RVA: 0x0025846C File Offset: 0x0025666C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008054 RID: 32852 RVA: 0x00258479 File Offset: 0x00256679
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008055 RID: 32853 RVA: 0x00258480 File Offset: 0x00256680
		public static HonamiStoryMapMark GetRootAsHonamiStoryMapMark(ByteBuffer _bb)
		{
			return HonamiStoryMapMark.GetRootAsHonamiStoryMapMark(_bb, default(HonamiStoryMapMark));
		}

		// Token: 0x06008056 RID: 32854 RVA: 0x0025849C File Offset: 0x0025669C
		public static HonamiStoryMapMark GetRootAsHonamiStoryMapMark(ByteBuffer _bb, HonamiStoryMapMark obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008057 RID: 32855 RVA: 0x002584B9 File Offset: 0x002566B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008058 RID: 32856 RVA: 0x002584C8 File Offset: 0x002566C8
		public HonamiStoryMapMark __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170017D9 RID: 6105
		// (get) Token: 0x06008059 RID: 32857 RVA: 0x002584D8 File Offset: 0x002566D8
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

		// Token: 0x170017DA RID: 6106
		// (get) Token: 0x0600805A RID: 32858 RVA: 0x00258514 File Offset: 0x00256714
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

		// Token: 0x0600805B RID: 32859 RVA: 0x0025854B File Offset: 0x0025674B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600805C RID: 32860 RVA: 0x0025855A File Offset: 0x0025675A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170017DB RID: 6107
		// (get) Token: 0x0600805D RID: 32861 RVA: 0x00258574 File Offset: 0x00256774
		public string Description
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

		// Token: 0x0600805E RID: 32862 RVA: 0x002585AB File Offset: 0x002567AB
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600805F RID: 32863 RVA: 0x002585BA File Offset: 0x002567BA
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170017DC RID: 6108
		// (get) Token: 0x06008060 RID: 32864 RVA: 0x002585D4 File Offset: 0x002567D4
		public string IconResourceId
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

		// Token: 0x06008061 RID: 32865 RVA: 0x0025860C File Offset: 0x0025680C
		public Span<byte> GetIconResourceIdBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008062 RID: 32866 RVA: 0x0025861C File Offset: 0x0025681C
		public byte[] GetIconResourceIdArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170017DD RID: 6109
		// (get) Token: 0x06008063 RID: 32867 RVA: 0x00258634 File Offset: 0x00256834
		public string MarkIconResourceId
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

		// Token: 0x06008064 RID: 32868 RVA: 0x0025866C File Offset: 0x0025686C
		public Span<byte> GetMarkIconResourceIdBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06008065 RID: 32869 RVA: 0x0025867C File Offset: 0x0025687C
		public byte[] GetMarkIconResourceIdArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04004DB9 RID: 19897
		private Table __p;
	}
}
