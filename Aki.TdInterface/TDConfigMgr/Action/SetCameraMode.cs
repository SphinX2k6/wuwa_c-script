using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021A7 RID: 8615
	[NullableContext(1)]
	[Nullable(0)]
	public class SetCameraMode : ActionParams
	{
		// Token: 0x0600BD2C RID: 48428 RVA: 0x001B3B9C File Offset: 0x001B1D9C
		private SetCameraMode_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetCameraMode 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetCameraMode_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetCameraMode_SetValue());
			}
			return result;
		}

		// Token: 0x0600BD2D RID: 48429 RVA: 0x001B3BD4 File Offset: 0x001B1DD4
		public static SetCameraMode Create([Nullable(2)] SetCameraMode instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetCameraMode
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BD2E RID: 48430 RVA: 0x001B3BE7 File Offset: 0x001B1DE7
		public static SetCameraMode CreateFromSetValue([Nullable(2)] SetCameraMode_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetCameraMode
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BD2F RID: 48431 RVA: 0x001B3BFA File Offset: 0x001B1DFA
		public SetCameraMode_SetValue ToSetValue()
		{
			return new SetCameraMode_SetValue
			{
				Mode = this.Mode
			};
		}

		// Token: 0x1700397C RID: 14716
		// (get) Token: 0x0600BD30 RID: 48432 RVA: 0x001B3C0D File Offset: 0x001B1E0D
		// (set) Token: 0x0600BD31 RID: 48433 RVA: 0x001B3C38 File Offset: 0x001B1E38
		public virtual string Mode
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Mode;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Mode;
			}
			set
			{
				this.GetOrCreatePoco().Mode = value;
			}
		}

		// Token: 0x040070E3 RID: 28899
		[Nullable(2)]
		protected new SetCameraMode FbInstance;

		// Token: 0x040070E4 RID: 28900
		[Nullable(2)]
		protected SetCameraMode_SetValue PocoInterface;
	}
}
