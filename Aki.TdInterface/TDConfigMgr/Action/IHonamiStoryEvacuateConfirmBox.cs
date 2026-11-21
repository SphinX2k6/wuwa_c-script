using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CC6 RID: 7366
	public class IHonamiStoryEvacuateConfirmBox : IInteractionConfirmBoxType
	{
		// Token: 0x06009C68 RID: 40040 RVA: 0x00168A34 File Offset: 0x00166C34
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

		// Token: 0x06009C69 RID: 40041 RVA: 0x00168A6C File Offset: 0x00166C6C
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

		// Token: 0x06009C6A RID: 40042 RVA: 0x00168A7F File Offset: 0x00166C7F
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

		// Token: 0x06009C6B RID: 40043 RVA: 0x00168A92 File Offset: 0x00166C92
		public new IHonamiStoryEvacuateConfirmBox_SetValue ToSetValue()
		{
			return new IHonamiStoryEvacuateConfirmBox_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003118 RID: 12568
		// (get) Token: 0x06009C6C RID: 40044 RVA: 0x00168AA5 File Offset: 0x00166CA5
		// (set) Token: 0x06009C6D RID: 40045 RVA: 0x00168AD0 File Offset: 0x00166CD0
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

		// Token: 0x04005FA5 RID: 24485
		[Nullable(2)]
		protected new IHonamiStoryEvacuateConfirmBox FbInstance;

		// Token: 0x04005FA6 RID: 24486
		[Nullable(2)]
		protected new IHonamiStoryEvacuateConfirmBox_SetValue PocoInterface;
	}
}
