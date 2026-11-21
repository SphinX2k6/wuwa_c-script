using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079CF RID: 31183
	public class ISubPlotModeBase_UnionUnion
	{
		// Token: 0x1700E49E RID: 58526
		// (get) Token: 0x06036F08 RID: 225032 RVA: 0x007588D9 File Offset: 0x00756AD9
		// (set) Token: 0x06036F09 RID: 225033 RVA: 0x007588E1 File Offset: 0x00756AE1
		public ISubPlotModeBase_Union Type { get; set; }

		// Token: 0x1700E49F RID: 58527
		// (get) Token: 0x06036F0A RID: 225034 RVA: 0x007588EA File Offset: 0x00756AEA
		// (set) Token: 0x06036F0B RID: 225035 RVA: 0x007588F2 File Offset: 0x00756AF2
		public object Value { get; set; }

		// Token: 0x06036F0C RID: 225036 RVA: 0x007588FB File Offset: 0x00756AFB
		public ISubPlotModeBase_UnionUnion()
		{
			this.Type = ISubPlotModeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06036F0D RID: 225037 RVA: 0x00758911 File Offset: 0x00756B11
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06036F0E RID: 225038 RVA: 0x00758923 File Offset: 0x00756B23
		public ISubPlotModeBaseT AsISubPlotModeBase()
		{
			return this.As<ISubPlotModeBaseT>();
		}

		// Token: 0x06036F0F RID: 225039 RVA: 0x0075892B File Offset: 0x00756B2B
		public static ISubPlotModeBase_UnionUnion FromISubPlotModeBase(ISubPlotModeBaseT _isubplotmodebase)
		{
			return new ISubPlotModeBase_UnionUnion
			{
				Type = ISubPlotModeBase_Union.ISubPlotModeBase,
				Value = _isubplotmodebase
			};
		}

		// Token: 0x06036F10 RID: 225040 RVA: 0x00758940 File Offset: 0x00756B40
		public ISubPlotModePromptWithProfilePicT AsISubPlotModePromptWithProfilePic()
		{
			return this.As<ISubPlotModePromptWithProfilePicT>();
		}

		// Token: 0x06036F11 RID: 225041 RVA: 0x00758948 File Offset: 0x00756B48
		public static ISubPlotModeBase_UnionUnion FromISubPlotModePromptWithProfilePic(ISubPlotModePromptWithProfilePicT _isubplotmodepromptwithprofilepic)
		{
			return new ISubPlotModeBase_UnionUnion
			{
				Type = ISubPlotModeBase_Union.ISubPlotModePromptWithProfilePic,
				Value = _isubplotmodepromptwithprofilepic
			};
		}

		// Token: 0x06036F12 RID: 225042 RVA: 0x00758960 File Offset: 0x00756B60
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
