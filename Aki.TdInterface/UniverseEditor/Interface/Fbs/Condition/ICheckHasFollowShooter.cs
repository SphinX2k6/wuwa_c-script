using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F0B RID: 20235
	public struct ICheckHasFollowShooter : IFlatbufferObject
	{
		// Token: 0x17009080 RID: 36992
		// (get) Token: 0x0601F6F9 RID: 128761 RVA: 0x00460B58 File Offset: 0x0045ED58
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F6FA RID: 128762 RVA: 0x00460B65 File Offset: 0x0045ED65
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F6FB RID: 128763 RVA: 0x00460B6C File Offset: 0x0045ED6C
		public static ICheckHasFollowShooter GetRootAsICheckHasFollowShooter(ByteBuffer _bb)
		{
			return ICheckHasFollowShooter.GetRootAsICheckHasFollowShooter(_bb, default(ICheckHasFollowShooter));
		}

		// Token: 0x0601F6FC RID: 128764 RVA: 0x00460B88 File Offset: 0x0045ED88
		public static ICheckHasFollowShooter GetRootAsICheckHasFollowShooter(ByteBuffer _bb, ICheckHasFollowShooter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F6FD RID: 128765 RVA: 0x00460BA5 File Offset: 0x0045EDA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F6FE RID: 128766 RVA: 0x00460BB4 File Offset: 0x0045EDB4
		public ICheckHasFollowShooter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009081 RID: 36993
		// (get) Token: 0x0601F6FF RID: 128767 RVA: 0x00460BC4 File Offset: 0x0045EDC4
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

		// Token: 0x17009082 RID: 36994
		// (get) Token: 0x0601F700 RID: 128768 RVA: 0x00460C00 File Offset: 0x0045EE00
		public bool Has
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009083 RID: 36995
		// (get) Token: 0x0601F701 RID: 128769 RVA: 0x00460C40 File Offset: 0x0045EE40
		public int Id
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

		// Token: 0x0601F702 RID: 128770 RVA: 0x00460C7C File Offset: 0x0045EE7C
		public static Offset<ICheckHasFollowShooter> CreateICheckHasFollowShooter(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, bool Has = false, int Id = 0)
		{
			builder.StartTable(3);
			ICheckHasFollowShooter.AddId(builder, Id);
			ICheckHasFollowShooter.AddHas(builder, Has);
			ICheckHasFollowShooter.AddType(builder, Type);
			return ICheckHasFollowShooter.EndICheckHasFollowShooter(builder);
		}

		// Token: 0x0601F703 RID: 128771 RVA: 0x00460CA0 File Offset: 0x0045EEA0
		public static void StartICheckHasFollowShooter(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601F704 RID: 128772 RVA: 0x00460CA9 File Offset: 0x0045EEA9
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F705 RID: 128773 RVA: 0x00460CB4 File Offset: 0x0045EEB4
		public static void AddHas(FlatBufferBuilder builder, bool has)
		{
			builder.AddBool(1, has, false);
		}

		// Token: 0x0601F706 RID: 128774 RVA: 0x00460CBF File Offset: 0x0045EEBF
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(2, id, 0);
		}

		// Token: 0x0601F707 RID: 128775 RVA: 0x00460CCA File Offset: 0x0045EECA
		public static Offset<ICheckHasFollowShooter> EndICheckHasFollowShooter(FlatBufferBuilder builder)
		{
			return new Offset<ICheckHasFollowShooter>(builder.EndTable());
		}

		// Token: 0x0601F708 RID: 128776 RVA: 0x00460CD8 File Offset: 0x0045EED8
		public ICheckHasFollowShooterT UnPack()
		{
			ICheckHasFollowShooterT checkHasFollowShooterT = new ICheckHasFollowShooterT();
			this.UnPackTo(checkHasFollowShooterT);
			return checkHasFollowShooterT;
		}

		// Token: 0x0601F709 RID: 128777 RVA: 0x00460CF3 File Offset: 0x0045EEF3
		public void UnPackTo(ICheckHasFollowShooterT _o)
		{
			_o.Type = this.Type;
			_o.Has = this.Has;
			_o.Id = this.Id;
		}

		// Token: 0x0601F70A RID: 128778 RVA: 0x00460D1C File Offset: 0x0045EF1C
		public static Offset<ICheckHasFollowShooter> Pack(FlatBufferBuilder builder, ICheckHasFollowShooterT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckHasFollowShooter>);
			}
			return ICheckHasFollowShooter.CreateICheckHasFollowShooter(builder, _o.Type, _o.Has, _o.Id);
		}

		// Token: 0x0400DD76 RID: 56694
		private Table __p;
	}
}
