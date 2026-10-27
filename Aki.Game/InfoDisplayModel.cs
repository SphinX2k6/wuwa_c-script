using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhoneMessage;

// Token: 0x02001F91 RID: 8081
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class InfoDisplayModel : ModelBase
{
	// Token: 0x0600FAD6 RID: 64214 RVA: 0x003CC84C File Offset: 0x003CAA4C
	public void SetGroupInfo(List<int> infoIds)
	{
		this.GroupInfoIds = infoIds;
		this.GroupPageIndex = 0;
	}

	// Token: 0x0600FAD7 RID: 64215 RVA: 0x003CC85C File Offset: 0x003CAA5C
	public void ClearGroupInfo()
	{
		this.GroupInfoIds = new List<int>();
		this.GroupPageIndex = -1;
	}

	// Token: 0x0600FAD8 RID: 64216 RVA: 0x003CC870 File Offset: 0x003CAA70
	public bool IsInGroupMode()
	{
		return this.GroupInfoIds.Count > 0;
	}

	// Token: 0x0600FAD9 RID: 64217 RVA: 0x003CC880 File Offset: 0x003CAA80
	public int GetGroupPageCount()
	{
		return this.GroupInfoIds.Count;
	}

	// Token: 0x0600FADA RID: 64218 RVA: 0x003CC88D File Offset: 0x003CAA8D
	public int GetGroupPageIndex()
	{
		return this.GroupPageIndex;
	}

	// Token: 0x0600FADB RID: 64219 RVA: 0x003CC898 File Offset: 0x003CAA98
	public int? GetGroupInfoIdByIndex(int index)
	{
		if (index < 0 || index >= this.GroupInfoIds.Count)
		{
			return null;
		}
		return new int?(this.GroupInfoIds[index]);
	}

	// Token: 0x0600FADC RID: 64220 RVA: 0x003CC8D2 File Offset: 0x003CAAD2
	public bool SetGroupPageIndex(int index)
	{
		if (index < 0 || index >= this.GroupInfoIds.Count)
		{
			return false;
		}
		this.GroupPageIndex = index;
		this.CurrentOpenId = this.GroupInfoIds[index];
		return true;
	}

	// Token: 0x0600FADD RID: 64221 RVA: 0x003CC902 File Offset: 0x003CAB02
	public EAttachmentType GetCurrentShowAttachmentType()
	{
		return this.CurrentShowAttachmentType;
	}

	// Token: 0x0600FADE RID: 64222 RVA: 0x003CC90A File Offset: 0x003CAB0A
	public void SetCurrentShowAttachmentType(EAttachmentType value)
	{
		this.CurrentShowAttachmentType = value;
	}

	// Token: 0x0600FADF RID: 64223 RVA: 0x003CC913 File Offset: 0x003CAB13
	public int CurrentInformationId()
	{
		return this.CurrentOpenId;
	}

	// Token: 0x0600FAE0 RID: 64224 RVA: 0x003CC91B File Offset: 0x003CAB1B
	public void SetCurrentOpenInformationId(int id)
	{
		this.CurrentOpenId = id;
	}

	// Token: 0x0600FAE1 RID: 64225 RVA: 0x003CC924 File Offset: 0x003CAB24
	public string CurrentCurrentInformationTexture()
	{
		return this.CurrentDetailTexture;
	}

	// Token: 0x0600FAE2 RID: 64226 RVA: 0x003CC92C File Offset: 0x003CAB2C
	public void SetCurrentOpenInformationTexture(string path)
	{
		this.CurrentDetailTexture = path;
	}

	// Token: 0x0600FAE3 RID: 64227 RVA: 0x003CC935 File Offset: 0x003CAB35
	public void SetAnimName(string value)
	{
		this.AnimName = value;
	}

	// Token: 0x0600FAE4 RID: 64228 RVA: 0x003CC93E File Offset: 0x003CAB3E
	public string GetAnimName()
	{
		return this.AnimName;
	}

	// Token: 0x0600FAE5 RID: 64229 RVA: 0x003CC946 File Offset: 0x003CAB46
	public string GetCurrentShowSpineAtlasPath()
	{
		return this.CurrentSpineAtlasPath;
	}

	// Token: 0x0600FAE6 RID: 64230 RVA: 0x003CC94E File Offset: 0x003CAB4E
	public void SetCurrentShowSpineAtlasPath(string value)
	{
		this.CurrentSpineAtlasPath = value;
	}

	// Token: 0x0600FAE7 RID: 64231 RVA: 0x003CC957 File Offset: 0x003CAB57
	public string GetCurrentShowSpineDataPath()
	{
		return this.CurrentSpineDataPath;
	}

	// Token: 0x0600FAE8 RID: 64232 RVA: 0x003CC95F File Offset: 0x003CAB5F
	public void SetCurrentShowSpineDataPath(string value)
	{
		this.CurrentSpineDataPath = value;
	}

	// Token: 0x0600FAE9 RID: 64233 RVA: 0x003CC968 File Offset: 0x003CAB68
	public string ConvertToHourMinuteString(float second)
	{
		int num = (int)Math.Floor((double)(second / 60f));
		int num2 = (int)Math.Floor((double)(second - (float)(num * 60)));
		string text = "0" + num.ToString();
		string text2 = "0" + num2.ToString();
		return text.Substring(text.Length - 2) + ":" + text2.Substring(text2.Length - 2);
	}

	// Token: 0x17001345 RID: 4933
	// (get) Token: 0x0600FAEA RID: 64234 RVA: 0x003CC9DB File Offset: 0x003CABDB
	public static InfoDisplayModel Instance
	{
		get
		{
			return InfoDisplayModel._Instance;
		}
	}

	// Token: 0x0600FAEB RID: 64235 RVA: 0x003CC9E2 File Offset: 0x003CABE2
	public static InfoDisplayModel GetOrCreateInstance()
	{
		if (InfoDisplayModel._Instance == null)
		{
			InfoDisplayModel.CreateInstance();
		}
		return InfoDisplayModel._Instance;
	}

	// Token: 0x0600FAEC RID: 64236 RVA: 0x003CC9F6 File Offset: 0x003CABF6
	public static bool CreateInstance()
	{
		if (InfoDisplayModel._Instance != null)
		{
			return true;
		}
		InfoDisplayModel._Instance = new InfoDisplayModel();
		return true;
	}

	// Token: 0x0600FAED RID: 64237 RVA: 0x003CCA0C File Offset: 0x003CAC0C
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600FAEE RID: 64238 RVA: 0x003CCA0E File Offset: 0x003CAC0E
	public static void ResetStaticDefaultValue()
	{
		InfoDisplayModel._Instance = null;
	}

	// Token: 0x0600FAEF RID: 64239 RVA: 0x003CCA16 File Offset: 0x003CAC16
	static InfoDisplayModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(InfoDisplayModel.CreateStaticDefaultValue), new Action(InfoDisplayModel.ResetStaticDefaultValue));
	}

	// Token: 0x040074C9 RID: 29897
	private int CurrentOpenId;

	// Token: 0x040074CA RID: 29898
	public EAttachmentType CurrentShowAttachmentType;

	// Token: 0x040074CB RID: 29899
	private string CurrentDetailTexture = "";

	// Token: 0x040074CC RID: 29900
	public string AnimName = "";

	// Token: 0x040074CD RID: 29901
	public string CurrentSpineAtlasPath = "";

	// Token: 0x040074CE RID: 29902
	public string CurrentSpineDataPath = "";

	// Token: 0x040074CF RID: 29903
	private List<int> GroupInfoIds = new List<int>();

	// Token: 0x040074D0 RID: 29904
	private int GroupPageIndex = -1;

	// Token: 0x040074D1 RID: 29905
	[Nullable(2)]
	private static InfoDisplayModel _Instance;
}
