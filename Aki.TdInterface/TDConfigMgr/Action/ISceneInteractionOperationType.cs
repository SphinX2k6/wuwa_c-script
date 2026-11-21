using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FF9 RID: 8185
	[JsonConverter(typeof(ISceneInteractionOperationTypeConverter))]
	public class ISceneInteractionOperationType
	{
		// Token: 0x0600ADD1 RID: 44497 RVA: 0x0018833C File Offset: 0x0018653C
		private ISceneInteractionOperationType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISceneInteractionOperationType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISceneInteractionOperationType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISceneInteractionOperationType_SetValue());
			}
			return result;
		}

		// Token: 0x0600ADD2 RID: 44498 RVA: 0x00188374 File Offset: 0x00186574
		public static ISceneInteractionOperationType Create([Nullable(2)] ISceneInteractionOperationType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneInteractionOperationType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600ADD3 RID: 44499 RVA: 0x00188387 File Offset: 0x00186587
		public static ISceneInteractionOperationType CreateFromSetValue([Nullable(2)] ISceneInteractionOperationType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISceneInteractionOperationType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600ADD4 RID: 44500 RVA: 0x0018839A File Offset: 0x0018659A
		public ISceneInteractionOperationType_SetValue ToSetValue()
		{
			return new ISceneInteractionOperationType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003501 RID: 13569
		// (get) Token: 0x0600ADD5 RID: 44501 RVA: 0x001883AD File Offset: 0x001865AD
		// (set) Token: 0x0600ADD6 RID: 44502 RVA: 0x001883D8 File Offset: 0x001865D8
		public virtual ESceneInteractionOperationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESceneInteractionOperationType.Enable;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040067B2 RID: 26546
		[Nullable(2)]
		protected ISceneInteractionOperationType FbInstance;

		// Token: 0x040067B3 RID: 26547
		[Nullable(2)]
		protected ISceneInteractionOperationType_SetValue PocoInterface;
	}
}
