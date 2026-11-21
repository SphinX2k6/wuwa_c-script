using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.MechanismTimeline.MechanismEvent;
using UnrealEngine;

namespace CSharpScript.Game.Module.MechanismTimeline
{
	// Token: 0x0200445F RID: 17503
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class MechanismTimelineModel : ModelBase
	{
		// Token: 0x0602C238 RID: 180792 RVA: 0x00C658C6 File Offset: 0x00C63AC6
		protected override bool OnInit()
		{
			bool result = base.OnInit();
			MechanismEventCenter.Instance.RegisterEvents();
			return result;
		}

		// Token: 0x0602C239 RID: 180793 RVA: 0x00C658D8 File Offset: 0x00C63AD8
		protected override bool OnClear()
		{
			MechanismEventCenter.Instance.Clear();
			return base.OnClear();
		}

		// Token: 0x0602C23A RID: 180794 RVA: 0x00C658EA File Offset: 0x00C63AEA
		public void RegisterSequenceContext(UMovieSceneSequencePlayer sequencePlayer, MechanismEventContext context)
		{
			if (sequencePlayer == null || !sequencePlayer.IsValid())
			{
				return;
			}
			this.MechanismEventContext.Set(sequencePlayer, context);
		}

		// Token: 0x0602C23B RID: 180795 RVA: 0x00C6590B File Offset: 0x00C63B0B
		public void UnRegisterSequenceContext(UMovieSceneSequencePlayer sequencePlayer)
		{
			if (sequencePlayer == null || !sequencePlayer.IsValid())
			{
				return;
			}
			this.MechanismEventContext.Remove(sequencePlayer);
		}

		// Token: 0x0602C23C RID: 180796 RVA: 0x00C6592C File Offset: 0x00C63B2C
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

		// Token: 0x17005827 RID: 22567
		// (get) Token: 0x0602C23D RID: 180797 RVA: 0x00C6594C File Offset: 0x00C63B4C
		public static MechanismTimelineModel Instance
		{
			get
			{
				return MechanismTimelineModel._Instance;
			}
		}

		// Token: 0x0602C23E RID: 180798 RVA: 0x00C65953 File Offset: 0x00C63B53
		public static MechanismTimelineModel GetOrCreateInstance()
		{
			if (MechanismTimelineModel._Instance == null)
			{
				MechanismTimelineModel.CreateInstance();
			}
			return MechanismTimelineModel._Instance;
		}

		// Token: 0x0602C23F RID: 180799 RVA: 0x00C65967 File Offset: 0x00C63B67
		public static bool CreateInstance()
		{
			if (MechanismTimelineModel._Instance != null)
			{
				return true;
			}
			MechanismTimelineModel._Instance = new MechanismTimelineModel();
			return true;
		}

		// Token: 0x0602C240 RID: 180800 RVA: 0x00C6597D File Offset: 0x00C63B7D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602C241 RID: 180801 RVA: 0x00C6597F File Offset: 0x00C63B7F
		public static void ResetStaticDefaultValue()
		{
			MechanismTimelineModel._Instance = null;
		}

		// Token: 0x0602C242 RID: 180802 RVA: 0x00C65987 File Offset: 0x00C63B87
		static MechanismTimelineModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MechanismTimelineModel.CreateStaticDefaultValue), new Action(MechanismTimelineModel.ResetStaticDefaultValue));
		}

		// Token: 0x04017C4E RID: 97358
		private readonly WeakMap<UMovieSceneSequencePlayer, MechanismEventContext> MechanismEventContext = new WeakMap<UMovieSceneSequencePlayer, MechanismEventContext>();

		// Token: 0x04017C4F RID: 97359
		[Nullable(2)]
		private static MechanismTimelineModel _Instance;
	}
}
