using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200101C RID: 4124
	public struct PinballRoleLevelConfig : IFlatbufferObject
	{
		// Token: 0x17002A38 RID: 10808
		// (get) Token: 0x0600B665 RID: 46693 RVA: 0x002E15BA File Offset: 0x002DF7BA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B666 RID: 46694 RVA: 0x002E15C7 File Offset: 0x002DF7C7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B667 RID: 46695 RVA: 0x002E15D0 File Offset: 0x002DF7D0
		public static PinballRoleLevelConfig GetRootAsPinballRoleLevelConfig(ByteBuffer _bb)
		{
			return PinballRoleLevelConfig.GetRootAsPinballRoleLevelConfig(_bb, default(PinballRoleLevelConfig));
		}

		// Token: 0x0600B668 RID: 46696 RVA: 0x002E15EC File Offset: 0x002DF7EC
		public static PinballRoleLevelConfig GetRootAsPinballRoleLevelConfig(ByteBuffer _bb, PinballRoleLevelConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B669 RID: 46697 RVA: 0x002E1609 File Offset: 0x002DF809
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B66A RID: 46698 RVA: 0x002E1618 File Offset: 0x002DF818
		public PinballRoleLevelConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002A39 RID: 10809
		// (get) Token: 0x0600B66B RID: 46699 RVA: 0x002E1628 File Offset: 0x002DF828
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

		// Token: 0x17002A3A RID: 10810
		// (get) Token: 0x0600B66C RID: 46700 RVA: 0x002E1664 File Offset: 0x002DF864
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

		// Token: 0x17002A3B RID: 10811
		// (get) Token: 0x0600B66D RID: 46701 RVA: 0x002E16A0 File Offset: 0x002DF8A0
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

		// Token: 0x17002A3C RID: 10812
		// (get) Token: 0x0600B66E RID: 46702 RVA: 0x002E16DC File Offset: 0x002DF8DC
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

		// Token: 0x17002A3D RID: 10813
		// (get) Token: 0x0600B66F RID: 46703 RVA: 0x002E171C File Offset: 0x002DF91C
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

		// Token: 0x040055E6 RID: 21990
		private Table __p;
	}
}
