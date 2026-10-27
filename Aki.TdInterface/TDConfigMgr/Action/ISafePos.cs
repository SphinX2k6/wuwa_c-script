using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DD0 RID: 7632
	[NullableContext(1)]
	[Nullable(0)]
	public class ISafePos : ITeleportConfig
	{
		// Token: 0x0600A36D RID: 41837 RVA: 0x00173174 File Offset: 0x00171374
		private ISafePos_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISafePos 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISafePos_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISafePos_SetValue());
			}
			return result;
		}

		// Token: 0x0600A36E RID: 41838 RVA: 0x001731AC File Offset: 0x001713AC
		public static ISafePos Create([Nullable(2)] ISafePos instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISafePos
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A36F RID: 41839 RVA: 0x001731BF File Offset: 0x001713BF
		public static ISafePos CreateFromSetValue([Nullable(2)] ISafePos_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISafePos
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A370 RID: 41840 RVA: 0x001731D2 File Offset: 0x001713D2
		public new ISafePos_SetValue ToSetValue()
		{
			return new ISafePos_SetValue
			{
				Type = this.Type,
				FinalSafePosEntityId = this.FinalSafePosEntityId
			};
		}

		// Token: 0x17003255 RID: 12885
		// (get) Token: 0x0600A371 RID: 41841 RVA: 0x001731F1 File Offset: 0x001713F1
		// (set) Token: 0x0600A372 RID: 41842 RVA: 0x0017321C File Offset: 0x0017141C
		public override ETeleportType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETeleportType.FixedPos;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003256 RID: 12886
		// (get) Token: 0x0600A373 RID: 41843 RVA: 0x0017322C File Offset: 0x0017142C
		// (set) Token: 0x0600A374 RID: 41844 RVA: 0x00173266 File Offset: 0x00171466
		public virtual int? FinalSafePosEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FinalSafePosEntityId;
				}
				ISafePos_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FinalSafePosEntityId;
			}
			set
			{
				this.GetOrCreatePoco().FinalSafePosEntityId = value;
			}
		}

		// Token: 0x040061FC RID: 25084
		[Nullable(2)]
		protected new ISafePos FbInstance;

		// Token: 0x040061FD RID: 25085
		[Nullable(2)]
		protected new ISafePos_SetValue PocoInterface;
	}
}
