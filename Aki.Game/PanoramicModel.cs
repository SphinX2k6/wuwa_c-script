using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x0200230D RID: 8973
[NullableContext(2)]
[Nullable(0)]
[Model(0)]
public class PanoramicModel : ModelBase
{
	// Token: 0x170016AC RID: 5804
	// (get) Token: 0x06011B87 RID: 72583 RVA: 0x0045BBF4 File Offset: 0x00459DF4
	// (set) Token: 0x06011B88 RID: 72584 RVA: 0x0045BBFC File Offset: 0x00459DFC
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

	// Token: 0x170016AD RID: 5805
	// (get) Token: 0x06011B89 RID: 72585 RVA: 0x0045BC05 File Offset: 0x00459E05
	// (set) Token: 0x06011B8A RID: 72586 RVA: 0x0045BC0D File Offset: 0x00459E0D
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

	// Token: 0x06011B8B RID: 72587 RVA: 0x0045BC16 File Offset: 0x00459E16
	protected override bool OnInit()
	{
		this.CurrentPanoramic = null;
		this.Activated = false;
		this.Panoramic = false;
		this.AllPoints = new Dictionary<long, PanoramicPointComponent>();
		return true;
	}

	// Token: 0x06011B8C RID: 72588 RVA: 0x0045BC39 File Offset: 0x00459E39
	protected override bool OnClear()
	{
		this.CurrentPanoramic = null;
		this.Activated = false;
		this.Panoramic = false;
		this.ClearPoint();
		return true;
	}

	// Token: 0x06011B8D RID: 72589 RVA: 0x0045BC57 File Offset: 0x00459E57
	protected override bool OnLeaveLevel()
	{
		this.CurrentPanoramic = null;
		this.Activated = false;
		this.Panoramic = false;
		this.ClearPoint();
		return true;
	}

	// Token: 0x06011B8E RID: 72590 RVA: 0x0045BC78 File Offset: 0x00459E78
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

	// Token: 0x06011B8F RID: 72591 RVA: 0x0045BCF4 File Offset: 0x00459EF4
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

	// Token: 0x06011B90 RID: 72592 RVA: 0x0045BD50 File Offset: 0x00459F50
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

	// Token: 0x06011B91 RID: 72593 RVA: 0x0045BD94 File Offset: 0x00459F94
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

	// Token: 0x06011B92 RID: 72594 RVA: 0x0045BDEC File Offset: 0x00459FEC
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public Dictionary<long, PanoramicPointComponent> GetPoint()
	{
		return this.AllPoints;
	}

	// Token: 0x06011B93 RID: 72595 RVA: 0x0045BDF4 File Offset: 0x00459FF4
	public int GetPointNum()
	{
		Dictionary<long, PanoramicPointComponent> allPoints = this.AllPoints;
		if (allPoints == null)
		{
			return 0;
		}
		return allPoints.Count;
	}

	// Token: 0x06011B94 RID: 72596 RVA: 0x0045BE08 File Offset: 0x0045A008
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

	// Token: 0x06011B95 RID: 72597 RVA: 0x0045BF32 File Offset: 0x0045A132
	public PanoramicPointComponent GetCurrentPanoramic()
	{
		return this.CurrentPanoramic;
	}

	// Token: 0x06011B96 RID: 72598 RVA: 0x0045BF3C File Offset: 0x0045A13C
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

	// Token: 0x06011B97 RID: 72599 RVA: 0x0045BF9C File Offset: 0x0045A19C
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

	// Token: 0x170016AE RID: 5806
	// (get) Token: 0x06011B98 RID: 72600 RVA: 0x0045C018 File Offset: 0x0045A218
	[Nullable(1)]
	public static PanoramicModel Instance
	{
		[NullableContext(1)]
		get
		{
			return PanoramicModel._Instance;
		}
	}

	// Token: 0x06011B99 RID: 72601 RVA: 0x0045C01F File Offset: 0x0045A21F
	[NullableContext(1)]
	public static PanoramicModel GetOrCreateInstance()
	{
		if (PanoramicModel._Instance == null)
		{
			PanoramicModel.CreateInstance();
		}
		return PanoramicModel._Instance;
	}

	// Token: 0x06011B9A RID: 72602 RVA: 0x0045C033 File Offset: 0x0045A233
	public static bool CreateInstance()
	{
		if (PanoramicModel._Instance != null)
		{
			return true;
		}
		PanoramicModel._Instance = new PanoramicModel();
		return true;
	}

	// Token: 0x06011B9B RID: 72603 RVA: 0x0045C049 File Offset: 0x0045A249
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06011B9C RID: 72604 RVA: 0x0045C04B File Offset: 0x0045A24B
	public static void ResetStaticDefaultValue()
	{
		PanoramicModel._Instance = null;
	}

	// Token: 0x06011B9D RID: 72605 RVA: 0x0045C053 File Offset: 0x0045A253
	static PanoramicModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PanoramicModel.CreateStaticDefaultValue), new Action(PanoramicModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400866D RID: 34413
	private PanoramicPointComponent CurrentPanoramic;

	// Token: 0x0400866E RID: 34414
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<long, PanoramicPointComponent> AllPoints;

	// Token: 0x0400866F RID: 34415
	private bool Activated;

	// Token: 0x04008670 RID: 34416
	private bool Panoramic;

	// Token: 0x04008671 RID: 34417
	private int MotorTag;

	// Token: 0x04008672 RID: 34418
	private static PanoramicModel _Instance;
}
