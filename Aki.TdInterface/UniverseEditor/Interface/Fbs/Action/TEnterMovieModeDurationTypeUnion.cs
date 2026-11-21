using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007EC5 RID: 32453
	public class TEnterMovieModeDurationTypeUnion
	{
		// Token: 0x1700F251 RID: 62033
		// (get) Token: 0x0603A92B RID: 239915 RVA: 0x007E1C24 File Offset: 0x007DFE24
		// (set) Token: 0x0603A92C RID: 239916 RVA: 0x007E1C2C File Offset: 0x007DFE2C
		public TEnterMovieModeDurationType Type { get; set; }

		// Token: 0x1700F252 RID: 62034
		// (get) Token: 0x0603A92D RID: 239917 RVA: 0x007E1C35 File Offset: 0x007DFE35
		// (set) Token: 0x0603A92E RID: 239918 RVA: 0x007E1C3D File Offset: 0x007DFE3D
		public object Value { get; set; }

		// Token: 0x0603A92F RID: 239919 RVA: 0x007E1C46 File Offset: 0x007DFE46
		public TEnterMovieModeDurationTypeUnion()
		{
			this.Type = TEnterMovieModeDurationType.NONE;
			this.Value = null;
		}

		// Token: 0x0603A930 RID: 239920 RVA: 0x007E1C5C File Offset: 0x007DFE5C
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A931 RID: 239921 RVA: 0x007E1C6E File Offset: 0x007DFE6E
		public IWaitMovieModeBorderAnimFinishedT AsIWaitMovieModeBorderAnimFinished()
		{
			return this.As<IWaitMovieModeBorderAnimFinishedT>();
		}

		// Token: 0x0603A932 RID: 239922 RVA: 0x007E1C76 File Offset: 0x007DFE76
		public static TEnterMovieModeDurationTypeUnion FromIWaitMovieModeBorderAnimFinished(IWaitMovieModeBorderAnimFinishedT _iwaitmoviemodeborderanimfinished)
		{
			return new TEnterMovieModeDurationTypeUnion
			{
				Type = TEnterMovieModeDurationType.IWaitMovieModeBorderAnimFinished,
				Value = _iwaitmoviemodeborderanimfinished
			};
		}

		// Token: 0x0603A933 RID: 239923 RVA: 0x007E1C8B File Offset: 0x007DFE8B
		public IWaitMovieModeFixedTimeT AsIWaitMovieModeFixedTime()
		{
			return this.As<IWaitMovieModeFixedTimeT>();
		}

		// Token: 0x0603A934 RID: 239924 RVA: 0x007E1C93 File Offset: 0x007DFE93
		public static TEnterMovieModeDurationTypeUnion FromIWaitMovieModeFixedTime(IWaitMovieModeFixedTimeT _iwaitmoviemodefixedtime)
		{
			return new TEnterMovieModeDurationTypeUnion
			{
				Type = TEnterMovieModeDurationType.IWaitMovieModeFixedTime,
				Value = _iwaitmoviemodefixedtime
			};
		}

		// Token: 0x0603A935 RID: 239925 RVA: 0x007E1CA8 File Offset: 0x007DFEA8
		public static int Pack(FlatBufferBuilder builder, TEnterMovieModeDurationTypeUnion _o)
		{
			TEnterMovieModeDurationType type = _o.Type;
			if (type == TEnterMovieModeDurationType.IWaitMovieModeBorderAnimFinished)
			{
				return IWaitMovieModeBorderAnimFinished.Pack(builder, _o.AsIWaitMovieModeBorderAnimFinished()).Value;
			}
			if (type != TEnterMovieModeDurationType.IWaitMovieModeFixedTime)
			{
				return 0;
			}
			return IWaitMovieModeFixedTime.Pack(builder, _o.AsIWaitMovieModeFixedTime()).Value;
		}
	}
}
