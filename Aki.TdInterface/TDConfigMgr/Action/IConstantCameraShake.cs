using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AB9 RID: 6841
	public class IConstantCameraShake : ICameraShakeConfig
	{
		// Token: 0x0600916D RID: 37229 RVA: 0x00155684 File Offset: 0x00153884
		private IConstantCameraShake_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IConstantCameraShake 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IConstantCameraShake_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IConstantCameraShake_SetValue());
			}
			return result;
		}

		// Token: 0x0600916E RID: 37230 RVA: 0x001556BC File Offset: 0x001538BC
		public static IConstantCameraShake Create([Nullable(2)] IConstantCameraShake instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IConstantCameraShake
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600916F RID: 37231 RVA: 0x001556CF File Offset: 0x001538CF
		public static IConstantCameraShake CreateFromSetValue([Nullable(2)] IConstantCameraShake_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IConstantCameraShake
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009170 RID: 37232 RVA: 0x001556E2 File Offset: 0x001538E2
		public new IConstantCameraShake_SetValue ToSetValue()
		{
			return new IConstantCameraShake_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002EAD RID: 11949
		// (get) Token: 0x06009171 RID: 37233 RVA: 0x001556F5 File Offset: 0x001538F5
		// (set) Token: 0x06009172 RID: 37234 RVA: 0x00155720 File Offset: 0x00153920
		public override ECameraShakeType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECameraShakeType.Constant;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005AC8 RID: 23240
		[Nullable(2)]
		protected new IConstantCameraShake FbInstance;

		// Token: 0x04005AC9 RID: 23241
		[Nullable(2)]
		protected new IConstantCameraShake_SetValue PocoInterface;
	}
}
