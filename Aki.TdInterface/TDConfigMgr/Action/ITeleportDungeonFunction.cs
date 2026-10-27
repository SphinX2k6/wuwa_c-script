using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F98 RID: 8088
	[NullableContext(2)]
	[Nullable(0)]
	public class ITeleportDungeonFunction : EnableFunction
	{
		// Token: 0x0600B1DA RID: 45530 RVA: 0x0019EBEC File Offset: 0x0019CDEC
		[NullableContext(1)]
		private ITeleportDungeonFunction_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITeleportDungeonFunction 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITeleportDungeonFunction_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITeleportDungeonFunction_SetValue());
			}
			return result;
		}

		// Token: 0x0600B1DB RID: 45531 RVA: 0x0019EC24 File Offset: 0x0019CE24
		[NullableContext(1)]
		public static ITeleportDungeonFunction Create([Nullable(2)] ITeleportDungeonFunction instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleportDungeonFunction
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B1DC RID: 45532 RVA: 0x0019EC37 File Offset: 0x0019CE37
		[NullableContext(1)]
		public static ITeleportDungeonFunction CreateFromSetValue([Nullable(2)] ITeleportDungeonFunction_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITeleportDungeonFunction
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B1DD RID: 45533 RVA: 0x0019EC4A File Offset: 0x0019CE4A
		[NullableContext(1)]
		public new ITeleportDungeonFunction_SetValue ToSetValue()
		{
			return new ITeleportDungeonFunction_SetValue
			{
				Type = this.Type,
				Enable = this.Enable,
				DungeonList = this.DungeonList
			};
		}

		// Token: 0x170036E1 RID: 14049
		// (get) Token: 0x0600B1DE RID: 45534 RVA: 0x0019EC75 File Offset: 0x0019CE75
		// (set) Token: 0x0600B1DF RID: 45535 RVA: 0x0019ECA0 File Offset: 0x0019CEA0
		public override EEnableFunctionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EEnableFunctionType.TeleportDungeon;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170036E2 RID: 14050
		// (get) Token: 0x0600B1E0 RID: 45536 RVA: 0x0019ECAE File Offset: 0x0019CEAE
		// (set) Token: 0x0600B1E1 RID: 45537 RVA: 0x0019ECD9 File Offset: 0x0019CED9
		public virtual bool Enable
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Enable;
				}
				return this.PocoInterface != null && this.PocoInterface.Enable;
			}
			set
			{
				this.GetOrCreatePoco().Enable = value;
			}
		}

		// Token: 0x170036E3 RID: 14051
		// (get) Token: 0x0600B1E2 RID: 45538 RVA: 0x0019ECE7 File Offset: 0x0019CEE7
		// (set) Token: 0x0600B1E3 RID: 45539 RVA: 0x0019ED0E File Offset: 0x0019CF0E
		public virtual List<int> DungeonList
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DungeonList;
				}
				ITeleportDungeonFunction_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DungeonList;
			}
			set
			{
				this.GetOrCreatePoco().DungeonList = value;
			}
		}

		// Token: 0x04006B78 RID: 27512
		protected new ITeleportDungeonFunction FbInstance;

		// Token: 0x04006B79 RID: 27513
		protected new ITeleportDungeonFunction_SetValue PocoInterface;
	}
}
