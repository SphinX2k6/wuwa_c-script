using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x020023AB RID: 9131
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class WeekCardModel : ModelBase
{
	// Token: 0x06012416 RID: 74774 RVA: 0x0047ED08 File Offset: 0x0047CF08
	public void SetWeekCardInfos(IEnumerable<WeekCardInfo> infos)
	{
		foreach (WeekCardInfo weekCardInfo in infos)
		{
			this.Cards[weekCardInfo.WeekCardId] = new WeekCardData(weekCardInfo);
		}
		EventSystem.Instance.Emit(EEventName.ReceiveWeekCardDataEvent);
	}

	// Token: 0x06012417 RID: 74775 RVA: 0x0047ED70 File Offset: 0x0047CF70
	[NullableContext(2)]
	public WeekCardData GetById(int weekCardId)
	{
		return this.Cards.GetValueOrDefault(weekCardId);
	}

	// Token: 0x06012418 RID: 74776 RVA: 0x0047ED7E File Offset: 0x0047CF7E
	public IReadOnlyDictionary<int, WeekCardData> GetAll()
	{
		return this.Cards;
	}

	// Token: 0x06012419 RID: 74777 RVA: 0x0047ED88 File Offset: 0x0047CF88
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

	// Token: 0x0601241A RID: 74778 RVA: 0x0047EDE8 File Offset: 0x0047CFE8
	public EWeekCardKind Classify(int weekCardId)
	{
		WeekCard? weekCard;
		if (((WeekCardConfig.Instance.GetConfig(weekCardId) != null) ? new int?(weekCard.GetValueOrDefault().ShowType) : null).GetValueOrDefault() != 2)
		{
			return EWeekCardKind.Normal;
		}
		return EWeekCardKind.NewPlayer;
	}

	// Token: 0x0601241B RID: 74779 RVA: 0x0047EE38 File Offset: 0x0047D038
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

	// Token: 0x0601241C RID: 74780 RVA: 0x0047EEA0 File Offset: 0x0047D0A0
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

	// Token: 0x170017B9 RID: 6073
	// (get) Token: 0x0601241D RID: 74781 RVA: 0x0047EED2 File Offset: 0x0047D0D2
	public static WeekCardModel Instance
	{
		get
		{
			return WeekCardModel._Instance;
		}
	}

	// Token: 0x0601241E RID: 74782 RVA: 0x0047EED9 File Offset: 0x0047D0D9
	public static WeekCardModel GetOrCreateInstance()
	{
		if (WeekCardModel._Instance == null)
		{
			WeekCardModel.CreateInstance();
		}
		return WeekCardModel._Instance;
	}

	// Token: 0x0601241F RID: 74783 RVA: 0x0047EEED File Offset: 0x0047D0ED
	public static bool CreateInstance()
	{
		if (WeekCardModel._Instance != null)
		{
			return true;
		}
		WeekCardModel._Instance = new WeekCardModel();
		return true;
	}

	// Token: 0x06012420 RID: 74784 RVA: 0x0047EF03 File Offset: 0x0047D103
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06012421 RID: 74785 RVA: 0x0047EF05 File Offset: 0x0047D105
	public static void ResetStaticDefaultValue()
	{
		WeekCardModel._Instance = null;
	}

	// Token: 0x06012422 RID: 74786 RVA: 0x0047EF0D File Offset: 0x0047D10D
	static WeekCardModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WeekCardModel.CreateStaticDefaultValue), new Action(WeekCardModel.ResetStaticDefaultValue));
	}

	// Token: 0x040089E4 RID: 35300
	private readonly Dictionary<int, WeekCardData> Cards = new Dictionary<int, WeekCardData>();

	// Token: 0x040089E5 RID: 35301
	private readonly Dictionary<EWeekCardKind, WeekCardViewModel> ViewModels = new Dictionary<EWeekCardKind, WeekCardViewModel>();

	// Token: 0x040089E6 RID: 35302
	[Nullable(2)]
	private static WeekCardModel _Instance;
}
