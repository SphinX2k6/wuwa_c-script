using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200411B RID: 16667
	public struct IShowUi : IFlatbufferObject
	{
		// Token: 0x17007607 RID: 30215
		// (get) Token: 0x06018679 RID: 99961 RVA: 0x00385219 File Offset: 0x00383419
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601867A RID: 99962 RVA: 0x00385226 File Offset: 0x00383426
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601867B RID: 99963 RVA: 0x00385230 File Offset: 0x00383430
		public static IShowUi GetRootAsIShowUi(ByteBuffer _bb)
		{
			return IShowUi.GetRootAsIShowUi(_bb, default(IShowUi));
		}

		// Token: 0x0601867C RID: 99964 RVA: 0x0038524C File Offset: 0x0038344C
		public static IShowUi GetRootAsIShowUi(ByteBuffer _bb, IShowUi obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601867D RID: 99965 RVA: 0x00385269 File Offset: 0x00383469
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601867E RID: 99966 RVA: 0x00385278 File Offset: 0x00383478
		public IShowUi __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007608 RID: 30216
		// (get) Token: 0x0601867F RID: 99967 RVA: 0x00385288 File Offset: 0x00383488
		public EShowUiType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EShowUiType.All;
				}
				return (EShowUiType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018680 RID: 99968 RVA: 0x003852C4 File Offset: 0x003834C4
		public static Offset<IShowUi> CreateIShowUi(FlatBufferBuilder builder, EShowUiType Type = EShowUiType.All)
		{
			builder.StartTable(1);
			IShowUi.AddType(builder, Type);
			return IShowUi.EndIShowUi(builder);
		}

		// Token: 0x06018681 RID: 99969 RVA: 0x003852DA File Offset: 0x003834DA
		public static void StartIShowUi(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06018682 RID: 99970 RVA: 0x003852E3 File Offset: 0x003834E3
		public static void AddType(FlatBufferBuilder builder, EShowUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018683 RID: 99971 RVA: 0x003852EE File Offset: 0x003834EE
		public static Offset<IShowUi> EndIShowUi(FlatBufferBuilder builder)
		{
			return new Offset<IShowUi>(builder.EndTable());
		}

		// Token: 0x06018684 RID: 99972 RVA: 0x003852FC File Offset: 0x003834FC
		public IShowUiT UnPack()
		{
			IShowUiT showUiT = new IShowUiT();
			this.UnPackTo(showUiT);
			return showUiT;
		}

		// Token: 0x06018685 RID: 99973 RVA: 0x00385317 File Offset: 0x00383517
		public void UnPackTo(IShowUiT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06018686 RID: 99974 RVA: 0x00385328 File Offset: 0x00383528
		public static Offset<IShowUi> Pack(FlatBufferBuilder builder, IShowUiT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowUi>);
			}
			return IShowUi.CreateIShowUi(builder, _o.Type);
		}

		// Token: 0x0400BD06 RID: 48390
		private Table __p;
	}
}
