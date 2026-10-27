using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006B6 RID: 1718
	[NullableContext(1)]
	[Nullable(0)]
	public class ISceneTextTypeBase
	{
		// Token: 0x060024E6 RID: 9446 RVA: 0x00063B0C File Offset: 0x00061D0C
		private ISceneTextTypeBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISceneTextTypeBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISceneTextTypeBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISceneTextTypeBase_SetValue());
			}
			return result;
		}

		// Token: 0x060024E7 RID: 9447 RVA: 0x00063B44 File Offset: 0x00061D44
		public static ISceneTextTypeBase Create([Nullable(2)] ISceneTextTypeBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneTextTypeBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x060024E8 RID: 9448 RVA: 0x00063B57 File Offset: 0x00061D57
		public static ISceneTextTypeBase CreateFromSetValue([Nullable(2)] ISceneTextTypeBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISceneTextTypeBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x060024E9 RID: 9449 RVA: 0x00063B6A File Offset: 0x00061D6A
		public ISceneTextTypeBase_SetValue ToSetValue()
		{
			return new ISceneTextTypeBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x060024EA RID: 9450 RVA: 0x00063B7D File Offset: 0x00061D7D
		// (set) Token: 0x060024EB RID: 9451 RVA: 0x00063BA8 File Offset: 0x00061DA8
		public virtual ESceneTextType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESceneTextType.SubtitleWithVoice;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001945 RID: 6469
		[Nullable(2)]
		protected ISceneTextTypeBase FbInstance;

		// Token: 0x04001946 RID: 6470
		[Nullable(2)]
		protected ISceneTextTypeBase_SetValue PocoInterface;
	}
}
