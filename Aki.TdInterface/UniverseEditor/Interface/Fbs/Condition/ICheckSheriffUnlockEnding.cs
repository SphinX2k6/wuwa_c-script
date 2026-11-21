using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200500D RID: 20493
	public struct ICheckSheriffUnlockEnding : IFlatbufferObject
	{
		// Token: 0x1700929F RID: 37535
		// (get) Token: 0x0601FFCB RID: 131019 RVA: 0x00470851 File Offset: 0x0046EA51
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FFCC RID: 131020 RVA: 0x0047085E File Offset: 0x0046EA5E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FFCD RID: 131021 RVA: 0x00470868 File Offset: 0x0046EA68
		public static ICheckSheriffUnlockEnding GetRootAsICheckSheriffUnlockEnding(ByteBuffer _bb)
		{
			return ICheckSheriffUnlockEnding.GetRootAsICheckSheriffUnlockEnding(_bb, default(ICheckSheriffUnlockEnding));
		}

		// Token: 0x0601FFCE RID: 131022 RVA: 0x00470884 File Offset: 0x0046EA84
		public static ICheckSheriffUnlockEnding GetRootAsICheckSheriffUnlockEnding(ByteBuffer _bb, ICheckSheriffUnlockEnding obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FFCF RID: 131023 RVA: 0x004708A1 File Offset: 0x0046EAA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FFD0 RID: 131024 RVA: 0x004708B0 File Offset: 0x0046EAB0
		public ICheckSheriffUnlockEnding __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170092A0 RID: 37536
		// (get) Token: 0x0601FFD1 RID: 131025 RVA: 0x004708C0 File Offset: 0x0046EAC0
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170092A1 RID: 37537
		// (get) Token: 0x0601FFD2 RID: 131026 RVA: 0x004708FC File Offset: 0x0046EAFC
		public int AnomalyId
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

		// Token: 0x170092A2 RID: 37538
		// (get) Token: 0x0601FFD3 RID: 131027 RVA: 0x00470938 File Offset: 0x0046EB38
		public int EndingId
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

		// Token: 0x0601FFD4 RID: 131028 RVA: 0x00470974 File Offset: 0x0046EB74
		public static Offset<ICheckSheriffUnlockEnding> CreateICheckSheriffUnlockEnding(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int AnomalyId = 0, int EndingId = 0)
		{
			builder.StartTable(3);
			ICheckSheriffUnlockEnding.AddEndingId(builder, EndingId);
			ICheckSheriffUnlockEnding.AddAnomalyId(builder, AnomalyId);
			ICheckSheriffUnlockEnding.AddType(builder, Type);
			return ICheckSheriffUnlockEnding.EndICheckSheriffUnlockEnding(builder);
		}

		// Token: 0x0601FFD5 RID: 131029 RVA: 0x00470998 File Offset: 0x0046EB98
		public static void StartICheckSheriffUnlockEnding(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601FFD6 RID: 131030 RVA: 0x004709A1 File Offset: 0x0046EBA1
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FFD7 RID: 131031 RVA: 0x004709AC File Offset: 0x0046EBAC
		public static void AddAnomalyId(FlatBufferBuilder builder, int anomalyId)
		{
			builder.AddInt(1, anomalyId, 0);
		}

		// Token: 0x0601FFD8 RID: 131032 RVA: 0x004709B7 File Offset: 0x0046EBB7
		public static void AddEndingId(FlatBufferBuilder builder, int endingId)
		{
			builder.AddInt(2, endingId, 0);
		}

		// Token: 0x0601FFD9 RID: 131033 RVA: 0x004709C2 File Offset: 0x0046EBC2
		public static Offset<ICheckSheriffUnlockEnding> EndICheckSheriffUnlockEnding(FlatBufferBuilder builder)
		{
			return new Offset<ICheckSheriffUnlockEnding>(builder.EndTable());
		}

		// Token: 0x0601FFDA RID: 131034 RVA: 0x004709D0 File Offset: 0x0046EBD0
		public ICheckSheriffUnlockEndingT UnPack()
		{
			ICheckSheriffUnlockEndingT checkSheriffUnlockEndingT = new ICheckSheriffUnlockEndingT();
			this.UnPackTo(checkSheriffUnlockEndingT);
			return checkSheriffUnlockEndingT;
		}

		// Token: 0x0601FFDB RID: 131035 RVA: 0x004709EB File Offset: 0x0046EBEB
		public void UnPackTo(ICheckSheriffUnlockEndingT _o)
		{
			_o.Type = this.Type;
			_o.AnomalyId = this.AnomalyId;
			_o.EndingId = this.EndingId;
		}

		// Token: 0x0601FFDC RID: 131036 RVA: 0x00470A14 File Offset: 0x0046EC14
		public static Offset<ICheckSheriffUnlockEnding> Pack(FlatBufferBuilder builder, ICheckSheriffUnlockEndingT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckSheriffUnlockEnding>);
			}
			return ICheckSheriffUnlockEnding.CreateICheckSheriffUnlockEnding(builder, _o.Type, _o.AnomalyId, _o.EndingId);
		}

		// Token: 0x0400DEC9 RID: 57033
		private Table __p;
	}
}
