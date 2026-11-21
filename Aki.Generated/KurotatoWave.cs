using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E9B RID: 3739
	public struct KurotatoWave : IFlatbufferObject
	{
		// Token: 0x17001CA1 RID: 7329
		// (get) Token: 0x06009204 RID: 37380 RVA: 0x00291988 File Offset: 0x0028FB88
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009205 RID: 37381 RVA: 0x00291995 File Offset: 0x0028FB95
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009206 RID: 37382 RVA: 0x0029199C File Offset: 0x0028FB9C
		public static KurotatoWave GetRootAsKurotatoWave(ByteBuffer _bb)
		{
			return KurotatoWave.GetRootAsKurotatoWave(_bb, default(KurotatoWave));
		}

		// Token: 0x06009207 RID: 37383 RVA: 0x002919B8 File Offset: 0x0028FBB8
		public static KurotatoWave GetRootAsKurotatoWave(ByteBuffer _bb, KurotatoWave obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009208 RID: 37384 RVA: 0x002919D5 File Offset: 0x0028FBD5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009209 RID: 37385 RVA: 0x002919E4 File Offset: 0x0028FBE4
		public KurotatoWave __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001CA2 RID: 7330
		// (get) Token: 0x0600920A RID: 37386 RVA: 0x002919F4 File Offset: 0x0028FBF4
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

		// Token: 0x17001CA3 RID: 7331
		// (get) Token: 0x0600920B RID: 37387 RVA: 0x00291A30 File Offset: 0x0028FC30
		public int Level
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

		// Token: 0x17001CA4 RID: 7332
		// (get) Token: 0x0600920C RID: 37388 RVA: 0x00291A6C File Offset: 0x0028FC6C
		public int Wave
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

		// Token: 0x17001CA5 RID: 7333
		// (get) Token: 0x0600920D RID: 37389 RVA: 0x00291AA8 File Offset: 0x0028FCA8
		public int WaveType
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

		// Token: 0x0600920E RID: 37390 RVA: 0x00291AE8 File Offset: 0x0028FCE8
		public int WaveConditions(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001CA6 RID: 7334
		// (get) Token: 0x0600920F RID: 37391 RVA: 0x00291B28 File Offset: 0x0028FD28
		public int WaveConditionsLength
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

		// Token: 0x06009210 RID: 37392 RVA: 0x00291B54 File Offset: 0x0028FD54
		public Span<int> GetWaveConditionsBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06009211 RID: 37393 RVA: 0x00291B64 File Offset: 0x0028FD64
		public int[] GetWaveConditionsArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17001CA7 RID: 7335
		// (get) Token: 0x06009212 RID: 37394 RVA: 0x00291B7C File Offset: 0x0028FD7C
		public int WaveTime
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

		// Token: 0x06009213 RID: 37395 RVA: 0x00291BBC File Offset: 0x0028FDBC
		public int ConditionSpawnIds(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001CA8 RID: 7336
		// (get) Token: 0x06009214 RID: 37396 RVA: 0x00291BFC File Offset: 0x0028FDFC
		public int ConditionSpawnIdsLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009215 RID: 37397 RVA: 0x00291C28 File Offset: 0x0028FE28
		public Span<int> GetConditionSpawnIdsBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x06009216 RID: 37398 RVA: 0x00291C38 File Offset: 0x0028FE38
		public int[] GetConditionSpawnIdsArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x17001CA9 RID: 7337
		// (get) Token: 0x06009217 RID: 37399 RVA: 0x00291C50 File Offset: 0x0028FE50
		public bool HasEndlessModeSelection
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001CAA RID: 7338
		// (get) Token: 0x06009218 RID: 37400 RVA: 0x00291C90 File Offset: 0x0028FE90
		public bool IsPowerWave
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06009219 RID: 37401 RVA: 0x00291CD0 File Offset: 0x0028FED0
		public int MonsterSpawnGroup(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001CAB RID: 7339
		// (get) Token: 0x0600921A RID: 37402 RVA: 0x00291D10 File Offset: 0x0028FF10
		public int MonsterSpawnGroupLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600921B RID: 37403 RVA: 0x00291D3C File Offset: 0x0028FF3C
		public Span<int> GetMonsterSpawnGroupBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600921C RID: 37404 RVA: 0x00291D4C File Offset: 0x0028FF4C
		public int[] GetMonsterSpawnGroupArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x0600921D RID: 37405 RVA: 0x00291D64 File Offset: 0x0028FF64
		[NullableContext(1)]
		public int[] ConditionSpawnIds()
		{
			return this.GetConditionSpawnIdsArray();
		}

		// Token: 0x0600921E RID: 37406 RVA: 0x00291D6C File Offset: 0x0028FF6C
		[NullableContext(1)]
		public IEnumerable<int> ConditionSpawnIdsIter()
		{
			KurotatoWave.<ConditionSpawnIdsIter>d__38 <ConditionSpawnIdsIter>d__ = new KurotatoWave.<ConditionSpawnIdsIter>d__38(-2);
			<ConditionSpawnIdsIter>d__.<>3__<>4__this = this;
			return <ConditionSpawnIdsIter>d__;
		}

		// Token: 0x0600921F RID: 37407 RVA: 0x00291D81 File Offset: 0x0028FF81
		[NullableContext(1)]
		public int[] MonsterSpawnGroup()
		{
			return this.GetMonsterSpawnGroupArray();
		}

		// Token: 0x06009220 RID: 37408 RVA: 0x00291D89 File Offset: 0x0028FF89
		[NullableContext(1)]
		public IEnumerable<int> MonsterSpawnGroupIter()
		{
			KurotatoWave.<MonsterSpawnGroupIter>d__40 <MonsterSpawnGroupIter>d__ = new KurotatoWave.<MonsterSpawnGroupIter>d__40(-2);
			<MonsterSpawnGroupIter>d__.<>3__<>4__this = this;
			return <MonsterSpawnGroupIter>d__;
		}

		// Token: 0x06009221 RID: 37409 RVA: 0x00291D9E File Offset: 0x0028FF9E
		[NullableContext(1)]
		public int[] WaveConditions()
		{
			return this.GetWaveConditionsArray();
		}

		// Token: 0x06009222 RID: 37410 RVA: 0x00291DA6 File Offset: 0x0028FFA6
		[NullableContext(1)]
		public IEnumerable<int> WaveConditionsIter()
		{
			KurotatoWave.<WaveConditionsIter>d__42 <WaveConditionsIter>d__ = new KurotatoWave.<WaveConditionsIter>d__42(-2);
			<WaveConditionsIter>d__.<>3__<>4__this = this;
			return <WaveConditionsIter>d__;
		}

		// Token: 0x0400542F RID: 21551
		private Table __p;
	}
}
