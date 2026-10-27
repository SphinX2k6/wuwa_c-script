using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D75 RID: 3445
	public struct InstanceTrialRoleConfig : IFlatbufferObject
	{
		// Token: 0x170019C1 RID: 6593
		// (get) Token: 0x060085A7 RID: 34215 RVA: 0x00264631 File Offset: 0x00262831
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060085A8 RID: 34216 RVA: 0x0026463E File Offset: 0x0026283E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060085A9 RID: 34217 RVA: 0x00264648 File Offset: 0x00262848
		public static InstanceTrialRoleConfig GetRootAsInstanceTrialRoleConfig(ByteBuffer _bb)
		{
			return InstanceTrialRoleConfig.GetRootAsInstanceTrialRoleConfig(_bb, default(InstanceTrialRoleConfig));
		}

		// Token: 0x060085AA RID: 34218 RVA: 0x00264664 File Offset: 0x00262864
		public static InstanceTrialRoleConfig GetRootAsInstanceTrialRoleConfig(ByteBuffer _bb, InstanceTrialRoleConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060085AB RID: 34219 RVA: 0x00264681 File Offset: 0x00262881
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060085AC RID: 34220 RVA: 0x00264690 File Offset: 0x00262890
		public InstanceTrialRoleConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170019C2 RID: 6594
		// (get) Token: 0x060085AD RID: 34221 RVA: 0x002646A0 File Offset: 0x002628A0
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

		// Token: 0x060085AE RID: 34222 RVA: 0x002646DC File Offset: 0x002628DC
		public int MaleFormation(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170019C3 RID: 6595
		// (get) Token: 0x060085AF RID: 34223 RVA: 0x0026471C File Offset: 0x0026291C
		public int MaleFormationLength
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

		// Token: 0x060085B0 RID: 34224 RVA: 0x00264747 File Offset: 0x00262947
		public Span<int> GetMaleFormationBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x060085B1 RID: 34225 RVA: 0x00264756 File Offset: 0x00262956
		public int[] GetMaleFormationArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x060085B2 RID: 34226 RVA: 0x00264770 File Offset: 0x00262970
		public int FemaleFormation(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170019C4 RID: 6596
		// (get) Token: 0x060085B3 RID: 34227 RVA: 0x002647B0 File Offset: 0x002629B0
		public int FemaleFormationLength
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

		// Token: 0x060085B4 RID: 34228 RVA: 0x002647DB File Offset: 0x002629DB
		public Span<int> GetFemaleFormationBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x060085B5 RID: 34229 RVA: 0x002647EA File Offset: 0x002629EA
		public int[] GetFemaleFormationArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x060085B6 RID: 34230 RVA: 0x00264804 File Offset: 0x00262A04
		public int MaleDelayFormation(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170019C5 RID: 6597
		// (get) Token: 0x060085B7 RID: 34231 RVA: 0x00264844 File Offset: 0x00262A44
		public int MaleDelayFormationLength
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

		// Token: 0x060085B8 RID: 34232 RVA: 0x00264870 File Offset: 0x00262A70
		public Span<int> GetMaleDelayFormationBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x060085B9 RID: 34233 RVA: 0x00264880 File Offset: 0x00262A80
		public int[] GetMaleDelayFormationArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x060085BA RID: 34234 RVA: 0x00264898 File Offset: 0x00262A98
		public int FemaleDelayFormation(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170019C6 RID: 6598
		// (get) Token: 0x060085BB RID: 34235 RVA: 0x002648D8 File Offset: 0x00262AD8
		public int FemaleDelayFormationLength
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

		// Token: 0x060085BC RID: 34236 RVA: 0x00264904 File Offset: 0x00262B04
		public Span<int> GetFemaleDelayFormationBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x060085BD RID: 34237 RVA: 0x00264914 File Offset: 0x00262B14
		public int[] GetFemaleDelayFormationArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x170019C7 RID: 6599
		// (get) Token: 0x060085BE RID: 34238 RVA: 0x0026492C File Offset: 0x00262B2C
		public bool OnlyTrial
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170019C8 RID: 6600
		// (get) Token: 0x060085BF RID: 34239 RVA: 0x0026496C File Offset: 0x00262B6C
		public bool AutoChange
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170019C9 RID: 6601
		// (get) Token: 0x060085C0 RID: 34240 RVA: 0x002649AC File Offset: 0x00262BAC
		public bool ShowInEntrance
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060085C1 RID: 34241 RVA: 0x002649EC File Offset: 0x00262BEC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FemaleDelayFormationIter()或GetFemaleDelayFormationBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] FemaleDelayFormation()
		{
			InstanceTrialRoleConfig instanceTrialRoleConfig = this;
			return instanceTrialRoleConfig.GetFemaleDelayFormationArray() ?? Array.Empty<int>();
		}

		// Token: 0x060085C2 RID: 34242 RVA: 0x00264A10 File Offset: 0x00262C10
		[NullableContext(1)]
		public readonly IEnumerable<int> FemaleDelayFormationIter()
		{
			InstanceTrialRoleConfig.<FemaleDelayFormationIter>d__37 <FemaleDelayFormationIter>d__ = new InstanceTrialRoleConfig.<FemaleDelayFormationIter>d__37(-2);
			<FemaleDelayFormationIter>d__.<>3__<>4__this = this;
			return <FemaleDelayFormationIter>d__;
		}

		// Token: 0x060085C3 RID: 34243 RVA: 0x00264A28 File Offset: 0x00262C28
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FemaleFormationIter()或GetFemaleFormationBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] FemaleFormation()
		{
			InstanceTrialRoleConfig instanceTrialRoleConfig = this;
			return instanceTrialRoleConfig.GetFemaleFormationArray() ?? Array.Empty<int>();
		}

		// Token: 0x060085C4 RID: 34244 RVA: 0x00264A4C File Offset: 0x00262C4C
		[NullableContext(1)]
		public readonly IEnumerable<int> FemaleFormationIter()
		{
			InstanceTrialRoleConfig.<FemaleFormationIter>d__39 <FemaleFormationIter>d__ = new InstanceTrialRoleConfig.<FemaleFormationIter>d__39(-2);
			<FemaleFormationIter>d__.<>3__<>4__this = this;
			return <FemaleFormationIter>d__;
		}

		// Token: 0x060085C5 RID: 34245 RVA: 0x00264A64 File Offset: 0x00262C64
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MaleDelayFormationIter()或GetMaleDelayFormationBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] MaleDelayFormation()
		{
			InstanceTrialRoleConfig instanceTrialRoleConfig = this;
			return instanceTrialRoleConfig.GetMaleDelayFormationArray() ?? Array.Empty<int>();
		}

		// Token: 0x060085C6 RID: 34246 RVA: 0x00264A88 File Offset: 0x00262C88
		[NullableContext(1)]
		public readonly IEnumerable<int> MaleDelayFormationIter()
		{
			InstanceTrialRoleConfig.<MaleDelayFormationIter>d__41 <MaleDelayFormationIter>d__ = new InstanceTrialRoleConfig.<MaleDelayFormationIter>d__41(-2);
			<MaleDelayFormationIter>d__.<>3__<>4__this = this;
			return <MaleDelayFormationIter>d__;
		}

		// Token: 0x060085C7 RID: 34247 RVA: 0x00264AA0 File Offset: 0x00262CA0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MaleFormationIter()或GetMaleFormationBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] MaleFormation()
		{
			InstanceTrialRoleConfig instanceTrialRoleConfig = this;
			return instanceTrialRoleConfig.GetMaleFormationArray() ?? Array.Empty<int>();
		}

		// Token: 0x060085C8 RID: 34248 RVA: 0x00264AC4 File Offset: 0x00262CC4
		[NullableContext(1)]
		public readonly IEnumerable<int> MaleFormationIter()
		{
			InstanceTrialRoleConfig.<MaleFormationIter>d__43 <MaleFormationIter>d__ = new InstanceTrialRoleConfig.<MaleFormationIter>d__43(-2);
			<MaleFormationIter>d__.<>3__<>4__this = this;
			return <MaleFormationIter>d__;
		}

		// Token: 0x04004DFD RID: 19965
		private Table __p;
	}
}
