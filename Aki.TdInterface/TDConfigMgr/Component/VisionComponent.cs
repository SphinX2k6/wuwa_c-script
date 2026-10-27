using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008DE RID: 2270
	[NullableContext(1)]
	[Nullable(0)]
	public class VisionComponent : IComponentBase
	{
		// Token: 0x06003371 RID: 13169 RVA: 0x00083CE0 File Offset: 0x00081EE0
		private VisionComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("VisionComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			VisionComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new VisionComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06003372 RID: 13170 RVA: 0x00083D18 File Offset: 0x00081F18
		public static VisionComponent Create([Nullable(2)] VisionComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new VisionComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06003373 RID: 13171 RVA: 0x00083D2B File Offset: 0x00081F2B
		public static VisionComponent CreateFromSetValue([Nullable(2)] VisionComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new VisionComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06003374 RID: 13172 RVA: 0x00083D3E File Offset: 0x00081F3E
		public new VisionComponent_SetValue ToSetValue()
		{
			return new VisionComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				VisionId = this.VisionId
			};
		}

		// Token: 0x17000DD3 RID: 3539
		// (get) Token: 0x06003375 RID: 13173 RVA: 0x00083D6C File Offset: 0x00081F6C
		// (set) Token: 0x06003376 RID: 13174 RVA: 0x00083DA6 File Offset: 0x00081FA6
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				VisionComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000DD4 RID: 3540
		// (get) Token: 0x06003377 RID: 13175 RVA: 0x00083DB4 File Offset: 0x00081FB4
		// (set) Token: 0x06003378 RID: 13176 RVA: 0x00083DDE File Offset: 0x00081FDE
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

		// Token: 0x17000DD5 RID: 3541
		// (get) Token: 0x06003379 RID: 13177 RVA: 0x00083DEC File Offset: 0x00081FEC
		// (set) Token: 0x0600337A RID: 13178 RVA: 0x00083E17 File Offset: 0x00082017
		public virtual int VisionId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.VisionId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.VisionId;
			}
			set
			{
				this.GetOrCreatePoco().VisionId = value;
			}
		}

		// Token: 0x040021BA RID: 8634
		[Nullable(2)]
		protected new VisionComponent FbInstance;

		// Token: 0x040021BB RID: 8635
		[Nullable(2)]
		protected new VisionComponent_SetValue PocoInterface;
	}
}
