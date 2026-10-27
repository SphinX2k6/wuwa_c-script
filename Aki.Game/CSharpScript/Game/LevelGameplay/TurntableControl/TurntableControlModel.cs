using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;

namespace CSharpScript.Game.LevelGamePlay.TurntableControl
{
	// Token: 0x020069BC RID: 27068
	[NullableContext(2)]
	[Nullable(0)]
	[Model(0)]
	public class TurntableControlModel : ModelBase
	{
		// Token: 0x17009861 RID: 39009
		// (get) Token: 0x060435BF RID: 275903 RVA: 0x01075A41 File Offset: 0x01073C41
		public Entity CurControllerEntity
		{
			get
			{
				return this.CurControllerEntityInternal;
			}
		}

		// Token: 0x17009862 RID: 39010
		// (get) Token: 0x060435C0 RID: 275904 RVA: 0x01075A49 File Offset: 0x01073C49
		public SceneItemTurntableControllerComponent CurControllerEntityComp
		{
			get
			{
				return this.CurControllerEntityCompInternal;
			}
		}

		// Token: 0x060435C1 RID: 275905 RVA: 0x01075A54 File Offset: 0x01073C54
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

		// Token: 0x060435C2 RID: 275906 RVA: 0x01075A91 File Offset: 0x01073C91
		public void ClearCurControllerEntity()
		{
			this.CurControllerEntityInternal = null;
			this.CurControllerEntityCompInternal = null;
		}

		// Token: 0x060435C3 RID: 275907 RVA: 0x01075AA1 File Offset: 0x01073CA1
		protected override bool OnClear()
		{
			this.ClearCurControllerEntity();
			return true;
		}

		// Token: 0x17009863 RID: 39011
		// (get) Token: 0x060435C4 RID: 275908 RVA: 0x01075AAA File Offset: 0x01073CAA
		[Nullable(1)]
		public static TurntableControlModel Instance
		{
			[NullableContext(1)]
			get
			{
				return TurntableControlModel._Instance;
			}
		}

		// Token: 0x060435C5 RID: 275909 RVA: 0x01075AB1 File Offset: 0x01073CB1
		[NullableContext(1)]
		public static TurntableControlModel GetOrCreateInstance()
		{
			if (TurntableControlModel._Instance == null)
			{
				TurntableControlModel.CreateInstance();
			}
			return TurntableControlModel._Instance;
		}

		// Token: 0x060435C6 RID: 275910 RVA: 0x01075AC5 File Offset: 0x01073CC5
		public static bool CreateInstance()
		{
			if (TurntableControlModel._Instance != null)
			{
				return true;
			}
			TurntableControlModel._Instance = new TurntableControlModel();
			return true;
		}

		// Token: 0x060435C7 RID: 275911 RVA: 0x01075ADB File Offset: 0x01073CDB
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060435C8 RID: 275912 RVA: 0x01075ADD File Offset: 0x01073CDD
		public static void ResetStaticDefaultValue()
		{
			TurntableControlModel._Instance = null;
		}

		// Token: 0x060435C9 RID: 275913 RVA: 0x01075AE5 File Offset: 0x01073CE5
		static TurntableControlModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TurntableControlModel.CreateStaticDefaultValue), new Action(TurntableControlModel.ResetStaticDefaultValue));
		}

		// Token: 0x04023228 RID: 143912
		private Entity CurControllerEntityInternal;

		// Token: 0x04023229 RID: 143913
		private SceneItemTurntableControllerComponent CurControllerEntityCompInternal;

		// Token: 0x0402322A RID: 143914
		private static TurntableControlModel _Instance;
	}
}
