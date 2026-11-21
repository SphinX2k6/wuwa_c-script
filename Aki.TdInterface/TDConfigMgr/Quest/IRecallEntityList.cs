using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001214 RID: 4628
	public class IRecallEntityList
	{
		// Token: 0x060067CF RID: 26575 RVA: 0x000F9170 File Offset: 0x000F7370
		private IRecallEntityList_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRecallEntityList 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRecallEntityList_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRecallEntityList_SetValue());
			}
			return result;
		}

		// Token: 0x060067D0 RID: 26576 RVA: 0x000F91A8 File Offset: 0x000F73A8
		public static IRecallEntityList Create([Nullable(2)] IRecallEntityList instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRecallEntityList
			{
				FbInstance = instance
			};
		}

		// Token: 0x060067D1 RID: 26577 RVA: 0x000F91BB File Offset: 0x000F73BB
		public static IRecallEntityList CreateFromSetValue([Nullable(2)] IRecallEntityList_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRecallEntityList
			{
				PocoInterface = value
			};
		}

		// Token: 0x060067D2 RID: 26578 RVA: 0x000F91CE File Offset: 0x000F73CE
		public IRecallEntityList_SetValue ToSetValue()
		{
			return new IRecallEntityList_SetValue
			{
				LevelId = this.LevelId,
				EntityList = this.EntityList
			};
		}

		// Token: 0x170021C8 RID: 8648
		// (get) Token: 0x060067D3 RID: 26579 RVA: 0x000F91ED File Offset: 0x000F73ED
		// (set) Token: 0x060067D4 RID: 26580 RVA: 0x000F9218 File Offset: 0x000F7418
		public virtual int LevelId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LevelId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.LevelId;
			}
			set
			{
				this.GetOrCreatePoco().LevelId = value;
			}
		}

		// Token: 0x170021C9 RID: 8649
		// (get) Token: 0x060067D5 RID: 26581 RVA: 0x000F9226 File Offset: 0x000F7426
		// (set) Token: 0x060067D6 RID: 26582 RVA: 0x000F924D File Offset: 0x000F744D
		public virtual List<int> EntityList
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityList;
				}
				IRecallEntityList_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EntityList;
			}
			set
			{
				this.GetOrCreatePoco().EntityList = value;
			}
		}

		// Token: 0x04003E24 RID: 15908
		[Nullable(2)]
		protected IRecallEntityList FbInstance;

		// Token: 0x04003E25 RID: 15909
		[Nullable(2)]
		protected IRecallEntityList_SetValue PocoInterface;
	}
}
