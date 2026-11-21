using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004EC RID: 1260
	public class IInteractStyleEntityPart : IInteractStyleBase
	{
		// Token: 0x06001922 RID: 6434 RVA: 0x0004AFA4 File Offset: 0x000491A4
		private IInteractStyleEntityPart_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInteractStyleEntityPart 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInteractStyleEntityPart_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInteractStyleEntityPart_SetValue());
			}
			return result;
		}

		// Token: 0x06001923 RID: 6435 RVA: 0x0004AFDC File Offset: 0x000491DC
		public static IInteractStyleEntityPart Create([Nullable(2)] IInteractStyleEntityPart instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractStyleEntityPart
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001924 RID: 6436 RVA: 0x0004AFEF File Offset: 0x000491EF
		public static IInteractStyleEntityPart CreateFromSetValue([Nullable(2)] IInteractStyleEntityPart_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInteractStyleEntityPart
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001925 RID: 6437 RVA: 0x0004B002 File Offset: 0x00049202
		public new IInteractStyleEntityPart_SetValue ToSetValue()
		{
			return new IInteractStyleEntityPart_SetValue
			{
				Type = this.Type,
				Bind = this.Bind,
				ShowAngle = this.ShowAngle,
				TriggerAngle = this.TriggerAngle
			};
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x06001926 RID: 6438 RVA: 0x0004B039 File Offset: 0x00049239
		// (set) Token: 0x06001927 RID: 6439 RVA: 0x0004B064 File Offset: 0x00049264
		public override EInteractStyleType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInteractStyleType.Panorama;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x06001928 RID: 6440 RVA: 0x0004B072 File Offset: 0x00049272
		// (set) Token: 0x06001929 RID: 6441 RVA: 0x0004B099 File Offset: 0x00049299
		public virtual IInteractEntityPartBindBase Bind
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Bind;
				}
				IInteractStyleEntityPart_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Bind;
			}
			set
			{
				this.GetOrCreatePoco().Bind = value;
			}
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x0600192A RID: 6442 RVA: 0x0004B0A7 File Offset: 0x000492A7
		// (set) Token: 0x0600192B RID: 6443 RVA: 0x0004B0D6 File Offset: 0x000492D6
		public virtual float ShowAngle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ShowAngle;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.ShowAngle;
			}
			set
			{
				this.GetOrCreatePoco().ShowAngle = value;
			}
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x0600192C RID: 6444 RVA: 0x0004B0E4 File Offset: 0x000492E4
		// (set) Token: 0x0600192D RID: 6445 RVA: 0x0004B113 File Offset: 0x00049313
		public virtual float TriggerAngle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TriggerAngle;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.TriggerAngle;
			}
			set
			{
				this.GetOrCreatePoco().TriggerAngle = value;
			}
		}

		// Token: 0x040012BB RID: 4795
		[Nullable(2)]
		protected new IInteractStyleEntityPart FbInstance;

		// Token: 0x040012BC RID: 4796
		[Nullable(2)]
		protected new IInteractStyleEntityPart_SetValue PocoInterface;
	}
}
