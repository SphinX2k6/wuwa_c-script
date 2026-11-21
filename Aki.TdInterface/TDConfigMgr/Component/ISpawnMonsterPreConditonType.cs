using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200078D RID: 1933
	public class ISpawnMonsterPreConditonType
	{
		// Token: 0x06002950 RID: 10576 RVA: 0x0006D6A8 File Offset: 0x0006B8A8
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

		// Token: 0x06002951 RID: 10577 RVA: 0x0006D6E0 File Offset: 0x0006B8E0
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

		// Token: 0x06002952 RID: 10578 RVA: 0x0006D6F3 File Offset: 0x0006B8F3
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

		// Token: 0x06002953 RID: 10579 RVA: 0x0006D706 File Offset: 0x0006B906
		public ISpawnMonsterPreConditonType_SetValue ToSetValue()
		{
			return new ISpawnMonsterPreConditonType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000AD3 RID: 2771
		// (get) Token: 0x06002954 RID: 10580 RVA: 0x0006D719 File Offset: 0x0006B919
		// (set) Token: 0x06002955 RID: 10581 RVA: 0x0006D744 File Offset: 0x0006B944
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

		// Token: 0x04001BF6 RID: 7158
		[Nullable(2)]
		protected ISpawnMonsterPreConditonType FbInstance;

		// Token: 0x04001BF7 RID: 7159
		[Nullable(2)]
		protected ISpawnMonsterPreConditonType_SetValue PocoInterface;
	}
}
