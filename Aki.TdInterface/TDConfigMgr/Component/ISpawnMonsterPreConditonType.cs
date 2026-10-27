using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006EC RID: 1772
	[NullableContext(1)]
	[Nullable(0)]
	public class ISpawnMonsterPreConditonType
	{
		// Token: 0x06002630 RID: 9776 RVA: 0x00066638 File Offset: 0x00064838
		private ISpawnMonsterPreConditonType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISpawnMonsterPreConditonType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISpawnMonsterPreConditonType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISpawnMonsterPreConditonType_SetValue());
			}
			return result;
		}

		// Token: 0x06002631 RID: 9777 RVA: 0x00066670 File Offset: 0x00064870
		public static ISpawnMonsterPreConditonType Create([Nullable(2)] ISpawnMonsterPreConditonType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISpawnMonsterPreConditonType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002632 RID: 9778 RVA: 0x00066683 File Offset: 0x00064883
		public static ISpawnMonsterPreConditonType CreateFromSetValue([Nullable(2)] ISpawnMonsterPreConditonType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISpawnMonsterPreConditonType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002633 RID: 9779 RVA: 0x00066696 File Offset: 0x00064896
		public ISpawnMonsterPreConditonType_SetValue ToSetValue()
		{
			return new ISpawnMonsterPreConditonType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x06002634 RID: 9780 RVA: 0x000666A9 File Offset: 0x000648A9
		// (set) Token: 0x06002635 RID: 9781 RVA: 0x000666D4 File Offset: 0x000648D4
		public virtual ESpawnMonsterPreCondition Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESpawnMonsterPreCondition.DependOnPreceding;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040019F7 RID: 6647
		[Nullable(2)]
		protected ISpawnMonsterPreConditonType FbInstance;

		// Token: 0x040019F8 RID: 6648
		[Nullable(2)]
		protected ISpawnMonsterPreConditonType_SetValue PocoInterface;
	}
}
