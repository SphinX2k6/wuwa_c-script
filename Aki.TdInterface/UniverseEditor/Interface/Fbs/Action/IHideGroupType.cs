using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F98 RID: 28568
	public struct IHideGroupType : IFlatbufferObject
	{
		// Token: 0x1700D142 RID: 53570
		// (get) Token: 0x0603174F RID: 202575 RVA: 0x006B4774 File Offset: 0x006B2974
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031750 RID: 202576 RVA: 0x006B4781 File Offset: 0x006B2981
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031751 RID: 202577 RVA: 0x006B4788 File Offset: 0x006B2988
		public static IHideGroupType GetRootAsIHideGroupType(ByteBuffer _bb)
		{
			return IHideGroupType.GetRootAsIHideGroupType(_bb, default(IHideGroupType));
		}

		// Token: 0x06031752 RID: 202578 RVA: 0x006B47A4 File Offset: 0x006B29A4
		public static IHideGroupType GetRootAsIHideGroupType(ByteBuffer _bb, IHideGroupType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031753 RID: 202579 RVA: 0x006B47C1 File Offset: 0x006B29C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031754 RID: 202580 RVA: 0x006B47D0 File Offset: 0x006B29D0
		public IHideGroupType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D143 RID: 53571
		// (get) Token: 0x06031755 RID: 202581 RVA: 0x006B47E0 File Offset: 0x006B29E0
		public EHideType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHideType.WorldMonsterAndMonsterTreasure;
				}
				return (EHideType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031756 RID: 202582 RVA: 0x006B481C File Offset: 0x006B2A1C
		public static Offset<IHideGroupType> CreateIHideGroupType(FlatBufferBuilder builder, EHideType Type = EHideType.WorldMonsterAndMonsterTreasure)
		{
			builder.StartTable(1);
			IHideGroupType.AddType(builder, Type);
			return IHideGroupType.EndIHideGroupType(builder);
		}

		// Token: 0x06031757 RID: 202583 RVA: 0x006B4832 File Offset: 0x006B2A32
		public static void StartIHideGroupType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031758 RID: 202584 RVA: 0x006B483B File Offset: 0x006B2A3B
		public static void AddType(FlatBufferBuilder builder, EHideType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031759 RID: 202585 RVA: 0x006B4846 File Offset: 0x006B2A46
		public static Offset<IHideGroupType> EndIHideGroupType(FlatBufferBuilder builder)
		{
			return new Offset<IHideGroupType>(builder.EndTable());
		}

		// Token: 0x0603175A RID: 202586 RVA: 0x006B4854 File Offset: 0x006B2A54
		public IHideGroupTypeT UnPack()
		{
			IHideGroupTypeT hideGroupTypeT = new IHideGroupTypeT();
			this.UnPackTo(hideGroupTypeT);
			return hideGroupTypeT;
		}

		// Token: 0x0603175B RID: 202587 RVA: 0x006B486F File Offset: 0x006B2A6F
		public void UnPackTo(IHideGroupTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603175C RID: 202588 RVA: 0x006B4880 File Offset: 0x006B2A80
		public static Offset<IHideGroupType> Pack(FlatBufferBuilder builder, IHideGroupTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHideGroupType>);
			}
			return IHideGroupType.CreateIHideGroupType(builder, _o.Type);
		}

		// Token: 0x04011EB8 RID: 73400
		private Table __p;
	}
}
