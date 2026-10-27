using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007681 RID: 30337
	public class TClientSetSeasonStateUnion
	{
		// Token: 0x1700E5E9 RID: 58857
		// (get) Token: 0x06037334 RID: 226100 RVA: 0x0077B5EC File Offset: 0x007797EC
		// (set) Token: 0x06037335 RID: 226101 RVA: 0x0077B5F4 File Offset: 0x007797F4
		public TClientSetSeasonState Type { get; set; }

		// Token: 0x1700E5EA RID: 58858
		// (get) Token: 0x06037336 RID: 226102 RVA: 0x0077B5FD File Offset: 0x007797FD
		// (set) Token: 0x06037337 RID: 226103 RVA: 0x0077B605 File Offset: 0x00779805
		public object Value { get; set; }

		// Token: 0x06037338 RID: 226104 RVA: 0x0077B60E File Offset: 0x0077980E
		public TClientSetSeasonStateUnion()
		{
			this.Type = TClientSetSeasonState.NONE;
			this.Value = null;
		}

		// Token: 0x06037339 RID: 226105 RVA: 0x0077B624 File Offset: 0x00779824
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603733A RID: 226106 RVA: 0x0077B636 File Offset: 0x00779836
		public ILoopSeasonChangeT AsILoopSeasonChange()
		{
			return this.As<ILoopSeasonChangeT>();
		}

		// Token: 0x0603733B RID: 226107 RVA: 0x0077B63E File Offset: 0x0077983E
		public static TClientSetSeasonStateUnion FromILoopSeasonChange(ILoopSeasonChangeT _iloopseasonchange)
		{
			return new TClientSetSeasonStateUnion
			{
				Type = TClientSetSeasonState.ILoopSeasonChange,
				Value = _iloopseasonchange
			};
		}

		// Token: 0x0603733C RID: 226108 RVA: 0x0077B653 File Offset: 0x00779853
		public ISwitchSeasonT AsISwitchSeason()
		{
			return this.As<ISwitchSeasonT>();
		}

		// Token: 0x0603733D RID: 226109 RVA: 0x0077B65B File Offset: 0x0077985B
		public static TClientSetSeasonStateUnion FromISwitchSeason(ISwitchSeasonT _iswitchseason)
		{
			return new TClientSetSeasonStateUnion
			{
				Type = TClientSetSeasonState.ISwitchSeason,
				Value = _iswitchseason
			};
		}

		// Token: 0x0603733E RID: 226110 RVA: 0x0077B670 File Offset: 0x00779870
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
