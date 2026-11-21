using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F7D RID: 28541
	public struct IHeadStyleMonsterDisplay : IFlatbufferObject
	{
		// Token: 0x1700D10C RID: 53516
		// (get) Token: 0x06031662 RID: 202338 RVA: 0x006B2D71 File Offset: 0x006B0F71
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031663 RID: 202339 RVA: 0x006B2D7E File Offset: 0x006B0F7E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031664 RID: 202340 RVA: 0x006B2D88 File Offset: 0x006B0F88
		public static IHeadStyleMonsterDisplay GetRootAsIHeadStyleMonsterDisplay(ByteBuffer _bb)
		{
			return IHeadStyleMonsterDisplay.GetRootAsIHeadStyleMonsterDisplay(_bb, default(IHeadStyleMonsterDisplay));
		}

		// Token: 0x06031665 RID: 202341 RVA: 0x006B2DA4 File Offset: 0x006B0FA4
		public static IHeadStyleMonsterDisplay GetRootAsIHeadStyleMonsterDisplay(ByteBuffer _bb, IHeadStyleMonsterDisplay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031666 RID: 202342 RVA: 0x006B2DC1 File Offset: 0x006B0FC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031667 RID: 202343 RVA: 0x006B2DD0 File Offset: 0x006B0FD0
		public IHeadStyleMonsterDisplay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D10D RID: 53517
		// (get) Token: 0x06031668 RID: 202344 RVA: 0x006B2DE0 File Offset: 0x006B0FE0
		public EHeadStyle Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHeadStyle.Normal;
				}
				return (EHeadStyle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D10E RID: 53518
		// (get) Token: 0x06031669 RID: 202345 RVA: 0x006B2E1C File Offset: 0x006B101C
		public int MonsterDisplayId
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

		// Token: 0x0603166A RID: 202346 RVA: 0x006B2E58 File Offset: 0x006B1058
		public static Offset<IHeadStyleMonsterDisplay> CreateIHeadStyleMonsterDisplay(FlatBufferBuilder builder, EHeadStyle Type = EHeadStyle.Normal, int MonsterDisplayId = 0)
		{
			builder.StartTable(2);
			IHeadStyleMonsterDisplay.AddMonsterDisplayId(builder, MonsterDisplayId);
			IHeadStyleMonsterDisplay.AddType(builder, Type);
			return IHeadStyleMonsterDisplay.EndIHeadStyleMonsterDisplay(builder);
		}

		// Token: 0x0603166B RID: 202347 RVA: 0x006B2E75 File Offset: 0x006B1075
		public static void StartIHeadStyleMonsterDisplay(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603166C RID: 202348 RVA: 0x006B2E7E File Offset: 0x006B107E
		public static void AddType(FlatBufferBuilder builder, EHeadStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603166D RID: 202349 RVA: 0x006B2E89 File Offset: 0x006B1089
		public static void AddMonsterDisplayId(FlatBufferBuilder builder, int monsterDisplayId)
		{
			builder.AddInt(1, monsterDisplayId, 0);
		}

		// Token: 0x0603166E RID: 202350 RVA: 0x006B2E94 File Offset: 0x006B1094
		public static Offset<IHeadStyleMonsterDisplay> EndIHeadStyleMonsterDisplay(FlatBufferBuilder builder)
		{
			return new Offset<IHeadStyleMonsterDisplay>(builder.EndTable());
		}

		// Token: 0x0603166F RID: 202351 RVA: 0x006B2EA4 File Offset: 0x006B10A4
		public IHeadStyleMonsterDisplayT UnPack()
		{
			IHeadStyleMonsterDisplayT headStyleMonsterDisplayT = new IHeadStyleMonsterDisplayT();
			this.UnPackTo(headStyleMonsterDisplayT);
			return headStyleMonsterDisplayT;
		}

		// Token: 0x06031670 RID: 202352 RVA: 0x006B2EBF File Offset: 0x006B10BF
		public void UnPackTo(IHeadStyleMonsterDisplayT _o)
		{
			_o.Type = this.Type;
			_o.MonsterDisplayId = this.MonsterDisplayId;
		}

		// Token: 0x06031671 RID: 202353 RVA: 0x006B2EDC File Offset: 0x006B10DC
		public static Offset<IHeadStyleMonsterDisplay> Pack(FlatBufferBuilder builder, IHeadStyleMonsterDisplayT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHeadStyleMonsterDisplay>);
			}
			return IHeadStyleMonsterDisplay.CreateIHeadStyleMonsterDisplay(builder, _o.Type, _o.MonsterDisplayId);
		}

		// Token: 0x04011E90 RID: 73360
		private Table __p;
	}
}
