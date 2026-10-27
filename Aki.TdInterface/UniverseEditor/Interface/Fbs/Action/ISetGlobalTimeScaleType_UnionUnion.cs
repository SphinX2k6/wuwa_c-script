using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FFC RID: 28668
	public class ISetGlobalTimeScaleType_UnionUnion
	{
		// Token: 0x1700D4F2 RID: 54514
		// (get) Token: 0x06032B50 RID: 207696 RVA: 0x006D785D File Offset: 0x006D5A5D
		// (set) Token: 0x06032B51 RID: 207697 RVA: 0x006D7865 File Offset: 0x006D5A65
		public ISetGlobalTimeScaleType_Union Type { get; set; }

		// Token: 0x1700D4F3 RID: 54515
		// (get) Token: 0x06032B52 RID: 207698 RVA: 0x006D786E File Offset: 0x006D5A6E
		// (set) Token: 0x06032B53 RID: 207699 RVA: 0x006D7876 File Offset: 0x006D5A76
		public object Value { get; set; }

		// Token: 0x06032B54 RID: 207700 RVA: 0x006D787F File Offset: 0x006D5A7F
		public ISetGlobalTimeScaleType_UnionUnion()
		{
			this.Type = ISetGlobalTimeScaleType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06032B55 RID: 207701 RVA: 0x006D7895 File Offset: 0x006D5A95
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06032B56 RID: 207702 RVA: 0x006D78A7 File Offset: 0x006D5AA7
		public ISetGlobalTimeScaleTypeT AsISetGlobalTimeScaleType()
		{
			return this.As<ISetGlobalTimeScaleTypeT>();
		}

		// Token: 0x06032B57 RID: 207703 RVA: 0x006D78AF File Offset: 0x006D5AAF
		public static ISetGlobalTimeScaleType_UnionUnion FromISetGlobalTimeScaleType(ISetGlobalTimeScaleTypeT _isetglobaltimescaletype)
		{
			return new ISetGlobalTimeScaleType_UnionUnion
			{
				Type = ISetGlobalTimeScaleType_Union.ISetGlobalTimeScaleType,
				Value = _isetglobaltimescaletype
			};
		}

		// Token: 0x06032B58 RID: 207704 RVA: 0x006D78C4 File Offset: 0x006D5AC4
		public IOpenGlobalTimeScaleT AsIOpenGlobalTimeScale()
		{
			return this.As<IOpenGlobalTimeScaleT>();
		}

		// Token: 0x06032B59 RID: 207705 RVA: 0x006D78CC File Offset: 0x006D5ACC
		public static ISetGlobalTimeScaleType_UnionUnion FromIOpenGlobalTimeScale(IOpenGlobalTimeScaleT _iopenglobaltimescale)
		{
			return new ISetGlobalTimeScaleType_UnionUnion
			{
				Type = ISetGlobalTimeScaleType_Union.IOpenGlobalTimeScale,
				Value = _iopenglobaltimescale
			};
		}

		// Token: 0x06032B5A RID: 207706 RVA: 0x006D78E1 File Offset: 0x006D5AE1
		public ICloseGlobalTimeScaleT AsICloseGlobalTimeScale()
		{
			return this.As<ICloseGlobalTimeScaleT>();
		}

		// Token: 0x06032B5B RID: 207707 RVA: 0x006D78E9 File Offset: 0x006D5AE9
		public static ISetGlobalTimeScaleType_UnionUnion FromICloseGlobalTimeScale(ICloseGlobalTimeScaleT _icloseglobaltimescale)
		{
			return new ISetGlobalTimeScaleType_UnionUnion
			{
				Type = ISetGlobalTimeScaleType_Union.ICloseGlobalTimeScale,
				Value = _icloseglobaltimescale
			};
		}

		// Token: 0x06032B5C RID: 207708 RVA: 0x006D7900 File Offset: 0x006D5B00
		public static int Pack(FlatBufferBuilder builder, ISetGlobalTimeScaleType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ISetGlobalTimeScaleType_Union.ISetGlobalTimeScaleType:
				return ISetGlobalTimeScaleType.Pack(builder, _o.AsISetGlobalTimeScaleType()).Value;
			case ISetGlobalTimeScaleType_Union.IOpenGlobalTimeScale:
				return IOpenGlobalTimeScale.Pack(builder, _o.AsIOpenGlobalTimeScale()).Value;
			case ISetGlobalTimeScaleType_Union.ICloseGlobalTimeScale:
				return ICloseGlobalTimeScale.Pack(builder, _o.AsICloseGlobalTimeScale()).Value;
			default:
				return 0;
			}
		}
	}
}
