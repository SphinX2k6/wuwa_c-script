using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001930 RID: 6448
	[NullableContext(1)]
	[Nullable(0)]
	public class IConstantCameraShake : ICameraShakeConfig
	{
		// Token: 0x06008A41 RID: 35393 RVA: 0x00145D44 File Offset: 0x00143F44
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

		// Token: 0x06008A42 RID: 35394 RVA: 0x00145D7C File Offset: 0x00143F7C
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

		// Token: 0x06008A43 RID: 35395 RVA: 0x00145D8F File Offset: 0x00143F8F
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

		// Token: 0x06008A44 RID: 35396 RVA: 0x00145DA2 File Offset: 0x00143FA2
		public new IConstantCameraShake_SetValue ToSetValue()
		{
			return new IConstantCameraShake_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002CAD RID: 11437
		// (get) Token: 0x06008A45 RID: 35397 RVA: 0x00145DB5 File Offset: 0x00143FB5
		// (set) Token: 0x06008A46 RID: 35398 RVA: 0x00145DE0 File Offset: 0x00143FE0
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

		// Token: 0x04005678 RID: 22136
		[Nullable(2)]
		protected new IConstantCameraShake FbInstance;

		// Token: 0x04005679 RID: 22137
		[Nullable(2)]
		protected new IConstantCameraShake_SetValue PocoInterface;
	}
}
