using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EDB RID: 28379
	public struct IFollowShooterLeisureInteract : IFlatbufferObject
	{
		// Token: 0x1700D021 RID: 53281
		// (get) Token: 0x06031197 RID: 201111 RVA: 0x006A8329 File Offset: 0x006A6529
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031198 RID: 201112 RVA: 0x006A8336 File Offset: 0x006A6536
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031199 RID: 201113 RVA: 0x006A8340 File Offset: 0x006A6540
		public static IFollowShooterLeisureInteract GetRootAsIFollowShooterLeisureInteract(ByteBuffer _bb)
		{
			return IFollowShooterLeisureInteract.GetRootAsIFollowShooterLeisureInteract(_bb, default(IFollowShooterLeisureInteract));
		}

		// Token: 0x0603119A RID: 201114 RVA: 0x006A835C File Offset: 0x006A655C
		public static IFollowShooterLeisureInteract GetRootAsIFollowShooterLeisureInteract(ByteBuffer _bb, IFollowShooterLeisureInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603119B RID: 201115 RVA: 0x006A8379 File Offset: 0x006A6579
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603119C RID: 201116 RVA: 0x006A8388 File Offset: 0x006A6588
		public IFollowShooterLeisureInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D022 RID: 53282
		// (get) Token: 0x0603119D RID: 201117 RVA: 0x006A8398 File Offset: 0x006A6598
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D023 RID: 53283
		// (get) Token: 0x0603119E RID: 201118 RVA: 0x006A83D4 File Offset: 0x006A65D4
		public TFollowShooterLeisureType InteractTypeType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TFollowShooterLeisureType.NONE;
				}
				return (TFollowShooterLeisureType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603119F RID: 201119 RVA: 0x006A8410 File Offset: 0x006A6610
		public TTable? InteractType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060311A0 RID: 201120 RVA: 0x006A8454 File Offset: 0x006A6654
		public IFollowShooterLeaveThrowInteractionPoint InteractTypeAsIFollowShooterLeaveThrowInteractionPoint()
		{
			return this.InteractType<IFollowShooterLeaveThrowInteractionPoint>().Value;
		}

		// Token: 0x060311A1 RID: 201121 RVA: 0x006A8470 File Offset: 0x006A6670
		public IFollowShooterResetToPlayer InteractTypeAsIFollowShooterResetToPlayer()
		{
			return this.InteractType<IFollowShooterResetToPlayer>().Value;
		}

		// Token: 0x060311A2 RID: 201122 RVA: 0x006A848B File Offset: 0x006A668B
		public static Offset<IFollowShooterLeisureInteract> CreateIFollowShooterLeisureInteract(FlatBufferBuilder builder, int Id = 0, TFollowShooterLeisureType InteractType_type = TFollowShooterLeisureType.NONE, int InteractTypeOffset = 0)
		{
			builder.StartTable(3);
			IFollowShooterLeisureInteract.AddInteractType(builder, InteractTypeOffset);
			IFollowShooterLeisureInteract.AddId(builder, Id);
			IFollowShooterLeisureInteract.AddInteractTypeType(builder, InteractType_type);
			return IFollowShooterLeisureInteract.EndIFollowShooterLeisureInteract(builder);
		}

		// Token: 0x060311A3 RID: 201123 RVA: 0x006A84AF File Offset: 0x006A66AF
		public static void StartIFollowShooterLeisureInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060311A4 RID: 201124 RVA: 0x006A84B8 File Offset: 0x006A66B8
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x060311A5 RID: 201125 RVA: 0x006A84C3 File Offset: 0x006A66C3
		public static void AddInteractTypeType(FlatBufferBuilder builder, TFollowShooterLeisureType interactTypeType)
		{
			builder.AddByte(1, (byte)interactTypeType, 0);
		}

		// Token: 0x060311A6 RID: 201126 RVA: 0x006A84CE File Offset: 0x006A66CE
		public static void AddInteractType(FlatBufferBuilder builder, int interactTypeOffset)
		{
			builder.AddOffset(2, interactTypeOffset, 0);
		}

		// Token: 0x060311A7 RID: 201127 RVA: 0x006A84D9 File Offset: 0x006A66D9
		public static Offset<IFollowShooterLeisureInteract> EndIFollowShooterLeisureInteract(FlatBufferBuilder builder)
		{
			return new Offset<IFollowShooterLeisureInteract>(builder.EndTable());
		}

		// Token: 0x060311A8 RID: 201128 RVA: 0x006A84E8 File Offset: 0x006A66E8
		public IFollowShooterLeisureInteractT UnPack()
		{
			IFollowShooterLeisureInteractT followShooterLeisureInteractT = new IFollowShooterLeisureInteractT();
			this.UnPackTo(followShooterLeisureInteractT);
			return followShooterLeisureInteractT;
		}

		// Token: 0x060311A9 RID: 201129 RVA: 0x006A8504 File Offset: 0x006A6704
		public void UnPackTo(IFollowShooterLeisureInteractT _o)
		{
			_o.Id = this.Id;
			_o.InteractType = new TFollowShooterLeisureTypeUnion();
			_o.InteractType.Type = this.InteractTypeType;
			TFollowShooterLeisureType interactTypeType = this.InteractTypeType;
			if (interactTypeType == TFollowShooterLeisureType.IFollowShooterLeaveThrowInteractionPoint)
			{
				_o.InteractType.Value = ((this.InteractType<IFollowShooterLeaveThrowInteractionPoint>() != null) ? this.InteractType<IFollowShooterLeaveThrowInteractionPoint>().Value.UnPack() : null);
				return;
			}
			if (interactTypeType != TFollowShooterLeisureType.IFollowShooterResetToPlayer)
			{
				return;
			}
			_o.InteractType.Value = ((this.InteractType<IFollowShooterResetToPlayer>() != null) ? this.InteractType<IFollowShooterResetToPlayer>().Value.UnPack() : null);
		}

		// Token: 0x060311AA RID: 201130 RVA: 0x006A85B4 File Offset: 0x006A67B4
		public static Offset<IFollowShooterLeisureInteract> Pack(FlatBufferBuilder builder, IFollowShooterLeisureInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFollowShooterLeisureInteract>);
			}
			TFollowShooterLeisureType interactType_type = (_o.InteractType == null) ? TFollowShooterLeisureType.NONE : _o.InteractType.Type;
			int interactTypeOffset = (_o.InteractType == null) ? 0 : TFollowShooterLeisureTypeUnion.Pack(builder, _o.InteractType);
			return IFollowShooterLeisureInteract.CreateIFollowShooterLeisureInteract(builder, _o.Id, interactType_type, interactTypeOffset);
		}

		// Token: 0x04011DD9 RID: 73177
		private Table __p;
	}
}
