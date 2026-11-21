using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BD3 RID: 31699
	public class ITimeScaleType_UnionUnion
	{
		// Token: 0x1700ED76 RID: 60790
		// (get) Token: 0x0603921C RID: 234012 RVA: 0x007B8611 File Offset: 0x007B6811
		// (set) Token: 0x0603921D RID: 234013 RVA: 0x007B8619 File Offset: 0x007B6819
		public ITimeScaleType_Union Type { get; set; }

		// Token: 0x1700ED77 RID: 60791
		// (get) Token: 0x0603921E RID: 234014 RVA: 0x007B8622 File Offset: 0x007B6822
		// (set) Token: 0x0603921F RID: 234015 RVA: 0x007B862A File Offset: 0x007B682A
		public object Value { get; set; }

		// Token: 0x06039220 RID: 234016 RVA: 0x007B8633 File Offset: 0x007B6833
		public ITimeScaleType_UnionUnion()
		{
			this.Type = ITimeScaleType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06039221 RID: 234017 RVA: 0x007B8649 File Offset: 0x007B6849
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06039222 RID: 234018 RVA: 0x007B865B File Offset: 0x007B685B
		public ITimeScaleTypeT AsITimeScaleType()
		{
			return this.As<ITimeScaleTypeT>();
		}

		// Token: 0x06039223 RID: 234019 RVA: 0x007B8663 File Offset: 0x007B6863
		public static ITimeScaleType_UnionUnion FromITimeScaleType(ITimeScaleTypeT _itimescaletype)
		{
			return new ITimeScaleType_UnionUnion
			{
				Type = ITimeScaleType_Union.ITimeScaleType,
				Value = _itimescaletype
			};
		}

		// Token: 0x06039224 RID: 234020 RVA: 0x007B8678 File Offset: 0x007B6878
		public ISetGlobalTimeScaleT AsISetGlobalTimeScale()
		{
			return this.As<ISetGlobalTimeScaleT>();
		}

		// Token: 0x06039225 RID: 234021 RVA: 0x007B8680 File Offset: 0x007B6880
		public static ITimeScaleType_UnionUnion FromISetGlobalTimeScale(ISetGlobalTimeScaleT _isetglobaltimescale)
		{
			return new ITimeScaleType_UnionUnion
			{
				Type = ITimeScaleType_Union.ISetGlobalTimeScale,
				Value = _isetglobaltimescale
			};
		}

		// Token: 0x06039226 RID: 234022 RVA: 0x007B8698 File Offset: 0x007B6898
		public static int Pack(FlatBufferBuilder builder, ITimeScaleType_UnionUnion _o)
		{
			ITimeScaleType_Union type = _o.Type;
			if (type == ITimeScaleType_Union.ITimeScaleType)
			{
				return ITimeScaleType.Pack(builder, _o.AsITimeScaleType()).Value;
			}
			if (type != ITimeScaleType_Union.ISetGlobalTimeScale)
			{
				return 0;
			}
			return ISetGlobalTimeScale.Pack(builder, _o.AsISetGlobalTimeScale()).Value;
		}
	}
}
