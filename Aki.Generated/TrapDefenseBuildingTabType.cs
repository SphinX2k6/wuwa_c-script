using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200115D RID: 4445
	public struct TrapDefenseBuildingTabType : IFlatbufferObject
	{
		// Token: 0x17003C00 RID: 15360
		// (get) Token: 0x0600E31E RID: 58142 RVA: 0x003379C1 File Offset: 0x00335BC1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E31F RID: 58143 RVA: 0x003379CE File Offset: 0x00335BCE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E320 RID: 58144 RVA: 0x003379D8 File Offset: 0x00335BD8
		public static TrapDefenseBuildingTabType GetRootAsTrapDefenseBuildingTabType(ByteBuffer _bb)
		{
			return TrapDefenseBuildingTabType.GetRootAsTrapDefenseBuildingTabType(_bb, default(TrapDefenseBuildingTabType));
		}

		// Token: 0x0600E321 RID: 58145 RVA: 0x003379F4 File Offset: 0x00335BF4
		public static TrapDefenseBuildingTabType GetRootAsTrapDefenseBuildingTabType(ByteBuffer _bb, TrapDefenseBuildingTabType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E322 RID: 58146 RVA: 0x00337A11 File Offset: 0x00335C11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E323 RID: 58147 RVA: 0x00337A20 File Offset: 0x00335C20
		public TrapDefenseBuildingTabType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003C01 RID: 15361
		// (get) Token: 0x0600E324 RID: 58148 RVA: 0x00337A30 File Offset: 0x00335C30
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

		// Token: 0x17003C02 RID: 15362
		// (get) Token: 0x0600E325 RID: 58149 RVA: 0x00337A6C File Offset: 0x00335C6C
		public string Icon
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

		// Token: 0x0600E326 RID: 58150 RVA: 0x00337AA3 File Offset: 0x00335CA3
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E327 RID: 58151 RVA: 0x00337AB2 File Offset: 0x00335CB2
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003C03 RID: 15363
		// (get) Token: 0x0600E328 RID: 58152 RVA: 0x00337ACC File Offset: 0x00335CCC
		public string TabName
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

		// Token: 0x0600E329 RID: 58153 RVA: 0x00337B03 File Offset: 0x00335D03
		public Span<byte> GetTabNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600E32A RID: 58154 RVA: 0x00337B12 File Offset: 0x00335D12
		public byte[] GetTabNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003C04 RID: 15364
		// (get) Token: 0x0600E32B RID: 58155 RVA: 0x00337B2C File Offset: 0x00335D2C
		public string RedDot
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

		// Token: 0x0600E32C RID: 58156 RVA: 0x00337B64 File Offset: 0x00335D64
		public Span<byte> GetRedDotBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600E32D RID: 58157 RVA: 0x00337B74 File Offset: 0x00335D74
		public byte[] GetRedDotArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x040052A2 RID: 21154
		private Table __p;
	}
}
