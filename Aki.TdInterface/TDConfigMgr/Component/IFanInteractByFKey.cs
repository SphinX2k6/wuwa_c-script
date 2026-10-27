using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000374 RID: 884
	[NullableContext(1)]
	[Nullable(0)]
	public class IFanInteractByFKey : IFanInteractType
	{
		// Token: 0x0600118F RID: 4495 RVA: 0x0003B288 File Offset: 0x00039488
		private IFanInteractByFKey_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFanInteractByFKey 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFanInteractByFKey_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFanInteractByFKey_SetValue());
			}
			return result;
		}

		// Token: 0x06001190 RID: 4496 RVA: 0x0003B2C0 File Offset: 0x000394C0
		public static IFanInteractByFKey Create([Nullable(2)] IFanInteractByFKey instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFanInteractByFKey
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001191 RID: 4497 RVA: 0x0003B2D3 File Offset: 0x000394D3
		public static IFanInteractByFKey CreateFromSetValue([Nullable(2)] IFanInteractByFKey_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFanInteractByFKey
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001192 RID: 4498 RVA: 0x0003B2E6 File Offset: 0x000394E6
		public new IFanInteractByFKey_SetValue ToSetValue()
		{
			return new IFanInteractByFKey_SetValue
			{
				Type = this.Type,
				TidInteractOptionText = this.TidInteractOptionText,
				EdTidInteractOptionText = this.EdTidInteractOptionText
			};
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06001193 RID: 4499 RVA: 0x0003B311 File Offset: 0x00039511
		// (set) Token: 0x06001194 RID: 4500 RVA: 0x0003B33C File Offset: 0x0003953C
		public override EFanInteractType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EFanInteractType.Hit;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06001195 RID: 4501 RVA: 0x0003B34A File Offset: 0x0003954A
		// (set) Token: 0x06001196 RID: 4502 RVA: 0x0003B375 File Offset: 0x00039575
		public virtual string TidInteractOptionText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidInteractOptionText;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TidInteractOptionText;
			}
			set
			{
				this.GetOrCreatePoco().TidInteractOptionText = value;
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06001197 RID: 4503 RVA: 0x0003B383 File Offset: 0x00039583
		// (set) Token: 0x06001198 RID: 4504 RVA: 0x0003B39A File Offset: 0x0003959A
		[Nullable(2)]
		public virtual string EdTidInteractOptionText
		{
			[NullableContext(2)]
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidInteractOptionText;
				}
				return null;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EdTidInteractOptionText = value;
			}
		}

		// Token: 0x04000E64 RID: 3684
		[Nullable(2)]
		protected new IFanInteractByFKey FbInstance;

		// Token: 0x04000E65 RID: 3685
		[Nullable(2)]
		protected new IFanInteractByFKey_SetValue PocoInterface;
	}
}
