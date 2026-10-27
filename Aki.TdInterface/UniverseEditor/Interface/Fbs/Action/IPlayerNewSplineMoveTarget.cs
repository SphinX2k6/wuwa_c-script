using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D05 RID: 27909
	public struct IPlayerNewSplineMoveTarget : IFlatbufferObject
	{
		// Token: 0x1700CFD9 RID: 53209
		// (get) Token: 0x06031372 RID: 201586 RVA: 0x006AD2AF File Offset: 0x006AB4AF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031373 RID: 201587 RVA: 0x006AD2BC File Offset: 0x006AB4BC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031374 RID: 201588 RVA: 0x006AD2C4 File Offset: 0x006AB4C4
		public static IPlayerNewSplineMoveTarget GetRootAsIPlayerNewSplineMoveTarget(ByteBuffer _bb)
		{
			return IPlayerNewSplineMoveTarget.GetRootAsIPlayerNewSplineMoveTarget(_bb, default(IPlayerNewSplineMoveTarget));
		}

		// Token: 0x06031375 RID: 201589 RVA: 0x006AD2E0 File Offset: 0x006AB4E0
		public static IPlayerNewSplineMoveTarget GetRootAsIPlayerNewSplineMoveTarget(ByteBuffer _bb, IPlayerNewSplineMoveTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031376 RID: 201590 RVA: 0x006AD2FD File Offset: 0x006AB4FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031377 RID: 201591 RVA: 0x006AD30C File Offset: 0x006AB50C
		public IPlayerNewSplineMoveTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CFDA RID: 53210
		// (get) Token: 0x06031378 RID: 201592 RVA: 0x006AD31C File Offset: 0x006AB51C
		public ENewSplineMoveTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENewSplineMoveTargetType.Player;
				}
				return (ENewSplineMoveTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031379 RID: 201593 RVA: 0x006AD358 File Offset: 0x006AB558
		public static Offset<IPlayerNewSplineMoveTarget> CreateIPlayerNewSplineMoveTarget(FlatBufferBuilder builder, ENewSplineMoveTargetType Type = ENewSplineMoveTargetType.Player)
		{
			builder.StartTable(1);
			IPlayerNewSplineMoveTarget.AddType(builder, Type);
			return IPlayerNewSplineMoveTarget.EndIPlayerNewSplineMoveTarget(builder);
		}

		// Token: 0x0603137A RID: 201594 RVA: 0x006AD36E File Offset: 0x006AB56E
		public static void StartIPlayerNewSplineMoveTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603137B RID: 201595 RVA: 0x006AD377 File Offset: 0x006AB577
		public static void AddType(FlatBufferBuilder builder, ENewSplineMoveTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603137C RID: 201596 RVA: 0x006AD382 File Offset: 0x006AB582
		public static Offset<IPlayerNewSplineMoveTarget> EndIPlayerNewSplineMoveTarget(FlatBufferBuilder builder)
		{
			return new Offset<IPlayerNewSplineMoveTarget>(builder.EndTable());
		}

		// Token: 0x0603137D RID: 201597 RVA: 0x006AD390 File Offset: 0x006AB590
		public IPlayerNewSplineMoveTargetT UnPack()
		{
			IPlayerNewSplineMoveTargetT playerNewSplineMoveTargetT = new IPlayerNewSplineMoveTargetT();
			this.UnPackTo(playerNewSplineMoveTargetT);
			return playerNewSplineMoveTargetT;
		}

		// Token: 0x0603137E RID: 201598 RVA: 0x006AD3AB File Offset: 0x006AB5AB
		public void UnPackTo(IPlayerNewSplineMoveTargetT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603137F RID: 201599 RVA: 0x006AD3BC File Offset: 0x006AB5BC
		public static Offset<IPlayerNewSplineMoveTarget> Pack(FlatBufferBuilder builder, IPlayerNewSplineMoveTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayerNewSplineMoveTarget>);
			}
			return IPlayerNewSplineMoveTarget.CreateIPlayerNewSplineMoveTarget(builder, _o.Type);
		}

		// Token: 0x04011683 RID: 71299
		private Table __p;
	}
}
