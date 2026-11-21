using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DBB RID: 11707
	public class IMessageBoard : IPhoneBoardTypeBase
	{
		// Token: 0x0600FEFA RID: 65274 RVA: 0x0024C1B6 File Offset: 0x0024A3B6
		public static IMessageBoard Create(IMessageBoard? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMessageBoard
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17005032 RID: 20530
		// (get) Token: 0x0600FEFB RID: 65275 RVA: 0x0024C1D5 File Offset: 0x0024A3D5
		public override EPhoneBoardType Type
		{
			get
			{
				return (EPhoneBoardType)this.Instance.Type;
			}
		}

		// Token: 0x17005033 RID: 20531
		// (get) Token: 0x0600FEFC RID: 65276 RVA: 0x0024C1E2 File Offset: 0x0024A3E2
		public virtual IPhoneMessageBoardConfig MessageBoardConfig
		{
			get
			{
				if (this._MessageBoardConfigInited)
				{
					return this._MessageBoardConfigCache;
				}
				this._MessageBoardConfigInited = true;
				this._MessageBoardConfigCache = IPhoneMessageBoardConfig.Create(this.Instance.MessageBoardConfig);
				return this._MessageBoardConfigCache;
			}
		}

		// Token: 0x04008B29 RID: 35625
		private IMessageBoard Instance;

		// Token: 0x04008B2A RID: 35626
		[Nullable(2)]
		private IPhoneMessageBoardConfig _MessageBoardConfigCache;

		// Token: 0x04008B2B RID: 35627
		private bool _MessageBoardConfigInited;
	}
}
