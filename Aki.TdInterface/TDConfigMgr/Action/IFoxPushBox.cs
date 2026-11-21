using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C5A RID: 7258
	public class IFoxPushBox : ILeisureInteractType
	{
		// Token: 0x06009A54 RID: 39508 RVA: 0x0016538C File Offset: 0x0016358C
		private IFoxPushBox_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFoxPushBox 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFoxPushBox_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFoxPushBox_SetValue());
			}
			return result;
		}

		// Token: 0x06009A55 RID: 39509 RVA: 0x001653C4 File Offset: 0x001635C4
		public static IFoxPushBox Create([Nullable(2)] IFoxPushBox instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFoxPushBox
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009A56 RID: 39510 RVA: 0x001653D7 File Offset: 0x001635D7
		public static IFoxPushBox CreateFromSetValue([Nullable(2)] IFoxPushBox_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFoxPushBox
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009A57 RID: 39511 RVA: 0x001653EC File Offset: 0x001635EC
		public new IFoxPushBox_SetValue ToSetValue()
		{
			return new IFoxPushBox_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId,
				CollisionRadius = this.CollisionRadius,
				SplineEntityId = this.SplineEntityId,
				SendEntityEventOnSplineFinish = this.SendEntityEventOnSplineFinish
			};
		}

		// Token: 0x170030B0 RID: 12464
		// (get) Token: 0x06009A58 RID: 39512 RVA: 0x0016543A File Offset: 0x0016363A
		// (set) Token: 0x06009A59 RID: 39513 RVA: 0x00165465 File Offset: 0x00163665
		public override ELeisureInteract Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELeisureInteract.CustomSkill;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170030B1 RID: 12465
		// (get) Token: 0x06009A5A RID: 39514 RVA: 0x00165473 File Offset: 0x00163673
		// (set) Token: 0x06009A5B RID: 39515 RVA: 0x0016549E File Offset: 0x0016369E
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

		// Token: 0x170030B2 RID: 12466
		// (get) Token: 0x06009A5C RID: 39516 RVA: 0x001654AC File Offset: 0x001636AC
		// (set) Token: 0x06009A5D RID: 39517 RVA: 0x001654D7 File Offset: 0x001636D7
		public virtual int CollisionRadius
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CollisionRadius;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.CollisionRadius;
			}
			set
			{
				this.GetOrCreatePoco().CollisionRadius = value;
			}
		}

		// Token: 0x170030B3 RID: 12467
		// (get) Token: 0x06009A5E RID: 39518 RVA: 0x001654E5 File Offset: 0x001636E5
		// (set) Token: 0x06009A5F RID: 39519 RVA: 0x00165510 File Offset: 0x00163710
		public virtual int SplineEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SplineEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.SplineEntityId;
			}
			set
			{
				this.GetOrCreatePoco().SplineEntityId = value;
			}
		}

		// Token: 0x170030B4 RID: 12468
		// (get) Token: 0x06009A60 RID: 39520 RVA: 0x0016551E File Offset: 0x0016371E
		// (set) Token: 0x06009A61 RID: 39521 RVA: 0x00165545 File Offset: 0x00163745
		[Nullable(2)]
		public virtual string SendEntityEventOnSplineFinish
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SendEntityEventOnSplineFinish;
				}
				IFoxPushBox_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SendEntityEventOnSplineFinish;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().SendEntityEventOnSplineFinish = value;
			}
		}

		// Token: 0x04005EC7 RID: 24263
		[Nullable(2)]
		protected new IFoxPushBox FbInstance;

		// Token: 0x04005EC8 RID: 24264
		[Nullable(2)]
		protected new IFoxPushBox_SetValue PocoInterface;
	}
}
