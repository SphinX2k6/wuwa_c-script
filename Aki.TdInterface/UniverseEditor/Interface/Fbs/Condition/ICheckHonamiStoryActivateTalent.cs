using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F17 RID: 20247
	public struct ICheckHonamiStoryActivateTalent : IFlatbufferObject
	{
		// Token: 0x17009091 RID: 37009
		// (get) Token: 0x0601F74B RID: 128843 RVA: 0x004612E0 File Offset: 0x0045F4E0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F74C RID: 128844 RVA: 0x004612ED File Offset: 0x0045F4ED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F74D RID: 128845 RVA: 0x004612F4 File Offset: 0x0045F4F4
		public static ICheckHonamiStoryActivateTalent GetRootAsICheckHonamiStoryActivateTalent(ByteBuffer _bb)
		{
			return ICheckHonamiStoryActivateTalent.GetRootAsICheckHonamiStoryActivateTalent(_bb, default(ICheckHonamiStoryActivateTalent));
		}

		// Token: 0x0601F74E RID: 128846 RVA: 0x00461310 File Offset: 0x0045F510
		public static ICheckHonamiStoryActivateTalent GetRootAsICheckHonamiStoryActivateTalent(ByteBuffer _bb, ICheckHonamiStoryActivateTalent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F74F RID: 128847 RVA: 0x0046132D File Offset: 0x0045F52D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F750 RID: 128848 RVA: 0x0046133C File Offset: 0x0045F53C
		public ICheckHonamiStoryActivateTalent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009092 RID: 37010
		// (get) Token: 0x0601F751 RID: 128849 RVA: 0x0046134C File Offset: 0x0045F54C
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

		// Token: 0x17009093 RID: 37011
		// (get) Token: 0x0601F752 RID: 128850 RVA: 0x00461388 File Offset: 0x0045F588
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

		// Token: 0x17009094 RID: 37012
		// (get) Token: 0x0601F753 RID: 128851 RVA: 0x004613C4 File Offset: 0x0045F5C4
		public bool IsActivated
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601F754 RID: 128852 RVA: 0x00461403 File Offset: 0x0045F603
		public static Offset<ICheckHonamiStoryActivateTalent> CreateICheckHonamiStoryActivateTalent(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int TalentId = 0, bool IsActivated = false)
		{
			builder.StartTable(3);
			ICheckHonamiStoryActivateTalent.AddTalentId(builder, TalentId);
			ICheckHonamiStoryActivateTalent.AddIsActivated(builder, IsActivated);
			ICheckHonamiStoryActivateTalent.AddType(builder, Type);
			return ICheckHonamiStoryActivateTalent.EndICheckHonamiStoryActivateTalent(builder);
		}

		// Token: 0x0601F755 RID: 128853 RVA: 0x00461427 File Offset: 0x0045F627
		public static void StartICheckHonamiStoryActivateTalent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601F756 RID: 128854 RVA: 0x00461430 File Offset: 0x0045F630
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F757 RID: 128855 RVA: 0x0046143B File Offset: 0x0045F63B
		public static void AddTalentId(FlatBufferBuilder builder, int talentId)
		{
			builder.AddInt(1, talentId, 0);
		}

		// Token: 0x0601F758 RID: 128856 RVA: 0x00461446 File Offset: 0x0045F646
		public static void AddIsActivated(FlatBufferBuilder builder, bool isActivated)
		{
			builder.AddBool(2, isActivated, false);
		}

		// Token: 0x0601F759 RID: 128857 RVA: 0x00461451 File Offset: 0x0045F651
		public static Offset<ICheckHonamiStoryActivateTalent> EndICheckHonamiStoryActivateTalent(FlatBufferBuilder builder)
		{
			return new Offset<ICheckHonamiStoryActivateTalent>(builder.EndTable());
		}

		// Token: 0x0601F75A RID: 128858 RVA: 0x00461460 File Offset: 0x0045F660
		public ICheckHonamiStoryActivateTalentT UnPack()
		{
			ICheckHonamiStoryActivateTalentT checkHonamiStoryActivateTalentT = new ICheckHonamiStoryActivateTalentT();
			this.UnPackTo(checkHonamiStoryActivateTalentT);
			return checkHonamiStoryActivateTalentT;
		}

		// Token: 0x0601F75B RID: 128859 RVA: 0x0046147B File Offset: 0x0045F67B
		public void UnPackTo(ICheckHonamiStoryActivateTalentT _o)
		{
			_o.Type = this.Type;
			_o.TalentId = this.TalentId;
			_o.IsActivated = this.IsActivated;
		}

		// Token: 0x0601F75C RID: 128860 RVA: 0x004614A4 File Offset: 0x0045F6A4
		public static Offset<ICheckHonamiStoryActivateTalent> Pack(FlatBufferBuilder builder, ICheckHonamiStoryActivateTalentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckHonamiStoryActivateTalent>);
			}
			return ICheckHonamiStoryActivateTalent.CreateICheckHonamiStoryActivateTalent(builder, _o.Type, _o.TalentId, _o.IsActivated);
		}

		// Token: 0x0400DD86 RID: 56710
		private Table __p;
	}
}
