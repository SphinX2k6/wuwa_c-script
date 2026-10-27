using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AEF RID: 10991
	[NullableContext(1)]
	[Nullable(0)]
	public class SetBlendAnim : ActionParams
	{
		// Token: 0x0600F0D7 RID: 61655 RVA: 0x0022F3C2 File Offset: 0x0022D5C2
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

		// Token: 0x17004CBB RID: 19643
		// (get) Token: 0x0600F0D8 RID: 61656 RVA: 0x0022F3E1 File Offset: 0x0022D5E1
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

		// Token: 0x17004CBC RID: 19644
		// (get) Token: 0x0600F0D9 RID: 61657 RVA: 0x0022F415 File Offset: 0x0022D615
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

		// Token: 0x0400847B RID: 33915
		private ISetBlendAnim Instance;

		// Token: 0x0400847C RID: 33916
		[Nullable(2)]
		private IPlayerBlendAnimTarget _TargetCache;

		// Token: 0x0400847D RID: 33917
		private bool _TargetInited;

		// Token: 0x0400847E RID: 33918
		private IBlendAnimTypeBase _BlendTypeCache;

		// Token: 0x0400847F RID: 33919
		private bool _BlendTypeInited;
	}
}
