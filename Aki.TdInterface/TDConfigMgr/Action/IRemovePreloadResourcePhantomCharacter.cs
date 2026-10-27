using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D9C RID: 7580
	[NullableContext(1)]
	[Nullable(0)]
	public class IRemovePreloadResourcePhantomCharacter : IRemovePreloadResourceCharacterType
	{
		// Token: 0x0600A273 RID: 41587 RVA: 0x0017176C File Offset: 0x0016F96C
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

		// Token: 0x0600A274 RID: 41588 RVA: 0x001717A4 File Offset: 0x0016F9A4
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

		// Token: 0x0600A275 RID: 41589 RVA: 0x001717B7 File Offset: 0x0016F9B7
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

		// Token: 0x0600A276 RID: 41590 RVA: 0x001717CA File Offset: 0x0016F9CA
		public new IRemovePreloadResourcePhantomCharacter_SetValue ToSetValue()
		{
			return new IRemovePreloadResourcePhantomCharacter_SetValue
			{
				Type = this.Type,
				Id = this.Id,
				DelayReMove = this.DelayReMove
			};
		}

		// Token: 0x17003226 RID: 12838
		// (get) Token: 0x0600A277 RID: 41591 RVA: 0x001717F5 File Offset: 0x0016F9F5
		// (set) Token: 0x0600A278 RID: 41592 RVA: 0x00171820 File Offset: 0x0016FA20
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

		// Token: 0x17003227 RID: 12839
		// (get) Token: 0x0600A279 RID: 41593 RVA: 0x0017182E File Offset: 0x0016FA2E
		// (set) Token: 0x0600A27A RID: 41594 RVA: 0x00171859 File Offset: 0x0016FA59
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

		// Token: 0x17003228 RID: 12840
		// (get) Token: 0x0600A27B RID: 41595 RVA: 0x00171868 File Offset: 0x0016FA68
		// (set) Token: 0x0600A27C RID: 41596 RVA: 0x001718C9 File Offset: 0x0016FAC9
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

		// Token: 0x04006191 RID: 24977
		[Nullable(2)]
		protected new IRemovePreloadResourcePhantomCharacter FbInstance;

		// Token: 0x04006192 RID: 24978
		[Nullable(2)]
		protected new IRemovePreloadResourcePhantomCharacter_SetValue PocoInterface;

		// Token: 0x04006193 RID: 24979
		private IDelayRemoveAfterSkillFinish _DelayReMoveCache;

		// Token: 0x04006194 RID: 24980
		private bool _DelayReMoveInited;
	}
}
