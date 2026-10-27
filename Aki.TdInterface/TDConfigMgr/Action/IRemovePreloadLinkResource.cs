using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D98 RID: 7576
	[NullableContext(1)]
	[Nullable(0)]
	public class IRemovePreloadLinkResource : IRemovePreloadResourceCharacterType
	{
		// Token: 0x0600A261 RID: 41569 RVA: 0x001715B0 File Offset: 0x0016F7B0
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

		// Token: 0x0600A262 RID: 41570 RVA: 0x001715E8 File Offset: 0x0016F7E8
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

		// Token: 0x0600A263 RID: 41571 RVA: 0x001715FB File Offset: 0x0016F7FB
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

		// Token: 0x0600A264 RID: 41572 RVA: 0x0017160E File Offset: 0x0016F80E
		public new IRemovePreloadLinkResource_SetValue ToSetValue()
		{
			return new IRemovePreloadLinkResource_SetValue
			{
				Type = this.Type,
				LinkResourceId = this.LinkResourceId
			};
		}

		// Token: 0x17003223 RID: 12835
		// (get) Token: 0x0600A265 RID: 41573 RVA: 0x0017162D File Offset: 0x0016F82D
		// (set) Token: 0x0600A266 RID: 41574 RVA: 0x00171658 File Offset: 0x0016F858
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

		// Token: 0x17003224 RID: 12836
		// (get) Token: 0x0600A267 RID: 41575 RVA: 0x00171666 File Offset: 0x0016F866
		// (set) Token: 0x0600A268 RID: 41576 RVA: 0x00171691 File Offset: 0x0016F891
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

		// Token: 0x0400618A RID: 24970
		[Nullable(2)]
		protected new IRemovePreloadLinkResource FbInstance;

		// Token: 0x0400618B RID: 24971
		[Nullable(2)]
		protected new IRemovePreloadLinkResource_SetValue PocoInterface;
	}
}
