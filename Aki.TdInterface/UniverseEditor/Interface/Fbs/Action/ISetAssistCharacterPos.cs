using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007777 RID: 30583
	public struct ISetAssistCharacterPos : IFlatbufferObject
	{
		// Token: 0x1700E021 RID: 57377
		// (get) Token: 0x06035ADF RID: 219871 RVA: 0x007317EF File Offset: 0x0072F9EF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035AE0 RID: 219872 RVA: 0x007317FC File Offset: 0x0072F9FC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035AE1 RID: 219873 RVA: 0x00731804 File Offset: 0x0072FA04
		public static ISetAssistCharacterPos GetRootAsISetAssistCharacterPos(ByteBuffer _bb)
		{
			return ISetAssistCharacterPos.GetRootAsISetAssistCharacterPos(_bb, default(ISetAssistCharacterPos));
		}

		// Token: 0x06035AE2 RID: 219874 RVA: 0x00731820 File Offset: 0x0072FA20
		public static ISetAssistCharacterPos GetRootAsISetAssistCharacterPos(ByteBuffer _bb, ISetAssistCharacterPos obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035AE3 RID: 219875 RVA: 0x0073183D File Offset: 0x0072FA3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035AE4 RID: 219876 RVA: 0x0073184C File Offset: 0x0072FA4C
		public ISetAssistCharacterPos __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E022 RID: 57378
		// (get) Token: 0x06035AE5 RID: 219877 RVA: 0x0073185C File Offset: 0x0072FA5C
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

		// Token: 0x1700E023 RID: 57379
		// (get) Token: 0x06035AE6 RID: 219878 RVA: 0x00731898 File Offset: 0x0072FA98
		public IPosA? Pos
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IPosA?(default(IPosA).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06035AE7 RID: 219879 RVA: 0x007318F5 File Offset: 0x0072FAF5
		public static Offset<ISetAssistCharacterPos> CreateISetAssistCharacterPos(FlatBufferBuilder builder, int Id = 0, Offset<IPosA> PosOffset = default(Offset<IPosA>))
		{
			builder.StartTable(2);
			ISetAssistCharacterPos.AddPos(builder, PosOffset);
			ISetAssistCharacterPos.AddId(builder, Id);
			return ISetAssistCharacterPos.EndISetAssistCharacterPos(builder);
		}

		// Token: 0x06035AE8 RID: 219880 RVA: 0x00731912 File Offset: 0x0072FB12
		public static void StartISetAssistCharacterPos(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06035AE9 RID: 219881 RVA: 0x0073191B File Offset: 0x0072FB1B
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x06035AEA RID: 219882 RVA: 0x00731926 File Offset: 0x0072FB26
		public static void AddPos(FlatBufferBuilder builder, Offset<IPosA> posOffset)
		{
			builder.AddOffset(1, posOffset.Value, 0);
		}

		// Token: 0x06035AEB RID: 219883 RVA: 0x00731936 File Offset: 0x0072FB36
		public static Offset<ISetAssistCharacterPos> EndISetAssistCharacterPos(FlatBufferBuilder builder)
		{
			return new Offset<ISetAssistCharacterPos>(builder.EndTable());
		}

		// Token: 0x06035AEC RID: 219884 RVA: 0x00731944 File Offset: 0x0072FB44
		public ISetAssistCharacterPosT UnPack()
		{
			ISetAssistCharacterPosT setAssistCharacterPosT = new ISetAssistCharacterPosT();
			this.UnPackTo(setAssistCharacterPosT);
			return setAssistCharacterPosT;
		}

		// Token: 0x06035AED RID: 219885 RVA: 0x00731960 File Offset: 0x0072FB60
		public void UnPackTo(ISetAssistCharacterPosT _o)
		{
			_o.Id = this.Id;
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
		}

		// Token: 0x06035AEE RID: 219886 RVA: 0x007319A8 File Offset: 0x0072FBA8
		public static Offset<ISetAssistCharacterPos> Pack(FlatBufferBuilder builder, ISetAssistCharacterPosT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetAssistCharacterPos>);
			}
			Offset<IPosA> posOffset = (_o.Pos == null) ? default(Offset<IPosA>) : IPosA.Pack(builder, _o.Pos);
			return ISetAssistCharacterPos.CreateISetAssistCharacterPos(builder, _o.Id, posOffset);
		}

		// Token: 0x0401299A RID: 76186
		private Table __p;
	}
}
