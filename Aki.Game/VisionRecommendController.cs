using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Google.Protobuf;

// Token: 0x02002449 RID: 9289
[NullableContext(1)]
[Nullable(0)]
public class VisionRecommendController : UiControllerBase
{
	// Token: 0x06012A10 RID: 76304 RVA: 0x00498E54 File Offset: 0x00497054
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.OnRoleChangeEnd, new Action(this.OnRoleInfoUpdate));
		EventSystem.Instance.Add(EEventName.RoleInfoUpdate, new Action(this.OnRoleInfoUpdate));
		EventSystem.Instance.Add<int>(EEventName.ActiveRole, new Action<int>(this.OnActiveRole));
	}

	// Token: 0x06012A11 RID: 76305 RVA: 0x00498EB8 File Offset: 0x004970B8
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnRoleChangeEnd, new Action(this.OnRoleInfoUpdate));
		EventSystem.Instance.Remove(EEventName.RoleInfoUpdate, new Action(this.OnRoleInfoUpdate));
		EventSystem.Instance.Remove(EEventName.ActiveRole, new Action<int>(this.OnActiveRole));
	}

	// Token: 0x06012A12 RID: 76306 RVA: 0x00498F1C File Offset: 0x0049711C
	private void OnRoleInfoUpdate()
	{
		foreach (RoleInstance roleInstance in RoleModel.Instance.GetRoleList())
		{
			this.RequestRoleVisionRecommendData(roleInstance.GetRoleId());
			this.RequestRoleVisionRecommendAttr(roleInstance.GetRoleId());
		}
	}

	// Token: 0x06012A13 RID: 76307 RVA: 0x00498F5E File Offset: 0x0049715E
	private void OnActiveRole(int roleId)
	{
		this.RequestRoleVisionRecommendData(roleId);
		this.RequestRoleVisionRecommendAttr(roleId);
	}

	// Token: 0x06012A14 RID: 76308 RVA: 0x00498F70 File Offset: 0x00497170
	public void RequestRoleVisionRecommendData(int roleId)
	{
		PhantomFetterRecommendRequest phantomFetterRecommendRequest = PhantomFetterRecommendRequest.Create();
		phantomFetterRecommendRequest.RoleId = roleId;
		Net.Instance.Call(ERequestMessageId.PhantomFetterRecommendRequest, phantomFetterRecommendRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			PhantomFetterRecommendResponse data = (PhantomFetterRecommendResponse)msg;
			VisionRecommendModel.Instance.OnRoleRecommendData(roleId, data);
		}, 0);
	}

	// Token: 0x06012A15 RID: 76309 RVA: 0x00498FBC File Offset: 0x004971BC
	public void RequestRoleVisionRecommendAttr(int roleId)
	{
		PhantomAttrRecommendRequest phantomAttrRecommendRequest = PhantomAttrRecommendRequest.Create();
		phantomAttrRecommendRequest.RoleId = roleId;
		Net.Instance.Call(ERequestMessageId.PhantomAttrRecommendRequest, phantomAttrRecommendRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			PhantomAttrRecommendResponse data = (PhantomAttrRecommendResponse)msg;
			VisionRecommendModel.Instance.OnRoleRecommendAttrData(roleId, data);
		}, 0);
	}

	// Token: 0x17001826 RID: 6182
	// (get) Token: 0x06012A16 RID: 76310 RVA: 0x00499005 File Offset: 0x00497205
	public static VisionRecommendController Instance
	{
		get
		{
			return VisionRecommendController._Instance;
		}
	}

	// Token: 0x06012A17 RID: 76311 RVA: 0x0049900C File Offset: 0x0049720C
	public static VisionRecommendController GetOrCreateInstance()
	{
		if (VisionRecommendController._Instance == null)
		{
			VisionRecommendController.CreateInstance();
		}
		return VisionRecommendController._Instance;
	}

	// Token: 0x06012A18 RID: 76312 RVA: 0x00499020 File Offset: 0x00497220
	public static bool CreateInstance()
	{
		if (VisionRecommendController._Instance != null)
		{
			return true;
		}
		VisionRecommendController._Instance = new VisionRecommendController();
		return true;
	}

	// Token: 0x06012A19 RID: 76313 RVA: 0x00499036 File Offset: 0x00497236
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06012A1A RID: 76314 RVA: 0x00499038 File Offset: 0x00497238
	public static void ResetStaticDefaultValue()
	{
		VisionRecommendController._Instance = null;
	}

	// Token: 0x06012A1B RID: 76315 RVA: 0x00499040 File Offset: 0x00497240
	static VisionRecommendController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(VisionRecommendController.CreateStaticDefaultValue), new Action(VisionRecommendController.ResetStaticDefaultValue));
	}

	// Token: 0x04008C62 RID: 35938
	[Nullable(2)]
	private static VisionRecommendController _Instance;
}
