using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AC7 RID: 10951
	[NullableContext(1)]
	[Nullable(0)]
	public class IMessageBoard : IPhoneBoardTypeBase
	{
		// Token: 0x0600F044 RID: 61508 RVA: 0x0022E4AA File Offset: 0x0022C6AA
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

		// Token: 0x17004C78 RID: 19576
		// (get) Token: 0x0600F045 RID: 61509 RVA: 0x0022E4C9 File Offset: 0x0022C6C9
		public override EPhoneBoardType Type
		{
			get
			{
				return (EPhoneBoardType)this.Instance.Type;
			}
		}

		// Token: 0x17004C79 RID: 19577
		// (get) Token: 0x0600F046 RID: 61510 RVA: 0x0022E4D6 File Offset: 0x0022C6D6
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

		// Token: 0x04008425 RID: 33829
		private IMessageBoard Instance;

		// Token: 0x04008426 RID: 33830
		[Nullable(2)]
		private IPhoneMessageBoardConfig _MessageBoardConfigCache;

		// Token: 0x04008427 RID: 33831
		private bool _MessageBoardConfigInited;
	}
}
