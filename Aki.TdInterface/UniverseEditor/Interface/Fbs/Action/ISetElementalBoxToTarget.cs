using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077A3 RID: 30627
	public struct ISetElementalBoxToTarget : IFlatbufferObject
	{
		// Token: 0x1700E06B RID: 57451
		// (get) Token: 0x06035C41 RID: 220225 RVA: 0x0073403B File Offset: 0x0073223B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035C42 RID: 220226 RVA: 0x00734048 File Offset: 0x00732248
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035C43 RID: 220227 RVA: 0x00734050 File Offset: 0x00732250
		public static ISetElementalBoxToTarget GetRootAsISetElementalBoxToTarget(ByteBuffer _bb)
		{
			return ISetElementalBoxToTarget.GetRootAsISetElementalBoxToTarget(_bb, default(ISetElementalBoxToTarget));
		}

		// Token: 0x06035C44 RID: 220228 RVA: 0x0073406C File Offset: 0x0073226C
		public static ISetElementalBoxToTarget GetRootAsISetElementalBoxToTarget(ByteBuffer _bb, ISetElementalBoxToTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035C45 RID: 220229 RVA: 0x00734089 File Offset: 0x00732289
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035C46 RID: 220230 RVA: 0x00734098 File Offset: 0x00732298
		public ISetElementalBoxToTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E06C RID: 57452
		// (get) Token: 0x06035C47 RID: 220231 RVA: 0x007340A8 File Offset: 0x007322A8
		public int ElementalBoxId
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

		// Token: 0x1700E06D RID: 57453
		// (get) Token: 0x06035C48 RID: 220232 RVA: 0x007340E4 File Offset: 0x007322E4
		public TTargetEntity TargetType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TTargetEntity.NONE;
				}
				return (TTargetEntity)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035C49 RID: 220233 RVA: 0x00734120 File Offset: 0x00732320
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06035C4A RID: 220234 RVA: 0x00734164 File Offset: 0x00732364
		public IPlayerEntity TargetAsIPlayerEntity()
		{
			return this.Target<IPlayerEntity>().Value;
		}

		// Token: 0x06035C4B RID: 220235 RVA: 0x00734180 File Offset: 0x00732380
		public ISelfEntity TargetAsISelfEntity()
		{
			return this.Target<ISelfEntity>().Value;
		}

		// Token: 0x06035C4C RID: 220236 RVA: 0x0073419C File Offset: 0x0073239C
		public ITargetEntity TargetAsITargetEntity()
		{
			return this.Target<ITargetEntity>().Value;
		}

		// Token: 0x06035C4D RID: 220237 RVA: 0x007341B8 File Offset: 0x007323B8
		public ITriggeredEntity TargetAsITriggeredEntity()
		{
			return this.Target<ITriggeredEntity>().Value;
		}

		// Token: 0x06035C4E RID: 220238 RVA: 0x007341D4 File Offset: 0x007323D4
		public IVehicleEntity TargetAsIVehicleEntity()
		{
			return this.Target<IVehicleEntity>().Value;
		}

		// Token: 0x06035C4F RID: 220239 RVA: 0x007341EF File Offset: 0x007323EF
		public static Offset<ISetElementalBoxToTarget> CreateISetElementalBoxToTarget(FlatBufferBuilder builder, int ElementalBoxId = 0, TTargetEntity Target_type = TTargetEntity.NONE, int TargetOffset = 0)
		{
			builder.StartTable(3);
			ISetElementalBoxToTarget.AddTarget(builder, TargetOffset);
			ISetElementalBoxToTarget.AddElementalBoxId(builder, ElementalBoxId);
			ISetElementalBoxToTarget.AddTargetType(builder, Target_type);
			return ISetElementalBoxToTarget.EndISetElementalBoxToTarget(builder);
		}

		// Token: 0x06035C50 RID: 220240 RVA: 0x00734213 File Offset: 0x00732413
		public static void StartISetElementalBoxToTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06035C51 RID: 220241 RVA: 0x0073421C File Offset: 0x0073241C
		public static void AddElementalBoxId(FlatBufferBuilder builder, int elementalBoxId)
		{
			builder.AddInt(0, elementalBoxId, 0);
		}

		// Token: 0x06035C52 RID: 220242 RVA: 0x00734227 File Offset: 0x00732427
		public static void AddTargetType(FlatBufferBuilder builder, TTargetEntity targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x06035C53 RID: 220243 RVA: 0x00734232 File Offset: 0x00732432
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(2, targetOffset, 0);
		}

		// Token: 0x06035C54 RID: 220244 RVA: 0x0073423D File Offset: 0x0073243D
		public static Offset<ISetElementalBoxToTarget> EndISetElementalBoxToTarget(FlatBufferBuilder builder)
		{
			return new Offset<ISetElementalBoxToTarget>(builder.EndTable());
		}

		// Token: 0x06035C55 RID: 220245 RVA: 0x0073424C File Offset: 0x0073244C
		public ISetElementalBoxToTargetT UnPack()
		{
			ISetElementalBoxToTargetT setElementalBoxToTargetT = new ISetElementalBoxToTargetT();
			this.UnPackTo(setElementalBoxToTargetT);
			return setElementalBoxToTargetT;
		}

		// Token: 0x06035C56 RID: 220246 RVA: 0x00734268 File Offset: 0x00732468
		public void UnPackTo(ISetElementalBoxToTargetT _o)
		{
			_o.ElementalBoxId = this.ElementalBoxId;
			_o.Target = new TTargetEntityUnion();
			_o.Target.Type = this.TargetType;
			switch (this.TargetType)
			{
			case TTargetEntity.IPlayerEntity:
				_o.Target.Value = ((this.Target<IPlayerEntity>() != null) ? this.Target<IPlayerEntity>().Value.UnPack() : null);
				return;
			case TTargetEntity.ISelfEntity:
				_o.Target.Value = ((this.Target<ISelfEntity>() != null) ? this.Target<ISelfEntity>().Value.UnPack() : null);
				return;
			case TTargetEntity.ITargetEntity:
				_o.Target.Value = ((this.Target<ITargetEntity>() != null) ? this.Target<ITargetEntity>().Value.UnPack() : null);
				return;
			case TTargetEntity.ITriggeredEntity:
				_o.Target.Value = ((this.Target<ITriggeredEntity>() != null) ? this.Target<ITriggeredEntity>().Value.UnPack() : null);
				return;
			case TTargetEntity.IVehicleEntity:
				_o.Target.Value = ((this.Target<IVehicleEntity>() != null) ? this.Target<IVehicleEntity>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06035C57 RID: 220247 RVA: 0x007343D4 File Offset: 0x007325D4
		public static Offset<ISetElementalBoxToTarget> Pack(FlatBufferBuilder builder, ISetElementalBoxToTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetElementalBoxToTarget>);
			}
			TTargetEntity target_type = (_o.Target == null) ? TTargetEntity.NONE : _o.Target.Type;
			int targetOffset = (_o.Target == null) ? 0 : TTargetEntityUnion.Pack(builder, _o.Target);
			return ISetElementalBoxToTarget.CreateISetElementalBoxToTarget(builder, _o.ElementalBoxId, target_type, targetOffset);
		}

		// Token: 0x040129CD RID: 76237
		private Table __p;
	}
}
