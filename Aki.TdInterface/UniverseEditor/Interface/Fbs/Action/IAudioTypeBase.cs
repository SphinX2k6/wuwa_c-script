using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006823 RID: 26659
	public struct IAudioTypeBase : IFlatbufferObject
	{
		// Token: 0x1700C404 RID: 50180
		// (get) Token: 0x0602D8E7 RID: 186599 RVA: 0x0063C14E File Offset: 0x0063A34E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D8E8 RID: 186600 RVA: 0x0063C15B File Offset: 0x0063A35B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D8E9 RID: 186601 RVA: 0x0063C164 File Offset: 0x0063A364
		public static IAudioTypeBase GetRootAsIAudioTypeBase(ByteBuffer _bb)
		{
			return IAudioTypeBase.GetRootAsIAudioTypeBase(_bb, default(IAudioTypeBase));
		}

		// Token: 0x0602D8EA RID: 186602 RVA: 0x0063C180 File Offset: 0x0063A380
		public static IAudioTypeBase GetRootAsIAudioTypeBase(ByteBuffer _bb, IAudioTypeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D8EB RID: 186603 RVA: 0x0063C19D File Offset: 0x0063A39D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D8EC RID: 186604 RVA: 0x0063C1AC File Offset: 0x0063A3AC
		public IAudioTypeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C405 RID: 50181
		// (get) Token: 0x0602D8ED RID: 186605 RVA: 0x0063C1BC File Offset: 0x0063A3BC
		public EAudioType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAudioType.RoleSceneVoice;
				}
				return (EAudioType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D8EE RID: 186606 RVA: 0x0063C1F8 File Offset: 0x0063A3F8
		public static Offset<IAudioTypeBase> CreateIAudioTypeBase(FlatBufferBuilder builder, EAudioType Type = EAudioType.RoleSceneVoice)
		{
			builder.StartTable(1);
			IAudioTypeBase.AddType(builder, Type);
			return IAudioTypeBase.EndIAudioTypeBase(builder);
		}

		// Token: 0x0602D8EF RID: 186607 RVA: 0x0063C20E File Offset: 0x0063A40E
		public static void StartIAudioTypeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602D8F0 RID: 186608 RVA: 0x0063C217 File Offset: 0x0063A417
		public static void AddType(FlatBufferBuilder builder, EAudioType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D8F1 RID: 186609 RVA: 0x0063C222 File Offset: 0x0063A422
		public static Offset<IAudioTypeBase> EndIAudioTypeBase(FlatBufferBuilder builder)
		{
			return new Offset<IAudioTypeBase>(builder.EndTable());
		}

		// Token: 0x0602D8F2 RID: 186610 RVA: 0x0063C230 File Offset: 0x0063A430
		public IAudioTypeBaseT UnPack()
		{
			IAudioTypeBaseT audioTypeBaseT = new IAudioTypeBaseT();
			this.UnPackTo(audioTypeBaseT);
			return audioTypeBaseT;
		}

		// Token: 0x0602D8F3 RID: 186611 RVA: 0x0063C24B File Offset: 0x0063A44B
		public void UnPackTo(IAudioTypeBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602D8F4 RID: 186612 RVA: 0x0063C25C File Offset: 0x0063A45C
		public static Offset<IAudioTypeBase> Pack(FlatBufferBuilder builder, IAudioTypeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAudioTypeBase>);
			}
			return IAudioTypeBase.CreateIAudioTypeBase(builder, _o.Type);
		}

		// Token: 0x040114E6 RID: 70886
		private Table __p;
	}
}
