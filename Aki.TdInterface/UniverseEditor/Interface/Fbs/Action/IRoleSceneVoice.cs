using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EF7 RID: 28407
	public struct IRoleSceneVoice : IFlatbufferObject
	{
		// Token: 0x1700D34C RID: 54092
		// (get) Token: 0x0603231D RID: 205597 RVA: 0x006C8656 File Offset: 0x006C6856
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603231E RID: 205598 RVA: 0x006C8663 File Offset: 0x006C6863
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603231F RID: 205599 RVA: 0x006C866C File Offset: 0x006C686C
		public static IRoleSceneVoice GetRootAsIRoleSceneVoice(ByteBuffer _bb)
		{
			return IRoleSceneVoice.GetRootAsIRoleSceneVoice(_bb, default(IRoleSceneVoice));
		}

		// Token: 0x06032320 RID: 205600 RVA: 0x006C8688 File Offset: 0x006C6888
		public static IRoleSceneVoice GetRootAsIRoleSceneVoice(ByteBuffer _bb, IRoleSceneVoice obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032321 RID: 205601 RVA: 0x006C86A5 File Offset: 0x006C68A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032322 RID: 205602 RVA: 0x006C86B4 File Offset: 0x006C68B4
		public IRoleSceneVoice __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D34D RID: 54093
		// (get) Token: 0x06032323 RID: 205603 RVA: 0x006C86C4 File Offset: 0x006C68C4
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

		// Token: 0x1700D34E RID: 54094
		// (get) Token: 0x06032324 RID: 205604 RVA: 0x006C8700 File Offset: 0x006C6900
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

		// Token: 0x06032325 RID: 205605 RVA: 0x006C873C File Offset: 0x006C693C
		public static Offset<IRoleSceneVoice> CreateIRoleSceneVoice(FlatBufferBuilder builder, EAudioType Type = EAudioType.RoleSceneVoice, int VoiceGroupData = 0)
		{
			builder.StartTable(2);
			IRoleSceneVoice.AddVoiceGroupData(builder, VoiceGroupData);
			IRoleSceneVoice.AddType(builder, Type);
			return IRoleSceneVoice.EndIRoleSceneVoice(builder);
		}

		// Token: 0x06032326 RID: 205606 RVA: 0x006C8759 File Offset: 0x006C6959
		public static void StartIRoleSceneVoice(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06032327 RID: 205607 RVA: 0x006C8762 File Offset: 0x006C6962
		public static void AddType(FlatBufferBuilder builder, EAudioType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032328 RID: 205608 RVA: 0x006C876D File Offset: 0x006C696D
		public static void AddVoiceGroupData(FlatBufferBuilder builder, int voiceGroupData)
		{
			builder.AddInt(1, voiceGroupData, 0);
		}

		// Token: 0x06032329 RID: 205609 RVA: 0x006C8778 File Offset: 0x006C6978
		public static Offset<IRoleSceneVoice> EndIRoleSceneVoice(FlatBufferBuilder builder)
		{
			return new Offset<IRoleSceneVoice>(builder.EndTable());
		}

		// Token: 0x0603232A RID: 205610 RVA: 0x006C8788 File Offset: 0x006C6988
		public IRoleSceneVoiceT UnPack()
		{
			IRoleSceneVoiceT roleSceneVoiceT = new IRoleSceneVoiceT();
			this.UnPackTo(roleSceneVoiceT);
			return roleSceneVoiceT;
		}

		// Token: 0x0603232B RID: 205611 RVA: 0x006C87A3 File Offset: 0x006C69A3
		public void UnPackTo(IRoleSceneVoiceT _o)
		{
			_o.Type = this.Type;
			_o.VoiceGroupData = this.VoiceGroupData;
		}

		// Token: 0x0603232C RID: 205612 RVA: 0x006C87C0 File Offset: 0x006C69C0
		public static Offset<IRoleSceneVoice> Pack(FlatBufferBuilder builder, IRoleSceneVoiceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoleSceneVoice>);
			}
			return IRoleSceneVoice.CreateIRoleSceneVoice(builder, _o.Type, _o.VoiceGroupData);
		}

		// Token: 0x040118EC RID: 71916
		private Table __p;
	}
}
