using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B1F RID: 6943
	public class IDetectBattleTag : IDetectBattleStateType
	{
		// Token: 0x0600935D RID: 37725 RVA: 0x00158A28 File Offset: 0x00156C28
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

		// Token: 0x0600935E RID: 37726 RVA: 0x00158A60 File Offset: 0x00156C60
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

		// Token: 0x0600935F RID: 37727 RVA: 0x00158A73 File Offset: 0x00156C73
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

		// Token: 0x06009360 RID: 37728 RVA: 0x00158A86 File Offset: 0x00156C86
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

		// Token: 0x17002F0C RID: 12044
		// (get) Token: 0x06009361 RID: 37729 RVA: 0x00158ABD File Offset: 0x00156CBD
		// (set) Token: 0x06009362 RID: 37730 RVA: 0x00158AE8 File Offset: 0x00156CE8
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

		// Token: 0x17002F0D RID: 12045
		// (get) Token: 0x06009363 RID: 37731 RVA: 0x00158AF6 File Offset: 0x00156CF6
		// (set) Token: 0x06009364 RID: 37732 RVA: 0x00158B21 File Offset: 0x00156D21
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

		// Token: 0x17002F0E RID: 12046
		// (get) Token: 0x06009365 RID: 37733 RVA: 0x00158B30 File Offset: 0x00156D30
		// (set) Token: 0x06009366 RID: 37734 RVA: 0x00158B91 File Offset: 0x00156D91
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

		// Token: 0x17002F0F RID: 12047
		// (get) Token: 0x06009367 RID: 37735 RVA: 0x00158BA6 File Offset: 0x00156DA6
		// (set) Token: 0x06009368 RID: 37736 RVA: 0x00158BD5 File Offset: 0x00156DD5
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

		// Token: 0x04005B9B RID: 23451
		[Nullable(2)]
		protected new IDetectBattleTag FbInstance;

		// Token: 0x04005B9C RID: 23452
		[Nullable(2)]
		protected new IDetectBattleTag_SetValue PocoInterface;

		// Token: 0x04005B9D RID: 23453
		private IDetectBattleMonsterOnGround _TagOptionCache;

		// Token: 0x04005B9E RID: 23454
		private bool _TagOptionInited;
	}
}
