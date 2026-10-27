using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073A9 RID: 29609
	public struct ITeleportTransitionWithCenterText : IFlatbufferObject
	{
		// Token: 0x1700E0C4 RID: 57540
		// (get) Token: 0x06035C05 RID: 220165 RVA: 0x007510EA File Offset: 0x0074F2EA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035C06 RID: 220166 RVA: 0x007510F7 File Offset: 0x0074F2F7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035C07 RID: 220167 RVA: 0x00751100 File Offset: 0x0074F300
		public static ITeleportTransitionWithCenterText GetRootAsITeleportTransitionWithCenterText(ByteBuffer _bb)
		{
			return ITeleportTransitionWithCenterText.GetRootAsITeleportTransitionWithCenterText(_bb, default(ITeleportTransitionWithCenterText));
		}

		// Token: 0x06035C08 RID: 220168 RVA: 0x0075111C File Offset: 0x0074F31C
		public static ITeleportTransitionWithCenterText GetRootAsITeleportTransitionWithCenterText(ByteBuffer _bb, ITeleportTransitionWithCenterText obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035C09 RID: 220169 RVA: 0x00751139 File Offset: 0x0074F339
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035C0A RID: 220170 RVA: 0x00751148 File Offset: 0x0074F348
		public ITeleportTransitionWithCenterText __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E0C5 RID: 57541
		// (get) Token: 0x06035C0B RID: 220171 RVA: 0x00751158 File Offset: 0x0074F358
		public ETeleportTransitionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETeleportTransitionType.PlayMp4;
				}
				return (ETeleportTransitionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E0C6 RID: 57542
		// (get) Token: 0x06035C0C RID: 220172 RVA: 0x00751194 File Offset: 0x0074F394
		public IPlayFlow? CenterTextFlow
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IPlayFlow?(default(IPlayFlow).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06035C0D RID: 220173 RVA: 0x007511F1 File Offset: 0x0074F3F1
		public static Offset<ITeleportTransitionWithCenterText> CreateITeleportTransitionWithCenterText(FlatBufferBuilder builder, ETeleportTransitionType Type = ETeleportTransitionType.PlayMp4, Offset<IPlayFlow> CenterTextFlowOffset = default(Offset<IPlayFlow>))
		{
			builder.StartTable(2);
			ITeleportTransitionWithCenterText.AddCenterTextFlow(builder, CenterTextFlowOffset);
			ITeleportTransitionWithCenterText.AddType(builder, Type);
			return ITeleportTransitionWithCenterText.EndITeleportTransitionWithCenterText(builder);
		}

		// Token: 0x06035C0E RID: 220174 RVA: 0x0075120E File Offset: 0x0074F40E
		public static void StartITeleportTransitionWithCenterText(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06035C0F RID: 220175 RVA: 0x00751217 File Offset: 0x0074F417
		public static void AddType(FlatBufferBuilder builder, ETeleportTransitionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035C10 RID: 220176 RVA: 0x00751222 File Offset: 0x0074F422
		public static void AddCenterTextFlow(FlatBufferBuilder builder, Offset<IPlayFlow> centerTextFlowOffset)
		{
			builder.AddOffset(1, centerTextFlowOffset.Value, 0);
		}

		// Token: 0x06035C11 RID: 220177 RVA: 0x00751232 File Offset: 0x0074F432
		public static Offset<ITeleportTransitionWithCenterText> EndITeleportTransitionWithCenterText(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportTransitionWithCenterText>(builder.EndTable());
		}

		// Token: 0x06035C12 RID: 220178 RVA: 0x00751240 File Offset: 0x0074F440
		public ITeleportTransitionWithCenterTextT UnPack()
		{
			ITeleportTransitionWithCenterTextT teleportTransitionWithCenterTextT = new ITeleportTransitionWithCenterTextT();
			this.UnPackTo(teleportTransitionWithCenterTextT);
			return teleportTransitionWithCenterTextT;
		}

		// Token: 0x06035C13 RID: 220179 RVA: 0x0075125C File Offset: 0x0074F45C
		public void UnPackTo(ITeleportTransitionWithCenterTextT _o)
		{
			_o.Type = this.Type;
			_o.CenterTextFlow = ((this.CenterTextFlow != null) ? this.CenterTextFlow.Value.UnPack() : null);
		}

		// Token: 0x06035C14 RID: 220180 RVA: 0x007512A4 File Offset: 0x0074F4A4
		public static Offset<ITeleportTransitionWithCenterText> Pack(FlatBufferBuilder builder, ITeleportTransitionWithCenterTextT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleportTransitionWithCenterText>);
			}
			Offset<IPlayFlow> centerTextFlowOffset = (_o.CenterTextFlow == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.CenterTextFlow);
			return ITeleportTransitionWithCenterText.CreateITeleportTransitionWithCenterText(builder, _o.Type, centerTextFlowOffset);
		}

		// Token: 0x040121DD RID: 74205
		private Table __p;
	}
}
