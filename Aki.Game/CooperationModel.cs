using System;
using System.Runtime.CompilerServices;

// Token: 0x02001702 RID: 5890
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class CooperationModel : ModelBase
{
	// Token: 0x0600A8E0 RID: 43232 RVA: 0x002602E3 File Offset: 0x0025E4E3
	protected override bool OnInit()
	{
		this.Handlers = new ICooperationHandler[]
		{
			new LinkCooperationHandler(),
			new QteCooperationHandler(),
			new SceneTeamCooperationHandler()
		};
		return true;
	}

	// Token: 0x0600A8E1 RID: 43233 RVA: 0x0026030C File Offset: 0x0025E50C
	protected override bool OnLeaveLevel()
	{
		if (this.Handlers != null)
		{
			ICooperationHandler[] handlers = this.Handlers;
			for (int i = 0; i < handlers.Length; i++)
			{
				handlers[i].Clear();
			}
		}
		return true;
	}

	// Token: 0x0600A8E2 RID: 43234 RVA: 0x0026033F File Offset: 0x0025E53F
	public ICooperationHandler[] GetHandlers()
	{
		return this.Handlers;
	}

	// Token: 0x17000DFC RID: 3580
	// (get) Token: 0x0600A8E3 RID: 43235 RVA: 0x00260347 File Offset: 0x0025E547
	public static CooperationModel Instance
	{
		get
		{
			return CooperationModel._Instance;
		}
	}

	// Token: 0x0600A8E4 RID: 43236 RVA: 0x0026034E File Offset: 0x0025E54E
	public static CooperationModel GetOrCreateInstance()
	{
		if (CooperationModel._Instance == null)
		{
			CooperationModel.CreateInstance();
		}
		return CooperationModel._Instance;
	}

	// Token: 0x0600A8E5 RID: 43237 RVA: 0x00260362 File Offset: 0x0025E562
	public static bool CreateInstance()
	{
		if (CooperationModel._Instance != null)
		{
			return true;
		}
		CooperationModel._Instance = new CooperationModel();
		return true;
	}

	// Token: 0x0600A8E6 RID: 43238 RVA: 0x00260378 File Offset: 0x0025E578
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600A8E7 RID: 43239 RVA: 0x0026037A File Offset: 0x0025E57A
	public static void ResetStaticDefaultValue()
	{
		CooperationModel._Instance = null;
	}

	// Token: 0x0600A8E8 RID: 43240 RVA: 0x00260382 File Offset: 0x0025E582
	static CooperationModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CooperationModel.CreateStaticDefaultValue), new Action(CooperationModel.ResetStaticDefaultValue));
	}

	// Token: 0x04004D0B RID: 19723
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ICooperationHandler[] Handlers;

	// Token: 0x04004D0C RID: 19724
	[Nullable(2)]
	private static CooperationModel _Instance;
}
