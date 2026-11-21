using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035E9 RID: 13801
	[NullableContext(1)]
	[Nullable(0)]
	public class LguiEventSystemController : ControllerBase
	{
		// Token: 0x0602325E RID: 143966 RVA: 0x009FD287 File Offset: 0x009FB487
		protected override bool OnInit()
		{
			this.AddEvents();
			return true;
		}

		// Token: 0x0602325F RID: 143967 RVA: 0x009FD290 File Offset: 0x009FB490
		protected override bool OnClear()
		{
			this.RemoveEvents();
			return true;
		}

		// Token: 0x06023260 RID: 143968 RVA: 0x009FD29C File Offset: 0x009FB49C
		private void AddEvents()
		{
			InputDistributeController.Instance.BindActions(new <>z__ReadOnlyArray<string>(new string[]
			{
				"UI左键点击",
				"UI右键点击"
			}), new TInputHandle<InputDistributeDefine.EActionType>(this.OnClickedMouse));
			InputDistributeController.Instance.BindAxis("WheelAxis", new TInputHandle<float>(this.OnInputWheelAxis));
		}

		// Token: 0x06023261 RID: 143969 RVA: 0x009FD2F8 File Offset: 0x009FB4F8
		private void RemoveEvents()
		{
			InputDistributeController.Instance.UnBindActions(new <>z__ReadOnlyArray<string>(new string[]
			{
				"UI左键点击",
				"UI右键点击"
			}), new TInputHandle<InputDistributeDefine.EActionType>(this.OnClickedMouse));
			InputDistributeController.Instance.UnBindAxis("WheelAxis", new TInputHandle<float>(this.OnInputWheelAxis));
		}

		// Token: 0x06023262 RID: 143970 RVA: 0x009FD351 File Offset: 0x009FB551
		private void OnClickedMouse(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification identification)
		{
			LguiEventSystemManager.Instance.ClickedMouse(actionName, actionType);
		}

		// Token: 0x06023263 RID: 143971 RVA: 0x009FD35F File Offset: 0x009FB55F
		private void OnInputWheelAxis(string axisName, float value, InputIdentification identification)
		{
			LguiEventSystemManager.Instance.InputWheelAxis(axisName, value);
		}

		// Token: 0x1700491E RID: 18718
		// (get) Token: 0x06023264 RID: 143972 RVA: 0x009FD36D File Offset: 0x009FB56D
		public static LguiEventSystemController Instance
		{
			get
			{
				return LguiEventSystemController._Instance;
			}
		}

		// Token: 0x06023265 RID: 143973 RVA: 0x009FD374 File Offset: 0x009FB574
		public static LguiEventSystemController GetOrCreateInstance()
		{
			if (LguiEventSystemController._Instance == null)
			{
				LguiEventSystemController.CreateInstance();
			}
			return LguiEventSystemController._Instance;
		}

		// Token: 0x06023266 RID: 143974 RVA: 0x009FD388 File Offset: 0x009FB588
		public static bool CreateInstance()
		{
			if (LguiEventSystemController._Instance != null)
			{
				return true;
			}
			LguiEventSystemController._Instance = new LguiEventSystemController();
			return true;
		}

		// Token: 0x06023267 RID: 143975 RVA: 0x009FD39E File Offset: 0x009FB59E
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06023268 RID: 143976 RVA: 0x009FD3A0 File Offset: 0x009FB5A0
		public static void ResetStaticDefaultValue()
		{
			LguiEventSystemController._Instance = null;
		}

		// Token: 0x06023269 RID: 143977 RVA: 0x009FD3A8 File Offset: 0x009FB5A8
		static LguiEventSystemController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LguiEventSystemController.CreateStaticDefaultValue), new Action(LguiEventSystemController.ResetStaticDefaultValue));
		}

		// Token: 0x04013D6A RID: 81258
		[Nullable(2)]
		private static LguiEventSystemController _Instance;
	}
}
