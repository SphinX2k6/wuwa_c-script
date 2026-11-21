using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FAD RID: 8109
	public class IRemovePreloadLinkResource : IRemovePreloadResourceCharacterType
	{
		// Token: 0x0600AC61 RID: 44129 RVA: 0x00185BD8 File Offset: 0x00183DD8
		private IRemovePreloadLinkResource_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRemovePreloadLinkResource 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRemovePreloadLinkResource_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRemovePreloadLinkResource_SetValue());
			}
			return result;
		}

		// Token: 0x0600AC62 RID: 44130 RVA: 0x00185C10 File Offset: 0x00183E10
		public static IRemovePreloadLinkResource Create([Nullable(2)] IRemovePreloadLinkResource instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRemovePreloadLinkResource
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AC63 RID: 44131 RVA: 0x00185C23 File Offset: 0x00183E23
		public static IRemovePreloadLinkResource CreateFromSetValue([Nullable(2)] IRemovePreloadLinkResource_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRemovePreloadLinkResource
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AC64 RID: 44132 RVA: 0x00185C36 File Offset: 0x00183E36
		public new IRemovePreloadLinkResource_SetValue ToSetValue()
		{
			return new IRemovePreloadLinkResource_SetValue
			{
				Type = this.Type,
				LinkResourceId = this.LinkResourceId
			};
		}

		// Token: 0x170034BB RID: 13499
		// (get) Token: 0x0600AC65 RID: 44133 RVA: 0x00185C55 File Offset: 0x00183E55
		// (set) Token: 0x0600AC66 RID: 44134 RVA: 0x00185C80 File Offset: 0x00183E80
		public override ERemovePreloadResourceObjectType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ERemovePreloadResourceObjectType.RemovePreloadResourceTrialCharacter;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170034BC RID: 13500
		// (get) Token: 0x0600AC67 RID: 44135 RVA: 0x00185C8E File Offset: 0x00183E8E
		// (set) Token: 0x0600AC68 RID: 44136 RVA: 0x00185CB9 File Offset: 0x00183EB9
		public virtual int LinkResourceId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LinkResourceId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.LinkResourceId;
			}
			set
			{
				this.GetOrCreatePoco().LinkResourceId = value;
			}
		}

		// Token: 0x0400670E RID: 26382
		[Nullable(2)]
		protected new IRemovePreloadLinkResource FbInstance;

		// Token: 0x0400670F RID: 26383
		[Nullable(2)]
		protected new IRemovePreloadLinkResource_SetValue PocoInterface;
	}
}
