using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073E9 RID: 29673
	public class ITimeScaleType_UnionUnion
	{
		// Token: 0x1700E161 RID: 57697
		// (get) Token: 0x06035E69 RID: 220777 RVA: 0x00755E9D File Offset: 0x0075409D
		// (set) Token: 0x06035E6A RID: 220778 RVA: 0x00755EA5 File Offset: 0x007540A5
		public ITimeScaleType_Union Type { get; set; }

		// Token: 0x1700E162 RID: 57698
		// (get) Token: 0x06035E6B RID: 220779 RVA: 0x00755EAE File Offset: 0x007540AE
		// (set) Token: 0x06035E6C RID: 220780 RVA: 0x00755EB6 File Offset: 0x007540B6
		public object Value { get; set; }

		// Token: 0x06035E6D RID: 220781 RVA: 0x00755EBF File Offset: 0x007540BF
		public ITimeScaleType_UnionUnion()
		{
			this.Type = ITimeScaleType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06035E6E RID: 220782 RVA: 0x00755ED5 File Offset: 0x007540D5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06035E6F RID: 220783 RVA: 0x00755EE7 File Offset: 0x007540E7
		public ITimeScaleTypeT AsITimeScaleType()
		{
			return this.As<ITimeScaleTypeT>();
		}

		// Token: 0x06035E70 RID: 220784 RVA: 0x00755EEF File Offset: 0x007540EF
		public static ITimeScaleType_UnionUnion FromITimeScaleType(ITimeScaleTypeT _itimescaletype)
		{
			return new ITimeScaleType_UnionUnion
			{
				Type = ITimeScaleType_Union.ITimeScaleType,
				Value = _itimescaletype
			};
		}

		// Token: 0x06035E71 RID: 220785 RVA: 0x00755F04 File Offset: 0x00754104
		public ISetGlobalTimeScaleT AsISetGlobalTimeScale()
		{
			return this.As<ISetGlobalTimeScaleT>();
		}

		// Token: 0x06035E72 RID: 220786 RVA: 0x00755F0C File Offset: 0x0075410C
		public static ITimeScaleType_UnionUnion FromISetGlobalTimeScale(ISetGlobalTimeScaleT _isetglobaltimescale)
		{
			return new ITimeScaleType_UnionUnion
			{
				Type = ITimeScaleType_Union.ISetGlobalTimeScale,
				Value = _isetglobaltimescale
			};
		}

		// Token: 0x06035E73 RID: 220787 RVA: 0x00755F24 File Offset: 0x00754124
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
