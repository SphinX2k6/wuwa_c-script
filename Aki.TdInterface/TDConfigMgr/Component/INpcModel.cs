using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000560 RID: 1376
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcModel : IModelConfig
	{
		// Token: 0x06001C24 RID: 7204 RVA: 0x00050BB8 File Offset: 0x0004EDB8
		private INpcModel_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcModel 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcModel_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcModel_SetValue());
			}
			return result;
		}

		// Token: 0x06001C25 RID: 7205 RVA: 0x00050BF0 File Offset: 0x0004EDF0
		public static INpcModel Create([Nullable(2)] INpcModel instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcModel
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001C26 RID: 7206 RVA: 0x00050C03 File Offset: 0x0004EE03
		public static INpcModel CreateFromSetValue([Nullable(2)] INpcModel_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcModel
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001C27 RID: 7207 RVA: 0x00050C18 File Offset: 0x0004EE18
		public new INpcModel_SetValue ToSetValue()
		{
			return new INpcModel_SetValue
			{
				Type = this.Type,
				BlueprintPath = this.BlueprintPath,
				NpcModel = this.NpcModel,
				Abp = this.Abp,
				BattleSockets = this.BattleSockets,
				NormalSockets = this.NormalSockets,
				LookingUpAngle = this.LookingUpAngle,
				BodyType = this.BodyType,
				NameZaxisOffset = this.NameZaxisOffset
			};
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x06001C28 RID: 7208 RVA: 0x00050C96 File Offset: 0x0004EE96
		// (set) Token: 0x06001C29 RID: 7209 RVA: 0x00050CC1 File Offset: 0x0004EEC1
		public override EModelType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EModelType.LevelPrefab;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x06001C2A RID: 7210 RVA: 0x00050CCF File Offset: 0x0004EECF
		// (set) Token: 0x06001C2B RID: 7211 RVA: 0x00050CFA File Offset: 0x0004EEFA
		public virtual string BlueprintPath
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BlueprintPath;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.BlueprintPath;
			}
			set
			{
				this.GetOrCreatePoco().BlueprintPath = value;
			}
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x06001C2C RID: 7212 RVA: 0x00050D08 File Offset: 0x0004EF08
		// (set) Token: 0x06001C2D RID: 7213 RVA: 0x00050D2F File Offset: 0x0004EF2F
		[Nullable(2)]
		public virtual INpcModelConfig NpcModel
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.NpcModel;
				}
				INpcModel_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.NpcModel;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().NpcModel = value;
			}
		}

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x06001C2E RID: 7214 RVA: 0x00050D3D File Offset: 0x0004EF3D
		// (set) Token: 0x06001C2F RID: 7215 RVA: 0x00050D68 File Offset: 0x0004EF68
		public virtual string Abp
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Abp;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Abp;
			}
			set
			{
				this.GetOrCreatePoco().Abp = value;
			}
		}

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x06001C30 RID: 7216 RVA: 0x00050D76 File Offset: 0x0004EF76
		// (set) Token: 0x06001C31 RID: 7217 RVA: 0x00050D9D File Offset: 0x0004EF9D
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<string> BattleSockets
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BattleSockets;
				}
				INpcModel_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.BattleSockets;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().BattleSockets = value;
			}
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x06001C32 RID: 7218 RVA: 0x00050DAB File Offset: 0x0004EFAB
		// (set) Token: 0x06001C33 RID: 7219 RVA: 0x00050DD2 File Offset: 0x0004EFD2
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<string> NormalSockets
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.NormalSockets;
				}
				INpcModel_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.NormalSockets;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().NormalSockets = value;
			}
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x06001C34 RID: 7220 RVA: 0x00050DE0 File Offset: 0x0004EFE0
		// (set) Token: 0x06001C35 RID: 7221 RVA: 0x00050E1A File Offset: 0x0004F01A
		public virtual float? LookingUpAngle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LookingUpAngle;
				}
				INpcModel_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.LookingUpAngle;
			}
			set
			{
				this.GetOrCreatePoco().LookingUpAngle = value;
			}
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x06001C36 RID: 7222 RVA: 0x00050E28 File Offset: 0x0004F028
		// (set) Token: 0x06001C37 RID: 7223 RVA: 0x00050E62 File Offset: 0x0004F062
		public virtual EBodyType? BodyType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BodyType;
				}
				INpcModel_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.BodyType;
			}
			set
			{
				this.GetOrCreatePoco().BodyType = value;
			}
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x06001C38 RID: 7224 RVA: 0x00050E70 File Offset: 0x0004F070
		// (set) Token: 0x06001C39 RID: 7225 RVA: 0x00050EAA File Offset: 0x0004F0AA
		public virtual float? NameZaxisOffset
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.NameZaxisOffset;
				}
				INpcModel_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.NameZaxisOffset;
			}
			set
			{
				this.GetOrCreatePoco().NameZaxisOffset = value;
			}
		}

		// Token: 0x04001423 RID: 5155
		[Nullable(2)]
		protected new INpcModel FbInstance;

		// Token: 0x04001424 RID: 5156
		[Nullable(2)]
		protected new INpcModel_SetValue PocoInterface;
	}
}
