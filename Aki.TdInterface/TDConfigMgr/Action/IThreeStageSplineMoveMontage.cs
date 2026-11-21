using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002203 RID: 8707
	public class IThreeStageSplineMoveMontage : ISplineMoveMontageType
	{
		// Token: 0x0600BDD6 RID: 48598 RVA: 0x001B6D88 File Offset: 0x001B4F88
		private IThreeStageSplineMoveMontage_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IThreeStageSplineMoveMontage 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IThreeStageSplineMoveMontage_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IThreeStageSplineMoveMontage_SetValue());
			}
			return result;
		}

		// Token: 0x0600BDD7 RID: 48599 RVA: 0x001B6DC0 File Offset: 0x001B4FC0
		public static IThreeStageSplineMoveMontage Create([Nullable(2)] IThreeStageSplineMoveMontage instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IThreeStageSplineMoveMontage
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BDD8 RID: 48600 RVA: 0x001B6DD3 File Offset: 0x001B4FD3
		public static IThreeStageSplineMoveMontage CreateFromSetValue([Nullable(2)] IThreeStageSplineMoveMontage_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IThreeStageSplineMoveMontage
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BDD9 RID: 48601 RVA: 0x001B6DE6 File Offset: 0x001B4FE6
		public new IThreeStageSplineMoveMontage_SetValue ToSetValue()
		{
			return new IThreeStageSplineMoveMontage_SetValue
			{
				Type = this.Type,
				MontagePath = this.MontagePath
			};
		}

		// Token: 0x170039F6 RID: 14838
		// (get) Token: 0x0600BDDA RID: 48602 RVA: 0x001B6E05 File Offset: 0x001B5005
		// (set) Token: 0x0600BDDB RID: 48603 RVA: 0x001B6E30 File Offset: 0x001B5030
		public override ESplineMoveMontageType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESplineMoveMontageType.ThreeStageMontage;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170039F7 RID: 14839
		// (get) Token: 0x0600BDDC RID: 48604 RVA: 0x001B6E3E File Offset: 0x001B503E
		// (set) Token: 0x0600BDDD RID: 48605 RVA: 0x001B6E69 File Offset: 0x001B5069
		public virtual string MontagePath
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MontagePath;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.MontagePath;
			}
			set
			{
				this.GetOrCreatePoco().MontagePath = value;
			}
		}

		// Token: 0x040071F1 RID: 29169
		[Nullable(2)]
		protected new IThreeStageSplineMoveMontage FbInstance;

		// Token: 0x040071F2 RID: 29170
		[Nullable(2)]
		protected new IThreeStageSplineMoveMontage_SetValue PocoInterface;
	}
}
