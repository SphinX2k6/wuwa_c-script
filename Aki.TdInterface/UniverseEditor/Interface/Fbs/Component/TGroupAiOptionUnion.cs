using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006250 RID: 25168
	public class TGroupAiOptionUnion
	{
		// Token: 0x1700BB4C RID: 47948
		// (get) Token: 0x0602AD61 RID: 175457 RVA: 0x005D9562 File Offset: 0x005D7762
		// (set) Token: 0x0602AD62 RID: 175458 RVA: 0x005D956A File Offset: 0x005D776A
		public TGroupAiOption Type { get; set; }

		// Token: 0x1700BB4D RID: 47949
		// (get) Token: 0x0602AD63 RID: 175459 RVA: 0x005D9573 File Offset: 0x005D7773
		// (set) Token: 0x0602AD64 RID: 175460 RVA: 0x005D957B File Offset: 0x005D777B
		public object Value { get; set; }

		// Token: 0x0602AD65 RID: 175461 RVA: 0x005D9584 File Offset: 0x005D7784
		public TGroupAiOptionUnion()
		{
			this.Type = TGroupAiOption.NONE;
			this.Value = null;
		}

		// Token: 0x0602AD66 RID: 175462 RVA: 0x005D959A File Offset: 0x005D779A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AD67 RID: 175463 RVA: 0x005D95AC File Offset: 0x005D77AC
		public IGroupAiModeDefaultT AsIGroupAiModeDefault()
		{
			return this.As<IGroupAiModeDefaultT>();
		}

		// Token: 0x0602AD68 RID: 175464 RVA: 0x005D95B4 File Offset: 0x005D77B4
		public static TGroupAiOptionUnion FromIGroupAiModeDefault(IGroupAiModeDefaultT _igroupaimodedefault)
		{
			return new TGroupAiOptionUnion
			{
				Type = TGroupAiOption.IGroupAiModeDefault,
				Value = _igroupaimodedefault
			};
		}

		// Token: 0x0602AD69 RID: 175465 RVA: 0x005D95C9 File Offset: 0x005D77C9
		public IGroupAiMonsterEcologyT AsIGroupAiMonsterEcology()
		{
			return this.As<IGroupAiMonsterEcologyT>();
		}

		// Token: 0x0602AD6A RID: 175466 RVA: 0x005D95D1 File Offset: 0x005D77D1
		public static TGroupAiOptionUnion FromIGroupAiMonsterEcology(IGroupAiMonsterEcologyT _igroupaimonsterecology)
		{
			return new TGroupAiOptionUnion
			{
				Type = TGroupAiOption.IGroupAiMonsterEcology,
				Value = _igroupaimonsterecology
			};
		}

		// Token: 0x0602AD6B RID: 175467 RVA: 0x005D95E6 File Offset: 0x005D77E6
		public IGroupAiPatrolT AsIGroupAiPatrol()
		{
			return this.As<IGroupAiPatrolT>();
		}

		// Token: 0x0602AD6C RID: 175468 RVA: 0x005D95EE File Offset: 0x005D77EE
		public static TGroupAiOptionUnion FromIGroupAiPatrol(IGroupAiPatrolT _igroupaipatrol)
		{
			return new TGroupAiOptionUnion
			{
				Type = TGroupAiOption.IGroupAiPatrol,
				Value = _igroupaipatrol
			};
		}

		// Token: 0x0602AD6D RID: 175469 RVA: 0x005D9604 File Offset: 0x005D7804
		public static int Pack(FlatBufferBuilder builder, TGroupAiOptionUnion _o)
		{
			switch (_o.Type)
			{
			case TGroupAiOption.IGroupAiModeDefault:
				return IGroupAiModeDefault.Pack(builder, _o.AsIGroupAiModeDefault()).Value;
			case TGroupAiOption.IGroupAiMonsterEcology:
				return IGroupAiMonsterEcology.Pack(builder, _o.AsIGroupAiMonsterEcology()).Value;
			case TGroupAiOption.IGroupAiPatrol:
				return IGroupAiPatrol.Pack(builder, _o.AsIGroupAiPatrol()).Value;
			default:
				return 0;
			}
		}
	}
}
