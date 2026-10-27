using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02005CA8 RID: 23720
	[NullableContext(1)]
	[Nullable(0)]
	public class FullScreenEffectHandle
	{
		// Token: 0x0603BED0 RID: 245456 RVA: 0x00E51EDF File Offset: 0x00E500DF
		public FullScreenEffectHandle(long uniqueId, string niagaraPath)
		{
		}

		// Token: 0x0603BED1 RID: 245457 RVA: 0x00E51F00 File Offset: 0x00E50100
		public void SetFloatParameter(string key, float value)
		{
			this.FloatParameterMap[key] = value;
			EventSystem.Instance.Emit<long, string, float>(EEventName.OnChangeFullScreenNiagaraFloatParameter, this.UniqueId, key, value);
		}

		// Token: 0x0603BED2 RID: 245458 RVA: 0x00E51F27 File Offset: 0x00E50127
		public IReadOnlyDictionary<string, float> GetFloatParameterMap()
		{
			return this.FloatParameterMap;
		}

		// Token: 0x0401F45A RID: 128090
		public readonly long UniqueId = uniqueId;

		// Token: 0x0401F45B RID: 128091
		public readonly string NiagaraPath = niagaraPath;

		// Token: 0x0401F45C RID: 128092
		private readonly Dictionary<string, float> FloatParameterMap = new Dictionary<string, float>();
	}
}
