using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000198 RID: 408
	public class GodKingFrequencyControllerComponent : IComponentBase
	{
		// Token: 0x0600055E RID: 1374 RVA: 0x00020E94 File Offset: 0x0001F094
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

		// Token: 0x0600055F RID: 1375 RVA: 0x00020ECC File Offset: 0x0001F0CC
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

		// Token: 0x06000560 RID: 1376 RVA: 0x00020EDF File Offset: 0x0001F0DF
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

		// Token: 0x06000561 RID: 1377 RVA: 0x00020EF4 File Offset: 0x0001F0F4
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

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000562 RID: 1378 RVA: 0x00020F68 File Offset: 0x0001F168
		// (set) Token: 0x06000563 RID: 1379 RVA: 0x00020FA2 File Offset: 0x0001F1A2
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

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000564 RID: 1380 RVA: 0x00020FB0 File Offset: 0x0001F1B0
		// (set) Token: 0x06000565 RID: 1381 RVA: 0x00020FDA File Offset: 0x0001F1DA
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

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000566 RID: 1382 RVA: 0x00020FE8 File Offset: 0x0001F1E8
		// (set) Token: 0x06000567 RID: 1383 RVA: 0x0002100F File Offset: 0x0001F20F
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

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000568 RID: 1384 RVA: 0x0002101D File Offset: 0x0001F21D
		// (set) Token: 0x06000569 RID: 1385 RVA: 0x00021048 File Offset: 0x0001F248
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

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x0600056A RID: 1386 RVA: 0x00021056 File Offset: 0x0001F256
		// (set) Token: 0x0600056B RID: 1387 RVA: 0x00021081 File Offset: 0x0001F281
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

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x0600056C RID: 1388 RVA: 0x0002108F File Offset: 0x0001F28F
		// (set) Token: 0x0600056D RID: 1389 RVA: 0x000210BA File Offset: 0x0001F2BA
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

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x0600056E RID: 1390 RVA: 0x000210C8 File Offset: 0x0001F2C8
		// (set) Token: 0x0600056F RID: 1391 RVA: 0x000210F7 File Offset: 0x0001F2F7
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

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000570 RID: 1392 RVA: 0x00021105 File Offset: 0x0001F305
		// (set) Token: 0x06000571 RID: 1393 RVA: 0x00021134 File Offset: 0x0001F334
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

		// Token: 0x040007AD RID: 1965
		[Nullable(2)]
		protected new GodKingFrequencyControllerComponent FbInstance;

		// Token: 0x040007AE RID: 1966
		[Nullable(2)]
		protected new GodKingFrequencyControllerComponent_SetValue PocoInterface;
	}
}
