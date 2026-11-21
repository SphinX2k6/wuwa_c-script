using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020D6 RID: 8406
	public class ISplineMoveConfig
	{
		// Token: 0x0600B276 RID: 45686 RVA: 0x00190C74 File Offset: 0x0018EE74
		private ISplineMoveConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISplineMoveConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISplineMoveConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISplineMoveConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600B277 RID: 45687 RVA: 0x00190CAC File Offset: 0x0018EEAC
		public static ISplineMoveConfig Create([Nullable(2)] ISplineMoveConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISplineMoveConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B278 RID: 45688 RVA: 0x00190CBF File Offset: 0x0018EEBF
		public static ISplineMoveConfig CreateFromSetValue([Nullable(2)] ISplineMoveConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISplineMoveConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B279 RID: 45689 RVA: 0x00190CD2 File Offset: 0x0018EED2
		public ISplineMoveConfig_SetValue ToSetValue()
		{
			return new ISplineMoveConfig_SetValue
			{
				Type = this.Type,
				Target = this.Target,
				SplineEntityId = this.SplineEntityId
			};
		}

		// Token: 0x17003609 RID: 13833
		// (get) Token: 0x0600B27A RID: 45690 RVA: 0x00190CFD File Offset: 0x0018EEFD
		// (set) Token: 0x0600B27B RID: 45691 RVA: 0x00190D28 File Offset: 0x0018EF28
		public virtual ESplineMoveConfigType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESplineMoveConfigType.Open;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700360A RID: 13834
		// (get) Token: 0x0600B27C RID: 45692 RVA: 0x00190D36 File Offset: 0x0018EF36
		// (set) Token: 0x0600B27D RID: 45693 RVA: 0x00190D5D File Offset: 0x0018EF5D
		public virtual ITargetEntityType Target
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Target;
				}
				ISplineMoveConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Target;
			}
			set
			{
				this.GetOrCreatePoco().Target = value;
			}
		}

		// Token: 0x1700360B RID: 13835
		// (get) Token: 0x0600B27E RID: 45694 RVA: 0x00190D6B File Offset: 0x0018EF6B
		// (set) Token: 0x0600B27F RID: 45695 RVA: 0x00190D96 File Offset: 0x0018EF96
		public virtual int SplineEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SplineEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.SplineEntityId;
			}
			set
			{
				this.GetOrCreatePoco().SplineEntityId = value;
			}
		}

		// Token: 0x040069E6 RID: 27110
		[Nullable(2)]
		protected ISplineMoveConfig FbInstance;

		// Token: 0x040069E7 RID: 27111
		[Nullable(2)]
		protected ISplineMoveConfig_SetValue PocoInterface;
	}
}
