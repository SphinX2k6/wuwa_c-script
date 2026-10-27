using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020046B8 RID: 18104
	[NullableContext(1)]
	[Nullable(0)]
	public class LguiEventSystemController : ControllerBase
	{
		// Token: 0x0602EB12 RID: 191250 RVA: 0x00ACE9B3 File Offset: 0x00ACCBB3
		protected override bool OnInit()
		{
			this.AddEvents();
			return true;
		}

		// Token: 0x0602EB13 RID: 191251 RVA: 0x00ACE9BC File Offset: 0x00ACCBBC
		protected override bool OnClear()
		{
			this.RemoveEvents();
			return true;
		}

		// Token: 0x0602EB14 RID: 191252 RVA: 0x00ACE9C8 File Offset: 0x00ACCBC8
		private void AddEvents()
		{
			InputDistributeController.Instance.BindActions(new <>z__ReadOnlyArray<string>(new string[]
			{
				"UI左键点击",
				"UI右键点击"
			}), new TInputHandle<InputDistributeDefine.EActionType>(this.OnClickedMouse));
			InputDistributeController.Instance.BindAxis("WheelAxis", new TInputHandle<float>(this.OnInputWheelAxis));
		}

		// Token: 0x0602EB15 RID: 191253 RVA: 0x00ACEA24 File Offset: 0x00ACCC24
		private void RemoveEvents()
		{
			InputDistributeController.Instance.UnBindActions(new <>z__ReadOnlyArray<string>(new string[]
			{
				"UI左键点击",
				"UI右键点击"
			}), new TInputHandle<InputDistributeDefine.EActionType>(this.OnClickedMouse));
			InputDistributeController.Instance.UnBindAxis("WheelAxis", new TInputHandle<float>(this.OnInputWheelAxis));
		}

		// Token: 0x0602EB16 RID: 191254 RVA: 0x00ACEA7D File Offset: 0x00ACCC7D
		private void OnClickedMouse(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification identification)
		{
			LguiEventSystemManager.Instance.ClickedMouse(actionName, actionType);
		}

		// Token: 0x0602EB17 RID: 191255 RVA: 0x00ACEA8B File Offset: 0x00ACCC8B
		private void OnInputWheelAxis(string axisName, float value, InputIdentification identification)
		{
			LguiEventSystemManager.Instance.InputWheelAxis(axisName, value);
		}

		// Token: 0x17007662 RID: 30306
		// (get) Token: 0x0602EB18 RID: 191256 RVA: 0x00ACEA99 File Offset: 0x00ACCC99
		public static LguiEventSystemController Instance
		{
			get
			{
				return LguiEventSystemController._Instance;
			}
		}

		// Token: 0x0602EB19 RID: 191257 RVA: 0x00ACEAA0 File Offset: 0x00ACCCA0
		public static LguiEventSystemController GetOrCreateInstance()
		{
			if (LguiEventSystemController._Instance == null)
			{
				LguiEventSystemController.CreateInstance();
			}
			return LguiEventSystemController._Instance;
		}

		// Token: 0x0602EB1A RID: 191258 RVA: 0x00ACEAB4 File Offset: 0x00ACCCB4
		public static bool CreateInstance()
		{
			if (LguiEventSystemController._Instance != null)
			{
				return true;
			}
			LguiEventSystemController._Instance = new LguiEventSystemController();
			return true;
		}

		// Token: 0x0602EB1B RID: 191259 RVA: 0x00ACEACA File Offset: 0x00ACCCCA
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602EB1C RID: 191260 RVA: 0x00ACEACC File Offset: 0x00ACCCCC
		public static void ResetStaticDefaultValue()
		{
			LguiEventSystemController._Instance = null;
		}

		// Token: 0x0602EB1D RID: 191261 RVA: 0x00ACEAD4 File Offset: 0x00ACCCD4
		static LguiEventSystemController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LguiEventSystemController.CreateStaticDefaultValue), new Action(LguiEventSystemController.ResetStaticDefaultValue));
		}

		// Token: 0x040196C5 RID: 104133
		[Nullable(2)]
		private static LguiEventSystemController _Instance;
	}
}
