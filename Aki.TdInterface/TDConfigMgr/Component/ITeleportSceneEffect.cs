using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000758 RID: 1880
	[NullableContext(2)]
	[Nullable(0)]
	public class ITeleportSceneEffect
	{
		// Token: 0x06002891 RID: 10385 RVA: 0x0006B564 File Offset: 0x00069764
		[NullableContext(1)]
		private ITeleportSceneEffect_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITeleportSceneEffect 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITeleportSceneEffect_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITeleportSceneEffect_SetValue());
			}
			return result;
		}

		// Token: 0x06002892 RID: 10386 RVA: 0x0006B59C File Offset: 0x0006979C
		[NullableContext(1)]
		public static ITeleportSceneEffect Create([Nullable(2)] ITeleportSceneEffect instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleportSceneEffect
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002893 RID: 10387 RVA: 0x0006B5AF File Offset: 0x000697AF
		[NullableContext(1)]
		public static ITeleportSceneEffect CreateFromSetValue([Nullable(2)] ITeleportSceneEffect_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITeleportSceneEffect
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002894 RID: 10388 RVA: 0x0006B5C2 File Offset: 0x000697C2
		[NullableContext(1)]
		public ITeleportSceneEffect_SetValue ToSetValue()
		{
			return new ITeleportSceneEffect_SetValue
			{
				WorldEffectPath = this.WorldEffectPath,
				ScreenEffectPath = this.ScreenEffectPath
			};
		}

		// Token: 0x17000AA5 RID: 2725
		// (get) Token: 0x06002895 RID: 10389 RVA: 0x0006B5E1 File Offset: 0x000697E1
		// (set) Token: 0x06002896 RID: 10390 RVA: 0x0006B608 File Offset: 0x00069808
		public virtual string WorldEffectPath
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.WorldEffectPath;
				}
				ITeleportSceneEffect_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.WorldEffectPath;
			}
			set
			{
				this.GetOrCreatePoco().WorldEffectPath = value;
			}
		}

		// Token: 0x17000AA6 RID: 2726
		// (get) Token: 0x06002897 RID: 10391 RVA: 0x0006B616 File Offset: 0x00069816
		// (set) Token: 0x06002898 RID: 10392 RVA: 0x0006B63D File Offset: 0x0006983D
		public virtual string ScreenEffectPath
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ScreenEffectPath;
				}
				ITeleportSceneEffect_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ScreenEffectPath;
			}
			set
			{
				this.GetOrCreatePoco().ScreenEffectPath = value;
			}
		}

		// Token: 0x04001B42 RID: 6978
		protected ITeleportSceneEffect FbInstance;

		// Token: 0x04001B43 RID: 6979
		protected ITeleportSceneEffect_SetValue PocoInterface;
	}
}
