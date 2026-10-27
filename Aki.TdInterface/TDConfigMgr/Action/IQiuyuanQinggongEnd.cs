using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D6C RID: 7532
	[NullableContext(1)]
	[Nullable(0)]
	public class IQiuyuanQinggongEnd : ILeisureInteractType
	{
		// Token: 0x0600A181 RID: 41345 RVA: 0x0016FD90 File Offset: 0x0016DF90
		private IQiuyuanQinggongEnd_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IQiuyuanQinggongEnd 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IQiuyuanQinggongEnd_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IQiuyuanQinggongEnd_SetValue());
			}
			return result;
		}

		// Token: 0x0600A182 RID: 41346 RVA: 0x0016FDC8 File Offset: 0x0016DFC8
		public static IQiuyuanQinggongEnd Create([Nullable(2)] IQiuyuanQinggongEnd instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQiuyuanQinggongEnd
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A183 RID: 41347 RVA: 0x0016FDDB File Offset: 0x0016DFDB
		public static IQiuyuanQinggongEnd CreateFromSetValue([Nullable(2)] IQiuyuanQinggongEnd_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IQiuyuanQinggongEnd
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A184 RID: 41348 RVA: 0x0016FDEE File Offset: 0x0016DFEE
		public new IQiuyuanQinggongEnd_SetValue ToSetValue()
		{
			return new IQiuyuanQinggongEnd_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170031F5 RID: 12789
		// (get) Token: 0x0600A185 RID: 41349 RVA: 0x0016FE01 File Offset: 0x0016E001
		// (set) Token: 0x0600A186 RID: 41350 RVA: 0x0016FE2C File Offset: 0x0016E02C
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

		// Token: 0x0400612A RID: 24874
		[Nullable(2)]
		protected new IQiuyuanQinggongEnd FbInstance;

		// Token: 0x0400612B RID: 24875
		[Nullable(2)]
		protected new IQiuyuanQinggongEnd_SetValue PocoInterface;
	}
}
