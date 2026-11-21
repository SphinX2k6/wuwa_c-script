using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011D3 RID: 4563
	public struct SolarSchoolAffairsOption : IFlatbufferObject
	{
		// Token: 0x170038AB RID: 14507
		// (get) Token: 0x0600DF2B RID: 57131 RVA: 0x0033BAC1 File Offset: 0x00339CC1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DF2C RID: 57132 RVA: 0x0033BACE File Offset: 0x00339CCE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DF2D RID: 57133 RVA: 0x0033BAD8 File Offset: 0x00339CD8
		public static SolarSchoolAffairsOption GetRootAsSolarSchoolAffairsOption(ByteBuffer _bb)
		{
			return SolarSchoolAffairsOption.GetRootAsSolarSchoolAffairsOption(_bb, default(SolarSchoolAffairsOption));
		}

		// Token: 0x0600DF2E RID: 57134 RVA: 0x0033BAF4 File Offset: 0x00339CF4
		public static SolarSchoolAffairsOption GetRootAsSolarSchoolAffairsOption(ByteBuffer _bb, SolarSchoolAffairsOption obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DF2F RID: 57135 RVA: 0x0033BB11 File Offset: 0x00339D11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DF30 RID: 57136 RVA: 0x0033BB20 File Offset: 0x00339D20
		public SolarSchoolAffairsOption __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170038AC RID: 14508
		// (get) Token: 0x0600DF31 RID: 57137 RVA: 0x0033BB30 File Offset: 0x00339D30
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

		// Token: 0x170038AD RID: 14509
		// (get) Token: 0x0600DF32 RID: 57138 RVA: 0x0033BB6C File Offset: 0x00339D6C
		public int GroupId
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

		// Token: 0x170038AE RID: 14510
		// (get) Token: 0x0600DF33 RID: 57139 RVA: 0x0033BBA8 File Offset: 0x00339DA8
		public string DescKey
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

		// Token: 0x0600DF34 RID: 57140 RVA: 0x0033BBDF File Offset: 0x00339DDF
		public Span<byte> GetDescKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600DF35 RID: 57141 RVA: 0x0033BBEE File Offset: 0x00339DEE
		public byte[] GetDescKeyArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170038AF RID: 14511
		// (get) Token: 0x0600DF36 RID: 57142 RVA: 0x0033BC08 File Offset: 0x00339E08
		public int Reward
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

		// Token: 0x0400580A RID: 22538
		private Table __p;
	}
}
