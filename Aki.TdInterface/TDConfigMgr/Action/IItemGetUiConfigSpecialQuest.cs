using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B60 RID: 7008
	[NullableContext(2)]
	[Nullable(0)]
	public class IItemGetUiConfigSpecialQuest : IItemGetUiConfigBase
	{
		// Token: 0x06009605 RID: 38405 RVA: 0x0015AA64 File Offset: 0x00158C64
		[NullableContext(1)]
		private IItemGetUiConfigSpecialQuest_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IItemGetUiConfigSpecialQuest 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IItemGetUiConfigSpecialQuest_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IItemGetUiConfigSpecialQuest_SetValue());
			}
			return result;
		}

		// Token: 0x06009606 RID: 38406 RVA: 0x0015AA9C File Offset: 0x00158C9C
		[NullableContext(1)]
		public static IItemGetUiConfigSpecialQuest Create([Nullable(2)] IItemGetUiConfigSpecialQuest instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IItemGetUiConfigSpecialQuest
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009607 RID: 38407 RVA: 0x0015AAAF File Offset: 0x00158CAF
		[NullableContext(1)]
		public static IItemGetUiConfigSpecialQuest CreateFromSetValue([Nullable(2)] IItemGetUiConfigSpecialQuest_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IItemGetUiConfigSpecialQuest
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009608 RID: 38408 RVA: 0x0015AAC2 File Offset: 0x00158CC2
		[NullableContext(1)]
		public new IItemGetUiConfigSpecialQuest_SetValue ToSetValue()
		{
			return new IItemGetUiConfigSpecialQuest_SetValue
			{
				Type = this.Type,
				Title = this.Title,
				ShowDetail = this.ShowDetail
			};
		}

		// Token: 0x17002F49 RID: 12105
		// (get) Token: 0x06009609 RID: 38409 RVA: 0x0015AAED File Offset: 0x00158CED
		// (set) Token: 0x0600960A RID: 38410 RVA: 0x0015AB18 File Offset: 0x00158D18
		public override EItemGetUiType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return (EItemGetUiType)0;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002F4A RID: 12106
		// (get) Token: 0x0600960B RID: 38411 RVA: 0x0015AB26 File Offset: 0x00158D26
		// (set) Token: 0x0600960C RID: 38412 RVA: 0x0015AB4D File Offset: 0x00158D4D
		public virtual string Title
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Title;
				}
				IItemGetUiConfigSpecialQuest_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Title;
			}
			set
			{
				this.GetOrCreatePoco().Title = value;
			}
		}

		// Token: 0x17002F4B RID: 12107
		// (get) Token: 0x0600960D RID: 38413 RVA: 0x0015AB5C File Offset: 0x00158D5C
		// (set) Token: 0x0600960E RID: 38414 RVA: 0x0015AB96 File Offset: 0x00158D96
		public virtual bool? ShowDetail
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ShowDetail;
				}
				IItemGetUiConfigSpecialQuest_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ShowDetail;
			}
			set
			{
				this.GetOrCreatePoco().ShowDetail = value;
			}
		}

		// Token: 0x04005BC2 RID: 23490
		protected new IItemGetUiConfigSpecialQuest FbInstance;

		// Token: 0x04005BC3 RID: 23491
		protected new IItemGetUiConfigSpecialQuest_SetValue PocoInterface;
	}
}
