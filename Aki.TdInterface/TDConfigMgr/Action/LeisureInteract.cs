using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020C9 RID: 8393
	[NullableContext(1)]
	[Nullable(0)]
	public class LeisureInteract : ActionParams
	{
		// Token: 0x0600B878 RID: 47224 RVA: 0x001AAD38 File Offset: 0x001A8F38
		private LeisureInteract_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("LeisureInteract 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			LeisureInteract_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new LeisureInteract_SetValue());
			}
			return result;
		}

		// Token: 0x0600B879 RID: 47225 RVA: 0x001AAD70 File Offset: 0x001A8F70
		public static LeisureInteract Create([Nullable(2)] LeisureInteract instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new LeisureInteract
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B87A RID: 47226 RVA: 0x001AAD83 File Offset: 0x001A8F83
		public static LeisureInteract CreateFromSetValue([Nullable(2)] LeisureInteract_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new LeisureInteract
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B87B RID: 47227 RVA: 0x001AAD96 File Offset: 0x001A8F96
		public LeisureInteract_SetValue ToSetValue()
		{
			return new LeisureInteract_SetValue
			{
				Option = this.Option,
				SceneEntity = this.SceneEntity
			};
		}

		// Token: 0x17003867 RID: 14439
		// (get) Token: 0x0600B87C RID: 47228 RVA: 0x001AADB5 File Offset: 0x001A8FB5
		// (set) Token: 0x0600B87D RID: 47229 RVA: 0x001AADDC File Offset: 0x001A8FDC
		public virtual ILeisureInteractType Option
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Option;
				}
				LeisureInteract_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Option;
			}
			set
			{
				this.GetOrCreatePoco().Option = value;
			}
		}

		// Token: 0x17003868 RID: 14440
		// (get) Token: 0x0600B87E RID: 47230 RVA: 0x001AADEC File Offset: 0x001A8FEC
		// (set) Token: 0x0600B87F RID: 47231 RVA: 0x001AAE26 File Offset: 0x001A9026
		public virtual int? SceneEntity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SceneEntity;
				}
				LeisureInteract_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SceneEntity;
			}
			set
			{
				this.GetOrCreatePoco().SceneEntity = value;
			}
		}

		// Token: 0x04006E8E RID: 28302
		[Nullable(2)]
		protected new LeisureInteract FbInstance;

		// Token: 0x04006E8F RID: 28303
		[Nullable(2)]
		protected LeisureInteract_SetValue PocoInterface;
	}
}
