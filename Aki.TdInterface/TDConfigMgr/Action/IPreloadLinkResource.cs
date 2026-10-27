using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D48 RID: 7496
	[NullableContext(1)]
	[Nullable(0)]
	public class IPreloadLinkResource : IPreloadCharacterType
	{
		// Token: 0x0600A0D3 RID: 41171 RVA: 0x0016EB70 File Offset: 0x0016CD70
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

		// Token: 0x0600A0D4 RID: 41172 RVA: 0x0016EBA8 File Offset: 0x0016CDA8
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

		// Token: 0x0600A0D5 RID: 41173 RVA: 0x0016EBBB File Offset: 0x0016CDBB
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

		// Token: 0x0600A0D6 RID: 41174 RVA: 0x0016EBCE File Offset: 0x0016CDCE
		public new IPreloadLinkResource_SetValue ToSetValue()
		{
			return new IPreloadLinkResource_SetValue
			{
				Type = this.Type,
				LinkResourceId = this.LinkResourceId
			};
		}

		// Token: 0x170031D4 RID: 12756
		// (get) Token: 0x0600A0D7 RID: 41175 RVA: 0x0016EBED File Offset: 0x0016CDED
		// (set) Token: 0x0600A0D8 RID: 41176 RVA: 0x0016EC18 File Offset: 0x0016CE18
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

		// Token: 0x170031D5 RID: 12757
		// (get) Token: 0x0600A0D9 RID: 41177 RVA: 0x0016EC26 File Offset: 0x0016CE26
		// (set) Token: 0x0600A0DA RID: 41178 RVA: 0x0016EC51 File Offset: 0x0016CE51
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

		// Token: 0x040060E1 RID: 24801
		[Nullable(2)]
		protected new IPreloadLinkResource FbInstance;

		// Token: 0x040060E2 RID: 24802
		[Nullable(2)]
		protected new IPreloadLinkResource_SetValue PocoInterface;
	}
}
