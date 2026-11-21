using System;
using System.Runtime.CompilerServices;

// Token: 0x02000BBA RID: 3002
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class CooperationModel : ModelBase
{
	// Token: 0x06007CC0 RID: 31936 RVA: 0x0026A6FF File Offset: 0x002688FF
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

	// Token: 0x06007CC1 RID: 31937 RVA: 0x0026A728 File Offset: 0x00268928
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

	// Token: 0x06007CC2 RID: 31938 RVA: 0x0026A75B File Offset: 0x0026895B
	public ICooperationHandler[] GetHandlers()
	{
		return this.Handlers;
	}

	// Token: 0x17000E1D RID: 3613
	// (get) Token: 0x06007CC3 RID: 31939 RVA: 0x0026A763 File Offset: 0x00268963
	public static CooperationModel Instance
	{
		get
		{
			return CooperationModel._Instance;
		}
	}

	// Token: 0x06007CC4 RID: 31940 RVA: 0x0026A76A File Offset: 0x0026896A
	public static CooperationModel GetOrCreateInstance()
	{
		if (CooperationModel._Instance == null)
		{
			CooperationModel.CreateInstance();
		}
		return CooperationModel._Instance;
	}

	// Token: 0x06007CC5 RID: 31941 RVA: 0x0026A77E File Offset: 0x0026897E
	public static bool CreateInstance()
	{
		if (CooperationModel._Instance != null)
		{
			return true;
		}
		CooperationModel._Instance = new CooperationModel();
		return true;
	}

	// Token: 0x06007CC6 RID: 31942 RVA: 0x0026A794 File Offset: 0x00268994
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06007CC7 RID: 31943 RVA: 0x0026A796 File Offset: 0x00268996
	public static void ResetStaticDefaultValue()
	{
		CooperationModel._Instance = null;
	}

	// Token: 0x06007CC8 RID: 31944 RVA: 0x0026A79E File Offset: 0x0026899E
	static CooperationModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CooperationModel.CreateStaticDefaultValue), new Action(CooperationModel.ResetStaticDefaultValue));
	}

	// Token: 0x04004DB2 RID: 19890
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ICooperationHandler[] Handlers;

	// Token: 0x04004DB3 RID: 19891
	[Nullable(2)]
	private static CooperationModel _Instance;
}
