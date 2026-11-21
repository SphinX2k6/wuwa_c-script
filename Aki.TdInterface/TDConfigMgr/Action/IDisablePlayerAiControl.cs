using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B3D RID: 6973
	[JsonConverter(typeof(IDisablePlayerAiControlConverter))]
	public class IDisablePlayerAiControl : IPlayerAiControlBase
	{
		// Token: 0x06009427 RID: 37927 RVA: 0x0015A228 File Offset: 0x00158428
		private IDisablePlayerAiControl_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDisablePlayerAiControl 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDisablePlayerAiControl_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDisablePlayerAiControl_SetValue());
			}
			return result;
		}

		// Token: 0x06009428 RID: 37928 RVA: 0x0015A260 File Offset: 0x00158460
		public static IDisablePlayerAiControl Create([Nullable(2)] IDisablePlayerAiControl instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDisablePlayerAiControl
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009429 RID: 37929 RVA: 0x0015A273 File Offset: 0x00158473
		public static IDisablePlayerAiControl CreateFromSetValue([Nullable(2)] IDisablePlayerAiControl_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDisablePlayerAiControl
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600942A RID: 37930 RVA: 0x0015A286 File Offset: 0x00158486
		public new IDisablePlayerAiControl_SetValue ToSetValue()
		{
			return new IDisablePlayerAiControl_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002F44 RID: 12100
		// (get) Token: 0x0600942B RID: 37931 RVA: 0x0015A299 File Offset: 0x00158499
		// (set) Token: 0x0600942C RID: 37932 RVA: 0x0015A2C4 File Offset: 0x001584C4
		public override EPlayerAiControlType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPlayerAiControlType.Enable;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005BF5 RID: 23541
		[Nullable(2)]
		protected new IDisablePlayerAiControl FbInstance;

		// Token: 0x04005BF6 RID: 23542
		[Nullable(2)]
		protected new IDisablePlayerAiControl_SetValue PocoInterface;
	}
}
