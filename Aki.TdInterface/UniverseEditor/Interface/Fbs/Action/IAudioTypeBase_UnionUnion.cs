using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006827 RID: 26663
	public class IAudioTypeBase_UnionUnion
	{
		// Token: 0x1700C407 RID: 50183
		// (get) Token: 0x0602D8F9 RID: 186617 RVA: 0x0063C2C5 File Offset: 0x0063A4C5
		// (set) Token: 0x0602D8FA RID: 186618 RVA: 0x0063C2CD File Offset: 0x0063A4CD
		public IAudioTypeBase_Union Type { get; set; }

		// Token: 0x1700C408 RID: 50184
		// (get) Token: 0x0602D8FB RID: 186619 RVA: 0x0063C2D6 File Offset: 0x0063A4D6
		// (set) Token: 0x0602D8FC RID: 186620 RVA: 0x0063C2DE File Offset: 0x0063A4DE
		public object Value { get; set; }

		// Token: 0x0602D8FD RID: 186621 RVA: 0x0063C2E7 File Offset: 0x0063A4E7
		public IAudioTypeBase_UnionUnion()
		{
			this.Type = IAudioTypeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602D8FE RID: 186622 RVA: 0x0063C2FD File Offset: 0x0063A4FD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602D8FF RID: 186623 RVA: 0x0063C30F File Offset: 0x0063A50F
		public IAudioTypeBaseT AsIAudioTypeBase()
		{
			return this.As<IAudioTypeBaseT>();
		}

		// Token: 0x0602D900 RID: 186624 RVA: 0x0063C317 File Offset: 0x0063A517
		public static IAudioTypeBase_UnionUnion FromIAudioTypeBase(IAudioTypeBaseT _iaudiotypebase)
		{
			return new IAudioTypeBase_UnionUnion
			{
				Type = IAudioTypeBase_Union.IAudioTypeBase,
				Value = _iaudiotypebase
			};
		}

		// Token: 0x0602D901 RID: 186625 RVA: 0x0063C32C File Offset: 0x0063A52C
		public IRoleSceneVoiceT AsIRoleSceneVoice()
		{
			return this.As<IRoleSceneVoiceT>();
		}

		// Token: 0x0602D902 RID: 186626 RVA: 0x0063C334 File Offset: 0x0063A534
		public static IAudioTypeBase_UnionUnion FromIRoleSceneVoice(IRoleSceneVoiceT _irolescenevoice)
		{
			return new IAudioTypeBase_UnionUnion
			{
				Type = IAudioTypeBase_Union.IRoleSceneVoice,
				Value = _irolescenevoice
			};
		}

		// Token: 0x0602D903 RID: 186627 RVA: 0x0063C34C File Offset: 0x0063A54C
		public static int Pack(FlatBufferBuilder builder, IAudioTypeBase_UnionUnion _o)
		{
			IAudioTypeBase_Union type = _o.Type;
			if (type == IAudioTypeBase_Union.IAudioTypeBase)
			{
				return IAudioTypeBase.Pack(builder, _o.AsIAudioTypeBase()).Value;
			}
			if (type != IAudioTypeBase_Union.IRoleSceneVoice)
			{
				return 0;
			}
			return IRoleSceneVoice.Pack(builder, _o.AsIRoleSceneVoice()).Value;
		}
	}
}
