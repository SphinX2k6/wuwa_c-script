using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200126C RID: 4716
	[NullableContext(2)]
	[Nullable(0)]
	public class IShowUiForging : IShowUiCrafting
	{
		// Token: 0x06006A35 RID: 27189 RVA: 0x000FE328 File Offset: 0x000FC528
		[NullableContext(0)]
		private IShowUiForging_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IShowUiForging 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IShowUiForging_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IShowUiForging_SetValue());
			}
			return result;
		}

		// Token: 0x06006A36 RID: 27190 RVA: 0x000FE360 File Offset: 0x000FC560
		[NullableContext(0)]
		public static IShowUiForging Create([Nullable(2)] IShowUiForging instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IShowUiForging
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006A37 RID: 27191 RVA: 0x000FE373 File Offset: 0x000FC573
		[NullableContext(0)]
		public static IShowUiForging CreateFromSetValue([Nullable(2)] IShowUiForging_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IShowUiForging
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006A38 RID: 27192 RVA: 0x000FE386 File Offset: 0x000FC586
		[NullableContext(0)]
		public new IShowUiForging_SetValue ToSetValue()
		{
			return new IShowUiForging_SetValue
			{
				Type = this.Type,
				EntityIds = this.EntityIds,
				ProductIds = this.ProductIds
			};
		}

		// Token: 0x17002278 RID: 8824
		// (get) Token: 0x06006A39 RID: 27193 RVA: 0x000FE3B1 File Offset: 0x000FC5B1
		// (set) Token: 0x06006A3A RID: 27194 RVA: 0x000FE3DC File Offset: 0x000FC5DC
		public override EShowUiType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EShowUiType.All;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002279 RID: 8825
		// (get) Token: 0x06006A3B RID: 27195 RVA: 0x000FE3EA File Offset: 0x000FC5EA
		// (set) Token: 0x06006A3C RID: 27196 RVA: 0x000FE411 File Offset: 0x000FC611
		public override List<int> EntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityIds;
				}
				IShowUiForging_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EntityIds;
			}
			set
			{
				this.GetOrCreatePoco().EntityIds = value;
			}
		}

		// Token: 0x1700227A RID: 8826
		// (get) Token: 0x06006A3D RID: 27197 RVA: 0x000FE41F File Offset: 0x000FC61F
		// (set) Token: 0x06006A3E RID: 27198 RVA: 0x000FE446 File Offset: 0x000FC646
		public override List<int> ProductIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ProductIds;
				}
				IShowUiForging_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ProductIds;
			}
			set
			{
				this.GetOrCreatePoco().ProductIds = value;
			}
		}

		// Token: 0x04003F8E RID: 16270
		protected new IShowUiForging FbInstance;

		// Token: 0x04003F8F RID: 16271
		protected new IShowUiForging_SetValue PocoInterface;
	}
}
