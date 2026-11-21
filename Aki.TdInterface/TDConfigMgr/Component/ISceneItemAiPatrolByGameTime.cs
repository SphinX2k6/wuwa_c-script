using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200073D RID: 1853
	public class ISceneItemAiPatrolByGameTime : ISceneItemAiPatrolType
	{
		// Token: 0x06002760 RID: 10080 RVA: 0x00069630 File Offset: 0x00067830
		private ISceneItemAiPatrolByGameTime_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISceneItemAiPatrolByGameTime 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISceneItemAiPatrolByGameTime_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISceneItemAiPatrolByGameTime_SetValue());
			}
			return result;
		}

		// Token: 0x06002761 RID: 10081 RVA: 0x00069668 File Offset: 0x00067868
		public static ISceneItemAiPatrolByGameTime Create([Nullable(2)] ISceneItemAiPatrolByGameTime instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneItemAiPatrolByGameTime
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002762 RID: 10082 RVA: 0x0006967B File Offset: 0x0006787B
		public static ISceneItemAiPatrolByGameTime CreateFromSetValue([Nullable(2)] ISceneItemAiPatrolByGameTime_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISceneItemAiPatrolByGameTime
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002763 RID: 10083 RVA: 0x0006968E File Offset: 0x0006788E
		public new ISceneItemAiPatrolByGameTime_SetValue ToSetValue()
		{
			return new ISceneItemAiPatrolByGameTime_SetValue
			{
				Type = this.Type,
				Spline = this.Spline
			};
		}

		// Token: 0x17000A53 RID: 2643
		// (get) Token: 0x06002764 RID: 10084 RVA: 0x000696AD File Offset: 0x000678AD
		// (set) Token: 0x06002765 RID: 10085 RVA: 0x000696D8 File Offset: 0x000678D8
		public override ESceneItemAiPatrolType Type
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

		// Token: 0x17000A54 RID: 2644
		// (get) Token: 0x06002766 RID: 10086 RVA: 0x000696E6 File Offset: 0x000678E6
		// (set) Token: 0x06002767 RID: 10087 RVA: 0x00069711 File Offset: 0x00067911
		public virtual int Spline
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Spline;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Spline;
			}
			set
			{
				this.GetOrCreatePoco().Spline = value;
			}
		}

		// Token: 0x04001AE8 RID: 6888
		[Nullable(2)]
		protected new ISceneItemAiPatrolByGameTime FbInstance;

		// Token: 0x04001AE9 RID: 6889
		[Nullable(2)]
		protected new ISceneItemAiPatrolByGameTime_SetValue PocoInterface;
	}
}
