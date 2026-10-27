using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020BD RID: 8381
	[NullableContext(1)]
	[Nullable(0)]
	public class IWindProtagonistParkour4 : ILeisureInteractType
	{
		// Token: 0x0600B844 RID: 47172 RVA: 0x001AA848 File Offset: 0x001A8A48
		private IWindProtagonistParkour4_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWindProtagonistParkour4 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWindProtagonistParkour4_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWindProtagonistParkour4_SetValue());
			}
			return result;
		}

		// Token: 0x0600B845 RID: 47173 RVA: 0x001AA880 File Offset: 0x001A8A80
		public static IWindProtagonistParkour4 Create([Nullable(2)] IWindProtagonistParkour4 instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWindProtagonistParkour4
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B846 RID: 47174 RVA: 0x001AA893 File Offset: 0x001A8A93
		public static IWindProtagonistParkour4 CreateFromSetValue([Nullable(2)] IWindProtagonistParkour4_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWindProtagonistParkour4
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B847 RID: 47175 RVA: 0x001AA8A6 File Offset: 0x001A8AA6
		public new IWindProtagonistParkour4_SetValue ToSetValue()
		{
			return new IWindProtagonistParkour4_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700385F RID: 14431
		// (get) Token: 0x0600B848 RID: 47176 RVA: 0x001AA8B9 File Offset: 0x001A8AB9
		// (set) Token: 0x0600B849 RID: 47177 RVA: 0x001AA8E4 File Offset: 0x001A8AE4
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

		// Token: 0x04006E7A RID: 28282
		[Nullable(2)]
		protected new IWindProtagonistParkour4 FbInstance;

		// Token: 0x04006E7B RID: 28283
		[Nullable(2)]
		protected new IWindProtagonistParkour4_SetValue PocoInterface;
	}
}
