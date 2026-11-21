using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005984 RID: 22916
	public struct IInhalationMatching : IFlatbufferObject
	{
		// Token: 0x1700A674 RID: 42612
		// (get) Token: 0x060255B9 RID: 153017 RVA: 0x005208D3 File Offset: 0x0051EAD3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060255BA RID: 153018 RVA: 0x005208E0 File Offset: 0x0051EAE0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060255BB RID: 153019 RVA: 0x005208E8 File Offset: 0x0051EAE8
		public static IInhalationMatching GetRootAsIInhalationMatching(ByteBuffer _bb)
		{
			return IInhalationMatching.GetRootAsIInhalationMatching(_bb, default(IInhalationMatching));
		}

		// Token: 0x060255BC RID: 153020 RVA: 0x00520904 File Offset: 0x0051EB04
		public static IInhalationMatching GetRootAsIInhalationMatching(ByteBuffer _bb, IInhalationMatching obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060255BD RID: 153021 RVA: 0x00520921 File Offset: 0x0051EB21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060255BE RID: 153022 RVA: 0x00520930 File Offset: 0x0051EB30
		public IInhalationMatching __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A675 RID: 42613
		// (get) Token: 0x060255BF RID: 153023 RVA: 0x00520940 File Offset: 0x0051EB40
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

		// Token: 0x1700A676 RID: 42614
		// (get) Token: 0x060255C0 RID: 153024 RVA: 0x0052097C File Offset: 0x0051EB7C
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

		// Token: 0x060255C1 RID: 153025 RVA: 0x005209D9 File Offset: 0x0051EBD9
		public static Offset<IInhalationMatching> CreateIInhalationMatching(FlatBufferBuilder builder, int InhalationStrength = 0, Offset<ICategoryMatchingCondition> EntityMatchOffset = default(Offset<ICategoryMatchingCondition>))
		{
			builder.StartTable(2);
			IInhalationMatching.AddEntityMatch(builder, EntityMatchOffset);
			IInhalationMatching.AddInhalationStrength(builder, InhalationStrength);
			return IInhalationMatching.EndIInhalationMatching(builder);
		}

		// Token: 0x060255C2 RID: 153026 RVA: 0x005209F6 File Offset: 0x0051EBF6
		public static void StartIInhalationMatching(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060255C3 RID: 153027 RVA: 0x005209FF File Offset: 0x0051EBFF
		public static void AddInhalationStrength(FlatBufferBuilder builder, int inhalationStrength)
		{
			builder.AddInt(0, inhalationStrength, 0);
		}

		// Token: 0x060255C4 RID: 153028 RVA: 0x00520A0A File Offset: 0x0051EC0A
		public static void AddEntityMatch(FlatBufferBuilder builder, Offset<ICategoryMatchingCondition> entityMatchOffset)
		{
			builder.AddOffset(1, entityMatchOffset.Value, 0);
		}

		// Token: 0x060255C5 RID: 153029 RVA: 0x00520A1A File Offset: 0x0051EC1A
		public static Offset<IInhalationMatching> EndIInhalationMatching(FlatBufferBuilder builder)
		{
			return new Offset<IInhalationMatching>(builder.EndTable());
		}

		// Token: 0x060255C6 RID: 153030 RVA: 0x00520A28 File Offset: 0x0051EC28
		public IInhalationMatchingT UnPack()
		{
			IInhalationMatchingT inhalationMatchingT = new IInhalationMatchingT();
			this.UnPackTo(inhalationMatchingT);
			return inhalationMatchingT;
		}

		// Token: 0x060255C7 RID: 153031 RVA: 0x00520A44 File Offset: 0x0051EC44
		public void UnPackTo(IInhalationMatchingT _o)
		{
			_o.InhalationStrength = this.InhalationStrength;
			_o.EntityMatch = ((this.EntityMatch != null) ? this.EntityMatch.Value.UnPack() : null);
		}

		// Token: 0x060255C8 RID: 153032 RVA: 0x00520A8C File Offset: 0x0051EC8C
		public static Offset<IInhalationMatching> Pack(FlatBufferBuilder builder, IInhalationMatchingT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInhalationMatching>);
			}
			Offset<ICategoryMatchingCondition> entityMatchOffset = (_o.EntityMatch == null) ? default(Offset<ICategoryMatchingCondition>) : ICategoryMatchingCondition.Pack(builder, _o.EntityMatch);
			return IInhalationMatching.CreateIInhalationMatching(builder, _o.InhalationStrength, entityMatchOffset);
		}

		// Token: 0x0400F273 RID: 62067
		private Table __p;
	}
}
