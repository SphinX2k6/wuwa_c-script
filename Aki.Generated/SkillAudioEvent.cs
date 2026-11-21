using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011B0 RID: 4528
	public struct SkillAudioEvent : IFlatbufferObject
	{
		// Token: 0x1700375A RID: 14170
		// (get) Token: 0x0600DB01 RID: 56065 RVA: 0x00331793 File Offset: 0x0032F993
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DB02 RID: 56066 RVA: 0x003317A0 File Offset: 0x0032F9A0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DB03 RID: 56067 RVA: 0x003317A8 File Offset: 0x0032F9A8
		public static SkillAudioEvent GetRootAsSkillAudioEvent(ByteBuffer _bb)
		{
			return SkillAudioEvent.GetRootAsSkillAudioEvent(_bb, default(SkillAudioEvent));
		}

		// Token: 0x0600DB04 RID: 56068 RVA: 0x003317C4 File Offset: 0x0032F9C4
		public static SkillAudioEvent GetRootAsSkillAudioEvent(ByteBuffer _bb, SkillAudioEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DB05 RID: 56069 RVA: 0x003317E1 File Offset: 0x0032F9E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DB06 RID: 56070 RVA: 0x003317F0 File Offset: 0x0032F9F0
		public SkillAudioEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700375B RID: 14171
		// (get) Token: 0x0600DB07 RID: 56071 RVA: 0x00331800 File Offset: 0x0032FA00
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700375C RID: 14172
		// (get) Token: 0x0600DB08 RID: 56072 RVA: 0x0033183C File Offset: 0x0032FA3C
		public string EventName
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DB09 RID: 56073 RVA: 0x00331873 File Offset: 0x0032FA73
		public Span<byte> GetEventNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600DB0A RID: 56074 RVA: 0x00331882 File Offset: 0x0032FA82
		public byte[] GetEventNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700375D RID: 14173
		// (get) Token: 0x0600DB0B RID: 56075 RVA: 0x0033189C File Offset: 0x0032FA9C
		public bool Remote
		{
			get
			{
				int num = this.__p.__offset(8);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700375E RID: 14174
		// (get) Token: 0x0600DB0C RID: 56076 RVA: 0x003318DC File Offset: 0x0032FADC
		public int PostProbability
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 100;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700375F RID: 14175
		// (get) Token: 0x0600DB0D RID: 56077 RVA: 0x0033191C File Offset: 0x0032FB1C
		public int ActorColdTime
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040057C9 RID: 22473
		private Table __p;
	}
}
