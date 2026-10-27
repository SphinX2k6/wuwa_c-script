using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001940 RID: 6464
	[NullableContext(1)]
	[Nullable(0)]
	public class ICreatePrefabConfig
	{
		// Token: 0x06008A8F RID: 35471 RVA: 0x00146514 File Offset: 0x00144714
		private ICreatePrefabConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICreatePrefabConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICreatePrefabConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICreatePrefabConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06008A90 RID: 35472 RVA: 0x0014654C File Offset: 0x0014474C
		public static ICreatePrefabConfig Create([Nullable(2)] ICreatePrefabConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICreatePrefabConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008A91 RID: 35473 RVA: 0x0014655F File Offset: 0x0014475F
		public static ICreatePrefabConfig CreateFromSetValue([Nullable(2)] ICreatePrefabConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICreatePrefabConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008A92 RID: 35474 RVA: 0x00146572 File Offset: 0x00144772
		public ICreatePrefabConfig_SetValue ToSetValue()
		{
			return new ICreatePrefabConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002CBC RID: 11452
		// (get) Token: 0x06008A93 RID: 35475 RVA: 0x00146585 File Offset: 0x00144785
		// (set) Token: 0x06008A94 RID: 35476 RVA: 0x001465B0 File Offset: 0x001447B0
		public virtual ECreatePrefabType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECreatePrefabType.PrefabId;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005697 RID: 22167
		[Nullable(2)]
		protected ICreatePrefabConfig FbInstance;

		// Token: 0x04005698 RID: 22168
		[Nullable(2)]
		protected ICreatePrefabConfig_SetValue PocoInterface;
	}
}
