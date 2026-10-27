using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B89 RID: 23433
	public struct IWoodElementalMatch : IFlatbufferObject
	{
		// Token: 0x1700B115 RID: 45333
		// (get) Token: 0x060281CF RID: 164303 RVA: 0x0058377F File Offset: 0x0058197F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060281D0 RID: 164304 RVA: 0x0058378C File Offset: 0x0058198C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060281D1 RID: 164305 RVA: 0x00583794 File Offset: 0x00581994
		public static IWoodElementalMatch GetRootAsIWoodElementalMatch(ByteBuffer _bb)
		{
			return IWoodElementalMatch.GetRootAsIWoodElementalMatch(_bb, default(IWoodElementalMatch));
		}

		// Token: 0x060281D2 RID: 164306 RVA: 0x005837B0 File Offset: 0x005819B0
		public static IWoodElementalMatch GetRootAsIWoodElementalMatch(ByteBuffer _bb, IWoodElementalMatch obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060281D3 RID: 164307 RVA: 0x005837CD File Offset: 0x005819CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060281D4 RID: 164308 RVA: 0x005837DC File Offset: 0x005819DC
		public IWoodElementalMatch __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B116 RID: 45334
		// (get) Token: 0x060281D5 RID: 164309 RVA: 0x005837EC File Offset: 0x005819EC
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

		// Token: 0x060281D6 RID: 164310 RVA: 0x00583828 File Offset: 0x00581A28
		public static Offset<IWoodElementalMatch> CreateIWoodElementalMatch(FlatBufferBuilder builder, EElementalType Type = EElementalType.Fire)
		{
			builder.StartTable(1);
			IWoodElementalMatch.AddType(builder, Type);
			return IWoodElementalMatch.EndIWoodElementalMatch(builder);
		}

		// Token: 0x060281D7 RID: 164311 RVA: 0x0058383E File Offset: 0x00581A3E
		public static void StartIWoodElementalMatch(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060281D8 RID: 164312 RVA: 0x00583847 File Offset: 0x00581A47
		public static void AddType(FlatBufferBuilder builder, EElementalType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060281D9 RID: 164313 RVA: 0x00583852 File Offset: 0x00581A52
		public static Offset<IWoodElementalMatch> EndIWoodElementalMatch(FlatBufferBuilder builder)
		{
			return new Offset<IWoodElementalMatch>(builder.EndTable());
		}

		// Token: 0x060281DA RID: 164314 RVA: 0x00583860 File Offset: 0x00581A60
		public IWoodElementalMatchT UnPack()
		{
			IWoodElementalMatchT woodElementalMatchT = new IWoodElementalMatchT();
			this.UnPackTo(woodElementalMatchT);
			return woodElementalMatchT;
		}

		// Token: 0x060281DB RID: 164315 RVA: 0x0058387B File Offset: 0x00581A7B
		public void UnPackTo(IWoodElementalMatchT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060281DC RID: 164316 RVA: 0x0058388C File Offset: 0x00581A8C
		public static Offset<IWoodElementalMatch> Pack(FlatBufferBuilder builder, IWoodElementalMatchT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWoodElementalMatch>);
			}
			return IWoodElementalMatch.CreateIWoodElementalMatch(builder, _o.Type);
		}

		// Token: 0x0400F2E7 RID: 62183
		private Table __p;
	}
}
