using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DE3 RID: 11747
	public class SetBlendAnim : ActionParams
	{
		// Token: 0x0600FF8D RID: 65421 RVA: 0x0024D0CE File Offset: 0x0024B2CE
		public static SetBlendAnim Create(ISetBlendAnim? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetBlendAnim
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17005075 RID: 20597
		// (get) Token: 0x0600FF8E RID: 65422 RVA: 0x0024D0ED File Offset: 0x0024B2ED
		public virtual IPlayerBlendAnimTarget Target
		{
			get
			{
				if (this._TargetInited)
				{
					return this._TargetCache;
				}
				this._TargetInited = true;
				this._TargetCache = IPlayerBlendAnimTarget.Create(this.Instance.Target);
				return this._TargetCache;
			}
		}

		// Token: 0x17005076 RID: 20598
		// (get) Token: 0x0600FF8F RID: 65423 RVA: 0x0024D121 File Offset: 0x0024B321
		public virtual IBlendAnimTypeBase BlendType
		{
			get
			{
				if (this._BlendTypeInited)
				{
					return this._BlendTypeCache;
				}
				this._BlendTypeInited = true;
				this._BlendTypeCache = ActionReadHelper.ReadSetBlendAnim_BlendType(this.Instance);
				return this._BlendTypeCache;
			}
		}

		// Token: 0x04008B7F RID: 35711
		private ISetBlendAnim Instance;

		// Token: 0x04008B80 RID: 35712
		[Nullable(2)]
		private IPlayerBlendAnimTarget _TargetCache;

		// Token: 0x04008B81 RID: 35713
		private bool _TargetInited;

		// Token: 0x04008B82 RID: 35714
		private IBlendAnimTypeBase _BlendTypeCache;

		// Token: 0x04008B83 RID: 35715
		private bool _BlendTypeInited;
	}
}
