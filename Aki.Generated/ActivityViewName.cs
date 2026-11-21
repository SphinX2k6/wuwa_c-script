using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BAB RID: 2987
	public struct ActivityViewName : IFlatbufferObject
	{
		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06004984 RID: 18820 RVA: 0x001EDA98 File Offset: 0x001EBC98
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004985 RID: 18821 RVA: 0x001EDAA5 File Offset: 0x001EBCA5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004986 RID: 18822 RVA: 0x001EDAAC File Offset: 0x001EBCAC
		public static ActivityViewName GetRootAsActivityViewName(ByteBuffer _bb)
		{
			return ActivityViewName.GetRootAsActivityViewName(_bb, default(ActivityViewName));
		}

		// Token: 0x06004987 RID: 18823 RVA: 0x001EDAC8 File Offset: 0x001EBCC8
		public static ActivityViewName GetRootAsActivityViewName(ByteBuffer _bb, ActivityViewName obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004988 RID: 18824 RVA: 0x001EDAE5 File Offset: 0x001EBCE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004989 RID: 18825 RVA: 0x001EDAF4 File Offset: 0x001EBCF4
		public ActivityViewName __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x0600498A RID: 18826 RVA: 0x001EDB04 File Offset: 0x001EBD04
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

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x0600498B RID: 18827 RVA: 0x001EDB40 File Offset: 0x001EBD40
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

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x0600498C RID: 18828 RVA: 0x001EDB7C File Offset: 0x001EBD7C
		public string ViewName
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

		// Token: 0x0600498D RID: 18829 RVA: 0x001EDBB3 File Offset: 0x001EBDB3
		public Span<byte> GetViewNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600498E RID: 18830 RVA: 0x001EDBC2 File Offset: 0x001EBDC2
		public byte[] GetViewNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04005088 RID: 20616
		private Table __p;
	}
}
