using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FD3 RID: 4051
	[NullableContext(1)]
	[Nullable(0)]
	public class IKillSingleMonster
	{
		// Token: 0x06005A4A RID: 23114 RVA: 0x000DB8B8 File Offset: 0x000D9AB8
		private IKillSingleMonster_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IKillSingleMonster 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IKillSingleMonster_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IKillSingleMonster_SetValue());
			}
			return result;
		}

		// Token: 0x06005A4B RID: 23115 RVA: 0x000DB8F0 File Offset: 0x000D9AF0
		public static IKillSingleMonster Create([Nullable(2)] IKillSingleMonster instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IKillSingleMonster
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005A4C RID: 23116 RVA: 0x000DB903 File Offset: 0x000D9B03
		public static IKillSingleMonster CreateFromSetValue([Nullable(2)] IKillSingleMonster_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IKillSingleMonster
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005A4D RID: 23117 RVA: 0x000DB916 File Offset: 0x000D9B16
		public IKillSingleMonster_SetValue ToSetValue()
		{
			return new IKillSingleMonster_SetValue
			{
				EntityId = this.EntityId,
				AddTime = this.AddTime
			};
		}

		// Token: 0x17001DEA RID: 7658
		// (get) Token: 0x06005A4E RID: 23118 RVA: 0x000DB935 File Offset: 0x000D9B35
		// (set) Token: 0x06005A4F RID: 23119 RVA: 0x000DB960 File Offset: 0x000D9B60
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x17001DEB RID: 7659
		// (get) Token: 0x06005A50 RID: 23120 RVA: 0x000DB96E File Offset: 0x000D9B6E
		// (set) Token: 0x06005A51 RID: 23121 RVA: 0x000DB999 File Offset: 0x000D9B99
		public virtual int AddTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AddTime;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.AddTime;
			}
			set
			{
				this.GetOrCreatePoco().AddTime = value;
			}
		}

		// Token: 0x0400366D RID: 13933
		[Nullable(2)]
		protected IKillSingleMonster FbInstance;

		// Token: 0x0400366E RID: 13934
		[Nullable(2)]
		protected IKillSingleMonster_SetValue PocoInterface;
	}
}
