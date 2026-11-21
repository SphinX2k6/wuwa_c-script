using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001243 RID: 4675
	public struct SurvivorsWeaponEvolve : IFlatbufferObject
	{
		// Token: 0x17003CC2 RID: 15554
		// (get) Token: 0x0600E987 RID: 59783 RVA: 0x003531B0 File Offset: 0x003513B0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E988 RID: 59784 RVA: 0x003531BD File Offset: 0x003513BD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E989 RID: 59785 RVA: 0x003531C4 File Offset: 0x003513C4
		public static SurvivorsWeaponEvolve GetRootAsSurvivorsWeaponEvolve(ByteBuffer _bb)
		{
			return SurvivorsWeaponEvolve.GetRootAsSurvivorsWeaponEvolve(_bb, default(SurvivorsWeaponEvolve));
		}

		// Token: 0x0600E98A RID: 59786 RVA: 0x003531E0 File Offset: 0x003513E0
		public static SurvivorsWeaponEvolve GetRootAsSurvivorsWeaponEvolve(ByteBuffer _bb, SurvivorsWeaponEvolve obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E98B RID: 59787 RVA: 0x003531FD File Offset: 0x003513FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E98C RID: 59788 RVA: 0x0035320C File Offset: 0x0035140C
		public SurvivorsWeaponEvolve __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003CC3 RID: 15555
		// (get) Token: 0x0600E98D RID: 59789 RVA: 0x0035321C File Offset: 0x0035141C
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

		// Token: 0x17003CC4 RID: 15556
		// (get) Token: 0x0600E98E RID: 59790 RVA: 0x00353258 File Offset: 0x00351458
		public int WeaponId
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

		// Token: 0x17003CC5 RID: 15557
		// (get) Token: 0x0600E98F RID: 59791 RVA: 0x00353294 File Offset: 0x00351494
		public int Quality
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

		// Token: 0x17003CC6 RID: 15558
		// (get) Token: 0x0600E990 RID: 59792 RVA: 0x003532D0 File Offset: 0x003514D0
		public int ConditionType
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

		// Token: 0x0600E991 RID: 59793 RVA: 0x00353310 File Offset: 0x00351510
		public DicIntInt? ConditionArgs(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003CC7 RID: 15559
		// (get) Token: 0x0600E992 RID: 59794 RVA: 0x00353374 File Offset: 0x00351574
		public int ConditionArgsLength
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

		// Token: 0x17003CC8 RID: 15560
		// (get) Token: 0x0600E993 RID: 59795 RVA: 0x003533A0 File Offset: 0x003515A0
		public string EvolveName
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

		// Token: 0x0600E994 RID: 59796 RVA: 0x003533D8 File Offset: 0x003515D8
		public Span<byte> GetEvolveNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600E995 RID: 59797 RVA: 0x003533E8 File Offset: 0x003515E8
		public byte[] GetEvolveNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x0600E996 RID: 59798 RVA: 0x00353400 File Offset: 0x00351600
		public string UnlockDesc(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003CC9 RID: 15561
		// (get) Token: 0x0600E997 RID: 59799 RVA: 0x0035343C File Offset: 0x0035163C
		public int UnlockDescLength
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

		// Token: 0x17003CCA RID: 15562
		// (get) Token: 0x0600E998 RID: 59800 RVA: 0x00353468 File Offset: 0x00351668
		public string Describe
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E999 RID: 59801 RVA: 0x003534A0 File Offset: 0x003516A0
		public Span<byte> GetDescribeBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600E99A RID: 59802 RVA: 0x003534B0 File Offset: 0x003516B0
		public byte[] GetDescribeArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0600E99B RID: 59803 RVA: 0x003534C8 File Offset: 0x003516C8
		[NullableContext(1)]
		public Dictionary<int, int> ConditionArgs()
		{
			return this.ConditionArgsIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600E99C RID: 59804 RVA: 0x0035351E File Offset: 0x0035171E
		[NullableContext(1)]
		public IEnumerable<DicIntInt> ConditionArgsIter()
		{
			SurvivorsWeaponEvolve.<ConditionArgsIter>d__31 <ConditionArgsIter>d__ = new SurvivorsWeaponEvolve.<ConditionArgsIter>d__31(-2);
			<ConditionArgsIter>d__.<>3__<>4__this = this;
			return <ConditionArgsIter>d__;
		}

		// Token: 0x0600E99D RID: 59805 RVA: 0x00353533 File Offset: 0x00351733
		[NullableContext(1)]
		public string[] UnlockDesc()
		{
			return this.UnlockDescIter().ToArray<string>();
		}

		// Token: 0x0600E99E RID: 59806 RVA: 0x00353540 File Offset: 0x00351740
		[NullableContext(1)]
		public IEnumerable<string> UnlockDescIter()
		{
			SurvivorsWeaponEvolve.<UnlockDescIter>d__33 <UnlockDescIter>d__ = new SurvivorsWeaponEvolve.<UnlockDescIter>d__33(-2);
			<UnlockDescIter>d__.<>3__<>4__this = this;
			return <UnlockDescIter>d__;
		}

		// Token: 0x0600E99F RID: 59807 RVA: 0x00353558 File Offset: 0x00351758
		public int? GetConditionArgs(int key)
		{
			this.EnsureConditionArgsCacheIfNeeded();
			int value;
			if (!this.ConditionArgsCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600E9A0 RID: 59808 RVA: 0x0035358C File Offset: 0x0035178C
		private void EnsureConditionArgsCacheIfNeeded()
		{
			if (this.ConditionArgsCache != null)
			{
				return;
			}
			this.ConditionArgsCache = this.ConditionArgsIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600E9A1 RID: 59809 RVA: 0x003535F2 File Offset: 0x003517F2
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetConditionArgsFrozenDict()
		{
			this.EnsureConditionArgsCacheIfNeeded();
			return this.ConditionArgsCache;
		}

		// Token: 0x0400588C RID: 22668
		private Table __p;

		// Token: 0x0400588D RID: 22669
		[Nullable(2)]
		private FrozenDictionary<int, int> ConditionArgsCache;
	}
}
