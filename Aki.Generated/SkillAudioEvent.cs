using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010B5 RID: 4277
	public struct SkillAudioEvent : IFlatbufferObject
	{
		// Token: 0x17003649 RID: 13897
		// (get) Token: 0x0600D324 RID: 54052 RVA: 0x003122D1 File Offset: 0x003104D1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D325 RID: 54053 RVA: 0x003122DE File Offset: 0x003104DE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D326 RID: 54054 RVA: 0x003122E8 File Offset: 0x003104E8
		public static SkillAudioEvent GetRootAsSkillAudioEvent(ByteBuffer _bb)
		{
			return SkillAudioEvent.GetRootAsSkillAudioEvent(_bb, default(SkillAudioEvent));
		}

		// Token: 0x0600D327 RID: 54055 RVA: 0x00312304 File Offset: 0x00310504
		public static SkillAudioEvent GetRootAsSkillAudioEvent(ByteBuffer _bb, SkillAudioEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D328 RID: 54056 RVA: 0x00312321 File Offset: 0x00310521
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D329 RID: 54057 RVA: 0x00312330 File Offset: 0x00310530
		public SkillAudioEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700364A RID: 13898
		// (get) Token: 0x0600D32A RID: 54058 RVA: 0x00312340 File Offset: 0x00310540
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

		// Token: 0x1700364B RID: 13899
		// (get) Token: 0x0600D32B RID: 54059 RVA: 0x0031237C File Offset: 0x0031057C
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

		// Token: 0x0600D32C RID: 54060 RVA: 0x003123B3 File Offset: 0x003105B3
		public Span<byte> GetEventNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600D32D RID: 54061 RVA: 0x003123C2 File Offset: 0x003105C2
		public byte[] GetEventNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700364C RID: 13900
		// (get) Token: 0x0600D32E RID: 54062 RVA: 0x003123DC File Offset: 0x003105DC
		public bool Remote
		{
			get
			{
				int num = this.__p.__offset(8);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700364D RID: 13901
		// (get) Token: 0x0600D32F RID: 54063 RVA: 0x0031241C File Offset: 0x0031061C
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

		// Token: 0x1700364E RID: 13902
		// (get) Token: 0x0600D330 RID: 54064 RVA: 0x0031245C File Offset: 0x0031065C
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

		// Token: 0x040051CA RID: 20938
		private Table __p;
	}
}
