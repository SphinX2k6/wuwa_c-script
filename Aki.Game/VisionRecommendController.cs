using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Google.Protobuf;

// Token: 0x0200192E RID: 6446
[NullableContext(1)]
[Nullable(0)]
public class VisionRecommendController : UiControllerBase
{
	// Token: 0x0600FEC6 RID: 65222 RVA: 0x004A6440 File Offset: 0x004A4640
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.OnRoleChangeEnd, new Action(this.OnMainRoleChanged));
		EventSystem.Instance.Add<int>(EEventName.RoleInfoUpdate, new Action<int>(this.OnRoleInfoUpdate));
		EventSystem.Instance.Add<int>(EEventName.ActiveRole, new Action<int>(this.OnActiveRole));
	}

	// Token: 0x0600FEC7 RID: 65223 RVA: 0x004A64A4 File Offset: 0x004A46A4
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnRoleChangeEnd, new Action(this.OnMainRoleChanged));
		EventSystem.Instance.Remove(EEventName.RoleInfoUpdate, new Action<int>(this.OnRoleInfoUpdate));
		EventSystem.Instance.Remove(EEventName.ActiveRole, new Action<int>(this.OnActiveRole));
	}

	// Token: 0x0600FEC8 RID: 65224 RVA: 0x004A6505 File Offset: 0x004A4705
	private void OnRoleInfoUpdate(int roleId)
	{
		this.RequestRoleVisionRecommendData(roleId);
		this.RequestRoleVisionRecommendAttr(roleId);
	}

	// Token: 0x0600FEC9 RID: 65225 RVA: 0x004A6518 File Offset: 0x004A4718
	private void OnMainRoleChanged()
	{
		int? curSelectMainRoleId = RoleModel.Instance.GetCurSelectMainRoleId();
		if (curSelectMainRoleId == null)
		{
			return;
		}
		VisionRecommendModel.Instance.ClearRoleRecommendData(curSelectMainRoleId.Value);
		this.RequestRoleVisionRecommendData(curSelectMainRoleId.Value);
		this.RequestRoleVisionRecommendAttr(curSelectMainRoleId.Value);
	}

	// Token: 0x0600FECA RID: 65226 RVA: 0x004A6565 File Offset: 0x004A4765
	private void OnActiveRole(int roleId)
	{
		this.RequestRoleVisionRecommendData(roleId);
		this.RequestRoleVisionRecommendAttr(roleId);
	}

	// Token: 0x0600FECB RID: 65227 RVA: 0x004A6578 File Offset: 0x004A4778
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

	// Token: 0x0600FECC RID: 65228 RVA: 0x004A65C4 File Offset: 0x004A47C4
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

	// Token: 0x17001860 RID: 6240
	// (get) Token: 0x0600FECD RID: 65229 RVA: 0x004A660D File Offset: 0x004A480D
	public static VisionRecommendController Instance
	{
		get
		{
			return VisionRecommendController._Instance;
		}
	}

	// Token: 0x0600FECE RID: 65230 RVA: 0x004A6614 File Offset: 0x004A4814
	public static VisionRecommendController GetOrCreateInstance()
	{
		if (VisionRecommendController._Instance == null)
		{
			VisionRecommendController.CreateInstance();
		}
		return VisionRecommendController._Instance;
	}

	// Token: 0x0600FECF RID: 65231 RVA: 0x004A6628 File Offset: 0x004A4828
	public static bool CreateInstance()
	{
		if (VisionRecommendController._Instance != null)
		{
			return true;
		}
		VisionRecommendController._Instance = new VisionRecommendController();
		return true;
	}

	// Token: 0x0600FED0 RID: 65232 RVA: 0x004A663E File Offset: 0x004A483E
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600FED1 RID: 65233 RVA: 0x004A6640 File Offset: 0x004A4840
	public static void ResetStaticDefaultValue()
	{
		VisionRecommendController._Instance = null;
	}

	// Token: 0x0600FED2 RID: 65234 RVA: 0x004A6648 File Offset: 0x004A4848
	static VisionRecommendController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(VisionRecommendController.CreateStaticDefaultValue), new Action(VisionRecommendController.ResetStaticDefaultValue));
	}

	// Token: 0x04008DA9 RID: 36265
	[Nullable(2)]
	private static VisionRecommendController _Instance;
}
