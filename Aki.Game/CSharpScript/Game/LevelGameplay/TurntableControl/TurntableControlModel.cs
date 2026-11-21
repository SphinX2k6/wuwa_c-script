using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;

namespace CSharpScript.Game.LevelGamePlay.TurntableControl
{
	// Token: 0x02005B18 RID: 23320
	[NullableContext(2)]
	[Nullable(0)]
	[Model(0)]
	public class TurntableControlModel : ModelBase
	{
		// Token: 0x17006D41 RID: 27969
		// (get) Token: 0x060395FB RID: 235003 RVA: 0x01019ED5 File Offset: 0x010180D5
		public Entity CurControllerEntity
		{
			get
			{
				return this.CurControllerEntityInternal;
			}
		}

		// Token: 0x17006D42 RID: 27970
		// (get) Token: 0x060395FC RID: 235004 RVA: 0x01019EDD File Offset: 0x010180DD
		public SceneItemTurntableControllerComponent CurControllerEntityComp
		{
			get
			{
				return this.CurControllerEntityCompInternal;
			}
		}

		// Token: 0x060395FD RID: 235005 RVA: 0x01019EE8 File Offset: 0x010180E8
		public void SetCurControllerEntity(int entityId)
		{
			Entity entity = EntitySystem.Instance.Get<Entity>(entityId);
			SceneItemTurntableControllerComponent sceneItemTurntableControllerComponent = (entity != null) ? entity.GetComponent<SceneItemTurntableControllerComponent>() : null;
			if (sceneItemTurntableControllerComponent == null)
			{
				this.ClearCurControllerEntity();
			}
			this.CurControllerEntityInternal = entity;
			this.CurControllerEntityCompInternal = sceneItemTurntableControllerComponent;
		}

		// Token: 0x060395FE RID: 235006 RVA: 0x01019F25 File Offset: 0x01018125
		public void ClearCurControllerEntity()
		{
			this.CurControllerEntityInternal = null;
			this.CurControllerEntityCompInternal = null;
		}

		// Token: 0x060395FF RID: 235007 RVA: 0x01019F35 File Offset: 0x01018135
		protected override bool OnClear()
		{
			this.ClearCurControllerEntity();
			return true;
		}

		// Token: 0x17006D43 RID: 27971
		// (get) Token: 0x06039600 RID: 235008 RVA: 0x01019F3E File Offset: 0x0101813E
		[Nullable(1)]
		public static TurntableControlModel Instance
		{
			[NullableContext(1)]
			get
			{
				return TurntableControlModel._Instance;
			}
		}

		// Token: 0x06039601 RID: 235009 RVA: 0x01019F45 File Offset: 0x01018145
		[NullableContext(1)]
		public static TurntableControlModel GetOrCreateInstance()
		{
			if (TurntableControlModel._Instance == null)
			{
				TurntableControlModel.CreateInstance();
			}
			return TurntableControlModel._Instance;
		}

		// Token: 0x06039602 RID: 235010 RVA: 0x01019F59 File Offset: 0x01018159
		public static bool CreateInstance()
		{
			if (TurntableControlModel._Instance != null)
			{
				return true;
			}
			TurntableControlModel._Instance = new TurntableControlModel();
			return true;
		}

		// Token: 0x06039603 RID: 235011 RVA: 0x01019F6F File Offset: 0x0101816F
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06039604 RID: 235012 RVA: 0x01019F71 File Offset: 0x01018171
		public static void ResetStaticDefaultValue()
		{
			TurntableControlModel._Instance = null;
		}

		// Token: 0x06039605 RID: 235013 RVA: 0x01019F79 File Offset: 0x01018179
		static TurntableControlModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TurntableControlModel.CreateStaticDefaultValue), new Action(TurntableControlModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401E418 RID: 123928
		private Entity CurControllerEntityInternal;

		// Token: 0x0401E419 RID: 123929
		private SceneItemTurntableControllerComponent CurControllerEntityCompInternal;

		// Token: 0x0401E41A RID: 123930
		private static TurntableControlModel _Instance;
	}
}
