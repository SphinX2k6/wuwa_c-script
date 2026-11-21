using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021DB RID: 8667
	public class ITeleportDungeonFunction : EnableFunction
	{
		// Token: 0x0600BCDE RID: 48350 RVA: 0x001B4F9C File Offset: 0x001B319C
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

		// Token: 0x0600BCDF RID: 48351 RVA: 0x001B4FD4 File Offset: 0x001B31D4
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

		// Token: 0x0600BCE0 RID: 48352 RVA: 0x001B4FE7 File Offset: 0x001B31E7
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

		// Token: 0x0600BCE1 RID: 48353 RVA: 0x001B4FFA File Offset: 0x001B31FA
		public new ITeleportDungeonFunction_SetValue ToSetValue()
		{
			return new ITeleportDungeonFunction_SetValue
			{
				Type = this.Type,
				Enable = this.Enable,
				DungeonList = this.DungeonList
			};
		}

		// Token: 0x170039B6 RID: 14774
		// (get) Token: 0x0600BCE2 RID: 48354 RVA: 0x001B5025 File Offset: 0x001B3225
		// (set) Token: 0x0600BCE3 RID: 48355 RVA: 0x001B5050 File Offset: 0x001B3250
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

		// Token: 0x170039B7 RID: 14775
		// (get) Token: 0x0600BCE4 RID: 48356 RVA: 0x001B505E File Offset: 0x001B325E
		// (set) Token: 0x0600BCE5 RID: 48357 RVA: 0x001B5089 File Offset: 0x001B3289
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

		// Token: 0x170039B8 RID: 14776
		// (get) Token: 0x0600BCE6 RID: 48358 RVA: 0x001B5097 File Offset: 0x001B3297
		// (set) Token: 0x0600BCE7 RID: 48359 RVA: 0x001B50BE File Offset: 0x001B32BE
		[Nullable(2)]
		public virtual List<int> DungeonList
		{
			[NullableContext(2)]
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
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().DungeonList = value;
			}
		}

		// Token: 0x04007173 RID: 29043
		[Nullable(2)]
		protected new ITeleportDungeonFunction FbInstance;

		// Token: 0x04007174 RID: 29044
		[Nullable(2)]
		protected new ITeleportDungeonFunction_SetValue PocoInterface;
	}
}
