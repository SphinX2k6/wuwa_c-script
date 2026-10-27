using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200069C RID: 1692
	[NullableContext(1)]
	[Nullable(0)]
	public class ISceneItemAiPatrolByGameTime : ISceneItemAiPatrolType
	{
		// Token: 0x06002444 RID: 9284 RVA: 0x00062668 File Offset: 0x00060868
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

		// Token: 0x06002445 RID: 9285 RVA: 0x000626A0 File Offset: 0x000608A0
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

		// Token: 0x06002446 RID: 9286 RVA: 0x000626B3 File Offset: 0x000608B3
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

		// Token: 0x06002447 RID: 9287 RVA: 0x000626C6 File Offset: 0x000608C6
		public new ISceneItemAiPatrolByGameTime_SetValue ToSetValue()
		{
			return new ISceneItemAiPatrolByGameTime_SetValue
			{
				Type = this.Type,
				Spline = this.Spline
			};
		}

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x06002448 RID: 9288 RVA: 0x000626E5 File Offset: 0x000608E5
		// (set) Token: 0x06002449 RID: 9289 RVA: 0x00062710 File Offset: 0x00060910
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

		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x0600244A RID: 9290 RVA: 0x0006271E File Offset: 0x0006091E
		// (set) Token: 0x0600244B RID: 9291 RVA: 0x00062749 File Offset: 0x00060949
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

		// Token: 0x040018EB RID: 6379
		[Nullable(2)]
		protected new ISceneItemAiPatrolByGameTime FbInstance;

		// Token: 0x040018EC RID: 6380
		[Nullable(2)]
		protected new ISceneItemAiPatrolByGameTime_SetValue PocoInterface;
	}
}
