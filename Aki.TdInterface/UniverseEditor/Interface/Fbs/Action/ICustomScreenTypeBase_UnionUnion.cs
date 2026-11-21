using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B82 RID: 27522
	public class ICustomScreenTypeBase_UnionUnion
	{
		// Token: 0x1700C9F6 RID: 51702
		// (get) Token: 0x0602F5BB RID: 193979 RVA: 0x0067644D File Offset: 0x0067464D
		// (set) Token: 0x0602F5BC RID: 193980 RVA: 0x00676455 File Offset: 0x00674655
		public ICustomScreenTypeBase_Union Type { get; set; }

		// Token: 0x1700C9F7 RID: 51703
		// (get) Token: 0x0602F5BD RID: 193981 RVA: 0x0067645E File Offset: 0x0067465E
		// (set) Token: 0x0602F5BE RID: 193982 RVA: 0x00676466 File Offset: 0x00674666
		public object Value { get; set; }

		// Token: 0x0602F5BF RID: 193983 RVA: 0x0067646F File Offset: 0x0067466F
		public ICustomScreenTypeBase_UnionUnion()
		{
			this.Type = ICustomScreenTypeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602F5C0 RID: 193984 RVA: 0x00676485 File Offset: 0x00674685
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602F5C1 RID: 193985 RVA: 0x00676497 File Offset: 0x00674697
		public ICustomScreenTypeBaseT AsICustomScreenTypeBase()
		{
			return this.As<ICustomScreenTypeBaseT>();
		}

		// Token: 0x0602F5C2 RID: 193986 RVA: 0x0067649F File Offset: 0x0067469F
		public static ICustomScreenTypeBase_UnionUnion FromICustomScreenTypeBase(ICustomScreenTypeBaseT _icustomscreentypebase)
		{
			return new ICustomScreenTypeBase_UnionUnion
			{
				Type = ICustomScreenTypeBase_Union.ICustomScreenTypeBase,
				Value = _icustomscreentypebase
			};
		}

		// Token: 0x0602F5C3 RID: 193987 RVA: 0x006764B4 File Offset: 0x006746B4
		public ICustomScreenSpineT AsICustomScreenSpine()
		{
			return this.As<ICustomScreenSpineT>();
		}

		// Token: 0x0602F5C4 RID: 193988 RVA: 0x006764BC File Offset: 0x006746BC
		public static ICustomScreenTypeBase_UnionUnion FromICustomScreenSpine(ICustomScreenSpineT _icustomscreenspine)
		{
			return new ICustomScreenTypeBase_UnionUnion
			{
				Type = ICustomScreenTypeBase_Union.ICustomScreenSpine,
				Value = _icustomscreenspine
			};
		}

		// Token: 0x0602F5C5 RID: 193989 RVA: 0x006764D1 File Offset: 0x006746D1
		public ICustomScreenBackgroundImageT AsICustomScreenBackgroundImage()
		{
			return this.As<ICustomScreenBackgroundImageT>();
		}

		// Token: 0x0602F5C6 RID: 193990 RVA: 0x006764D9 File Offset: 0x006746D9
		public static ICustomScreenTypeBase_UnionUnion FromICustomScreenBackgroundImage(ICustomScreenBackgroundImageT _icustomscreenbackgroundimage)
		{
			return new ICustomScreenTypeBase_UnionUnion
			{
				Type = ICustomScreenTypeBase_Union.ICustomScreenBackgroundImage,
				Value = _icustomscreenbackgroundimage
			};
		}

		// Token: 0x0602F5C7 RID: 193991 RVA: 0x006764EE File Offset: 0x006746EE
		public ICustomScreenLoadingT AsICustomScreenLoading()
		{
			return this.As<ICustomScreenLoadingT>();
		}

		// Token: 0x0602F5C8 RID: 193992 RVA: 0x006764F6 File Offset: 0x006746F6
		public static ICustomScreenTypeBase_UnionUnion FromICustomScreenLoading(ICustomScreenLoadingT _icustomscreenloading)
		{
			return new ICustomScreenTypeBase_UnionUnion
			{
				Type = ICustomScreenTypeBase_Union.ICustomScreenLoading,
				Value = _icustomscreenloading
			};
		}

		// Token: 0x0602F5C9 RID: 193993 RVA: 0x0067650C File Offset: 0x0067470C
		public static int Pack(FlatBufferBuilder builder, ICustomScreenTypeBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ICustomScreenTypeBase_Union.ICustomScreenTypeBase:
				return ICustomScreenTypeBase.Pack(builder, _o.AsICustomScreenTypeBase()).Value;
			case ICustomScreenTypeBase_Union.ICustomScreenSpine:
				return ICustomScreenSpine.Pack(builder, _o.AsICustomScreenSpine()).Value;
			case ICustomScreenTypeBase_Union.ICustomScreenBackgroundImage:
				return ICustomScreenBackgroundImage.Pack(builder, _o.AsICustomScreenBackgroundImage()).Value;
			case ICustomScreenTypeBase_Union.ICustomScreenLoading:
				return ICustomScreenLoading.Pack(builder, _o.AsICustomScreenLoading()).Value;
			default:
				return 0;
			}
		}
	}
}
