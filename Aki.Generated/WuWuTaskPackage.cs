using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011AB RID: 4523
	public struct WuWuTaskPackage : IFlatbufferObject
	{
		// Token: 0x17003E8F RID: 16015
		// (get) Token: 0x0600E985 RID: 59781 RVA: 0x00346449 File Offset: 0x00344649
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E986 RID: 59782 RVA: 0x00346456 File Offset: 0x00344656
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E987 RID: 59783 RVA: 0x00346460 File Offset: 0x00344660
		public static WuWuTaskPackage GetRootAsWuWuTaskPackage(ByteBuffer _bb)
		{
			return WuWuTaskPackage.GetRootAsWuWuTaskPackage(_bb, default(WuWuTaskPackage));
		}

		// Token: 0x0600E988 RID: 59784 RVA: 0x0034647C File Offset: 0x0034467C
		public static WuWuTaskPackage GetRootAsWuWuTaskPackage(ByteBuffer _bb, WuWuTaskPackage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E989 RID: 59785 RVA: 0x00346499 File Offset: 0x00344699
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E98A RID: 59786 RVA: 0x003464A8 File Offset: 0x003446A8
		public WuWuTaskPackage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003E90 RID: 16016
		// (get) Token: 0x0600E98B RID: 59787 RVA: 0x003464B8 File Offset: 0x003446B8
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

		// Token: 0x17003E91 RID: 16017
		// (get) Token: 0x0600E98C RID: 59788 RVA: 0x003464F4 File Offset: 0x003446F4
		public int PreWrap
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

		// Token: 0x17003E92 RID: 16018
		// (get) Token: 0x0600E98D RID: 59789 RVA: 0x00346530 File Offset: 0x00344730
		public int OpenDay
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003E93 RID: 16019
		// (get) Token: 0x0600E98E RID: 59790 RVA: 0x0034656C File Offset: 0x0034476C
		public int DropId
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

		// Token: 0x17003E94 RID: 16020
		// (get) Token: 0x0600E98F RID: 59791 RVA: 0x003465AC File Offset: 0x003447AC
		public string Title
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

		// Token: 0x0600E990 RID: 59792 RVA: 0x003465E4 File Offset: 0x003447E4
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600E991 RID: 59793 RVA: 0x003465F4 File Offset: 0x003447F4
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003E95 RID: 16021
		// (get) Token: 0x0600E992 RID: 59794 RVA: 0x0034660C File Offset: 0x0034480C
		public int DescGroupId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040052F8 RID: 21240
		private Table __p;
	}
}
