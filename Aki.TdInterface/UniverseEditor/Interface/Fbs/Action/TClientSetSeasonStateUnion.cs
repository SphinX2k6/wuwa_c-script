using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E8F RID: 32399
	public class TClientSetSeasonStateUnion
	{
		// Token: 0x1700F227 RID: 61991
		// (get) Token: 0x0603A7DB RID: 239579 RVA: 0x007DF734 File Offset: 0x007DD934
		// (set) Token: 0x0603A7DC RID: 239580 RVA: 0x007DF73C File Offset: 0x007DD93C
		public TClientSetSeasonState Type { get; set; }

		// Token: 0x1700F228 RID: 61992
		// (get) Token: 0x0603A7DD RID: 239581 RVA: 0x007DF745 File Offset: 0x007DD945
		// (set) Token: 0x0603A7DE RID: 239582 RVA: 0x007DF74D File Offset: 0x007DD94D
		public object Value { get; set; }

		// Token: 0x0603A7DF RID: 239583 RVA: 0x007DF756 File Offset: 0x007DD956
		public TClientSetSeasonStateUnion()
		{
			this.Type = TClientSetSeasonState.NONE;
			this.Value = null;
		}

		// Token: 0x0603A7E0 RID: 239584 RVA: 0x007DF76C File Offset: 0x007DD96C
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A7E1 RID: 239585 RVA: 0x007DF77E File Offset: 0x007DD97E
		public ILoopSeasonChangeT AsILoopSeasonChange()
		{
			return this.As<ILoopSeasonChangeT>();
		}

		// Token: 0x0603A7E2 RID: 239586 RVA: 0x007DF786 File Offset: 0x007DD986
		public static TClientSetSeasonStateUnion FromILoopSeasonChange(ILoopSeasonChangeT _iloopseasonchange)
		{
			return new TClientSetSeasonStateUnion
			{
				Type = TClientSetSeasonState.ILoopSeasonChange,
				Value = _iloopseasonchange
			};
		}

		// Token: 0x0603A7E3 RID: 239587 RVA: 0x007DF79B File Offset: 0x007DD99B
		public ISwitchSeasonT AsISwitchSeason()
		{
			return this.As<ISwitchSeasonT>();
		}

		// Token: 0x0603A7E4 RID: 239588 RVA: 0x007DF7A3 File Offset: 0x007DD9A3
		public static TClientSetSeasonStateUnion FromISwitchSeason(ISwitchSeasonT _iswitchseason)
		{
			return new TClientSetSeasonStateUnion
			{
				Type = TClientSetSeasonState.ISwitchSeason,
				Value = _iswitchseason
			};
		}

		// Token: 0x0603A7E5 RID: 239589 RVA: 0x007DF7B8 File Offset: 0x007DD9B8
		public static int Pack(FlatBufferBuilder builder, TClientSetSeasonStateUnion _o)
		{
			TClientSetSeasonState type = _o.Type;
			if (type == TClientSetSeasonState.ILoopSeasonChange)
			{
				return ILoopSeasonChange.Pack(builder, _o.AsILoopSeasonChange()).Value;
			}
			if (type != TClientSetSeasonState.ISwitchSeason)
			{
				return 0;
			}
			return ISwitchSeason.Pack(builder, _o.AsISwitchSeason()).Value;
		}
	}
}
