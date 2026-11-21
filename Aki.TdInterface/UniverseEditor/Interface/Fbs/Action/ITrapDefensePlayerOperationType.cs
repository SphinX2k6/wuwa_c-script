using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C59 RID: 31833
	public struct ITrapDefensePlayerOperationType : IFlatbufferObject
	{
		// Token: 0x1700EE4B RID: 61003
		// (get) Token: 0x06039611 RID: 235025 RVA: 0x007BF285 File Offset: 0x007BD485
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039612 RID: 235026 RVA: 0x007BF292 File Offset: 0x007BD492
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039613 RID: 235027 RVA: 0x007BF29C File Offset: 0x007BD49C
		public static ITrapDefensePlayerOperationType GetRootAsITrapDefensePlayerOperationType(ByteBuffer _bb)
		{
			return ITrapDefensePlayerOperationType.GetRootAsITrapDefensePlayerOperationType(_bb, default(ITrapDefensePlayerOperationType));
		}

		// Token: 0x06039614 RID: 235028 RVA: 0x007BF2B8 File Offset: 0x007BD4B8
		public static ITrapDefensePlayerOperationType GetRootAsITrapDefensePlayerOperationType(ByteBuffer _bb, ITrapDefensePlayerOperationType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039615 RID: 235029 RVA: 0x007BF2D5 File Offset: 0x007BD4D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039616 RID: 235030 RVA: 0x007BF2E4 File Offset: 0x007BD4E4
		public ITrapDefensePlayerOperationType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EE4C RID: 61004
		// (get) Token: 0x06039617 RID: 235031 RVA: 0x007BF2F4 File Offset: 0x007BD4F4
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

		// Token: 0x06039618 RID: 235032 RVA: 0x007BF330 File Offset: 0x007BD530
		public static Offset<ITrapDefensePlayerOperationType> CreateITrapDefensePlayerOperationType(FlatBufferBuilder builder, ETrapDefensePlayerOperationType Type = ETrapDefensePlayerOperationType.SpawnMonster)
		{
			builder.StartTable(1);
			ITrapDefensePlayerOperationType.AddType(builder, Type);
			return ITrapDefensePlayerOperationType.EndITrapDefensePlayerOperationType(builder);
		}

		// Token: 0x06039619 RID: 235033 RVA: 0x007BF346 File Offset: 0x007BD546
		public static void StartITrapDefensePlayerOperationType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603961A RID: 235034 RVA: 0x007BF34F File Offset: 0x007BD54F
		public static void AddType(FlatBufferBuilder builder, ETrapDefensePlayerOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603961B RID: 235035 RVA: 0x007BF35A File Offset: 0x007BD55A
		public static Offset<ITrapDefensePlayerOperationType> EndITrapDefensePlayerOperationType(FlatBufferBuilder builder)
		{
			return new Offset<ITrapDefensePlayerOperationType>(builder.EndTable());
		}

		// Token: 0x0603961C RID: 235036 RVA: 0x007BF368 File Offset: 0x007BD568
		public ITrapDefensePlayerOperationTypeT UnPack()
		{
			ITrapDefensePlayerOperationTypeT trapDefensePlayerOperationTypeT = new ITrapDefensePlayerOperationTypeT();
			this.UnPackTo(trapDefensePlayerOperationTypeT);
			return trapDefensePlayerOperationTypeT;
		}

		// Token: 0x0603961D RID: 235037 RVA: 0x007BF383 File Offset: 0x007BD583
		public void UnPackTo(ITrapDefensePlayerOperationTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603961E RID: 235038 RVA: 0x007BF394 File Offset: 0x007BD594
		public static Offset<ITrapDefensePlayerOperationType> Pack(FlatBufferBuilder builder, ITrapDefensePlayerOperationTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrapDefensePlayerOperationType>);
			}
			return ITrapDefensePlayerOperationType.CreateITrapDefensePlayerOperationType(builder, _o.Type);
		}

		// Token: 0x04013314 RID: 78612
		private Table __p;
	}
}
