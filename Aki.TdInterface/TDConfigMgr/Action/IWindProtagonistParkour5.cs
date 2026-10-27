using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020BF RID: 8383
	[NullableContext(1)]
	[Nullable(0)]
	public class IWindProtagonistParkour5 : ILeisureInteractType
	{
		// Token: 0x0600B84C RID: 47180 RVA: 0x001AA904 File Offset: 0x001A8B04
		private IWindProtagonistParkour5_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWindProtagonistParkour5 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWindProtagonistParkour5_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWindProtagonistParkour5_SetValue());
			}
			return result;
		}

		// Token: 0x0600B84D RID: 47181 RVA: 0x001AA93C File Offset: 0x001A8B3C
		public static IWindProtagonistParkour5 Create([Nullable(2)] IWindProtagonistParkour5 instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWindProtagonistParkour5
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B84E RID: 47182 RVA: 0x001AA94F File Offset: 0x001A8B4F
		public static IWindProtagonistParkour5 CreateFromSetValue([Nullable(2)] IWindProtagonistParkour5_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWindProtagonistParkour5
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B84F RID: 47183 RVA: 0x001AA962 File Offset: 0x001A8B62
		public new IWindProtagonistParkour5_SetValue ToSetValue()
		{
			return new IWindProtagonistParkour5_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003860 RID: 14432
		// (get) Token: 0x0600B850 RID: 47184 RVA: 0x001AA975 File Offset: 0x001A8B75
		// (set) Token: 0x0600B851 RID: 47185 RVA: 0x001AA9A0 File Offset: 0x001A8BA0
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

		// Token: 0x04006E7D RID: 28285
		[Nullable(2)]
		protected new IWindProtagonistParkour5 FbInstance;

		// Token: 0x04006E7E RID: 28286
		[Nullable(2)]
		protected new IWindProtagonistParkour5_SetValue PocoInterface;
	}
}
