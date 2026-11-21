using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002772 RID: 10098
	public class ISpawn
	{
		// Token: 0x0600DFC7 RID: 57287 RVA: 0x0020F206 File Offset: 0x0020D406
		public static ISpawn Create(ISpawn? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISpawn
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003D91 RID: 15761
		// (get) Token: 0x0600DFC8 RID: 57288 RVA: 0x0020F225 File Offset: 0x0020D425
		public virtual int TemplateGuid
		{
			get
			{
				return this.Instance.TemplateGuid;
			}
		}

		// Token: 0x17003D92 RID: 15762
		// (get) Token: 0x0600DFC9 RID: 57289 RVA: 0x0020F232 File Offset: 0x0020D432
		public virtual ITransform Transform
		{
			get
			{
				if (this._TransformInited)
				{
					return this._TransformCache;
				}
				this._TransformInited = true;
				this._TransformCache = ITransform.Create(this.Instance.Transform);
				return this._TransformCache;
			}
		}

		// Token: 0x040079C2 RID: 31170
		private ISpawn Instance;

		// Token: 0x040079C3 RID: 31171
		[Nullable(2)]
		private ITransform _TransformCache;

		// Token: 0x040079C4 RID: 31172
		private bool _TransformInited;
	}
}
