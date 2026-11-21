using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028BC RID: 10428
	public class SpawnChild : ActionParams
	{
		// Token: 0x0600E842 RID: 59458 RVA: 0x0022554A File Offset: 0x0022374A
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

		// Token: 0x17004378 RID: 17272
		// (get) Token: 0x0600E843 RID: 59459 RVA: 0x00225569 File Offset: 0x00223769
		public virtual string TemplateGuid
		{
			get
			{
				return this.Instance.TemplateGuid;
			}
		}

		// Token: 0x17004379 RID: 17273
		// (get) Token: 0x0600E844 RID: 59460 RVA: 0x00225576 File Offset: 0x00223776
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

		// Token: 0x04007FEA RID: 32746
		private ISpawnChild Instance;

		// Token: 0x04007FEB RID: 32747
		[Nullable(2)]
		private ITransform _TransformCache;

		// Token: 0x04007FEC RID: 32748
		private bool _TransformInited;
	}
}
