using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002128 RID: 8488
	public class ISundialPuzzleGameplay : IUiGame
	{
		// Token: 0x0600B434 RID: 46132 RVA: 0x00193F38 File Offset: 0x00192138
		private ISundialPuzzleGameplay_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISundialPuzzleGameplay 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISundialPuzzleGameplay_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISundialPuzzleGameplay_SetValue());
			}
			return result;
		}

		// Token: 0x0600B435 RID: 46133 RVA: 0x00193F70 File Offset: 0x00192170
		public static ISundialPuzzleGameplay Create([Nullable(2)] ISundialPuzzleGameplay instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISundialPuzzleGameplay
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B436 RID: 46134 RVA: 0x00193F83 File Offset: 0x00192183
		public static ISundialPuzzleGameplay CreateFromSetValue([Nullable(2)] ISundialPuzzleGameplay_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISundialPuzzleGameplay
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B437 RID: 46135 RVA: 0x00193F96 File Offset: 0x00192196
		public new ISundialPuzzleGameplay_SetValue ToSetValue()
		{
			return new ISundialPuzzleGameplay_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700366D RID: 13933
		// (get) Token: 0x0600B438 RID: 46136 RVA: 0x00193FA9 File Offset: 0x001921A9
		// (set) Token: 0x0600B439 RID: 46137 RVA: 0x00193FD4 File Offset: 0x001921D4
		public override ESimpleGameplayType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESimpleGameplayType.Cipher;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006AB6 RID: 27318
		[Nullable(2)]
		protected new ISundialPuzzleGameplay FbInstance;

		// Token: 0x04006AB7 RID: 27319
		[Nullable(2)]
		protected new ISundialPuzzleGameplay_SetValue PocoInterface;
	}
}
