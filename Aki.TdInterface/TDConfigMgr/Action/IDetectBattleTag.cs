using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001998 RID: 6552
	[NullableContext(1)]
	[Nullable(0)]
	public class IDetectBattleTag : IDetectBattleStateType
	{
		// Token: 0x06008C39 RID: 35897 RVA: 0x00149218 File Offset: 0x00147418
		private IDetectBattleTag_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDetectBattleTag 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDetectBattleTag_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDetectBattleTag_SetValue());
			}
			return result;
		}

		// Token: 0x06008C3A RID: 35898 RVA: 0x00149250 File Offset: 0x00147450
		public static IDetectBattleTag Create([Nullable(2)] IDetectBattleTag instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDetectBattleTag
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008C3B RID: 35899 RVA: 0x00149263 File Offset: 0x00147463
		public static IDetectBattleTag CreateFromSetValue([Nullable(2)] IDetectBattleTag_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDetectBattleTag
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008C3C RID: 35900 RVA: 0x00149276 File Offset: 0x00147476
		public new IDetectBattleTag_SetValue ToSetValue()
		{
			return new IDetectBattleTag_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId,
				TagOption = this.TagOption,
				MaxWaitTime = this.MaxWaitTime
			};
		}

		// Token: 0x17002D0D RID: 11533
		// (get) Token: 0x06008C3D RID: 35901 RVA: 0x001492AD File Offset: 0x001474AD
		// (set) Token: 0x06008C3E RID: 35902 RVA: 0x001492D8 File Offset: 0x001474D8
		public override EDetectBattleConditionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EDetectBattleConditionType.DetectBattleTag;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002D0E RID: 11534
		// (get) Token: 0x06008C3F RID: 35903 RVA: 0x001492E6 File Offset: 0x001474E6
		// (set) Token: 0x06008C40 RID: 35904 RVA: 0x00149311 File Offset: 0x00147511
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x17002D0F RID: 11535
		// (get) Token: 0x06008C41 RID: 35905 RVA: 0x00149320 File Offset: 0x00147520
		// (set) Token: 0x06008C42 RID: 35906 RVA: 0x00149381 File Offset: 0x00147581
		public virtual IDetectBattleMonsterOnGround TagOption
		{
			get
			{
				if (this._TagOptionInited)
				{
					return this._TagOptionCache;
				}
				this._TagOptionInited = true;
				if (this.FbInstance != null)
				{
					this._TagOptionCache = IDetectBattleMonsterOnGround.Create(this.FbInstance.TagOption);
				}
				else
				{
					IDetectBattleTag_SetValue pocoInterface = this.PocoInterface;
					this._TagOptionCache = ((pocoInterface != null) ? pocoInterface.TagOption : null);
				}
				return this._TagOptionCache;
			}
			set
			{
				this.GetOrCreatePoco().TagOption = value;
				this._TagOptionInited = false;
			}
		}

		// Token: 0x17002D10 RID: 11536
		// (get) Token: 0x06008C43 RID: 35907 RVA: 0x00149396 File Offset: 0x00147596
		// (set) Token: 0x06008C44 RID: 35908 RVA: 0x001493C5 File Offset: 0x001475C5
		public virtual float MaxWaitTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxWaitTime;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.MaxWaitTime;
			}
			set
			{
				this.GetOrCreatePoco().MaxWaitTime = value;
			}
		}

		// Token: 0x04005752 RID: 22354
		[Nullable(2)]
		protected new IDetectBattleTag FbInstance;

		// Token: 0x04005753 RID: 22355
		[Nullable(2)]
		protected new IDetectBattleTag_SetValue PocoInterface;

		// Token: 0x04005754 RID: 22356
		private IDetectBattleMonsterOnGround _TagOptionCache;

		// Token: 0x04005755 RID: 22357
		private bool _TagOptionInited;
	}
}
