using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Render;

namespace CSharpScript.Game.Manager
{
	// Token: 0x02006948 RID: 26952
	[NullableContext(1)]
	[Nullable(0)]
	public class SwitcherManager : Singleton
	{
		// Token: 0x0604328B RID: 275083 RVA: 0x0105E7C0 File Offset: 0x0105C9C0
		public void Initialize()
		{
			this.AllSwitcher["特效生成Log"] = new ValueTuple<Func<bool>, Action<bool>>(() => EffectGlobal.Instance.EnableSpawnLog, delegate(bool value)
			{
				EffectGlobal.Instance.EnableSpawnLog = value;
			});
			this.AllSwitcher["打开TOD时间同步"] = new ValueTuple<Func<bool>, Action<bool>>(() => TimeOfDayController.Instance.IsSyncToEngine, delegate(bool value)
			{
				TimeOfDayController.Instance.IsSyncToEngine = value;
			});
		}

		// Token: 0x170097FC RID: 38908
		// (get) Token: 0x0604328C RID: 275084 RVA: 0x0105E873 File Offset: 0x0105CA73
		public static SwitcherManager Instance
		{
			get
			{
				if (SwitcherManager._instance == null)
				{
					SwitcherManager._instance = new SwitcherManager();
					SwitcherManager._instance.OnInit();
				}
				return SwitcherManager._instance;
			}
		}

		// Token: 0x0604328D RID: 275085 RVA: 0x0105E896 File Offset: 0x0105CA96
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0604328E RID: 275086 RVA: 0x0105E898 File Offset: 0x0105CA98
		public static void ResetStaticDefaultValue()
		{
			SwitcherManager instance = SwitcherManager._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			SwitcherManager._instance = null;
		}

		// Token: 0x0604328F RID: 275087 RVA: 0x0105E8B1 File Offset: 0x0105CAB1
		static SwitcherManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SwitcherManager.CreateStaticDefaultValue), new Action(SwitcherManager.ResetStaticDefaultValue));
		}

		// Token: 0x04022F9D RID: 143261
		[TupleElementNames(new string[]
		{
			"GetValue",
			"SetValue"
		})]
		[Nullable(new byte[]
		{
			1,
			1,
			0,
			1,
			1
		})]
		public readonly Dictionary<string, ValueTuple<Func<bool>, Action<bool>>> AllSwitcher = new Dictionary<string, ValueTuple<Func<bool>, Action<bool>>>();

		// Token: 0x04022F9E RID: 143262
		[Nullable(2)]
		private static SwitcherManager _instance;
	}
}
