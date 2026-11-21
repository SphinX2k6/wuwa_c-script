using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001020 RID: 4128
	public struct PinballWaveConfig : IFlatbufferObject
	{
		// Token: 0x17002A4F RID: 10831
		// (get) Token: 0x0600B69E RID: 46750 RVA: 0x002E1D25 File Offset: 0x002DFF25
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B69F RID: 46751 RVA: 0x002E1D32 File Offset: 0x002DFF32
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B6A0 RID: 46752 RVA: 0x002E1D3C File Offset: 0x002DFF3C
		public static PinballWaveConfig GetRootAsPinballWaveConfig(ByteBuffer _bb)
		{
			return PinballWaveConfig.GetRootAsPinballWaveConfig(_bb, default(PinballWaveConfig));
		}

		// Token: 0x0600B6A1 RID: 46753 RVA: 0x002E1D58 File Offset: 0x002DFF58
		public static PinballWaveConfig GetRootAsPinballWaveConfig(ByteBuffer _bb, PinballWaveConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B6A2 RID: 46754 RVA: 0x002E1D75 File Offset: 0x002DFF75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B6A3 RID: 46755 RVA: 0x002E1D84 File Offset: 0x002DFF84
		public PinballWaveConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002A50 RID: 10832
		// (get) Token: 0x0600B6A4 RID: 46756 RVA: 0x002E1D94 File Offset: 0x002DFF94
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

		// Token: 0x17002A51 RID: 10833
		// (get) Token: 0x0600B6A5 RID: 46757 RVA: 0x002E1DD0 File Offset: 0x002DFFD0
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

		// Token: 0x17002A52 RID: 10834
		// (get) Token: 0x0600B6A6 RID: 46758 RVA: 0x002E1E0C File Offset: 0x002E000C
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

		// Token: 0x17002A53 RID: 10835
		// (get) Token: 0x0600B6A7 RID: 46759 RVA: 0x002E1E48 File Offset: 0x002E0048
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

		// Token: 0x17002A54 RID: 10836
		// (get) Token: 0x0600B6A8 RID: 46760 RVA: 0x002E1E88 File Offset: 0x002E0088
		public int WaveCondition
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

		// Token: 0x0600B6A9 RID: 46761 RVA: 0x002E1EC8 File Offset: 0x002E00C8
		public int ConditionSpawnIds(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002A55 RID: 10837
		// (get) Token: 0x0600B6AA RID: 46762 RVA: 0x002E1F08 File Offset: 0x002E0108
		public int ConditionSpawnIdsLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600B6AB RID: 46763 RVA: 0x002E1F34 File Offset: 0x002E0134
		public Span<int> GetConditionSpawnIdsBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600B6AC RID: 46764 RVA: 0x002E1F44 File Offset: 0x002E0144
		public int[] GetConditionSpawnIdsArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x0600B6AD RID: 46765 RVA: 0x002E1F5C File Offset: 0x002E015C
		public int MonsterSpawnGroup(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002A56 RID: 10838
		// (get) Token: 0x0600B6AE RID: 46766 RVA: 0x002E1F9C File Offset: 0x002E019C
		public int MonsterSpawnGroupLength
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

		// Token: 0x0600B6AF RID: 46767 RVA: 0x002E1FC8 File Offset: 0x002E01C8
		public Span<int> GetMonsterSpawnGroupBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600B6B0 RID: 46768 RVA: 0x002E1FD8 File Offset: 0x002E01D8
		public int[] GetMonsterSpawnGroupArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x0600B6B1 RID: 46769 RVA: 0x002E1FF0 File Offset: 0x002E01F0
		[NullableContext(1)]
		public int[] ConditionSpawnIds()
		{
			return this.GetConditionSpawnIdsArray();
		}

		// Token: 0x0600B6B2 RID: 46770 RVA: 0x002E1FF8 File Offset: 0x002E01F8
		[NullableContext(1)]
		public IEnumerable<int> ConditionSpawnIdsIter()
		{
			PinballWaveConfig.<ConditionSpawnIdsIter>d__29 <ConditionSpawnIdsIter>d__ = new PinballWaveConfig.<ConditionSpawnIdsIter>d__29(-2);
			<ConditionSpawnIdsIter>d__.<>3__<>4__this = this;
			return <ConditionSpawnIdsIter>d__;
		}

		// Token: 0x0600B6B3 RID: 46771 RVA: 0x002E200D File Offset: 0x002E020D
		[NullableContext(1)]
		public int[] MonsterSpawnGroup()
		{
			return this.GetMonsterSpawnGroupArray();
		}

		// Token: 0x0600B6B4 RID: 46772 RVA: 0x002E2015 File Offset: 0x002E0215
		[NullableContext(1)]
		public IEnumerable<int> MonsterSpawnGroupIter()
		{
			PinballWaveConfig.<MonsterSpawnGroupIter>d__31 <MonsterSpawnGroupIter>d__ = new PinballWaveConfig.<MonsterSpawnGroupIter>d__31(-2);
			<MonsterSpawnGroupIter>d__.<>3__<>4__this = this;
			return <MonsterSpawnGroupIter>d__;
		}

		// Token: 0x040055EA RID: 21994
		private Table __p;
	}
}
