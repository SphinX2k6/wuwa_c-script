using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using Google.Protobuf.Collections;

// Token: 0x020016B0 RID: 5808
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class MailModel : ModelBase
{
	// Token: 0x0600E1DF RID: 57823 RVA: 0x00423684 File Offset: 0x00421884
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

	// Token: 0x0600E1E0 RID: 57824 RVA: 0x004236E4 File Offset: 0x004218E4
	public int GetFavoriteMailCapacity()
	{
		return MailConfig.Instance.GetFavoriteMailSize().GetValueOrDefault();
	}

	// Token: 0x0600E1E1 RID: 57825 RVA: 0x00423703 File Offset: 0x00421903
	public bool IsFavoriteMailFull()
	{
		return this.GetFavoriteMailCount() >= this.GetFavoriteMailCapacity();
	}

	// Token: 0x0600E1E2 RID: 57826 RVA: 0x00423718 File Offset: 0x00421918
	public bool IsFavoriteMailSpaceNearFull()
	{
		double favoriteMailCapacity = (double)this.GetFavoriteMailCapacity();
		int mailSpaceWarningThresholdRate = MailConfig.Instance.GetMailSpaceWarningThresholdRate();
		int num = (int)Math.Floor(favoriteMailCapacity * (double)mailSpaceWarningThresholdRate / 100.0);
		return this.GetFavoriteMailCount() >= num;
	}

	// Token: 0x0600E1E3 RID: 57827 RVA: 0x00423756 File Offset: 0x00421956
	public bool IsMailFavorite(string mailId)
	{
		MailData mailInstanceById = this.GetMailInstanceById(mailId);
		return mailInstanceById != null && mailInstanceById.IsFavorite;
	}

	// Token: 0x0600E1E4 RID: 57828 RVA: 0x0042376A File Offset: 0x0042196A
	public int GetMailSpaceWarningThreshold()
	{
		return MailConfig.Instance.GetMailSpaceWarningThreshold();
	}

	// Token: 0x0600E1E5 RID: 57829 RVA: 0x00423776 File Offset: 0x00421976
	public bool IsMailSpaceNearFull()
	{
		return this.GetMailListLength() >= this.GetMailSpaceWarningThreshold();
	}

	// Token: 0x0600E1E6 RID: 57830 RVA: 0x00423789 File Offset: 0x00421989
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

	// Token: 0x0600E1E7 RID: 57831 RVA: 0x004237BC File Offset: 0x004219BC
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

	// Token: 0x0600E1E8 RID: 57832 RVA: 0x00423810 File Offset: 0x00421A10
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

	// Token: 0x0600E1E9 RID: 57833 RVA: 0x004238AC File Offset: 0x00421AAC
	public bool GetRedDotCouldLightOn()
	{
		return this.UnFinishedMailSet.Count > 0 && this.CheckOpenCondition();
	}

	// Token: 0x0600E1EA RID: 57834 RVA: 0x004238C4 File Offset: 0x00421AC4
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

	// Token: 0x0600E1EB RID: 57835 RVA: 0x0042393C File Offset: 0x00421B3C
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

	// Token: 0x0600E1EC RID: 57836 RVA: 0x004239B8 File Offset: 0x00421BB8
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

	// Token: 0x0600E1ED RID: 57837 RVA: 0x00423A30 File Offset: 0x00421C30
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

	// Token: 0x0600E1EE RID: 57838 RVA: 0x00423BA8 File Offset: 0x00421DA8
	public void ClearLastPickedAttachments()
	{
		this.LastPickedAttachments.Clear();
	}

	// Token: 0x0600E1EF RID: 57839 RVA: 0x00423BB5 File Offset: 0x00421DB5
	public string GetCurrentSelectMailId()
	{
		return this.CurrentSelectMailId;
	}

	// Token: 0x0600E1F0 RID: 57840 RVA: 0x00423BBD File Offset: 0x00421DBD
	public void SetCurrentSelectMailId(string newMailId)
	{
		this.CurrentSelectMailId = newMailId;
	}

	// Token: 0x0600E1F1 RID: 57841 RVA: 0x00423BC6 File Offset: 0x00421DC6
	public void OpenWebBrowser(string url)
	{
		if (string.IsNullOrEmpty(url))
		{
			return;
		}
		KuroSdkController.Instance.OpenExternalUrl(url);
	}

	// Token: 0x0600E1F2 RID: 57842 RVA: 0x00423BDC File Offset: 0x00421DDC
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

	// Token: 0x0600E1F3 RID: 57843 RVA: 0x00423C64 File Offset: 0x00421E64
	public void ReloadMailList()
	{
		this.MailList.Clear();
		foreach (MailData item in this.MailMap.Values)
		{
			this.MailList.Add(item);
		}
		List<MailData> list = new List<MailData>(this.MailList);
		NoLinq.SortStable<MailData>(list, new Comparison<MailData>(this.MailSort));
		this.MailList.Clear();
		this.MailList.AddRange(list);
	}

	// Token: 0x0600E1F4 RID: 57844 RVA: 0x00423D04 File Offset: 0x00421F04
	public List<MailData> GetMailList()
	{
		return this.MailList;
	}

	// Token: 0x0600E1F5 RID: 57845 RVA: 0x00423D0C File Offset: 0x00421F0C
	private void SetValueOfMailList(MailData mail)
	{
		this.MailMap[mail.Id] = mail;
	}

	// Token: 0x0600E1F6 RID: 57846 RVA: 0x00423D20 File Offset: 0x00421F20
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

	// Token: 0x0600E1F7 RID: 57847 RVA: 0x00423D75 File Offset: 0x00421F75
	public int GetMailListLength()
	{
		return this.MailMap.Count;
	}

	// Token: 0x0600E1F8 RID: 57848 RVA: 0x00423D84 File Offset: 0x00421F84
	public MailData GetMailInstanceById(string id)
	{
		MailData result;
		this.MailMap.TryGetValue(id, out result);
		return result;
	}

	// Token: 0x0600E1F9 RID: 57849 RVA: 0x00423DA4 File Offset: 0x00421FA4
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

	// Token: 0x0600E1FA RID: 57850 RVA: 0x00423DF0 File Offset: 0x00421FF0
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

	// Token: 0x0600E1FB RID: 57851 RVA: 0x00423E84 File Offset: 0x00422084
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

	// Token: 0x0600E1FC RID: 57852 RVA: 0x00423EE4 File Offset: 0x004220E4
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

	// Token: 0x0600E1FD RID: 57853 RVA: 0x00423F64 File Offset: 0x00422164
	private string FormatIdStringByLength(int id, int length)
	{
		return (new string('0', length) + ((double)id % Math.Pow(10.0, (double)length)).ToString()).Substring(Math.Max(0, (new string('0', length) + ((double)id % Math.Pow(10.0, (double)length)).ToString()).Length - length));
	}

	// Token: 0x0600E1FE RID: 57854 RVA: 0x00423FD4 File Offset: 0x004221D4
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
		RepeatedField<PbMailAttachment> attachments = mailInformation.Attachments;
		PbMailAttachment[] array = new PbMailAttachment[attachments.Count];
		attachments.CopyTo(array, 0);
		mailData.AttachmentInfos = array;
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

	// Token: 0x0600E1FF RID: 57855 RVA: 0x00424170 File Offset: 0x00422370
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

	// Token: 0x0600E200 RID: 57856 RVA: 0x004241F8 File Offset: 0x004223F8
	public void SaveShowNewMailMap()
	{
		Dictionary<string, bool> dictionary = LocalStorage.GetPlayer<Dictionary<string, bool>>(ELocalStoragePlayerKey.HasShowNewMailTipsMap, null) ?? new Dictionary<string, bool>();
		foreach (KeyValuePair<string, MailData> keyValuePair in this.MailMap)
		{
			dictionary[keyValuePair.Key] = true;
		}
		LocalStorage.SetPlayer<Dictionary<string, bool>>(ELocalStoragePlayerKey.HasShowNewMailTipsMap, dictionary);
	}

	// Token: 0x0600E201 RID: 57857 RVA: 0x00424270 File Offset: 0x00422470
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

	// Token: 0x0600E202 RID: 57858 RVA: 0x004243A8 File Offset: 0x004225A8
	private void AddSpecialMail(MailData mailData)
	{
		EMailConfigType configId = (EMailConfigType)mailData.ConfigId;
		if (configId == EMailConfigType.BackpackOverLimitMail || configId == EMailConfigType.BackpackOverLimitWithCurrencyMail)
		{
			string str = this.GenerateOverLimitMailIdSuffix((long)mailData.Time);
			mailData.Title += str;
		}
	}

	// Token: 0x0600E203 RID: 57859 RVA: 0x004243E4 File Offset: 0x004225E4
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

	// Token: 0x0600E204 RID: 57860 RVA: 0x00424518 File Offset: 0x00422718
	public bool CheckOpenCondition()
	{
		return FunctionModel.Instance.IsOpen(10020);
	}

	// Token: 0x0600E205 RID: 57861 RVA: 0x00424529 File Offset: 0x00422729
	public MailFilter GetMailFilterConfigData(EMailFilter type)
	{
		return MailConfig.Instance.GetMailFilterConfigById((int)type);
	}

	// Token: 0x0600E206 RID: 57862 RVA: 0x00424538 File Offset: 0x00422738
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

	// Token: 0x0600E207 RID: 57863 RVA: 0x00424584 File Offset: 0x00422784
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

	// Token: 0x0600E208 RID: 57864 RVA: 0x004245CC File Offset: 0x004227CC
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

	// Token: 0x17001592 RID: 5522
	// (get) Token: 0x0600E209 RID: 57865 RVA: 0x00424614 File Offset: 0x00422814
	public static MailModel Instance
	{
		get
		{
			return MailModel._Instance;
		}
	}

	// Token: 0x0600E20A RID: 57866 RVA: 0x0042461B File Offset: 0x0042281B
	public static MailModel GetOrCreateInstance()
	{
		if (MailModel._Instance == null)
		{
			MailModel.CreateInstance();
		}
		return MailModel._Instance;
	}

	// Token: 0x0600E20B RID: 57867 RVA: 0x0042462F File Offset: 0x0042282F
	public static bool CreateInstance()
	{
		if (MailModel._Instance != null)
		{
			return true;
		}
		MailModel._Instance = new MailModel();
		return true;
	}

	// Token: 0x0600E20C RID: 57868 RVA: 0x00424645 File Offset: 0x00422845
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600E20D RID: 57869 RVA: 0x00424647 File Offset: 0x00422847
	public static void ResetStaticDefaultValue()
	{
		MailModel._Instance = null;
	}

	// Token: 0x0600E20E RID: 57870 RVA: 0x0042464F File Offset: 0x0042284F
	static MailModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MailModel.CreateStaticDefaultValue), new Action(MailModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400813D RID: 33085
	private const int ID_SHOW_LENGTH = 3;

	// Token: 0x0400813E RID: 33086
	private Dictionary<string, MailData> MailMap = new Dictionary<string, MailData>();

	// Token: 0x0400813F RID: 33087
	private List<MailData> MailList = new List<MailData>();

	// Token: 0x04008140 RID: 33088
	private string CurrentSelectMailId = "";

	// Token: 0x04008141 RID: 33089
	private HashSet<string> UnFinishedMailSet = new HashSet<string>();

	// Token: 0x04008142 RID: 33090
	private Dictionary<string, int> DayToSpecialMailCount = new Dictionary<string, int>();

	// Token: 0x04008143 RID: 33091
	public double LastTimeShowNewMailTipsTime;

	// Token: 0x04008144 RID: 33092
	private int? MailCapacity;

	// Token: 0x04008145 RID: 33093
	private List<MailAttachmentData> LastPickedAttachments = new List<MailAttachmentData>();

	// Token: 0x04008146 RID: 33094
	[Nullable(2)]
	private static MailModel _Instance;
}
