using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.MechanismTimeline.MechanismEvent;
using UnrealEngine;

namespace CSharpScript.Game.Module.MechanismTimeline
{
	// Token: 0x0200547C RID: 21628
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class MechanismTimelineModel : ModelBase
	{
		// Token: 0x060372EF RID: 226031 RVA: 0x00D1646E File Offset: 0x00D1466E
		protected override bool OnInit()
		{
			bool result = base.OnInit();
			MechanismEventCenter.Instance.RegisterEvents();
			return result;
		}

		// Token: 0x060372F0 RID: 226032 RVA: 0x00D16480 File Offset: 0x00D14680
		protected override bool OnClear()
		{
			MechanismEventCenter.Instance.Clear();
			return base.OnClear();
		}

		// Token: 0x060372F1 RID: 226033 RVA: 0x00D16492 File Offset: 0x00D14692
		public void RegisterSequenceContext(UMovieSceneSequencePlayer sequencePlayer, MechanismEventContext context)
		{
			if (sequencePlayer == null || !sequencePlayer.IsValid())
			{
				return;
			}
			this.MechanismEventContext.Set(sequencePlayer, context);
		}

		// Token: 0x060372F2 RID: 226034 RVA: 0x00D164B3 File Offset: 0x00D146B3
		public void UnRegisterSequenceContext(UMovieSceneSequencePlayer sequencePlayer)
		{
			if (sequencePlayer == null || !sequencePlayer.IsValid())
			{
				return;
			}
			this.MechanismEventContext.Remove(sequencePlayer);
		}

		// Token: 0x060372F3 RID: 226035 RVA: 0x00D164D4 File Offset: 0x00D146D4
		[return: Nullable(2)]
		public MechanismEventContext GetContextByPlayer(UMovieSceneSequencePlayer sequencePlayer)
		{
			MechanismEventContext result;
			if (!this.MechanismEventContext.TryGetValue(sequencePlayer, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x1700845B RID: 33883
		// (get) Token: 0x060372F4 RID: 226036 RVA: 0x00D164F4 File Offset: 0x00D146F4
		public static MechanismTimelineModel Instance
		{
			get
			{
				return MechanismTimelineModel._Instance;
			}
		}

		// Token: 0x060372F5 RID: 226037 RVA: 0x00D164FB File Offset: 0x00D146FB
		public static MechanismTimelineModel GetOrCreateInstance()
		{
			if (MechanismTimelineModel._Instance == null)
			{
				MechanismTimelineModel.CreateInstance();
			}
			return MechanismTimelineModel._Instance;
		}

		// Token: 0x060372F6 RID: 226038 RVA: 0x00D1650F File Offset: 0x00D1470F
		public static bool CreateInstance()
		{
			if (MechanismTimelineModel._Instance != null)
			{
				return true;
			}
			MechanismTimelineModel._Instance = new MechanismTimelineModel();
			return true;
		}

		// Token: 0x060372F7 RID: 226039 RVA: 0x00D16525 File Offset: 0x00D14725
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060372F8 RID: 226040 RVA: 0x00D16527 File Offset: 0x00D14727
		public static void ResetStaticDefaultValue()
		{
			MechanismTimelineModel._Instance = null;
		}

		// Token: 0x060372F9 RID: 226041 RVA: 0x00D1652F File Offset: 0x00D1472F
		static MechanismTimelineModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MechanismTimelineModel.CreateStaticDefaultValue), new Action(MechanismTimelineModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401D1B5 RID: 119221
		private readonly WeakMap<UMovieSceneSequencePlayer, MechanismEventContext> MechanismEventContext = new WeakMap<UMovieSceneSequencePlayer, MechanismEventContext>();

		// Token: 0x0401D1B6 RID: 119222
		[Nullable(2)]
		private static MechanismTimelineModel _Instance;
	}
}
