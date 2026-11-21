using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D57 RID: 3415
	public struct FindSunSpirit : IFlatbufferObject
	{
		// Token: 0x1700116F RID: 4463
		// (get) Token: 0x0600749B RID: 29851 RVA: 0x0024E63C File Offset: 0x0024C83C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600749C RID: 29852 RVA: 0x0024E649 File Offset: 0x0024C849
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600749D RID: 29853 RVA: 0x0024E650 File Offset: 0x0024C850
		public static FindSunSpirit GetRootAsFindSunSpirit(ByteBuffer _bb)
		{
			return FindSunSpirit.GetRootAsFindSunSpirit(_bb, default(FindSunSpirit));
		}

		// Token: 0x0600749E RID: 29854 RVA: 0x0024E66C File Offset: 0x0024C86C
		public static FindSunSpirit GetRootAsFindSunSpirit(ByteBuffer _bb, FindSunSpirit obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600749F RID: 29855 RVA: 0x0024E689 File Offset: 0x0024C889
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060074A0 RID: 29856 RVA: 0x0024E698 File Offset: 0x0024C898
		public FindSunSpirit __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001170 RID: 4464
		// (get) Token: 0x060074A1 RID: 29857 RVA: 0x0024E6A8 File Offset: 0x0024C8A8
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

		// Token: 0x17001171 RID: 4465
		// (get) Token: 0x060074A2 RID: 29858 RVA: 0x0024E6E4 File Offset: 0x0024C8E4
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

		// Token: 0x060074A3 RID: 29859 RVA: 0x0024E71B File Offset: 0x0024C91B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060074A4 RID: 29860 RVA: 0x0024E72A File Offset: 0x0024C92A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001172 RID: 4466
		// (get) Token: 0x060074A5 RID: 29861 RVA: 0x0024E744 File Offset: 0x0024C944
		public string Level
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

		// Token: 0x060074A6 RID: 29862 RVA: 0x0024E77B File Offset: 0x0024C97B
		public Span<byte> GetLevelBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060074A7 RID: 29863 RVA: 0x0024E78A File Offset: 0x0024C98A
		public byte[] GetLevelArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x040052A2 RID: 21154
		private Table __p;
	}
}
