using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071FC RID: 29180
	public class IModifyMediaConfig_UnionUnion
	{
		// Token: 0x1700D594 RID: 54676
		// (get) Token: 0x06032C28 RID: 207912 RVA: 0x006DB361 File Offset: 0x006D9561
		// (set) Token: 0x06032C29 RID: 207913 RVA: 0x006DB369 File Offset: 0x006D9569
		public IModifyMediaConfig_Union Type { get; set; }

		// Token: 0x1700D595 RID: 54677
		// (get) Token: 0x06032C2A RID: 207914 RVA: 0x006DB372 File Offset: 0x006D9572
		// (set) Token: 0x06032C2B RID: 207915 RVA: 0x006DB37A File Offset: 0x006D957A
		public object Value { get; set; }

		// Token: 0x06032C2C RID: 207916 RVA: 0x006DB383 File Offset: 0x006D9583
		public IModifyMediaConfig_UnionUnion()
		{
			this.Type = IModifyMediaConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06032C2D RID: 207917 RVA: 0x006DB399 File Offset: 0x006D9599
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06032C2E RID: 207918 RVA: 0x006DB3AB File Offset: 0x006D95AB
		public IModifyMediaConfigT AsIModifyMediaConfig()
		{
			return this.As<IModifyMediaConfigT>();
		}

		// Token: 0x06032C2F RID: 207919 RVA: 0x006DB3B3 File Offset: 0x006D95B3
		public static IModifyMediaConfig_UnionUnion FromIModifyMediaConfig(IModifyMediaConfigT _imodifymediaconfig)
		{
			return new IModifyMediaConfig_UnionUnion
			{
				Type = IModifyMediaConfig_Union.IModifyMediaConfig,
				Value = _imodifymediaconfig
			};
		}

		// Token: 0x06032C30 RID: 207920 RVA: 0x006DB3C8 File Offset: 0x006D95C8
		public IChangeMediaPlayDaT AsIChangeMediaPlayDa()
		{
			return this.As<IChangeMediaPlayDaT>();
		}

		// Token: 0x06032C31 RID: 207921 RVA: 0x006DB3D0 File Offset: 0x006D95D0
		public static IModifyMediaConfig_UnionUnion FromIChangeMediaPlayDa(IChangeMediaPlayDaT _ichangemediaplayda)
		{
			return new IModifyMediaConfig_UnionUnion
			{
				Type = IModifyMediaConfig_Union.IChangeMediaPlayDa,
				Value = _ichangemediaplayda
			};
		}

		// Token: 0x06032C32 RID: 207922 RVA: 0x006DB3E8 File Offset: 0x006D95E8
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
