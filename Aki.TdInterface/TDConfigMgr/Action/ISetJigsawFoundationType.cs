using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E24 RID: 7716
	[NullableContext(1)]
	[Nullable(0)]
	public class ISetJigsawFoundationType
	{
		// Token: 0x0600A50D RID: 42253 RVA: 0x001760C0 File Offset: 0x001742C0
		private ISetJigsawFoundationType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISetJigsawFoundationType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISetJigsawFoundationType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISetJigsawFoundationType_SetValue());
			}
			return result;
		}

		// Token: 0x0600A50E RID: 42254 RVA: 0x001760F8 File Offset: 0x001742F8
		public static ISetJigsawFoundationType Create([Nullable(2)] ISetJigsawFoundationType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetJigsawFoundationType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A50F RID: 42255 RVA: 0x0017610B File Offset: 0x0017430B
		public static ISetJigsawFoundationType CreateFromSetValue([Nullable(2)] ISetJigsawFoundationType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISetJigsawFoundationType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A510 RID: 42256 RVA: 0x0017611E File Offset: 0x0017431E
		public ISetJigsawFoundationType_SetValue ToSetValue()
		{
			return new ISetJigsawFoundationType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170032A7 RID: 12967
		// (get) Token: 0x0600A511 RID: 42257 RVA: 0x00176131 File Offset: 0x00174331
		// (set) Token: 0x0600A512 RID: 42258 RVA: 0x0017615C File Offset: 0x0017435C
		public virtual ESetJigsawFoundationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESetJigsawFoundationType.SetPieceState;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040062BE RID: 25278
		[Nullable(2)]
		protected ISetJigsawFoundationType FbInstance;

		// Token: 0x040062BF RID: 25279
		[Nullable(2)]
		protected ISetJigsawFoundationType_SetValue PocoInterface;
	}
}
