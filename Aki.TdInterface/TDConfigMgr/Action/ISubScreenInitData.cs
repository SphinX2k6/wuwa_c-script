using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002110 RID: 8464
	public class ISubScreenInitData
	{
		// Token: 0x0600B3C2 RID: 46018 RVA: 0x00193324 File Offset: 0x00191524
		private ISubScreenInitData_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISubScreenInitData 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISubScreenInitData_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISubScreenInitData_SetValue());
			}
			return result;
		}

		// Token: 0x0600B3C3 RID: 46019 RVA: 0x0019335C File Offset: 0x0019155C
		public static ISubScreenInitData Create([Nullable(2)] ISubScreenInitData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISubScreenInitData
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B3C4 RID: 46020 RVA: 0x0019336F File Offset: 0x0019156F
		public static ISubScreenInitData CreateFromSetValue([Nullable(2)] ISubScreenInitData_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISubScreenInitData
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B3C5 RID: 46021 RVA: 0x00193382 File Offset: 0x00191582
		public ISubScreenInitData_SetValue ToSetValue()
		{
			return new ISubScreenInitData_SetValue
			{
				Type = this.Type,
				SubScreenKey = this.SubScreenKey
			};
		}

		// Token: 0x17003658 RID: 13912
		// (get) Token: 0x0600B3C6 RID: 46022 RVA: 0x001933A1 File Offset: 0x001915A1
		// (set) Token: 0x0600B3C7 RID: 46023 RVA: 0x001933CC File Offset: 0x001915CC
		public virtual ESubScreenInitDataType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESubScreenInitDataType.Preset;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003659 RID: 13913
		// (get) Token: 0x0600B3C8 RID: 46024 RVA: 0x001933DA File Offset: 0x001915DA
		// (set) Token: 0x0600B3C9 RID: 46025 RVA: 0x00193405 File Offset: 0x00191605
		public virtual string SubScreenKey
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SubScreenKey;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.SubScreenKey;
			}
			set
			{
				this.GetOrCreatePoco().SubScreenKey = value;
			}
		}

		// Token: 0x04006A85 RID: 27269
		[Nullable(2)]
		protected ISubScreenInitData FbInstance;

		// Token: 0x04006A86 RID: 27270
		[Nullable(2)]
		protected ISubScreenInitData_SetValue PocoInterface;
	}
}
