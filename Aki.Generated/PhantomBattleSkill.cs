using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EDB RID: 3803
	public struct PhantomBattleSkill : IFlatbufferObject
	{
		// Token: 0x1700267D RID: 9853
		// (get) Token: 0x0600A7C4 RID: 42948 RVA: 0x002B14D0 File Offset: 0x002AF6D0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A7C5 RID: 42949 RVA: 0x002B14DD File Offset: 0x002AF6DD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A7C6 RID: 42950 RVA: 0x002B14E4 File Offset: 0x002AF6E4
		public static PhantomBattleSkill GetRootAsPhantomBattleSkill(ByteBuffer _bb)
		{
			return PhantomBattleSkill.GetRootAsPhantomBattleSkill(_bb, default(PhantomBattleSkill));
		}

		// Token: 0x0600A7C7 RID: 42951 RVA: 0x002B1500 File Offset: 0x002AF700
		public static PhantomBattleSkill GetRootAsPhantomBattleSkill(ByteBuffer _bb, PhantomBattleSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A7C8 RID: 42952 RVA: 0x002B151D File Offset: 0x002AF71D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A7C9 RID: 42953 RVA: 0x002B152C File Offset: 0x002AF72C
		public PhantomBattleSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700267E RID: 9854
		// (get) Token: 0x0600A7CA RID: 42954 RVA: 0x002B153C File Offset: 0x002AF73C
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

		// Token: 0x1700267F RID: 9855
		// (get) Token: 0x0600A7CB RID: 42955 RVA: 0x002B1578 File Offset: 0x002AF778
		public string Name
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A7CC RID: 42956 RVA: 0x002B15AF File Offset: 0x002AF7AF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A7CD RID: 42957 RVA: 0x002B15BE File Offset: 0x002AF7BE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002680 RID: 9856
		// (get) Token: 0x0600A7CE RID: 42958 RVA: 0x002B15D8 File Offset: 0x002AF7D8
		public string Desc
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

		// Token: 0x0600A7CF RID: 42959 RVA: 0x002B160F File Offset: 0x002AF80F
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600A7D0 RID: 42960 RVA: 0x002B161E File Offset: 0x002AF81E
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002681 RID: 9857
		// (get) Token: 0x0600A7D1 RID: 42961 RVA: 0x002B1638 File Offset: 0x002AF838
		public int ExecuteTimes
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002682 RID: 9858
		// (get) Token: 0x0600A7D2 RID: 42962 RVA: 0x002B1678 File Offset: 0x002AF878
		public int CostDurability
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A7D3 RID: 42963 RVA: 0x002B16B8 File Offset: 0x002AF8B8
		public string DescParams(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002683 RID: 9859
		// (get) Token: 0x0600A7D4 RID: 42964 RVA: 0x002B16F4 File Offset: 0x002AF8F4
		public int DescParamsLength
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

		// Token: 0x17002684 RID: 9860
		// (get) Token: 0x0600A7D5 RID: 42965 RVA: 0x002B1720 File Offset: 0x002AF920
		public int TargetSelectType
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

		// Token: 0x0600A7D6 RID: 42966 RVA: 0x002B1760 File Offset: 0x002AF960
		public string TargetSelectParams(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002685 RID: 9861
		// (get) Token: 0x0600A7D7 RID: 42967 RVA: 0x002B179C File Offset: 0x002AF99C
		public int TargetSelectParamsLength
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

		// Token: 0x17002686 RID: 9862
		// (get) Token: 0x0600A7D8 RID: 42968 RVA: 0x002B17C8 File Offset: 0x002AF9C8
		public int BattlePower
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002687 RID: 9863
		// (get) Token: 0x0600A7D9 RID: 42969 RVA: 0x002B1808 File Offset: 0x002AFA08
		public int CostConsume
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

		// Token: 0x17002688 RID: 9864
		// (get) Token: 0x0600A7DA RID: 42970 RVA: 0x002B1848 File Offset: 0x002AFA48
		public int EffectType
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

		// Token: 0x0600A7DB RID: 42971 RVA: 0x002B1888 File Offset: 0x002AFA88
		public string EffectParams(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002689 RID: 9865
		// (get) Token: 0x0600A7DC RID: 42972 RVA: 0x002B18C4 File Offset: 0x002AFAC4
		public int EffectParamsLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700268A RID: 9866
		// (get) Token: 0x0600A7DD RID: 42973 RVA: 0x002B18F0 File Offset: 0x002AFAF0
		public int ActivateCondition
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

		// Token: 0x0600A7DE RID: 42974 RVA: 0x002B192D File Offset: 0x002AFB2D
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DescParamsIter()或GetDescParamsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] DescParams()
		{
			return this.DescParamsIter().ToArray<string>();
		}

		// Token: 0x0600A7DF RID: 42975 RVA: 0x002B193A File Offset: 0x002AFB3A
		[NullableContext(1)]
		public readonly IEnumerable<string> DescParamsIter()
		{
			PhantomBattleSkill.<DescParamsIter>d__42 <DescParamsIter>d__ = new PhantomBattleSkill.<DescParamsIter>d__42(-2);
			<DescParamsIter>d__.<>3__<>4__this = this;
			return <DescParamsIter>d__;
		}

		// Token: 0x0600A7E0 RID: 42976 RVA: 0x002B194F File Offset: 0x002AFB4F
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EffectParamsIter()或GetEffectParamsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] EffectParams()
		{
			return this.EffectParamsIter().ToArray<string>();
		}

		// Token: 0x0600A7E1 RID: 42977 RVA: 0x002B195C File Offset: 0x002AFB5C
		[NullableContext(1)]
		public readonly IEnumerable<string> EffectParamsIter()
		{
			PhantomBattleSkill.<EffectParamsIter>d__44 <EffectParamsIter>d__ = new PhantomBattleSkill.<EffectParamsIter>d__44(-2);
			<EffectParamsIter>d__.<>3__<>4__this = this;
			return <EffectParamsIter>d__;
		}

		// Token: 0x0600A7E2 RID: 42978 RVA: 0x002B1971 File Offset: 0x002AFB71
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TargetSelectParamsIter()或GetTargetSelectParamsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] TargetSelectParams()
		{
			return this.TargetSelectParamsIter().ToArray<string>();
		}

		// Token: 0x0600A7E3 RID: 42979 RVA: 0x002B197E File Offset: 0x002AFB7E
		[NullableContext(1)]
		public readonly IEnumerable<string> TargetSelectParamsIter()
		{
			PhantomBattleSkill.<TargetSelectParamsIter>d__46 <TargetSelectParamsIter>d__ = new PhantomBattleSkill.<TargetSelectParamsIter>d__46(-2);
			<TargetSelectParamsIter>d__.<>3__<>4__this = this;
			return <TargetSelectParamsIter>d__;
		}

		// Token: 0x04004F99 RID: 20377
		private Table __p;
	}
}
