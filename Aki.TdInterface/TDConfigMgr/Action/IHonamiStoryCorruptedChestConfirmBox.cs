using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B13 RID: 6931
	[NullableContext(1)]
	[Nullable(0)]
	public class IHonamiStoryCorruptedChestConfirmBox : IInteractionConfirmBoxType
	{
		// Token: 0x0600946A RID: 37994 RVA: 0x00157B58 File Offset: 0x00155D58
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

		// Token: 0x0600946B RID: 37995 RVA: 0x00157B90 File Offset: 0x00155D90
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

		// Token: 0x0600946C RID: 37996 RVA: 0x00157BA3 File Offset: 0x00155DA3
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

		// Token: 0x0600946D RID: 37997 RVA: 0x00157BB6 File Offset: 0x00155DB6
		public new IHonamiStoryCorruptedChestConfirmBox_SetValue ToSetValue()
		{
			return new IHonamiStoryCorruptedChestConfirmBox_SetValue
			{
				Type = this.Type,
				Id = this.Id
			};
		}

		// Token: 0x17002EEE RID: 12014
		// (get) Token: 0x0600946E RID: 37998 RVA: 0x00157BD5 File Offset: 0x00155DD5
		// (set) Token: 0x0600946F RID: 37999 RVA: 0x00157C00 File Offset: 0x00155E00
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

		// Token: 0x17002EEF RID: 12015
		// (get) Token: 0x06009470 RID: 38000 RVA: 0x00157C0E File Offset: 0x00155E0E
		// (set) Token: 0x06009471 RID: 38001 RVA: 0x00157C39 File Offset: 0x00155E39
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

		// Token: 0x04005AFF RID: 23295
		[Nullable(2)]
		protected new IHonamiStoryCorruptedChestConfirmBox FbInstance;

		// Token: 0x04005B00 RID: 23296
		[Nullable(2)]
		protected new IHonamiStoryCorruptedChestConfirmBox_SetValue PocoInterface;
	}
}
