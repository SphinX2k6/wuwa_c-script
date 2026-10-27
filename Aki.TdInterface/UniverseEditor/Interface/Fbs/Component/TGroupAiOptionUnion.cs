using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C2B RID: 23595
	public class TGroupAiOptionUnion
	{
		// Token: 0x1700B1FA RID: 45562
		// (get) Token: 0x06028753 RID: 165715 RVA: 0x0059134A File Offset: 0x0058F54A
		// (set) Token: 0x06028754 RID: 165716 RVA: 0x00591352 File Offset: 0x0058F552
		public TGroupAiOption Type { get; set; }

		// Token: 0x1700B1FB RID: 45563
		// (get) Token: 0x06028755 RID: 165717 RVA: 0x0059135B File Offset: 0x0058F55B
		// (set) Token: 0x06028756 RID: 165718 RVA: 0x00591363 File Offset: 0x0058F563
		public object Value { get; set; }

		// Token: 0x06028757 RID: 165719 RVA: 0x0059136C File Offset: 0x0058F56C
		public TGroupAiOptionUnion()
		{
			this.Type = TGroupAiOption.NONE;
			this.Value = null;
		}

		// Token: 0x06028758 RID: 165720 RVA: 0x00591382 File Offset: 0x0058F582
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06028759 RID: 165721 RVA: 0x00591394 File Offset: 0x0058F594
		public IGroupAiModeDefaultT AsIGroupAiModeDefault()
		{
			return this.As<IGroupAiModeDefaultT>();
		}

		// Token: 0x0602875A RID: 165722 RVA: 0x0059139C File Offset: 0x0058F59C
		public static TGroupAiOptionUnion FromIGroupAiModeDefault(IGroupAiModeDefaultT _igroupaimodedefault)
		{
			return new TGroupAiOptionUnion
			{
				Type = TGroupAiOption.IGroupAiModeDefault,
				Value = _igroupaimodedefault
			};
		}

		// Token: 0x0602875B RID: 165723 RVA: 0x005913B1 File Offset: 0x0058F5B1
		public IGroupAiMonsterEcologyT AsIGroupAiMonsterEcology()
		{
			return this.As<IGroupAiMonsterEcologyT>();
		}

		// Token: 0x0602875C RID: 165724 RVA: 0x005913B9 File Offset: 0x0058F5B9
		public static TGroupAiOptionUnion FromIGroupAiMonsterEcology(IGroupAiMonsterEcologyT _igroupaimonsterecology)
		{
			return new TGroupAiOptionUnion
			{
				Type = TGroupAiOption.IGroupAiMonsterEcology,
				Value = _igroupaimonsterecology
			};
		}

		// Token: 0x0602875D RID: 165725 RVA: 0x005913CE File Offset: 0x0058F5CE
		public IGroupAiPatrolT AsIGroupAiPatrol()
		{
			return this.As<IGroupAiPatrolT>();
		}

		// Token: 0x0602875E RID: 165726 RVA: 0x005913D6 File Offset: 0x0058F5D6
		public static TGroupAiOptionUnion FromIGroupAiPatrol(IGroupAiPatrolT _igroupaipatrol)
		{
			return new TGroupAiOptionUnion
			{
				Type = TGroupAiOption.IGroupAiPatrol,
				Value = _igroupaipatrol
			};
		}

		// Token: 0x0602875F RID: 165727 RVA: 0x005913EC File Offset: 0x0058F5EC
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
