using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011B4 RID: 4532
	[NullableContext(1)]
	[Nullable(0)]
	public class ITrackEffectAutoChange : ITrackEffectType
	{
		// Token: 0x060066F6 RID: 26358 RVA: 0x000F6AF4 File Offset: 0x000F4CF4
		private ITrackEffectAutoChange_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITrackEffectAutoChange 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITrackEffectAutoChange_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITrackEffectAutoChange_SetValue());
			}
			return result;
		}

		// Token: 0x060066F7 RID: 26359 RVA: 0x000F6B2C File Offset: 0x000F4D2C
		public static ITrackEffectAutoChange Create([Nullable(2)] ITrackEffectAutoChange instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrackEffectAutoChange
			{
				FbInstance = instance
			};
		}

		// Token: 0x060066F8 RID: 26360 RVA: 0x000F6B3F File Offset: 0x000F4D3F
		public static ITrackEffectAutoChange CreateFromSetValue([Nullable(2)] ITrackEffectAutoChange_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITrackEffectAutoChange
			{
				PocoInterface = value
			};
		}

		// Token: 0x060066F9 RID: 26361 RVA: 0x000F6B52 File Offset: 0x000F4D52
		public new ITrackEffectAutoChange_SetValue ToSetValue()
		{
			return new ITrackEffectAutoChange_SetValue
			{
				Type = this.Type,
				EnterRange = this.EnterRange,
				LeaveRange = this.LeaveRange
			};
		}

		// Token: 0x17002172 RID: 8562
		// (get) Token: 0x060066FA RID: 26362 RVA: 0x000F6B7D File Offset: 0x000F4D7D
		// (set) Token: 0x060066FB RID: 26363 RVA: 0x000F6BA8 File Offset: 0x000F4DA8
		public override ETrackEffectType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETrackEffectType.AutoChange;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002173 RID: 8563
		// (get) Token: 0x060066FC RID: 26364 RVA: 0x000F6BB6 File Offset: 0x000F4DB6
		// (set) Token: 0x060066FD RID: 26365 RVA: 0x000F6BE1 File Offset: 0x000F4DE1
		public virtual int EnterRange
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EnterRange;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EnterRange;
			}
			set
			{
				this.GetOrCreatePoco().EnterRange = value;
			}
		}

		// Token: 0x17002174 RID: 8564
		// (get) Token: 0x060066FE RID: 26366 RVA: 0x000F6BEF File Offset: 0x000F4DEF
		// (set) Token: 0x060066FF RID: 26367 RVA: 0x000F6C1A File Offset: 0x000F4E1A
		public virtual int LeaveRange
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LeaveRange;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.LeaveRange;
			}
			set
			{
				this.GetOrCreatePoco().LeaveRange = value;
			}
		}

		// Token: 0x04003DD5 RID: 15829
		[Nullable(2)]
		protected new ITrackEffectAutoChange FbInstance;

		// Token: 0x04003DD6 RID: 15830
		[Nullable(2)]
		protected new ITrackEffectAutoChange_SetValue PocoInterface;
	}
}
