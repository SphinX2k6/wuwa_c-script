using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F59 RID: 8025
	public class IPreloadLinkResource : IPreloadCharacterType
	{
		// Token: 0x0600AABF RID: 43711 RVA: 0x00182F94 File Offset: 0x00181194
		private IPreloadLinkResource_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPreloadLinkResource 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPreloadLinkResource_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPreloadLinkResource_SetValue());
			}
			return result;
		}

		// Token: 0x0600AAC0 RID: 43712 RVA: 0x00182FCC File Offset: 0x001811CC
		public static IPreloadLinkResource Create([Nullable(2)] IPreloadLinkResource instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPreloadLinkResource
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AAC1 RID: 43713 RVA: 0x00182FDF File Offset: 0x001811DF
		public static IPreloadLinkResource CreateFromSetValue([Nullable(2)] IPreloadLinkResource_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPreloadLinkResource
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AAC2 RID: 43714 RVA: 0x00182FF2 File Offset: 0x001811F2
		public new IPreloadLinkResource_SetValue ToSetValue()
		{
			return new IPreloadLinkResource_SetValue
			{
				Type = this.Type,
				LinkResourceId = this.LinkResourceId
			};
		}

		// Token: 0x17003468 RID: 13416
		// (get) Token: 0x0600AAC3 RID: 43715 RVA: 0x00183011 File Offset: 0x00181211
		// (set) Token: 0x0600AAC4 RID: 43716 RVA: 0x0018303C File Offset: 0x0018123C
		public override EPreloadObjectType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPreloadObjectType.PreloadTrialCharacterForSkill;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003469 RID: 13417
		// (get) Token: 0x0600AAC5 RID: 43717 RVA: 0x0018304A File Offset: 0x0018124A
		// (set) Token: 0x0600AAC6 RID: 43718 RVA: 0x00183075 File Offset: 0x00181275
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

		// Token: 0x0400665D RID: 26205
		[Nullable(2)]
		protected new IPreloadLinkResource FbInstance;

		// Token: 0x0400665E RID: 26206
		[Nullable(2)]
		protected new IPreloadLinkResource_SetValue PocoInterface;
	}
}
