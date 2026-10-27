using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200087F RID: 2175
	[NullableContext(1)]
	[Nullable(0)]
	public class RollBlockFloorComponent : IComponentBase
	{
		// Token: 0x06003057 RID: 12375 RVA: 0x0007C640 File Offset: 0x0007A840
		private RollBlockFloorComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("RollBlockFloorComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			RollBlockFloorComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new RollBlockFloorComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06003058 RID: 12376 RVA: 0x0007C678 File Offset: 0x0007A878
		public static RollBlockFloorComponent Create([Nullable(2)] RollBlockFloorComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RollBlockFloorComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06003059 RID: 12377 RVA: 0x0007C68B File Offset: 0x0007A88B
		public static RollBlockFloorComponent CreateFromSetValue([Nullable(2)] RollBlockFloorComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new RollBlockFloorComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600305A RID: 12378 RVA: 0x0007C69E File Offset: 0x0007A89E
		public new RollBlockFloorComponent_SetValue ToSetValue()
		{
			return new RollBlockFloorComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked
			};
		}

		// Token: 0x17000CD0 RID: 3280
		// (get) Token: 0x0600305B RID: 12379 RVA: 0x0007C6C0 File Offset: 0x0007A8C0
		// (set) Token: 0x0600305C RID: 12380 RVA: 0x0007C6FA File Offset: 0x0007A8FA
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				RollBlockFloorComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000CD1 RID: 3281
		// (get) Token: 0x0600305D RID: 12381 RVA: 0x0007C708 File Offset: 0x0007A908
		// (set) Token: 0x0600305E RID: 12382 RVA: 0x0007C732 File Offset: 0x0007A932
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

		// Token: 0x04001FCC RID: 8140
		[Nullable(2)]
		protected new RollBlockFloorComponent FbInstance;

		// Token: 0x04001FCD RID: 8141
		[Nullable(2)]
		protected new RollBlockFloorComponent_SetValue PocoInterface;
	}
}
