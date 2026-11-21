using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200126E RID: 4718
	[NullableContext(2)]
	[Nullable(0)]
	public class IShowUiSynthetic : IShowUiCrafting
	{
		// Token: 0x06006A41 RID: 27201 RVA: 0x000FE464 File Offset: 0x000FC664
		[NullableContext(0)]
		private IShowUiSynthetic_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IShowUiSynthetic 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IShowUiSynthetic_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IShowUiSynthetic_SetValue());
			}
			return result;
		}

		// Token: 0x06006A42 RID: 27202 RVA: 0x000FE49C File Offset: 0x000FC69C
		[NullableContext(0)]
		public static IShowUiSynthetic Create([Nullable(2)] IShowUiSynthetic instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IShowUiSynthetic
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006A43 RID: 27203 RVA: 0x000FE4AF File Offset: 0x000FC6AF
		[NullableContext(0)]
		public static IShowUiSynthetic CreateFromSetValue([Nullable(2)] IShowUiSynthetic_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IShowUiSynthetic
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006A44 RID: 27204 RVA: 0x000FE4C2 File Offset: 0x000FC6C2
		[NullableContext(0)]
		public new IShowUiSynthetic_SetValue ToSetValue()
		{
			return new IShowUiSynthetic_SetValue
			{
				Type = this.Type,
				EntityIds = this.EntityIds,
				ProductIds = this.ProductIds
			};
		}

		// Token: 0x1700227B RID: 8827
		// (get) Token: 0x06006A45 RID: 27205 RVA: 0x000FE4ED File Offset: 0x000FC6ED
		// (set) Token: 0x06006A46 RID: 27206 RVA: 0x000FE518 File Offset: 0x000FC718
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

		// Token: 0x1700227C RID: 8828
		// (get) Token: 0x06006A47 RID: 27207 RVA: 0x000FE526 File Offset: 0x000FC726
		// (set) Token: 0x06006A48 RID: 27208 RVA: 0x000FE54D File Offset: 0x000FC74D
		public override List<int> EntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityIds;
				}
				IShowUiSynthetic_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700227D RID: 8829
		// (get) Token: 0x06006A49 RID: 27209 RVA: 0x000FE55B File Offset: 0x000FC75B
		// (set) Token: 0x06006A4A RID: 27210 RVA: 0x000FE582 File Offset: 0x000FC782
		public override List<int> ProductIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ProductIds;
				}
				IShowUiSynthetic_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04003F93 RID: 16275
		protected new IShowUiSynthetic FbInstance;

		// Token: 0x04003F94 RID: 16276
		protected new IShowUiSynthetic_SetValue PocoInterface;
	}
}
