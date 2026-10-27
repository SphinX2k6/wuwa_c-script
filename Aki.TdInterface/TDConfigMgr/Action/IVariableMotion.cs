using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200202F RID: 8239
	[NullableContext(1)]
	[Nullable(0)]
	public class IVariableMotion : ISceneItemMoveMotionType
	{
		// Token: 0x0600B516 RID: 46358 RVA: 0x001A4B38 File Offset: 0x001A2D38
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

		// Token: 0x0600B517 RID: 46359 RVA: 0x001A4B70 File Offset: 0x001A2D70
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

		// Token: 0x0600B518 RID: 46360 RVA: 0x001A4B83 File Offset: 0x001A2D83
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

		// Token: 0x0600B519 RID: 46361 RVA: 0x001A4B96 File Offset: 0x001A2D96
		public new IVariableMotion_SetValue ToSetValue()
		{
			return new IVariableMotion_SetValue
			{
				Type = this.Type,
				Acceleration = this.Acceleration,
				MaxSpeed = this.MaxSpeed
			};
		}

		// Token: 0x1700379D RID: 14237
		// (get) Token: 0x0600B51A RID: 46362 RVA: 0x001A4BC1 File Offset: 0x001A2DC1
		// (set) Token: 0x0600B51B RID: 46363 RVA: 0x001A4BEC File Offset: 0x001A2DEC
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

		// Token: 0x1700379E RID: 14238
		// (get) Token: 0x0600B51C RID: 46364 RVA: 0x001A4BFA File Offset: 0x001A2DFA
		// (set) Token: 0x0600B51D RID: 46365 RVA: 0x001A4C29 File Offset: 0x001A2E29
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

		// Token: 0x1700379F RID: 14239
		// (get) Token: 0x0600B51E RID: 46366 RVA: 0x001A4C37 File Offset: 0x001A2E37
		// (set) Token: 0x0600B51F RID: 46367 RVA: 0x001A4C66 File Offset: 0x001A2E66
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

		// Token: 0x04006D06 RID: 27910
		[Nullable(2)]
		protected new IVariableMotion FbInstance;

		// Token: 0x04006D07 RID: 27911
		[Nullable(2)]
		protected new IVariableMotion_SetValue PocoInterface;
	}
}
