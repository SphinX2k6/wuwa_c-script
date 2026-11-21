using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018CA RID: 6346
	public class HonamiStoryGetItem : ActionParams
	{
		// Token: 0x06008517 RID: 34071 RVA: 0x0013D590 File Offset: 0x0013B790
		private HonamiStoryGetItem_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("HonamiStoryGetItem 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			HonamiStoryGetItem_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new HonamiStoryGetItem_SetValue());
			}
			return result;
		}

		// Token: 0x06008518 RID: 34072 RVA: 0x0013D5C8 File Offset: 0x0013B7C8
		public static HonamiStoryGetItem Create([Nullable(2)] HonamiStoryGetItem instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new HonamiStoryGetItem
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008519 RID: 34073 RVA: 0x0013D5DB File Offset: 0x0013B7DB
		public static HonamiStoryGetItem CreateFromSetValue([Nullable(2)] HonamiStoryGetItem_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new HonamiStoryGetItem
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600851A RID: 34074 RVA: 0x0013D5EE File Offset: 0x0013B7EE
		public HonamiStoryGetItem_SetValue ToSetValue()
		{
			return new HonamiStoryGetItem_SetValue
			{
				ActivityId = this.ActivityId,
				ItemId = this.ItemId
			};
		}

		// Token: 0x17002B68 RID: 11112
		// (get) Token: 0x0600851B RID: 34075 RVA: 0x0013D60D File Offset: 0x0013B80D
		// (set) Token: 0x0600851C RID: 34076 RVA: 0x0013D638 File Offset: 0x0013B838
		public virtual int ActivityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ActivityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ActivityId;
			}
			set
			{
				this.GetOrCreatePoco().ActivityId = value;
			}
		}

		// Token: 0x17002B69 RID: 11113
		// (get) Token: 0x0600851D RID: 34077 RVA: 0x0013D646 File Offset: 0x0013B846
		// (set) Token: 0x0600851E RID: 34078 RVA: 0x0013D66D File Offset: 0x0013B86D
		public virtual List<int> ItemId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ItemId;
				}
				HonamiStoryGetItem_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ItemId;
			}
			set
			{
				this.GetOrCreatePoco().ItemId = value;
			}
		}

		// Token: 0x04005498 RID: 21656
		[Nullable(2)]
		protected new HonamiStoryGetItem FbInstance;

		// Token: 0x04005499 RID: 21657
		[Nullable(2)]
		protected HonamiStoryGetItem_SetValue PocoInterface;
	}
}
