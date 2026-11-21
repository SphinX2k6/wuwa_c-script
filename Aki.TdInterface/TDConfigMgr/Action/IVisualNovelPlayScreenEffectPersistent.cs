using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022EC RID: 8940
	public class IVisualNovelPlayScreenEffectPersistent : IVisualNovelPlayScreenEffectConfigBase
	{
		// Token: 0x0600C2DC RID: 49884 RVA: 0x001C0050 File Offset: 0x001BE250
		private IVisualNovelPlayScreenEffectPersistent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelPlayScreenEffectPersistent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelPlayScreenEffectPersistent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelPlayScreenEffectPersistent_SetValue());
			}
			return result;
		}

		// Token: 0x0600C2DD RID: 49885 RVA: 0x001C0088 File Offset: 0x001BE288
		public static IVisualNovelPlayScreenEffectPersistent Create([Nullable(2)] IVisualNovelPlayScreenEffectPersistent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelPlayScreenEffectPersistent
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C2DE RID: 49886 RVA: 0x001C009B File Offset: 0x001BE29B
		public static IVisualNovelPlayScreenEffectPersistent CreateFromSetValue([Nullable(2)] IVisualNovelPlayScreenEffectPersistent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelPlayScreenEffectPersistent
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C2DF RID: 49887 RVA: 0x001C00AE File Offset: 0x001BE2AE
		public new IVisualNovelPlayScreenEffectPersistent_SetValue ToSetValue()
		{
			return new IVisualNovelPlayScreenEffectPersistent_SetValue
			{
				Type = this.Type,
				PersistentEffectPath = this.PersistentEffectPath
			};
		}

		// Token: 0x17003B1C RID: 15132
		// (get) Token: 0x0600C2E0 RID: 49888 RVA: 0x001C00CD File Offset: 0x001BE2CD
		// (set) Token: 0x0600C2E1 RID: 49889 RVA: 0x001C00F8 File Offset: 0x001BE2F8
		public override EVisualNovelScreenEffectType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EVisualNovelScreenEffectType.OneShot;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003B1D RID: 15133
		// (get) Token: 0x0600C2E2 RID: 49890 RVA: 0x001C0106 File Offset: 0x001BE306
		// (set) Token: 0x0600C2E3 RID: 49891 RVA: 0x001C0131 File Offset: 0x001BE331
		public virtual string PersistentEffectPath
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PersistentEffectPath;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.PersistentEffectPath;
			}
			set
			{
				this.GetOrCreatePoco().PersistentEffectPath = value;
			}
		}

		// Token: 0x04007449 RID: 29769
		[Nullable(2)]
		protected new IVisualNovelPlayScreenEffectPersistent FbInstance;

		// Token: 0x0400744A RID: 29770
		[Nullable(2)]
		protected new IVisualNovelPlayScreenEffectPersistent_SetValue PocoInterface;
	}
}
