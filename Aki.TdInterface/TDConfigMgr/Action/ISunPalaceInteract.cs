using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EF1 RID: 7921
	[NullableContext(1)]
	[Nullable(0)]
	public class ISunPalaceInteract : ILeisureInteractType
	{
		// Token: 0x0600A96A RID: 43370 RVA: 0x0017DFFC File Offset: 0x0017C1FC
		private ISunPalaceInteract_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISunPalaceInteract 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISunPalaceInteract_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISunPalaceInteract_SetValue());
			}
			return result;
		}

		// Token: 0x0600A96B RID: 43371 RVA: 0x0017E034 File Offset: 0x0017C234
		public static ISunPalaceInteract Create([Nullable(2)] ISunPalaceInteract instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISunPalaceInteract
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A96C RID: 43372 RVA: 0x0017E047 File Offset: 0x0017C247
		public static ISunPalaceInteract CreateFromSetValue([Nullable(2)] ISunPalaceInteract_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISunPalaceInteract
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A96D RID: 43373 RVA: 0x0017E05A File Offset: 0x0017C25A
		public new ISunPalaceInteract_SetValue ToSetValue()
		{
			return new ISunPalaceInteract_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170033A3 RID: 13219
		// (get) Token: 0x0600A96E RID: 43374 RVA: 0x0017E06D File Offset: 0x0017C26D
		// (set) Token: 0x0600A96F RID: 43375 RVA: 0x0017E098 File Offset: 0x0017C298
		public override ELeisureInteract Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELeisureInteract.CustomSkill;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040064CA RID: 25802
		[Nullable(2)]
		protected new ISunPalaceInteract FbInstance;

		// Token: 0x040064CB RID: 25803
		[Nullable(2)]
		protected new ISunPalaceInteract_SetValue PocoInterface;
	}
}
