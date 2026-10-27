using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200213D RID: 8509
	[NullableContext(1)]
	[Nullable(0)]
	public class ReignsChangePlayerName : ActionParams
	{
		// Token: 0x0600BB5E RID: 47966 RVA: 0x001B0AF4 File Offset: 0x001AECF4
		private ReignsChangePlayerName_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ReignsChangePlayerName 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ReignsChangePlayerName_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ReignsChangePlayerName_SetValue());
			}
			return result;
		}

		// Token: 0x0600BB5F RID: 47967 RVA: 0x001B0B2C File Offset: 0x001AED2C
		public static ReignsChangePlayerName Create([Nullable(2)] ReignsChangePlayerName instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ReignsChangePlayerName
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BB60 RID: 47968 RVA: 0x001B0B3F File Offset: 0x001AED3F
		public static ReignsChangePlayerName CreateFromSetValue([Nullable(2)] ReignsChangePlayerName_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ReignsChangePlayerName
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BB61 RID: 47969 RVA: 0x001B0B52 File Offset: 0x001AED52
		public ReignsChangePlayerName_SetValue ToSetValue()
		{
			return new ReignsChangePlayerName_SetValue
			{
				PlayerNameId = this.PlayerNameId
			};
		}

		// Token: 0x17003930 RID: 14640
		// (get) Token: 0x0600BB62 RID: 47970 RVA: 0x001B0B65 File Offset: 0x001AED65
		// (set) Token: 0x0600BB63 RID: 47971 RVA: 0x001B0B90 File Offset: 0x001AED90
		public virtual string PlayerNameId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PlayerNameId;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.PlayerNameId;
			}
			set
			{
				this.GetOrCreatePoco().PlayerNameId = value;
			}
		}

		// Token: 0x0400700F RID: 28687
		[Nullable(2)]
		protected new ReignsChangePlayerName FbInstance;

		// Token: 0x04007010 RID: 28688
		[Nullable(2)]
		protected ReignsChangePlayerName_SetValue PocoInterface;
	}
}
