using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076F4 RID: 30452
	public class ISceneUiSubtitleStyleBase_UnionUnion
	{
		// Token: 0x1700DF62 RID: 57186
		// (get) Token: 0x060356ED RID: 218861 RVA: 0x0072A8F5 File Offset: 0x00728AF5
		// (set) Token: 0x060356EE RID: 218862 RVA: 0x0072A8FD File Offset: 0x00728AFD
		public ISceneUiSubtitleStyleBase_Union Type { get; set; }

		// Token: 0x1700DF63 RID: 57187
		// (get) Token: 0x060356EF RID: 218863 RVA: 0x0072A906 File Offset: 0x00728B06
		// (set) Token: 0x060356F0 RID: 218864 RVA: 0x0072A90E File Offset: 0x00728B0E
		public object Value { get; set; }

		// Token: 0x060356F1 RID: 218865 RVA: 0x0072A917 File Offset: 0x00728B17
		public ISceneUiSubtitleStyleBase_UnionUnion()
		{
			this.Type = ISceneUiSubtitleStyleBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060356F2 RID: 218866 RVA: 0x0072A92D File Offset: 0x00728B2D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060356F3 RID: 218867 RVA: 0x0072A93F File Offset: 0x00728B3F
		public ISceneUiSubtitleStyleBaseT AsISceneUiSubtitleStyleBase()
		{
			return this.As<ISceneUiSubtitleStyleBaseT>();
		}

		// Token: 0x060356F4 RID: 218868 RVA: 0x0072A947 File Offset: 0x00728B47
		public static ISceneUiSubtitleStyleBase_UnionUnion FromISceneUiSubtitleStyleBase(ISceneUiSubtitleStyleBaseT _isceneuisubtitlestylebase)
		{
			return new ISceneUiSubtitleStyleBase_UnionUnion
			{
				Type = ISceneUiSubtitleStyleBase_Union.ISceneUiSubtitleStyleBase,
				Value = _isceneuisubtitlestylebase
			};
		}

		// Token: 0x060356F5 RID: 218869 RVA: 0x0072A95C File Offset: 0x00728B5C
		public ISceneUiSubtitleScatterT AsISceneUiSubtitleScatter()
		{
			return this.As<ISceneUiSubtitleScatterT>();
		}

		// Token: 0x060356F6 RID: 218870 RVA: 0x0072A964 File Offset: 0x00728B64
		public static ISceneUiSubtitleStyleBase_UnionUnion FromISceneUiSubtitleScatter(ISceneUiSubtitleScatterT _isceneuisubtitlescatter)
		{
			return new ISceneUiSubtitleStyleBase_UnionUnion
			{
				Type = ISceneUiSubtitleStyleBase_Union.ISceneUiSubtitleScatter,
				Value = _isceneuisubtitlescatter
			};
		}

		// Token: 0x060356F7 RID: 218871 RVA: 0x0072A979 File Offset: 0x00728B79
		public ISceneUiSubtitleAppearT AsISceneUiSubtitleAppear()
		{
			return this.As<ISceneUiSubtitleAppearT>();
		}

		// Token: 0x060356F8 RID: 218872 RVA: 0x0072A981 File Offset: 0x00728B81
		public static ISceneUiSubtitleStyleBase_UnionUnion FromISceneUiSubtitleAppear(ISceneUiSubtitleAppearT _isceneuisubtitleappear)
		{
			return new ISceneUiSubtitleStyleBase_UnionUnion
			{
				Type = ISceneUiSubtitleStyleBase_Union.ISceneUiSubtitleAppear,
				Value = _isceneuisubtitleappear
			};
		}

		// Token: 0x060356F9 RID: 218873 RVA: 0x0072A998 File Offset: 0x00728B98
		public static int Pack(FlatBufferBuilder builder, ISceneUiSubtitleStyleBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ISceneUiSubtitleStyleBase_Union.ISceneUiSubtitleStyleBase:
				return ISceneUiSubtitleStyleBase.Pack(builder, _o.AsISceneUiSubtitleStyleBase()).Value;
			case ISceneUiSubtitleStyleBase_Union.ISceneUiSubtitleScatter:
				return ISceneUiSubtitleScatter.Pack(builder, _o.AsISceneUiSubtitleScatter()).Value;
			case ISceneUiSubtitleStyleBase_Union.ISceneUiSubtitleAppear:
				return ISceneUiSubtitleAppear.Pack(builder, _o.AsISceneUiSubtitleAppear()).Value;
			default:
				return 0;
			}
		}
	}
}
