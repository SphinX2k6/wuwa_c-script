using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020DC RID: 8412
	public class ISplineMovePattern
	{
		// Token: 0x0600B292 RID: 45714 RVA: 0x00190F2C File Offset: 0x0018F12C
		private ISplineMovePattern_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISplineMovePattern 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISplineMovePattern_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISplineMovePattern_SetValue());
			}
			return result;
		}

		// Token: 0x0600B293 RID: 45715 RVA: 0x00190F64 File Offset: 0x0018F164
		public static ISplineMovePattern Create([Nullable(2)] ISplineMovePattern instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISplineMovePattern
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B294 RID: 45716 RVA: 0x00190F77 File Offset: 0x0018F177
		public static ISplineMovePattern CreateFromSetValue([Nullable(2)] ISplineMovePattern_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISplineMovePattern
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B295 RID: 45717 RVA: 0x00190F8C File Offset: 0x0018F18C
		public ISplineMovePattern_SetValue ToSetValue()
		{
			return new ISplineMovePattern_SetValue
			{
				Type = this.Type,
				MaxOffsetDistance = this.MaxOffsetDistance,
				IsOneWay = this.IsOneWay,
				LayerVerticalLimit = this.LayerVerticalLimit,
				DynamicGravity = this.DynamicGravity,
				GravitySwitchAngularVelocity = this.GravitySwitchAngularVelocity,
				AutoExitDistance = this.AutoExitDistance
			};
		}

		// Token: 0x1700360E RID: 13838
		// (get) Token: 0x0600B296 RID: 45718 RVA: 0x00190FF2 File Offset: 0x0018F1F2
		// (set) Token: 0x0600B297 RID: 45719 RVA: 0x0019101D File Offset: 0x0018F21D
		public virtual ESplineMovePattern Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESplineMovePattern.PathLine;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700360F RID: 13839
		// (get) Token: 0x0600B298 RID: 45720 RVA: 0x0019102C File Offset: 0x0018F22C
		// (set) Token: 0x0600B299 RID: 45721 RVA: 0x00191066 File Offset: 0x0018F266
		public virtual float? MaxOffsetDistance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxOffsetDistance;
				}
				ISplineMovePattern_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MaxOffsetDistance;
			}
			set
			{
				this.GetOrCreatePoco().MaxOffsetDistance = value;
			}
		}

		// Token: 0x17003610 RID: 13840
		// (get) Token: 0x0600B29A RID: 45722 RVA: 0x00191074 File Offset: 0x0018F274
		// (set) Token: 0x0600B29B RID: 45723 RVA: 0x001910AE File Offset: 0x0018F2AE
		public virtual bool? IsOneWay
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsOneWay;
				}
				ISplineMovePattern_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsOneWay;
			}
			set
			{
				this.GetOrCreatePoco().IsOneWay = value;
			}
		}

		// Token: 0x17003611 RID: 13841
		// (get) Token: 0x0600B29C RID: 45724 RVA: 0x001910BC File Offset: 0x0018F2BC
		// (set) Token: 0x0600B29D RID: 45725 RVA: 0x001910F6 File Offset: 0x0018F2F6
		public virtual float? LayerVerticalLimit
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LayerVerticalLimit;
				}
				ISplineMovePattern_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.LayerVerticalLimit;
			}
			set
			{
				this.GetOrCreatePoco().LayerVerticalLimit = value;
			}
		}

		// Token: 0x17003612 RID: 13842
		// (get) Token: 0x0600B29E RID: 45726 RVA: 0x00191104 File Offset: 0x0018F304
		// (set) Token: 0x0600B29F RID: 45727 RVA: 0x0019113E File Offset: 0x0018F33E
		public virtual bool? DynamicGravity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DynamicGravity;
				}
				ISplineMovePattern_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DynamicGravity;
			}
			set
			{
				this.GetOrCreatePoco().DynamicGravity = value;
			}
		}

		// Token: 0x17003613 RID: 13843
		// (get) Token: 0x0600B2A0 RID: 45728 RVA: 0x0019114C File Offset: 0x0018F34C
		// (set) Token: 0x0600B2A1 RID: 45729 RVA: 0x00191186 File Offset: 0x0018F386
		public virtual float? GravitySwitchAngularVelocity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GravitySwitchAngularVelocity;
				}
				ISplineMovePattern_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.GravitySwitchAngularVelocity;
			}
			set
			{
				this.GetOrCreatePoco().GravitySwitchAngularVelocity = value;
			}
		}

		// Token: 0x17003614 RID: 13844
		// (get) Token: 0x0600B2A2 RID: 45730 RVA: 0x00191194 File Offset: 0x0018F394
		// (set) Token: 0x0600B2A3 RID: 45731 RVA: 0x001911CE File Offset: 0x0018F3CE
		public virtual int? AutoExitDistance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AutoExitDistance;
				}
				ISplineMovePattern_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AutoExitDistance;
			}
			set
			{
				this.GetOrCreatePoco().AutoExitDistance = value;
			}
		}

		// Token: 0x040069F1 RID: 27121
		[Nullable(2)]
		protected ISplineMovePattern FbInstance;

		// Token: 0x040069F2 RID: 27122
		[Nullable(2)]
		protected ISplineMovePattern_SetValue PocoInterface;
	}
}
