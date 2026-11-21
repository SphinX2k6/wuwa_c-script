using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001268 RID: 4712
	[NullableContext(2)]
	[Nullable(0)]
	public class IShowUiCook : IShowUiCrafting
	{
		// Token: 0x06006A1D RID: 27165 RVA: 0x000FE0B0 File Offset: 0x000FC2B0
		[NullableContext(0)]
		private IShowUiCook_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IShowUiCook 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IShowUiCook_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IShowUiCook_SetValue());
			}
			return result;
		}

		// Token: 0x06006A1E RID: 27166 RVA: 0x000FE0E8 File Offset: 0x000FC2E8
		[NullableContext(0)]
		public static IShowUiCook Create([Nullable(2)] IShowUiCook instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IShowUiCook
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006A1F RID: 27167 RVA: 0x000FE0FB File Offset: 0x000FC2FB
		[NullableContext(0)]
		public static IShowUiCook CreateFromSetValue([Nullable(2)] IShowUiCook_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IShowUiCook
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006A20 RID: 27168 RVA: 0x000FE10E File Offset: 0x000FC30E
		[NullableContext(0)]
		public new IShowUiCook_SetValue ToSetValue()
		{
			return new IShowUiCook_SetValue
			{
				Type = this.Type,
				EntityIds = this.EntityIds,
				ProductIds = this.ProductIds
			};
		}

		// Token: 0x17002272 RID: 8818
		// (get) Token: 0x06006A21 RID: 27169 RVA: 0x000FE139 File Offset: 0x000FC339
		// (set) Token: 0x06006A22 RID: 27170 RVA: 0x000FE164 File Offset: 0x000FC364
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

		// Token: 0x17002273 RID: 8819
		// (get) Token: 0x06006A23 RID: 27171 RVA: 0x000FE172 File Offset: 0x000FC372
		// (set) Token: 0x06006A24 RID: 27172 RVA: 0x000FE199 File Offset: 0x000FC399
		public override List<int> EntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityIds;
				}
				IShowUiCook_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17002274 RID: 8820
		// (get) Token: 0x06006A25 RID: 27173 RVA: 0x000FE1A7 File Offset: 0x000FC3A7
		// (set) Token: 0x06006A26 RID: 27174 RVA: 0x000FE1CE File Offset: 0x000FC3CE
		public override List<int> ProductIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ProductIds;
				}
				IShowUiCook_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04003F84 RID: 16260
		protected new IShowUiCook FbInstance;

		// Token: 0x04003F85 RID: 16261
		protected new IShowUiCook_SetValue PocoInterface;
	}
}
