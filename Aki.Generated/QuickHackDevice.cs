using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001068 RID: 4200
	public struct QuickHackDevice : IFlatbufferObject
	{
		// Token: 0x17002CCC RID: 11468
		// (get) Token: 0x0600BD95 RID: 48533 RVA: 0x002F0205 File Offset: 0x002EE405
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BD96 RID: 48534 RVA: 0x002F0212 File Offset: 0x002EE412
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BD97 RID: 48535 RVA: 0x002F021C File Offset: 0x002EE41C
		public static QuickHackDevice GetRootAsQuickHackDevice(ByteBuffer _bb)
		{
			return QuickHackDevice.GetRootAsQuickHackDevice(_bb, default(QuickHackDevice));
		}

		// Token: 0x0600BD98 RID: 48536 RVA: 0x002F0238 File Offset: 0x002EE438
		public static QuickHackDevice GetRootAsQuickHackDevice(ByteBuffer _bb, QuickHackDevice obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BD99 RID: 48537 RVA: 0x002F0255 File Offset: 0x002EE455
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BD9A RID: 48538 RVA: 0x002F0264 File Offset: 0x002EE464
		public QuickHackDevice __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002CCD RID: 11469
		// (get) Token: 0x0600BD9B RID: 48539 RVA: 0x002F0274 File Offset: 0x002EE474
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

		// Token: 0x0600BD9C RID: 48540 RVA: 0x002F02B0 File Offset: 0x002EE4B0
		public int SkillIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002CCE RID: 11470
		// (get) Token: 0x0600BD9D RID: 48541 RVA: 0x002F02F0 File Offset: 0x002EE4F0
		public int SkillIdsLength
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

		// Token: 0x0600BD9E RID: 48542 RVA: 0x002F031B File Offset: 0x002EE51B
		public Span<int> GetSkillIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600BD9F RID: 48543 RVA: 0x002F032A File Offset: 0x002EE52A
		public int[] GetSkillIdsArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x17002CCF RID: 11471
		// (get) Token: 0x0600BDA0 RID: 48544 RVA: 0x002F0344 File Offset: 0x002EE544
		public bool RefreshSkillListByTarget
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002CD0 RID: 11472
		// (get) Token: 0x0600BDA1 RID: 48545 RVA: 0x002F0384 File Offset: 0x002EE584
		public int TargetSelectType
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

		// Token: 0x17002CD1 RID: 11473
		// (get) Token: 0x0600BDA2 RID: 48546 RVA: 0x002F03C4 File Offset: 0x002EE5C4
		public int TargetSelectMaxDistance
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 2000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002CD2 RID: 11474
		// (get) Token: 0x0600BDA3 RID: 48547 RVA: 0x002F0408 File Offset: 0x002EE608
		public int TargetScreenRadius
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return -1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BDA4 RID: 48548 RVA: 0x002F0448 File Offset: 0x002EE648
		public long OnScreenTargetGameplayCueIds(int j)
		{
			int num = this.__p.__offset(16);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17002CD3 RID: 11475
		// (get) Token: 0x0600BDA5 RID: 48549 RVA: 0x002F0494 File Offset: 0x002EE694
		public int OnScreenTargetGameplayCueIdsLength
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

		// Token: 0x0600BDA6 RID: 48550 RVA: 0x002F04C0 File Offset: 0x002EE6C0
		public Span<long> GetOnScreenTargetGameplayCueIdsBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(16, 8));
		}

		// Token: 0x0600BDA7 RID: 48551 RVA: 0x002F04D5 File Offset: 0x002EE6D5
		public long[] GetOnScreenTargetGameplayCueIdsArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(16) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x0600BDA8 RID: 48552 RVA: 0x002F0514 File Offset: 0x002EE714
		public long TargetGameplayCueIds(int j)
		{
			int num = this.__p.__offset(18);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17002CD4 RID: 11476
		// (get) Token: 0x0600BDA9 RID: 48553 RVA: 0x002F0560 File Offset: 0x002EE760
		public int TargetGameplayCueIdsLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600BDAA RID: 48554 RVA: 0x002F058C File Offset: 0x002EE78C
		public Span<long> GetTargetGameplayCueIdsBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(18, 8));
		}

		// Token: 0x0600BDAB RID: 48555 RVA: 0x002F05A1 File Offset: 0x002EE7A1
		public long[] GetTargetGameplayCueIdsArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(18) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x17002CD5 RID: 11477
		// (get) Token: 0x0600BDAC RID: 48556 RVA: 0x002F05E0 File Offset: 0x002EE7E0
		public string OnScreenTargetTag
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BDAD RID: 48557 RVA: 0x002F0618 File Offset: 0x002EE818
		public Span<byte> GetOnScreenTargetTagBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600BDAE RID: 48558 RVA: 0x002F0628 File Offset: 0x002EE828
		public byte[] GetOnScreenTargetTagArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002CD6 RID: 11478
		// (get) Token: 0x0600BDAF RID: 48559 RVA: 0x002F0640 File Offset: 0x002EE840
		public string SelectTargetTag
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BDB0 RID: 48560 RVA: 0x002F0678 File Offset: 0x002EE878
		public Span<byte> GetSelectTargetTagBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600BDB1 RID: 48561 RVA: 0x002F0688 File Offset: 0x002EE888
		public byte[] GetSelectTargetTagArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17002CD7 RID: 11479
		// (get) Token: 0x0600BDB2 RID: 48562 RVA: 0x002F06A0 File Offset: 0x002EE8A0
		public int RamResourceType
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002CD8 RID: 11480
		// (get) Token: 0x0600BDB3 RID: 48563 RVA: 0x002F06E0 File Offset: 0x002EE8E0
		public int RamResourceParam
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002CD9 RID: 11481
		// (get) Token: 0x0600BDB4 RID: 48564 RVA: 0x002F0720 File Offset: 0x002EE920
		public int TimeScaleMode
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002CDA RID: 11482
		// (get) Token: 0x0600BDB5 RID: 48565 RVA: 0x002F0760 File Offset: 0x002EE960
		public int TimeScaleDuration
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return -1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002CDB RID: 11483
		// (get) Token: 0x0600BDB6 RID: 48566 RVA: 0x002F07A0 File Offset: 0x002EE9A0
		public float TimeDilation
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002CDC RID: 11484
		// (get) Token: 0x0600BDB7 RID: 48567 RVA: 0x002F07E4 File Offset: 0x002EE9E4
		public bool FirstPersonCamera
		{
			get
			{
				int num = this.__p.__offset(34);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002CDD RID: 11485
		// (get) Token: 0x0600BDB8 RID: 48568 RVA: 0x002F0824 File Offset: 0x002EEA24
		public int DurationLimit
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002CDE RID: 11486
		// (get) Token: 0x0600BDB9 RID: 48569 RVA: 0x002F0864 File Offset: 0x002EEA64
		public int UiType
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002CDF RID: 11487
		// (get) Token: 0x0600BDBA RID: 48570 RVA: 0x002F08A4 File Offset: 0x002EEAA4
		public int SkillEffectiveTargetSize
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return -1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002CE0 RID: 11488
		// (get) Token: 0x0600BDBB RID: 48571 RVA: 0x002F08E4 File Offset: 0x002EEAE4
		public bool UseTargetHighlightCondition
		{
			get
			{
				int num = this.__p.__offset(42);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002CE1 RID: 11489
		// (get) Token: 0x0600BDBC RID: 48572 RVA: 0x002F0924 File Offset: 0x002EEB24
		public bool OpenMonsterHackMark
		{
			get
			{
				int num = this.__p.__offset(44);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600BDBD RID: 48573 RVA: 0x002F0964 File Offset: 0x002EEB64
		[NullableContext(1)]
		public long[] OnScreenTargetGameplayCueIds()
		{
			return this.GetOnScreenTargetGameplayCueIdsArray();
		}

		// Token: 0x0600BDBE RID: 48574 RVA: 0x002F096C File Offset: 0x002EEB6C
		[NullableContext(1)]
		public IEnumerable<long> OnScreenTargetGameplayCueIdsIter()
		{
			QuickHackDevice.<OnScreenTargetGameplayCueIdsIter>d__64 <OnScreenTargetGameplayCueIdsIter>d__ = new QuickHackDevice.<OnScreenTargetGameplayCueIdsIter>d__64(-2);
			<OnScreenTargetGameplayCueIdsIter>d__.<>3__<>4__this = this;
			return <OnScreenTargetGameplayCueIdsIter>d__;
		}

		// Token: 0x0600BDBF RID: 48575 RVA: 0x002F0981 File Offset: 0x002EEB81
		[NullableContext(1)]
		public int[] SkillIds()
		{
			return this.GetSkillIdsArray();
		}

		// Token: 0x0600BDC0 RID: 48576 RVA: 0x002F0989 File Offset: 0x002EEB89
		[NullableContext(1)]
		public IEnumerable<int> SkillIdsIter()
		{
			QuickHackDevice.<SkillIdsIter>d__66 <SkillIdsIter>d__ = new QuickHackDevice.<SkillIdsIter>d__66(-2);
			<SkillIdsIter>d__.<>3__<>4__this = this;
			return <SkillIdsIter>d__;
		}

		// Token: 0x0600BDC1 RID: 48577 RVA: 0x002F099E File Offset: 0x002EEB9E
		[NullableContext(1)]
		public long[] TargetGameplayCueIds()
		{
			return this.GetTargetGameplayCueIdsArray();
		}

		// Token: 0x0600BDC2 RID: 48578 RVA: 0x002F09A6 File Offset: 0x002EEBA6
		[NullableContext(1)]
		public IEnumerable<long> TargetGameplayCueIdsIter()
		{
			QuickHackDevice.<TargetGameplayCueIdsIter>d__68 <TargetGameplayCueIdsIter>d__ = new QuickHackDevice.<TargetGameplayCueIdsIter>d__68(-2);
			<TargetGameplayCueIdsIter>d__.<>3__<>4__this = this;
			return <TargetGameplayCueIdsIter>d__;
		}

		// Token: 0x04005636 RID: 22070
		private Table __p;
	}
}
