using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012EE RID: 4846
	public class ITrackEffectAutoChange : ITrackEffectType
	{
		// Token: 0x06006D2F RID: 27951 RVA: 0x00104344 File Offset: 0x00102544
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

		// Token: 0x06006D30 RID: 27952 RVA: 0x0010437C File Offset: 0x0010257C
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

		// Token: 0x06006D31 RID: 27953 RVA: 0x0010438F File Offset: 0x0010258F
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

		// Token: 0x06006D32 RID: 27954 RVA: 0x001043A2 File Offset: 0x001025A2
		public new ITrackEffectAutoChange_SetValue ToSetValue()
		{
			return new ITrackEffectAutoChange_SetValue
			{
				Type = this.Type,
				EnterRange = this.EnterRange,
				LeaveRange = this.LeaveRange
			};
		}

		// Token: 0x17002332 RID: 9010
		// (get) Token: 0x06006D33 RID: 27955 RVA: 0x001043CD File Offset: 0x001025CD
		// (set) Token: 0x06006D34 RID: 27956 RVA: 0x001043F8 File Offset: 0x001025F8
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

		// Token: 0x17002333 RID: 9011
		// (get) Token: 0x06006D35 RID: 27957 RVA: 0x00104406 File Offset: 0x00102606
		// (set) Token: 0x06006D36 RID: 27958 RVA: 0x00104431 File Offset: 0x00102631
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

		// Token: 0x17002334 RID: 9012
		// (get) Token: 0x06006D37 RID: 27959 RVA: 0x0010443F File Offset: 0x0010263F
		// (set) Token: 0x06006D38 RID: 27960 RVA: 0x0010446A File Offset: 0x0010266A
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

		// Token: 0x04004140 RID: 16704
		[Nullable(2)]
		protected new ITrackEffectAutoChange FbInstance;

		// Token: 0x04004141 RID: 16705
		[Nullable(2)]
		protected new ITrackEffectAutoChange_SetValue PocoInterface;
	}
}
