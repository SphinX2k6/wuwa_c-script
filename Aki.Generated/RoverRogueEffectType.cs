using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001173 RID: 4467
	public struct RoverRogueEffectType : IFlatbufferObject
	{
		// Token: 0x17003549 RID: 13641
		// (get) Token: 0x0600D576 RID: 54646 RVA: 0x0032530C File Offset: 0x0032350C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D577 RID: 54647 RVA: 0x00325319 File Offset: 0x00323519
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D578 RID: 54648 RVA: 0x00325320 File Offset: 0x00323520
		public static RoverRogueEffectType GetRootAsRoverRogueEffectType(ByteBuffer _bb)
		{
			return RoverRogueEffectType.GetRootAsRoverRogueEffectType(_bb, default(RoverRogueEffectType));
		}

		// Token: 0x0600D579 RID: 54649 RVA: 0x0032533C File Offset: 0x0032353C
		public static RoverRogueEffectType GetRootAsRoverRogueEffectType(ByteBuffer _bb, RoverRogueEffectType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D57A RID: 54650 RVA: 0x00325359 File Offset: 0x00323559
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D57B RID: 54651 RVA: 0x00325368 File Offset: 0x00323568
		public RoverRogueEffectType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700354A RID: 13642
		// (get) Token: 0x0600D57C RID: 54652 RVA: 0x00325378 File Offset: 0x00323578
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

		// Token: 0x04005781 RID: 22401
		private Table __p;
	}
}
