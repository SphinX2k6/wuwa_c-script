using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200613D RID: 24893
	public struct IAddTrialFollowShooter : IFlatbufferObject
	{
		// Token: 0x1700B7A9 RID: 47017
		// (get) Token: 0x0602A979 RID: 174457 RVA: 0x005DD919 File Offset: 0x005DBB19
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A97A RID: 174458 RVA: 0x005DD926 File Offset: 0x005DBB26
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A97B RID: 174459 RVA: 0x005DD930 File Offset: 0x005DBB30
		public static IAddTrialFollowShooter GetRootAsIAddTrialFollowShooter(ByteBuffer _bb)
		{
			return IAddTrialFollowShooter.GetRootAsIAddTrialFollowShooter(_bb, default(IAddTrialFollowShooter));
		}

		// Token: 0x0602A97C RID: 174460 RVA: 0x005DD94C File Offset: 0x005DBB4C
		public static IAddTrialFollowShooter GetRootAsIAddTrialFollowShooter(ByteBuffer _bb, IAddTrialFollowShooter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A97D RID: 174461 RVA: 0x005DD969 File Offset: 0x005DBB69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A97E RID: 174462 RVA: 0x005DD978 File Offset: 0x005DBB78
		public IAddTrialFollowShooter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B7AA RID: 47018
		// (get) Token: 0x0602A97F RID: 174463 RVA: 0x005DD988 File Offset: 0x005DBB88
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

		// Token: 0x1700B7AB RID: 47019
		// (get) Token: 0x0602A980 RID: 174464 RVA: 0x005DD9C4 File Offset: 0x005DBBC4
		public IActiveRange? ActiveRange
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IActiveRange?(default(IActiveRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602A981 RID: 174465 RVA: 0x005DDA21 File Offset: 0x005DBC21
		public static Offset<IAddTrialFollowShooter> CreateIAddTrialFollowShooter(FlatBufferBuilder builder, int Id = 0, Offset<IActiveRange> ActiveRangeOffset = default(Offset<IActiveRange>))
		{
			builder.StartTable(2);
			IAddTrialFollowShooter.AddActiveRange(builder, ActiveRangeOffset);
			IAddTrialFollowShooter.AddId(builder, Id);
			return IAddTrialFollowShooter.EndIAddTrialFollowShooter(builder);
		}

		// Token: 0x0602A982 RID: 174466 RVA: 0x005DDA3E File Offset: 0x005DBC3E
		public static void StartIAddTrialFollowShooter(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602A983 RID: 174467 RVA: 0x005DDA47 File Offset: 0x005DBC47
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0602A984 RID: 174468 RVA: 0x005DDA52 File Offset: 0x005DBC52
		public static void AddActiveRange(FlatBufferBuilder builder, Offset<IActiveRange> activeRangeOffset)
		{
			builder.AddOffset(1, activeRangeOffset.Value, 0);
		}

		// Token: 0x0602A985 RID: 174469 RVA: 0x005DDA62 File Offset: 0x005DBC62
		public static Offset<IAddTrialFollowShooter> EndIAddTrialFollowShooter(FlatBufferBuilder builder)
		{
			return new Offset<IAddTrialFollowShooter>(builder.EndTable());
		}

		// Token: 0x0602A986 RID: 174470 RVA: 0x005DDA70 File Offset: 0x005DBC70
		public IAddTrialFollowShooterT UnPack()
		{
			IAddTrialFollowShooterT addTrialFollowShooterT = new IAddTrialFollowShooterT();
			this.UnPackTo(addTrialFollowShooterT);
			return addTrialFollowShooterT;
		}

		// Token: 0x0602A987 RID: 174471 RVA: 0x005DDA8C File Offset: 0x005DBC8C
		public void UnPackTo(IAddTrialFollowShooterT _o)
		{
			_o.Id = this.Id;
			_o.ActiveRange = ((this.ActiveRange != null) ? this.ActiveRange.Value.UnPack() : null);
		}

		// Token: 0x0602A988 RID: 174472 RVA: 0x005DDAD4 File Offset: 0x005DBCD4
		public static Offset<IAddTrialFollowShooter> Pack(FlatBufferBuilder builder, IAddTrialFollowShooterT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAddTrialFollowShooter>);
			}
			Offset<IActiveRange> activeRangeOffset = (_o.ActiveRange == null) ? default(Offset<IActiveRange>) : IActiveRange.Pack(builder, _o.ActiveRange);
			return IAddTrialFollowShooter.CreateIAddTrialFollowShooter(builder, _o.Id, activeRangeOffset);
		}

		// Token: 0x0401052C RID: 66860
		private Table __p;
	}
}
