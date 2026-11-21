using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C5C RID: 7260
	public class IFoxPutDown : ILeisureInteractType
	{
		// Token: 0x06009A64 RID: 39524 RVA: 0x00165564 File Offset: 0x00163764
		private IFoxPutDown_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFoxPutDown 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFoxPutDown_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFoxPutDown_SetValue());
			}
			return result;
		}

		// Token: 0x06009A65 RID: 39525 RVA: 0x0016559C File Offset: 0x0016379C
		public static IFoxPutDown Create([Nullable(2)] IFoxPutDown instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFoxPutDown
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009A66 RID: 39526 RVA: 0x001655AF File Offset: 0x001637AF
		public static IFoxPutDown CreateFromSetValue([Nullable(2)] IFoxPutDown_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFoxPutDown
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009A67 RID: 39527 RVA: 0x001655C2 File Offset: 0x001637C2
		public new IFoxPutDown_SetValue ToSetValue()
		{
			return new IFoxPutDown_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170030B5 RID: 12469
		// (get) Token: 0x06009A68 RID: 39528 RVA: 0x001655D5 File Offset: 0x001637D5
		// (set) Token: 0x06009A69 RID: 39529 RVA: 0x00165600 File Offset: 0x00163800
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

		// Token: 0x04005ECE RID: 24270
		[Nullable(2)]
		protected new IFoxPutDown FbInstance;

		// Token: 0x04005ECF RID: 24271
		[Nullable(2)]
		protected new IFoxPutDown_SetValue PocoInterface;
	}
}
