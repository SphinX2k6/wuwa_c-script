using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011E7 RID: 4583
	public class IQuestScheduleType
	{
		// Token: 0x06006697 RID: 26263 RVA: 0x000F6A28 File Offset: 0x000F4C28
		private IQuestScheduleType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IQuestScheduleType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IQuestScheduleType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IQuestScheduleType_SetValue());
			}
			return result;
		}

		// Token: 0x06006698 RID: 26264 RVA: 0x000F6A60 File Offset: 0x000F4C60
		public static IQuestScheduleType Create([Nullable(2)] IQuestScheduleType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestScheduleType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006699 RID: 26265 RVA: 0x000F6A73 File Offset: 0x000F4C73
		public static IQuestScheduleType CreateFromSetValue([Nullable(2)] IQuestScheduleType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IQuestScheduleType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600669A RID: 26266 RVA: 0x000F6A86 File Offset: 0x000F4C86
		public IQuestScheduleType_SetValue ToSetValue()
		{
			return new IQuestScheduleType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700216F RID: 8559
		// (get) Token: 0x0600669B RID: 26267 RVA: 0x000F6A99 File Offset: 0x000F4C99
		// (set) Token: 0x0600669C RID: 26268 RVA: 0x000F6AC4 File Offset: 0x000F4CC4
		public virtual EQuestScheduleType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EQuestScheduleType.None;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003D85 RID: 15749
		[Nullable(2)]
		protected IQuestScheduleType FbInstance;

		// Token: 0x04003D86 RID: 15750
		[Nullable(2)]
		protected IQuestScheduleType_SetValue PocoInterface;
	}
}
