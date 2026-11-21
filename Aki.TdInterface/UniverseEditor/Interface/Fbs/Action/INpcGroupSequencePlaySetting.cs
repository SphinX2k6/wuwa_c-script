using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200731C RID: 29468
	public struct INpcGroupSequencePlaySetting : IFlatbufferObject
	{
		// Token: 0x1700D7FC RID: 55292
		// (get) Token: 0x06033619 RID: 210457 RVA: 0x006ED8B2 File Offset: 0x006EBAB2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603361A RID: 210458 RVA: 0x006ED8BF File Offset: 0x006EBABF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603361B RID: 210459 RVA: 0x006ED8C8 File Offset: 0x006EBAC8
		public static INpcGroupSequencePlaySetting GetRootAsINpcGroupSequencePlaySetting(ByteBuffer _bb)
		{
			return INpcGroupSequencePlaySetting.GetRootAsINpcGroupSequencePlaySetting(_bb, default(INpcGroupSequencePlaySetting));
		}

		// Token: 0x0603361C RID: 210460 RVA: 0x006ED8E4 File Offset: 0x006EBAE4
		public static INpcGroupSequencePlaySetting GetRootAsINpcGroupSequencePlaySetting(ByteBuffer _bb, INpcGroupSequencePlaySetting obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603361D RID: 210461 RVA: 0x006ED901 File Offset: 0x006EBB01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603361E RID: 210462 RVA: 0x006ED910 File Offset: 0x006EBB10
		public INpcGroupSequencePlaySetting __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D7FD RID: 55293
		// (get) Token: 0x0603361F RID: 210463 RVA: 0x006ED920 File Offset: 0x006EBB20
		public string Mark
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033620 RID: 210464 RVA: 0x006ED957 File Offset: 0x006EBB57
		public Span<byte> GetMarkBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06033621 RID: 210465 RVA: 0x006ED966 File Offset: 0x006EBB66
		public byte[] GetMarkArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700D7FE RID: 55294
		// (get) Token: 0x06033622 RID: 210466 RVA: 0x006ED974 File Offset: 0x006EBB74
		public bool IsLoop
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D7FF RID: 55295
		// (get) Token: 0x06033623 RID: 210467 RVA: 0x006ED9B4 File Offset: 0x006EBBB4
		public bool IsWaitCurrentSequenceFinish
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06033624 RID: 210468 RVA: 0x006ED9F3 File Offset: 0x006EBBF3
		public static Offset<INpcGroupSequencePlaySetting> CreateINpcGroupSequencePlaySetting(FlatBufferBuilder builder, StringOffset MarkOffset = default(StringOffset), bool IsLoop = false, bool IsWaitCurrentSequenceFinish = false)
		{
			builder.StartTable(3);
			INpcGroupSequencePlaySetting.AddMark(builder, MarkOffset);
			INpcGroupSequencePlaySetting.AddIsWaitCurrentSequenceFinish(builder, IsWaitCurrentSequenceFinish);
			INpcGroupSequencePlaySetting.AddIsLoop(builder, IsLoop);
			return INpcGroupSequencePlaySetting.EndINpcGroupSequencePlaySetting(builder);
		}

		// Token: 0x06033625 RID: 210469 RVA: 0x006EDA17 File Offset: 0x006EBC17
		public static void StartINpcGroupSequencePlaySetting(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06033626 RID: 210470 RVA: 0x006EDA20 File Offset: 0x006EBC20
		public static void AddMark(FlatBufferBuilder builder, StringOffset markOffset)
		{
			builder.AddOffset(0, markOffset.Value, 0);
		}

		// Token: 0x06033627 RID: 210471 RVA: 0x006EDA30 File Offset: 0x006EBC30
		public static void AddIsLoop(FlatBufferBuilder builder, bool isLoop)
		{
			builder.AddBool(1, isLoop, false);
		}

		// Token: 0x06033628 RID: 210472 RVA: 0x006EDA3B File Offset: 0x006EBC3B
		public static void AddIsWaitCurrentSequenceFinish(FlatBufferBuilder builder, bool isWaitCurrentSequenceFinish)
		{
			builder.AddBool(2, isWaitCurrentSequenceFinish, false);
		}

		// Token: 0x06033629 RID: 210473 RVA: 0x006EDA46 File Offset: 0x006EBC46
		public static Offset<INpcGroupSequencePlaySetting> EndINpcGroupSequencePlaySetting(FlatBufferBuilder builder)
		{
			return new Offset<INpcGroupSequencePlaySetting>(builder.EndTable());
		}

		// Token: 0x0603362A RID: 210474 RVA: 0x006EDA54 File Offset: 0x006EBC54
		public INpcGroupSequencePlaySettingT UnPack()
		{
			INpcGroupSequencePlaySettingT npcGroupSequencePlaySettingT = new INpcGroupSequencePlaySettingT();
			this.UnPackTo(npcGroupSequencePlaySettingT);
			return npcGroupSequencePlaySettingT;
		}

		// Token: 0x0603362B RID: 210475 RVA: 0x006EDA6F File Offset: 0x006EBC6F
		public void UnPackTo(INpcGroupSequencePlaySettingT _o)
		{
			_o.Mark = this.Mark;
			_o.IsLoop = this.IsLoop;
			_o.IsWaitCurrentSequenceFinish = this.IsWaitCurrentSequenceFinish;
		}

		// Token: 0x0603362C RID: 210476 RVA: 0x006EDA98 File Offset: 0x006EBC98
		public static Offset<INpcGroupSequencePlaySetting> Pack(FlatBufferBuilder builder, INpcGroupSequencePlaySettingT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcGroupSequencePlaySetting>);
			}
			StringOffset markOffset = (_o.Mark == null) ? default(StringOffset) : builder.CreateString(_o.Mark);
			return INpcGroupSequencePlaySetting.CreateINpcGroupSequencePlaySetting(builder, markOffset, _o.IsLoop, _o.IsWaitCurrentSequenceFinish);
		}

		// Token: 0x040123DD RID: 74717
		private Table __p;
	}
}
