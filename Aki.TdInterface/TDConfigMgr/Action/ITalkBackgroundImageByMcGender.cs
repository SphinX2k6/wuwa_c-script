using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002157 RID: 8535
	public class ITalkBackgroundImageByMcGender : ITalkBackground
	{
		// Token: 0x0600B520 RID: 46368 RVA: 0x0019583C File Offset: 0x00193A3C
		private ITalkBackgroundImageByMcGender_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkBackgroundImageByMcGender 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkBackgroundImageByMcGender_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkBackgroundImageByMcGender_SetValue());
			}
			return result;
		}

		// Token: 0x0600B521 RID: 46369 RVA: 0x00195874 File Offset: 0x00193A74
		public static ITalkBackgroundImageByMcGender Create([Nullable(2)] ITalkBackgroundImageByMcGender instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkBackgroundImageByMcGender
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B522 RID: 46370 RVA: 0x00195887 File Offset: 0x00193A87
		public static ITalkBackgroundImageByMcGender CreateFromSetValue([Nullable(2)] ITalkBackgroundImageByMcGender_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkBackgroundImageByMcGender
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B523 RID: 46371 RVA: 0x0019589A File Offset: 0x00193A9A
		public new ITalkBackgroundImageByMcGender_SetValue ToSetValue()
		{
			return new ITalkBackgroundImageByMcGender_SetValue
			{
				Type = this.Type,
				ImageAssetMale = this.ImageAssetMale,
				ImageAssetFemale = this.ImageAssetFemale
			};
		}

		// Token: 0x1700369D RID: 13981
		// (get) Token: 0x0600B524 RID: 46372 RVA: 0x001958C5 File Offset: 0x00193AC5
		// (set) Token: 0x0600B525 RID: 46373 RVA: 0x001958F0 File Offset: 0x00193AF0
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

		// Token: 0x1700369E RID: 13982
		// (get) Token: 0x0600B526 RID: 46374 RVA: 0x001958FE File Offset: 0x00193AFE
		// (set) Token: 0x0600B527 RID: 46375 RVA: 0x00195929 File Offset: 0x00193B29
		public virtual string ImageAssetMale
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ImageAssetMale;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.ImageAssetMale;
			}
			set
			{
				this.GetOrCreatePoco().ImageAssetMale = value;
			}
		}

		// Token: 0x1700369F RID: 13983
		// (get) Token: 0x0600B528 RID: 46376 RVA: 0x00195937 File Offset: 0x00193B37
		// (set) Token: 0x0600B529 RID: 46377 RVA: 0x00195962 File Offset: 0x00193B62
		public virtual string ImageAssetFemale
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ImageAssetFemale;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.ImageAssetFemale;
			}
			set
			{
				this.GetOrCreatePoco().ImageAssetFemale = value;
			}
		}

		// Token: 0x04006B1B RID: 27419
		[Nullable(2)]
		protected new ITalkBackgroundImageByMcGender FbInstance;

		// Token: 0x04006B1C RID: 27420
		[Nullable(2)]
		protected new ITalkBackgroundImageByMcGender_SetValue PocoInterface;
	}
}
