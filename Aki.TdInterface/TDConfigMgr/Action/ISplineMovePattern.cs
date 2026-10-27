using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EA3 RID: 7843
	[NullableContext(1)]
	[Nullable(0)]
	public class ISplineMovePattern
	{
		// Token: 0x0600A7C2 RID: 42946 RVA: 0x0017AF8C File Offset: 0x0017918C
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

		// Token: 0x0600A7C3 RID: 42947 RVA: 0x0017AFC4 File Offset: 0x001791C4
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

		// Token: 0x0600A7C4 RID: 42948 RVA: 0x0017AFD7 File Offset: 0x001791D7
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

		// Token: 0x0600A7C5 RID: 42949 RVA: 0x0017AFEC File Offset: 0x001791EC
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

		// Token: 0x17003344 RID: 13124
		// (get) Token: 0x0600A7C6 RID: 42950 RVA: 0x0017B052 File Offset: 0x00179252
		// (set) Token: 0x0600A7C7 RID: 42951 RVA: 0x0017B07D File Offset: 0x0017927D
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

		// Token: 0x17003345 RID: 13125
		// (get) Token: 0x0600A7C8 RID: 42952 RVA: 0x0017B08C File Offset: 0x0017928C
		// (set) Token: 0x0600A7C9 RID: 42953 RVA: 0x0017B0C6 File Offset: 0x001792C6
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

		// Token: 0x17003346 RID: 13126
		// (get) Token: 0x0600A7CA RID: 42954 RVA: 0x0017B0D4 File Offset: 0x001792D4
		// (set) Token: 0x0600A7CB RID: 42955 RVA: 0x0017B10E File Offset: 0x0017930E
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

		// Token: 0x17003347 RID: 13127
		// (get) Token: 0x0600A7CC RID: 42956 RVA: 0x0017B11C File Offset: 0x0017931C
		// (set) Token: 0x0600A7CD RID: 42957 RVA: 0x0017B156 File Offset: 0x00179356
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

		// Token: 0x17003348 RID: 13128
		// (get) Token: 0x0600A7CE RID: 42958 RVA: 0x0017B164 File Offset: 0x00179364
		// (set) Token: 0x0600A7CF RID: 42959 RVA: 0x0017B19E File Offset: 0x0017939E
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

		// Token: 0x17003349 RID: 13129
		// (get) Token: 0x0600A7D0 RID: 42960 RVA: 0x0017B1AC File Offset: 0x001793AC
		// (set) Token: 0x0600A7D1 RID: 42961 RVA: 0x0017B1E6 File Offset: 0x001793E6
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

		// Token: 0x1700334A RID: 13130
		// (get) Token: 0x0600A7D2 RID: 42962 RVA: 0x0017B1F4 File Offset: 0x001793F4
		// (set) Token: 0x0600A7D3 RID: 42963 RVA: 0x0017B22E File Offset: 0x0017942E
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

		// Token: 0x04006403 RID: 25603
		[Nullable(2)]
		protected ISplineMovePattern FbInstance;

		// Token: 0x04006404 RID: 25604
		[Nullable(2)]
		protected ISplineMovePattern_SetValue PocoInterface;
	}
}
