using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x0200089D RID: 2205
[NullableContext(1)]
[Nullable(0)]
public class PinballWeaponData
{
	// Token: 0x0600638C RID: 25484 RVA: 0x001FAFE8 File Offset: 0x001F91E8
	public void Phrase(PinballWeapon info)
	{
		this.Id = info.ConfigId;
		this.IncId = info.IncrId;
		this.FuncValue = info.FuncValue;
		this.RoleId = info.RoleId;
		this.SubEntryId = info.SubEntryId;
		PinballWeaponConfig? pinballWeaponConfigById = PinballConfig.Instance.GetPinballWeaponConfigById(this.Id);
		if (pinballWeaponConfigById == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.PinballBattle;
			ELogAuthor author = ELogAuthor.CB;
			string message = "武器配置不存在";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", this.Id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.MainEntryId = pinballWeaponConfigById.Value.MainEntry;
		this.Quality = pinballWeaponConfigById.Value.QualityId;
		this.Name = pinballWeaponConfigById.Value.Name;
		this.Type = pinballWeaponConfigById.Value.Type;
		this.Icon = pinballWeaponConfigById.Value.Icon;
		this.PersonType = pinballWeaponConfigById.Value.PersonType;
		int propListLength = pinballWeaponConfigById.Value.PropListLength;
		this.PropList = new int[propListLength];
		for (int i = 0; i < propListLength; i++)
		{
			int num = pinballWeaponConfigById.Value.PropList(i);
			this.PropList[i] = num;
		}
	}

	// Token: 0x0600638D RID: 25485 RVA: 0x001FB148 File Offset: 0x001F9348
	public bool GetCanDecompose()
	{
		return !this.GetIsLock() && this.RoleId == 0;
	}

	// Token: 0x0600638E RID: 25486 RVA: 0x001FB15D File Offset: 0x001F935D
	public void SetIsLock(bool lockVal)
	{
		if (lockVal)
		{
			this.FuncValue |= 1;
			return;
		}
		this.FuncValue &= -2;
	}

	// Token: 0x0600638F RID: 25487 RVA: 0x001FB180 File Offset: 0x001F9380
	public bool GetIsLock()
	{
		return (this.FuncValue & 1) > 0;
	}

	// Token: 0x06006390 RID: 25488 RVA: 0x001FB18D File Offset: 0x001F938D
	public bool GetIsPersonWeapon()
	{
		return this.PersonType > 0;
	}

	// Token: 0x04004034 RID: 16436
	public int Id;

	// Token: 0x04004035 RID: 16437
	public int IncId;

	// Token: 0x04004036 RID: 16438
	public int FuncValue;

	// Token: 0x04004037 RID: 16439
	public int RoleId;

	// Token: 0x04004038 RID: 16440
	public int MainEntryId;

	// Token: 0x04004039 RID: 16441
	public int SubEntryId;

	// Token: 0x0400403A RID: 16442
	public int Quality;

	// Token: 0x0400403B RID: 16443
	public string Name = "";

	// Token: 0x0400403C RID: 16444
	public int Type;

	// Token: 0x0400403D RID: 16445
	public string Icon = "";

	// Token: 0x0400403E RID: 16446
	public int[] PropList = Array.Empty<int>();

	// Token: 0x0400403F RID: 16447
	public bool IsSelected;

	// Token: 0x04004040 RID: 16448
	public int PersonType;
}
