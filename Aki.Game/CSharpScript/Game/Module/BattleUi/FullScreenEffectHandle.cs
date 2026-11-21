using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02004C8A RID: 19594
	[NullableContext(1)]
	[Nullable(0)]
	public class FullScreenEffectHandle
	{
		// Token: 0x06030E23 RID: 200227 RVA: 0x00DA2587 File Offset: 0x00DA0787
		public FullScreenEffectHandle(long uniqueId, string niagaraPath)
		{
		}

		// Token: 0x06030E24 RID: 200228 RVA: 0x00DA25A8 File Offset: 0x00DA07A8
		public void SetFloatParameter(string key, float value)
		{
			this.FloatParameterMap[key] = value;
			EventSystem.Instance.Emit<long, string, float>(EEventName.OnChangeFullScreenNiagaraFloatParameter, this.UniqueId, key, value);
		}

		// Token: 0x06030E25 RID: 200229 RVA: 0x00DA25CF File Offset: 0x00DA07CF
		public IReadOnlyDictionary<string, float> GetFloatParameterMap()
		{
			return this.FloatParameterMap;
		}

		// Token: 0x04019F13 RID: 106259
		public readonly long UniqueId = uniqueId;

		// Token: 0x04019F14 RID: 106260
		public readonly string NiagaraPath = niagaraPath;

		// Token: 0x04019F15 RID: 106261
		private readonly Dictionary<string, float> FloatParameterMap = new Dictionary<string, float>();
	}
}
