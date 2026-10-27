using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AE1 RID: 6881
	[NullableContext(1)]
	[Nullable(0)]
	public class IGroupAiCommunicateMode
	{
		// Token: 0x06009378 RID: 37752 RVA: 0x0015636C File Offset: 0x0015456C
		private IGroupAiCommunicateMode_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IGroupAiCommunicateMode 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IGroupAiCommunicateMode_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IGroupAiCommunicateMode_SetValue());
			}
			return result;
		}

		// Token: 0x06009379 RID: 37753 RVA: 0x001563A4 File Offset: 0x001545A4
		public static IGroupAiCommunicateMode Create([Nullable(2)] IGroupAiCommunicateMode instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGroupAiCommunicateMode
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600937A RID: 37754 RVA: 0x001563B7 File Offset: 0x001545B7
		public static IGroupAiCommunicateMode CreateFromSetValue([Nullable(2)] IGroupAiCommunicateMode_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IGroupAiCommunicateMode
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600937B RID: 37755 RVA: 0x001563CA File Offset: 0x001545CA
		public IGroupAiCommunicateMode_SetValue ToSetValue()
		{
			return new IGroupAiCommunicateMode_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002EC0 RID: 11968
		// (get) Token: 0x0600937C RID: 37756 RVA: 0x001563DD File Offset: 0x001545DD
		// (set) Token: 0x0600937D RID: 37757 RVA: 0x00156408 File Offset: 0x00154608
		public virtual EGroupAiCommunicateType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EGroupAiCommunicateType.AddTag;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005A9F RID: 23199
		[Nullable(2)]
		protected IGroupAiCommunicateMode FbInstance;

		// Token: 0x04005AA0 RID: 23200
		[Nullable(2)]
		protected IGroupAiCommunicateMode_SetValue PocoInterface;
	}
}
