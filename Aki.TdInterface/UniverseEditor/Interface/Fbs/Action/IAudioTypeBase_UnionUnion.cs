using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061B9 RID: 25017
	public class IAudioTypeBase_UnionUnion
	{
		// Token: 0x1700BA84 RID: 47748
		// (get) Token: 0x0602B1B2 RID: 176562 RVA: 0x005F1851 File Offset: 0x005EFA51
		// (set) Token: 0x0602B1B3 RID: 176563 RVA: 0x005F1859 File Offset: 0x005EFA59
		public IAudioTypeBase_Union Type { get; set; }

		// Token: 0x1700BA85 RID: 47749
		// (get) Token: 0x0602B1B4 RID: 176564 RVA: 0x005F1862 File Offset: 0x005EFA62
		// (set) Token: 0x0602B1B5 RID: 176565 RVA: 0x005F186A File Offset: 0x005EFA6A
		public object Value { get; set; }

		// Token: 0x0602B1B6 RID: 176566 RVA: 0x005F1873 File Offset: 0x005EFA73
		public IAudioTypeBase_UnionUnion()
		{
			this.Type = IAudioTypeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602B1B7 RID: 176567 RVA: 0x005F1889 File Offset: 0x005EFA89
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602B1B8 RID: 176568 RVA: 0x005F189B File Offset: 0x005EFA9B
		public IAudioTypeBaseT AsIAudioTypeBase()
		{
			return this.As<IAudioTypeBaseT>();
		}

		// Token: 0x0602B1B9 RID: 176569 RVA: 0x005F18A3 File Offset: 0x005EFAA3
		public static IAudioTypeBase_UnionUnion FromIAudioTypeBase(IAudioTypeBaseT _iaudiotypebase)
		{
			return new IAudioTypeBase_UnionUnion
			{
				Type = IAudioTypeBase_Union.IAudioTypeBase,
				Value = _iaudiotypebase
			};
		}

		// Token: 0x0602B1BA RID: 176570 RVA: 0x005F18B8 File Offset: 0x005EFAB8
		public IRoleSceneVoiceT AsIRoleSceneVoice()
		{
			return this.As<IRoleSceneVoiceT>();
		}

		// Token: 0x0602B1BB RID: 176571 RVA: 0x005F18C0 File Offset: 0x005EFAC0
		public static IAudioTypeBase_UnionUnion FromIRoleSceneVoice(IRoleSceneVoiceT _irolescenevoice)
		{
			return new IAudioTypeBase_UnionUnion
			{
				Type = IAudioTypeBase_Union.IRoleSceneVoice,
				Value = _irolescenevoice
			};
		}

		// Token: 0x0602B1BC RID: 176572 RVA: 0x005F18D8 File Offset: 0x005EFAD8
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
