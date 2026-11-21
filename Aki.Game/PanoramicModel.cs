using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x020017F1 RID: 6129
[NullableContext(2)]
[Nullable(0)]
[Model(0)]
public class PanoramicModel : ModelBase
{
	// Token: 0x170016E3 RID: 5859
	// (get) Token: 0x0600F022 RID: 61474 RVA: 0x00468A04 File Offset: 0x00466C04
	// (set) Token: 0x0600F023 RID: 61475 RVA: 0x00468A0C File Offset: 0x00466C0C
	public bool IsPanoramic
	{
		get
		{
			return this.Panoramic;
		}
		set
		{
			this.Panoramic = value;
		}
	}

	// Token: 0x170016E4 RID: 5860
	// (get) Token: 0x0600F024 RID: 61476 RVA: 0x00468A15 File Offset: 0x00466C15
	// (set) Token: 0x0600F025 RID: 61477 RVA: 0x00468A1D File Offset: 0x00466C1D
	public int PlayMoveMotorTag
	{
		get
		{
			return this.MotorTag;
		}
		set
		{
			this.MotorTag = value;
		}
	}

	// Token: 0x0600F026 RID: 61478 RVA: 0x00468A26 File Offset: 0x00466C26
	protected override bool OnInit()
	{
		this.CurrentPanoramic = null;
		this.Activated = false;
		this.Panoramic = false;
		this.AllPoints = new Dictionary<long, PanoramicPointComponent>();
		return true;
	}

	// Token: 0x0600F027 RID: 61479 RVA: 0x00468A49 File Offset: 0x00466C49
	protected override bool OnClear()
	{
		this.CurrentPanoramic = null;
		this.Activated = false;
		this.Panoramic = false;
		this.ClearPoint();
		return true;
	}

	// Token: 0x0600F028 RID: 61480 RVA: 0x00468A67 File Offset: 0x00466C67
	protected override bool OnLeaveLevel()
	{
		this.CurrentPanoramic = null;
		this.Activated = false;
		this.Panoramic = false;
		this.ClearPoint();
		return true;
	}

	// Token: 0x0600F029 RID: 61481 RVA: 0x00468A88 File Offset: 0x00466C88
	[NullableContext(1)]
	public void AddPoint(long num, PanoramicPointComponent comp)
	{
		if (this.AllPoints == null)
		{
			this.AllPoints = new Dictionary<long, PanoramicPointComponent>();
		}
		Dictionary<long, PanoramicPointComponent> allPoints = this.AllPoints;
		if (allPoints != null && allPoints.ContainsKey(num))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Panoramic;
			ELogAuthor author = ELogAuthor.JYS;
			string message = "[环视] AddPoint but already have";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", num);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		if (this.AllPoints != null)
		{
			this.AllPoints[num] = comp;
		}
	}

	// Token: 0x0600F02A RID: 61482 RVA: 0x00468B04 File Offset: 0x00466D04
	public void RemovePoint(long num)
	{
		Dictionary<long, PanoramicPointComponent> allPoints = this.AllPoints;
		if (allPoints == null || !allPoints.ContainsKey(num))
		{
			return;
		}
		Dictionary<long, PanoramicPointComponent> allPoints2 = this.AllPoints;
		PanoramicPointComponent panoramicPointComponent = (allPoints2 != null) ? allPoints2.GetValueOrDefault(num) : null;
		if (this.CurrentPanoramic == panoramicPointComponent)
		{
			this.CurrentPanoramic = null;
		}
		Dictionary<long, PanoramicPointComponent> allPoints3 = this.AllPoints;
		if (allPoints3 == null)
		{
			return;
		}
		allPoints3.Remove(num);
	}

	// Token: 0x0600F02B RID: 61483 RVA: 0x00468B60 File Offset: 0x00466D60
	public void ClearPoint()
	{
		Log.Instance.Info(ELogModule.Panoramic, ELogAuthor.JYS, "[环视] ClearPoint", default(ReadOnlySpan<ValueTuple<string, object>>));
		Dictionary<long, PanoramicPointComponent> allPoints = this.AllPoints;
		if (allPoints != null)
		{
			allPoints.Clear();
		}
		this.AllPoints = null;
	}

	// Token: 0x0600F02C RID: 61484 RVA: 0x00468BA4 File Offset: 0x00466DA4
	public PanoramicPointComponent FindPoint(long num)
	{
		Dictionary<long, PanoramicPointComponent> allPoints = this.AllPoints;
		if (allPoints == null || !allPoints.ContainsKey(num))
		{
			Log.Instance.Warn(ELogModule.Panoramic, ELogAuthor.JYS, "[环视] FindPoint not find", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		Dictionary<long, PanoramicPointComponent> allPoints2 = this.AllPoints;
		if (allPoints2 == null)
		{
			return null;
		}
		return allPoints2.GetValueOrDefault(num);
	}

	// Token: 0x0600F02D RID: 61485 RVA: 0x00468BFC File Offset: 0x00466DFC
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public Dictionary<long, PanoramicPointComponent> GetPoint()
	{
		return this.AllPoints;
	}

	// Token: 0x0600F02E RID: 61486 RVA: 0x00468C04 File Offset: 0x00466E04
	public int GetPointNum()
	{
		Dictionary<long, PanoramicPointComponent> allPoints = this.AllPoints;
		if (allPoints == null)
		{
			return 0;
		}
		return allPoints.Count;
	}

	// Token: 0x0600F02F RID: 61487 RVA: 0x00468C18 File Offset: 0x00466E18
	public void SetCurrentPanoramic(PanoramicPointComponent value, bool noUpdate = false)
	{
		if (value == null)
		{
			if (noUpdate)
			{
				this.CurrentPanoramic = null;
				return;
			}
			this.ChangeAllPanoramicType(EPanoramicType.Default);
			if (this.Activated)
			{
				this.Activated = false;
				EventSystem.Instance.Emit(EEventName.OnPanoramicDisable);
			}
			return;
		}
		else
		{
			if (!this.Activated)
			{
				this.Activated = true;
				EventSystem.Instance.Emit(EEventName.OnPanoramicActive);
			}
			int? num = (value != null) ? new int?(value.GetId()) : null;
			PanoramicPointComponent currentPanoramic = this.CurrentPanoramic;
			int? num2 = (currentPanoramic != null) ? new int?(currentPanoramic.GetId()) : null;
			if (num.GetValueOrDefault() == num2.GetValueOrDefault() & num != null == (num2 != null))
			{
				PanoramicPointComponent currentPanoramic2 = this.CurrentPanoramic;
				if (currentPanoramic2 == null)
				{
					return;
				}
				currentPanoramic2.ChangeSpotType(EPanoramicType.Active);
				return;
			}
			else
			{
				EPanoramicType type = EPanoramicType.Default;
				num2 = ((value != null) ? new int?(value.GetId()) : null);
				this.ChangeAllPanoramicTypeExecptWhich(type, (num2 != null) ? new long?((long)num2.GetValueOrDefault()) : null);
				this.CurrentPanoramic = value;
				PanoramicPointComponent currentPanoramic3 = this.CurrentPanoramic;
				if (currentPanoramic3 == null)
				{
					return;
				}
				currentPanoramic3.ChangeSpotType(EPanoramicType.Active);
				return;
			}
		}
	}

	// Token: 0x0600F030 RID: 61488 RVA: 0x00468D42 File Offset: 0x00466F42
	public PanoramicPointComponent GetCurrentPanoramic()
	{
		return this.CurrentPanoramic;
	}

	// Token: 0x0600F031 RID: 61489 RVA: 0x00468D4C File Offset: 0x00466F4C
	public void ChangeAllPanoramicType(EPanoramicType type)
	{
		if (this.AllPoints != null)
		{
			foreach (PanoramicPointComponent panoramicPointComponent in this.AllPoints.Values)
			{
				panoramicPointComponent.ChangeSpotType(type);
			}
		}
	}

	// Token: 0x0600F032 RID: 61490 RVA: 0x00468DAC File Offset: 0x00466FAC
	public void ChangeAllPanoramicTypeExecptWhich(EPanoramicType type, long? id)
	{
		if (this.AllPoints != null)
		{
			foreach (PanoramicPointComponent panoramicPointComponent in this.AllPoints.Values)
			{
				long num = (long)panoramicPointComponent.GetId();
				long? num2 = id;
				if (!(num == num2.GetValueOrDefault() & num2 != null))
				{
					panoramicPointComponent.ChangeSpotType(type);
				}
			}
		}
	}

	// Token: 0x170016E5 RID: 5861
	// (get) Token: 0x0600F033 RID: 61491 RVA: 0x00468E28 File Offset: 0x00467028
	[Nullable(1)]
	public static PanoramicModel Instance
	{
		[NullableContext(1)]
		get
		{
			return PanoramicModel._Instance;
		}
	}

	// Token: 0x0600F034 RID: 61492 RVA: 0x00468E2F File Offset: 0x0046702F
	[NullableContext(1)]
	public static PanoramicModel GetOrCreateInstance()
	{
		if (PanoramicModel._Instance == null)
		{
			PanoramicModel.CreateInstance();
		}
		return PanoramicModel._Instance;
	}

	// Token: 0x0600F035 RID: 61493 RVA: 0x00468E43 File Offset: 0x00467043
	public static bool CreateInstance()
	{
		if (PanoramicModel._Instance != null)
		{
			return true;
		}
		PanoramicModel._Instance = new PanoramicModel();
		return true;
	}

	// Token: 0x0600F036 RID: 61494 RVA: 0x00468E59 File Offset: 0x00467059
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600F037 RID: 61495 RVA: 0x00468E5B File Offset: 0x0046705B
	public static void ResetStaticDefaultValue()
	{
		PanoramicModel._Instance = null;
	}

	// Token: 0x0600F038 RID: 61496 RVA: 0x00468E63 File Offset: 0x00467063
	static PanoramicModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PanoramicModel.CreateStaticDefaultValue), new Action(PanoramicModel.ResetStaticDefaultValue));
	}

	// Token: 0x040087AD RID: 34733
	private PanoramicPointComponent CurrentPanoramic;

	// Token: 0x040087AE RID: 34734
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<long, PanoramicPointComponent> AllPoints;

	// Token: 0x040087AF RID: 34735
	private bool Activated;

	// Token: 0x040087B0 RID: 34736
	private bool Panoramic;

	// Token: 0x040087B1 RID: 34737
	private int MotorTag;

	// Token: 0x040087B2 RID: 34738
	private static PanoramicModel _Instance;
}
