using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Base;
using CSharpScript.Game.Module.Map.Mark.Component;

namespace CSharpScript.Game.Module.Map.Marks
{
	// Token: 0x020054D2 RID: 21714
	[NullableContext(1)]
	[Nullable(0)]
	public class MarkItemEntity : MapEntity
	{
		// Token: 0x17008516 RID: 34070
		// (get) Token: 0x06037707 RID: 227079 RVA: 0x00D2AB90 File Offset: 0x00D28D90
		// (set) Token: 0x06037708 RID: 227080 RVA: 0x00D2AB98 File Offset: 0x00D28D98
		public bool IsTempMapMark { get; set; }

		// Token: 0x17008517 RID: 34071
		// (get) Token: 0x06037709 RID: 227081 RVA: 0x00D2ABA4 File Offset: 0x00D28DA4
		public MarkGamePlayComponent GamePlay
		{
			get
			{
				MarkGamePlayComponent result;
				if ((result = this._gamePlayCache) == null)
				{
					result = (this._gamePlayCache = base.GetOrAddComponent<MarkGamePlayComponent>(EMapComponent.MarkGamePlay));
				}
				return result;
			}
		}

		// Token: 0x17008518 RID: 34072
		// (get) Token: 0x0603770A RID: 227082 RVA: 0x00D2ABCC File Offset: 0x00D28DCC
		public MarkResourceComponent Resource
		{
			get
			{
				MarkResourceComponent result;
				if ((result = this._resourceCache) == null)
				{
					result = (this._resourceCache = base.GetOrAddComponent<MarkResourceComponent>(EMapComponent.MarkResource));
				}
				return result;
			}
		}

		// Token: 0x17008519 RID: 34073
		// (get) Token: 0x0603770B RID: 227083 RVA: 0x00D2ABF4 File Offset: 0x00D28DF4
		public MarkViewLifeCircleComponent ViewLifeCircle
		{
			get
			{
				MarkViewLifeCircleComponent result;
				if ((result = this._viewLifeCircleCache) == null)
				{
					result = (this._viewLifeCircleCache = base.GetOrAddComponent<MarkViewLifeCircleComponent>(EMapComponent.MarkViewLifeCircle));
				}
				return result;
			}
		}

		// Token: 0x1700851A RID: 34074
		// (get) Token: 0x0603770C RID: 227084 RVA: 0x00D2AC1C File Offset: 0x00D28E1C
		public MarkMultiFloorComponent MultiFloor
		{
			get
			{
				MarkMultiFloorComponent result;
				if ((result = this._multiFloorCache) == null)
				{
					result = (this._multiFloorCache = base.GetOrAddComponent<MarkMultiFloorComponent>(EMapComponent.MarkMultiFloor));
				}
				return result;
			}
		}

		// Token: 0x0603770D RID: 227085 RVA: 0x00D2AC44 File Offset: 0x00D28E44
		protected override void OnInit()
		{
			this._gamePlayCache = base.GetOrAddComponent<MarkGamePlayComponent>(EMapComponent.MarkGamePlay);
			this._resourceCache = base.GetOrAddComponent<MarkResourceComponent>(EMapComponent.MarkResource);
			this._viewLifeCircleCache = base.GetOrAddComponent<MarkViewLifeCircleComponent>(EMapComponent.MarkViewLifeCircle);
			this._multiFloorCache = base.GetOrAddComponent<MarkMultiFloorComponent>(EMapComponent.MarkMultiFloor);
		}

		// Token: 0x0603770E RID: 227086 RVA: 0x00D2AC7E File Offset: 0x00D28E7E
		protected override void OnDispose()
		{
			this._gamePlayCache = null;
			this._resourceCache = null;
			this._viewLifeCircleCache = null;
			this._multiFloorCache = null;
		}

		// Token: 0x1700851B RID: 34075
		// (get) Token: 0x0603770F RID: 227087 RVA: 0x00D2AC9C File Offset: 0x00D28E9C
		public bool IsConfigMark
		{
			get
			{
				MarkConfigComponent component = base.GetComponent<MarkConfigComponent>(EMapComponent.MarkConfig);
				return component != null && component.Config.HasValue;
			}
		}

		// Token: 0x0401D386 RID: 119686
		[Nullable(2)]
		private MarkGamePlayComponent _gamePlayCache;

		// Token: 0x0401D387 RID: 119687
		[Nullable(2)]
		private MarkResourceComponent _resourceCache;

		// Token: 0x0401D388 RID: 119688
		[Nullable(2)]
		private MarkViewLifeCircleComponent _viewLifeCircleCache;

		// Token: 0x0401D389 RID: 119689
		[Nullable(2)]
		private MarkMultiFloorComponent _multiFloorCache;
	}
}
