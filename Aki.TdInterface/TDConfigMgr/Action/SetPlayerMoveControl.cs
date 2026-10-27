using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021CB RID: 8651
	[NullableContext(1)]
	[Nullable(0)]
	public class SetPlayerMoveControl : ActionParams
	{
		// Token: 0x0600BDF8 RID: 48632 RVA: 0x001B564C File Offset: 0x001B384C
		private SetPlayerMoveControl_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetPlayerMoveControl 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetPlayerMoveControl_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetPlayerMoveControl_SetValue());
			}
			return result;
		}

		// Token: 0x0600BDF9 RID: 48633 RVA: 0x001B5684 File Offset: 0x001B3884
		public static SetPlayerMoveControl Create([Nullable(2)] SetPlayerMoveControl instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetPlayerMoveControl
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BDFA RID: 48634 RVA: 0x001B5697 File Offset: 0x001B3897
		public static SetPlayerMoveControl CreateFromSetValue([Nullable(2)] SetPlayerMoveControl_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetPlayerMoveControl
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BDFB RID: 48635 RVA: 0x001B56AA File Offset: 0x001B38AA
		public SetPlayerMoveControl_SetValue ToSetValue()
		{
			return new SetPlayerMoveControl_SetValue
			{
				Left = this.Left,
				Right = this.Right,
				Forward = this.Forward,
				Back = this.Back
			};
		}

		// Token: 0x170039AC RID: 14764
		// (get) Token: 0x0600BDFC RID: 48636 RVA: 0x001B56E1 File Offset: 0x001B38E1
		// (set) Token: 0x0600BDFD RID: 48637 RVA: 0x001B570C File Offset: 0x001B390C
		public virtual int Left
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Left;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Left;
			}
			set
			{
				this.GetOrCreatePoco().Left = value;
			}
		}

		// Token: 0x170039AD RID: 14765
		// (get) Token: 0x0600BDFE RID: 48638 RVA: 0x001B571A File Offset: 0x001B391A
		// (set) Token: 0x0600BDFF RID: 48639 RVA: 0x001B5745 File Offset: 0x001B3945
		public virtual int Right
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Right;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Right;
			}
			set
			{
				this.GetOrCreatePoco().Right = value;
			}
		}

		// Token: 0x170039AE RID: 14766
		// (get) Token: 0x0600BE00 RID: 48640 RVA: 0x001B5753 File Offset: 0x001B3953
		// (set) Token: 0x0600BE01 RID: 48641 RVA: 0x001B577E File Offset: 0x001B397E
		public virtual int Forward
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Forward;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Forward;
			}
			set
			{
				this.GetOrCreatePoco().Forward = value;
			}
		}

		// Token: 0x170039AF RID: 14767
		// (get) Token: 0x0600BE02 RID: 48642 RVA: 0x001B578C File Offset: 0x001B398C
		// (set) Token: 0x0600BE03 RID: 48643 RVA: 0x001B57B7 File Offset: 0x001B39B7
		public virtual int Back
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Back;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Back;
			}
			set
			{
				this.GetOrCreatePoco().Back = value;
			}
		}

		// Token: 0x0400715D RID: 29021
		[Nullable(2)]
		protected new SetPlayerMoveControl FbInstance;

		// Token: 0x0400715E RID: 29022
		[Nullable(2)]
		protected SetPlayerMoveControl_SetValue PocoInterface;
	}
}
