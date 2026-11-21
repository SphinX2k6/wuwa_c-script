using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B3F RID: 6975
	public class IDisableRideFlyingCarUiGameplay : IToggleRideFlyingCarUiGameplayConfig
	{
		// Token: 0x0600942F RID: 37935 RVA: 0x0015A2E4 File Offset: 0x001584E4
		private IDisableRideFlyingCarUiGameplay_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDisableRideFlyingCarUiGameplay 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDisableRideFlyingCarUiGameplay_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDisableRideFlyingCarUiGameplay_SetValue());
			}
			return result;
		}

		// Token: 0x06009430 RID: 37936 RVA: 0x0015A31C File Offset: 0x0015851C
		public static IDisableRideFlyingCarUiGameplay Create([Nullable(2)] IDisableRideFlyingCarUiGameplay instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDisableRideFlyingCarUiGameplay
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009431 RID: 37937 RVA: 0x0015A32F File Offset: 0x0015852F
		public static IDisableRideFlyingCarUiGameplay CreateFromSetValue([Nullable(2)] IDisableRideFlyingCarUiGameplay_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDisableRideFlyingCarUiGameplay
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009432 RID: 37938 RVA: 0x0015A342 File Offset: 0x00158542
		public new IDisableRideFlyingCarUiGameplay_SetValue ToSetValue()
		{
			return new IDisableRideFlyingCarUiGameplay_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002F45 RID: 12101
		// (get) Token: 0x06009433 RID: 37939 RVA: 0x0015A355 File Offset: 0x00158555
		// (set) Token: 0x06009434 RID: 37940 RVA: 0x0015A380 File Offset: 0x00158580
		public override EToggleRideFlyingCarUiGameplayType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EToggleRideFlyingCarUiGameplayType.Enable;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005BF8 RID: 23544
		[Nullable(2)]
		protected new IDisableRideFlyingCarUiGameplay FbInstance;

		// Token: 0x04005BF9 RID: 23545
		[Nullable(2)]
		protected new IDisableRideFlyingCarUiGameplay_SetValue PocoInterface;
	}
}
