using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D61 RID: 15713
	public struct ICheckPlayerPressButton : IFlatbufferObject
	{
		// Token: 0x17006BD5 RID: 27605
		// (get) Token: 0x06015BD1 RID: 89041 RVA: 0x00322AD6 File Offset: 0x00320CD6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015BD2 RID: 89042 RVA: 0x00322AE3 File Offset: 0x00320CE3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015BD3 RID: 89043 RVA: 0x00322AEC File Offset: 0x00320CEC
		public static ICheckPlayerPressButton GetRootAsICheckPlayerPressButton(ByteBuffer _bb)
		{
			return ICheckPlayerPressButton.GetRootAsICheckPlayerPressButton(_bb, default(ICheckPlayerPressButton));
		}

		// Token: 0x06015BD4 RID: 89044 RVA: 0x00322B08 File Offset: 0x00320D08
		public static ICheckPlayerPressButton GetRootAsICheckPlayerPressButton(ByteBuffer _bb, ICheckPlayerPressButton obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015BD5 RID: 89045 RVA: 0x00322B25 File Offset: 0x00320D25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015BD6 RID: 89046 RVA: 0x00322B34 File Offset: 0x00320D34
		public ICheckPlayerPressButton __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006BD6 RID: 27606
		// (get) Token: 0x06015BD7 RID: 89047 RVA: 0x00322B44 File Offset: 0x00320D44
		public ECheckPlayerInputType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECheckPlayerInputType.PressButton;
				}
				return (ECheckPlayerInputType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006BD7 RID: 27607
		// (get) Token: 0x06015BD8 RID: 89048 RVA: 0x00322B80 File Offset: 0x00320D80
		public EPlayerButtonType ButtonType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EPlayerButtonType.ChallengeAgain;
				}
				return (EPlayerButtonType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06015BD9 RID: 89049 RVA: 0x00322BBC File Offset: 0x00320DBC
		public static Offset<ICheckPlayerPressButton> CreateICheckPlayerPressButton(FlatBufferBuilder builder, ECheckPlayerInputType Type = ECheckPlayerInputType.PressButton, EPlayerButtonType ButtonType = EPlayerButtonType.ChallengeAgain)
		{
			builder.StartTable(2);
			ICheckPlayerPressButton.AddButtonType(builder, ButtonType);
			ICheckPlayerPressButton.AddType(builder, Type);
			return ICheckPlayerPressButton.EndICheckPlayerPressButton(builder);
		}

		// Token: 0x06015BDA RID: 89050 RVA: 0x00322BD9 File Offset: 0x00320DD9
		public static void StartICheckPlayerPressButton(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06015BDB RID: 89051 RVA: 0x00322BE2 File Offset: 0x00320DE2
		public static void AddType(FlatBufferBuilder builder, ECheckPlayerInputType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015BDC RID: 89052 RVA: 0x00322BED File Offset: 0x00320DED
		public static void AddButtonType(FlatBufferBuilder builder, EPlayerButtonType buttonType)
		{
			builder.AddByte(1, (byte)buttonType, 0);
		}

		// Token: 0x06015BDD RID: 89053 RVA: 0x00322BF8 File Offset: 0x00320DF8
		public static Offset<ICheckPlayerPressButton> EndICheckPlayerPressButton(FlatBufferBuilder builder)
		{
			return new Offset<ICheckPlayerPressButton>(builder.EndTable());
		}

		// Token: 0x06015BDE RID: 89054 RVA: 0x00322C08 File Offset: 0x00320E08
		public ICheckPlayerPressButtonT UnPack()
		{
			ICheckPlayerPressButtonT checkPlayerPressButtonT = new ICheckPlayerPressButtonT();
			this.UnPackTo(checkPlayerPressButtonT);
			return checkPlayerPressButtonT;
		}

		// Token: 0x06015BDF RID: 89055 RVA: 0x00322C23 File Offset: 0x00320E23
		public void UnPackTo(ICheckPlayerPressButtonT _o)
		{
			_o.Type = this.Type;
			_o.ButtonType = this.ButtonType;
		}

		// Token: 0x06015BE0 RID: 89056 RVA: 0x00322C40 File Offset: 0x00320E40
		public static Offset<ICheckPlayerPressButton> Pack(FlatBufferBuilder builder, ICheckPlayerPressButtonT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckPlayerPressButton>);
			}
			return ICheckPlayerPressButton.CreateICheckPlayerPressButton(builder, _o.Type, _o.ButtonType);
		}

		// Token: 0x0400B642 RID: 46658
		private Table __p;
	}
}
