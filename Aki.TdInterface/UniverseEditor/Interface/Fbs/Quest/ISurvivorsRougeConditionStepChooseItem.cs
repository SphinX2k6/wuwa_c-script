using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200415D RID: 16733
	public struct ISurvivorsRougeConditionStepChooseItem : IFlatbufferObject
	{
		// Token: 0x1700768F RID: 30351
		// (get) Token: 0x06018934 RID: 100660 RVA: 0x0038A8FD File Offset: 0x00388AFD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018935 RID: 100661 RVA: 0x0038A90A File Offset: 0x00388B0A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018936 RID: 100662 RVA: 0x0038A914 File Offset: 0x00388B14
		public static ISurvivorsRougeConditionStepChooseItem GetRootAsISurvivorsRougeConditionStepChooseItem(ByteBuffer _bb)
		{
			return ISurvivorsRougeConditionStepChooseItem.GetRootAsISurvivorsRougeConditionStepChooseItem(_bb, default(ISurvivorsRougeConditionStepChooseItem));
		}

		// Token: 0x06018937 RID: 100663 RVA: 0x0038A930 File Offset: 0x00388B30
		public static ISurvivorsRougeConditionStepChooseItem GetRootAsISurvivorsRougeConditionStepChooseItem(ByteBuffer _bb, ISurvivorsRougeConditionStepChooseItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018938 RID: 100664 RVA: 0x0038A94D File Offset: 0x00388B4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018939 RID: 100665 RVA: 0x0038A95C File Offset: 0x00388B5C
		public ISurvivorsRougeConditionStepChooseItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007690 RID: 30352
		// (get) Token: 0x0601893A RID: 100666 RVA: 0x0038A96C File Offset: 0x00388B6C
		public ESurvivorsRougeConditionStep Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESurvivorsRougeConditionStep.Prepare;
				}
				return (ESurvivorsRougeConditionStep)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601893B RID: 100667 RVA: 0x0038A9A8 File Offset: 0x00388BA8
		public static Offset<ISurvivorsRougeConditionStepChooseItem> CreateISurvivorsRougeConditionStepChooseItem(FlatBufferBuilder builder, ESurvivorsRougeConditionStep Type = ESurvivorsRougeConditionStep.Prepare)
		{
			builder.StartTable(1);
			ISurvivorsRougeConditionStepChooseItem.AddType(builder, Type);
			return ISurvivorsRougeConditionStepChooseItem.EndISurvivorsRougeConditionStepChooseItem(builder);
		}

		// Token: 0x0601893C RID: 100668 RVA: 0x0038A9BE File Offset: 0x00388BBE
		public static void StartISurvivorsRougeConditionStepChooseItem(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601893D RID: 100669 RVA: 0x0038A9C7 File Offset: 0x00388BC7
		public static void AddType(FlatBufferBuilder builder, ESurvivorsRougeConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601893E RID: 100670 RVA: 0x0038A9D2 File Offset: 0x00388BD2
		public static Offset<ISurvivorsRougeConditionStepChooseItem> EndISurvivorsRougeConditionStepChooseItem(FlatBufferBuilder builder)
		{
			return new Offset<ISurvivorsRougeConditionStepChooseItem>(builder.EndTable());
		}

		// Token: 0x0601893F RID: 100671 RVA: 0x0038A9E0 File Offset: 0x00388BE0
		public ISurvivorsRougeConditionStepChooseItemT UnPack()
		{
			ISurvivorsRougeConditionStepChooseItemT survivorsRougeConditionStepChooseItemT = new ISurvivorsRougeConditionStepChooseItemT();
			this.UnPackTo(survivorsRougeConditionStepChooseItemT);
			return survivorsRougeConditionStepChooseItemT;
		}

		// Token: 0x06018940 RID: 100672 RVA: 0x0038A9FB File Offset: 0x00388BFB
		public void UnPackTo(ISurvivorsRougeConditionStepChooseItemT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06018941 RID: 100673 RVA: 0x0038AA0C File Offset: 0x00388C0C
		public static Offset<ISurvivorsRougeConditionStepChooseItem> Pack(FlatBufferBuilder builder, ISurvivorsRougeConditionStepChooseItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISurvivorsRougeConditionStepChooseItem>);
			}
			return ISurvivorsRougeConditionStepChooseItem.CreateISurvivorsRougeConditionStepChooseItem(builder, _o.Type);
		}

		// Token: 0x0400BD7D RID: 48509
		private Table __p;
	}
}
