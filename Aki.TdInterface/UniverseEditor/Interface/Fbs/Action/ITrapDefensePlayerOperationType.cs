using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007466 RID: 29798
	public struct ITrapDefensePlayerOperationType : IFlatbufferObject
	{
		// Token: 0x1700E22E RID: 57902
		// (get) Token: 0x06036228 RID: 221736 RVA: 0x0075C559 File Offset: 0x0075A759
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036229 RID: 221737 RVA: 0x0075C566 File Offset: 0x0075A766
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603622A RID: 221738 RVA: 0x0075C570 File Offset: 0x0075A770
		public static ITrapDefensePlayerOperationType GetRootAsITrapDefensePlayerOperationType(ByteBuffer _bb)
		{
			return ITrapDefensePlayerOperationType.GetRootAsITrapDefensePlayerOperationType(_bb, default(ITrapDefensePlayerOperationType));
		}

		// Token: 0x0603622B RID: 221739 RVA: 0x0075C58C File Offset: 0x0075A78C
		public static ITrapDefensePlayerOperationType GetRootAsITrapDefensePlayerOperationType(ByteBuffer _bb, ITrapDefensePlayerOperationType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603622C RID: 221740 RVA: 0x0075C5A9 File Offset: 0x0075A7A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603622D RID: 221741 RVA: 0x0075C5B8 File Offset: 0x0075A7B8
		public ITrapDefensePlayerOperationType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E22F RID: 57903
		// (get) Token: 0x0603622E RID: 221742 RVA: 0x0075C5C8 File Offset: 0x0075A7C8
		public ETrapDefensePlayerOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETrapDefensePlayerOperationType.SpawnMonster;
				}
				return (ETrapDefensePlayerOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603622F RID: 221743 RVA: 0x0075C604 File Offset: 0x0075A804
		public static Offset<ITrapDefensePlayerOperationType> CreateITrapDefensePlayerOperationType(FlatBufferBuilder builder, ETrapDefensePlayerOperationType Type = ETrapDefensePlayerOperationType.SpawnMonster)
		{
			builder.StartTable(1);
			ITrapDefensePlayerOperationType.AddType(builder, Type);
			return ITrapDefensePlayerOperationType.EndITrapDefensePlayerOperationType(builder);
		}

		// Token: 0x06036230 RID: 221744 RVA: 0x0075C61A File Offset: 0x0075A81A
		public static void StartITrapDefensePlayerOperationType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06036231 RID: 221745 RVA: 0x0075C623 File Offset: 0x0075A823
		public static void AddType(FlatBufferBuilder builder, ETrapDefensePlayerOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036232 RID: 221746 RVA: 0x0075C62E File Offset: 0x0075A82E
		public static Offset<ITrapDefensePlayerOperationType> EndITrapDefensePlayerOperationType(FlatBufferBuilder builder)
		{
			return new Offset<ITrapDefensePlayerOperationType>(builder.EndTable());
		}

		// Token: 0x06036233 RID: 221747 RVA: 0x0075C63C File Offset: 0x0075A83C
		public ITrapDefensePlayerOperationTypeT UnPack()
		{
			ITrapDefensePlayerOperationTypeT trapDefensePlayerOperationTypeT = new ITrapDefensePlayerOperationTypeT();
			this.UnPackTo(trapDefensePlayerOperationTypeT);
			return trapDefensePlayerOperationTypeT;
		}

		// Token: 0x06036234 RID: 221748 RVA: 0x0075C657 File Offset: 0x0075A857
		public void UnPackTo(ITrapDefensePlayerOperationTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06036235 RID: 221749 RVA: 0x0075C668 File Offset: 0x0075A868
		public static Offset<ITrapDefensePlayerOperationType> Pack(FlatBufferBuilder builder, ITrapDefensePlayerOperationTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrapDefensePlayerOperationType>);
			}
			return ITrapDefensePlayerOperationType.CreateITrapDefensePlayerOperationType(builder, _o.Type);
		}

		// Token: 0x040122ED RID: 74477
		private Table __p;
	}
}
