using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E1F RID: 3615
	[NullableContext(2)]
	[Nullable(0)]
	public class IIntervalSplineSpawn : IPathDrivenActorSpawnBase
	{
		// Token: 0x060051C8 RID: 20936 RVA: 0x000C99EF File Offset: 0x000C7BEF
		[NullableContext(1)]
		public static IIntervalSplineSpawn Create(IIntervalSplineSpawn? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IIntervalSplineSpawn
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B47 RID: 6983
		// (get) Token: 0x060051C9 RID: 20937 RVA: 0x000C9A0E File Offset: 0x000C7C0E
		public override EPathDrivenActorSpawnType Type
		{
			get
			{
				return (EPathDrivenActorSpawnType)this.Instance.Type;
			}
		}

		// Token: 0x17001B48 RID: 6984
		// (get) Token: 0x060051CA RID: 20938 RVA: 0x000C9A1B File Offset: 0x000C7C1B
		[Nullable(1)]
		public virtual string ActorBlueprintPath
		{
			[NullableContext(1)]
			get
			{
				return this.Instance.ActorBlueprintPath;
			}
		}

		// Token: 0x17001B49 RID: 6985
		// (get) Token: 0x060051CB RID: 20939 RVA: 0x000C9A28 File Offset: 0x000C7C28
		[Nullable(1)]
		public virtual IPathDrivenActorSplineMove MoveMode
		{
			[NullableContext(1)]
			get
			{
				if (this._MoveModeInited)
				{
					return this._MoveModeCache;
				}
				this._MoveModeInited = true;
				this._MoveModeCache = IPathDrivenActorSplineMove.Create(this.Instance.MoveMode);
				return this._MoveModeCache;
			}
		}

		// Token: 0x17001B4A RID: 6986
		// (get) Token: 0x060051CC RID: 20940 RVA: 0x000C9A5C File Offset: 0x000C7C5C
		public virtual float SpawnInterval
		{
			get
			{
				return this.Instance.SpawnInterval;
			}
		}

		// Token: 0x17001B4B RID: 6987
		// (get) Token: 0x060051CD RID: 20941 RVA: 0x000C9A6C File Offset: 0x000C7C6C
		public virtual int? MaxActiveCount
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.MaxActiveCount);
			}
		}

		// Token: 0x17001B4C RID: 6988
		// (get) Token: 0x060051CE RID: 20942 RVA: 0x000C9AA4 File Offset: 0x000C7CA4
		public virtual float? MaxSpawnInterval
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new float?(this.Instance.MaxSpawnInterval);
			}
		}

		// Token: 0x17001B4D RID: 6989
		// (get) Token: 0x060051CF RID: 20943 RVA: 0x000C9ADA File Offset: 0x000C7CDA
		public virtual IPathDrivenActorInitialSpawnConfig InitialSpawnConfig
		{
			get
			{
				if (this._InitialSpawnConfigInited)
				{
					return this._InitialSpawnConfigCache;
				}
				this._InitialSpawnConfigInited = true;
				this._InitialSpawnConfigCache = IPathDrivenActorInitialSpawnConfig.Create(this.Instance.InitialSpawnConfig);
				return this._InitialSpawnConfigCache;
			}
		}

		// Token: 0x17001B4E RID: 6990
		// (get) Token: 0x060051D0 RID: 20944 RVA: 0x000C9B0E File Offset: 0x000C7D0E
		public virtual IIntervalSplineSpawnAllActorAudio AudioConfig
		{
			get
			{
				if (this._AudioConfigInited)
				{
					return this._AudioConfigCache;
				}
				this._AudioConfigInited = true;
				this._AudioConfigCache = IIntervalSplineSpawnAllActorAudio.Create(this.Instance.AudioConfig);
				return this._AudioConfigCache;
			}
		}

		// Token: 0x04002F18 RID: 12056
		private IIntervalSplineSpawn Instance;

		// Token: 0x04002F19 RID: 12057
		private IPathDrivenActorSplineMove _MoveModeCache;

		// Token: 0x04002F1A RID: 12058
		private bool _MoveModeInited;

		// Token: 0x04002F1B RID: 12059
		private IPathDrivenActorInitialSpawnConfig _InitialSpawnConfigCache;

		// Token: 0x04002F1C RID: 12060
		private bool _InitialSpawnConfigInited;

		// Token: 0x04002F1D RID: 12061
		private IIntervalSplineSpawnAllActorAudio _AudioConfigCache;

		// Token: 0x04002F1E RID: 12062
		private bool _AudioConfigInited;
	}
}
