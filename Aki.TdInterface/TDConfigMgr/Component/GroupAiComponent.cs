using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200018D RID: 397
	[NullableContext(1)]
	[Nullable(0)]
	public class GroupAiComponent : IComponentBase
	{
		// Token: 0x060005A4 RID: 1444 RVA: 0x00020EB0 File Offset: 0x0001F0B0
		private GroupAiComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("GroupAiComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			GroupAiComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new GroupAiComponent_SetValue());
			}
			return result;
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x00020EE8 File Offset: 0x0001F0E8
		public static GroupAiComponent Create([Nullable(2)] GroupAiComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new GroupAiComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x00020EFB File Offset: 0x0001F0FB
		public static GroupAiComponent CreateFromSetValue([Nullable(2)] GroupAiComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new GroupAiComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x00020F10 File Offset: 0x0001F110
		public new GroupAiComponent_SetValue ToSetValue()
		{
			return new GroupAiComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				Entities = this.Entities,
				Option = this.Option,
				SyncTags = this.SyncTags
			};
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060005A8 RID: 1448 RVA: 0x00020F60 File Offset: 0x0001F160
		// (set) Token: 0x060005A9 RID: 1449 RVA: 0x00020F9A File Offset: 0x0001F19A
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				GroupAiComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060005AA RID: 1450 RVA: 0x00020FA8 File Offset: 0x0001F1A8
		// (set) Token: 0x060005AB RID: 1451 RVA: 0x00020FD2 File Offset: 0x0001F1D2
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060005AC RID: 1452 RVA: 0x00020FE0 File Offset: 0x0001F1E0
		// (set) Token: 0x060005AD RID: 1453 RVA: 0x00021007 File Offset: 0x0001F207
		public virtual List<int> Entities
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Entities;
				}
				GroupAiComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Entities;
			}
			set
			{
				this.GetOrCreatePoco().Entities = value;
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060005AE RID: 1454 RVA: 0x00021015 File Offset: 0x0001F215
		// (set) Token: 0x060005AF RID: 1455 RVA: 0x0002103C File Offset: 0x0001F23C
		public virtual IGroupAiMode Option
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Option;
				}
				GroupAiComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Option;
			}
			set
			{
				this.GetOrCreatePoco().Option = value;
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x060005B0 RID: 1456 RVA: 0x0002104A File Offset: 0x0001F24A
		// (set) Token: 0x060005B1 RID: 1457 RVA: 0x00021071 File Offset: 0x0001F271
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<string> SyncTags
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
					return this.FbInstance.SyncTags;
				}
				GroupAiComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SyncTags;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().SyncTags = value;
			}
		}

		// Token: 0x04000788 RID: 1928
		[Nullable(2)]
		protected new GroupAiComponent FbInstance;

		// Token: 0x04000789 RID: 1929
		[Nullable(2)]
		protected new GroupAiComponent_SetValue PocoInterface;
	}
}
