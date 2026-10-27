using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A51 RID: 19025
	public struct ICheckHonamiStoryActivateTalent : IFlatbufferObject
	{
		// Token: 0x170089B5 RID: 35253
		// (get) Token: 0x0601DCA8 RID: 122024 RVA: 0x00430154 File Offset: 0x0042E354
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DCA9 RID: 122025 RVA: 0x00430161 File Offset: 0x0042E361
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DCAA RID: 122026 RVA: 0x00430168 File Offset: 0x0042E368
		public static ICheckHonamiStoryActivateTalent GetRootAsICheckHonamiStoryActivateTalent(ByteBuffer _bb)
		{
			return ICheckHonamiStoryActivateTalent.GetRootAsICheckHonamiStoryActivateTalent(_bb, default(ICheckHonamiStoryActivateTalent));
		}

		// Token: 0x0601DCAB RID: 122027 RVA: 0x00430184 File Offset: 0x0042E384
		public static ICheckHonamiStoryActivateTalent GetRootAsICheckHonamiStoryActivateTalent(ByteBuffer _bb, ICheckHonamiStoryActivateTalent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DCAC RID: 122028 RVA: 0x004301A1 File Offset: 0x0042E3A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DCAD RID: 122029 RVA: 0x004301B0 File Offset: 0x0042E3B0
		public ICheckHonamiStoryActivateTalent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170089B6 RID: 35254
		// (get) Token: 0x0601DCAE RID: 122030 RVA: 0x004301C0 File Offset: 0x0042E3C0
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

		// Token: 0x170089B7 RID: 35255
		// (get) Token: 0x0601DCAF RID: 122031 RVA: 0x004301FC File Offset: 0x0042E3FC
		public int TalentId
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

		// Token: 0x170089B8 RID: 35256
		// (get) Token: 0x0601DCB0 RID: 122032 RVA: 0x00430238 File Offset: 0x0042E438
		public bool IsActivated
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601DCB1 RID: 122033 RVA: 0x00430277 File Offset: 0x0042E477
		public static Offset<ICheckHonamiStoryActivateTalent> CreateICheckHonamiStoryActivateTalent(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int TalentId = 0, bool IsActivated = false)
		{
			builder.StartTable(3);
			ICheckHonamiStoryActivateTalent.AddTalentId(builder, TalentId);
			ICheckHonamiStoryActivateTalent.AddIsActivated(builder, IsActivated);
			ICheckHonamiStoryActivateTalent.AddType(builder, Type);
			return ICheckHonamiStoryActivateTalent.EndICheckHonamiStoryActivateTalent(builder);
		}

		// Token: 0x0601DCB2 RID: 122034 RVA: 0x0043029B File Offset: 0x0042E49B
		public static void StartICheckHonamiStoryActivateTalent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601DCB3 RID: 122035 RVA: 0x004302A4 File Offset: 0x0042E4A4
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DCB4 RID: 122036 RVA: 0x004302AF File Offset: 0x0042E4AF
		public static void AddTalentId(FlatBufferBuilder builder, int talentId)
		{
			builder.AddInt(1, talentId, 0);
		}

		// Token: 0x0601DCB5 RID: 122037 RVA: 0x004302BA File Offset: 0x0042E4BA
		public static void AddIsActivated(FlatBufferBuilder builder, bool isActivated)
		{
			builder.AddBool(2, isActivated, false);
		}

		// Token: 0x0601DCB6 RID: 122038 RVA: 0x004302C5 File Offset: 0x0042E4C5
		public static Offset<ICheckHonamiStoryActivateTalent> EndICheckHonamiStoryActivateTalent(FlatBufferBuilder builder)
		{
			return new Offset<ICheckHonamiStoryActivateTalent>(builder.EndTable());
		}

		// Token: 0x0601DCB7 RID: 122039 RVA: 0x004302D4 File Offset: 0x0042E4D4
		public ICheckHonamiStoryActivateTalentT UnPack()
		{
			ICheckHonamiStoryActivateTalentT checkHonamiStoryActivateTalentT = new ICheckHonamiStoryActivateTalentT();
			this.UnPackTo(checkHonamiStoryActivateTalentT);
			return checkHonamiStoryActivateTalentT;
		}

		// Token: 0x0601DCB8 RID: 122040 RVA: 0x004302EF File Offset: 0x0042E4EF
		public void UnPackTo(ICheckHonamiStoryActivateTalentT _o)
		{
			_o.Type = this.Type;
			_o.TalentId = this.TalentId;
			_o.IsActivated = this.IsActivated;
		}

		// Token: 0x0601DCB9 RID: 122041 RVA: 0x00430318 File Offset: 0x0042E518
		public static Offset<ICheckHonamiStoryActivateTalent> Pack(FlatBufferBuilder builder, ICheckHonamiStoryActivateTalentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckHonamiStoryActivateTalent>);
			}
			return ICheckHonamiStoryActivateTalent.CreateICheckHonamiStoryActivateTalent(builder, _o.Type, _o.TalentId, _o.IsActivated);
		}

		// Token: 0x0400D2AB RID: 53931
		private Table __p;
	}
}
