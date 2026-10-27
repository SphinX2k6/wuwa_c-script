using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FCA RID: 4042
	public struct RiskHarvestArtifact : IFlatbufferObject
	{
		// Token: 0x17002E79 RID: 11897
		// (get) Token: 0x0600BD1F RID: 48415 RVA: 0x002E097D File Offset: 0x002DEB7D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BD20 RID: 48416 RVA: 0x002E098A File Offset: 0x002DEB8A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BD21 RID: 48417 RVA: 0x002E0994 File Offset: 0x002DEB94
		public static RiskHarvestArtifact GetRootAsRiskHarvestArtifact(ByteBuffer _bb)
		{
			return RiskHarvestArtifact.GetRootAsRiskHarvestArtifact(_bb, default(RiskHarvestArtifact));
		}

		// Token: 0x0600BD22 RID: 48418 RVA: 0x002E09B0 File Offset: 0x002DEBB0
		public static RiskHarvestArtifact GetRootAsRiskHarvestArtifact(ByteBuffer _bb, RiskHarvestArtifact obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BD23 RID: 48419 RVA: 0x002E09CD File Offset: 0x002DEBCD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BD24 RID: 48420 RVA: 0x002E09DC File Offset: 0x002DEBDC
		public RiskHarvestArtifact __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002E7A RID: 11898
		// (get) Token: 0x0600BD25 RID: 48421 RVA: 0x002E09EC File Offset: 0x002DEBEC
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

		// Token: 0x0600BD26 RID: 48422 RVA: 0x002E0A28 File Offset: 0x002DEC28
		public int BuffGroup(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002E7B RID: 11899
		// (get) Token: 0x0600BD27 RID: 48423 RVA: 0x002E0A68 File Offset: 0x002DEC68
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

		// Token: 0x0600BD28 RID: 48424 RVA: 0x002E0A93 File Offset: 0x002DEC93
		public Span<int> GetBuffGroupBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600BD29 RID: 48425 RVA: 0x002E0AA2 File Offset: 0x002DECA2
		public int[] GetBuffGroupArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600BD2A RID: 48426 RVA: 0x002E0ABC File Offset: 0x002DECBC
		public int BasicBuffGroup(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002E7C RID: 11900
		// (get) Token: 0x0600BD2B RID: 48427 RVA: 0x002E0AFC File Offset: 0x002DECFC
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

		// Token: 0x0600BD2C RID: 48428 RVA: 0x002E0B27 File Offset: 0x002DED27
		public Span<int> GetBasicBuffGroupBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600BD2D RID: 48429 RVA: 0x002E0B36 File Offset: 0x002DED36
		public int[] GetBasicBuffGroupArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600BD2E RID: 48430 RVA: 0x002E0B50 File Offset: 0x002DED50
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BasicBuffGroupIter()或GetBasicBuffGroupBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] BasicBuffGroup()
		{
			RiskHarvestArtifact riskHarvestArtifact = this;
			return riskHarvestArtifact.GetBasicBuffGroupArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600BD2F RID: 48431 RVA: 0x002E0B74 File Offset: 0x002DED74
		[NullableContext(1)]
		public readonly IEnumerable<int> BasicBuffGroupIter()
		{
			RiskHarvestArtifact.<BasicBuffGroupIter>d__21 <BasicBuffGroupIter>d__ = new RiskHarvestArtifact.<BasicBuffGroupIter>d__21(-2);
			<BasicBuffGroupIter>d__.<>3__<>4__this = this;
			return <BasicBuffGroupIter>d__;
		}

		// Token: 0x0600BD30 RID: 48432 RVA: 0x002E0B8C File Offset: 0x002DED8C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BuffGroupIter()或GetBuffGroupBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] BuffGroup()
		{
			RiskHarvestArtifact riskHarvestArtifact = this;
			return riskHarvestArtifact.GetBuffGroupArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600BD31 RID: 48433 RVA: 0x002E0BB0 File Offset: 0x002DEDB0
		[NullableContext(1)]
		public readonly IEnumerable<int> BuffGroupIter()
		{
			RiskHarvestArtifact.<BuffGroupIter>d__23 <BuffGroupIter>d__ = new RiskHarvestArtifact.<BuffGroupIter>d__23(-2);
			<BuffGroupIter>d__.<>3__<>4__this = this;
			return <BuffGroupIter>d__;
		}

		// Token: 0x040050A5 RID: 20645
		private Table __p;
	}
}
