using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002159 RID: 8537
	public class ITalkBackgroundSpineImage : ITalkBackground
	{
		// Token: 0x0600B52C RID: 46380 RVA: 0x00195980 File Offset: 0x00193B80
		private ITalkBackgroundSpineImage_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkBackgroundSpineImage 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkBackgroundSpineImage_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkBackgroundSpineImage_SetValue());
			}
			return result;
		}

		// Token: 0x0600B52D RID: 46381 RVA: 0x001959B8 File Offset: 0x00193BB8
		public static ITalkBackgroundSpineImage Create([Nullable(2)] ITalkBackgroundSpineImage instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkBackgroundSpineImage
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B52E RID: 46382 RVA: 0x001959CB File Offset: 0x00193BCB
		public static ITalkBackgroundSpineImage CreateFromSetValue([Nullable(2)] ITalkBackgroundSpineImage_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkBackgroundSpineImage
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B52F RID: 46383 RVA: 0x001959DE File Offset: 0x00193BDE
		public new ITalkBackgroundSpineImage_SetValue ToSetValue()
		{
			return new ITalkBackgroundSpineImage_SetValue
			{
				Type = this.Type,
				Id = this.Id,
				IsLoop = this.IsLoop
			};
		}

		// Token: 0x170036A0 RID: 13984
		// (get) Token: 0x0600B530 RID: 46384 RVA: 0x00195A09 File Offset: 0x00193C09
		// (set) Token: 0x0600B531 RID: 46385 RVA: 0x00195A34 File Offset: 0x00193C34
		public override ETalkBackgroundType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETalkBackgroundType.Clean;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170036A1 RID: 13985
		// (get) Token: 0x0600B532 RID: 46386 RVA: 0x00195A42 File Offset: 0x00193C42
		// (set) Token: 0x0600B533 RID: 46387 RVA: 0x00195A6D File Offset: 0x00193C6D
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x170036A2 RID: 13986
		// (get) Token: 0x0600B534 RID: 46388 RVA: 0x00195A7C File Offset: 0x00193C7C
		// (set) Token: 0x0600B535 RID: 46389 RVA: 0x00195AB6 File Offset: 0x00193CB6
		public virtual bool? IsLoop
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsLoop;
				}
				ITalkBackgroundSpineImage_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsLoop;
			}
			set
			{
				this.GetOrCreatePoco().IsLoop = value;
			}
		}

		// Token: 0x04006B20 RID: 27424
		[Nullable(2)]
		protected new ITalkBackgroundSpineImage FbInstance;

		// Token: 0x04006B21 RID: 27425
		[Nullable(2)]
		protected new ITalkBackgroundSpineImage_SetValue PocoInterface;
	}
}
