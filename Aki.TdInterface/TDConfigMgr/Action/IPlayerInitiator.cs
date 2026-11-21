using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F15 RID: 7957
	public class IPlayerInitiator : INpcGroupPerformInitiatorType
	{
		// Token: 0x0600A959 RID: 43353 RVA: 0x00180738 File Offset: 0x0017E938
		private IPlayerInitiator_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPlayerInitiator 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPlayerInitiator_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPlayerInitiator_SetValue());
			}
			return result;
		}

		// Token: 0x0600A95A RID: 43354 RVA: 0x00180770 File Offset: 0x0017E970
		public static IPlayerInitiator Create([Nullable(2)] IPlayerInitiator instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayerInitiator
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A95B RID: 43355 RVA: 0x00180783 File Offset: 0x0017E983
		public static IPlayerInitiator CreateFromSetValue([Nullable(2)] IPlayerInitiator_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPlayerInitiator
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A95C RID: 43356 RVA: 0x00180796 File Offset: 0x0017E996
		public new IPlayerInitiator_SetValue ToSetValue()
		{
			return new IPlayerInitiator_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700341B RID: 13339
		// (get) Token: 0x0600A95D RID: 43357 RVA: 0x001807A9 File Offset: 0x0017E9A9
		// (set) Token: 0x0600A95E RID: 43358 RVA: 0x001807D4 File Offset: 0x0017E9D4
		public override ENpcGroupPerformInitiatorType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ENpcGroupPerformInitiatorType.Player;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040065B4 RID: 26036
		[Nullable(2)]
		protected new IPlayerInitiator FbInstance;

		// Token: 0x040065B5 RID: 26037
		[Nullable(2)]
		protected new IPlayerInitiator_SetValue PocoInterface;
	}
}
