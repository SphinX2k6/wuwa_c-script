using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CBE RID: 7358
	[NullableContext(1)]
	[Nullable(0)]
	public class IPainCoveringHead : ILeisureInteractType
	{
		// Token: 0x06009DF9 RID: 40441 RVA: 0x00169884 File Offset: 0x00167A84
		private IPainCoveringHead_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPainCoveringHead 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPainCoveringHead_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPainCoveringHead_SetValue());
			}
			return result;
		}

		// Token: 0x06009DFA RID: 40442 RVA: 0x001698BC File Offset: 0x00167ABC
		public static IPainCoveringHead Create([Nullable(2)] IPainCoveringHead instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPainCoveringHead
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009DFB RID: 40443 RVA: 0x001698CF File Offset: 0x00167ACF
		public static IPainCoveringHead CreateFromSetValue([Nullable(2)] IPainCoveringHead_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPainCoveringHead
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009DFC RID: 40444 RVA: 0x001698E2 File Offset: 0x00167AE2
		public new IPainCoveringHead_SetValue ToSetValue()
		{
			return new IPainCoveringHead_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003136 RID: 12598
		// (get) Token: 0x06009DFD RID: 40445 RVA: 0x001698F5 File Offset: 0x00167AF5
		// (set) Token: 0x06009DFE RID: 40446 RVA: 0x00169920 File Offset: 0x00167B20
		public override ELeisureInteract Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELeisureInteract.CustomSkill;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005F8D RID: 24461
		[Nullable(2)]
		protected new IPainCoveringHead FbInstance;

		// Token: 0x04005F8E RID: 24462
		[Nullable(2)]
		protected new IPainCoveringHead_SetValue PocoInterface;
	}
}
