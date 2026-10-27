using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007E7 RID: 2023
	[NullableContext(1)]
	[Nullable(0)]
	public class IWindDirectionalStateGrade
	{
		// Token: 0x06002BF5 RID: 11253 RVA: 0x00072764 File Offset: 0x00070964
		private IWindDirectionalStateGrade_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWindDirectionalStateGrade 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWindDirectionalStateGrade_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWindDirectionalStateGrade_SetValue());
			}
			return result;
		}

		// Token: 0x06002BF6 RID: 11254 RVA: 0x0007279C File Offset: 0x0007099C
		public static IWindDirectionalStateGrade Create([Nullable(2)] IWindDirectionalStateGrade instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWindDirectionalStateGrade
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002BF7 RID: 11255 RVA: 0x000727AF File Offset: 0x000709AF
		public static IWindDirectionalStateGrade CreateFromSetValue([Nullable(2)] IWindDirectionalStateGrade_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWindDirectionalStateGrade
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002BF8 RID: 11256 RVA: 0x000727C2 File Offset: 0x000709C2
		public IWindDirectionalStateGrade_SetValue ToSetValue()
		{
			return new IWindDirectionalStateGrade_SetValue
			{
				State = this.State,
				Speed = this.Speed,
				Strength = this.Strength
			};
		}

		// Token: 0x17000B83 RID: 2947
		// (get) Token: 0x06002BF9 RID: 11257 RVA: 0x000727ED File Offset: 0x000709ED
		// (set) Token: 0x06002BFA RID: 11258 RVA: 0x00072818 File Offset: 0x00070A18
		public virtual string State
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.State;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.State;
			}
			set
			{
				this.GetOrCreatePoco().State = value;
			}
		}

		// Token: 0x17000B84 RID: 2948
		// (get) Token: 0x06002BFB RID: 11259 RVA: 0x00072826 File Offset: 0x00070A26
		// (set) Token: 0x06002BFC RID: 11260 RVA: 0x00072855 File Offset: 0x00070A55
		public virtual float Speed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Speed;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Speed;
			}
			set
			{
				this.GetOrCreatePoco().Speed = value;
			}
		}

		// Token: 0x17000B85 RID: 2949
		// (get) Token: 0x06002BFD RID: 11261 RVA: 0x00072863 File Offset: 0x00070A63
		// (set) Token: 0x06002BFE RID: 11262 RVA: 0x00072892 File Offset: 0x00070A92
		public virtual float Strength
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Strength;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Strength;
			}
			set
			{
				this.GetOrCreatePoco().Strength = value;
			}
		}

		// Token: 0x04001D29 RID: 7465
		[Nullable(2)]
		protected IWindDirectionalStateGrade FbInstance;

		// Token: 0x04001D2A RID: 7466
		[Nullable(2)]
		protected IWindDirectionalStateGrade_SetValue PocoInterface;
	}
}
