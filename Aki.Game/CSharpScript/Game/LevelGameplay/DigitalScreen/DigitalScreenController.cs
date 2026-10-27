using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.DigitalScreen
{
	// Token: 0x02006F13 RID: 28435
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class DigitalScreenController : UiControllerBase
	{
		// Token: 0x06045353 RID: 283475 RVA: 0x0111FAAC File Offset: 0x0111DCAC
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

		// Token: 0x17009AFF RID: 39679
		// (get) Token: 0x06045354 RID: 283476 RVA: 0x0111FAFF File Offset: 0x0111DCFF
		public static DigitalScreenController Instance
		{
			get
			{
				return DigitalScreenController._Instance;
			}
		}

		// Token: 0x06045355 RID: 283477 RVA: 0x0111FB06 File Offset: 0x0111DD06
		public static DigitalScreenController GetOrCreateInstance()
		{
			if (DigitalScreenController._Instance == null)
			{
				DigitalScreenController.CreateInstance();
			}
			return DigitalScreenController._Instance;
		}

		// Token: 0x06045356 RID: 283478 RVA: 0x0111FB1A File Offset: 0x0111DD1A
		public static bool CreateInstance()
		{
			if (DigitalScreenController._Instance != null)
			{
				return true;
			}
			DigitalScreenController._Instance = new DigitalScreenController();
			return true;
		}

		// Token: 0x06045357 RID: 283479 RVA: 0x0111FB30 File Offset: 0x0111DD30
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06045358 RID: 283480 RVA: 0x0111FB32 File Offset: 0x0111DD32
		public static void ResetStaticDefaultValue()
		{
			DigitalScreenController._Instance = null;
		}

		// Token: 0x06045359 RID: 283481 RVA: 0x0111FB3A File Offset: 0x0111DD3A
		static DigitalScreenController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(DigitalScreenController.CreateStaticDefaultValue), new Action(DigitalScreenController.ResetStaticDefaultValue));
		}

		// Token: 0x0402413C RID: 147772
		[Nullable(2)]
		private static DigitalScreenController _Instance;
	}
}
