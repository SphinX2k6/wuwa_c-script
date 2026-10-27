using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BCA RID: 7114
	[NullableContext(2)]
	[Nullable(0)]
	public class IMechEscortPoint
	{
		// Token: 0x0600986B RID: 39019 RVA: 0x0015F574 File Offset: 0x0015D774
		[NullableContext(1)]
		private IMechEscortPoint_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMechEscortPoint 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMechEscortPoint_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMechEscortPoint_SetValue());
			}
			return result;
		}

		// Token: 0x0600986C RID: 39020 RVA: 0x0015F5AC File Offset: 0x0015D7AC
		[NullableContext(1)]
		public static IMechEscortPoint Create([Nullable(2)] IMechEscortPoint instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechEscortPoint
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600986D RID: 39021 RVA: 0x0015F5BF File Offset: 0x0015D7BF
		[NullableContext(1)]
		public static IMechEscortPoint CreateFromSetValue([Nullable(2)] IMechEscortPoint_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMechEscortPoint
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600986E RID: 39022 RVA: 0x0015F5D4 File Offset: 0x0015D7D4
		[NullableContext(1)]
		public IMechEscortPoint_SetValue ToSetValue()
		{
			return new IMechEscortPoint_SetValue
			{
				SplinePointIndex = this.SplinePointIndex,
				ForwardOffset = this.ForwardOffset,
				Radius = this.Radius,
				Angle = this.Angle,
				MovieCamera = this.MovieCamera
			};
		}

		// Token: 0x17002FDD RID: 12253
		// (get) Token: 0x0600986F RID: 39023 RVA: 0x0015F622 File Offset: 0x0015D822
		// (set) Token: 0x06009870 RID: 39024 RVA: 0x0015F64D File Offset: 0x0015D84D
		public virtual int SplinePointIndex
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SplinePointIndex;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.SplinePointIndex;
			}
			set
			{
				this.GetOrCreatePoco().SplinePointIndex = value;
			}
		}

		// Token: 0x17002FDE RID: 12254
		// (get) Token: 0x06009871 RID: 39025 RVA: 0x0015F65B File Offset: 0x0015D85B
		// (set) Token: 0x06009872 RID: 39026 RVA: 0x0015F68A File Offset: 0x0015D88A
		public virtual float ForwardOffset
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ForwardOffset;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.ForwardOffset;
			}
			set
			{
				this.GetOrCreatePoco().ForwardOffset = value;
			}
		}

		// Token: 0x17002FDF RID: 12255
		// (get) Token: 0x06009873 RID: 39027 RVA: 0x0015F698 File Offset: 0x0015D898
		// (set) Token: 0x06009874 RID: 39028 RVA: 0x0015F6C7 File Offset: 0x0015D8C7
		public virtual float Radius
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Radius;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Radius;
			}
			set
			{
				this.GetOrCreatePoco().Radius = value;
			}
		}

		// Token: 0x17002FE0 RID: 12256
		// (get) Token: 0x06009875 RID: 39029 RVA: 0x0015F6D5 File Offset: 0x0015D8D5
		// (set) Token: 0x06009876 RID: 39030 RVA: 0x0015F704 File Offset: 0x0015D904
		public virtual float Angle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Angle;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Angle;
			}
			set
			{
				this.GetOrCreatePoco().Angle = value;
			}
		}

		// Token: 0x17002FE1 RID: 12257
		// (get) Token: 0x06009877 RID: 39031 RVA: 0x0015F712 File Offset: 0x0015D912
		// (set) Token: 0x06009878 RID: 39032 RVA: 0x0015F739 File Offset: 0x0015D939
		public virtual IEnterMovieCameraType MovieCamera
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MovieCamera;
				}
				IMechEscortPoint_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MovieCamera;
			}
			set
			{
				this.GetOrCreatePoco().MovieCamera = value;
			}
		}

		// Token: 0x04005CF8 RID: 23800
		protected IMechEscortPoint FbInstance;

		// Token: 0x04005CF9 RID: 23801
		protected IMechEscortPoint_SetValue PocoInterface;
	}
}
