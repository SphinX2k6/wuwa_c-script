using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B7F RID: 7039
	[JsonConverter(typeof(IEnableSectionalCameraOperationConverter))]
	public class IEnableSectionalCameraOperation : ICameraOperationType
	{
		// Token: 0x06009577 RID: 38263 RVA: 0x0015C610 File Offset: 0x0015A810
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

		// Token: 0x06009578 RID: 38264 RVA: 0x0015C648 File Offset: 0x0015A848
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

		// Token: 0x06009579 RID: 38265 RVA: 0x0015C65B File Offset: 0x0015A85B
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

		// Token: 0x0600957A RID: 38266 RVA: 0x0015C66E File Offset: 0x0015A86E
		public new IEnableSectionalCameraOperation_SetValue ToSetValue()
		{
			return new IEnableSectionalCameraOperation_SetValue
			{
				Type = this.Type,
				EnableRotate = this.EnableRotate,
				EnableZoom = this.EnableZoom
			};
		}

		// Token: 0x17002F89 RID: 12169
		// (get) Token: 0x0600957B RID: 38267 RVA: 0x0015C699 File Offset: 0x0015A899
		// (set) Token: 0x0600957C RID: 38268 RVA: 0x0015C6C4 File Offset: 0x0015A8C4
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

		// Token: 0x17002F8A RID: 12170
		// (get) Token: 0x0600957D RID: 38269 RVA: 0x0015C6D4 File Offset: 0x0015A8D4
		// (set) Token: 0x0600957E RID: 38270 RVA: 0x0015C70E File Offset: 0x0015A90E
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

		// Token: 0x17002F8B RID: 12171
		// (get) Token: 0x0600957F RID: 38271 RVA: 0x0015C71C File Offset: 0x0015A91C
		// (set) Token: 0x06009580 RID: 38272 RVA: 0x0015C756 File Offset: 0x0015A956
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

		// Token: 0x04005C86 RID: 23686
		[Nullable(2)]
		protected new IEnableSectionalCameraOperation FbInstance;

		// Token: 0x04005C87 RID: 23687
		[Nullable(2)]
		protected new IEnableSectionalCameraOperation_SetValue PocoInterface;
	}
}
