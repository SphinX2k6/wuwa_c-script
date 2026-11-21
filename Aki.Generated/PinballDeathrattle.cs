using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200100F RID: 4111
	public struct PinballDeathrattle : IFlatbufferObject
	{
		// Token: 0x1700299E RID: 10654
		// (get) Token: 0x0600B4D6 RID: 46294 RVA: 0x002DDEA1 File Offset: 0x002DC0A1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B4D7 RID: 46295 RVA: 0x002DDEAE File Offset: 0x002DC0AE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B4D8 RID: 46296 RVA: 0x002DDEB8 File Offset: 0x002DC0B8
		public static PinballDeathrattle GetRootAsPinballDeathrattle(ByteBuffer _bb)
		{
			return PinballDeathrattle.GetRootAsPinballDeathrattle(_bb, default(PinballDeathrattle));
		}

		// Token: 0x0600B4D9 RID: 46297 RVA: 0x002DDED4 File Offset: 0x002DC0D4
		public static PinballDeathrattle GetRootAsPinballDeathrattle(ByteBuffer _bb, PinballDeathrattle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B4DA RID: 46298 RVA: 0x002DDEF1 File Offset: 0x002DC0F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B4DB RID: 46299 RVA: 0x002DDF00 File Offset: 0x002DC100
		public PinballDeathrattle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700299F RID: 10655
		// (get) Token: 0x0600B4DC RID: 46300 RVA: 0x002DDF10 File Offset: 0x002DC110
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

		// Token: 0x170029A0 RID: 10656
		// (get) Token: 0x0600B4DD RID: 46301 RVA: 0x002DDF4C File Offset: 0x002DC14C
		public int Type
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B4DE RID: 46302 RVA: 0x002DDF88 File Offset: 0x002DC188
		public int SpawnDrops(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170029A1 RID: 10657
		// (get) Token: 0x0600B4DF RID: 46303 RVA: 0x002DDFC8 File Offset: 0x002DC1C8
		public int SpawnDropsLength
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

		// Token: 0x0600B4E0 RID: 46304 RVA: 0x002DDFF3 File Offset: 0x002DC1F3
		public Span<int> GetSpawnDropsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600B4E1 RID: 46305 RVA: 0x002DE002 File Offset: 0x002DC202
		public int[] GetSpawnDropsArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600B4E2 RID: 46306 RVA: 0x002DE01C File Offset: 0x002DC21C
		public int SpawnDropWeights(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170029A2 RID: 10658
		// (get) Token: 0x0600B4E3 RID: 46307 RVA: 0x002DE05C File Offset: 0x002DC25C
		public int SpawnDropWeightsLength
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

		// Token: 0x0600B4E4 RID: 46308 RVA: 0x002DE088 File Offset: 0x002DC288
		public Span<int> GetSpawnDropWeightsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600B4E5 RID: 46309 RVA: 0x002DE098 File Offset: 0x002DC298
		public int[] GetSpawnDropWeightsArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x0600B4E6 RID: 46310 RVA: 0x002DE0B0 File Offset: 0x002DC2B0
		public int BuffIdList(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170029A3 RID: 10659
		// (get) Token: 0x0600B4E7 RID: 46311 RVA: 0x002DE0F0 File Offset: 0x002DC2F0
		public int BuffIdListLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600B4E8 RID: 46312 RVA: 0x002DE11C File Offset: 0x002DC31C
		public Span<int> GetBuffIdListBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600B4E9 RID: 46313 RVA: 0x002DE12C File Offset: 0x002DC32C
		public int[] GetBuffIdListArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x0600B4EA RID: 46314 RVA: 0x002DE144 File Offset: 0x002DC344
		[NullableContext(1)]
		public int[] BuffIdList()
		{
			return this.GetBuffIdListArray();
		}

		// Token: 0x0600B4EB RID: 46315 RVA: 0x002DE14C File Offset: 0x002DC34C
		[NullableContext(1)]
		public IEnumerable<int> BuffIdListIter()
		{
			PinballDeathrattle.<BuffIdListIter>d__28 <BuffIdListIter>d__ = new PinballDeathrattle.<BuffIdListIter>d__28(-2);
			<BuffIdListIter>d__.<>3__<>4__this = this;
			return <BuffIdListIter>d__;
		}

		// Token: 0x0600B4EC RID: 46316 RVA: 0x002DE161 File Offset: 0x002DC361
		[NullableContext(1)]
		public int[] SpawnDropWeights()
		{
			return this.GetSpawnDropWeightsArray();
		}

		// Token: 0x0600B4ED RID: 46317 RVA: 0x002DE169 File Offset: 0x002DC369
		[NullableContext(1)]
		public IEnumerable<int> SpawnDropWeightsIter()
		{
			PinballDeathrattle.<SpawnDropWeightsIter>d__30 <SpawnDropWeightsIter>d__ = new PinballDeathrattle.<SpawnDropWeightsIter>d__30(-2);
			<SpawnDropWeightsIter>d__.<>3__<>4__this = this;
			return <SpawnDropWeightsIter>d__;
		}

		// Token: 0x0600B4EE RID: 46318 RVA: 0x002DE17E File Offset: 0x002DC37E
		[NullableContext(1)]
		public int[] SpawnDrops()
		{
			return this.GetSpawnDropsArray();
		}

		// Token: 0x0600B4EF RID: 46319 RVA: 0x002DE186 File Offset: 0x002DC386
		[NullableContext(1)]
		public IEnumerable<int> SpawnDropsIter()
		{
			PinballDeathrattle.<SpawnDropsIter>d__32 <SpawnDropsIter>d__ = new PinballDeathrattle.<SpawnDropsIter>d__32(-2);
			<SpawnDropsIter>d__.<>3__<>4__this = this;
			return <SpawnDropsIter>d__;
		}

		// Token: 0x040055D8 RID: 21976
		private Table __p;
	}
}
