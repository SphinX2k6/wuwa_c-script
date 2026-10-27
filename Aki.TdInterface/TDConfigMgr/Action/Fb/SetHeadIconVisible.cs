using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002508 RID: 9480
	[NullableContext(1)]
	[Nullable(0)]
	public class SetHeadIconVisible : ActionParams
	{
		// Token: 0x0600D385 RID: 54149 RVA: 0x001F5967 File Offset: 0x001F3B67
		public static SetHeadIconVisible Create(ISetHeadIconVisible? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetHeadIconVisible
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003B37 RID: 15159
		// (get) Token: 0x0600D386 RID: 54150 RVA: 0x001F5986 File Offset: 0x001F3B86
		public virtual IHeadStyle HeadStyleConfig
		{
			get
			{
				if (this._HeadStyleConfigInited)
				{
					return this._HeadStyleConfigCache;
				}
				this._HeadStyleConfigInited = true;
				this._HeadStyleConfigCache = ActionReadHelper.ReadSetHeadIconVisible_HeadStyleConfig(this.Instance);
				return this._HeadStyleConfigCache;
			}
		}

		// Token: 0x17003B38 RID: 15160
		// (get) Token: 0x0600D387 RID: 54151 RVA: 0x001F59B5 File Offset: 0x001F3BB5
		public virtual bool Visible
		{
			get
			{
				return this.Instance.Visible;
			}
		}

		// Token: 0x040073F2 RID: 29682
		private ISetHeadIconVisible Instance;

		// Token: 0x040073F3 RID: 29683
		private IHeadStyle _HeadStyleConfigCache;

		// Token: 0x040073F4 RID: 29684
		private bool _HeadStyleConfigInited;
	}
}
