using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C96 RID: 7318
	public class IHandInHandInitiatorType
	{
		// Token: 0x06009B76 RID: 39798 RVA: 0x001671B0 File Offset: 0x001653B0
		private IHandInHandInitiatorType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHandInHandInitiatorType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHandInHandInitiatorType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHandInHandInitiatorType_SetValue());
			}
			return result;
		}

		// Token: 0x06009B77 RID: 39799 RVA: 0x001671E8 File Offset: 0x001653E8
		public static IHandInHandInitiatorType Create([Nullable(2)] IHandInHandInitiatorType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHandInHandInitiatorType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009B78 RID: 39800 RVA: 0x001671FB File Offset: 0x001653FB
		public static IHandInHandInitiatorType CreateFromSetValue([Nullable(2)] IHandInHandInitiatorType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHandInHandInitiatorType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009B79 RID: 39801 RVA: 0x0016720E File Offset: 0x0016540E
		public IHandInHandInitiatorType_SetValue ToSetValue()
		{
			return new IHandInHandInitiatorType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170030E7 RID: 12519
		// (get) Token: 0x06009B7A RID: 39802 RVA: 0x00167221 File Offset: 0x00165421
		// (set) Token: 0x06009B7B RID: 39803 RVA: 0x0016724C File Offset: 0x0016544C
		public virtual EHandInHandInitiatorType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EHandInHandInitiatorType.Player;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005F42 RID: 24386
		[Nullable(2)]
		protected IHandInHandInitiatorType FbInstance;

		// Token: 0x04005F43 RID: 24387
		[Nullable(2)]
		protected IHandInHandInitiatorType_SetValue PocoInterface;
	}
}
