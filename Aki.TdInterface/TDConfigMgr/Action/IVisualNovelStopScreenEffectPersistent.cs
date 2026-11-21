using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022FA RID: 8954
	public class IVisualNovelStopScreenEffectPersistent : IVisualNovelStopScreenEffectConfigBase
	{
		// Token: 0x0600C32A RID: 49962 RVA: 0x001C08FC File Offset: 0x001BEAFC
		private IVisualNovelStopScreenEffectPersistent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelStopScreenEffectPersistent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelStopScreenEffectPersistent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelStopScreenEffectPersistent_SetValue());
			}
			return result;
		}

		// Token: 0x0600C32B RID: 49963 RVA: 0x001C0934 File Offset: 0x001BEB34
		public static IVisualNovelStopScreenEffectPersistent Create([Nullable(2)] IVisualNovelStopScreenEffectPersistent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelStopScreenEffectPersistent
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C32C RID: 49964 RVA: 0x001C0947 File Offset: 0x001BEB47
		public static IVisualNovelStopScreenEffectPersistent CreateFromSetValue([Nullable(2)] IVisualNovelStopScreenEffectPersistent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelStopScreenEffectPersistent
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C32D RID: 49965 RVA: 0x001C095A File Offset: 0x001BEB5A
		public new IVisualNovelStopScreenEffectPersistent_SetValue ToSetValue()
		{
			return new IVisualNovelStopScreenEffectPersistent_SetValue
			{
				Type = this.Type,
				PersistentEffectPath = this.PersistentEffectPath
			};
		}

		// Token: 0x17003B2E RID: 15150
		// (get) Token: 0x0600C32E RID: 49966 RVA: 0x001C0979 File Offset: 0x001BEB79
		// (set) Token: 0x0600C32F RID: 49967 RVA: 0x001C09A4 File Offset: 0x001BEBA4
		public override EVisualNovelStopScreenEffectType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EVisualNovelStopScreenEffectType.Persistent;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003B2F RID: 15151
		// (get) Token: 0x0600C330 RID: 49968 RVA: 0x001C09B2 File Offset: 0x001BEBB2
		// (set) Token: 0x0600C331 RID: 49969 RVA: 0x001C09DD File Offset: 0x001BEBDD
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

		// Token: 0x04007469 RID: 29801
		[Nullable(2)]
		protected new IVisualNovelStopScreenEffectPersistent FbInstance;

		// Token: 0x0400746A RID: 29802
		[Nullable(2)]
		protected new IVisualNovelStopScreenEffectPersistent_SetValue PocoInterface;
	}
}
