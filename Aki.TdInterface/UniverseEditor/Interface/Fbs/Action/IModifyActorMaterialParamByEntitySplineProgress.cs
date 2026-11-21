using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071CE RID: 29134
	public struct IModifyActorMaterialParamByEntitySplineProgress : IFlatbufferObject
	{
		// Token: 0x1700D552 RID: 54610
		// (get) Token: 0x06032AD2 RID: 207570 RVA: 0x006D89FB File Offset: 0x006D6BFB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032AD3 RID: 207571 RVA: 0x006D8A08 File Offset: 0x006D6C08
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032AD4 RID: 207572 RVA: 0x006D8A10 File Offset: 0x006D6C10
		public static IModifyActorMaterialParamByEntitySplineProgress GetRootAsIModifyActorMaterialParamByEntitySplineProgress(ByteBuffer _bb)
		{
			return IModifyActorMaterialParamByEntitySplineProgress.GetRootAsIModifyActorMaterialParamByEntitySplineProgress(_bb, default(IModifyActorMaterialParamByEntitySplineProgress));
		}

		// Token: 0x06032AD5 RID: 207573 RVA: 0x006D8A2C File Offset: 0x006D6C2C
		public static IModifyActorMaterialParamByEntitySplineProgress GetRootAsIModifyActorMaterialParamByEntitySplineProgress(ByteBuffer _bb, IModifyActorMaterialParamByEntitySplineProgress obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032AD6 RID: 207574 RVA: 0x006D8A49 File Offset: 0x006D6C49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032AD7 RID: 207575 RVA: 0x006D8A58 File Offset: 0x006D6C58
		public IModifyActorMaterialParamByEntitySplineProgress __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D553 RID: 54611
		// (get) Token: 0x06032AD8 RID: 207576 RVA: 0x006D8A68 File Offset: 0x006D6C68
		public ECommonTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECommonTargetType.Player;
				}
				return (ECommonTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D554 RID: 54612
		// (get) Token: 0x06032AD9 RID: 207577 RVA: 0x006D8AA4 File Offset: 0x006D6CA4
		public int Id
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032ADA RID: 207578 RVA: 0x006D8AE0 File Offset: 0x006D6CE0
		public static Offset<IModifyActorMaterialParamByEntitySplineProgress> CreateIModifyActorMaterialParamByEntitySplineProgress(FlatBufferBuilder builder, ECommonTargetType Type = ECommonTargetType.Player, int Id = 0)
		{
			builder.StartTable(2);
			IModifyActorMaterialParamByEntitySplineProgress.AddId(builder, Id);
			IModifyActorMaterialParamByEntitySplineProgress.AddType(builder, Type);
			return IModifyActorMaterialParamByEntitySplineProgress.EndIModifyActorMaterialParamByEntitySplineProgress(builder);
		}

		// Token: 0x06032ADB RID: 207579 RVA: 0x006D8AFD File Offset: 0x006D6CFD
		public static void StartIModifyActorMaterialParamByEntitySplineProgress(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06032ADC RID: 207580 RVA: 0x006D8B06 File Offset: 0x006D6D06
		public static void AddType(FlatBufferBuilder builder, ECommonTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032ADD RID: 207581 RVA: 0x006D8B11 File Offset: 0x006D6D11
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06032ADE RID: 207582 RVA: 0x006D8B1C File Offset: 0x006D6D1C
		public static Offset<IModifyActorMaterialParamByEntitySplineProgress> EndIModifyActorMaterialParamByEntitySplineProgress(FlatBufferBuilder builder)
		{
			return new Offset<IModifyActorMaterialParamByEntitySplineProgress>(builder.EndTable());
		}

		// Token: 0x06032ADF RID: 207583 RVA: 0x006D8B2C File Offset: 0x006D6D2C
		public IModifyActorMaterialParamByEntitySplineProgressT UnPack()
		{
			IModifyActorMaterialParamByEntitySplineProgressT modifyActorMaterialParamByEntitySplineProgressT = new IModifyActorMaterialParamByEntitySplineProgressT();
			this.UnPackTo(modifyActorMaterialParamByEntitySplineProgressT);
			return modifyActorMaterialParamByEntitySplineProgressT;
		}

		// Token: 0x06032AE0 RID: 207584 RVA: 0x006D8B47 File Offset: 0x006D6D47
		public void UnPackTo(IModifyActorMaterialParamByEntitySplineProgressT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x06032AE1 RID: 207585 RVA: 0x006D8B64 File Offset: 0x006D6D64
		public static Offset<IModifyActorMaterialParamByEntitySplineProgress> Pack(FlatBufferBuilder builder, IModifyActorMaterialParamByEntitySplineProgressT _o)
		{
			if (_o == null)
			{
				return default(Offset<IModifyActorMaterialParamByEntitySplineProgress>);
			}
			return IModifyActorMaterialParamByEntitySplineProgress.CreateIModifyActorMaterialParamByEntitySplineProgress(builder, _o.Type, _o.Id);
		}

		// Token: 0x040121E0 RID: 74208
		private Table __p;
	}
}
