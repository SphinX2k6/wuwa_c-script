using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B3B RID: 23355
	public class IMonsterShowOnDeathConfig_UnionUnion
	{
		// Token: 0x1700AA69 RID: 43625
		// (get) Token: 0x06026684 RID: 157316 RVA: 0x00542949 File Offset: 0x00540B49
		// (set) Token: 0x06026685 RID: 157317 RVA: 0x00542951 File Offset: 0x00540B51
		public IMonsterShowOnDeathConfig_Union Type { get; set; }

		// Token: 0x1700AA6A RID: 43626
		// (get) Token: 0x06026686 RID: 157318 RVA: 0x0054295A File Offset: 0x00540B5A
		// (set) Token: 0x06026687 RID: 157319 RVA: 0x00542962 File Offset: 0x00540B62
		public object Value { get; set; }

		// Token: 0x06026688 RID: 157320 RVA: 0x0054296B File Offset: 0x00540B6B
		public IMonsterShowOnDeathConfig_UnionUnion()
		{
			this.Type = IMonsterShowOnDeathConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06026689 RID: 157321 RVA: 0x00542981 File Offset: 0x00540B81
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602668A RID: 157322 RVA: 0x00542993 File Offset: 0x00540B93
		public IMonsterShowOnDeathConfigT AsIMonsterShowOnDeathConfig()
		{
			return this.As<IMonsterShowOnDeathConfigT>();
		}

		// Token: 0x0602668B RID: 157323 RVA: 0x0054299B File Offset: 0x00540B9B
		public static IMonsterShowOnDeathConfig_UnionUnion FromIMonsterShowOnDeathConfig(IMonsterShowOnDeathConfigT _imonstershowondeathconfig)
		{
			return new IMonsterShowOnDeathConfig_UnionUnion
			{
				Type = IMonsterShowOnDeathConfig_Union.IMonsterShowOnDeathConfig,
				Value = _imonstershowondeathconfig
			};
		}

		// Token: 0x0602668C RID: 157324 RVA: 0x005429B0 File Offset: 0x00540BB0
		public IMonsterShowOnDeathEffectT AsIMonsterShowOnDeathEffect()
		{
			return this.As<IMonsterShowOnDeathEffectT>();
		}

		// Token: 0x0602668D RID: 157325 RVA: 0x005429B8 File Offset: 0x00540BB8
		public static IMonsterShowOnDeathConfig_UnionUnion FromIMonsterShowOnDeathEffect(IMonsterShowOnDeathEffectT _imonstershowondeatheffect)
		{
			return new IMonsterShowOnDeathConfig_UnionUnion
			{
				Type = IMonsterShowOnDeathConfig_Union.IMonsterShowOnDeathEffect,
				Value = _imonstershowondeatheffect
			};
		}

		// Token: 0x0602668E RID: 157326 RVA: 0x005429D0 File Offset: 0x00540BD0
		public static int Pack(FlatBufferBuilder builder, IMonsterShowOnDeathConfig_UnionUnion _o)
		{
			IMonsterShowOnDeathConfig_Union type = _o.Type;
			if (type == IMonsterShowOnDeathConfig_Union.IMonsterShowOnDeathConfig)
			{
				return IMonsterShowOnDeathConfig.Pack(builder, _o.AsIMonsterShowOnDeathConfig()).Value;
			}
			if (type != IMonsterShowOnDeathConfig_Union.IMonsterShowOnDeathEffect)
			{
				return 0;
			}
			return IMonsterShowOnDeathEffect.Pack(builder, _o.AsIMonsterShowOnDeathEffect()).Value;
		}
	}
}
