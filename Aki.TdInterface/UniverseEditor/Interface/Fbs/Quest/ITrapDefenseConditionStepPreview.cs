using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200468B RID: 18059
	public struct ITrapDefenseConditionStepPreview : IFlatbufferObject
	{
		// Token: 0x17007E83 RID: 32387
		// (get) Token: 0x0601A834 RID: 108596 RVA: 0x003C5F19 File Offset: 0x003C4119
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A835 RID: 108597 RVA: 0x003C5F26 File Offset: 0x003C4126
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A836 RID: 108598 RVA: 0x003C5F30 File Offset: 0x003C4130
		public static ITrapDefenseConditionStepPreview GetRootAsITrapDefenseConditionStepPreview(ByteBuffer _bb)
		{
			return ITrapDefenseConditionStepPreview.GetRootAsITrapDefenseConditionStepPreview(_bb, default(ITrapDefenseConditionStepPreview));
		}

		// Token: 0x0601A837 RID: 108599 RVA: 0x003C5F4C File Offset: 0x003C414C
		public static ITrapDefenseConditionStepPreview GetRootAsITrapDefenseConditionStepPreview(ByteBuffer _bb, ITrapDefenseConditionStepPreview obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A838 RID: 108600 RVA: 0x003C5F69 File Offset: 0x003C4169
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A839 RID: 108601 RVA: 0x003C5F78 File Offset: 0x003C4178
		public ITrapDefenseConditionStepPreview __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007E84 RID: 32388
		// (get) Token: 0x0601A83A RID: 108602 RVA: 0x003C5F88 File Offset: 0x003C4188
		public ETrapDefenseConditionStep Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETrapDefenseConditionStep.Reward;
				}
				return (ETrapDefenseConditionStep)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A83B RID: 108603 RVA: 0x003C5FC4 File Offset: 0x003C41C4
		public static Offset<ITrapDefenseConditionStepPreview> CreateITrapDefenseConditionStepPreview(FlatBufferBuilder builder, ETrapDefenseConditionStep Type = ETrapDefenseConditionStep.Reward)
		{
			builder.StartTable(1);
			ITrapDefenseConditionStepPreview.AddType(builder, Type);
			return ITrapDefenseConditionStepPreview.EndITrapDefenseConditionStepPreview(builder);
		}

		// Token: 0x0601A83C RID: 108604 RVA: 0x003C5FDA File Offset: 0x003C41DA
		public static void StartITrapDefenseConditionStepPreview(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601A83D RID: 108605 RVA: 0x003C5FE3 File Offset: 0x003C41E3
		public static void AddType(FlatBufferBuilder builder, ETrapDefenseConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A83E RID: 108606 RVA: 0x003C5FEE File Offset: 0x003C41EE
		public static Offset<ITrapDefenseConditionStepPreview> EndITrapDefenseConditionStepPreview(FlatBufferBuilder builder)
		{
			return new Offset<ITrapDefenseConditionStepPreview>(builder.EndTable());
		}

		// Token: 0x0601A83F RID: 108607 RVA: 0x003C5FFC File Offset: 0x003C41FC
		public ITrapDefenseConditionStepPreviewT UnPack()
		{
			ITrapDefenseConditionStepPreviewT trapDefenseConditionStepPreviewT = new ITrapDefenseConditionStepPreviewT();
			this.UnPackTo(trapDefenseConditionStepPreviewT);
			return trapDefenseConditionStepPreviewT;
		}

		// Token: 0x0601A840 RID: 108608 RVA: 0x003C6017 File Offset: 0x003C4217
		public void UnPackTo(ITrapDefenseConditionStepPreviewT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601A841 RID: 108609 RVA: 0x003C6028 File Offset: 0x003C4228
		public static Offset<ITrapDefenseConditionStepPreview> Pack(FlatBufferBuilder builder, ITrapDefenseConditionStepPreviewT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrapDefenseConditionStepPreview>);
			}
			return ITrapDefenseConditionStepPreview.CreateITrapDefenseConditionStepPreview(builder, _o.Type);
		}

		// Token: 0x0400C8C1 RID: 51393
		private Table __p;
	}
}
