using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Render;

namespace CSharpScript.Game.Manager
{
	// Token: 0x02005AA3 RID: 23203
	[NullableContext(1)]
	[Nullable(0)]
	public class SwitcherManager : Singleton
	{
		// Token: 0x060392C2 RID: 234178 RVA: 0x0100297C File Offset: 0x01000B7C
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

		// Token: 0x17006CDC RID: 27868
		// (get) Token: 0x060392C3 RID: 234179 RVA: 0x01002A2F File Offset: 0x01000C2F
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

		// Token: 0x060392C4 RID: 234180 RVA: 0x01002A52 File Offset: 0x01000C52
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060392C5 RID: 234181 RVA: 0x01002A54 File Offset: 0x01000C54
		public static void ResetStaticDefaultValue()
		{
			SwitcherManager instance = SwitcherManager._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			SwitcherManager._instance = null;
		}

		// Token: 0x060392C6 RID: 234182 RVA: 0x01002A6D File Offset: 0x01000C6D
		static SwitcherManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SwitcherManager.CreateStaticDefaultValue), new Action(SwitcherManager.ResetStaticDefaultValue));
		}

		// Token: 0x0401E187 RID: 123271
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

		// Token: 0x0401E188 RID: 123272
		[Nullable(2)]
		private static SwitcherManager _instance;
	}
}
