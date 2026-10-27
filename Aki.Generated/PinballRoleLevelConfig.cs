using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F37 RID: 3895
	public struct PinballRoleLevelConfig : IFlatbufferObject
	{
		// Token: 0x170029D2 RID: 10706
		// (get) Token: 0x0600B044 RID: 45124 RVA: 0x002C4C5D File Offset: 0x002C2E5D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B045 RID: 45125 RVA: 0x002C4C6A File Offset: 0x002C2E6A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B046 RID: 45126 RVA: 0x002C4C74 File Offset: 0x002C2E74
		public static PinballRoleLevelConfig GetRootAsPinballRoleLevelConfig(ByteBuffer _bb)
		{
			return PinballRoleLevelConfig.GetRootAsPinballRoleLevelConfig(_bb, default(PinballRoleLevelConfig));
		}

		// Token: 0x0600B047 RID: 45127 RVA: 0x002C4C90 File Offset: 0x002C2E90
		public static PinballRoleLevelConfig GetRootAsPinballRoleLevelConfig(ByteBuffer _bb, PinballRoleLevelConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B048 RID: 45128 RVA: 0x002C4CAD File Offset: 0x002C2EAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B049 RID: 45129 RVA: 0x002C4CBC File Offset: 0x002C2EBC
		public PinballRoleLevelConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170029D3 RID: 10707
		// (get) Token: 0x0600B04A RID: 45130 RVA: 0x002C4CCC File Offset: 0x002C2ECC
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

		// Token: 0x170029D4 RID: 10708
		// (get) Token: 0x0600B04B RID: 45131 RVA: 0x002C4D08 File Offset: 0x002C2F08
		public int GroupId
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

		// Token: 0x170029D5 RID: 10709
		// (get) Token: 0x0600B04C RID: 45132 RVA: 0x002C4D44 File Offset: 0x002C2F44
		public int Level
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170029D6 RID: 10710
		// (get) Token: 0x0600B04D RID: 45133 RVA: 0x002C4D80 File Offset: 0x002C2F80
		public int Consume
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170029D7 RID: 10711
		// (get) Token: 0x0600B04E RID: 45134 RVA: 0x002C4DC0 File Offset: 0x002C2FC0
		public int Prop
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

		// Token: 0x04005001 RID: 20481
		private Table __p;
	}
}
