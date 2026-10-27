using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x020013E9 RID: 5097
[NullableContext(1)]
[Nullable(0)]
public class PinballWeaponData
{
	// Token: 0x06008FF7 RID: 36855 RVA: 0x001F24AC File Offset: 0x001F06AC
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

	// Token: 0x06008FF8 RID: 36856 RVA: 0x001F260C File Offset: 0x001F080C
	public bool GetCanDecompose()
	{
		return !this.GetIsLock() && this.RoleId == 0;
	}

	// Token: 0x06008FF9 RID: 36857 RVA: 0x001F2621 File Offset: 0x001F0821
	public void SetIsLock(bool lockVal)
	{
		if (lockVal)
		{
			this.FuncValue |= 1;
			return;
		}
		this.FuncValue &= -2;
	}

	// Token: 0x06008FFA RID: 36858 RVA: 0x001F2644 File Offset: 0x001F0844
	public bool GetIsLock()
	{
		return (this.FuncValue & 1) > 0;
	}

	// Token: 0x06008FFB RID: 36859 RVA: 0x001F2651 File Offset: 0x001F0851
	public bool GetIsPersonWeapon()
	{
		return this.PersonType > 0;
	}

	// Token: 0x04003F9C RID: 16284
	public int Id;

	// Token: 0x04003F9D RID: 16285
	public int IncId;

	// Token: 0x04003F9E RID: 16286
	public int FuncValue;

	// Token: 0x04003F9F RID: 16287
	public int RoleId;

	// Token: 0x04003FA0 RID: 16288
	public int MainEntryId;

	// Token: 0x04003FA1 RID: 16289
	public int SubEntryId;

	// Token: 0x04003FA2 RID: 16290
	public int Quality;

	// Token: 0x04003FA3 RID: 16291
	public string Name = "";

	// Token: 0x04003FA4 RID: 16292
	public int Type;

	// Token: 0x04003FA5 RID: 16293
	public string Icon = "";

	// Token: 0x04003FA6 RID: 16294
	public int[] PropList = Array.Empty<int>();

	// Token: 0x04003FA7 RID: 16295
	public bool IsSelected;

	// Token: 0x04003FA8 RID: 16296
	public int PersonType;
}
