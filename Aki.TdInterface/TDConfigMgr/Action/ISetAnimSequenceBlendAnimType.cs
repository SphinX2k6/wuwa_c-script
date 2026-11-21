using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200203D RID: 8253
	public class ISetAnimSequenceBlendAnimType : IBlendAnimTypeBase
	{
		// Token: 0x0600AF2D RID: 44845 RVA: 0x0018ABA0 File Offset: 0x00188DA0
		private ISetAnimSequenceBlendAnimType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISetAnimSequenceBlendAnimType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISetAnimSequenceBlendAnimType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISetAnimSequenceBlendAnimType_SetValue());
			}
			return result;
		}

		// Token: 0x0600AF2E RID: 44846 RVA: 0x0018ABD8 File Offset: 0x00188DD8
		public static ISetAnimSequenceBlendAnimType Create([Nullable(2)] ISetAnimSequenceBlendAnimType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetAnimSequenceBlendAnimType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AF2F RID: 44847 RVA: 0x0018ABEB File Offset: 0x00188DEB
		public static ISetAnimSequenceBlendAnimType CreateFromSetValue([Nullable(2)] ISetAnimSequenceBlendAnimType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISetAnimSequenceBlendAnimType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AF30 RID: 44848 RVA: 0x0018ABFE File Offset: 0x00188DFE
		public new ISetAnimSequenceBlendAnimType_SetValue ToSetValue()
		{
			return new ISetAnimSequenceBlendAnimType_SetValue
			{
				Type = this.Type,
				AnimSequence = this.AnimSequence,
				ProtectTime = this.ProtectTime
			};
		}

		// Token: 0x17003549 RID: 13641
		// (get) Token: 0x0600AF31 RID: 44849 RVA: 0x0018AC29 File Offset: 0x00188E29
		// (set) Token: 0x0600AF32 RID: 44850 RVA: 0x0018AC54 File Offset: 0x00188E54
		public override EBlendAnimType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EBlendAnimType.StateMachine;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700354A RID: 13642
		// (get) Token: 0x0600AF33 RID: 44851 RVA: 0x0018AC62 File Offset: 0x00188E62
		// (set) Token: 0x0600AF34 RID: 44852 RVA: 0x0018AC8D File Offset: 0x00188E8D
		public virtual string AnimSequence
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AnimSequence;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.AnimSequence;
			}
			set
			{
				this.GetOrCreatePoco().AnimSequence = value;
			}
		}

		// Token: 0x1700354B RID: 13643
		// (get) Token: 0x0600AF35 RID: 44853 RVA: 0x0018AC9C File Offset: 0x00188E9C
		// (set) Token: 0x0600AF36 RID: 44854 RVA: 0x0018ACD6 File Offset: 0x00188ED6
		public virtual float? ProtectTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ProtectTime;
				}
				ISetAnimSequenceBlendAnimType_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ProtectTime;
			}
			set
			{
				this.GetOrCreatePoco().ProtectTime = value;
			}
		}

		// Token: 0x04006858 RID: 26712
		[Nullable(2)]
		protected new ISetAnimSequenceBlendAnimType FbInstance;

		// Token: 0x04006859 RID: 26713
		[Nullable(2)]
		protected new ISetAnimSequenceBlendAnimType_SetValue PocoInterface;
	}
}
