using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053FE RID: 21502
	public struct IInhalationMatching : IFlatbufferObject
	{
		// Token: 0x17009E3A RID: 40506
		// (get) Token: 0x06023501 RID: 144641 RVA: 0x004E38A7 File Offset: 0x004E1AA7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023502 RID: 144642 RVA: 0x004E38B4 File Offset: 0x004E1AB4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023503 RID: 144643 RVA: 0x004E38BC File Offset: 0x004E1ABC
		public static IInhalationMatching GetRootAsIInhalationMatching(ByteBuffer _bb)
		{
			return IInhalationMatching.GetRootAsIInhalationMatching(_bb, default(IInhalationMatching));
		}

		// Token: 0x06023504 RID: 144644 RVA: 0x004E38D8 File Offset: 0x004E1AD8
		public static IInhalationMatching GetRootAsIInhalationMatching(ByteBuffer _bb, IInhalationMatching obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023505 RID: 144645 RVA: 0x004E38F5 File Offset: 0x004E1AF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023506 RID: 144646 RVA: 0x004E3904 File Offset: 0x004E1B04
		public IInhalationMatching __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009E3B RID: 40507
		// (get) Token: 0x06023507 RID: 144647 RVA: 0x004E3914 File Offset: 0x004E1B14
		public int InhalationStrength
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

		// Token: 0x17009E3C RID: 40508
		// (get) Token: 0x06023508 RID: 144648 RVA: 0x004E3950 File Offset: 0x004E1B50
		public ICategoryMatchingCondition? EntityMatch
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ICategoryMatchingCondition?(default(ICategoryMatchingCondition).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06023509 RID: 144649 RVA: 0x004E39AD File Offset: 0x004E1BAD
		public static Offset<IInhalationMatching> CreateIInhalationMatching(FlatBufferBuilder builder, int InhalationStrength = 0, Offset<ICategoryMatchingCondition> EntityMatchOffset = default(Offset<ICategoryMatchingCondition>))
		{
			builder.StartTable(2);
			IInhalationMatching.AddEntityMatch(builder, EntityMatchOffset);
			IInhalationMatching.AddInhalationStrength(builder, InhalationStrength);
			return IInhalationMatching.EndIInhalationMatching(builder);
		}

		// Token: 0x0602350A RID: 144650 RVA: 0x004E39CA File Offset: 0x004E1BCA
		public static void StartIInhalationMatching(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602350B RID: 144651 RVA: 0x004E39D3 File Offset: 0x004E1BD3
		public static void AddInhalationStrength(FlatBufferBuilder builder, int inhalationStrength)
		{
			builder.AddInt(0, inhalationStrength, 0);
		}

		// Token: 0x0602350C RID: 144652 RVA: 0x004E39DE File Offset: 0x004E1BDE
		public static void AddEntityMatch(FlatBufferBuilder builder, Offset<ICategoryMatchingCondition> entityMatchOffset)
		{
			builder.AddOffset(1, entityMatchOffset.Value, 0);
		}

		// Token: 0x0602350D RID: 144653 RVA: 0x004E39EE File Offset: 0x004E1BEE
		public static Offset<IInhalationMatching> EndIInhalationMatching(FlatBufferBuilder builder)
		{
			return new Offset<IInhalationMatching>(builder.EndTable());
		}

		// Token: 0x0602350E RID: 144654 RVA: 0x004E39FC File Offset: 0x004E1BFC
		public IInhalationMatchingT UnPack()
		{
			IInhalationMatchingT inhalationMatchingT = new IInhalationMatchingT();
			this.UnPackTo(inhalationMatchingT);
			return inhalationMatchingT;
		}

		// Token: 0x0602350F RID: 144655 RVA: 0x004E3A18 File Offset: 0x004E1C18
		public void UnPackTo(IInhalationMatchingT _o)
		{
			_o.InhalationStrength = this.InhalationStrength;
			_o.EntityMatch = ((this.EntityMatch != null) ? this.EntityMatch.Value.UnPack() : null);
		}

		// Token: 0x06023510 RID: 144656 RVA: 0x004E3A60 File Offset: 0x004E1C60
		public static Offset<IInhalationMatching> Pack(FlatBufferBuilder builder, IInhalationMatchingT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInhalationMatching>);
			}
			Offset<ICategoryMatchingCondition> entityMatchOffset = (_o.EntityMatch == null) ? default(Offset<ICategoryMatchingCondition>) : ICategoryMatchingCondition.Pack(builder, _o.EntityMatch);
			return IInhalationMatching.CreateIInhalationMatching(builder, _o.InhalationStrength, entityMatchOffset);
		}

		// Token: 0x0400E642 RID: 58946
		private Table __p;
	}
}
