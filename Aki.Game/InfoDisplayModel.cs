using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhoneMessage;

// Token: 0x02001453 RID: 5203
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class InfoDisplayModel : ModelBase
{
	// Token: 0x0600CEF5 RID: 52981 RVA: 0x003D8380 File Offset: 0x003D6580
	public void SetGroupInfo(List<int> infoIds)
	{
		this.GroupInfoIds = infoIds;
		this.GroupPageIndex = 0;
	}

	// Token: 0x0600CEF6 RID: 52982 RVA: 0x003D8390 File Offset: 0x003D6590
	public void ClearGroupInfo()
	{
		this.GroupInfoIds = new List<int>();
		this.GroupPageIndex = -1;
	}

	// Token: 0x0600CEF7 RID: 52983 RVA: 0x003D83A4 File Offset: 0x003D65A4
	public bool IsInGroupMode()
	{
		return this.GroupInfoIds.Count > 0;
	}

	// Token: 0x0600CEF8 RID: 52984 RVA: 0x003D83B4 File Offset: 0x003D65B4
	public int GetGroupPageCount()
	{
		return this.GroupInfoIds.Count;
	}

	// Token: 0x0600CEF9 RID: 52985 RVA: 0x003D83C1 File Offset: 0x003D65C1
	public int GetGroupPageIndex()
	{
		return this.GroupPageIndex;
	}

	// Token: 0x0600CEFA RID: 52986 RVA: 0x003D83CC File Offset: 0x003D65CC
	public int? GetGroupInfoIdByIndex(int index)
	{
		if (index < 0 || index >= this.GroupInfoIds.Count)
		{
			return null;
		}
		return new int?(this.GroupInfoIds[index]);
	}

	// Token: 0x0600CEFB RID: 52987 RVA: 0x003D8406 File Offset: 0x003D6606
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

	// Token: 0x0600CEFC RID: 52988 RVA: 0x003D8436 File Offset: 0x003D6636
	public EAttachmentType GetCurrentShowAttachmentType()
	{
		return this.CurrentShowAttachmentType;
	}

	// Token: 0x0600CEFD RID: 52989 RVA: 0x003D843E File Offset: 0x003D663E
	public void SetCurrentShowAttachmentType(EAttachmentType value)
	{
		this.CurrentShowAttachmentType = value;
	}

	// Token: 0x0600CEFE RID: 52990 RVA: 0x003D8447 File Offset: 0x003D6647
	public int CurrentInformationId()
	{
		return this.CurrentOpenId;
	}

	// Token: 0x0600CEFF RID: 52991 RVA: 0x003D844F File Offset: 0x003D664F
	public void SetCurrentOpenInformationId(int id)
	{
		this.CurrentOpenId = id;
	}

	// Token: 0x0600CF00 RID: 52992 RVA: 0x003D8458 File Offset: 0x003D6658
	public string GetExtraTopDesc()
	{
		return this.ExtraTopDesc;
	}

	// Token: 0x0600CF01 RID: 52993 RVA: 0x003D8460 File Offset: 0x003D6660
	[NullableContext(2)]
	public void SetExtraTopDesc(string value)
	{
		this.ExtraTopDesc = (value ?? "");
	}

	// Token: 0x0600CF02 RID: 52994 RVA: 0x003D8472 File Offset: 0x003D6672
	public string CurrentCurrentInformationTexture()
	{
		return this.CurrentDetailTexture;
	}

	// Token: 0x0600CF03 RID: 52995 RVA: 0x003D847A File Offset: 0x003D667A
	public void SetCurrentOpenInformationTexture(string path)
	{
		this.CurrentDetailTexture = path;
	}

	// Token: 0x0600CF04 RID: 52996 RVA: 0x003D8483 File Offset: 0x003D6683
	public void SetAnimName(string value)
	{
		this.AnimName = value;
	}

	// Token: 0x0600CF05 RID: 52997 RVA: 0x003D848C File Offset: 0x003D668C
	public string GetAnimName()
	{
		return this.AnimName;
	}

	// Token: 0x0600CF06 RID: 52998 RVA: 0x003D8494 File Offset: 0x003D6694
	public string GetCurrentShowSpineAtlasPath()
	{
		return this.CurrentSpineAtlasPath;
	}

	// Token: 0x0600CF07 RID: 52999 RVA: 0x003D849C File Offset: 0x003D669C
	public void SetCurrentShowSpineAtlasPath(string value)
	{
		this.CurrentSpineAtlasPath = value;
	}

	// Token: 0x0600CF08 RID: 53000 RVA: 0x003D84A5 File Offset: 0x003D66A5
	public string GetCurrentShowSpineDataPath()
	{
		return this.CurrentSpineDataPath;
	}

	// Token: 0x0600CF09 RID: 53001 RVA: 0x003D84AD File Offset: 0x003D66AD
	public void SetCurrentShowSpineDataPath(string value)
	{
		this.CurrentSpineDataPath = value;
	}

	// Token: 0x0600CF0A RID: 53002 RVA: 0x003D84B8 File Offset: 0x003D66B8
	public string ConvertToHourMinuteString(float second)
	{
		int num = (int)Math.Floor((double)(second / 60f));
		int num2 = (int)Math.Floor((double)(second - (float)(num * 60)));
		string text = "0" + num.ToString();
		string text2 = "0" + num2.ToString();
		return text.Substring(text.Length - 2) + ":" + text2.Substring(text2.Length - 2);
	}

	// Token: 0x1700136F RID: 4975
	// (get) Token: 0x0600CF0B RID: 53003 RVA: 0x003D852B File Offset: 0x003D672B
	public static InfoDisplayModel Instance
	{
		get
		{
			return InfoDisplayModel._Instance;
		}
	}

	// Token: 0x0600CF0C RID: 53004 RVA: 0x003D8532 File Offset: 0x003D6732
	public static InfoDisplayModel GetOrCreateInstance()
	{
		if (InfoDisplayModel._Instance == null)
		{
			InfoDisplayModel.CreateInstance();
		}
		return InfoDisplayModel._Instance;
	}

	// Token: 0x0600CF0D RID: 53005 RVA: 0x003D8546 File Offset: 0x003D6746
	public static bool CreateInstance()
	{
		if (InfoDisplayModel._Instance != null)
		{
			return true;
		}
		InfoDisplayModel._Instance = new InfoDisplayModel();
		return true;
	}

	// Token: 0x0600CF0E RID: 53006 RVA: 0x003D855C File Offset: 0x003D675C
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600CF0F RID: 53007 RVA: 0x003D855E File Offset: 0x003D675E
	public static void ResetStaticDefaultValue()
	{
		InfoDisplayModel._Instance = null;
	}

	// Token: 0x0600CF10 RID: 53008 RVA: 0x003D8566 File Offset: 0x003D6766
	static InfoDisplayModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(InfoDisplayModel.CreateStaticDefaultValue), new Action(InfoDisplayModel.ResetStaticDefaultValue));
	}

	// Token: 0x040075AA RID: 30122
	private int CurrentOpenId;

	// Token: 0x040075AB RID: 30123
	public EAttachmentType CurrentShowAttachmentType;

	// Token: 0x040075AC RID: 30124
	private string CurrentDetailTexture = "";

	// Token: 0x040075AD RID: 30125
	public string AnimName = "";

	// Token: 0x040075AE RID: 30126
	public string CurrentSpineAtlasPath = "";

	// Token: 0x040075AF RID: 30127
	public string CurrentSpineDataPath = "";

	// Token: 0x040075B0 RID: 30128
	private List<int> GroupInfoIds = new List<int>();

	// Token: 0x040075B1 RID: 30129
	private int GroupPageIndex = -1;

	// Token: 0x040075B2 RID: 30130
	private string ExtraTopDesc = "";

	// Token: 0x040075B3 RID: 30131
	[Nullable(2)]
	private static InfoDisplayModel _Instance;
}
