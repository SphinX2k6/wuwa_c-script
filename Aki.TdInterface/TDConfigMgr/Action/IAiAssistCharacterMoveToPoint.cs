using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200194D RID: 6477
	public class IAiAssistCharacterMoveToPoint : IExecBattleActionType
	{
		// Token: 0x060089B9 RID: 35257 RVA: 0x00147D4C File Offset: 0x00145F4C
		private IAiAssistCharacterMoveToPoint_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAiAssistCharacterMoveToPoint 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAiAssistCharacterMoveToPoint_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAiAssistCharacterMoveToPoint_SetValue());
			}
			return result;
		}

		// Token: 0x060089BA RID: 35258 RVA: 0x00147D84 File Offset: 0x00145F84
		public static IAiAssistCharacterMoveToPoint Create([Nullable(2)] IAiAssistCharacterMoveToPoint instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAiAssistCharacterMoveToPoint
			{
				FbInstance = instance
			};
		}

		// Token: 0x060089BB RID: 35259 RVA: 0x00147D97 File Offset: 0x00145F97
		public static IAiAssistCharacterMoveToPoint CreateFromSetValue([Nullable(2)] IAiAssistCharacterMoveToPoint_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAiAssistCharacterMoveToPoint
			{
				PocoInterface = value
			};
		}

		// Token: 0x060089BC RID: 35260 RVA: 0x00147DAA File Offset: 0x00145FAA
		public new IAiAssistCharacterMoveToPoint_SetValue ToSetValue()
		{
			return new IAiAssistCharacterMoveToPoint_SetValue
			{
				Type = this.Type,
				AssistCharacterId = this.AssistCharacterId,
				MoveType = this.MoveType,
				Timeout = this.Timeout
			};
		}

		// Token: 0x17002CF5 RID: 11509
		// (get) Token: 0x060089BD RID: 35261 RVA: 0x00147DE1 File Offset: 0x00145FE1
		// (set) Token: 0x060089BE RID: 35262 RVA: 0x00147E0C File Offset: 0x0014600C
		public override EExecBattleActionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EExecBattleActionType.SetBattleTags;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002CF6 RID: 11510
		// (get) Token: 0x060089BF RID: 35263 RVA: 0x00147E1A File Offset: 0x0014601A
		// (set) Token: 0x060089C0 RID: 35264 RVA: 0x00147E45 File Offset: 0x00146045
		public virtual int AssistCharacterId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AssistCharacterId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.AssistCharacterId;
			}
			set
			{
				this.GetOrCreatePoco().AssistCharacterId = value;
			}
		}

		// Token: 0x17002CF7 RID: 11511
		// (get) Token: 0x060089C1 RID: 35265 RVA: 0x00147E53 File Offset: 0x00146053
		// (set) Token: 0x060089C2 RID: 35266 RVA: 0x00147E7A File Offset: 0x0014607A
		public virtual IAssistCharacterMoveType MoveType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MoveType;
				}
				IAiAssistCharacterMoveToPoint_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MoveType;
			}
			set
			{
				this.GetOrCreatePoco().MoveType = value;
			}
		}

		// Token: 0x17002CF8 RID: 11512
		// (get) Token: 0x060089C3 RID: 35267 RVA: 0x00147E88 File Offset: 0x00146088
		// (set) Token: 0x060089C4 RID: 35268 RVA: 0x00147EB3 File Offset: 0x001460B3
		public virtual int Timeout
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Timeout;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Timeout;
			}
			set
			{
				this.GetOrCreatePoco().Timeout = value;
			}
		}

		// Token: 0x04005754 RID: 22356
		[Nullable(2)]
		protected new IAiAssistCharacterMoveToPoint FbInstance;

		// Token: 0x04005755 RID: 22357
		[Nullable(2)]
		protected new IAiAssistCharacterMoveToPoint_SetValue PocoInterface;
	}
}
