using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DCB RID: 28107
	public struct IPromptStyleBattle : IFlatbufferObject
	{
		// Token: 0x1700D191 RID: 53649
		// (get) Token: 0x06031A5D RID: 203357 RVA: 0x006B9D1C File Offset: 0x006B7F1C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031A5E RID: 203358 RVA: 0x006B9D29 File Offset: 0x006B7F29
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031A5F RID: 203359 RVA: 0x006B9D30 File Offset: 0x006B7F30
		public static IPromptStyleBattle GetRootAsIPromptStyleBattle(ByteBuffer _bb)
		{
			return IPromptStyleBattle.GetRootAsIPromptStyleBattle(_bb, default(IPromptStyleBattle));
		}

		// Token: 0x06031A60 RID: 203360 RVA: 0x006B9D4C File Offset: 0x006B7F4C
		public static IPromptStyleBattle GetRootAsIPromptStyleBattle(ByteBuffer _bb, IPromptStyleBattle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031A61 RID: 203361 RVA: 0x006B9D69 File Offset: 0x006B7F69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031A62 RID: 203362 RVA: 0x006B9D78 File Offset: 0x006B7F78
		public IPromptStyleBattle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D192 RID: 53650
		// (get) Token: 0x06031A63 RID: 203363 RVA: 0x006B9D88 File Offset: 0x006B7F88
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

		// Token: 0x06031A64 RID: 203364 RVA: 0x006B9DC4 File Offset: 0x006B7FC4
		public static Offset<IPromptStyleBattle> CreateIPromptStyleBattle(FlatBufferBuilder builder, EPromptStyle Type = EPromptStyle.Default)
		{
			builder.StartTable(1);
			IPromptStyleBattle.AddType(builder, Type);
			return IPromptStyleBattle.EndIPromptStyleBattle(builder);
		}

		// Token: 0x06031A65 RID: 203365 RVA: 0x006B9DDA File Offset: 0x006B7FDA
		public static void StartIPromptStyleBattle(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031A66 RID: 203366 RVA: 0x006B9DE3 File Offset: 0x006B7FE3
		public static void AddType(FlatBufferBuilder builder, EPromptStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031A67 RID: 203367 RVA: 0x006B9DEE File Offset: 0x006B7FEE
		public static Offset<IPromptStyleBattle> EndIPromptStyleBattle(FlatBufferBuilder builder)
		{
			return new Offset<IPromptStyleBattle>(builder.EndTable());
		}

		// Token: 0x06031A68 RID: 203368 RVA: 0x006B9DFC File Offset: 0x006B7FFC
		public IPromptStyleBattleT UnPack()
		{
			IPromptStyleBattleT promptStyleBattleT = new IPromptStyleBattleT();
			this.UnPackTo(promptStyleBattleT);
			return promptStyleBattleT;
		}

		// Token: 0x06031A69 RID: 203369 RVA: 0x006B9E17 File Offset: 0x006B8017
		public void UnPackTo(IPromptStyleBattleT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06031A6A RID: 203370 RVA: 0x006B9E28 File Offset: 0x006B8028
		public static Offset<IPromptStyleBattle> Pack(FlatBufferBuilder builder, IPromptStyleBattleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPromptStyleBattle>);
			}
			return IPromptStyleBattle.CreateIPromptStyleBattle(builder, _o.Type);
		}

		// Token: 0x040117AE RID: 71598
		private Table __p;
	}
}
