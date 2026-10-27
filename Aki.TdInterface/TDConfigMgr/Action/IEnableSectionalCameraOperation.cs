using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019EC RID: 6636
	[NullableContext(1)]
	[Nullable(0)]
	[JsonConverter(typeof(IEnableSectionalCameraOperationConverter))]
	public class IEnableSectionalCameraOperation : ICameraOperationType
	{
		// Token: 0x06008E15 RID: 36373 RVA: 0x0014C7A0 File Offset: 0x0014A9A0
		private IEnableSectionalCameraOperation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEnableSectionalCameraOperation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEnableSectionalCameraOperation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEnableSectionalCameraOperation_SetValue());
			}
			return result;
		}

		// Token: 0x06008E16 RID: 36374 RVA: 0x0014C7D8 File Offset: 0x0014A9D8
		public static IEnableSectionalCameraOperation Create([Nullable(2)] IEnableSectionalCameraOperation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnableSectionalCameraOperation
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008E17 RID: 36375 RVA: 0x0014C7EB File Offset: 0x0014A9EB
		public static IEnableSectionalCameraOperation CreateFromSetValue([Nullable(2)] IEnableSectionalCameraOperation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEnableSectionalCameraOperation
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008E18 RID: 36376 RVA: 0x0014C7FE File Offset: 0x0014A9FE
		public new IEnableSectionalCameraOperation_SetValue ToSetValue()
		{
			return new IEnableSectionalCameraOperation_SetValue
			{
				Type = this.Type,
				EnableRotate = this.EnableRotate,
				EnableZoom = this.EnableZoom
			};
		}

		// Token: 0x17002D7D RID: 11645
		// (get) Token: 0x06008E19 RID: 36377 RVA: 0x0014C829 File Offset: 0x0014AA29
		// (set) Token: 0x06008E1A RID: 36378 RVA: 0x0014C854 File Offset: 0x0014AA54
		public override ECameraOperationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECameraOperationType.Enable;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002D7E RID: 11646
		// (get) Token: 0x06008E1B RID: 36379 RVA: 0x0014C864 File Offset: 0x0014AA64
		// (set) Token: 0x06008E1C RID: 36380 RVA: 0x0014C89E File Offset: 0x0014AA9E
		public virtual bool? EnableRotate
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EnableRotate;
				}
				IEnableSectionalCameraOperation_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EnableRotate;
			}
			set
			{
				this.GetOrCreatePoco().EnableRotate = value;
			}
		}

		// Token: 0x17002D7F RID: 11647
		// (get) Token: 0x06008E1D RID: 36381 RVA: 0x0014C8AC File Offset: 0x0014AAAC
		// (set) Token: 0x06008E1E RID: 36382 RVA: 0x0014C8E6 File Offset: 0x0014AAE6
		public virtual bool? EnableZoom
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EnableZoom;
				}
				IEnableSectionalCameraOperation_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EnableZoom;
			}
			set
			{
				this.GetOrCreatePoco().EnableZoom = value;
			}
		}

		// Token: 0x04005824 RID: 22564
		[Nullable(2)]
		protected new IEnableSectionalCameraOperation FbInstance;

		// Token: 0x04005825 RID: 22565
		[Nullable(2)]
		protected new IEnableSectionalCameraOperation_SetValue PocoInterface;
	}
}
