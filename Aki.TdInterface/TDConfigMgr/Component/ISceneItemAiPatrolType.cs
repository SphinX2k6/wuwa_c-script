using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200073F RID: 1855
	public class ISceneItemAiPatrolType
	{
		// Token: 0x0600276A RID: 10090 RVA: 0x00069730 File Offset: 0x00067930
		private ISceneItemAiPatrolType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISceneItemAiPatrolType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISceneItemAiPatrolType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISceneItemAiPatrolType_SetValue());
			}
			return result;
		}

		// Token: 0x0600276B RID: 10091 RVA: 0x00069768 File Offset: 0x00067968
		public static ISceneItemAiPatrolType Create([Nullable(2)] ISceneItemAiPatrolType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneItemAiPatrolType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600276C RID: 10092 RVA: 0x0006977B File Offset: 0x0006797B
		public static ISceneItemAiPatrolType CreateFromSetValue([Nullable(2)] ISceneItemAiPatrolType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISceneItemAiPatrolType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600276D RID: 10093 RVA: 0x0006978E File Offset: 0x0006798E
		public ISceneItemAiPatrolType_SetValue ToSetValue()
		{
			return new ISceneItemAiPatrolType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000A55 RID: 2645
		// (get) Token: 0x0600276E RID: 10094 RVA: 0x000697A1 File Offset: 0x000679A1
		// (set) Token: 0x0600276F RID: 10095 RVA: 0x000697CC File Offset: 0x000679CC
		public virtual ESceneItemAiPatrolType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESceneItemAiPatrolType.ByGameTime;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001AEC RID: 6892
		[Nullable(2)]
		protected ISceneItemAiPatrolType FbInstance;

		// Token: 0x04001AED RID: 6893
		[Nullable(2)]
		protected ISceneItemAiPatrolType_SetValue PocoInterface;
	}
}
