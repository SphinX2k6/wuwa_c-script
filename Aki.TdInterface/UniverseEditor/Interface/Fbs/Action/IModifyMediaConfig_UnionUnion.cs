using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AC8 RID: 27336
	public class IModifyMediaConfig_UnionUnion
	{
		// Token: 0x1700CACC RID: 51916
		// (get) Token: 0x0602FE72 RID: 196210 RVA: 0x006840BD File Offset: 0x006822BD
		// (set) Token: 0x0602FE73 RID: 196211 RVA: 0x006840C5 File Offset: 0x006822C5
		public IModifyMediaConfig_Union Type { get; set; }

		// Token: 0x1700CACD RID: 51917
		// (get) Token: 0x0602FE74 RID: 196212 RVA: 0x006840CE File Offset: 0x006822CE
		// (set) Token: 0x0602FE75 RID: 196213 RVA: 0x006840D6 File Offset: 0x006822D6
		public object Value { get; set; }

		// Token: 0x0602FE76 RID: 196214 RVA: 0x006840DF File Offset: 0x006822DF
		public IModifyMediaConfig_UnionUnion()
		{
			this.Type = IModifyMediaConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602FE77 RID: 196215 RVA: 0x006840F5 File Offset: 0x006822F5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602FE78 RID: 196216 RVA: 0x00684107 File Offset: 0x00682307
		public IModifyMediaConfigT AsIModifyMediaConfig()
		{
			return this.As<IModifyMediaConfigT>();
		}

		// Token: 0x0602FE79 RID: 196217 RVA: 0x0068410F File Offset: 0x0068230F
		public static IModifyMediaConfig_UnionUnion FromIModifyMediaConfig(IModifyMediaConfigT _imodifymediaconfig)
		{
			return new IModifyMediaConfig_UnionUnion
			{
				Type = IModifyMediaConfig_Union.IModifyMediaConfig,
				Value = _imodifymediaconfig
			};
		}

		// Token: 0x0602FE7A RID: 196218 RVA: 0x00684124 File Offset: 0x00682324
		public IChangeMediaPlayDaT AsIChangeMediaPlayDa()
		{
			return this.As<IChangeMediaPlayDaT>();
		}

		// Token: 0x0602FE7B RID: 196219 RVA: 0x0068412C File Offset: 0x0068232C
		public static IModifyMediaConfig_UnionUnion FromIChangeMediaPlayDa(IChangeMediaPlayDaT _ichangemediaplayda)
		{
			return new IModifyMediaConfig_UnionUnion
			{
				Type = IModifyMediaConfig_Union.IChangeMediaPlayDa,
				Value = _ichangemediaplayda
			};
		}

		// Token: 0x0602FE7C RID: 196220 RVA: 0x00684144 File Offset: 0x00682344
		public static int Pack(FlatBufferBuilder builder, IModifyMediaConfig_UnionUnion _o)
		{
			IModifyMediaConfig_Union type = _o.Type;
			if (type == IModifyMediaConfig_Union.IModifyMediaConfig)
			{
				return IModifyMediaConfig.Pack(builder, _o.AsIModifyMediaConfig()).Value;
			}
			if (type != IModifyMediaConfig_Union.IChangeMediaPlayDa)
			{
				return 0;
			}
			return IChangeMediaPlayDa.Pack(builder, _o.AsIChangeMediaPlayDa()).Value;
		}
	}
}
