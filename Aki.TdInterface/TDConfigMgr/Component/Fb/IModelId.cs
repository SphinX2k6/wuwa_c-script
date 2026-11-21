using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DD8 RID: 3544
	public class IModelId : IModelConfig
	{
		// Token: 0x0600505C RID: 20572 RVA: 0x000C775D File Offset: 0x000C595D
		public static IModelId Create(IModelId? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IModelId
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170018A7 RID: 6311
		// (get) Token: 0x0600505D RID: 20573 RVA: 0x000C777C File Offset: 0x000C597C
		public override EModelType Type
		{
			get
			{
				return (EModelType)this.Instance.Type;
			}
		}

		// Token: 0x170018A8 RID: 6312
		// (get) Token: 0x0600505E RID: 20574 RVA: 0x000C7789 File Offset: 0x000C5989
		public virtual int ModelId
		{
			get
			{
				return this.Instance.ModelId;
			}
		}

		// Token: 0x04002DCD RID: 11725
		private IModelId Instance;
	}
}
