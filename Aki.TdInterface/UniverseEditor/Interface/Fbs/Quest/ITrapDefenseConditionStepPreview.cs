using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200422F RID: 16943
	public struct ITrapDefenseConditionStepPreview : IFlatbufferObject
	{
		// Token: 0x17007852 RID: 30802
		// (get) Token: 0x060190C8 RID: 102600 RVA: 0x0039A841 File Offset: 0x00398A41
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060190C9 RID: 102601 RVA: 0x0039A84E File Offset: 0x00398A4E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060190CA RID: 102602 RVA: 0x0039A858 File Offset: 0x00398A58
		public static ITrapDefenseConditionStepPreview GetRootAsITrapDefenseConditionStepPreview(ByteBuffer _bb)
		{
			return ITrapDefenseConditionStepPreview.GetRootAsITrapDefenseConditionStepPreview(_bb, default(ITrapDefenseConditionStepPreview));
		}

		// Token: 0x060190CB RID: 102603 RVA: 0x0039A874 File Offset: 0x00398A74
		public static ITrapDefenseConditionStepPreview GetRootAsITrapDefenseConditionStepPreview(ByteBuffer _bb, ITrapDefenseConditionStepPreview obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060190CC RID: 102604 RVA: 0x0039A891 File Offset: 0x00398A91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060190CD RID: 102605 RVA: 0x0039A8A0 File Offset: 0x00398AA0
		public ITrapDefenseConditionStepPreview __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007853 RID: 30803
		// (get) Token: 0x060190CE RID: 102606 RVA: 0x0039A8B0 File Offset: 0x00398AB0
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

		// Token: 0x060190CF RID: 102607 RVA: 0x0039A8EC File Offset: 0x00398AEC
		public static Offset<ITrapDefenseConditionStepPreview> CreateITrapDefenseConditionStepPreview(FlatBufferBuilder builder, ETrapDefenseConditionStep Type = ETrapDefenseConditionStep.Reward)
		{
			builder.StartTable(1);
			ITrapDefenseConditionStepPreview.AddType(builder, Type);
			return ITrapDefenseConditionStepPreview.EndITrapDefenseConditionStepPreview(builder);
		}

		// Token: 0x060190D0 RID: 102608 RVA: 0x0039A902 File Offset: 0x00398B02
		public static void StartITrapDefenseConditionStepPreview(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060190D1 RID: 102609 RVA: 0x0039A90B File Offset: 0x00398B0B
		public static void AddType(FlatBufferBuilder builder, ETrapDefenseConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060190D2 RID: 102610 RVA: 0x0039A916 File Offset: 0x00398B16
		public static Offset<ITrapDefenseConditionStepPreview> EndITrapDefenseConditionStepPreview(FlatBufferBuilder builder)
		{
			return new Offset<ITrapDefenseConditionStepPreview>(builder.EndTable());
		}

		// Token: 0x060190D3 RID: 102611 RVA: 0x0039A924 File Offset: 0x00398B24
		public ITrapDefenseConditionStepPreviewT UnPack()
		{
			ITrapDefenseConditionStepPreviewT trapDefenseConditionStepPreviewT = new ITrapDefenseConditionStepPreviewT();
			this.UnPackTo(trapDefenseConditionStepPreviewT);
			return trapDefenseConditionStepPreviewT;
		}

		// Token: 0x060190D4 RID: 102612 RVA: 0x0039A93F File Offset: 0x00398B3F
		public void UnPackTo(ITrapDefenseConditionStepPreviewT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060190D5 RID: 102613 RVA: 0x0039A950 File Offset: 0x00398B50
		public static Offset<ITrapDefenseConditionStepPreview> Pack(FlatBufferBuilder builder, ITrapDefenseConditionStepPreviewT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrapDefenseConditionStepPreview>);
			}
			return ITrapDefenseConditionStepPreview.CreateITrapDefenseConditionStepPreview(builder, _o.Type);
		}

		// Token: 0x0400BEB4 RID: 48820
		private Table __p;
	}
}
