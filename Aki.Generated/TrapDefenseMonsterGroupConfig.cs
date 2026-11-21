using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200129E RID: 4766
	public struct TrapDefenseMonsterGroupConfig : IFlatbufferObject
	{
		// Token: 0x17003FC0 RID: 16320
		// (get) Token: 0x0600F19E RID: 61854 RVA: 0x00364ED9 File Offset: 0x003630D9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F19F RID: 61855 RVA: 0x00364EE6 File Offset: 0x003630E6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F1A0 RID: 61856 RVA: 0x00364EF0 File Offset: 0x003630F0
		public static TrapDefenseMonsterGroupConfig GetRootAsTrapDefenseMonsterGroupConfig(ByteBuffer _bb)
		{
			return TrapDefenseMonsterGroupConfig.GetRootAsTrapDefenseMonsterGroupConfig(_bb, default(TrapDefenseMonsterGroupConfig));
		}

		// Token: 0x0600F1A1 RID: 61857 RVA: 0x00364F0C File Offset: 0x0036310C
		public static TrapDefenseMonsterGroupConfig GetRootAsTrapDefenseMonsterGroupConfig(ByteBuffer _bb, TrapDefenseMonsterGroupConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F1A2 RID: 61858 RVA: 0x00364F29 File Offset: 0x00363129
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F1A3 RID: 61859 RVA: 0x00364F38 File Offset: 0x00363138
		public TrapDefenseMonsterGroupConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003FC1 RID: 16321
		// (get) Token: 0x0600F1A4 RID: 61860 RVA: 0x00364F48 File Offset: 0x00363148
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

		// Token: 0x17003FC2 RID: 16322
		// (get) Token: 0x0600F1A5 RID: 61861 RVA: 0x00364F84 File Offset: 0x00363184
		public string Monsters
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

		// Token: 0x0600F1A6 RID: 61862 RVA: 0x00364FBB File Offset: 0x003631BB
		public Span<byte> GetMonstersBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600F1A7 RID: 61863 RVA: 0x00364FCA File Offset: 0x003631CA
		public byte[] GetMonstersArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x040058F1 RID: 22769
		private Table __p;
	}
}
