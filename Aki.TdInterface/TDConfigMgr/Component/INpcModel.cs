using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005C7 RID: 1479
	public class INpcModel : IModelConfig
	{
		// Token: 0x06001E20 RID: 7712 RVA: 0x00055974 File Offset: 0x00053B74
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

		// Token: 0x06001E21 RID: 7713 RVA: 0x000559AC File Offset: 0x00053BAC
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

		// Token: 0x06001E22 RID: 7714 RVA: 0x000559BF File Offset: 0x00053BBF
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

		// Token: 0x06001E23 RID: 7715 RVA: 0x000559D4 File Offset: 0x00053BD4
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

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x06001E24 RID: 7716 RVA: 0x00055A52 File Offset: 0x00053C52
		// (set) Token: 0x06001E25 RID: 7717 RVA: 0x00055A7D File Offset: 0x00053C7D
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

		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x06001E26 RID: 7718 RVA: 0x00055A8B File Offset: 0x00053C8B
		// (set) Token: 0x06001E27 RID: 7719 RVA: 0x00055AB6 File Offset: 0x00053CB6
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

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x06001E28 RID: 7720 RVA: 0x00055AC4 File Offset: 0x00053CC4
		// (set) Token: 0x06001E29 RID: 7721 RVA: 0x00055AEB File Offset: 0x00053CEB
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

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x06001E2A RID: 7722 RVA: 0x00055AF9 File Offset: 0x00053CF9
		// (set) Token: 0x06001E2B RID: 7723 RVA: 0x00055B24 File Offset: 0x00053D24
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

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x06001E2C RID: 7724 RVA: 0x00055B32 File Offset: 0x00053D32
		// (set) Token: 0x06001E2D RID: 7725 RVA: 0x00055B59 File Offset: 0x00053D59
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<string> BattleSockets
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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
				0
			})]
			set
			{
				this.GetOrCreatePoco().BattleSockets = value;
			}
		}

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x06001E2E RID: 7726 RVA: 0x00055B67 File Offset: 0x00053D67
		// (set) Token: 0x06001E2F RID: 7727 RVA: 0x00055B8E File Offset: 0x00053D8E
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<string> NormalSockets
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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
				0
			})]
			set
			{
				this.GetOrCreatePoco().NormalSockets = value;
			}
		}

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x06001E30 RID: 7728 RVA: 0x00055B9C File Offset: 0x00053D9C
		// (set) Token: 0x06001E31 RID: 7729 RVA: 0x00055BD6 File Offset: 0x00053DD6
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

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x06001E32 RID: 7730 RVA: 0x00055BE4 File Offset: 0x00053DE4
		// (set) Token: 0x06001E33 RID: 7731 RVA: 0x00055C1E File Offset: 0x00053E1E
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

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x06001E34 RID: 7732 RVA: 0x00055C2C File Offset: 0x00053E2C
		// (set) Token: 0x06001E35 RID: 7733 RVA: 0x00055C66 File Offset: 0x00053E66
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

		// Token: 0x0400158D RID: 5517
		[Nullable(2)]
		protected new INpcModel FbInstance;

		// Token: 0x0400158E RID: 5518
		[Nullable(2)]
		protected new INpcModel_SetValue PocoInterface;
	}
}
