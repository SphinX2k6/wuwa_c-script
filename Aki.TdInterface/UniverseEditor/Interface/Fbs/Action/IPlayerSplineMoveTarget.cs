using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200748C RID: 29836
	public struct IPlayerSplineMoveTarget : IFlatbufferObject
	{
		// Token: 0x1700DB2B RID: 56107
		// (get) Token: 0x060343B2 RID: 213938 RVA: 0x00708ED1 File Offset: 0x007070D1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060343B3 RID: 213939 RVA: 0x00708EDE File Offset: 0x007070DE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060343B4 RID: 213940 RVA: 0x00708EE8 File Offset: 0x007070E8
		public static IPlayerSplineMoveTarget GetRootAsIPlayerSplineMoveTarget(ByteBuffer _bb)
		{
			return IPlayerSplineMoveTarget.GetRootAsIPlayerSplineMoveTarget(_bb, default(IPlayerSplineMoveTarget));
		}

		// Token: 0x060343B5 RID: 213941 RVA: 0x00708F04 File Offset: 0x00707104
		public static IPlayerSplineMoveTarget GetRootAsIPlayerSplineMoveTarget(ByteBuffer _bb, IPlayerSplineMoveTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060343B6 RID: 213942 RVA: 0x00708F21 File Offset: 0x00707121
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060343B7 RID: 213943 RVA: 0x00708F30 File Offset: 0x00707130
		public IPlayerSplineMoveTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DB2C RID: 56108
		// (get) Token: 0x060343B8 RID: 213944 RVA: 0x00708F40 File Offset: 0x00707140
		public ESplineMoveTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESplineMoveTargetType.Entity;
				}
				return (ESplineMoveTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DB2D RID: 56109
		// (get) Token: 0x060343B9 RID: 213945 RVA: 0x00708F7C File Offset: 0x0070717C
		public IThreeStageSplineMoveMontage? CustomMoveMontage
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IThreeStageSplineMoveMontage?(default(IThreeStageSplineMoveMontage).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060343BA RID: 213946 RVA: 0x00708FD9 File Offset: 0x007071D9
		public static Offset<IPlayerSplineMoveTarget> CreateIPlayerSplineMoveTarget(FlatBufferBuilder builder, ESplineMoveTargetType Type = ESplineMoveTargetType.Entity, Offset<IThreeStageSplineMoveMontage> CustomMoveMontageOffset = default(Offset<IThreeStageSplineMoveMontage>))
		{
			builder.StartTable(2);
			IPlayerSplineMoveTarget.AddCustomMoveMontage(builder, CustomMoveMontageOffset);
			IPlayerSplineMoveTarget.AddType(builder, Type);
			return IPlayerSplineMoveTarget.EndIPlayerSplineMoveTarget(builder);
		}

		// Token: 0x060343BB RID: 213947 RVA: 0x00708FF6 File Offset: 0x007071F6
		public static void StartIPlayerSplineMoveTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060343BC RID: 213948 RVA: 0x00708FFF File Offset: 0x007071FF
		public static void AddType(FlatBufferBuilder builder, ESplineMoveTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060343BD RID: 213949 RVA: 0x0070900A File Offset: 0x0070720A
		public static void AddCustomMoveMontage(FlatBufferBuilder builder, Offset<IThreeStageSplineMoveMontage> customMoveMontageOffset)
		{
			builder.AddOffset(1, customMoveMontageOffset.Value, 0);
		}

		// Token: 0x060343BE RID: 213950 RVA: 0x0070901A File Offset: 0x0070721A
		public static Offset<IPlayerSplineMoveTarget> EndIPlayerSplineMoveTarget(FlatBufferBuilder builder)
		{
			return new Offset<IPlayerSplineMoveTarget>(builder.EndTable());
		}

		// Token: 0x060343BF RID: 213951 RVA: 0x00709028 File Offset: 0x00707228
		public IPlayerSplineMoveTargetT UnPack()
		{
			IPlayerSplineMoveTargetT playerSplineMoveTargetT = new IPlayerSplineMoveTargetT();
			this.UnPackTo(playerSplineMoveTargetT);
			return playerSplineMoveTargetT;
		}

		// Token: 0x060343C0 RID: 213952 RVA: 0x00709044 File Offset: 0x00707244
		public void UnPackTo(IPlayerSplineMoveTargetT _o)
		{
			_o.Type = this.Type;
			_o.CustomMoveMontage = ((this.CustomMoveMontage != null) ? this.CustomMoveMontage.Value.UnPack() : null);
		}

		// Token: 0x060343C1 RID: 213953 RVA: 0x0070908C File Offset: 0x0070728C
		public static Offset<IPlayerSplineMoveTarget> Pack(FlatBufferBuilder builder, IPlayerSplineMoveTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayerSplineMoveTarget>);
			}
			Offset<IThreeStageSplineMoveMontage> customMoveMontageOffset = (_o.CustomMoveMontage == null) ? default(Offset<IThreeStageSplineMoveMontage>) : IThreeStageSplineMoveMontage.Pack(builder, _o.CustomMoveMontage);
			return IPlayerSplineMoveTarget.CreateIPlayerSplineMoveTarget(builder, _o.Type, customMoveMontageOffset);
		}

		// Token: 0x04012606 RID: 75270
		private Table __p;
	}
}
