using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AC8 RID: 10952
	[NullableContext(1)]
	[Nullable(0)]
	public class IOpenPhoneMessageBoard : IPhoneSystemInteractBase
	{
		// Token: 0x0600F048 RID: 61512 RVA: 0x0022E512 File Offset: 0x0022C712
		public static IOpenPhoneMessageBoard Create(IOpenPhoneMessageBoard? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOpenPhoneMessageBoard
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C7A RID: 19578
		// (get) Token: 0x0600F049 RID: 61513 RVA: 0x0022E531 File Offset: 0x0022C731
		public override EPhoneSystemInteractType Type
		{
			get
			{
				return (EPhoneSystemInteractType)this.Instance.Type;
			}
		}

		// Token: 0x17004C7B RID: 19579
		// (get) Token: 0x0600F04A RID: 61514 RVA: 0x0022E53E File Offset: 0x0022C73E
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

		// Token: 0x04008428 RID: 33832
		private IOpenPhoneMessageBoard Instance;

		// Token: 0x04008429 RID: 33833
		[Nullable(2)]
		private IMessageBoard _PhoneBoardTypeCache;

		// Token: 0x0400842A RID: 33834
		private bool _PhoneBoardTypeInited;
	}
}
