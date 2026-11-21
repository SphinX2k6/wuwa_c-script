using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B25 RID: 6949
	public class IDisableAlertAreaDungeonCondition : IDisableAlertAreaCondition
	{
		// Token: 0x0600937B RID: 37755 RVA: 0x00158D6C File Offset: 0x00156F6C
		private IDisableAlertAreaDungeonCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDisableAlertAreaDungeonCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDisableAlertAreaDungeonCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDisableAlertAreaDungeonCondition_SetValue());
			}
			return result;
		}

		// Token: 0x0600937C RID: 37756 RVA: 0x00158DA4 File Offset: 0x00156FA4
		public static IDisableAlertAreaDungeonCondition Create([Nullable(2)] IDisableAlertAreaDungeonCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDisableAlertAreaDungeonCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600937D RID: 37757 RVA: 0x00158DB7 File Offset: 0x00156FB7
		public static IDisableAlertAreaDungeonCondition CreateFromSetValue([Nullable(2)] IDisableAlertAreaDungeonCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDisableAlertAreaDungeonCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600937E RID: 37758 RVA: 0x00158DCA File Offset: 0x00156FCA
		public new IDisableAlertAreaDungeonCondition_SetValue ToSetValue()
		{
			return new IDisableAlertAreaDungeonCondition_SetValue
			{
				Type = this.Type,
				RelatedDungeonId = this.RelatedDungeonId
			};
		}

		// Token: 0x17002F12 RID: 12050
		// (get) Token: 0x0600937F RID: 37759 RVA: 0x00158DE9 File Offset: 0x00156FE9
		// (set) Token: 0x06009380 RID: 37760 RVA: 0x00158E14 File Offset: 0x00157014
		public override EDisableAlertAreaCondition Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EDisableAlertAreaCondition.DungeonCondition;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002F13 RID: 12051
		// (get) Token: 0x06009381 RID: 37761 RVA: 0x00158E22 File Offset: 0x00157022
		// (set) Token: 0x06009382 RID: 37762 RVA: 0x00158E4D File Offset: 0x0015704D
		public virtual int RelatedDungeonId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RelatedDungeonId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.RelatedDungeonId;
			}
			set
			{
				this.GetOrCreatePoco().RelatedDungeonId = value;
			}
		}

		// Token: 0x04005BA9 RID: 23465
		[Nullable(2)]
		protected new IDisableAlertAreaDungeonCondition FbInstance;

		// Token: 0x04005BAA RID: 23466
		[Nullable(2)]
		protected new IDisableAlertAreaDungeonCondition_SetValue PocoInterface;
	}
}
