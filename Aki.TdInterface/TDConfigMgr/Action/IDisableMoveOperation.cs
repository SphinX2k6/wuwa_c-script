using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B3B RID: 6971
	[JsonConverter(typeof(IDisableMoveOperationConverter))]
	public class IDisableMoveOperation : IMoveOperationType
	{
		// Token: 0x0600940B RID: 37899 RVA: 0x00159E54 File Offset: 0x00158054
		private IDisableMoveOperation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDisableMoveOperation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDisableMoveOperation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDisableMoveOperation_SetValue());
			}
			return result;
		}

		// Token: 0x0600940C RID: 37900 RVA: 0x00159E8C File Offset: 0x0015808C
		public static IDisableMoveOperation Create([Nullable(2)] IDisableMoveOperation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDisableMoveOperation
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600940D RID: 37901 RVA: 0x00159E9F File Offset: 0x0015809F
		public static IDisableMoveOperation CreateFromSetValue([Nullable(2)] IDisableMoveOperation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDisableMoveOperation
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600940E RID: 37902 RVA: 0x00159EB4 File Offset: 0x001580B4
		public new IDisableMoveOperation_SetValue ToSetValue()
		{
			return new IDisableMoveOperation_SetValue
			{
				Type = this.Type,
				Forward = this.Forward,
				Back = this.Back,
				Left = this.Left,
				Right = this.Right,
				ForceWalk = this.ForceWalk,
				ForceJog = this.ForceJog,
				ForbidSprint = this.ForbidSprint,
				ForbidAndDisableSprint = this.ForbidAndDisableSprint,
				ForbidAndDisableMotorcycleSprint = this.ForbidAndDisableMotorcycleSprint,
				DisableClimbAndStep = this.DisableClimbAndStep
			};
		}

		// Token: 0x17002F39 RID: 12089
		// (get) Token: 0x0600940F RID: 37903 RVA: 0x00159F4A File Offset: 0x0015814A
		// (set) Token: 0x06009410 RID: 37904 RVA: 0x00159F75 File Offset: 0x00158175
		public override EMoveOperationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMoveOperationType.Enable;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002F3A RID: 12090
		// (get) Token: 0x06009411 RID: 37905 RVA: 0x00159F83 File Offset: 0x00158183
		// (set) Token: 0x06009412 RID: 37906 RVA: 0x00159FAE File Offset: 0x001581AE
		public virtual bool Forward
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Forward;
				}
				return this.PocoInterface != null && this.PocoInterface.Forward;
			}
			set
			{
				this.GetOrCreatePoco().Forward = value;
			}
		}

		// Token: 0x17002F3B RID: 12091
		// (get) Token: 0x06009413 RID: 37907 RVA: 0x00159FBC File Offset: 0x001581BC
		// (set) Token: 0x06009414 RID: 37908 RVA: 0x00159FE7 File Offset: 0x001581E7
		public virtual bool Back
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Back;
				}
				return this.PocoInterface != null && this.PocoInterface.Back;
			}
			set
			{
				this.GetOrCreatePoco().Back = value;
			}
		}

		// Token: 0x17002F3C RID: 12092
		// (get) Token: 0x06009415 RID: 37909 RVA: 0x00159FF5 File Offset: 0x001581F5
		// (set) Token: 0x06009416 RID: 37910 RVA: 0x0015A020 File Offset: 0x00158220
		public virtual bool Left
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Left;
				}
				return this.PocoInterface != null && this.PocoInterface.Left;
			}
			set
			{
				this.GetOrCreatePoco().Left = value;
			}
		}

		// Token: 0x17002F3D RID: 12093
		// (get) Token: 0x06009417 RID: 37911 RVA: 0x0015A02E File Offset: 0x0015822E
		// (set) Token: 0x06009418 RID: 37912 RVA: 0x0015A059 File Offset: 0x00158259
		public virtual bool Right
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Right;
				}
				return this.PocoInterface != null && this.PocoInterface.Right;
			}
			set
			{
				this.GetOrCreatePoco().Right = value;
			}
		}

		// Token: 0x17002F3E RID: 12094
		// (get) Token: 0x06009419 RID: 37913 RVA: 0x0015A068 File Offset: 0x00158268
		// (set) Token: 0x0600941A RID: 37914 RVA: 0x0015A0A2 File Offset: 0x001582A2
		public virtual bool? ForceWalk
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ForceWalk;
				}
				IDisableMoveOperation_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ForceWalk;
			}
			set
			{
				this.GetOrCreatePoco().ForceWalk = value;
			}
		}

		// Token: 0x17002F3F RID: 12095
		// (get) Token: 0x0600941B RID: 37915 RVA: 0x0015A0B0 File Offset: 0x001582B0
		// (set) Token: 0x0600941C RID: 37916 RVA: 0x0015A0EA File Offset: 0x001582EA
		public virtual bool? ForceJog
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ForceJog;
				}
				IDisableMoveOperation_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ForceJog;
			}
			set
			{
				this.GetOrCreatePoco().ForceJog = value;
			}
		}

		// Token: 0x17002F40 RID: 12096
		// (get) Token: 0x0600941D RID: 37917 RVA: 0x0015A0F8 File Offset: 0x001582F8
		// (set) Token: 0x0600941E RID: 37918 RVA: 0x0015A132 File Offset: 0x00158332
		public virtual bool? ForbidSprint
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ForbidSprint;
				}
				IDisableMoveOperation_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ForbidSprint;
			}
			set
			{
				this.GetOrCreatePoco().ForbidSprint = value;
			}
		}

		// Token: 0x17002F41 RID: 12097
		// (get) Token: 0x0600941F RID: 37919 RVA: 0x0015A140 File Offset: 0x00158340
		// (set) Token: 0x06009420 RID: 37920 RVA: 0x0015A17A File Offset: 0x0015837A
		public virtual bool? ForbidAndDisableSprint
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ForbidAndDisableSprint;
				}
				IDisableMoveOperation_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ForbidAndDisableSprint;
			}
			set
			{
				this.GetOrCreatePoco().ForbidAndDisableSprint = value;
			}
		}

		// Token: 0x17002F42 RID: 12098
		// (get) Token: 0x06009421 RID: 37921 RVA: 0x0015A188 File Offset: 0x00158388
		// (set) Token: 0x06009422 RID: 37922 RVA: 0x0015A1C2 File Offset: 0x001583C2
		public virtual bool? ForbidAndDisableMotorcycleSprint
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ForbidAndDisableMotorcycleSprint;
				}
				IDisableMoveOperation_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ForbidAndDisableMotorcycleSprint;
			}
			set
			{
				this.GetOrCreatePoco().ForbidAndDisableMotorcycleSprint = value;
			}
		}

		// Token: 0x17002F43 RID: 12099
		// (get) Token: 0x06009423 RID: 37923 RVA: 0x0015A1D0 File Offset: 0x001583D0
		// (set) Token: 0x06009424 RID: 37924 RVA: 0x0015A20A File Offset: 0x0015840A
		public virtual bool? DisableClimbAndStep
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DisableClimbAndStep;
				}
				IDisableMoveOperation_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DisableClimbAndStep;
			}
			set
			{
				this.GetOrCreatePoco().DisableClimbAndStep = value;
			}
		}

		// Token: 0x04005BE8 RID: 23528
		[Nullable(2)]
		protected new IDisableMoveOperation FbInstance;

		// Token: 0x04005BE9 RID: 23529
		[Nullable(2)]
		protected new IDisableMoveOperation_SetValue PocoInterface;
	}
}
