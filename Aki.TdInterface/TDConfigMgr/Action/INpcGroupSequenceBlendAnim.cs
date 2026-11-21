using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E67 RID: 7783
	public class INpcGroupSequenceBlendAnim
	{
		// Token: 0x0600A573 RID: 42355 RVA: 0x00179600 File Offset: 0x00177800
		private INpcGroupSequenceBlendAnim_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcGroupSequenceBlendAnim 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcGroupSequenceBlendAnim_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcGroupSequenceBlendAnim_SetValue());
			}
			return result;
		}

		// Token: 0x0600A574 RID: 42356 RVA: 0x00179638 File Offset: 0x00177838
		public static INpcGroupSequenceBlendAnim Create([Nullable(2)] INpcGroupSequenceBlendAnim instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcGroupSequenceBlendAnim
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A575 RID: 42357 RVA: 0x0017964B File Offset: 0x0017784B
		public static INpcGroupSequenceBlendAnim CreateFromSetValue([Nullable(2)] INpcGroupSequenceBlendAnim_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcGroupSequenceBlendAnim
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A576 RID: 42358 RVA: 0x0017965E File Offset: 0x0017785E
		public INpcGroupSequenceBlendAnim_SetValue ToSetValue()
		{
			return new INpcGroupSequenceBlendAnim_SetValue
			{
				Target = this.Target,
				BlendType = this.BlendType
			};
		}

		// Token: 0x1700332D RID: 13101
		// (get) Token: 0x0600A577 RID: 42359 RVA: 0x0017967D File Offset: 0x0017787D
		// (set) Token: 0x0600A578 RID: 42360 RVA: 0x001796A8 File Offset: 0x001778A8
		public virtual int Target
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Target;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Target;
			}
			set
			{
				this.GetOrCreatePoco().Target = value;
			}
		}

		// Token: 0x1700332E RID: 13102
		// (get) Token: 0x0600A579 RID: 42361 RVA: 0x001796B8 File Offset: 0x001778B8
		// (set) Token: 0x0600A57A RID: 42362 RVA: 0x00179719 File Offset: 0x00177919
		public virtual INpcGroupSequenceMontageBlendAnimType BlendType
		{
			get
			{
				if (this._BlendTypeInited)
				{
					return this._BlendTypeCache;
				}
				this._BlendTypeInited = true;
				if (this.FbInstance != null)
				{
					this._BlendTypeCache = INpcGroupSequenceMontageBlendAnimType.Create(this.FbInstance.BlendType);
				}
				else
				{
					INpcGroupSequenceBlendAnim_SetValue pocoInterface = this.PocoInterface;
					this._BlendTypeCache = ((pocoInterface != null) ? pocoInterface.BlendType : null);
				}
				return this._BlendTypeCache;
			}
			set
			{
				this.GetOrCreatePoco().BlendType = value;
				this._BlendTypeInited = false;
			}
		}

		// Token: 0x040063EC RID: 25580
		[Nullable(2)]
		protected INpcGroupSequenceBlendAnim FbInstance;

		// Token: 0x040063ED RID: 25581
		[Nullable(2)]
		protected INpcGroupSequenceBlendAnim_SetValue PocoInterface;

		// Token: 0x040063EE RID: 25582
		private INpcGroupSequenceMontageBlendAnimType _BlendTypeCache;

		// Token: 0x040063EF RID: 25583
		private bool _BlendTypeInited;
	}
}
