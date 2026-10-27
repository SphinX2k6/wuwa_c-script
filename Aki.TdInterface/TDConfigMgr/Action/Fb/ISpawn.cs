using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020024CD RID: 9421
	[NullableContext(1)]
	[Nullable(0)]
	public class ISpawn
	{
		// Token: 0x0600D272 RID: 53874 RVA: 0x001F39AA File Offset: 0x001F1BAA
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

		// Token: 0x17003A9A RID: 15002
		// (get) Token: 0x0600D273 RID: 53875 RVA: 0x001F39C9 File Offset: 0x001F1BC9
		public virtual int TemplateGuid
		{
			get
			{
				return this.Instance.TemplateGuid;
			}
		}

		// Token: 0x17003A9B RID: 15003
		// (get) Token: 0x0600D274 RID: 53876 RVA: 0x001F39D6 File Offset: 0x001F1BD6
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

		// Token: 0x04007375 RID: 29557
		private ISpawn Instance;

		// Token: 0x04007376 RID: 29558
		[Nullable(2)]
		private ITransform _TransformCache;

		// Token: 0x04007377 RID: 29559
		private bool _TransformInited;
	}
}
