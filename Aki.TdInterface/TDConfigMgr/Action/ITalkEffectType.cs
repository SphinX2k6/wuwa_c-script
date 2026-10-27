using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F2A RID: 7978
	[NullableContext(1)]
	[Nullable(0)]
	public class ITalkEffectType
	{
		// Token: 0x0600AA9A RID: 43674 RVA: 0x0018014C File Offset: 0x0017E34C
		private ITalkEffectType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkEffectType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkEffectType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkEffectType_SetValue());
			}
			return result;
		}

		// Token: 0x0600AA9B RID: 43675 RVA: 0x00180184 File Offset: 0x0017E384
		public static ITalkEffectType Create([Nullable(2)] ITalkEffectType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkEffectType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AA9C RID: 43676 RVA: 0x00180197 File Offset: 0x0017E397
		public static ITalkEffectType CreateFromSetValue([Nullable(2)] ITalkEffectType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkEffectType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AA9D RID: 43677 RVA: 0x001801AA File Offset: 0x0017E3AA
		public ITalkEffectType_SetValue ToSetValue()
		{
			return new ITalkEffectType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170033E6 RID: 13286
		// (get) Token: 0x0600AA9E RID: 43678 RVA: 0x001801BD File Offset: 0x0017E3BD
		// (set) Token: 0x0600AA9F RID: 43679 RVA: 0x001801E8 File Offset: 0x0017E3E8
		public virtual ETalkEffectType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETalkEffectType.Effect;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006550 RID: 25936
		[Nullable(2)]
		protected ITalkEffectType FbInstance;

		// Token: 0x04006551 RID: 25937
		[Nullable(2)]
		protected ITalkEffectType_SetValue PocoInterface;
	}
}
