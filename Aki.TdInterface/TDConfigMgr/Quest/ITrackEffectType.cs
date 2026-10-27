using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011B6 RID: 4534
	[NullableContext(1)]
	[Nullable(0)]
	public class ITrackEffectType
	{
		// Token: 0x06006702 RID: 26370 RVA: 0x000F6C38 File Offset: 0x000F4E38
		private ITrackEffectType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITrackEffectType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITrackEffectType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITrackEffectType_SetValue());
			}
			return result;
		}

		// Token: 0x06006703 RID: 26371 RVA: 0x000F6C70 File Offset: 0x000F4E70
		public static ITrackEffectType Create([Nullable(2)] ITrackEffectType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrackEffectType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006704 RID: 26372 RVA: 0x000F6C83 File Offset: 0x000F4E83
		public static ITrackEffectType CreateFromSetValue([Nullable(2)] ITrackEffectType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITrackEffectType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006705 RID: 26373 RVA: 0x000F6C96 File Offset: 0x000F4E96
		public ITrackEffectType_SetValue ToSetValue()
		{
			return new ITrackEffectType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002175 RID: 8565
		// (get) Token: 0x06006706 RID: 26374 RVA: 0x000F6CA9 File Offset: 0x000F4EA9
		// (set) Token: 0x06006707 RID: 26375 RVA: 0x000F6CD4 File Offset: 0x000F4ED4
		public virtual ETrackEffectType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETrackEffectType.AutoChange;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003DDA RID: 15834
		[Nullable(2)]
		protected ITrackEffectType FbInstance;

		// Token: 0x04003DDB RID: 15835
		[Nullable(2)]
		protected ITrackEffectType_SetValue PocoInterface;
	}
}
