using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020A9 RID: 8361
	[NullableContext(1)]
	[Nullable(0)]
	public class IVisualNovelTransitionLocation : IVisualNovelTransitionConfigBase
	{
		// Token: 0x0600B7E4 RID: 47076 RVA: 0x001A9E70 File Offset: 0x001A8070
		private IVisualNovelTransitionLocation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelTransitionLocation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelTransitionLocation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelTransitionLocation_SetValue());
			}
			return result;
		}

		// Token: 0x0600B7E5 RID: 47077 RVA: 0x001A9EA8 File Offset: 0x001A80A8
		public static IVisualNovelTransitionLocation Create([Nullable(2)] IVisualNovelTransitionLocation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelTransitionLocation
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B7E6 RID: 47078 RVA: 0x001A9EBB File Offset: 0x001A80BB
		public static IVisualNovelTransitionLocation CreateFromSetValue([Nullable(2)] IVisualNovelTransitionLocation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelTransitionLocation
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B7E7 RID: 47079 RVA: 0x001A9ECE File Offset: 0x001A80CE
		public new IVisualNovelTransitionLocation_SetValue ToSetValue()
		{
			return new IVisualNovelTransitionLocation_SetValue
			{
				Type = this.Type,
				LocationId = this.LocationId,
				TransitionBackgroundId = this.TransitionBackgroundId
			};
		}

		// Token: 0x1700384D RID: 14413
		// (get) Token: 0x0600B7E8 RID: 47080 RVA: 0x001A9EF9 File Offset: 0x001A80F9
		// (set) Token: 0x0600B7E9 RID: 47081 RVA: 0x001A9F24 File Offset: 0x001A8124
		public override EVisualNovelTransitionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EVisualNovelTransitionType.Location;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700384E RID: 14414
		// (get) Token: 0x0600B7EA RID: 47082 RVA: 0x001A9F32 File Offset: 0x001A8132
		// (set) Token: 0x0600B7EB RID: 47083 RVA: 0x001A9F5D File Offset: 0x001A815D
		public virtual int LocationId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LocationId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.LocationId;
			}
			set
			{
				this.GetOrCreatePoco().LocationId = value;
			}
		}

		// Token: 0x1700384F RID: 14415
		// (get) Token: 0x0600B7EC RID: 47084 RVA: 0x001A9F6C File Offset: 0x001A816C
		// (set) Token: 0x0600B7ED RID: 47085 RVA: 0x001A9FA6 File Offset: 0x001A81A6
		public virtual int? TransitionBackgroundId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TransitionBackgroundId;
				}
				IVisualNovelTransitionLocation_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TransitionBackgroundId;
			}
			set
			{
				this.GetOrCreatePoco().TransitionBackgroundId = value;
			}
		}

		// Token: 0x04006E52 RID: 28242
		[Nullable(2)]
		protected new IVisualNovelTransitionLocation FbInstance;

		// Token: 0x04006E53 RID: 28243
		[Nullable(2)]
		protected new IVisualNovelTransitionLocation_SetValue PocoInterface;
	}
}
