using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200559D RID: 21917
	public class IMonsterShowOnDeathConfig_UnionUnion
	{
		// Token: 0x1700A1E1 RID: 41441
		// (get) Token: 0x06024477 RID: 148599 RVA: 0x005023D1 File Offset: 0x005005D1
		// (set) Token: 0x06024478 RID: 148600 RVA: 0x005023D9 File Offset: 0x005005D9
		public IMonsterShowOnDeathConfig_Union Type { get; set; }

		// Token: 0x1700A1E2 RID: 41442
		// (get) Token: 0x06024479 RID: 148601 RVA: 0x005023E2 File Offset: 0x005005E2
		// (set) Token: 0x0602447A RID: 148602 RVA: 0x005023EA File Offset: 0x005005EA
		public object Value { get; set; }

		// Token: 0x0602447B RID: 148603 RVA: 0x005023F3 File Offset: 0x005005F3
		public IMonsterShowOnDeathConfig_UnionUnion()
		{
			this.Type = IMonsterShowOnDeathConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602447C RID: 148604 RVA: 0x00502409 File Offset: 0x00500609
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602447D RID: 148605 RVA: 0x0050241B File Offset: 0x0050061B
		public IMonsterShowOnDeathConfigT AsIMonsterShowOnDeathConfig()
		{
			return this.As<IMonsterShowOnDeathConfigT>();
		}

		// Token: 0x0602447E RID: 148606 RVA: 0x00502423 File Offset: 0x00500623
		public static IMonsterShowOnDeathConfig_UnionUnion FromIMonsterShowOnDeathConfig(IMonsterShowOnDeathConfigT _imonstershowondeathconfig)
		{
			return new IMonsterShowOnDeathConfig_UnionUnion
			{
				Type = IMonsterShowOnDeathConfig_Union.IMonsterShowOnDeathConfig,
				Value = _imonstershowondeathconfig
			};
		}

		// Token: 0x0602447F RID: 148607 RVA: 0x00502438 File Offset: 0x00500638
		public IMonsterShowOnDeathEffectT AsIMonsterShowOnDeathEffect()
		{
			return this.As<IMonsterShowOnDeathEffectT>();
		}

		// Token: 0x06024480 RID: 148608 RVA: 0x00502440 File Offset: 0x00500640
		public static IMonsterShowOnDeathConfig_UnionUnion FromIMonsterShowOnDeathEffect(IMonsterShowOnDeathEffectT _imonstershowondeatheffect)
		{
			return new IMonsterShowOnDeathConfig_UnionUnion
			{
				Type = IMonsterShowOnDeathConfig_Union.IMonsterShowOnDeathEffect,
				Value = _imonstershowondeatheffect
			};
		}

		// Token: 0x06024481 RID: 148609 RVA: 0x00502458 File Offset: 0x00500658
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
