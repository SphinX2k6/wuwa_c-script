using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.SceneItem.Interface;

namespace CSharpScript.Game.NewWorld.Common.Model
{
	// Token: 0x020061F7 RID: 25079
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class GraphModel : ModelBase
	{
		// Token: 0x0603C3A6 RID: 246694 RVA: 0x01127FB4 File Offset: 0x011261B4
		protected override bool OnInit()
		{
			this.SceneItemGraphs = new Dictionary<int, ISceneItemGraph>();
			return true;
		}

		// Token: 0x0603C3A7 RID: 246695 RVA: 0x01127FC2 File Offset: 0x011261C2
		protected override bool OnClear()
		{
			Dictionary<int, ISceneItemGraph> sceneItemGraphs = this.SceneItemGraphs;
			if (sceneItemGraphs != null)
			{
				sceneItemGraphs.Clear();
			}
			this.SceneItemGraphs = null;
			return true;
		}

		// Token: 0x170071AD RID: 29101
		// (get) Token: 0x0603C3A8 RID: 246696 RVA: 0x01127FDD File Offset: 0x011261DD
		public static GraphModel Instance
		{
			get
			{
				return GraphModel._Instance;
			}
		}

		// Token: 0x0603C3A9 RID: 246697 RVA: 0x01127FE4 File Offset: 0x011261E4
		public static GraphModel GetOrCreateInstance()
		{
			if (GraphModel._Instance == null)
			{
				GraphModel.CreateInstance();
			}
			return GraphModel._Instance;
		}

		// Token: 0x0603C3AA RID: 246698 RVA: 0x01127FF8 File Offset: 0x011261F8
		public static bool CreateInstance()
		{
			if (GraphModel._Instance != null)
			{
				return true;
			}
			GraphModel._Instance = new GraphModel();
			return true;
		}

		// Token: 0x0603C3AB RID: 246699 RVA: 0x0112800E File Offset: 0x0112620E
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603C3AC RID: 246700 RVA: 0x01128010 File Offset: 0x01126210
		public static void ResetStaticDefaultValue()
		{
			GraphModel._Instance = null;
		}

		// Token: 0x0603C3AD RID: 246701 RVA: 0x01128018 File Offset: 0x01126218
		static GraphModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(GraphModel.CreateStaticDefaultValue), new Action(GraphModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401FE3A RID: 130618
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Dictionary<int, ISceneItemGraph> SceneItemGraphs;

		// Token: 0x0401FE3B RID: 130619
		[Nullable(2)]
		private static GraphModel _Instance;
	}
}
