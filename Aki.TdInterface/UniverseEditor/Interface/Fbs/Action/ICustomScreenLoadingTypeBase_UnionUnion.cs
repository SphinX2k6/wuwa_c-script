using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006508 RID: 25864
	public class ICustomScreenLoadingTypeBase_UnionUnion
	{
		// Token: 0x1700C055 RID: 49237
		// (get) Token: 0x0602CDD5 RID: 183765 RVA: 0x00629A7D File Offset: 0x00627C7D
		// (set) Token: 0x0602CDD6 RID: 183766 RVA: 0x00629A85 File Offset: 0x00627C85
		public ICustomScreenLoadingTypeBase_Union Type { get; set; }

		// Token: 0x1700C056 RID: 49238
		// (get) Token: 0x0602CDD7 RID: 183767 RVA: 0x00629A8E File Offset: 0x00627C8E
		// (set) Token: 0x0602CDD8 RID: 183768 RVA: 0x00629A96 File Offset: 0x00627C96
		public object Value { get; set; }

		// Token: 0x0602CDD9 RID: 183769 RVA: 0x00629A9F File Offset: 0x00627C9F
		public ICustomScreenLoadingTypeBase_UnionUnion()
		{
			this.Type = ICustomScreenLoadingTypeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602CDDA RID: 183770 RVA: 0x00629AB5 File Offset: 0x00627CB5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602CDDB RID: 183771 RVA: 0x00629AC7 File Offset: 0x00627CC7
		public ICustomScreenLoadingTypeBaseT AsICustomScreenLoadingTypeBase()
		{
			return this.As<ICustomScreenLoadingTypeBaseT>();
		}

		// Token: 0x0602CDDC RID: 183772 RVA: 0x00629ACF File Offset: 0x00627CCF
		public static ICustomScreenLoadingTypeBase_UnionUnion FromICustomScreenLoadingTypeBase(ICustomScreenLoadingTypeBaseT _icustomscreenloadingtypebase)
		{
			return new ICustomScreenLoadingTypeBase_UnionUnion
			{
				Type = ICustomScreenLoadingTypeBase_Union.ICustomScreenLoadingTypeBase,
				Value = _icustomscreenloadingtypebase
			};
		}

		// Token: 0x0602CDDD RID: 183773 RVA: 0x00629AE4 File Offset: 0x00627CE4
		public ICustomScreenLoadingCyberpunkT AsICustomScreenLoadingCyberpunk()
		{
			return this.As<ICustomScreenLoadingCyberpunkT>();
		}

		// Token: 0x0602CDDE RID: 183774 RVA: 0x00629AEC File Offset: 0x00627CEC
		public static ICustomScreenLoadingTypeBase_UnionUnion FromICustomScreenLoadingCyberpunk(ICustomScreenLoadingCyberpunkT _icustomscreenloadingcyberpunk)
		{
			return new ICustomScreenLoadingTypeBase_UnionUnion
			{
				Type = ICustomScreenLoadingTypeBase_Union.ICustomScreenLoadingCyberpunk,
				Value = _icustomscreenloadingcyberpunk
			};
		}

		// Token: 0x0602CDDF RID: 183775 RVA: 0x00629B04 File Offset: 0x00627D04
		public static int Pack(FlatBufferBuilder builder, ICustomScreenLoadingTypeBase_UnionUnion _o)
		{
			ICustomScreenLoadingTypeBase_Union type = _o.Type;
			if (type == ICustomScreenLoadingTypeBase_Union.ICustomScreenLoadingTypeBase)
			{
				return ICustomScreenLoadingTypeBase.Pack(builder, _o.AsICustomScreenLoadingTypeBase()).Value;
			}
			if (type != ICustomScreenLoadingTypeBase_Union.ICustomScreenLoadingCyberpunk)
			{
				return 0;
			}
			return ICustomScreenLoadingCyberpunk.Pack(builder, _o.AsICustomScreenLoadingCyberpunk()).Value;
		}
	}
}
