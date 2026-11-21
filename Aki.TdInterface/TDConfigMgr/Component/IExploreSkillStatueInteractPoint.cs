using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003AB RID: 939
	public class IExploreSkillStatueInteractPoint : IExploreSkillInteractType
	{
		// Token: 0x06001273 RID: 4723 RVA: 0x0003DADC File Offset: 0x0003BCDC
		private IExploreSkillStatueInteractPoint_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IExploreSkillStatueInteractPoint 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IExploreSkillStatueInteractPoint_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IExploreSkillStatueInteractPoint_SetValue());
			}
			return result;
		}

		// Token: 0x06001274 RID: 4724 RVA: 0x0003DB14 File Offset: 0x0003BD14
		public static IExploreSkillStatueInteractPoint Create([Nullable(2)] IExploreSkillStatueInteractPoint instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExploreSkillStatueInteractPoint
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001275 RID: 4725 RVA: 0x0003DB27 File Offset: 0x0003BD27
		public static IExploreSkillStatueInteractPoint CreateFromSetValue([Nullable(2)] IExploreSkillStatueInteractPoint_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IExploreSkillStatueInteractPoint
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001276 RID: 4726 RVA: 0x0003DB3A File Offset: 0x0003BD3A
		public new IExploreSkillStatueInteractPoint_SetValue ToSetValue()
		{
			return new IExploreSkillStatueInteractPoint_SetValue
			{
				Type = this.Type,
				PullTime = this.PullTime,
				HangingPointList = this.HangingPointList
			};
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06001277 RID: 4727 RVA: 0x0003DB65 File Offset: 0x0003BD65
		// (set) Token: 0x06001278 RID: 4728 RVA: 0x0003DB90 File Offset: 0x0003BD90
		public override EExploreSkillInteractType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EExploreSkillInteractType.PullGiant;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06001279 RID: 4729 RVA: 0x0003DB9E File Offset: 0x0003BD9E
		// (set) Token: 0x0600127A RID: 4730 RVA: 0x0003DBCD File Offset: 0x0003BDCD
		public virtual float PullTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PullTime;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.PullTime;
			}
			set
			{
				this.GetOrCreatePoco().PullTime = value;
			}
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x0600127B RID: 4731 RVA: 0x0003DBDB File Offset: 0x0003BDDB
		// (set) Token: 0x0600127C RID: 4732 RVA: 0x0003DC02 File Offset: 0x0003BE02
		public virtual List<string> HangingPointList
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HangingPointList;
				}
				IExploreSkillStatueInteractPoint_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.HangingPointList;
			}
			set
			{
				this.GetOrCreatePoco().HangingPointList = value;
			}
		}

		// Token: 0x04000F30 RID: 3888
		[Nullable(2)]
		protected new IExploreSkillStatueInteractPoint FbInstance;

		// Token: 0x04000F31 RID: 3889
		[Nullable(2)]
		protected new IExploreSkillStatueInteractPoint_SetValue PocoInterface;
	}
}
