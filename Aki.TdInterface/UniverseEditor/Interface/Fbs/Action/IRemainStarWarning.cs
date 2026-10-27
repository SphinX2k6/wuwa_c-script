using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E37 RID: 28215
	public struct IRemainStarWarning : IFlatbufferObject
	{
		// Token: 0x1700D23E RID: 53822
		// (get) Token: 0x06031D9C RID: 204188 RVA: 0x006BF37D File Offset: 0x006BD57D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031D9D RID: 204189 RVA: 0x006BF38A File Offset: 0x006BD58A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031D9E RID: 204190 RVA: 0x006BF394 File Offset: 0x006BD594
		public static IRemainStarWarning GetRootAsIRemainStarWarning(ByteBuffer _bb)
		{
			return IRemainStarWarning.GetRootAsIRemainStarWarning(_bb, default(IRemainStarWarning));
		}

		// Token: 0x06031D9F RID: 204191 RVA: 0x006BF3B0 File Offset: 0x006BD5B0
		public static IRemainStarWarning GetRootAsIRemainStarWarning(ByteBuffer _bb, IRemainStarWarning obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031DA0 RID: 204192 RVA: 0x006BF3CD File Offset: 0x006BD5CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031DA1 RID: 204193 RVA: 0x006BF3DC File Offset: 0x006BD5DC
		public IRemainStarWarning __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D23F RID: 53823
		// (get) Token: 0x06031DA2 RID: 204194 RVA: 0x006BF3EC File Offset: 0x006BD5EC
		public ECommonTipType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECommonTipType.ChallengeCondition;
				}
				return (ECommonTipType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D240 RID: 53824
		// (get) Token: 0x06031DA3 RID: 204195 RVA: 0x006BF428 File Offset: 0x006BD628
		public string WarningText
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031DA4 RID: 204196 RVA: 0x006BF45F File Offset: 0x006BD65F
		public Span<byte> GetWarningTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06031DA5 RID: 204197 RVA: 0x006BF46E File Offset: 0x006BD66E
		public byte[] GetWarningTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06031DA6 RID: 204198 RVA: 0x006BF47C File Offset: 0x006BD67C
		public static Offset<IRemainStarWarning> CreateIRemainStarWarning(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, StringOffset WarningTextOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IRemainStarWarning.AddWarningText(builder, WarningTextOffset);
			IRemainStarWarning.AddType(builder, Type);
			return IRemainStarWarning.EndIRemainStarWarning(builder);
		}

		// Token: 0x06031DA7 RID: 204199 RVA: 0x006BF499 File Offset: 0x006BD699
		public static void StartIRemainStarWarning(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031DA8 RID: 204200 RVA: 0x006BF4A2 File Offset: 0x006BD6A2
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031DA9 RID: 204201 RVA: 0x006BF4AD File Offset: 0x006BD6AD
		public static void AddWarningText(FlatBufferBuilder builder, StringOffset warningTextOffset)
		{
			builder.AddOffset(1, warningTextOffset.Value, 0);
		}

		// Token: 0x06031DAA RID: 204202 RVA: 0x006BF4BD File Offset: 0x006BD6BD
		public static Offset<IRemainStarWarning> EndIRemainStarWarning(FlatBufferBuilder builder)
		{
			return new Offset<IRemainStarWarning>(builder.EndTable());
		}

		// Token: 0x06031DAB RID: 204203 RVA: 0x006BF4CC File Offset: 0x006BD6CC
		public IRemainStarWarningT UnPack()
		{
			IRemainStarWarningT remainStarWarningT = new IRemainStarWarningT();
			this.UnPackTo(remainStarWarningT);
			return remainStarWarningT;
		}

		// Token: 0x06031DAC RID: 204204 RVA: 0x006BF4E7 File Offset: 0x006BD6E7
		public void UnPackTo(IRemainStarWarningT _o)
		{
			_o.Type = this.Type;
			_o.WarningText = this.WarningText;
		}

		// Token: 0x06031DAD RID: 204205 RVA: 0x006BF504 File Offset: 0x006BD704
		public static Offset<IRemainStarWarning> Pack(FlatBufferBuilder builder, IRemainStarWarningT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRemainStarWarning>);
			}
			StringOffset warningTextOffset = (_o.WarningText == null) ? default(StringOffset) : builder.CreateString(_o.WarningText);
			return IRemainStarWarning.CreateIRemainStarWarning(builder, _o.Type, warningTextOffset);
		}

		// Token: 0x0401181B RID: 71707
		private Table __p;
	}
}
