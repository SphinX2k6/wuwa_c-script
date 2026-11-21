using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DE9 RID: 3561
	public struct GlobalConfigFromCsv : IFlatbufferObject
	{
		// Token: 0x1700162E RID: 5678
		// (get) Token: 0x06008123 RID: 33059 RVA: 0x0026B32E File Offset: 0x0026952E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008124 RID: 33060 RVA: 0x0026B33B File Offset: 0x0026953B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008125 RID: 33061 RVA: 0x0026B344 File Offset: 0x00269544
		public static GlobalConfigFromCsv GetRootAsGlobalConfigFromCsv(ByteBuffer _bb)
		{
			return GlobalConfigFromCsv.GetRootAsGlobalConfigFromCsv(_bb, default(GlobalConfigFromCsv));
		}

		// Token: 0x06008126 RID: 33062 RVA: 0x0026B360 File Offset: 0x00269560
		public static GlobalConfigFromCsv GetRootAsGlobalConfigFromCsv(ByteBuffer _bb, GlobalConfigFromCsv obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008127 RID: 33063 RVA: 0x0026B37D File Offset: 0x0026957D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008128 RID: 33064 RVA: 0x0026B38C File Offset: 0x0026958C
		public GlobalConfigFromCsv __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700162F RID: 5679
		// (get) Token: 0x06008129 RID: 33065 RVA: 0x0026B39C File Offset: 0x0026959C
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

		// Token: 0x17001630 RID: 5680
		// (get) Token: 0x0600812A RID: 33066 RVA: 0x0026B3D8 File Offset: 0x002695D8
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

		// Token: 0x0600812B RID: 33067 RVA: 0x0026B40F File Offset: 0x0026960F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600812C RID: 33068 RVA: 0x0026B41E File Offset: 0x0026961E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001631 RID: 5681
		// (get) Token: 0x0600812D RID: 33069 RVA: 0x0026B438 File Offset: 0x00269638
		public string Desc
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

		// Token: 0x0600812E RID: 33070 RVA: 0x0026B46F File Offset: 0x0026966F
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600812F RID: 33071 RVA: 0x0026B47E File Offset: 0x0026967E
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001632 RID: 5682
		// (get) Token: 0x06008130 RID: 33072 RVA: 0x0026B498 File Offset: 0x00269698
		public string Type
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

		// Token: 0x06008131 RID: 33073 RVA: 0x0026B4D0 File Offset: 0x002696D0
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008132 RID: 33074 RVA: 0x0026B4E0 File Offset: 0x002696E0
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001633 RID: 5683
		// (get) Token: 0x06008133 RID: 33075 RVA: 0x0026B4F8 File Offset: 0x002696F8
		public string Value
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

		// Token: 0x06008134 RID: 33076 RVA: 0x0026B530 File Offset: 0x00269730
		public Span<byte> GetValueBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06008135 RID: 33077 RVA: 0x0026B540 File Offset: 0x00269740
		public byte[] GetValueArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0400535F RID: 21343
		private Table __p;
	}
}
