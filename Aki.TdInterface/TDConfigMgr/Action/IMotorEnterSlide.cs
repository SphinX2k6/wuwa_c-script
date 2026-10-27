using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C1A RID: 7194
	[NullableContext(1)]
	[Nullable(0)]
	public class IMotorEnterSlide : ILeisureInteractType
	{
		// Token: 0x06009A5F RID: 39519 RVA: 0x00163210 File Offset: 0x00161410
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

		// Token: 0x06009A60 RID: 39520 RVA: 0x00163248 File Offset: 0x00161448
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

		// Token: 0x06009A61 RID: 39521 RVA: 0x0016325B File Offset: 0x0016145B
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

		// Token: 0x06009A62 RID: 39522 RVA: 0x0016326E File Offset: 0x0016146E
		public new IMotorEnterSlide_SetValue ToSetValue()
		{
			return new IMotorEnterSlide_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId,
				EnterMode = this.EnterMode
			};
		}

		// Token: 0x1700305F RID: 12383
		// (get) Token: 0x06009A63 RID: 39523 RVA: 0x00163299 File Offset: 0x00161499
		// (set) Token: 0x06009A64 RID: 39524 RVA: 0x001632C4 File Offset: 0x001614C4
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

		// Token: 0x17003060 RID: 12384
		// (get) Token: 0x06009A65 RID: 39525 RVA: 0x001632D2 File Offset: 0x001614D2
		// (set) Token: 0x06009A66 RID: 39526 RVA: 0x001632FD File Offset: 0x001614FD
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

		// Token: 0x17003061 RID: 12385
		// (get) Token: 0x06009A67 RID: 39527 RVA: 0x0016330C File Offset: 0x0016150C
		// (set) Token: 0x06009A68 RID: 39528 RVA: 0x00163346 File Offset: 0x00161546
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

		// Token: 0x04005DEA RID: 24042
		[Nullable(2)]
		protected new IMotorEnterSlide FbInstance;

		// Token: 0x04005DEB RID: 24043
		[Nullable(2)]
		protected new IMotorEnterSlide_SetValue PocoInterface;
	}
}
