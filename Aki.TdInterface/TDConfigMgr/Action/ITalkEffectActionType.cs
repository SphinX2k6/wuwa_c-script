using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F24 RID: 7972
	[NullableContext(1)]
	[Nullable(0)]
	public class ITalkEffectActionType
	{
		// Token: 0x0600AA74 RID: 43636 RVA: 0x0017FCB4 File Offset: 0x0017DEB4
		private ITalkEffectActionType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkEffectActionType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkEffectActionType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkEffectActionType_SetValue());
			}
			return result;
		}

		// Token: 0x0600AA75 RID: 43637 RVA: 0x0017FCEC File Offset: 0x0017DEEC
		public static ITalkEffectActionType Create([Nullable(2)] ITalkEffectActionType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkEffectActionType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AA76 RID: 43638 RVA: 0x0017FCFF File Offset: 0x0017DEFF
		public static ITalkEffectActionType CreateFromSetValue([Nullable(2)] ITalkEffectActionType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkEffectActionType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AA77 RID: 43639 RVA: 0x0017FD12 File Offset: 0x0017DF12
		public ITalkEffectActionType_SetValue ToSetValue()
		{
			return new ITalkEffectActionType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170033DC RID: 13276
		// (get) Token: 0x0600AA78 RID: 43640 RVA: 0x0017FD25 File Offset: 0x0017DF25
		// (set) Token: 0x0600AA79 RID: 43641 RVA: 0x0017FD50 File Offset: 0x0017DF50
		public virtual ETalkEffectActionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETalkEffectActionType.Play;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400653E RID: 25918
		[Nullable(2)]
		protected ITalkEffectActionType FbInstance;

		// Token: 0x0400653F RID: 25919
		[Nullable(2)]
		protected ITalkEffectActionType_SetValue PocoInterface;
	}
}
