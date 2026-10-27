using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;

// Token: 0x020021CC RID: 8652
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class MailModel : ModelBase
{
	// Token: 0x06010D4E RID: 68942 RVA: 0x00416D94 File Offset: 0x00414F94
	public int GetFavoriteMailCount()
	{
		int num = 0;
		using (Dictionary<string, MailData>.ValueCollection.Enumerator enumerator = this.MailMap.Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.IsFavorite)
				{
					num++;
				}
			}
		}
		return num;
	}

	// Token: 0x06010D4F RID: 68943 RVA: 0x00416DF4 File Offset: 0x00414FF4
	public int GetFavoriteMailCapacity()
	{
		return MailConfig.Instance.GetFavoriteMailSize().GetValueOrDefault();
	}

	// Token: 0x06010D50 RID: 68944 RVA: 0x00416E13 File Offset: 0x00415013
	public bool IsFavoriteMailFull()
	{
		return this.GetFavoriteMailCount() >= this.GetFavoriteMailCapacity();
	}

	// Token: 0x06010D51 RID: 68945 RVA: 0x00416E28 File Offset: 0x00415028
	public bool IsFavoriteMailSpaceNearFull()
	{
		double favoriteMailCapacity = (double)this.GetFavoriteMailCapacity();
		int mailSpaceWarningThresholdRate = MailConfig.Instance.GetMailSpaceWarningThresholdRate();
		int num = (int)Math.Floor(favoriteMailCapacity * (double)mailSpaceWarningThresholdRate / 100.0);
		return this.GetFavoriteMailCount() >= num;
	}

	// Token: 0x06010D52 RID: 68946 RVA: 0x00416E66 File Offset: 0x00415066
	public bool IsMailFavorite(string mailId)
	{
		MailData mailInstanceById = this.GetMailInstanceById(mailId);
		return mailInstanceById != null && mailInstanceById.IsFavorite;
	}

	// Token: 0x06010D53 RID: 68947 RVA: 0x00416E7A File Offset: 0x0041507A
	public int GetMailSpaceWarningThreshold()
	{
		return MailConfig.Instance.GetMailSpaceWarningThreshold();
	}

	// Token: 0x06010D54 RID: 68948 RVA: 0x00416E86 File Offset: 0x00415086
	public bool IsMailSpaceNearFull()
	{
		return this.GetMailListLength() >= this.GetMailSpaceWarningThreshold();
	}

	// Token: 0x06010D55 RID: 68949 RVA: 0x00416E99 File Offset: 0x00415099
	public bool CanRequestMailFavorite(string mailId, bool isFavorite)
	{
		if (this.GetMailInstanceById(mailId) == null)
		{
			return false;
		}
		if (isFavorite)
		{
			if (this.IsMailFavorite(mailId))
			{
				return false;
			}
			if (this.IsFavoriteMailFull())
			{
				return false;
			}
		}
		else if (!this.IsMailFavorite(mailId))
		{
			return false;
		}
		return true;
	}

	// Token: 0x06010D56 RID: 68950 RVA: 0x00416ECC File Offset: 0x004150CC
	public void ApplyMailFavoriteResponse(string mailId, bool isFavorite, int state, long expiryTime)
	{
		MailData mailInstanceById = this.GetMailInstanceById(mailId);
		if (mailInstanceById == null)
		{
			return;
		}
		if (isFavorite && mailInstanceById.IsIntervalMail)
		{
			mailInstanceById.IntervalExpiryTime = mailInstanceById.ExpiryTime;
		}
		mailInstanceById.ExpiryTime = expiryTime;
		this.SetMailStatusByStatusCode(state, mailInstanceById);
		EventSystem.Instance.Emit<string, bool>(EEventName.MailFavoriteChanged, mailId, isFavorite);
	}

	// Token: 0x06010D57 RID: 68951 RVA: 0x00416F20 File Offset: 0x00415120
	private void UpdateUnFinishedMailCountByMail(MailData mail)
	{
		if (!mail.GetWasScanned() || mail.GetAttachmentStatus() == EMailAttachment.AttachmentRemained)
		{
			if (this.UnFinishedMailSet.Contains(mail.Id))
			{
				EventSystem.Instance.Emit(EEventName.SwitchUnfinishedFlag);
				return;
			}
			this.UnFinishedMailSet.Add(mail.Id);
		}
		else
		{
			if (!this.UnFinishedMailSet.Contains(mail.Id))
			{
				EventSystem.Instance.Emit(EEventName.SwitchUnfinishedFlag);
				return;
			}
			this.UnFinishedMailSet.Remove(mail.Id);
		}
		EventSystem.Instance.Emit(EEventName.SwitchUnfinishedFlag);
	}

	// Token: 0x06010D58 RID: 68952 RVA: 0x00416FBC File Offset: 0x004151BC
	public bool GetRedDotCouldLightOn()
	{
		return this.UnFinishedMailSet.Count > 0 && this.CheckOpenCondition();
	}

	// Token: 0x06010D59 RID: 68953 RVA: 0x00416FD4 File Offset: 0x004151D4
	public bool UnScannedRedPoint()
	{
		if (!this.CheckOpenCondition())
		{
			return false;
		}
		bool result = false;
		if (this.MailMap.Count > 0)
		{
			using (Dictionary<string, MailData>.ValueCollection.Enumerator enumerator = this.MailMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (!enumerator.Current.GetWasScanned())
					{
						result = true;
						break;
					}
				}
			}
		}
		return result;
	}

	// Token: 0x06010D5A RID: 68954 RVA: 0x0041704C File Offset: 0x0041524C
	public bool GetRedDotImportant()
	{
		if (!this.CheckOpenCondition())
		{
			return false;
		}
		bool result = false;
		if (this.UnFinishedMailSet.Count > 0)
		{
			foreach (string id in this.UnFinishedMailSet)
			{
				if (this.GetMailInstanceById(id).GetMailLevel() == 2)
				{
					result = true;
					break;
				}
			}
		}
		return result;
	}

	// Token: 0x06010D5B RID: 68955 RVA: 0x004170C8 File Offset: 0x004152C8
	public List<TItem> GetLastPickedAttachments()
	{
		List<TItem> list = new List<TItem>();
		foreach (MailAttachmentData mailAttachmentData in this.LastPickedAttachments)
		{
			InventoryDefine.IGetItemData itemData = new InventoryDefine.GetItemData(mailAttachmentData.GetItemId(), 0);
			TItem item = new TItem(itemData, mailAttachmentData.GetCount());
			list.Add(item);
		}
		return list;
	}

	// Token: 0x06010D5C RID: 68956 RVA: 0x00417140 File Offset: 0x00415340
	public void SetLastPickedAttachments(Dictionary<string, int> successIdMap, EMailAttachmentPickType pickType)
	{
		this.ClearLastPickedAttachments();
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		foreach (string text in successIdMap.Keys)
		{
			MailData mailInstanceById = this.GetMailInstanceById(text);
			foreach (PbMailAttachment pbMailAttachment in mailInstanceById.GetAttachmentInfo())
			{
				int? num = dictionary.ContainsKey(pbMailAttachment.Id) ? new int?(dictionary[pbMailAttachment.Id]) : null;
				int value = pbMailAttachment.Count + num.GetValueOrDefault();
				dictionary[pbMailAttachment.Id] = value;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Mail;
			ELogAuthor author = ELogAuthor.YZY;
			string message = "邮件数据：领取邮件奖励";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("key", text);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.SetMailStatusByStatusCode(successIdMap[text], mailInstanceById);
		}
		foreach (KeyValuePair<int, int> keyValuePair in dictionary)
		{
			this.LastPickedAttachments.Add(new MailAttachmentData(keyValuePair.Key, keyValuePair.Value, true));
		}
		EventSystem.Instance.Emit<EMailAttachmentPickType>(EEventName.PickingAttachment, pickType);
	}

	// Token: 0x06010D5D RID: 68957 RVA: 0x004172B8 File Offset: 0x004154B8
	public void ClearLastPickedAttachments()
	{
		this.LastPickedAttachments.Clear();
	}

	// Token: 0x06010D5E RID: 68958 RVA: 0x004172C5 File Offset: 0x004154C5
	public string GetCurrentSelectMailId()
	{
		return this.CurrentSelectMailId;
	}

	// Token: 0x06010D5F RID: 68959 RVA: 0x004172CD File Offset: 0x004154CD
	public void SetCurrentSelectMailId(string newMailId)
	{
		this.CurrentSelectMailId = newMailId;
	}

	// Token: 0x06010D60 RID: 68960 RVA: 0x004172D6 File Offset: 0x004154D6
	public void OpenWebBrowser(string url)
	{
		if (string.IsNullOrEmpty(url))
		{
			return;
		}
		KuroSdkController.Instance.OpenExternalUrl(url);
	}

	// Token: 0x06010D61 RID: 68961 RVA: 0x004172EC File Offset: 0x004154EC
	private int MailSort(MailData mailDataA, MailData mailDataB)
	{
		if (mailDataA.GetWasScanned() != mailDataB.GetWasScanned())
		{
			if (!mailDataA.GetWasScanned())
			{
				return -1;
			}
			return 1;
		}
		else if (mailDataA.GetAttachmentStatus() != mailDataB.GetAttachmentStatus())
		{
			if (mailDataA.GetAttachmentStatus() >= mailDataB.GetAttachmentStatus())
			{
				return -1;
			}
			return 1;
		}
		else if (mailDataA.GetMailLevel() != mailDataB.GetMailLevel())
		{
			if (mailDataA.GetMailLevel() >= mailDataB.GetMailLevel())
			{
				return -1;
			}
			return 1;
		}
		else
		{
			if (mailDataA.GetReceiveTime() == mailDataB.GetReceiveTime())
			{
				return 1;
			}
			if (mailDataA.GetReceiveTime() >= mailDataB.GetReceiveTime())
			{
				return -1;
			}
			return 1;
		}
	}

	// Token: 0x06010D62 RID: 68962 RVA: 0x00417374 File Offset: 0x00415574
	public void ReloadMailList()
	{
		this.MailList.Clear();
		foreach (MailData item in this.MailMap.Values)
		{
			this.MailList.Add(item);
		}
		List<MailData> collection = this.MailList.OrderBy((MailData mail) => mail, Comparer<MailData>.Create(new Comparison<MailData>(this.MailSort))).ToList<MailData>();
		this.MailList.Clear();
		this.MailList.AddRange(collection);
	}

	// Token: 0x06010D63 RID: 68963 RVA: 0x00417434 File Offset: 0x00415634
	public List<MailData> GetMailList()
	{
		return this.MailList;
	}

	// Token: 0x06010D64 RID: 68964 RVA: 0x0041743C File Offset: 0x0041563C
	private void SetValueOfMailList(MailData mail)
	{
		this.MailMap[mail.Id] = mail;
	}

	// Token: 0x06010D65 RID: 68965 RVA: 0x00417450 File Offset: 0x00415650
	public void DeleteMail(string mailId)
	{
		if (this.GetMailInstanceById(mailId) == null)
		{
			return;
		}
		if (this.UnFinishedMailSet.Contains(mailId))
		{
			this.UnFinishedMailSet.Remove(mailId);
			EventSystem.Instance.Emit(EEventName.SwitchUnfinishedFlag);
		}
		this.MailMap.Remove(mailId);
		this.ReloadMailList();
	}

	// Token: 0x06010D66 RID: 68966 RVA: 0x004174A5 File Offset: 0x004156A5
	public int GetMailListLength()
	{
		return this.MailMap.Count;
	}

	// Token: 0x06010D67 RID: 68967 RVA: 0x004174B4 File Offset: 0x004156B4
	public MailData GetMailInstanceById(string id)
	{
		MailData result;
		this.MailMap.TryGetValue(id, out result);
		return result;
	}

	// Token: 0x06010D68 RID: 68968 RVA: 0x004174D4 File Offset: 0x004156D4
	public void AddMail(PbMailInfo mailInfo, bool reloadList = true)
	{
		if (this.MailMap.Count >= this.GetMailCapacity())
		{
			Log.Instance.Error(ELogModule.Mail, ELogAuthor.YZY, "后端新增邮件时超出容量！", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		this.MakeMailInstance(mailInfo);
		if (reloadList)
		{
			this.ReloadMailList();
		}
	}

	// Token: 0x06010D69 RID: 68969 RVA: 0x00417520 File Offset: 0x00415720
	public void OnMailInfoSynced(MailInfosNotify response)
	{
		foreach (PbMailInfo other in response.MailInfos)
		{
			if (MailModel.Instance.GetMailListLength() >= MailModel.Instance.GetMailCapacity())
			{
				Log.Instance.Error(ELogModule.Mail, ELogAuthor.YZY, "[MailError]MailBox is fulfilled", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			PbMailInfo pbMailInfo = PbMailInfo.Create();
			pbMailInfo.MergeFrom(other);
			this.AddMail(pbMailInfo, false);
		}
		this.ReloadMailList();
	}

	// Token: 0x06010D6A RID: 68970 RVA: 0x004175B4 File Offset: 0x004157B4
	public int GetMailCapacity()
	{
		if (this.MailCapacity != null)
		{
			return this.MailCapacity.Value;
		}
		int? mailSize = MailConfig.Instance.GetMailSize();
		int? num = mailSize;
		int num2 = 0;
		if (num.GetValueOrDefault() > num2 & num != null)
		{
			this.MailCapacity = mailSize;
			return this.MailCapacity.Value;
		}
		return 0;
	}

	// Token: 0x06010D6B RID: 68971 RVA: 0x00417614 File Offset: 0x00415814
	private string GenerateOverLimitMailIdSuffix(long timeStamp)
	{
		DateTime localDateTime = DateTimeOffset.FromUnixTimeMilliseconds(timeStamp * (long)TimeUtil.Instance.InverseMillisecond).LocalDateTime;
		string text = TimeUtil.Instance.DateFormat4(localDateTime);
		int num = 1;
		if (this.DayToSpecialMailCount.ContainsKey(text))
		{
			num = this.DayToSpecialMailCount[text];
			num++;
		}
		this.DayToSpecialMailCount[text] = num;
		string str = this.FormatIdStringByLength(num, 3);
		return " " + text + " " + str;
	}

	// Token: 0x06010D6C RID: 68972 RVA: 0x00417694 File Offset: 0x00415894
	private string FormatIdStringByLength(int id, int length)
	{
		return (new string('0', length) + ((double)id % Math.Pow(10.0, (double)length)).ToString()).Substring(Math.Max(0, (new string('0', length) + ((double)id % Math.Pow(10.0, (double)length)).ToString()).Length - length));
	}

	// Token: 0x06010D6D RID: 68973 RVA: 0x00417704 File Offset: 0x00415904
	private unsafe void MakeMailInstance(PbMailInfo mailInformation)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Mail;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "邮件数据：创建邮件 ";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("mailInformation.Id", mailInformation.Id);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		int state = mailInformation.State;
		MailData mailData = new MailData();
		ObjectUtils.CopyValue(mailInformation, mailData);
		mailData.Id = mailInformation.Id;
		mailData.ConfigId = mailInformation.ConfigId;
		long receivedTime = mailInformation.ReceivedTime;
		mailData.Time = (int)(receivedTime & (long)((ulong)-1));
		mailData.Level = (int)mailInformation.Level;
		mailData.Title = mailInformation.Title;
		mailData.SetText(mailInformation.Content);
		MailConfig.Instance.ApplyTemplateJumpId(mailData);
		mailData.Sender = mailInformation.Sender;
		mailData.ExpiryTime = MathUtils.Instance.LongToBigInt(mailInformation.ExpiryTime);
		mailData.IsIntervalMail = mailInformation.IsIntervalMail;
		mailData.AttachmentInfos = mailInformation.Attachments.ToArray<PbMailAttachment>();
		mailData.ReadTime = MathUtils.Instance.LongToNumber(mailInformation.ReadTime);
		this.AddSpecialMail(mailData);
		this.SetValueOfMailList(mailData);
		this.SetMailStatusByStatusCode(state, mailData);
		if (mailData.IsIntervalMail && !mailData.IsFavorite)
		{
			mailData.IntervalExpiryTime = mailData.ExpiryTime;
		}
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.Mail;
		ELogAuthor author2 = ELogAuthor.YZY;
		string message2 = "邮件数据：创建邮件成功： ";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("newMail.Id", mailData.Id);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("title", mailData.Title);
		instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
	}

	// Token: 0x06010D6E RID: 68974 RVA: 0x00417890 File Offset: 0x00415A90
	public bool IfNeedShowNewMail()
	{
		Dictionary<string, bool> dictionary = LocalStorage.GetPlayer<Dictionary<string, bool>>(ELocalStoragePlayerKey.HasShowNewMailTipsMap, null) ?? new Dictionary<string, bool>();
		foreach (KeyValuePair<string, MailData> keyValuePair in this.MailMap)
		{
			bool flag;
			if (keyValuePair.Value.GetIfShowNewMail() && (!dictionary.TryGetValue(keyValuePair.Key, out flag) || !flag))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06010D6F RID: 68975 RVA: 0x00417918 File Offset: 0x00415B18
	public void SaveShowNewMailMap()
	{
		Dictionary<string, bool> dictionary = LocalStorage.GetPlayer<Dictionary<string, bool>>(ELocalStoragePlayerKey.HasShowNewMailTipsMap, null) ?? new Dictionary<string, bool>();
		foreach (KeyValuePair<string, MailData> keyValuePair in this.MailMap)
		{
			dictionary[keyValuePair.Key] = true;
		}
		LocalStorage.SetPlayer<Dictionary<string, bool>>(ELocalStoragePlayerKey.HasShowNewMailTipsMap, dictionary);
	}

	// Token: 0x06010D70 RID: 68976 RVA: 0x00417990 File Offset: 0x00415B90
	public void RefreshLocalNewMailMap()
	{
		Dictionary<string, bool> dictionary = LocalStorage.GetPlayer<Dictionary<string, bool>>(ELocalStoragePlayerKey.HasShowNewMailTipsMap, null) ?? new Dictionary<string, bool>();
		List<string> list = new List<string>();
		foreach (KeyValuePair<string, bool> keyValuePair in dictionary)
		{
			if (!this.MailMap.ContainsKey(keyValuePair.Key))
			{
				list.Add(keyValuePair.Key);
			}
		}
		foreach (string key in list)
		{
			dictionary.Remove(key);
		}
		foreach (KeyValuePair<string, MailData> keyValuePair2 in this.MailMap)
		{
			bool flag;
			if (keyValuePair2.Value.GetIfShowNewMail() && (!dictionary.TryGetValue(keyValuePair2.Key, out flag) || !flag))
			{
				dictionary[keyValuePair2.Key] = false;
			}
		}
		LocalStorage.SetPlayer<Dictionary<string, bool>>(ELocalStoragePlayerKey.HasShowNewMailTipsMap, dictionary);
	}

	// Token: 0x06010D71 RID: 68977 RVA: 0x00417AC8 File Offset: 0x00415CC8
	private void AddSpecialMail(MailData mailData)
	{
		EMailConfigType configId = (EMailConfigType)mailData.ConfigId;
		if (configId == EMailConfigType.BackpackOverLimitMail || configId == EMailConfigType.BackpackOverLimitWithCurrencyMail)
		{
			string str = this.GenerateOverLimitMailIdSuffix((long)mailData.Time);
			mailData.Title += str;
		}
	}

	// Token: 0x06010D72 RID: 68978 RVA: 0x00417B04 File Offset: 0x00415D04
	public unsafe void SetMailStatusByStatusCode(int state, MailData mailInstance)
	{
		bool flag = (state & 1) != 0;
		bool flag2 = (state & 2) != 0;
		bool favorite = (state & 4) != 0;
		EMailAttachment emailAttachment = EMailAttachment.NoneAttachment;
		if (mailInstance.AttachmentInfos.Length == 0)
		{
			emailAttachment = EMailAttachment.NoneAttachment;
		}
		else if (mailInstance.AttachmentInfos.Length != 0)
		{
			emailAttachment = (flag2 ? EMailAttachment.AttachmentPicked : EMailAttachment.AttachmentRemained);
		}
		mailInstance.SetWasScanned((flag > false) ? 1 : 0);
		mailInstance.SetAttachmentStatus(emailAttachment);
		mailInstance.SetFavorite(favorite);
		this.UpdateUnFinishedMailCountByMail(mailInstance);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Mail;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "邮件数据：邮件状态改变";
		<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("SetMailStatusByStatusCode:", emailAttachment);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("id:", mailInstance.Id);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("scanned:", flag);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("taken:", flag2);
		ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4);
		string item = "this.UnFinishedMailSet.length";
		HashSet<string> unFinishedMailSet = this.UnFinishedMailSet;
		ptr = new ValueTuple<string, object>(item, (unFinishedMailSet != null) ? new int?(unFinishedMailSet.Count) : null);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
	}

	// Token: 0x06010D73 RID: 68979 RVA: 0x00417C38 File Offset: 0x00415E38
	public bool CheckOpenCondition()
	{
		return FunctionModel.Instance.IsOpen(10020);
	}

	// Token: 0x06010D74 RID: 68980 RVA: 0x00417C49 File Offset: 0x00415E49
	public MailFilter GetMailFilterConfigData(EMailFilter type)
	{
		return MailConfig.Instance.GetMailFilterConfigById((int)type);
	}

	// Token: 0x06010D75 RID: 68981 RVA: 0x00417C58 File Offset: 0x00415E58
	public List<MailData> GetImportantMails(List<MailData> totalSortedMails = null)
	{
		List<MailData> list = totalSortedMails ?? this.GetMailList();
		List<MailData> list2 = new List<MailData>();
		for (int i = 0; i < list.Count; i++)
		{
			MailData mailData = list[i];
			if (mailData.GetMailLevel() == 2)
			{
				list2.Add(mailData);
			}
		}
		return list2;
	}

	// Token: 0x06010D76 RID: 68982 RVA: 0x00417CA4 File Offset: 0x00415EA4
	public List<MailData> GetUnScanMails(List<MailData> totalSortedMails = null)
	{
		List<MailData> list = totalSortedMails ?? this.GetMailList();
		List<MailData> list2 = new List<MailData>();
		for (int i = 0; i < list.Count; i++)
		{
			MailData mailData = list[i];
			if (!mailData.GetWasScanned())
			{
				list2.Add(mailData);
			}
		}
		return list2;
	}

	// Token: 0x06010D77 RID: 68983 RVA: 0x00417CEC File Offset: 0x00415EEC
	public List<MailData> GetFavoriteMails(List<MailData> totalSortedMails = null)
	{
		List<MailData> list = totalSortedMails ?? this.GetMailList();
		List<MailData> list2 = new List<MailData>();
		for (int i = 0; i < list.Count; i++)
		{
			MailData mailData = list[i];
			if (mailData.IsFavorite)
			{
				list2.Add(mailData);
			}
		}
		return list2;
	}

	// Token: 0x1700155B RID: 5467
	// (get) Token: 0x06010D78 RID: 68984 RVA: 0x00417D34 File Offset: 0x00415F34
	public static MailModel Instance
	{
		get
		{
			return MailModel._Instance;
		}
	}

	// Token: 0x06010D79 RID: 68985 RVA: 0x00417D3B File Offset: 0x00415F3B
	public static MailModel GetOrCreateInstance()
	{
		if (MailModel._Instance == null)
		{
			MailModel.CreateInstance();
		}
		return MailModel._Instance;
	}

	// Token: 0x06010D7A RID: 68986 RVA: 0x00417D4F File Offset: 0x00415F4F
	public static bool CreateInstance()
	{
		if (MailModel._Instance != null)
		{
			return true;
		}
		MailModel._Instance = new MailModel();
		return true;
	}

	// Token: 0x06010D7B RID: 68987 RVA: 0x00417D65 File Offset: 0x00415F65
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06010D7C RID: 68988 RVA: 0x00417D67 File Offset: 0x00415F67
	public static void ResetStaticDefaultValue()
	{
		MailModel._Instance = null;
	}

	// Token: 0x06010D7D RID: 68989 RVA: 0x00417D6F File Offset: 0x00415F6F
	static MailModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MailModel.CreateStaticDefaultValue), new Action(MailModel.ResetStaticDefaultValue));
	}

	// Token: 0x04007FF6 RID: 32758
	private const int ID_SHOW_LENGTH = 3;

	// Token: 0x04007FF7 RID: 32759
	private Dictionary<string, MailData> MailMap = new Dictionary<string, MailData>();

	// Token: 0x04007FF8 RID: 32760
	private List<MailData> MailList = new List<MailData>();

	// Token: 0x04007FF9 RID: 32761
	private string CurrentSelectMailId = "";

	// Token: 0x04007FFA RID: 32762
	private HashSet<string> UnFinishedMailSet = new HashSet<string>();

	// Token: 0x04007FFB RID: 32763
	private Dictionary<string, int> DayToSpecialMailCount = new Dictionary<string, int>();

	// Token: 0x04007FFC RID: 32764
	public double LastTimeShowNewMailTipsTime;

	// Token: 0x04007FFD RID: 32765
	private int? MailCapacity;

	// Token: 0x04007FFE RID: 32766
	private List<MailAttachmentData> LastPickedAttachments = new List<MailAttachmentData>();

	// Token: 0x04007FFF RID: 32767
	[Nullable(2)]
	private static MailModel _Instance;
}
