using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004178 RID: 16760
	public struct ICheckPlayerPressButton : IFlatbufferObject
	{
		// Token: 0x1700718F RID: 29071
		// (get) Token: 0x06017109 RID: 94473 RVA: 0x00349D4E File Offset: 0x00347F4E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601710A RID: 94474 RVA: 0x00349D5B File Offset: 0x00347F5B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601710B RID: 94475 RVA: 0x00349D64 File Offset: 0x00347F64
		public static ICheckPlayerPressButton GetRootAsICheckPlayerPressButton(ByteBuffer _bb)
		{
			return ICheckPlayerPressButton.GetRootAsICheckPlayerPressButton(_bb, default(ICheckPlayerPressButton));
		}

		// Token: 0x0601710C RID: 94476 RVA: 0x00349D80 File Offset: 0x00347F80
		public static ICheckPlayerPressButton GetRootAsICheckPlayerPressButton(ByteBuffer _bb, ICheckPlayerPressButton obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601710D RID: 94477 RVA: 0x00349D9D File Offset: 0x00347F9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601710E RID: 94478 RVA: 0x00349DAC File Offset: 0x00347FAC
		public ICheckPlayerPressButton __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007190 RID: 29072
		// (get) Token: 0x0601710F RID: 94479 RVA: 0x00349DBC File Offset: 0x00347FBC
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

		// Token: 0x17007191 RID: 29073
		// (get) Token: 0x06017110 RID: 94480 RVA: 0x00349DF8 File Offset: 0x00347FF8
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

		// Token: 0x06017111 RID: 94481 RVA: 0x00349E34 File Offset: 0x00348034
		public static Offset<ICheckPlayerPressButton> CreateICheckPlayerPressButton(FlatBufferBuilder builder, ECheckPlayerInputType Type = ECheckPlayerInputType.PressButton, EPlayerButtonType ButtonType = EPlayerButtonType.ChallengeAgain)
		{
			builder.StartTable(2);
			ICheckPlayerPressButton.AddButtonType(builder, ButtonType);
			ICheckPlayerPressButton.AddType(builder, Type);
			return ICheckPlayerPressButton.EndICheckPlayerPressButton(builder);
		}

		// Token: 0x06017112 RID: 94482 RVA: 0x00349E51 File Offset: 0x00348051
		public static void StartICheckPlayerPressButton(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06017113 RID: 94483 RVA: 0x00349E5A File Offset: 0x0034805A
		public static void AddType(FlatBufferBuilder builder, ECheckPlayerInputType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017114 RID: 94484 RVA: 0x00349E65 File Offset: 0x00348065
		public static void AddButtonType(FlatBufferBuilder builder, EPlayerButtonType buttonType)
		{
			builder.AddByte(1, (byte)buttonType, 0);
		}

		// Token: 0x06017115 RID: 94485 RVA: 0x00349E70 File Offset: 0x00348070
		public static Offset<ICheckPlayerPressButton> EndICheckPlayerPressButton(FlatBufferBuilder builder)
		{
			return new Offset<ICheckPlayerPressButton>(builder.EndTable());
		}

		// Token: 0x06017116 RID: 94486 RVA: 0x00349E80 File Offset: 0x00348080
		public ICheckPlayerPressButtonT UnPack()
		{
			ICheckPlayerPressButtonT checkPlayerPressButtonT = new ICheckPlayerPressButtonT();
			this.UnPackTo(checkPlayerPressButtonT);
			return checkPlayerPressButtonT;
		}

		// Token: 0x06017117 RID: 94487 RVA: 0x00349E9B File Offset: 0x0034809B
		public void UnPackTo(ICheckPlayerPressButtonT _o)
		{
			_o.Type = this.Type;
			_o.ButtonType = this.ButtonType;
		}

		// Token: 0x06017118 RID: 94488 RVA: 0x00349EB8 File Offset: 0x003480B8
		public static Offset<ICheckPlayerPressButton> Pack(FlatBufferBuilder builder, ICheckPlayerPressButtonT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckPlayerPressButton>);
			}
			return ICheckPlayerPressButton.CreateICheckPlayerPressButton(builder, _o.Type, _o.ButtonType);
		}

		// Token: 0x0400BFEF RID: 49135
		private Table __p;
	}
}
