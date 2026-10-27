using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010B3 RID: 4275
	public struct SimpleCombatDetailConfig : IFlatbufferObject
	{
		// Token: 0x1700362A RID: 13866
		// (get) Token: 0x0600D2CE RID: 53966 RVA: 0x00311646 File Offset: 0x0030F846
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D2CF RID: 53967 RVA: 0x00311653 File Offset: 0x0030F853
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D2D0 RID: 53968 RVA: 0x0031165C File Offset: 0x0030F85C
		public static SimpleCombatDetailConfig GetRootAsSimpleCombatDetailConfig(ByteBuffer _bb)
		{
			return SimpleCombatDetailConfig.GetRootAsSimpleCombatDetailConfig(_bb, default(SimpleCombatDetailConfig));
		}

		// Token: 0x0600D2D1 RID: 53969 RVA: 0x00311678 File Offset: 0x0030F878
		public static SimpleCombatDetailConfig GetRootAsSimpleCombatDetailConfig(ByteBuffer _bb, SimpleCombatDetailConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D2D2 RID: 53970 RVA: 0x00311695 File Offset: 0x0030F895
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D2D3 RID: 53971 RVA: 0x003116A4 File Offset: 0x0030F8A4
		public SimpleCombatDetailConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700362B RID: 13867
		// (get) Token: 0x0600D2D4 RID: 53972 RVA: 0x003116B4 File Offset: 0x0030F8B4
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

		// Token: 0x1700362C RID: 13868
		// (get) Token: 0x0600D2D5 RID: 53973 RVA: 0x003116F0 File Offset: 0x0030F8F0
		public int SimpleCombatId
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

		// Token: 0x1700362D RID: 13869
		// (get) Token: 0x0600D2D6 RID: 53974 RVA: 0x0031172C File Offset: 0x0030F92C
		public int SubTypeId
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

		// Token: 0x1700362E RID: 13870
		// (get) Token: 0x0600D2D7 RID: 53975 RVA: 0x00311768 File Offset: 0x0030F968
		public string PrefabPath
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

		// Token: 0x0600D2D8 RID: 53976 RVA: 0x003117A0 File Offset: 0x0030F9A0
		public Span<byte> GetPrefabPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600D2D9 RID: 53977 RVA: 0x003117B0 File Offset: 0x0030F9B0
		public byte[] GetPrefabPathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700362F RID: 13871
		// (get) Token: 0x0600D2DA RID: 53978 RVA: 0x003117C8 File Offset: 0x0030F9C8
		public string DaPath
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

		// Token: 0x0600D2DB RID: 53979 RVA: 0x00311800 File Offset: 0x0030FA00
		public Span<byte> GetDaPathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600D2DC RID: 53980 RVA: 0x00311810 File Offset: 0x0030FA10
		public byte[] GetDaPathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003630 RID: 13872
		// (get) Token: 0x0600D2DD RID: 53981 RVA: 0x00311828 File Offset: 0x0030FA28
		public int PropertyId
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

		// Token: 0x040051C8 RID: 20936
		private Table __p;
	}
}
