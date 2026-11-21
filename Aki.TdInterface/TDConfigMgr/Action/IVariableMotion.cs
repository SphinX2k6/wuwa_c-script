using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002278 RID: 8824
	public class IVariableMotion : ISceneItemMoveMotionType
	{
		// Token: 0x0600C03C RID: 49212 RVA: 0x001BB2A4 File Offset: 0x001B94A4
		private IVariableMotion_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVariableMotion 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVariableMotion_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVariableMotion_SetValue());
			}
			return result;
		}

		// Token: 0x0600C03D RID: 49213 RVA: 0x001BB2DC File Offset: 0x001B94DC
		public static IVariableMotion Create([Nullable(2)] IVariableMotion instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVariableMotion
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C03E RID: 49214 RVA: 0x001BB2EF File Offset: 0x001B94EF
		public static IVariableMotion CreateFromSetValue([Nullable(2)] IVariableMotion_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVariableMotion
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C03F RID: 49215 RVA: 0x001BB302 File Offset: 0x001B9502
		public new IVariableMotion_SetValue ToSetValue()
		{
			return new IVariableMotion_SetValue
			{
				Type = this.Type,
				Acceleration = this.Acceleration,
				MaxSpeed = this.MaxSpeed
			};
		}

		// Token: 0x17003A7A RID: 14970
		// (get) Token: 0x0600C040 RID: 49216 RVA: 0x001BB32D File Offset: 0x001B952D
		// (set) Token: 0x0600C041 RID: 49217 RVA: 0x001BB358 File Offset: 0x001B9558
		public override EMoveMotion Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMoveMotion.UniformMotion;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003A7B RID: 14971
		// (get) Token: 0x0600C042 RID: 49218 RVA: 0x001BB366 File Offset: 0x001B9566
		// (set) Token: 0x0600C043 RID: 49219 RVA: 0x001BB395 File Offset: 0x001B9595
		public virtual float Acceleration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Acceleration;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Acceleration;
			}
			set
			{
				this.GetOrCreatePoco().Acceleration = value;
			}
		}

		// Token: 0x17003A7C RID: 14972
		// (get) Token: 0x0600C044 RID: 49220 RVA: 0x001BB3A3 File Offset: 0x001B95A3
		// (set) Token: 0x0600C045 RID: 49221 RVA: 0x001BB3D2 File Offset: 0x001B95D2
		public virtual float MaxSpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxSpeed;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.MaxSpeed;
			}
			set
			{
				this.GetOrCreatePoco().MaxSpeed = value;
			}
		}

		// Token: 0x0400730F RID: 29455
		[Nullable(2)]
		protected new IVariableMotion FbInstance;

		// Token: 0x04007310 RID: 29456
		[Nullable(2)]
		protected new IVariableMotion_SetValue PocoInterface;
	}
}
