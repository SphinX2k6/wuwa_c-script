using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x02001890 RID: 6288
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class WeekCardModel : ModelBase
{
	// Token: 0x0600F8C8 RID: 63688 RVA: 0x0048C1DC File Offset: 0x0048A3DC
	public void SetWeekCardInfos(IEnumerable<WeekCardInfo> infos)
	{
		foreach (WeekCardInfo weekCardInfo in infos)
		{
			this.Cards[weekCardInfo.WeekCardId] = new WeekCardData(weekCardInfo);
		}
		EventSystem.Instance.Emit(EEventName.ReceiveWeekCardDataEvent);
	}

	// Token: 0x0600F8C9 RID: 63689 RVA: 0x0048C244 File Offset: 0x0048A444
	[NullableContext(2)]
	public WeekCardData GetById(int weekCardId)
	{
		return this.Cards.GetValueOrDefault(weekCardId);
	}

	// Token: 0x0600F8CA RID: 63690 RVA: 0x0048C252 File Offset: 0x0048A452
	public IReadOnlyDictionary<int, WeekCardData> GetAll()
	{
		return this.Cards;
	}

	// Token: 0x0600F8CB RID: 63691 RVA: 0x0048C25C File Offset: 0x0048A45C
	public bool AnyOpen()
	{
		using (Dictionary<int, WeekCardData>.ValueCollection.Enumerator enumerator = this.Cards.Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.GetWeekCardIsOpen())
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0600F8CC RID: 63692 RVA: 0x0048C2BC File Offset: 0x0048A4BC
	public EWeekCardKind Classify(int weekCardId)
	{
		WeekCard? weekCard;
		if (((WeekCardConfig.Instance.GetConfig(weekCardId) != null) ? new int?(weekCard.GetValueOrDefault().ShowType) : null).GetValueOrDefault() != 2)
		{
			return EWeekCardKind.Normal;
		}
		return EWeekCardKind.NewPlayer;
	}

	// Token: 0x0600F8CD RID: 63693 RVA: 0x0048C30C File Offset: 0x0048A50C
	[NullableContext(2)]
	public WeekCardData GetDefaultByKind(EWeekCardKind kind)
	{
		foreach (WeekCardData weekCardData in this.Cards.Values)
		{
			if (this.Classify(weekCardData.WeekCardId) == kind)
			{
				return weekCardData;
			}
		}
		return null;
	}

	// Token: 0x0600F8CE RID: 63694 RVA: 0x0048C374 File Offset: 0x0048A574
	public WeekCardViewModel GetViewModel(EWeekCardKind kind)
	{
		WeekCardViewModel weekCardViewModel;
		if (!this.ViewModels.TryGetValue(kind, out weekCardViewModel))
		{
			weekCardViewModel = new WeekCardViewModel(kind);
			this.ViewModels[kind] = weekCardViewModel;
		}
		return weekCardViewModel;
	}

	// Token: 0x170017F3 RID: 6131
	// (get) Token: 0x0600F8CF RID: 63695 RVA: 0x0048C3A6 File Offset: 0x0048A5A6
	public static WeekCardModel Instance
	{
		get
		{
			return WeekCardModel._Instance;
		}
	}

	// Token: 0x0600F8D0 RID: 63696 RVA: 0x0048C3AD File Offset: 0x0048A5AD
	public static WeekCardModel GetOrCreateInstance()
	{
		if (WeekCardModel._Instance == null)
		{
			WeekCardModel.CreateInstance();
		}
		return WeekCardModel._Instance;
	}

	// Token: 0x0600F8D1 RID: 63697 RVA: 0x0048C3C1 File Offset: 0x0048A5C1
	public static bool CreateInstance()
	{
		if (WeekCardModel._Instance != null)
		{
			return true;
		}
		WeekCardModel._Instance = new WeekCardModel();
		return true;
	}

	// Token: 0x0600F8D2 RID: 63698 RVA: 0x0048C3D7 File Offset: 0x0048A5D7
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600F8D3 RID: 63699 RVA: 0x0048C3D9 File Offset: 0x0048A5D9
	public static void ResetStaticDefaultValue()
	{
		WeekCardModel._Instance = null;
	}

	// Token: 0x0600F8D4 RID: 63700 RVA: 0x0048C3E1 File Offset: 0x0048A5E1
	static WeekCardModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WeekCardModel.CreateStaticDefaultValue), new Action(WeekCardModel.ResetStaticDefaultValue));
	}

	// Token: 0x04008B2B RID: 35627
	private readonly Dictionary<int, WeekCardData> Cards = new Dictionary<int, WeekCardData>();

	// Token: 0x04008B2C RID: 35628
	private readonly Dictionary<EWeekCardKind, WeekCardViewModel> ViewModels = new Dictionary<EWeekCardKind, WeekCardViewModel>();

	// Token: 0x04008B2D RID: 35629
	[Nullable(2)]
	private static WeekCardModel _Instance;
}
