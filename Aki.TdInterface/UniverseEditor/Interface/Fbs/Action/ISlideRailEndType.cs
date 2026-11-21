using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007914 RID: 30996
	public struct ISlideRailEndType : IFlatbufferObject
	{
		// Token: 0x1700E35D RID: 58205
		// (get) Token: 0x0603693C RID: 223548 RVA: 0x0074E101 File Offset: 0x0074C301
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603693D RID: 223549 RVA: 0x0074E10E File Offset: 0x0074C30E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603693E RID: 223550 RVA: 0x0074E118 File Offset: 0x0074C318
		public static ISlideRailEndType GetRootAsISlideRailEndType(ByteBuffer _bb)
		{
			return ISlideRailEndType.GetRootAsISlideRailEndType(_bb, default(ISlideRailEndType));
		}

		// Token: 0x0603693F RID: 223551 RVA: 0x0074E134 File Offset: 0x0074C334
		public static ISlideRailEndType GetRootAsISlideRailEndType(ByteBuffer _bb, ISlideRailEndType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036940 RID: 223552 RVA: 0x0074E151 File Offset: 0x0074C351
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036941 RID: 223553 RVA: 0x0074E160 File Offset: 0x0074C360
		public ISlideRailEndType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E35E RID: 58206
		// (get) Token: 0x06036942 RID: 223554 RVA: 0x0074E170 File Offset: 0x0074C370
		public ESlideRailEndType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESlideRailEndType.Player;
				}
				return (ESlideRailEndType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036943 RID: 223555 RVA: 0x0074E1AC File Offset: 0x0074C3AC
		public static Offset<ISlideRailEndType> CreateISlideRailEndType(FlatBufferBuilder builder, ESlideRailEndType Type = ESlideRailEndType.Player)
		{
			builder.StartTable(1);
			ISlideRailEndType.AddType(builder, Type);
			return ISlideRailEndType.EndISlideRailEndType(builder);
		}

		// Token: 0x06036944 RID: 223556 RVA: 0x0074E1C2 File Offset: 0x0074C3C2
		public static void StartISlideRailEndType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06036945 RID: 223557 RVA: 0x0074E1CB File Offset: 0x0074C3CB
		public static void AddType(FlatBufferBuilder builder, ESlideRailEndType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036946 RID: 223558 RVA: 0x0074E1D6 File Offset: 0x0074C3D6
		public static Offset<ISlideRailEndType> EndISlideRailEndType(FlatBufferBuilder builder)
		{
			return new Offset<ISlideRailEndType>(builder.EndTable());
		}

		// Token: 0x06036947 RID: 223559 RVA: 0x0074E1E4 File Offset: 0x0074C3E4
		public ISlideRailEndTypeT UnPack()
		{
			ISlideRailEndTypeT slideRailEndTypeT = new ISlideRailEndTypeT();
			this.UnPackTo(slideRailEndTypeT);
			return slideRailEndTypeT;
		}

		// Token: 0x06036948 RID: 223560 RVA: 0x0074E1FF File Offset: 0x0074C3FF
		public void UnPackTo(ISlideRailEndTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06036949 RID: 223561 RVA: 0x0074E210 File Offset: 0x0074C410
		public static Offset<ISlideRailEndType> Pack(FlatBufferBuilder builder, ISlideRailEndTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISlideRailEndType>);
			}
			return ISlideRailEndType.CreateISlideRailEndType(builder, _o.Type);
		}

		// Token: 0x04012BD1 RID: 76753
		private Table __p;
	}
}
