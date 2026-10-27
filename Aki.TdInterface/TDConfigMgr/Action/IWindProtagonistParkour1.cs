using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020B7 RID: 8375
	[NullableContext(1)]
	[Nullable(0)]
	public class IWindProtagonistParkour1 : ILeisureInteractType
	{
		// Token: 0x0600B82C RID: 47148 RVA: 0x001AA614 File Offset: 0x001A8814
		private IWindProtagonistParkour1_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWindProtagonistParkour1 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWindProtagonistParkour1_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWindProtagonistParkour1_SetValue());
			}
			return result;
		}

		// Token: 0x0600B82D RID: 47149 RVA: 0x001AA64C File Offset: 0x001A884C
		public static IWindProtagonistParkour1 Create([Nullable(2)] IWindProtagonistParkour1 instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWindProtagonistParkour1
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B82E RID: 47150 RVA: 0x001AA65F File Offset: 0x001A885F
		public static IWindProtagonistParkour1 CreateFromSetValue([Nullable(2)] IWindProtagonistParkour1_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWindProtagonistParkour1
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B82F RID: 47151 RVA: 0x001AA672 File Offset: 0x001A8872
		public new IWindProtagonistParkour1_SetValue ToSetValue()
		{
			return new IWindProtagonistParkour1_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700385C RID: 14428
		// (get) Token: 0x0600B830 RID: 47152 RVA: 0x001AA685 File Offset: 0x001A8885
		// (set) Token: 0x0600B831 RID: 47153 RVA: 0x001AA6B0 File Offset: 0x001A88B0
		public override ELeisureInteract Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELeisureInteract.CustomSkill;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006E71 RID: 28273
		[Nullable(2)]
		protected new IWindProtagonistParkour1 FbInstance;

		// Token: 0x04006E72 RID: 28274
		[Nullable(2)]
		protected new IWindProtagonistParkour1_SetValue PocoInterface;
	}
}
