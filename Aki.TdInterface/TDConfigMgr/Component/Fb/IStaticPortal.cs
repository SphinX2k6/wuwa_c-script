using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DF6 RID: 3574
	[NullableContext(2)]
	[Nullable(0)]
	public class IStaticPortal : IPortalMode
	{
		// Token: 0x060050FB RID: 20731 RVA: 0x000C8BCB File Offset: 0x000C6DCB
		[NullableContext(0)]
		public static IStaticPortal Create(IStaticPortal? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStaticPortal
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700190A RID: 6410
		// (get) Token: 0x060050FC RID: 20732 RVA: 0x000C8BEA File Offset: 0x000C6DEA
		public override EPortalType Type
		{
			get
			{
				return (EPortalType)this.Instance.Type;
			}
		}

		// Token: 0x1700190B RID: 6411
		// (get) Token: 0x060050FD RID: 20733 RVA: 0x000C8BF7 File Offset: 0x000C6DF7
		public override EPortalModel PortalModel
		{
			get
			{
				return (EPortalModel)this.Instance.PortalModel;
			}
		}

		// Token: 0x1700190C RID: 6412
		// (get) Token: 0x060050FE RID: 20734 RVA: 0x000C8C04 File Offset: 0x000C6E04
		public override IPortalRenderConfig RenderConfig
		{
			get
			{
				if (this._RenderConfigInited)
				{
					return this._RenderConfigCache;
				}
				this._RenderConfigInited = true;
				this._RenderConfigCache = IPortalRenderConfig.Create(this.Instance.RenderConfig);
				return this._RenderConfigCache;
			}
		}

		// Token: 0x1700190D RID: 6413
		// (get) Token: 0x060050FF RID: 20735 RVA: 0x000C8C38 File Offset: 0x000C6E38
		public virtual int LinkPortalEntityId
		{
			get
			{
				return this.Instance.LinkPortalEntityId;
			}
		}

		// Token: 0x1700190E RID: 6414
		// (get) Token: 0x06005100 RID: 20736 RVA: 0x000C8C48 File Offset: 0x000C6E48
		public virtual bool? IsStreamSource
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsStreamSource);
			}
		}

		// Token: 0x04002E23 RID: 11811
		private IStaticPortal Instance;

		// Token: 0x04002E24 RID: 11812
		private IPortalRenderConfig _RenderConfigCache;

		// Token: 0x04002E25 RID: 11813
		private bool _RenderConfigInited;
	}
}
