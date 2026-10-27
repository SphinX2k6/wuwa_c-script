using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000181 RID: 385
	[NullableContext(1)]
	[Nullable(0)]
	public class GodKingFrequencyControllerComponent : IComponentBase
	{
		// Token: 0x0600054A RID: 1354 RVA: 0x000202B8 File Offset: 0x0001E4B8
		private GodKingFrequencyControllerComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("GodKingFrequencyControllerComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			GodKingFrequencyControllerComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new GodKingFrequencyControllerComponent_SetValue());
			}
			return result;
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x000202F0 File Offset: 0x0001E4F0
		public static GodKingFrequencyControllerComponent Create([Nullable(2)] GodKingFrequencyControllerComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new GodKingFrequencyControllerComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x00020303 File Offset: 0x0001E503
		public static GodKingFrequencyControllerComponent CreateFromSetValue([Nullable(2)] GodKingFrequencyControllerComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new GodKingFrequencyControllerComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x00020318 File Offset: 0x0001E518
		public new GodKingFrequencyControllerComponent_SetValue ToSetValue()
		{
			return new GodKingFrequencyControllerComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				StatueEntityIdList = this.StatueEntityIdList,
				InitialAttachStatue = this.InitialAttachStatue,
				GodKingFrequencyEntity = this.GodKingFrequencyEntity,
				AttachSocket = this.AttachSocket,
				FlySpeed = this.FlySpeed,
				MaxFlyTime = this.MaxFlyTime
			};
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x0600054E RID: 1358 RVA: 0x0002038C File Offset: 0x0001E58C
		// (set) Token: 0x0600054F RID: 1359 RVA: 0x000203C6 File Offset: 0x0001E5C6
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				GodKingFrequencyControllerComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000550 RID: 1360 RVA: 0x000203D4 File Offset: 0x0001E5D4
		// (set) Token: 0x06000551 RID: 1361 RVA: 0x000203FE File Offset: 0x0001E5FE
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000552 RID: 1362 RVA: 0x0002040C File Offset: 0x0001E60C
		// (set) Token: 0x06000553 RID: 1363 RVA: 0x00020433 File Offset: 0x0001E633
		public virtual List<int> StatueEntityIdList
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StatueEntityIdList;
				}
				GodKingFrequencyControllerComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.StatueEntityIdList;
			}
			set
			{
				this.GetOrCreatePoco().StatueEntityIdList = value;
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000554 RID: 1364 RVA: 0x00020441 File Offset: 0x0001E641
		// (set) Token: 0x06000555 RID: 1365 RVA: 0x0002046C File Offset: 0x0001E66C
		public virtual int InitialAttachStatue
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InitialAttachStatue;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.InitialAttachStatue;
			}
			set
			{
				this.GetOrCreatePoco().InitialAttachStatue = value;
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000556 RID: 1366 RVA: 0x0002047A File Offset: 0x0001E67A
		// (set) Token: 0x06000557 RID: 1367 RVA: 0x000204A5 File Offset: 0x0001E6A5
		public virtual int GodKingFrequencyEntity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GodKingFrequencyEntity;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.GodKingFrequencyEntity;
			}
			set
			{
				this.GetOrCreatePoco().GodKingFrequencyEntity = value;
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000558 RID: 1368 RVA: 0x000204B3 File Offset: 0x0001E6B3
		// (set) Token: 0x06000559 RID: 1369 RVA: 0x000204DE File Offset: 0x0001E6DE
		public virtual string AttachSocket
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AttachSocket;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.AttachSocket;
			}
			set
			{
				this.GetOrCreatePoco().AttachSocket = value;
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x0600055A RID: 1370 RVA: 0x000204EC File Offset: 0x0001E6EC
		// (set) Token: 0x0600055B RID: 1371 RVA: 0x0002051B File Offset: 0x0001E71B
		public virtual float FlySpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FlySpeed;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.FlySpeed;
			}
			set
			{
				this.GetOrCreatePoco().FlySpeed = value;
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x0600055C RID: 1372 RVA: 0x00020529 File Offset: 0x0001E729
		// (set) Token: 0x0600055D RID: 1373 RVA: 0x00020558 File Offset: 0x0001E758
		public virtual float MaxFlyTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxFlyTime;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.MaxFlyTime;
			}
			set
			{
				this.GetOrCreatePoco().MaxFlyTime = value;
			}
		}

		// Token: 0x04000757 RID: 1879
		[Nullable(2)]
		protected new GodKingFrequencyControllerComponent FbInstance;

		// Token: 0x04000758 RID: 1880
		[Nullable(2)]
		protected new GodKingFrequencyControllerComponent_SetValue PocoInterface;
	}
}
