using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B21 RID: 6945
	public class IDetectBattleTagType
	{
		// Token: 0x0600936B RID: 37739 RVA: 0x00158BF4 File Offset: 0x00156DF4
		private IDetectBattleTagType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDetectBattleTagType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDetectBattleTagType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDetectBattleTagType_SetValue());
			}
			return result;
		}

		// Token: 0x0600936C RID: 37740 RVA: 0x00158C2C File Offset: 0x00156E2C
		public static IDetectBattleTagType Create([Nullable(2)] IDetectBattleTagType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDetectBattleTagType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600936D RID: 37741 RVA: 0x00158C3F File Offset: 0x00156E3F
		public static IDetectBattleTagType CreateFromSetValue([Nullable(2)] IDetectBattleTagType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDetectBattleTagType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600936E RID: 37742 RVA: 0x00158C52 File Offset: 0x00156E52
		public IDetectBattleTagType_SetValue ToSetValue()
		{
			return new IDetectBattleTagType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002F10 RID: 12048
		// (get) Token: 0x0600936F RID: 37743 RVA: 0x00158C65 File Offset: 0x00156E65
		// (set) Token: 0x06009370 RID: 37744 RVA: 0x00158C90 File Offset: 0x00156E90
		public virtual EDetectBattleTagType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EDetectBattleTagType.MonsterOnTheGround;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005BA3 RID: 23459
		[Nullable(2)]
		protected IDetectBattleTagType FbInstance;

		// Token: 0x04005BA4 RID: 23460
		[Nullable(2)]
		protected IDetectBattleTagType_SetValue PocoInterface;
	}
}
