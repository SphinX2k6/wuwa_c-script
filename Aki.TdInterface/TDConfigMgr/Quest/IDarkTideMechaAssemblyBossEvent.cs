using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001058 RID: 4184
	public class IDarkTideMechaAssemblyBossEvent : IDarkTideBossEvent
	{
		// Token: 0x06005C34 RID: 23604 RVA: 0x000E067C File Offset: 0x000DE87C
		private IDarkTideMechaAssemblyBossEvent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDarkTideMechaAssemblyBossEvent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDarkTideMechaAssemblyBossEvent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDarkTideMechaAssemblyBossEvent_SetValue());
			}
			return result;
		}

		// Token: 0x06005C35 RID: 23605 RVA: 0x000E06B4 File Offset: 0x000DE8B4
		public static IDarkTideMechaAssemblyBossEvent Create([Nullable(2)] IDarkTideMechaAssemblyBossEvent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDarkTideMechaAssemblyBossEvent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005C36 RID: 23606 RVA: 0x000E06C7 File Offset: 0x000DE8C7
		public static IDarkTideMechaAssemblyBossEvent CreateFromSetValue([Nullable(2)] IDarkTideMechaAssemblyBossEvent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDarkTideMechaAssemblyBossEvent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005C37 RID: 23607 RVA: 0x000E06DA File Offset: 0x000DE8DA
		public new IDarkTideMechaAssemblyBossEvent_SetValue ToSetValue()
		{
			return new IDarkTideMechaAssemblyBossEvent_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001E92 RID: 7826
		// (get) Token: 0x06005C38 RID: 23608 RVA: 0x000E06ED File Offset: 0x000DE8ED
		// (set) Token: 0x06005C39 RID: 23609 RVA: 0x000E0718 File Offset: 0x000DE918
		public override EDarkTideBossEventType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EDarkTideBossEventType.XinjilemuChase;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003792 RID: 14226
		[Nullable(2)]
		protected new IDarkTideMechaAssemblyBossEvent FbInstance;

		// Token: 0x04003793 RID: 14227
		[Nullable(2)]
		protected new IDarkTideMechaAssemblyBossEvent_SetValue PocoInterface;
	}
}
