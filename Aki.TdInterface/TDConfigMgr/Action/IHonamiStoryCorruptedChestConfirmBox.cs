using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CC2 RID: 7362
	public class IHonamiStoryCorruptedChestConfirmBox : IInteractionConfirmBoxType
	{
		// Token: 0x06009C54 RID: 40020 RVA: 0x00168834 File Offset: 0x00166A34
		private IHonamiStoryCorruptedChestConfirmBox_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHonamiStoryCorruptedChestConfirmBox 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHonamiStoryCorruptedChestConfirmBox_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHonamiStoryCorruptedChestConfirmBox_SetValue());
			}
			return result;
		}

		// Token: 0x06009C55 RID: 40021 RVA: 0x0016886C File Offset: 0x00166A6C
		public static IHonamiStoryCorruptedChestConfirmBox Create([Nullable(2)] IHonamiStoryCorruptedChestConfirmBox instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHonamiStoryCorruptedChestConfirmBox
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009C56 RID: 40022 RVA: 0x0016887F File Offset: 0x00166A7F
		public static IHonamiStoryCorruptedChestConfirmBox CreateFromSetValue([Nullable(2)] IHonamiStoryCorruptedChestConfirmBox_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHonamiStoryCorruptedChestConfirmBox
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009C57 RID: 40023 RVA: 0x00168892 File Offset: 0x00166A92
		public new IHonamiStoryCorruptedChestConfirmBox_SetValue ToSetValue()
		{
			return new IHonamiStoryCorruptedChestConfirmBox_SetValue
			{
				Type = this.Type,
				Id = this.Id
			};
		}

		// Token: 0x17003114 RID: 12564
		// (get) Token: 0x06009C58 RID: 40024 RVA: 0x001688B1 File Offset: 0x00166AB1
		// (set) Token: 0x06009C59 RID: 40025 RVA: 0x001688DC File Offset: 0x00166ADC
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

		// Token: 0x17003115 RID: 12565
		// (get) Token: 0x06009C5A RID: 40026 RVA: 0x001688EA File Offset: 0x00166AEA
		// (set) Token: 0x06009C5B RID: 40027 RVA: 0x00168915 File Offset: 0x00166B15
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x04005F9D RID: 24477
		[Nullable(2)]
		protected new IHonamiStoryCorruptedChestConfirmBox FbInstance;

		// Token: 0x04005F9E RID: 24478
		[Nullable(2)]
		protected new IHonamiStoryCorruptedChestConfirmBox_SetValue PocoInterface;
	}
}
