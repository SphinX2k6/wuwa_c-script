using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E26 RID: 7718
	[NullableContext(1)]
	[Nullable(0)]
	public class ISetJigsawItemType
	{
		// Token: 0x0600A515 RID: 42261 RVA: 0x0017617C File Offset: 0x0017437C
		private ISetJigsawItemType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISetJigsawItemType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISetJigsawItemType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISetJigsawItemType_SetValue());
			}
			return result;
		}

		// Token: 0x0600A516 RID: 42262 RVA: 0x001761B4 File Offset: 0x001743B4
		public static ISetJigsawItemType Create([Nullable(2)] ISetJigsawItemType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetJigsawItemType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A517 RID: 42263 RVA: 0x001761C7 File Offset: 0x001743C7
		public static ISetJigsawItemType CreateFromSetValue([Nullable(2)] ISetJigsawItemType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISetJigsawItemType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A518 RID: 42264 RVA: 0x001761DA File Offset: 0x001743DA
		public ISetJigsawItemType_SetValue ToSetValue()
		{
			return new ISetJigsawItemType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170032A8 RID: 12968
		// (get) Token: 0x0600A519 RID: 42265 RVA: 0x001761ED File Offset: 0x001743ED
		// (set) Token: 0x0600A51A RID: 42266 RVA: 0x00176218 File Offset: 0x00174418
		public virtual ESetJigsawItemType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESetJigsawItemType.MoveJigsawItem;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040062C1 RID: 25281
		[Nullable(2)]
		protected ISetJigsawItemType FbInstance;

		// Token: 0x040062C2 RID: 25282
		[Nullable(2)]
		protected ISetJigsawItemType_SetValue PocoInterface;
	}
}
