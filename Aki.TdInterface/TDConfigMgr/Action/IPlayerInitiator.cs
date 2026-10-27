using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D04 RID: 7428
	[NullableContext(1)]
	[Nullable(0)]
	public class IPlayerInitiator : INpcGroupPerformInitiatorType
	{
		// Token: 0x06009F6F RID: 40815 RVA: 0x0016C398 File Offset: 0x0016A598
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

		// Token: 0x06009F70 RID: 40816 RVA: 0x0016C3D0 File Offset: 0x0016A5D0
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

		// Token: 0x06009F71 RID: 40817 RVA: 0x0016C3E3 File Offset: 0x0016A5E3
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

		// Token: 0x06009F72 RID: 40818 RVA: 0x0016C3F6 File Offset: 0x0016A5F6
		public new IPlayerInitiator_SetValue ToSetValue()
		{
			return new IPlayerInitiator_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003188 RID: 12680
		// (get) Token: 0x06009F73 RID: 40819 RVA: 0x0016C409 File Offset: 0x0016A609
		// (set) Token: 0x06009F74 RID: 40820 RVA: 0x0016C434 File Offset: 0x0016A634
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

		// Token: 0x0400603B RID: 24635
		[Nullable(2)]
		protected new IPlayerInitiator FbInstance;

		// Token: 0x0400603C RID: 24636
		[Nullable(2)]
		protected new IPlayerInitiator_SetValue PocoInterface;
	}
}
