using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001148 RID: 4424
	[NullableContext(1)]
	[Nullable(0)]
	public class IStalkingGamePlayConfig : ISpecialGamePlayConfig
	{
		// Token: 0x0600646A RID: 25706 RVA: 0x000F1660 File Offset: 0x000EF860
		private IStalkingGamePlayConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IStalkingGamePlayConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IStalkingGamePlayConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IStalkingGamePlayConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600646B RID: 25707 RVA: 0x000F1698 File Offset: 0x000EF898
		public static IStalkingGamePlayConfig Create([Nullable(2)] IStalkingGamePlayConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStalkingGamePlayConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600646C RID: 25708 RVA: 0x000F16AB File Offset: 0x000EF8AB
		public static IStalkingGamePlayConfig CreateFromSetValue([Nullable(2)] IStalkingGamePlayConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IStalkingGamePlayConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600646D RID: 25709 RVA: 0x000F16BE File Offset: 0x000EF8BE
		public new IStalkingGamePlayConfig_SetValue ToSetValue()
		{
			return new IStalkingGamePlayConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170020CE RID: 8398
		// (get) Token: 0x0600646E RID: 25710 RVA: 0x000F16D1 File Offset: 0x000EF8D1
		// (set) Token: 0x0600646F RID: 25711 RVA: 0x000F16FC File Offset: 0x000EF8FC
		public override ESpecialGamePlayConfigType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESpecialGamePlayConfigType.Stalking;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003C53 RID: 15443
		[Nullable(2)]
		protected new IStalkingGamePlayConfig FbInstance;

		// Token: 0x04003C54 RID: 15444
		[Nullable(2)]
		protected new IStalkingGamePlayConfig_SetValue PocoInterface;
	}
}
