using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010E4 RID: 4324
	[NullableContext(1)]
	[Nullable(0)]
	public class IRecallEntityGroup
	{
		// Token: 0x060061C8 RID: 25032 RVA: 0x000EBEC8 File Offset: 0x000EA0C8
		private IRecallEntityGroup_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRecallEntityGroup 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRecallEntityGroup_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRecallEntityGroup_SetValue());
			}
			return result;
		}

		// Token: 0x060061C9 RID: 25033 RVA: 0x000EBF00 File Offset: 0x000EA100
		public static IRecallEntityGroup Create([Nullable(2)] IRecallEntityGroup instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRecallEntityGroup
			{
				FbInstance = instance
			};
		}

		// Token: 0x060061CA RID: 25034 RVA: 0x000EBF13 File Offset: 0x000EA113
		public static IRecallEntityGroup CreateFromSetValue([Nullable(2)] IRecallEntityGroup_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRecallEntityGroup
			{
				PocoInterface = value
			};
		}

		// Token: 0x060061CB RID: 25035 RVA: 0x000EBF26 File Offset: 0x000EA126
		public IRecallEntityGroup_SetValue ToSetValue()
		{
			return new IRecallEntityGroup_SetValue
			{
				Index = this.Index,
				Source = this.Source,
				LevelId = this.LevelId,
				Entities = this.Entities
			};
		}

		// Token: 0x17002012 RID: 8210
		// (get) Token: 0x060061CC RID: 25036 RVA: 0x000EBF5D File Offset: 0x000EA15D
		// (set) Token: 0x060061CD RID: 25037 RVA: 0x000EBF88 File Offset: 0x000EA188
		public virtual int Index
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Index;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Index;
			}
			set
			{
				this.GetOrCreatePoco().Index = value;
			}
		}

		// Token: 0x17002013 RID: 8211
		// (get) Token: 0x060061CE RID: 25038 RVA: 0x000EBF96 File Offset: 0x000EA196
		// (set) Token: 0x060061CF RID: 25039 RVA: 0x000EBFC1 File Offset: 0x000EA1C1
		public virtual string Source
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Source;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Source;
			}
			set
			{
				this.GetOrCreatePoco().Source = value;
			}
		}

		// Token: 0x17002014 RID: 8212
		// (get) Token: 0x060061D0 RID: 25040 RVA: 0x000EBFCF File Offset: 0x000EA1CF
		// (set) Token: 0x060061D1 RID: 25041 RVA: 0x000EBFFA File Offset: 0x000EA1FA
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

		// Token: 0x17002015 RID: 8213
		// (get) Token: 0x060061D2 RID: 25042 RVA: 0x000EC008 File Offset: 0x000EA208
		// (set) Token: 0x060061D3 RID: 25043 RVA: 0x000EC02F File Offset: 0x000EA22F
		public virtual List<int> Entities
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Entities;
				}
				IRecallEntityGroup_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Entities;
			}
			set
			{
				this.GetOrCreatePoco().Entities = value;
			}
		}

		// Token: 0x04003AD1 RID: 15057
		[Nullable(2)]
		protected IRecallEntityGroup FbInstance;

		// Token: 0x04003AD2 RID: 15058
		[Nullable(2)]
		protected IRecallEntityGroup_SetValue PocoInterface;
	}
}
