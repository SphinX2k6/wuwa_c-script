using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061B5 RID: 25013
	public struct IAudioTypeBase : IFlatbufferObject
	{
		// Token: 0x1700BA81 RID: 47745
		// (get) Token: 0x0602B1A0 RID: 176544 RVA: 0x005F16DA File Offset: 0x005EF8DA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B1A1 RID: 176545 RVA: 0x005F16E7 File Offset: 0x005EF8E7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B1A2 RID: 176546 RVA: 0x005F16F0 File Offset: 0x005EF8F0
		public static IAudioTypeBase GetRootAsIAudioTypeBase(ByteBuffer _bb)
		{
			return IAudioTypeBase.GetRootAsIAudioTypeBase(_bb, default(IAudioTypeBase));
		}

		// Token: 0x0602B1A3 RID: 176547 RVA: 0x005F170C File Offset: 0x005EF90C
		public static IAudioTypeBase GetRootAsIAudioTypeBase(ByteBuffer _bb, IAudioTypeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B1A4 RID: 176548 RVA: 0x005F1729 File Offset: 0x005EF929
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B1A5 RID: 176549 RVA: 0x005F1738 File Offset: 0x005EF938
		public IAudioTypeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BA82 RID: 47746
		// (get) Token: 0x0602B1A6 RID: 176550 RVA: 0x005F1748 File Offset: 0x005EF948
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

		// Token: 0x0602B1A7 RID: 176551 RVA: 0x005F1784 File Offset: 0x005EF984
		public static Offset<IAudioTypeBase> CreateIAudioTypeBase(FlatBufferBuilder builder, EAudioType Type = EAudioType.RoleSceneVoice)
		{
			builder.StartTable(1);
			IAudioTypeBase.AddType(builder, Type);
			return IAudioTypeBase.EndIAudioTypeBase(builder);
		}

		// Token: 0x0602B1A8 RID: 176552 RVA: 0x005F179A File Offset: 0x005EF99A
		public static void StartIAudioTypeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602B1A9 RID: 176553 RVA: 0x005F17A3 File Offset: 0x005EF9A3
		public static void AddType(FlatBufferBuilder builder, EAudioType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B1AA RID: 176554 RVA: 0x005F17AE File Offset: 0x005EF9AE
		public static Offset<IAudioTypeBase> EndIAudioTypeBase(FlatBufferBuilder builder)
		{
			return new Offset<IAudioTypeBase>(builder.EndTable());
		}

		// Token: 0x0602B1AB RID: 176555 RVA: 0x005F17BC File Offset: 0x005EF9BC
		public IAudioTypeBaseT UnPack()
		{
			IAudioTypeBaseT audioTypeBaseT = new IAudioTypeBaseT();
			this.UnPackTo(audioTypeBaseT);
			return audioTypeBaseT;
		}

		// Token: 0x0602B1AC RID: 176556 RVA: 0x005F17D7 File Offset: 0x005EF9D7
		public void UnPackTo(IAudioTypeBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602B1AD RID: 176557 RVA: 0x005F17E8 File Offset: 0x005EF9E8
		public static Offset<IAudioTypeBase> Pack(FlatBufferBuilder builder, IAudioTypeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAudioTypeBase>);
			}
			return IAudioTypeBase.CreateIAudioTypeBase(builder, _o.Type);
		}

		// Token: 0x040106D4 RID: 67284
		private Table __p;
	}
}
