using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007546 RID: 30022
	public struct IPromptStyleBattle : IFlatbufferObject
	{
		// Token: 0x1700DCD9 RID: 56537
		// (get) Token: 0x06034A59 RID: 215641 RVA: 0x00715404 File Offset: 0x00713604
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034A5A RID: 215642 RVA: 0x00715411 File Offset: 0x00713611
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034A5B RID: 215643 RVA: 0x00715418 File Offset: 0x00713618
		public static IPromptStyleBattle GetRootAsIPromptStyleBattle(ByteBuffer _bb)
		{
			return IPromptStyleBattle.GetRootAsIPromptStyleBattle(_bb, default(IPromptStyleBattle));
		}

		// Token: 0x06034A5C RID: 215644 RVA: 0x00715434 File Offset: 0x00713634
		public static IPromptStyleBattle GetRootAsIPromptStyleBattle(ByteBuffer _bb, IPromptStyleBattle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034A5D RID: 215645 RVA: 0x00715451 File Offset: 0x00713651
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034A5E RID: 215646 RVA: 0x00715460 File Offset: 0x00713660
		public IPromptStyleBattle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DCDA RID: 56538
		// (get) Token: 0x06034A5F RID: 215647 RVA: 0x00715470 File Offset: 0x00713670
		public EPromptStyle Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPromptStyle.Default;
				}
				return (EPromptStyle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06034A60 RID: 215648 RVA: 0x007154AC File Offset: 0x007136AC
		public static Offset<IPromptStyleBattle> CreateIPromptStyleBattle(FlatBufferBuilder builder, EPromptStyle Type = EPromptStyle.Default)
		{
			builder.StartTable(1);
			IPromptStyleBattle.AddType(builder, Type);
			return IPromptStyleBattle.EndIPromptStyleBattle(builder);
		}

		// Token: 0x06034A61 RID: 215649 RVA: 0x007154C2 File Offset: 0x007136C2
		public static void StartIPromptStyleBattle(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06034A62 RID: 215650 RVA: 0x007154CB File Offset: 0x007136CB
		public static void AddType(FlatBufferBuilder builder, EPromptStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034A63 RID: 215651 RVA: 0x007154D6 File Offset: 0x007136D6
		public static Offset<IPromptStyleBattle> EndIPromptStyleBattle(FlatBufferBuilder builder)
		{
			return new Offset<IPromptStyleBattle>(builder.EndTable());
		}

		// Token: 0x06034A64 RID: 215652 RVA: 0x007154E4 File Offset: 0x007136E4
		public IPromptStyleBattleT UnPack()
		{
			IPromptStyleBattleT promptStyleBattleT = new IPromptStyleBattleT();
			this.UnPackTo(promptStyleBattleT);
			return promptStyleBattleT;
		}

		// Token: 0x06034A65 RID: 215653 RVA: 0x007154FF File Offset: 0x007136FF
		public void UnPackTo(IPromptStyleBattleT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06034A66 RID: 215654 RVA: 0x00715510 File Offset: 0x00713710
		public static Offset<IPromptStyleBattle> Pack(FlatBufferBuilder builder, IPromptStyleBattleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPromptStyleBattle>);
			}
			return IPromptStyleBattle.CreateIPromptStyleBattle(builder, _o.Type);
		}

		// Token: 0x0401272A RID: 75562
		private Table __p;
	}
}
