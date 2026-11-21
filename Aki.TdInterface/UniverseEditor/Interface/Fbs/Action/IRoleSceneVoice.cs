using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200767B RID: 30331
	public struct IRoleSceneVoice : IFlatbufferObject
	{
		// Token: 0x1700DEA3 RID: 56995
		// (get) Token: 0x0603535D RID: 217949 RVA: 0x0072438A File Offset: 0x0072258A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603535E RID: 217950 RVA: 0x00724397 File Offset: 0x00722597
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603535F RID: 217951 RVA: 0x007243A0 File Offset: 0x007225A0
		public static IRoleSceneVoice GetRootAsIRoleSceneVoice(ByteBuffer _bb)
		{
			return IRoleSceneVoice.GetRootAsIRoleSceneVoice(_bb, default(IRoleSceneVoice));
		}

		// Token: 0x06035360 RID: 217952 RVA: 0x007243BC File Offset: 0x007225BC
		public static IRoleSceneVoice GetRootAsIRoleSceneVoice(ByteBuffer _bb, IRoleSceneVoice obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035361 RID: 217953 RVA: 0x007243D9 File Offset: 0x007225D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035362 RID: 217954 RVA: 0x007243E8 File Offset: 0x007225E8
		public IRoleSceneVoice __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DEA4 RID: 56996
		// (get) Token: 0x06035363 RID: 217955 RVA: 0x007243F8 File Offset: 0x007225F8
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

		// Token: 0x1700DEA5 RID: 56997
		// (get) Token: 0x06035364 RID: 217956 RVA: 0x00724434 File Offset: 0x00722634
		public int VoiceGroupData
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035365 RID: 217957 RVA: 0x00724470 File Offset: 0x00722670
		public static Offset<IRoleSceneVoice> CreateIRoleSceneVoice(FlatBufferBuilder builder, EAudioType Type = EAudioType.RoleSceneVoice, int VoiceGroupData = 0)
		{
			builder.StartTable(2);
			IRoleSceneVoice.AddVoiceGroupData(builder, VoiceGroupData);
			IRoleSceneVoice.AddType(builder, Type);
			return IRoleSceneVoice.EndIRoleSceneVoice(builder);
		}

		// Token: 0x06035366 RID: 217958 RVA: 0x0072448D File Offset: 0x0072268D
		public static void StartIRoleSceneVoice(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06035367 RID: 217959 RVA: 0x00724496 File Offset: 0x00722696
		public static void AddType(FlatBufferBuilder builder, EAudioType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035368 RID: 217960 RVA: 0x007244A1 File Offset: 0x007226A1
		public static void AddVoiceGroupData(FlatBufferBuilder builder, int voiceGroupData)
		{
			builder.AddInt(1, voiceGroupData, 0);
		}

		// Token: 0x06035369 RID: 217961 RVA: 0x007244AC File Offset: 0x007226AC
		public static Offset<IRoleSceneVoice> EndIRoleSceneVoice(FlatBufferBuilder builder)
		{
			return new Offset<IRoleSceneVoice>(builder.EndTable());
		}

		// Token: 0x0603536A RID: 217962 RVA: 0x007244BC File Offset: 0x007226BC
		public IRoleSceneVoiceT UnPack()
		{
			IRoleSceneVoiceT roleSceneVoiceT = new IRoleSceneVoiceT();
			this.UnPackTo(roleSceneVoiceT);
			return roleSceneVoiceT;
		}

		// Token: 0x0603536B RID: 217963 RVA: 0x007244D7 File Offset: 0x007226D7
		public void UnPackTo(IRoleSceneVoiceT _o)
		{
			_o.Type = this.Type;
			_o.VoiceGroupData = this.VoiceGroupData;
		}

		// Token: 0x0603536C RID: 217964 RVA: 0x007244F4 File Offset: 0x007226F4
		public static Offset<IRoleSceneVoice> Pack(FlatBufferBuilder builder, IRoleSceneVoiceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoleSceneVoice>);
			}
			return IRoleSceneVoice.CreateIRoleSceneVoice(builder, _o.Type, _o.VoiceGroupData);
		}

		// Token: 0x04012871 RID: 75889
		private Table __p;
	}
}
