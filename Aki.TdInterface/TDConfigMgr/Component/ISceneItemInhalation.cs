using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006A4 RID: 1700
	[NullableContext(1)]
	[Nullable(0)]
	public class ISceneItemInhalation : IInhalationPerformanceType
	{
		// Token: 0x0600246E RID: 9326 RVA: 0x00062B9C File Offset: 0x00060D9C
		private ISceneItemInhalation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISceneItemInhalation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISceneItemInhalation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISceneItemInhalation_SetValue());
			}
			return result;
		}

		// Token: 0x0600246F RID: 9327 RVA: 0x00062BD4 File Offset: 0x00060DD4
		public static ISceneItemInhalation Create([Nullable(2)] ISceneItemInhalation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneItemInhalation
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002470 RID: 9328 RVA: 0x00062BE7 File Offset: 0x00060DE7
		public static ISceneItemInhalation CreateFromSetValue([Nullable(2)] ISceneItemInhalation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISceneItemInhalation
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002471 RID: 9329 RVA: 0x00062BFA File Offset: 0x00060DFA
		public new ISceneItemInhalation_SetValue ToSetValue()
		{
			return new ISceneItemInhalation_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x06002472 RID: 9330 RVA: 0x00062C0D File Offset: 0x00060E0D
		// (set) Token: 0x06002473 RID: 9331 RVA: 0x00062C38 File Offset: 0x00060E38
		public override EInhalationPerformanceType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInhalationPerformanceType.Role;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001902 RID: 6402
		[Nullable(2)]
		protected new ISceneItemInhalation FbInstance;

		// Token: 0x04001903 RID: 6403
		[Nullable(2)]
		protected new ISceneItemInhalation_SetValue PocoInterface;
	}
}
