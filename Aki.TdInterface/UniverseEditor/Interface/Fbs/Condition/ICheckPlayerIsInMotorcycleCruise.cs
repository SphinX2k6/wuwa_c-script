using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FCB RID: 20427
	public struct ICheckPlayerIsInMotorcycleCruise : IFlatbufferObject
	{
		// Token: 0x1700921B RID: 37403
		// (get) Token: 0x0601FD95 RID: 130453 RVA: 0x0046C65A File Offset: 0x0046A85A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FD96 RID: 130454 RVA: 0x0046C667 File Offset: 0x0046A867
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FD97 RID: 130455 RVA: 0x0046C670 File Offset: 0x0046A870
		public static ICheckPlayerIsInMotorcycleCruise GetRootAsICheckPlayerIsInMotorcycleCruise(ByteBuffer _bb)
		{
			return ICheckPlayerIsInMotorcycleCruise.GetRootAsICheckPlayerIsInMotorcycleCruise(_bb, default(ICheckPlayerIsInMotorcycleCruise));
		}

		// Token: 0x0601FD98 RID: 130456 RVA: 0x0046C68C File Offset: 0x0046A88C
		public static ICheckPlayerIsInMotorcycleCruise GetRootAsICheckPlayerIsInMotorcycleCruise(ByteBuffer _bb, ICheckPlayerIsInMotorcycleCruise obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FD99 RID: 130457 RVA: 0x0046C6A9 File Offset: 0x0046A8A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FD9A RID: 130458 RVA: 0x0046C6B8 File Offset: 0x0046A8B8
		public ICheckPlayerIsInMotorcycleCruise __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700921C RID: 37404
		// (get) Token: 0x0601FD9B RID: 130459 RVA: 0x0046C6C8 File Offset: 0x0046A8C8
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700921D RID: 37405
		// (get) Token: 0x0601FD9C RID: 130460 RVA: 0x0046C704 File Offset: 0x0046A904
		public bool IsInMotorcycleCruise
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601FD9D RID: 130461 RVA: 0x0046C743 File Offset: 0x0046A943
		public static Offset<ICheckPlayerIsInMotorcycleCruise> CreateICheckPlayerIsInMotorcycleCruise(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, bool IsInMotorcycleCruise = false)
		{
			builder.StartTable(2);
			ICheckPlayerIsInMotorcycleCruise.AddIsInMotorcycleCruise(builder, IsInMotorcycleCruise);
			ICheckPlayerIsInMotorcycleCruise.AddType(builder, Type);
			return ICheckPlayerIsInMotorcycleCruise.EndICheckPlayerIsInMotorcycleCruise(builder);
		}

		// Token: 0x0601FD9E RID: 130462 RVA: 0x0046C760 File Offset: 0x0046A960
		public static void StartICheckPlayerIsInMotorcycleCruise(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601FD9F RID: 130463 RVA: 0x0046C769 File Offset: 0x0046A969
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FDA0 RID: 130464 RVA: 0x0046C774 File Offset: 0x0046A974
		public static void AddIsInMotorcycleCruise(FlatBufferBuilder builder, bool isInMotorcycleCruise)
		{
			builder.AddBool(1, isInMotorcycleCruise, false);
		}

		// Token: 0x0601FDA1 RID: 130465 RVA: 0x0046C77F File Offset: 0x0046A97F
		public static Offset<ICheckPlayerIsInMotorcycleCruise> EndICheckPlayerIsInMotorcycleCruise(FlatBufferBuilder builder)
		{
			return new Offset<ICheckPlayerIsInMotorcycleCruise>(builder.EndTable());
		}

		// Token: 0x0601FDA2 RID: 130466 RVA: 0x0046C78C File Offset: 0x0046A98C
		public ICheckPlayerIsInMotorcycleCruiseT UnPack()
		{
			ICheckPlayerIsInMotorcycleCruiseT checkPlayerIsInMotorcycleCruiseT = new ICheckPlayerIsInMotorcycleCruiseT();
			this.UnPackTo(checkPlayerIsInMotorcycleCruiseT);
			return checkPlayerIsInMotorcycleCruiseT;
		}

		// Token: 0x0601FDA3 RID: 130467 RVA: 0x0046C7A7 File Offset: 0x0046A9A7
		public void UnPackTo(ICheckPlayerIsInMotorcycleCruiseT _o)
		{
			_o.Type = this.Type;
			_o.IsInMotorcycleCruise = this.IsInMotorcycleCruise;
		}

		// Token: 0x0601FDA4 RID: 130468 RVA: 0x0046C7C4 File Offset: 0x0046A9C4
		public static Offset<ICheckPlayerIsInMotorcycleCruise> Pack(FlatBufferBuilder builder, ICheckPlayerIsInMotorcycleCruiseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckPlayerIsInMotorcycleCruise>);
			}
			return ICheckPlayerIsInMotorcycleCruise.CreateICheckPlayerIsInMotorcycleCruise(builder, _o.Type, _o.IsInMotorcycleCruise);
		}

		// Token: 0x0400DE72 RID: 56946
		private Table __p;
	}
}
