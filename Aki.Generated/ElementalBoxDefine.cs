using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D07 RID: 3335
	public struct ElementalBoxDefine : IFlatbufferObject
	{
		// Token: 0x17000EF0 RID: 3824
		// (get) Token: 0x06006DAF RID: 28079 RVA: 0x0023F9A9 File Offset: 0x0023DBA9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006DB0 RID: 28080 RVA: 0x0023F9B6 File Offset: 0x0023DBB6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006DB1 RID: 28081 RVA: 0x0023F9C0 File Offset: 0x0023DBC0
		public static ElementalBoxDefine GetRootAsElementalBoxDefine(ByteBuffer _bb)
		{
			return ElementalBoxDefine.GetRootAsElementalBoxDefine(_bb, default(ElementalBoxDefine));
		}

		// Token: 0x06006DB2 RID: 28082 RVA: 0x0023F9DC File Offset: 0x0023DBDC
		public static ElementalBoxDefine GetRootAsElementalBoxDefine(ByteBuffer _bb, ElementalBoxDefine obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006DB3 RID: 28083 RVA: 0x0023F9F9 File Offset: 0x0023DBF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006DB4 RID: 28084 RVA: 0x0023FA08 File Offset: 0x0023DC08
		public ElementalBoxDefine __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000EF1 RID: 3825
		// (get) Token: 0x06006DB5 RID: 28085 RVA: 0x0023FA18 File Offset: 0x0023DC18
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

		// Token: 0x17000EF2 RID: 3826
		// (get) Token: 0x06006DB6 RID: 28086 RVA: 0x0023FA54 File Offset: 0x0023DC54
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

		// Token: 0x06006DB7 RID: 28087 RVA: 0x0023FA8B File Offset: 0x0023DC8B
		public Span<byte> GetElementalTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006DB8 RID: 28088 RVA: 0x0023FA9A File Offset: 0x0023DC9A
		public byte[] GetElementalTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000EF3 RID: 3827
		// (get) Token: 0x06006DB9 RID: 28089 RVA: 0x0023FAB4 File Offset: 0x0023DCB4
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

		// Token: 0x17000EF4 RID: 3828
		// (get) Token: 0x06006DBA RID: 28090 RVA: 0x0023FAF0 File Offset: 0x0023DCF0
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

		// Token: 0x06006DBB RID: 28091 RVA: 0x0023FB28 File Offset: 0x0023DD28
		public Span<byte> GetInitStateBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06006DBC RID: 28092 RVA: 0x0023FB38 File Offset: 0x0023DD38
		public byte[] GetInitStateArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000EF5 RID: 3829
		// (get) Token: 0x06006DBD RID: 28093 RVA: 0x0023FB50 File Offset: 0x0023DD50
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

		// Token: 0x06006DBE RID: 28094 RVA: 0x0023FB88 File Offset: 0x0023DD88
		public Span<byte> GetCustomBoxPrefabBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06006DBF RID: 28095 RVA: 0x0023FB98 File Offset: 0x0023DD98
		public byte[] GetCustomBoxPrefabArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04005247 RID: 21063
		private Table __p;
	}
}
