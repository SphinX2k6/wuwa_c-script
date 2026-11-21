using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200788A RID: 30858
	public struct ISheriffChangeCriminalState : IFlatbufferObject
	{
		// Token: 0x1700E24C RID: 57932
		// (get) Token: 0x0603648A RID: 222346 RVA: 0x007452FA File Offset: 0x007434FA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603648B RID: 222347 RVA: 0x00745307 File Offset: 0x00743507
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603648C RID: 222348 RVA: 0x00745310 File Offset: 0x00743510
		public static ISheriffChangeCriminalState GetRootAsISheriffChangeCriminalState(ByteBuffer _bb)
		{
			return ISheriffChangeCriminalState.GetRootAsISheriffChangeCriminalState(_bb, default(ISheriffChangeCriminalState));
		}

		// Token: 0x0603648D RID: 222349 RVA: 0x0074532C File Offset: 0x0074352C
		public static ISheriffChangeCriminalState GetRootAsISheriffChangeCriminalState(ByteBuffer _bb, ISheriffChangeCriminalState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603648E RID: 222350 RVA: 0x00745349 File Offset: 0x00743549
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603648F RID: 222351 RVA: 0x00745358 File Offset: 0x00743558
		public ISheriffChangeCriminalState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E24D RID: 57933
		// (get) Token: 0x06036490 RID: 222352 RVA: 0x00745368 File Offset: 0x00743568
		public int CriminalId
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

		// Token: 0x1700E24E RID: 57934
		// (get) Token: 0x06036491 RID: 222353 RVA: 0x007453A4 File Offset: 0x007435A4
		public ESheriffCriminalState CriminalState
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ESheriffCriminalState.None;
				}
				return (ESheriffCriminalState)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036492 RID: 222354 RVA: 0x007453E0 File Offset: 0x007435E0
		public static Offset<ISheriffChangeCriminalState> CreateISheriffChangeCriminalState(FlatBufferBuilder builder, int CriminalId = 0, ESheriffCriminalState CriminalState = ESheriffCriminalState.None)
		{
			builder.StartTable(2);
			ISheriffChangeCriminalState.AddCriminalId(builder, CriminalId);
			ISheriffChangeCriminalState.AddCriminalState(builder, CriminalState);
			return ISheriffChangeCriminalState.EndISheriffChangeCriminalState(builder);
		}

		// Token: 0x06036493 RID: 222355 RVA: 0x007453FD File Offset: 0x007435FD
		public static void StartISheriffChangeCriminalState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06036494 RID: 222356 RVA: 0x00745406 File Offset: 0x00743606
		public static void AddCriminalId(FlatBufferBuilder builder, int criminalId)
		{
			builder.AddInt(0, criminalId, 0);
		}

		// Token: 0x06036495 RID: 222357 RVA: 0x00745411 File Offset: 0x00743611
		public static void AddCriminalState(FlatBufferBuilder builder, ESheriffCriminalState criminalState)
		{
			builder.AddByte(1, (byte)criminalState, 0);
		}

		// Token: 0x06036496 RID: 222358 RVA: 0x0074541C File Offset: 0x0074361C
		public static Offset<ISheriffChangeCriminalState> EndISheriffChangeCriminalState(FlatBufferBuilder builder)
		{
			return new Offset<ISheriffChangeCriminalState>(builder.EndTable());
		}

		// Token: 0x06036497 RID: 222359 RVA: 0x0074542C File Offset: 0x0074362C
		public ISheriffChangeCriminalStateT UnPack()
		{
			ISheriffChangeCriminalStateT sheriffChangeCriminalStateT = new ISheriffChangeCriminalStateT();
			this.UnPackTo(sheriffChangeCriminalStateT);
			return sheriffChangeCriminalStateT;
		}

		// Token: 0x06036498 RID: 222360 RVA: 0x00745447 File Offset: 0x00743647
		public void UnPackTo(ISheriffChangeCriminalStateT _o)
		{
			_o.CriminalId = this.CriminalId;
			_o.CriminalState = this.CriminalState;
		}

		// Token: 0x06036499 RID: 222361 RVA: 0x00745464 File Offset: 0x00743664
		public static Offset<ISheriffChangeCriminalState> Pack(FlatBufferBuilder builder, ISheriffChangeCriminalStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISheriffChangeCriminalState>);
			}
			return ISheriffChangeCriminalState.CreateISheriffChangeCriminalState(builder, _o.CriminalId, _o.CriminalState);
		}

		// Token: 0x04012B1B RID: 76571
		private Table __p;
	}
}
