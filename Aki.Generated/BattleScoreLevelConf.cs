using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C0E RID: 3086
	public struct BattleScoreLevelConf : IFlatbufferObject
	{
		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06005293 RID: 21139 RVA: 0x00202CBC File Offset: 0x00200EBC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005294 RID: 21140 RVA: 0x00202CC9 File Offset: 0x00200EC9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005295 RID: 21141 RVA: 0x00202CD0 File Offset: 0x00200ED0
		public static BattleScoreLevelConf GetRootAsBattleScoreLevelConf(ByteBuffer _bb)
		{
			return BattleScoreLevelConf.GetRootAsBattleScoreLevelConf(_bb, default(BattleScoreLevelConf));
		}

		// Token: 0x06005296 RID: 21142 RVA: 0x00202CEC File Offset: 0x00200EEC
		public static BattleScoreLevelConf GetRootAsBattleScoreLevelConf(ByteBuffer _bb, BattleScoreLevelConf obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005297 RID: 21143 RVA: 0x00202D09 File Offset: 0x00200F09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005298 RID: 21144 RVA: 0x00202D18 File Offset: 0x00200F18
		public BattleScoreLevelConf __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06005299 RID: 21145 RVA: 0x00202D28 File Offset: 0x00200F28
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

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x0600529A RID: 21146 RVA: 0x00202D64 File Offset: 0x00200F64
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

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x0600529B RID: 21147 RVA: 0x00202DA0 File Offset: 0x00200FA0
		public int Level
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

		// Token: 0x0600529C RID: 21148 RVA: 0x00202DDC File Offset: 0x00200FDC
		public int LowerUpperLimits(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x0600529D RID: 21149 RVA: 0x00202E1C File Offset: 0x0020101C
		public int LowerUpperLimitsLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600529E RID: 21150 RVA: 0x00202E48 File Offset: 0x00201048
		public Span<int> GetLowerUpperLimitsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600529F RID: 21151 RVA: 0x00202E58 File Offset: 0x00201058
		public int[] GetLowerUpperLimitsArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x060052A0 RID: 21152 RVA: 0x00202E70 File Offset: 0x00201070
		public int BuffTime
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x060052A1 RID: 21153 RVA: 0x00202EB0 File Offset: 0x002010B0
		public string Bgm
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060052A2 RID: 21154 RVA: 0x00202EE8 File Offset: 0x002010E8
		public Span<byte> GetBgmBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060052A3 RID: 21155 RVA: 0x00202EF8 File Offset: 0x002010F8
		public byte[] GetBgmArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x060052A4 RID: 21156 RVA: 0x00202F10 File Offset: 0x00201110
		[NullableContext(1)]
		public int[] LowerUpperLimits()
		{
			return this.GetLowerUpperLimitsArray();
		}

		// Token: 0x060052A5 RID: 21157 RVA: 0x00202F18 File Offset: 0x00201118
		[NullableContext(1)]
		public IEnumerable<int> LowerUpperLimitsIter()
		{
			BattleScoreLevelConf.<LowerUpperLimitsIter>d__26 <LowerUpperLimitsIter>d__ = new BattleScoreLevelConf.<LowerUpperLimitsIter>d__26(-2);
			<LowerUpperLimitsIter>d__.<>3__<>4__this = this;
			return <LowerUpperLimitsIter>d__;
		}

		// Token: 0x04005106 RID: 20742
		private Table __p;
	}
}
