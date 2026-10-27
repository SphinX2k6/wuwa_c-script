using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010E6 RID: 4326
	[NullableContext(1)]
	[Nullable(0)]
	public class IRecallEntityList
	{
		// Token: 0x060061D6 RID: 25046 RVA: 0x000EC050 File Offset: 0x000EA250
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

		// Token: 0x060061D7 RID: 25047 RVA: 0x000EC088 File Offset: 0x000EA288
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

		// Token: 0x060061D8 RID: 25048 RVA: 0x000EC09B File Offset: 0x000EA29B
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

		// Token: 0x060061D9 RID: 25049 RVA: 0x000EC0AE File Offset: 0x000EA2AE
		public IRecallEntityList_SetValue ToSetValue()
		{
			return new IRecallEntityList_SetValue
			{
				LevelId = this.LevelId,
				EntityList = this.EntityList
			};
		}

		// Token: 0x17002016 RID: 8214
		// (get) Token: 0x060061DA RID: 25050 RVA: 0x000EC0CD File Offset: 0x000EA2CD
		// (set) Token: 0x060061DB RID: 25051 RVA: 0x000EC0F8 File Offset: 0x000EA2F8
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

		// Token: 0x17002017 RID: 8215
		// (get) Token: 0x060061DC RID: 25052 RVA: 0x000EC106 File Offset: 0x000EA306
		// (set) Token: 0x060061DD RID: 25053 RVA: 0x000EC12D File Offset: 0x000EA32D
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

		// Token: 0x04003AD7 RID: 15063
		[Nullable(2)]
		protected IRecallEntityList FbInstance;

		// Token: 0x04003AD8 RID: 15064
		[Nullable(2)]
		protected IRecallEntityList_SetValue PocoInterface;
	}
}
