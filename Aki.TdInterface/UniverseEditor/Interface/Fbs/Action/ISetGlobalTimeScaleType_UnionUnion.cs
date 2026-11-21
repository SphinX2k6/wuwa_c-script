using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077C5 RID: 30661
	public class ISetGlobalTimeScaleType_UnionUnion
	{
		// Token: 0x1700E0C6 RID: 57542
		// (get) Token: 0x06035DB6 RID: 220598 RVA: 0x007374A1 File Offset: 0x007356A1
		// (set) Token: 0x06035DB7 RID: 220599 RVA: 0x007374A9 File Offset: 0x007356A9
		public ISetGlobalTimeScaleType_Union Type { get; set; }

		// Token: 0x1700E0C7 RID: 57543
		// (get) Token: 0x06035DB8 RID: 220600 RVA: 0x007374B2 File Offset: 0x007356B2
		// (set) Token: 0x06035DB9 RID: 220601 RVA: 0x007374BA File Offset: 0x007356BA
		public object Value { get; set; }

		// Token: 0x06035DBA RID: 220602 RVA: 0x007374C3 File Offset: 0x007356C3
		public ISetGlobalTimeScaleType_UnionUnion()
		{
			this.Type = ISetGlobalTimeScaleType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06035DBB RID: 220603 RVA: 0x007374D9 File Offset: 0x007356D9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06035DBC RID: 220604 RVA: 0x007374EB File Offset: 0x007356EB
		public ISetGlobalTimeScaleTypeT AsISetGlobalTimeScaleType()
		{
			return this.As<ISetGlobalTimeScaleTypeT>();
		}

		// Token: 0x06035DBD RID: 220605 RVA: 0x007374F3 File Offset: 0x007356F3
		public static ISetGlobalTimeScaleType_UnionUnion FromISetGlobalTimeScaleType(ISetGlobalTimeScaleTypeT _isetglobaltimescaletype)
		{
			return new ISetGlobalTimeScaleType_UnionUnion
			{
				Type = ISetGlobalTimeScaleType_Union.ISetGlobalTimeScaleType,
				Value = _isetglobaltimescaletype
			};
		}

		// Token: 0x06035DBE RID: 220606 RVA: 0x00737508 File Offset: 0x00735708
		public IOpenGlobalTimeScaleT AsIOpenGlobalTimeScale()
		{
			return this.As<IOpenGlobalTimeScaleT>();
		}

		// Token: 0x06035DBF RID: 220607 RVA: 0x00737510 File Offset: 0x00735710
		public static ISetGlobalTimeScaleType_UnionUnion FromIOpenGlobalTimeScale(IOpenGlobalTimeScaleT _iopenglobaltimescale)
		{
			return new ISetGlobalTimeScaleType_UnionUnion
			{
				Type = ISetGlobalTimeScaleType_Union.IOpenGlobalTimeScale,
				Value = _iopenglobaltimescale
			};
		}

		// Token: 0x06035DC0 RID: 220608 RVA: 0x00737525 File Offset: 0x00735725
		public ICloseGlobalTimeScaleT AsICloseGlobalTimeScale()
		{
			return this.As<ICloseGlobalTimeScaleT>();
		}

		// Token: 0x06035DC1 RID: 220609 RVA: 0x0073752D File Offset: 0x0073572D
		public static ISetGlobalTimeScaleType_UnionUnion FromICloseGlobalTimeScale(ICloseGlobalTimeScaleT _icloseglobaltimescale)
		{
			return new ISetGlobalTimeScaleType_UnionUnion
			{
				Type = ISetGlobalTimeScaleType_Union.ICloseGlobalTimeScale,
				Value = _icloseglobaltimescale
			};
		}

		// Token: 0x06035DC2 RID: 220610 RVA: 0x00737544 File Offset: 0x00735744
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
