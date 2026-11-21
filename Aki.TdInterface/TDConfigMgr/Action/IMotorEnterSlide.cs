using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E09 RID: 7689
	public class IMotorEnterSlide : ILeisureInteractType
	{
		// Token: 0x0600A38F RID: 41871 RVA: 0x0017615C File Offset: 0x0017435C
		private IMotorEnterSlide_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMotorEnterSlide 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMotorEnterSlide_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMotorEnterSlide_SetValue());
			}
			return result;
		}

		// Token: 0x0600A390 RID: 41872 RVA: 0x00176194 File Offset: 0x00174394
		public static IMotorEnterSlide Create([Nullable(2)] IMotorEnterSlide instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorEnterSlide
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A391 RID: 41873 RVA: 0x001761A7 File Offset: 0x001743A7
		public static IMotorEnterSlide CreateFromSetValue([Nullable(2)] IMotorEnterSlide_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMotorEnterSlide
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A392 RID: 41874 RVA: 0x001761BA File Offset: 0x001743BA
		public new IMotorEnterSlide_SetValue ToSetValue()
		{
			return new IMotorEnterSlide_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId,
				EnterMode = this.EnterMode
			};
		}

		// Token: 0x170032C8 RID: 13000
		// (get) Token: 0x0600A393 RID: 41875 RVA: 0x001761E5 File Offset: 0x001743E5
		// (set) Token: 0x0600A394 RID: 41876 RVA: 0x00176210 File Offset: 0x00174410
		public override ELeisureInteract Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELeisureInteract.CustomSkill;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170032C9 RID: 13001
		// (get) Token: 0x0600A395 RID: 41877 RVA: 0x0017621E File Offset: 0x0017441E
		// (set) Token: 0x0600A396 RID: 41878 RVA: 0x00176249 File Offset: 0x00174449
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x170032CA RID: 13002
		// (get) Token: 0x0600A397 RID: 41879 RVA: 0x00176258 File Offset: 0x00174458
		// (set) Token: 0x0600A398 RID: 41880 RVA: 0x00176292 File Offset: 0x00174492
		public virtual EMotorEnterSlideMode? EnterMode
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EnterMode;
				}
				IMotorEnterSlide_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EnterMode;
			}
			set
			{
				this.GetOrCreatePoco().EnterMode = value;
			}
		}

		// Token: 0x04006311 RID: 25361
		[Nullable(2)]
		protected new IMotorEnterSlide FbInstance;

		// Token: 0x04006312 RID: 25362
		[Nullable(2)]
		protected new IMotorEnterSlide_SetValue PocoInterface;
	}
}
