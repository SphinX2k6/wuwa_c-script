using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200525E RID: 21086
	public struct IFireElementalMatch : IFlatbufferObject
	{
		// Token: 0x17009A72 RID: 39538
		// (get) Token: 0x060224D1 RID: 140497 RVA: 0x004C180F File Offset: 0x004BFA0F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060224D2 RID: 140498 RVA: 0x004C181C File Offset: 0x004BFA1C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060224D3 RID: 140499 RVA: 0x004C1824 File Offset: 0x004BFA24
		public static IFireElementalMatch GetRootAsIFireElementalMatch(ByteBuffer _bb)
		{
			return IFireElementalMatch.GetRootAsIFireElementalMatch(_bb, default(IFireElementalMatch));
		}

		// Token: 0x060224D4 RID: 140500 RVA: 0x004C1840 File Offset: 0x004BFA40
		public static IFireElementalMatch GetRootAsIFireElementalMatch(ByteBuffer _bb, IFireElementalMatch obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060224D5 RID: 140501 RVA: 0x004C185D File Offset: 0x004BFA5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060224D6 RID: 140502 RVA: 0x004C186C File Offset: 0x004BFA6C
		public IFireElementalMatch __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009A73 RID: 39539
		// (get) Token: 0x060224D7 RID: 140503 RVA: 0x004C187C File Offset: 0x004BFA7C
		public EElementalType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EElementalType.Fire;
				}
				return (EElementalType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060224D8 RID: 140504 RVA: 0x004C18B8 File Offset: 0x004BFAB8
		public static Offset<IFireElementalMatch> CreateIFireElementalMatch(FlatBufferBuilder builder, EElementalType Type = EElementalType.Fire)
		{
			builder.StartTable(1);
			IFireElementalMatch.AddType(builder, Type);
			return IFireElementalMatch.EndIFireElementalMatch(builder);
		}

		// Token: 0x060224D9 RID: 140505 RVA: 0x004C18CE File Offset: 0x004BFACE
		public static void StartIFireElementalMatch(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060224DA RID: 140506 RVA: 0x004C18D7 File Offset: 0x004BFAD7
		public static void AddType(FlatBufferBuilder builder, EElementalType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060224DB RID: 140507 RVA: 0x004C18E2 File Offset: 0x004BFAE2
		public static Offset<IFireElementalMatch> EndIFireElementalMatch(FlatBufferBuilder builder)
		{
			return new Offset<IFireElementalMatch>(builder.EndTable());
		}

		// Token: 0x060224DC RID: 140508 RVA: 0x004C18F0 File Offset: 0x004BFAF0
		public IFireElementalMatchT UnPack()
		{
			IFireElementalMatchT fireElementalMatchT = new IFireElementalMatchT();
			this.UnPackTo(fireElementalMatchT);
			return fireElementalMatchT;
		}

		// Token: 0x060224DD RID: 140509 RVA: 0x004C190B File Offset: 0x004BFB0B
		public void UnPackTo(IFireElementalMatchT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060224DE RID: 140510 RVA: 0x004C191C File Offset: 0x004BFB1C
		public static Offset<IFireElementalMatch> Pack(FlatBufferBuilder builder, IFireElementalMatchT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFireElementalMatch>);
			}
			return IFireElementalMatch.CreateIFireElementalMatch(builder, _o.Type);
		}

		// Token: 0x0400E3B0 RID: 58288
		private Table __p;
	}
}
