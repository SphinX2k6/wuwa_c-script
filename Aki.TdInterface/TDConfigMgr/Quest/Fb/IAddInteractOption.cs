using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020014BC RID: 5308
	public class IAddInteractOption
	{
		// Token: 0x06007862 RID: 30818 RVA: 0x0012044C File Offset: 0x0011E64C
		public static IAddInteractOption Create(IAddInteractOption? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAddInteractOption
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700268C RID: 9868
		// (get) Token: 0x06007863 RID: 30819 RVA: 0x0012046B File Offset: 0x0011E66B
		public virtual IInteractOption Option
		{
			get
			{
				if (this._OptionInited)
				{
					return this._OptionCache;
				}
				this._OptionInited = true;
				this._OptionCache = IInteractOption.Create(this.Instance.Option);
				return this._OptionCache;
			}
		}

		// Token: 0x1700268D RID: 9869
		// (get) Token: 0x06007864 RID: 30820 RVA: 0x0012049F File Offset: 0x0011E69F
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x1700268E RID: 9870
		// (get) Token: 0x06007865 RID: 30821 RVA: 0x001204AC File Offset: 0x0011E6AC
		public virtual bool? IsManualFinish
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsManualFinish);
			}
		}

		// Token: 0x1700268F RID: 9871
		// (get) Token: 0x06007866 RID: 30822 RVA: 0x001204E4 File Offset: 0x0011E6E4
		public virtual bool? IsManualDelete
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsManualDelete);
			}
		}

		// Token: 0x17002690 RID: 9872
		// (get) Token: 0x06007867 RID: 30823 RVA: 0x0012051A File Offset: 0x0011E71A
		[Nullable(2)]
		public virtual string InteractToken
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.InteractToken;
			}
		}

		// Token: 0x04004532 RID: 17714
		private IAddInteractOption Instance;

		// Token: 0x04004533 RID: 17715
		[Nullable(2)]
		private IInteractOption _OptionCache;

		// Token: 0x04004534 RID: 17716
		private bool _OptionInited;
	}
}
