using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071FA RID: 29178
	public class ISubPlotModeBase_UnionUnion
	{
		// Token: 0x1700D8A5 RID: 55461
		// (get) Token: 0x06033C06 RID: 211974 RVA: 0x006F7579 File Offset: 0x006F5779
		// (set) Token: 0x06033C07 RID: 211975 RVA: 0x006F7581 File Offset: 0x006F5781
		public ISubPlotModeBase_Union Type { get; set; }

		// Token: 0x1700D8A6 RID: 55462
		// (get) Token: 0x06033C08 RID: 211976 RVA: 0x006F758A File Offset: 0x006F578A
		// (set) Token: 0x06033C09 RID: 211977 RVA: 0x006F7592 File Offset: 0x006F5792
		public object Value { get; set; }

		// Token: 0x06033C0A RID: 211978 RVA: 0x006F759B File Offset: 0x006F579B
		public ISubPlotModeBase_UnionUnion()
		{
			this.Type = ISubPlotModeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06033C0B RID: 211979 RVA: 0x006F75B1 File Offset: 0x006F57B1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06033C0C RID: 211980 RVA: 0x006F75C3 File Offset: 0x006F57C3
		public ISubPlotModeBaseT AsISubPlotModeBase()
		{
			return this.As<ISubPlotModeBaseT>();
		}

		// Token: 0x06033C0D RID: 211981 RVA: 0x006F75CB File Offset: 0x006F57CB
		public static ISubPlotModeBase_UnionUnion FromISubPlotModeBase(ISubPlotModeBaseT _isubplotmodebase)
		{
			return new ISubPlotModeBase_UnionUnion
			{
				Type = ISubPlotModeBase_Union.ISubPlotModeBase,
				Value = _isubplotmodebase
			};
		}

		// Token: 0x06033C0E RID: 211982 RVA: 0x006F75E0 File Offset: 0x006F57E0
		public ISubPlotModePromptWithProfilePicT AsISubPlotModePromptWithProfilePic()
		{
			return this.As<ISubPlotModePromptWithProfilePicT>();
		}

		// Token: 0x06033C0F RID: 211983 RVA: 0x006F75E8 File Offset: 0x006F57E8
		public static ISubPlotModeBase_UnionUnion FromISubPlotModePromptWithProfilePic(ISubPlotModePromptWithProfilePicT _isubplotmodepromptwithprofilepic)
		{
			return new ISubPlotModeBase_UnionUnion
			{
				Type = ISubPlotModeBase_Union.ISubPlotModePromptWithProfilePic,
				Value = _isubplotmodepromptwithprofilepic
			};
		}

		// Token: 0x06033C10 RID: 211984 RVA: 0x006F7600 File Offset: 0x006F5800
		public static int Pack(FlatBufferBuilder builder, ISubPlotModeBase_UnionUnion _o)
		{
			ISubPlotModeBase_Union type = _o.Type;
			if (type == ISubPlotModeBase_Union.ISubPlotModeBase)
			{
				return ISubPlotModeBase.Pack(builder, _o.AsISubPlotModeBase()).Value;
			}
			if (type != ISubPlotModeBase_Union.ISubPlotModePromptWithProfilePic)
			{
				return 0;
			}
			return ISubPlotModePromptWithProfilePic.Pack(builder, _o.AsISubPlotModePromptWithProfilePic()).Value;
		}
	}
}
