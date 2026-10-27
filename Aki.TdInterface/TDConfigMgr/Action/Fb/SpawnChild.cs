using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025FC RID: 9724
	[NullableContext(1)]
	[Nullable(0)]
	public class SpawnChild : ActionParams
	{
		// Token: 0x0600DA75 RID: 55925 RVA: 0x00208DF6 File Offset: 0x00206FF6
		public static SpawnChild Create(ISpawnChild? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SpawnChild
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700403F RID: 16447
		// (get) Token: 0x0600DA76 RID: 55926 RVA: 0x00208E15 File Offset: 0x00207015
		public virtual string TemplateGuid
		{
			get
			{
				return this.Instance.TemplateGuid;
			}
		}

		// Token: 0x17004040 RID: 16448
		// (get) Token: 0x0600DA77 RID: 55927 RVA: 0x00208E22 File Offset: 0x00207022
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

		// Token: 0x04007950 RID: 31056
		private ISpawnChild Instance;

		// Token: 0x04007951 RID: 31057
		[Nullable(2)]
		private ITransform _TransformCache;

		// Token: 0x04007952 RID: 31058
		private bool _TransformInited;
	}
}
