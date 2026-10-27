using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000362 RID: 866
	[NullableContext(1)]
	[Nullable(0)]
	public class IExploreSkillStatueInteractPoint : IExploreSkillInteractType
	{
		// Token: 0x0600112F RID: 4399 RVA: 0x0003A7F8 File Offset: 0x000389F8
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

		// Token: 0x06001130 RID: 4400 RVA: 0x0003A830 File Offset: 0x00038A30
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

		// Token: 0x06001131 RID: 4401 RVA: 0x0003A843 File Offset: 0x00038A43
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

		// Token: 0x06001132 RID: 4402 RVA: 0x0003A856 File Offset: 0x00038A56
		public new IExploreSkillStatueInteractPoint_SetValue ToSetValue()
		{
			return new IExploreSkillStatueInteractPoint_SetValue
			{
				Type = this.Type,
				PullTime = this.PullTime,
				HangingPointList = this.HangingPointList
			};
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06001133 RID: 4403 RVA: 0x0003A881 File Offset: 0x00038A81
		// (set) Token: 0x06001134 RID: 4404 RVA: 0x0003A8AC File Offset: 0x00038AAC
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

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06001135 RID: 4405 RVA: 0x0003A8BA File Offset: 0x00038ABA
		// (set) Token: 0x06001136 RID: 4406 RVA: 0x0003A8E9 File Offset: 0x00038AE9
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

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06001137 RID: 4407 RVA: 0x0003A8F7 File Offset: 0x00038AF7
		// (set) Token: 0x06001138 RID: 4408 RVA: 0x0003A91E File Offset: 0x00038B1E
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

		// Token: 0x04000E39 RID: 3641
		[Nullable(2)]
		protected new IExploreSkillStatueInteractPoint FbInstance;

		// Token: 0x04000E3A RID: 3642
		[Nullable(2)]
		protected new IExploreSkillStatueInteractPoint_SetValue PocoInterface;
	}
}
