using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001852 RID: 6226
	[NullableContext(1)]
	[Nullable(0)]
	public class ICameraShakeConfig
	{
		// Token: 0x060085C7 RID: 34247 RVA: 0x0013E1F0 File Offset: 0x0013C3F0
		private ICameraShakeConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICameraShakeConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICameraShakeConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICameraShakeConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060085C8 RID: 34248 RVA: 0x0013E228 File Offset: 0x0013C428
		public static ICameraShakeConfig Create([Nullable(2)] ICameraShakeConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICameraShakeConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060085C9 RID: 34249 RVA: 0x0013E23B File Offset: 0x0013C43B
		public static ICameraShakeConfig CreateFromSetValue([Nullable(2)] ICameraShakeConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICameraShakeConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060085CA RID: 34250 RVA: 0x0013E24E File Offset: 0x0013C44E
		public ICameraShakeConfig_SetValue ToSetValue()
		{
			return new ICameraShakeConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002BBD RID: 11197
		// (get) Token: 0x060085CB RID: 34251 RVA: 0x0013E261 File Offset: 0x0013C461
		// (set) Token: 0x060085CC RID: 34252 RVA: 0x0013E28C File Offset: 0x0013C48C
		public virtual ECameraShakeType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECameraShakeType.Constant;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400547A RID: 21626
		[Nullable(2)]
		protected ICameraShakeConfig FbInstance;

		// Token: 0x0400547B RID: 21627
		[Nullable(2)]
		protected ICameraShakeConfig_SetValue PocoInterface;
	}
}
