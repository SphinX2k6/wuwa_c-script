using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.DigitalScreen
{
	// Token: 0x02006094 RID: 24724
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class DigitalScreenController : UiControllerBase
	{
		// Token: 0x0603B501 RID: 242945 RVA: 0x010C9A4C File Offset: 0x010C7C4C
		[NullableContext(0)]
		public UniTask<bool> OpenDigitalScreenById(int index, [Nullable(2)] object param = null, bool isPlot = false)
		{
			DigitalScreenController.<OpenDigitalScreenById>d__0 <OpenDigitalScreenById>d__;
			<OpenDigitalScreenById>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OpenDigitalScreenById>d__.index = index;
			<OpenDigitalScreenById>d__.param = param;
			<OpenDigitalScreenById>d__.isPlot = isPlot;
			<OpenDigitalScreenById>d__.<>1__state = -1;
			<OpenDigitalScreenById>d__.<>t__builder.Start<DigitalScreenController.<OpenDigitalScreenById>d__0>(ref <OpenDigitalScreenById>d__);
			return <OpenDigitalScreenById>d__.<>t__builder.Task;
		}

		// Token: 0x1700703E RID: 28734
		// (get) Token: 0x0603B502 RID: 242946 RVA: 0x010C9A9F File Offset: 0x010C7C9F
		public static DigitalScreenController Instance
		{
			get
			{
				return DigitalScreenController._Instance;
			}
		}

		// Token: 0x0603B503 RID: 242947 RVA: 0x010C9AA6 File Offset: 0x010C7CA6
		public static DigitalScreenController GetOrCreateInstance()
		{
			if (DigitalScreenController._Instance == null)
			{
				DigitalScreenController.CreateInstance();
			}
			return DigitalScreenController._Instance;
		}

		// Token: 0x0603B504 RID: 242948 RVA: 0x010C9ABA File Offset: 0x010C7CBA
		public static bool CreateInstance()
		{
			if (DigitalScreenController._Instance != null)
			{
				return true;
			}
			DigitalScreenController._Instance = new DigitalScreenController();
			return true;
		}

		// Token: 0x0603B505 RID: 242949 RVA: 0x010C9AD0 File Offset: 0x010C7CD0
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603B506 RID: 242950 RVA: 0x010C9AD2 File Offset: 0x010C7CD2
		public static void ResetStaticDefaultValue()
		{
			DigitalScreenController._Instance = null;
		}

		// Token: 0x0603B507 RID: 242951 RVA: 0x010C9ADA File Offset: 0x010C7CDA
		static DigitalScreenController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(DigitalScreenController.CreateStaticDefaultValue), new Action(DigitalScreenController.ResetStaticDefaultValue));
		}

		// Token: 0x0401F3F1 RID: 127985
		[Nullable(2)]
		private static DigitalScreenController _Instance;
	}
}
