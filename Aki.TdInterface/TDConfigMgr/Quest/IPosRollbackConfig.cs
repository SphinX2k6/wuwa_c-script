using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200105B RID: 4187
	[NullableContext(1)]
	[Nullable(0)]
	public class IPosRollbackConfig
	{
		// Token: 0x06005DCE RID: 24014 RVA: 0x000E2FB8 File Offset: 0x000E11B8
		private IPosRollbackConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPosRollbackConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPosRollbackConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPosRollbackConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06005DCF RID: 24015 RVA: 0x000E2FF0 File Offset: 0x000E11F0
		public static IPosRollbackConfig Create([Nullable(2)] IPosRollbackConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPosRollbackConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005DD0 RID: 24016 RVA: 0x000E3003 File Offset: 0x000E1203
		public static IPosRollbackConfig CreateFromSetValue([Nullable(2)] IPosRollbackConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPosRollbackConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005DD1 RID: 24017 RVA: 0x000E3016 File Offset: 0x000E1216
		public IPosRollbackConfig_SetValue ToSetValue()
		{
			return new IPosRollbackConfig_SetValue
			{
				RangeEntityId = this.RangeEntityId,
				PositionEntityId = this.PositionEntityId,
				GravityFlip = this.GravityFlip
			};
		}

		// Token: 0x17001EE0 RID: 7904
		// (get) Token: 0x06005DD2 RID: 24018 RVA: 0x000E3044 File Offset: 0x000E1244
		// (set) Token: 0x06005DD3 RID: 24019 RVA: 0x000E307E File Offset: 0x000E127E
		public virtual int? RangeEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RangeEntityId;
				}
				IPosRollbackConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.RangeEntityId;
			}
			set
			{
				this.GetOrCreatePoco().RangeEntityId = value;
			}
		}

		// Token: 0x17001EE1 RID: 7905
		// (get) Token: 0x06005DD4 RID: 24020 RVA: 0x000E308C File Offset: 0x000E128C
		// (set) Token: 0x06005DD5 RID: 24021 RVA: 0x000E30B7 File Offset: 0x000E12B7
		public virtual int PositionEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PositionEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.PositionEntityId;
			}
			set
			{
				this.GetOrCreatePoco().PositionEntityId = value;
			}
		}

		// Token: 0x17001EE2 RID: 7906
		// (get) Token: 0x06005DD6 RID: 24022 RVA: 0x000E30C8 File Offset: 0x000E12C8
		// (set) Token: 0x06005DD7 RID: 24023 RVA: 0x000E3102 File Offset: 0x000E1302
		public virtual bool? GravityFlip
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GravityFlip;
				}
				IPosRollbackConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.GravityFlip;
			}
			set
			{
				this.GetOrCreatePoco().GravityFlip = value;
			}
		}

		// Token: 0x0400387B RID: 14459
		[Nullable(2)]
		protected IPosRollbackConfig FbInstance;

		// Token: 0x0400387C RID: 14460
		[Nullable(2)]
		protected IPosRollbackConfig_SetValue PocoInterface;
	}
}
