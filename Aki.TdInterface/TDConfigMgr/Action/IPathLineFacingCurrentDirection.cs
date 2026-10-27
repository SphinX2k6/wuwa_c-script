using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CC2 RID: 7362
	[NullableContext(1)]
	[Nullable(0)]
	public class IPathLineFacingCurrentDirection : IPathLineFacingType
	{
		// Token: 0x06009E0B RID: 40459 RVA: 0x00169A40 File Offset: 0x00167C40
		private IPathLineFacingCurrentDirection_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPathLineFacingCurrentDirection 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPathLineFacingCurrentDirection_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPathLineFacingCurrentDirection_SetValue());
			}
			return result;
		}

		// Token: 0x06009E0C RID: 40460 RVA: 0x00169A78 File Offset: 0x00167C78
		public static IPathLineFacingCurrentDirection Create([Nullable(2)] IPathLineFacingCurrentDirection instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPathLineFacingCurrentDirection
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009E0D RID: 40461 RVA: 0x00169A8B File Offset: 0x00167C8B
		public static IPathLineFacingCurrentDirection CreateFromSetValue([Nullable(2)] IPathLineFacingCurrentDirection_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPathLineFacingCurrentDirection
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009E0E RID: 40462 RVA: 0x00169A9E File Offset: 0x00167C9E
		public new IPathLineFacingCurrentDirection_SetValue ToSetValue()
		{
			return new IPathLineFacingCurrentDirection_SetValue
			{
				Type = this.Type,
				YawOffset = this.YawOffset
			};
		}

		// Token: 0x17003139 RID: 12601
		// (get) Token: 0x06009E0F RID: 40463 RVA: 0x00169ABD File Offset: 0x00167CBD
		// (set) Token: 0x06009E10 RID: 40464 RVA: 0x00169AE8 File Offset: 0x00167CE8
		public override EPathLineFacingType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPathLineFacingType.Current;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700313A RID: 12602
		// (get) Token: 0x06009E11 RID: 40465 RVA: 0x00169AF8 File Offset: 0x00167CF8
		// (set) Token: 0x06009E12 RID: 40466 RVA: 0x00169B32 File Offset: 0x00167D32
		public virtual float? YawOffset
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.YawOffset;
				}
				IPathLineFacingCurrentDirection_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.YawOffset;
			}
			set
			{
				this.GetOrCreatePoco().YawOffset = value;
			}
		}

		// Token: 0x04005F94 RID: 24468
		[Nullable(2)]
		protected new IPathLineFacingCurrentDirection FbInstance;

		// Token: 0x04005F95 RID: 24469
		[Nullable(2)]
		protected new IPathLineFacingCurrentDirection_SetValue PocoInterface;
	}
}
