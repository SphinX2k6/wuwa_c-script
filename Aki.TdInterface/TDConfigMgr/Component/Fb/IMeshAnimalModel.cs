using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DDF RID: 3551
	public class IMeshAnimalModel : IAnimalModelConfig
	{
		// Token: 0x0600507E RID: 20606 RVA: 0x000C7B57 File Offset: 0x000C5D57
		public static IMeshAnimalModel Create(IMeshAnimalModel? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMeshAnimalModel
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170018BB RID: 6331
		// (get) Token: 0x0600507F RID: 20607 RVA: 0x000C7B76 File Offset: 0x000C5D76
		public override EAnimalModelType Type
		{
			get
			{
				return (EAnimalModelType)this.Instance.Type;
			}
		}

		// Token: 0x170018BC RID: 6332
		// (get) Token: 0x06005080 RID: 20608 RVA: 0x000C7B83 File Offset: 0x000C5D83
		public virtual string Mesh
		{
			get
			{
				return this.Instance.Mesh;
			}
		}

		// Token: 0x04002DDC RID: 11740
		private IMeshAnimalModel Instance;
	}
}
