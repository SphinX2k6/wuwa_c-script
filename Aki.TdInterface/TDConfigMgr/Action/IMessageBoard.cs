using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BDC RID: 7132
	[NullableContext(1)]
	[Nullable(0)]
	public class IMessageBoard : IPhoneBoardTypeBase
	{
		// Token: 0x060098C1 RID: 39105 RVA: 0x0015FE50 File Offset: 0x0015E050
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

		// Token: 0x060098C2 RID: 39106 RVA: 0x0015FE88 File Offset: 0x0015E088
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

		// Token: 0x060098C3 RID: 39107 RVA: 0x0015FE9B File Offset: 0x0015E09B
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

		// Token: 0x060098C4 RID: 39108 RVA: 0x0015FEAE File Offset: 0x0015E0AE
		public new IMessageBoard_SetValue ToSetValue()
		{
			return new IMessageBoard_SetValue
			{
				Type = this.Type,
				MessageBoardConfig = this.MessageBoardConfig
			};
		}

		// Token: 0x17002FED RID: 12269
		// (get) Token: 0x060098C5 RID: 39109 RVA: 0x0015FECD File Offset: 0x0015E0CD
		// (set) Token: 0x060098C6 RID: 39110 RVA: 0x0015FEF8 File Offset: 0x0015E0F8
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

		// Token: 0x17002FEE RID: 12270
		// (get) Token: 0x060098C7 RID: 39111 RVA: 0x0015FF08 File Offset: 0x0015E108
		// (set) Token: 0x060098C8 RID: 39112 RVA: 0x0015FF69 File Offset: 0x0015E169
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

		// Token: 0x04005D1C RID: 23836
		[Nullable(2)]
		protected new IMessageBoard FbInstance;

		// Token: 0x04005D1D RID: 23837
		[Nullable(2)]
		protected new IMessageBoard_SetValue PocoInterface;

		// Token: 0x04005D1E RID: 23838
		private IPhoneMessageBoardConfig _MessageBoardConfigCache;

		// Token: 0x04005D1F RID: 23839
		private bool _MessageBoardConfigInited;
	}
}
