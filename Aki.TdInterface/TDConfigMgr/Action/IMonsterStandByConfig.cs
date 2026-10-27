using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BFC RID: 7164
	[NullableContext(1)]
	[Nullable(0)]
	public class IMonsterStandByConfig
	{
		// Token: 0x06009967 RID: 39271 RVA: 0x00161014 File Offset: 0x0015F214
		private IMonsterStandByConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMonsterStandByConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMonsterStandByConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMonsterStandByConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06009968 RID: 39272 RVA: 0x0016104C File Offset: 0x0015F24C
		public static IMonsterStandByConfig Create([Nullable(2)] IMonsterStandByConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterStandByConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009969 RID: 39273 RVA: 0x0016105F File Offset: 0x0015F25F
		public static IMonsterStandByConfig CreateFromSetValue([Nullable(2)] IMonsterStandByConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMonsterStandByConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600996A RID: 39274 RVA: 0x00161072 File Offset: 0x0015F272
		public IMonsterStandByConfig_SetValue ToSetValue()
		{
			return new IMonsterStandByConfig_SetValue
			{
				Tag = this.Tag,
				Duration = this.Duration,
				RepeatTimes = this.RepeatTimes,
				EmotionId = this.EmotionId
			};
		}

		// Token: 0x17003010 RID: 12304
		// (get) Token: 0x0600996B RID: 39275 RVA: 0x001610A9 File Offset: 0x0015F2A9
		// (set) Token: 0x0600996C RID: 39276 RVA: 0x001610D4 File Offset: 0x0015F2D4
		public virtual string Tag
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Tag;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Tag;
			}
			set
			{
				this.GetOrCreatePoco().Tag = value;
			}
		}

		// Token: 0x17003011 RID: 12305
		// (get) Token: 0x0600996D RID: 39277 RVA: 0x001610E4 File Offset: 0x0015F2E4
		// (set) Token: 0x0600996E RID: 39278 RVA: 0x0016111E File Offset: 0x0015F31E
		public virtual float? Duration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Duration;
				}
				IMonsterStandByConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Duration;
			}
			set
			{
				this.GetOrCreatePoco().Duration = value;
			}
		}

		// Token: 0x17003012 RID: 12306
		// (get) Token: 0x0600996F RID: 39279 RVA: 0x0016112C File Offset: 0x0015F32C
		// (set) Token: 0x06009970 RID: 39280 RVA: 0x00161166 File Offset: 0x0015F366
		public virtual int? RepeatTimes
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RepeatTimes;
				}
				IMonsterStandByConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.RepeatTimes;
			}
			set
			{
				this.GetOrCreatePoco().RepeatTimes = value;
			}
		}

		// Token: 0x17003013 RID: 12307
		// (get) Token: 0x06009971 RID: 39281 RVA: 0x00161174 File Offset: 0x0015F374
		// (set) Token: 0x06009972 RID: 39282 RVA: 0x001611AE File Offset: 0x0015F3AE
		public virtual int? EmotionId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EmotionId;
				}
				IMonsterStandByConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EmotionId;
			}
			set
			{
				this.GetOrCreatePoco().EmotionId = value;
			}
		}

		// Token: 0x04005D65 RID: 23909
		[Nullable(2)]
		protected IMonsterStandByConfig FbInstance;

		// Token: 0x04005D66 RID: 23910
		[Nullable(2)]
		protected IMonsterStandByConfig_SetValue PocoInterface;
	}
}
