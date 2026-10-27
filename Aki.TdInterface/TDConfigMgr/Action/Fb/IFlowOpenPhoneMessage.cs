using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AC9 RID: 10953
	[NullableContext(1)]
	[Nullable(0)]
	public class IFlowOpenPhoneMessage : IPhoneSystemInteractBase
	{
		// Token: 0x0600F04C RID: 61516 RVA: 0x0022E57A File Offset: 0x0022C77A
		public static IFlowOpenPhoneMessage Create(IFlowOpenPhoneMessage? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowOpenPhoneMessage
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C7C RID: 19580
		// (get) Token: 0x0600F04D RID: 61517 RVA: 0x0022E599 File Offset: 0x0022C799
		public override EPhoneSystemInteractType Type
		{
			get
			{
				return (EPhoneSystemInteractType)this.Instance.Type;
			}
		}

		// Token: 0x17004C7D RID: 19581
		// (get) Token: 0x0600F04E RID: 61518 RVA: 0x0022E5A6 File Offset: 0x0022C7A6
		public virtual IMessageBoard PhoneBoardType
		{
			get
			{
				if (this._PhoneBoardTypeInited)
				{
					return this._PhoneBoardTypeCache;
				}
				this._PhoneBoardTypeInited = true;
				this._PhoneBoardTypeCache = IMessageBoard.Create(this.Instance.PhoneBoardType);
				return this._PhoneBoardTypeCache;
			}
		}

		// Token: 0x0400842B RID: 33835
		private IFlowOpenPhoneMessage Instance;

		// Token: 0x0400842C RID: 33836
		[Nullable(2)]
		private IMessageBoard _PhoneBoardTypeCache;

		// Token: 0x0400842D RID: 33837
		private bool _PhoneBoardTypeInited;
	}
}
