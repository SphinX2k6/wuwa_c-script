using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DC5 RID: 7621
	public class IMessageBoard : IPhoneBoardTypeBase
	{
		// Token: 0x0600A1CF RID: 41423 RVA: 0x00172A10 File Offset: 0x00170C10
		private IMessageBoard_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMessageBoard 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMessageBoard_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMessageBoard_SetValue());
			}
			return result;
		}

		// Token: 0x0600A1D0 RID: 41424 RVA: 0x00172A48 File Offset: 0x00170C48
		public static IMessageBoard Create([Nullable(2)] IMessageBoard instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMessageBoard
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A1D1 RID: 41425 RVA: 0x00172A5B File Offset: 0x00170C5B
		public static IMessageBoard CreateFromSetValue([Nullable(2)] IMessageBoard_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMessageBoard
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A1D2 RID: 41426 RVA: 0x00172A6E File Offset: 0x00170C6E
		public new IMessageBoard_SetValue ToSetValue()
		{
			return new IMessageBoard_SetValue
			{
				Type = this.Type,
				MessageBoardConfig = this.MessageBoardConfig
			};
		}

		// Token: 0x1700324E RID: 12878
		// (get) Token: 0x0600A1D3 RID: 41427 RVA: 0x00172A8D File Offset: 0x00170C8D
		// (set) Token: 0x0600A1D4 RID: 41428 RVA: 0x00172AB8 File Offset: 0x00170CB8
		public override EPhoneBoardType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPhoneBoardType.MessageBoard;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700324F RID: 12879
		// (get) Token: 0x0600A1D5 RID: 41429 RVA: 0x00172AC8 File Offset: 0x00170CC8
		// (set) Token: 0x0600A1D6 RID: 41430 RVA: 0x00172B29 File Offset: 0x00170D29
		public virtual IPhoneMessageBoardConfig MessageBoardConfig
		{
			get
			{
				if (this._MessageBoardConfigInited)
				{
					return this._MessageBoardConfigCache;
				}
				this._MessageBoardConfigInited = true;
				if (this.FbInstance != null)
				{
					this._MessageBoardConfigCache = IPhoneMessageBoardConfig.Create(this.FbInstance.MessageBoardConfig);
				}
				else
				{
					IMessageBoard_SetValue pocoInterface = this.PocoInterface;
					this._MessageBoardConfigCache = ((pocoInterface != null) ? pocoInterface.MessageBoardConfig : null);
				}
				return this._MessageBoardConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().MessageBoardConfig = value;
				this._MessageBoardConfigInited = false;
			}
		}

		// Token: 0x04006235 RID: 25141
		[Nullable(2)]
		protected new IMessageBoard FbInstance;

		// Token: 0x04006236 RID: 25142
		[Nullable(2)]
		protected new IMessageBoard_SetValue PocoInterface;

		// Token: 0x04006237 RID: 25143
		private IPhoneMessageBoardConfig _MessageBoardConfigCache;

		// Token: 0x04006238 RID: 25144
		private bool _MessageBoardConfigInited;
	}
}
