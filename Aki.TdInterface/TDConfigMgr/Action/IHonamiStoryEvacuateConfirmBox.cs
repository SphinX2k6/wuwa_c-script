using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B17 RID: 6935
	[NullableContext(1)]
	[Nullable(0)]
	public class IHonamiStoryEvacuateConfirmBox : IInteractionConfirmBoxType
	{
		// Token: 0x0600947E RID: 38014 RVA: 0x00157D58 File Offset: 0x00155F58
		private IHonamiStoryEvacuateConfirmBox_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHonamiStoryEvacuateConfirmBox 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHonamiStoryEvacuateConfirmBox_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHonamiStoryEvacuateConfirmBox_SetValue());
			}
			return result;
		}

		// Token: 0x0600947F RID: 38015 RVA: 0x00157D90 File Offset: 0x00155F90
		public static IHonamiStoryEvacuateConfirmBox Create([Nullable(2)] IHonamiStoryEvacuateConfirmBox instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHonamiStoryEvacuateConfirmBox
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009480 RID: 38016 RVA: 0x00157DA3 File Offset: 0x00155FA3
		public static IHonamiStoryEvacuateConfirmBox CreateFromSetValue([Nullable(2)] IHonamiStoryEvacuateConfirmBox_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHonamiStoryEvacuateConfirmBox
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009481 RID: 38017 RVA: 0x00157DB6 File Offset: 0x00155FB6
		public new IHonamiStoryEvacuateConfirmBox_SetValue ToSetValue()
		{
			return new IHonamiStoryEvacuateConfirmBox_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002EF2 RID: 12018
		// (get) Token: 0x06009482 RID: 38018 RVA: 0x00157DC9 File Offset: 0x00155FC9
		// (set) Token: 0x06009483 RID: 38019 RVA: 0x00157DF4 File Offset: 0x00155FF4
		public override EInteractionConfirmBoxType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInteractionConfirmBoxType.Common;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005B07 RID: 23303
		[Nullable(2)]
		protected new IHonamiStoryEvacuateConfirmBox FbInstance;

		// Token: 0x04005B08 RID: 23304
		[Nullable(2)]
		protected new IHonamiStoryEvacuateConfirmBox_SetValue PocoInterface;
	}
}
