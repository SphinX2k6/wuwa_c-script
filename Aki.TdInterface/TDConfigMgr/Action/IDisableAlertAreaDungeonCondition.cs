using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200199E RID: 6558
	[NullableContext(1)]
	[Nullable(0)]
	public class IDisableAlertAreaDungeonCondition : IDisableAlertAreaCondition
	{
		// Token: 0x06008C57 RID: 35927 RVA: 0x0014955C File Offset: 0x0014775C
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

		// Token: 0x06008C58 RID: 35928 RVA: 0x00149594 File Offset: 0x00147794
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

		// Token: 0x06008C59 RID: 35929 RVA: 0x001495A7 File Offset: 0x001477A7
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

		// Token: 0x06008C5A RID: 35930 RVA: 0x001495BA File Offset: 0x001477BA
		public new IDisableAlertAreaDungeonCondition_SetValue ToSetValue()
		{
			return new IDisableAlertAreaDungeonCondition_SetValue
			{
				Type = this.Type,
				RelatedDungeonId = this.RelatedDungeonId
			};
		}

		// Token: 0x17002D13 RID: 11539
		// (get) Token: 0x06008C5B RID: 35931 RVA: 0x001495D9 File Offset: 0x001477D9
		// (set) Token: 0x06008C5C RID: 35932 RVA: 0x00149604 File Offset: 0x00147804
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

		// Token: 0x17002D14 RID: 11540
		// (get) Token: 0x06008C5D RID: 35933 RVA: 0x00149612 File Offset: 0x00147812
		// (set) Token: 0x06008C5E RID: 35934 RVA: 0x0014963D File Offset: 0x0014783D
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

		// Token: 0x04005760 RID: 22368
		[Nullable(2)]
		protected new IDisableAlertAreaDungeonCondition FbInstance;

		// Token: 0x04005761 RID: 22369
		[Nullable(2)]
		protected new IDisableAlertAreaDungeonCondition_SetValue PocoInterface;
	}
}
