using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C17 RID: 3095
	public struct DynamicMapMark : IFlatbufferObject
	{
		// Token: 0x17000E33 RID: 3635
		// (get) Token: 0x060066BE RID: 26302 RVA: 0x0021E24B File Offset: 0x0021C44B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060066BF RID: 26303 RVA: 0x0021E258 File Offset: 0x0021C458
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060066C0 RID: 26304 RVA: 0x0021E260 File Offset: 0x0021C460
		public static DynamicMapMark GetRootAsDynamicMapMark(ByteBuffer _bb)
		{
			return DynamicMapMark.GetRootAsDynamicMapMark(_bb, default(DynamicMapMark));
		}

		// Token: 0x060066C1 RID: 26305 RVA: 0x0021E27C File Offset: 0x0021C47C
		public static DynamicMapMark GetRootAsDynamicMapMark(ByteBuffer _bb, DynamicMapMark obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060066C2 RID: 26306 RVA: 0x0021E299 File Offset: 0x0021C499
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060066C3 RID: 26307 RVA: 0x0021E2A8 File Offset: 0x0021C4A8
		public DynamicMapMark __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000E34 RID: 3636
		// (get) Token: 0x060066C4 RID: 26308 RVA: 0x0021E2B8 File Offset: 0x0021C4B8
		public int MarkId
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

		// Token: 0x17000E35 RID: 3637
		// (get) Token: 0x060066C5 RID: 26309 RVA: 0x0021E2F4 File Offset: 0x0021C4F4
		public int InstanceDungeonId
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

		// Token: 0x17000E36 RID: 3638
		// (get) Token: 0x060066C6 RID: 26310 RVA: 0x0021E330 File Offset: 0x0021C530
		public int MapId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 8;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000E37 RID: 3639
		// (get) Token: 0x060066C7 RID: 26311 RVA: 0x0021E36C File Offset: 0x0021C56C
		public int RelativeSubType
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

		// Token: 0x17000E38 RID: 3640
		// (get) Token: 0x060066C8 RID: 26312 RVA: 0x0021E3AC File Offset: 0x0021C5AC
		public int RelativeDungeonId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 8;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000E39 RID: 3641
		// (get) Token: 0x060066C9 RID: 26313 RVA: 0x0021E3EC File Offset: 0x0021C5EC
		public int FogHide
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

		// Token: 0x17000E3A RID: 3642
		// (get) Token: 0x060066CA RID: 26314 RVA: 0x0021E42C File Offset: 0x0021C62C
		public int RelativeType
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000E3B RID: 3643
		// (get) Token: 0x060066CB RID: 26315 RVA: 0x0021E46C File Offset: 0x0021C66C
		public int RelativeId
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000E3C RID: 3644
		// (get) Token: 0x060066CC RID: 26316 RVA: 0x0021E4AC File Offset: 0x0021C6AC
		public IntVector? MarkVector
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return new IntVector?(default(IntVector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17000E3D RID: 3645
		// (get) Token: 0x060066CD RID: 26317 RVA: 0x0021E50C File Offset: 0x0021C70C
		public int EntityConfigId
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000E3E RID: 3646
		// (get) Token: 0x060066CE RID: 26318 RVA: 0x0021E54C File Offset: 0x0021C74C
		public int ObjectType
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

		// Token: 0x17000E3F RID: 3647
		// (get) Token: 0x060066CF RID: 26319 RVA: 0x0021E58C File Offset: 0x0021C78C
		public string MarkTitle
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060066D0 RID: 26320 RVA: 0x0021E5C4 File Offset: 0x0021C7C4
		public Span<byte> GetMarkTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x060066D1 RID: 26321 RVA: 0x0021E5D4 File Offset: 0x0021C7D4
		public byte[] GetMarkTitleArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17000E40 RID: 3648
		// (get) Token: 0x060066D2 RID: 26322 RVA: 0x0021E5EC File Offset: 0x0021C7EC
		public string MarkDesc
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060066D3 RID: 26323 RVA: 0x0021E624 File Offset: 0x0021C824
		public Span<byte> GetMarkDescBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x060066D4 RID: 26324 RVA: 0x0021E634 File Offset: 0x0021C834
		public byte[] GetMarkDescArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17000E41 RID: 3649
		// (get) Token: 0x060066D5 RID: 26325 RVA: 0x0021E64C File Offset: 0x0021C84C
		public int ToBeDiscovered
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000E42 RID: 3650
		// (get) Token: 0x060066D6 RID: 26326 RVA: 0x0021E68C File Offset: 0x0021C88C
		public int IsMonster
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000E43 RID: 3651
		// (get) Token: 0x060066D7 RID: 26327 RVA: 0x0021E6CC File Offset: 0x0021C8CC
		public int ShowPriority
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060066D8 RID: 26328 RVA: 0x0021E70C File Offset: 0x0021C90C
		public int ShowRange(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000E44 RID: 3652
		// (get) Token: 0x060066D9 RID: 26329 RVA: 0x0021E74C File Offset: 0x0021C94C
		public int ShowRangeLength
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060066DA RID: 26330 RVA: 0x0021E778 File Offset: 0x0021C978
		public Span<int> GetShowRangeBytes()
		{
			return this.__p.__vector_as_span<int>(36, 4);
		}

		// Token: 0x060066DB RID: 26331 RVA: 0x0021E788 File Offset: 0x0021C988
		public int[] GetShowRangeArray()
		{
			return this.__p.__vector_as_array<int>(36) ?? Array.Empty<int>();
		}

		// Token: 0x17000E45 RID: 3653
		// (get) Token: 0x060066DC RID: 26332 RVA: 0x0021E7A0 File Offset: 0x0021C9A0
		public string LockMarkPic
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060066DD RID: 26333 RVA: 0x0021E7D8 File Offset: 0x0021C9D8
		public Span<byte> GetLockMarkPicBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x060066DE RID: 26334 RVA: 0x0021E7E8 File Offset: 0x0021C9E8
		public byte[] GetLockMarkPicArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x17000E46 RID: 3654
		// (get) Token: 0x060066DF RID: 26335 RVA: 0x0021E800 File Offset: 0x0021CA00
		public string UnlockMarkPic
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060066E0 RID: 26336 RVA: 0x0021E838 File Offset: 0x0021CA38
		public Span<byte> GetUnlockMarkPicBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x060066E1 RID: 26337 RVA: 0x0021E848 File Offset: 0x0021CA48
		public byte[] GetUnlockMarkPicArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x17000E47 RID: 3655
		// (get) Token: 0x060066E2 RID: 26338 RVA: 0x0021E860 File Offset: 0x0021CA60
		public int ShowCondition
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000E48 RID: 3656
		// (get) Token: 0x060066E3 RID: 26339 RVA: 0x0021E8A0 File Offset: 0x0021CAA0
		public int FogShow
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000E49 RID: 3657
		// (get) Token: 0x060066E4 RID: 26340 RVA: 0x0021E8E0 File Offset: 0x0021CAE0
		public int MapShow
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000E4A RID: 3658
		// (get) Token: 0x060066E5 RID: 26341 RVA: 0x0021E920 File Offset: 0x0021CB20
		public float Scale
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000E4B RID: 3659
		// (get) Token: 0x060066E6 RID: 26342 RVA: 0x0021E964 File Offset: 0x0021CB64
		public float FirstReward
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000E4C RID: 3660
		// (get) Token: 0x060066E7 RID: 26343 RVA: 0x0021E9A8 File Offset: 0x0021CBA8
		public float Reward
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000E4D RID: 3661
		// (get) Token: 0x060066E8 RID: 26344 RVA: 0x0021E9EC File Offset: 0x0021CBEC
		public int TrackHudEnable
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000E4E RID: 3662
		// (get) Token: 0x060066E9 RID: 26345 RVA: 0x0021EA2C File Offset: 0x0021CC2C
		public float TrackAutoCancelDistance
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return -1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060066EA RID: 26346 RVA: 0x0021EA70 File Offset: 0x0021CC70
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ShowRangeIter()或GetShowRangeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ShowRange()
		{
			DynamicMapMark dynamicMapMark = this;
			return dynamicMapMark.GetShowRangeArray() ?? Array.Empty<int>();
		}

		// Token: 0x060066EB RID: 26347 RVA: 0x0021EA94 File Offset: 0x0021CC94
		[NullableContext(1)]
		public readonly IEnumerable<int> ShowRangeIter()
		{
			DynamicMapMark.<ShowRangeIter>d__74 <ShowRangeIter>d__ = new DynamicMapMark.<ShowRangeIter>d__74(-2);
			<ShowRangeIter>d__.<>3__<>4__this = this;
			return <ShowRangeIter>d__;
		}

		// Token: 0x04004C57 RID: 19543
		private Table __p;
	}
}
