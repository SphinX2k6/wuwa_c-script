using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004229 RID: 16937
	public struct ITrapDefenseConditionStepLoadAndRestoreMap : IFlatbufferObject
	{
		// Token: 0x1700784C RID: 30796
		// (get) Token: 0x060190A4 RID: 102564 RVA: 0x0039A552 File Offset: 0x00398752
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060190A5 RID: 102565 RVA: 0x0039A55F File Offset: 0x0039875F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060190A6 RID: 102566 RVA: 0x0039A568 File Offset: 0x00398768
		public static ITrapDefenseConditionStepLoadAndRestoreMap GetRootAsITrapDefenseConditionStepLoadAndRestoreMap(ByteBuffer _bb)
		{
			return ITrapDefenseConditionStepLoadAndRestoreMap.GetRootAsITrapDefenseConditionStepLoadAndRestoreMap(_bb, default(ITrapDefenseConditionStepLoadAndRestoreMap));
		}

		// Token: 0x060190A7 RID: 102567 RVA: 0x0039A584 File Offset: 0x00398784
		public static ITrapDefenseConditionStepLoadAndRestoreMap GetRootAsITrapDefenseConditionStepLoadAndRestoreMap(ByteBuffer _bb, ITrapDefenseConditionStepLoadAndRestoreMap obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060190A8 RID: 102568 RVA: 0x0039A5A1 File Offset: 0x003987A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060190A9 RID: 102569 RVA: 0x0039A5B0 File Offset: 0x003987B0
		public ITrapDefenseConditionStepLoadAndRestoreMap __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700784D RID: 30797
		// (get) Token: 0x060190AA RID: 102570 RVA: 0x0039A5C0 File Offset: 0x003987C0
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

		// Token: 0x060190AB RID: 102571 RVA: 0x0039A5FC File Offset: 0x003987FC
		public static Offset<ITrapDefenseConditionStepLoadAndRestoreMap> CreateITrapDefenseConditionStepLoadAndRestoreMap(FlatBufferBuilder builder, ETrapDefenseConditionStep Type = ETrapDefenseConditionStep.Reward)
		{
			builder.StartTable(1);
			ITrapDefenseConditionStepLoadAndRestoreMap.AddType(builder, Type);
			return ITrapDefenseConditionStepLoadAndRestoreMap.EndITrapDefenseConditionStepLoadAndRestoreMap(builder);
		}

		// Token: 0x060190AC RID: 102572 RVA: 0x0039A612 File Offset: 0x00398812
		public static void StartITrapDefenseConditionStepLoadAndRestoreMap(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060190AD RID: 102573 RVA: 0x0039A61B File Offset: 0x0039881B
		public static void AddType(FlatBufferBuilder builder, ETrapDefenseConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060190AE RID: 102574 RVA: 0x0039A626 File Offset: 0x00398826
		public static Offset<ITrapDefenseConditionStepLoadAndRestoreMap> EndITrapDefenseConditionStepLoadAndRestoreMap(FlatBufferBuilder builder)
		{
			return new Offset<ITrapDefenseConditionStepLoadAndRestoreMap>(builder.EndTable());
		}

		// Token: 0x060190AF RID: 102575 RVA: 0x0039A634 File Offset: 0x00398834
		public ITrapDefenseConditionStepLoadAndRestoreMapT UnPack()
		{
			ITrapDefenseConditionStepLoadAndRestoreMapT trapDefenseConditionStepLoadAndRestoreMapT = new ITrapDefenseConditionStepLoadAndRestoreMapT();
			this.UnPackTo(trapDefenseConditionStepLoadAndRestoreMapT);
			return trapDefenseConditionStepLoadAndRestoreMapT;
		}

		// Token: 0x060190B0 RID: 102576 RVA: 0x0039A64F File Offset: 0x0039884F
		public void UnPackTo(ITrapDefenseConditionStepLoadAndRestoreMapT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060190B1 RID: 102577 RVA: 0x0039A660 File Offset: 0x00398860
		public static Offset<ITrapDefenseConditionStepLoadAndRestoreMap> Pack(FlatBufferBuilder builder, ITrapDefenseConditionStepLoadAndRestoreMapT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrapDefenseConditionStepLoadAndRestoreMap>);
			}
			return ITrapDefenseConditionStepLoadAndRestoreMap.CreateITrapDefenseConditionStepLoadAndRestoreMap(builder, _o.Type);
		}

		// Token: 0x0400BEB0 RID: 48816
		private Table __p;
	}
}
