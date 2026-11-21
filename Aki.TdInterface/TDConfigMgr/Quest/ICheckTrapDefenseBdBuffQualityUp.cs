using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001018 RID: 4120
	public class ICheckTrapDefenseBdBuffQualityUp : ICheckTrapDefenseEventBase
	{
		// Token: 0x06005A3C RID: 23100 RVA: 0x000DBFE4 File Offset: 0x000DA1E4
		private ICheckTrapDefenseBdBuffQualityUp_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICheckTrapDefenseBdBuffQualityUp 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICheckTrapDefenseBdBuffQualityUp_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICheckTrapDefenseBdBuffQualityUp_SetValue());
			}
			return result;
		}

		// Token: 0x06005A3D RID: 23101 RVA: 0x000DC01C File Offset: 0x000DA21C
		public static ICheckTrapDefenseBdBuffQualityUp Create([Nullable(2)] ICheckTrapDefenseBdBuffQualityUp instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICheckTrapDefenseBdBuffQualityUp
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005A3E RID: 23102 RVA: 0x000DC02F File Offset: 0x000DA22F
		public static ICheckTrapDefenseBdBuffQualityUp CreateFromSetValue([Nullable(2)] ICheckTrapDefenseBdBuffQualityUp_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICheckTrapDefenseBdBuffQualityUp
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005A3F RID: 23103 RVA: 0x000DC042 File Offset: 0x000DA242
		public new ICheckTrapDefenseBdBuffQualityUp_SetValue ToSetValue()
		{
			return new ICheckTrapDefenseBdBuffQualityUp_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001DF6 RID: 7670
		// (get) Token: 0x06005A40 RID: 23104 RVA: 0x000DC055 File Offset: 0x000DA255
		// (set) Token: 0x06005A41 RID: 23105 RVA: 0x000DC080 File Offset: 0x000DA280
		public override ECheckTrapDefenseEvent Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECheckTrapDefenseEvent.MonsterKilled;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400365C RID: 13916
		[Nullable(2)]
		protected new ICheckTrapDefenseBdBuffQualityUp FbInstance;

		// Token: 0x0400365D RID: 13917
		[Nullable(2)]
		protected new ICheckTrapDefenseBdBuffQualityUp_SetValue PocoInterface;
	}
}
