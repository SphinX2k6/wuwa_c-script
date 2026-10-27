using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.SceneItem.Interface;

namespace CSharpScript.Game.NewWorld.Common.Model
{
	// Token: 0x02007076 RID: 28790
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class GraphModel : ModelBase
	{
		// Token: 0x0604619C RID: 287132 RVA: 0x0117E798 File Offset: 0x0117C998
		protected override bool OnInit()
		{
			this.SceneItemGraphs = new Dictionary<int, ISceneItemGraph>();
			return true;
		}

		// Token: 0x0604619D RID: 287133 RVA: 0x0117E7A6 File Offset: 0x0117C9A6
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

		// Token: 0x17009C18 RID: 39960
		// (get) Token: 0x0604619E RID: 287134 RVA: 0x0117E7C1 File Offset: 0x0117C9C1
		public static GraphModel Instance
		{
			get
			{
				return GraphModel._Instance;
			}
		}

		// Token: 0x0604619F RID: 287135 RVA: 0x0117E7C8 File Offset: 0x0117C9C8
		public static GraphModel GetOrCreateInstance()
		{
			if (GraphModel._Instance == null)
			{
				GraphModel.CreateInstance();
			}
			return GraphModel._Instance;
		}

		// Token: 0x060461A0 RID: 287136 RVA: 0x0117E7DC File Offset: 0x0117C9DC
		public static bool CreateInstance()
		{
			if (GraphModel._Instance != null)
			{
				return true;
			}
			GraphModel._Instance = new GraphModel();
			return true;
		}

		// Token: 0x060461A1 RID: 287137 RVA: 0x0117E7F2 File Offset: 0x0117C9F2
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060461A2 RID: 287138 RVA: 0x0117E7F4 File Offset: 0x0117C9F4
		public static void ResetStaticDefaultValue()
		{
			GraphModel._Instance = null;
		}

		// Token: 0x060461A3 RID: 287139 RVA: 0x0117E7FC File Offset: 0x0117C9FC
		static GraphModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(GraphModel.CreateStaticDefaultValue), new Action(GraphModel.ResetStaticDefaultValue));
		}

		// Token: 0x04024B7F RID: 150399
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Dictionary<int, ISceneItemGraph> SceneItemGraphs;

		// Token: 0x04024B80 RID: 150400
		[Nullable(2)]
		private static GraphModel _Instance;
	}
}
