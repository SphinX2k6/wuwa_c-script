using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010B2 RID: 4274
	public struct RiskHarvestArtifact : IFlatbufferObject
	{
		// Token: 0x17002EF4 RID: 12020
		// (get) Token: 0x0600C369 RID: 50025 RVA: 0x002FCFC5 File Offset: 0x002FB1C5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C36A RID: 50026 RVA: 0x002FCFD2 File Offset: 0x002FB1D2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C36B RID: 50027 RVA: 0x002FCFDC File Offset: 0x002FB1DC
		public static RiskHarvestArtifact GetRootAsRiskHarvestArtifact(ByteBuffer _bb)
		{
			return RiskHarvestArtifact.GetRootAsRiskHarvestArtifact(_bb, default(RiskHarvestArtifact));
		}

		// Token: 0x0600C36C RID: 50028 RVA: 0x002FCFF8 File Offset: 0x002FB1F8
		public static RiskHarvestArtifact GetRootAsRiskHarvestArtifact(ByteBuffer _bb, RiskHarvestArtifact obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C36D RID: 50029 RVA: 0x002FD015 File Offset: 0x002FB215
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C36E RID: 50030 RVA: 0x002FD024 File Offset: 0x002FB224
		public RiskHarvestArtifact __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002EF5 RID: 12021
		// (get) Token: 0x0600C36F RID: 50031 RVA: 0x002FD034 File Offset: 0x002FB234
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

		// Token: 0x0600C370 RID: 50032 RVA: 0x002FD070 File Offset: 0x002FB270
		public int BuffGroup(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002EF6 RID: 12022
		// (get) Token: 0x0600C371 RID: 50033 RVA: 0x002FD0B0 File Offset: 0x002FB2B0
		public int BuffGroupLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600C372 RID: 50034 RVA: 0x002FD0DB File Offset: 0x002FB2DB
		public Span<int> GetBuffGroupBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600C373 RID: 50035 RVA: 0x002FD0EA File Offset: 0x002FB2EA
		public int[] GetBuffGroupArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600C374 RID: 50036 RVA: 0x002FD104 File Offset: 0x002FB304
		public int BasicBuffGroup(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002EF7 RID: 12023
		// (get) Token: 0x0600C375 RID: 50037 RVA: 0x002FD144 File Offset: 0x002FB344
		public int BasicBuffGroupLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600C376 RID: 50038 RVA: 0x002FD16F File Offset: 0x002FB36F
		public Span<int> GetBasicBuffGroupBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600C377 RID: 50039 RVA: 0x002FD17E File Offset: 0x002FB37E
		public int[] GetBasicBuffGroupArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600C378 RID: 50040 RVA: 0x002FD195 File Offset: 0x002FB395
		[NullableContext(1)]
		public int[] BasicBuffGroup()
		{
			return this.GetBasicBuffGroupArray();
		}

		// Token: 0x0600C379 RID: 50041 RVA: 0x002FD19D File Offset: 0x002FB39D
		[NullableContext(1)]
		public IEnumerable<int> BasicBuffGroupIter()
		{
			RiskHarvestArtifact.<BasicBuffGroupIter>d__21 <BasicBuffGroupIter>d__ = new RiskHarvestArtifact.<BasicBuffGroupIter>d__21(-2);
			<BasicBuffGroupIter>d__.<>3__<>4__this = this;
			return <BasicBuffGroupIter>d__;
		}

		// Token: 0x0600C37A RID: 50042 RVA: 0x002FD1B2 File Offset: 0x002FB3B2
		[NullableContext(1)]
		public int[] BuffGroup()
		{
			return this.GetBuffGroupArray();
		}

		// Token: 0x0600C37B RID: 50043 RVA: 0x002FD1BA File Offset: 0x002FB3BA
		[NullableContext(1)]
		public IEnumerable<int> BuffGroupIter()
		{
			RiskHarvestArtifact.<BuffGroupIter>d__23 <BuffGroupIter>d__ = new RiskHarvestArtifact.<BuffGroupIter>d__23(-2);
			<BuffGroupIter>d__.<>3__<>4__this = this;
			return <BuffGroupIter>d__;
		}

		// Token: 0x0400568D RID: 22157
		private Table __p;
	}
}
