using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001157 RID: 4439
	public struct TrapDefenseBatchConfig : IFlatbufferObject
	{
		// Token: 0x17003BC7 RID: 15303
		// (get) Token: 0x0600E278 RID: 57976 RVA: 0x00336301 File Offset: 0x00334501
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E279 RID: 57977 RVA: 0x0033630E File Offset: 0x0033450E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E27A RID: 57978 RVA: 0x00336318 File Offset: 0x00334518
		public static TrapDefenseBatchConfig GetRootAsTrapDefenseBatchConfig(ByteBuffer _bb)
		{
			return TrapDefenseBatchConfig.GetRootAsTrapDefenseBatchConfig(_bb, default(TrapDefenseBatchConfig));
		}

		// Token: 0x0600E27B RID: 57979 RVA: 0x00336334 File Offset: 0x00334534
		public static TrapDefenseBatchConfig GetRootAsTrapDefenseBatchConfig(ByteBuffer _bb, TrapDefenseBatchConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E27C RID: 57980 RVA: 0x00336351 File Offset: 0x00334551
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E27D RID: 57981 RVA: 0x00336360 File Offset: 0x00334560
		public TrapDefenseBatchConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003BC8 RID: 15304
		// (get) Token: 0x0600E27E RID: 57982 RVA: 0x00336370 File Offset: 0x00334570
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

		// Token: 0x17003BC9 RID: 15305
		// (get) Token: 0x0600E27F RID: 57983 RVA: 0x003363AC File Offset: 0x003345AC
		public string SpawnMonsters
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

		// Token: 0x0600E280 RID: 57984 RVA: 0x003363E3 File Offset: 0x003345E3
		public Span<byte> GetSpawnMonstersBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E281 RID: 57985 RVA: 0x003363F2 File Offset: 0x003345F2
		public byte[] GetSpawnMonstersArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003BCA RID: 15306
		// (get) Token: 0x0600E282 RID: 57986 RVA: 0x0033640C File Offset: 0x0033460C
		public string Splines
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

		// Token: 0x0600E283 RID: 57987 RVA: 0x00336443 File Offset: 0x00334643
		public Span<byte> GetSplinesBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600E284 RID: 57988 RVA: 0x00336452 File Offset: 0x00334652
		public byte[] GetSplinesArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0400529C RID: 21148
		private Table __p;
	}
}
