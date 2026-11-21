using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020DA RID: 8410
	public class ISplineMoveMontageType
	{
		// Token: 0x0600B28A RID: 45706 RVA: 0x00190E70 File Offset: 0x0018F070
		private ISplineMoveMontageType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISplineMoveMontageType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISplineMoveMontageType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISplineMoveMontageType_SetValue());
			}
			return result;
		}

		// Token: 0x0600B28B RID: 45707 RVA: 0x00190EA8 File Offset: 0x0018F0A8
		public static ISplineMoveMontageType Create([Nullable(2)] ISplineMoveMontageType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISplineMoveMontageType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B28C RID: 45708 RVA: 0x00190EBB File Offset: 0x0018F0BB
		public static ISplineMoveMontageType CreateFromSetValue([Nullable(2)] ISplineMoveMontageType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISplineMoveMontageType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B28D RID: 45709 RVA: 0x00190ECE File Offset: 0x0018F0CE
		public ISplineMoveMontageType_SetValue ToSetValue()
		{
			return new ISplineMoveMontageType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700360D RID: 13837
		// (get) Token: 0x0600B28E RID: 45710 RVA: 0x00190EE1 File Offset: 0x0018F0E1
		// (set) Token: 0x0600B28F RID: 45711 RVA: 0x00190F0C File Offset: 0x0018F10C
		public virtual ESplineMoveMontageType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESplineMoveMontageType.ThreeStageMontage;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040069EE RID: 27118
		[Nullable(2)]
		protected ISplineMoveMontageType FbInstance;

		// Token: 0x040069EF RID: 27119
		[Nullable(2)]
		protected ISplineMoveMontageType_SetValue PocoInterface;
	}
}
