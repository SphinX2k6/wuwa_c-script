using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FB1 RID: 8113
	public class IRemovePreloadResourcePhantomCharacter : IRemovePreloadResourceCharacterType
	{
		// Token: 0x0600AC73 RID: 44147 RVA: 0x00185D94 File Offset: 0x00183F94
		private IRemovePreloadResourcePhantomCharacter_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRemovePreloadResourcePhantomCharacter 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRemovePreloadResourcePhantomCharacter_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRemovePreloadResourcePhantomCharacter_SetValue());
			}
			return result;
		}

		// Token: 0x0600AC74 RID: 44148 RVA: 0x00185DCC File Offset: 0x00183FCC
		public static IRemovePreloadResourcePhantomCharacter Create([Nullable(2)] IRemovePreloadResourcePhantomCharacter instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRemovePreloadResourcePhantomCharacter
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AC75 RID: 44149 RVA: 0x00185DDF File Offset: 0x00183FDF
		public static IRemovePreloadResourcePhantomCharacter CreateFromSetValue([Nullable(2)] IRemovePreloadResourcePhantomCharacter_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRemovePreloadResourcePhantomCharacter
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AC76 RID: 44150 RVA: 0x00185DF2 File Offset: 0x00183FF2
		public new IRemovePreloadResourcePhantomCharacter_SetValue ToSetValue()
		{
			return new IRemovePreloadResourcePhantomCharacter_SetValue
			{
				Type = this.Type,
				Id = this.Id,
				DelayReMove = this.DelayReMove
			};
		}

		// Token: 0x170034BE RID: 13502
		// (get) Token: 0x0600AC77 RID: 44151 RVA: 0x00185E1D File Offset: 0x0018401D
		// (set) Token: 0x0600AC78 RID: 44152 RVA: 0x00185E48 File Offset: 0x00184048
		public override ERemovePreloadResourceObjectType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ERemovePreloadResourceObjectType.RemovePreloadResourceTrialCharacter;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170034BF RID: 13503
		// (get) Token: 0x0600AC79 RID: 44153 RVA: 0x00185E56 File Offset: 0x00184056
		// (set) Token: 0x0600AC7A RID: 44154 RVA: 0x00185E81 File Offset: 0x00184081
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x170034C0 RID: 13504
		// (get) Token: 0x0600AC7B RID: 44155 RVA: 0x00185E90 File Offset: 0x00184090
		// (set) Token: 0x0600AC7C RID: 44156 RVA: 0x00185EF1 File Offset: 0x001840F1
		[Nullable(2)]
		public virtual IDelayRemoveAfterSkillFinish DelayReMove
		{
			[NullableContext(2)]
			get
			{
				if (this._DelayReMoveInited)
				{
					return this._DelayReMoveCache;
				}
				this._DelayReMoveInited = true;
				if (this.FbInstance != null)
				{
					this._DelayReMoveCache = IDelayRemoveAfterSkillFinish.Create(this.FbInstance.DelayReMove);
				}
				else
				{
					IRemovePreloadResourcePhantomCharacter_SetValue pocoInterface = this.PocoInterface;
					this._DelayReMoveCache = ((pocoInterface != null) ? pocoInterface.DelayReMove : null);
				}
				return this._DelayReMoveCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().DelayReMove = value;
				this._DelayReMoveInited = false;
			}
		}

		// Token: 0x04006715 RID: 26389
		[Nullable(2)]
		protected new IRemovePreloadResourcePhantomCharacter FbInstance;

		// Token: 0x04006716 RID: 26390
		[Nullable(2)]
		protected new IRemovePreloadResourcePhantomCharacter_SetValue PocoInterface;

		// Token: 0x04006717 RID: 26391
		private IDelayRemoveAfterSkillFinish _DelayReMoveCache;

		// Token: 0x04006718 RID: 26392
		private bool _DelayReMoveInited;
	}
}
