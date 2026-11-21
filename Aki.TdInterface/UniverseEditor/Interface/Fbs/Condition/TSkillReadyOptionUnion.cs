using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005254 RID: 21076
	public class TSkillReadyOptionUnion
	{
		// Token: 0x1700968E RID: 38542
		// (get) Token: 0x060212E9 RID: 135913 RVA: 0x0049474A File Offset: 0x0049294A
		// (set) Token: 0x060212EA RID: 135914 RVA: 0x00494752 File Offset: 0x00492952
		public TSkillReadyOption Type { get; set; }

		// Token: 0x1700968F RID: 38543
		// (get) Token: 0x060212EB RID: 135915 RVA: 0x0049475B File Offset: 0x0049295B
		// (set) Token: 0x060212EC RID: 135916 RVA: 0x00494763 File Offset: 0x00492963
		public object Value { get; set; }

		// Token: 0x060212ED RID: 135917 RVA: 0x0049476C File Offset: 0x0049296C
		public TSkillReadyOptionUnion()
		{
			this.Type = TSkillReadyOption.NONE;
			this.Value = null;
		}

		// Token: 0x060212EE RID: 135918 RVA: 0x00494782 File Offset: 0x00492982
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060212EF RID: 135919 RVA: 0x00494794 File Offset: 0x00492994
		public IESkillReadyT AsIESkillReady()
		{
			return this.As<IESkillReadyT>();
		}

		// Token: 0x060212F0 RID: 135920 RVA: 0x0049479C File Offset: 0x0049299C
		public static TSkillReadyOptionUnion FromIESkillReady(IESkillReadyT _ieskillready)
		{
			return new TSkillReadyOptionUnion
			{
				Type = TSkillReadyOption.IESkillReady,
				Value = _ieskillready
			};
		}

		// Token: 0x060212F1 RID: 135921 RVA: 0x004947B1 File Offset: 0x004929B1
		public IUltimateSkillReadyT AsIUltimateSkillReady()
		{
			return this.As<IUltimateSkillReadyT>();
		}

		// Token: 0x060212F2 RID: 135922 RVA: 0x004947B9 File Offset: 0x004929B9
		public static TSkillReadyOptionUnion FromIUltimateSkillReady(IUltimateSkillReadyT _iultimateskillready)
		{
			return new TSkillReadyOptionUnion
			{
				Type = TSkillReadyOption.IUltimateSkillReady,
				Value = _iultimateskillready
			};
		}

		// Token: 0x060212F3 RID: 135923 RVA: 0x004947CE File Offset: 0x004929CE
		public IVisionSkillReadyT AsIVisionSkillReady()
		{
			return this.As<IVisionSkillReadyT>();
		}

		// Token: 0x060212F4 RID: 135924 RVA: 0x004947D6 File Offset: 0x004929D6
		public static TSkillReadyOptionUnion FromIVisionSkillReady(IVisionSkillReadyT _ivisionskillready)
		{
			return new TSkillReadyOptionUnion
			{
				Type = TSkillReadyOption.IVisionSkillReady,
				Value = _ivisionskillready
			};
		}

		// Token: 0x060212F5 RID: 135925 RVA: 0x004947EC File Offset: 0x004929EC
		public static int Pack(FlatBufferBuilder builder, TSkillReadyOptionUnion _o)
		{
			switch (_o.Type)
			{
			case TSkillReadyOption.IESkillReady:
				return IESkillReady.Pack(builder, _o.AsIESkillReady()).Value;
			case TSkillReadyOption.IUltimateSkillReady:
				return IUltimateSkillReady.Pack(builder, _o.AsIUltimateSkillReady()).Value;
			case TSkillReadyOption.IVisionSkillReady:
				return IVisionSkillReady.Pack(builder, _o.AsIVisionSkillReady()).Value;
			default:
				return 0;
			}
		}
	}
}
