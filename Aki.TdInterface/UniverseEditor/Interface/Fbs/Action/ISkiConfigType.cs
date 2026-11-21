using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078ED RID: 30957
	public struct ISkiConfigType : IFlatbufferObject
	{
		// Token: 0x1700E32D RID: 58157
		// (get) Token: 0x06036832 RID: 223282 RVA: 0x0074C410 File Offset: 0x0074A610
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036833 RID: 223283 RVA: 0x0074C41D File Offset: 0x0074A61D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036834 RID: 223284 RVA: 0x0074C424 File Offset: 0x0074A624
		public static ISkiConfigType GetRootAsISkiConfigType(ByteBuffer _bb)
		{
			return ISkiConfigType.GetRootAsISkiConfigType(_bb, default(ISkiConfigType));
		}

		// Token: 0x06036835 RID: 223285 RVA: 0x0074C440 File Offset: 0x0074A640
		public static ISkiConfigType GetRootAsISkiConfigType(ByteBuffer _bb, ISkiConfigType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036836 RID: 223286 RVA: 0x0074C45D File Offset: 0x0074A65D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036837 RID: 223287 RVA: 0x0074C46C File Offset: 0x0074A66C
		public ISkiConfigType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E32E RID: 58158
		// (get) Token: 0x06036838 RID: 223288 RVA: 0x0074C47C File Offset: 0x0074A67C
		public ESkiConfig Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESkiConfig.Open;
				}
				return (ESkiConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E32F RID: 58159
		// (get) Token: 0x06036839 RID: 223289 RVA: 0x0074C4B8 File Offset: 0x0074A6B8
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

		// Token: 0x0603683A RID: 223290 RVA: 0x0074C4F4 File Offset: 0x0074A6F4
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603683B RID: 223291 RVA: 0x0074C538 File Offset: 0x0074A738
		public IPlayerEntity TargetAsIPlayerEntity()
		{
			return this.Target<IPlayerEntity>().Value;
		}

		// Token: 0x0603683C RID: 223292 RVA: 0x0074C554 File Offset: 0x0074A754
		public ISelfEntity TargetAsISelfEntity()
		{
			return this.Target<ISelfEntity>().Value;
		}

		// Token: 0x0603683D RID: 223293 RVA: 0x0074C570 File Offset: 0x0074A770
		public ITargetEntity TargetAsITargetEntity()
		{
			return this.Target<ITargetEntity>().Value;
		}

		// Token: 0x0603683E RID: 223294 RVA: 0x0074C58C File Offset: 0x0074A78C
		public ITriggeredEntity TargetAsITriggeredEntity()
		{
			return this.Target<ITriggeredEntity>().Value;
		}

		// Token: 0x0603683F RID: 223295 RVA: 0x0074C5A8 File Offset: 0x0074A7A8
		public IVehicleEntity TargetAsIVehicleEntity()
		{
			return this.Target<IVehicleEntity>().Value;
		}

		// Token: 0x06036840 RID: 223296 RVA: 0x0074C5C3 File Offset: 0x0074A7C3
		public static Offset<ISkiConfigType> CreateISkiConfigType(FlatBufferBuilder builder, ESkiConfig Type = ESkiConfig.Open, TTargetEntity Target_type = TTargetEntity.NONE, int TargetOffset = 0)
		{
			builder.StartTable(3);
			ISkiConfigType.AddTarget(builder, TargetOffset);
			ISkiConfigType.AddTargetType(builder, Target_type);
			ISkiConfigType.AddType(builder, Type);
			return ISkiConfigType.EndISkiConfigType(builder);
		}

		// Token: 0x06036841 RID: 223297 RVA: 0x0074C5E7 File Offset: 0x0074A7E7
		public static void StartISkiConfigType(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06036842 RID: 223298 RVA: 0x0074C5F0 File Offset: 0x0074A7F0
		public static void AddType(FlatBufferBuilder builder, ESkiConfig type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036843 RID: 223299 RVA: 0x0074C5FB File Offset: 0x0074A7FB
		public static void AddTargetType(FlatBufferBuilder builder, TTargetEntity targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x06036844 RID: 223300 RVA: 0x0074C606 File Offset: 0x0074A806
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(2, targetOffset, 0);
		}

		// Token: 0x06036845 RID: 223301 RVA: 0x0074C611 File Offset: 0x0074A811
		public static Offset<ISkiConfigType> EndISkiConfigType(FlatBufferBuilder builder)
		{
			return new Offset<ISkiConfigType>(builder.EndTable());
		}

		// Token: 0x06036846 RID: 223302 RVA: 0x0074C620 File Offset: 0x0074A820
		public ISkiConfigTypeT UnPack()
		{
			ISkiConfigTypeT skiConfigTypeT = new ISkiConfigTypeT();
			this.UnPackTo(skiConfigTypeT);
			return skiConfigTypeT;
		}

		// Token: 0x06036847 RID: 223303 RVA: 0x0074C63C File Offset: 0x0074A83C
		public void UnPackTo(ISkiConfigTypeT _o)
		{
			_o.Type = this.Type;
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

		// Token: 0x06036848 RID: 223304 RVA: 0x0074C7A8 File Offset: 0x0074A9A8
		public static Offset<ISkiConfigType> Pack(FlatBufferBuilder builder, ISkiConfigTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISkiConfigType>);
			}
			TTargetEntity target_type = (_o.Target == null) ? TTargetEntity.NONE : _o.Target.Type;
			int targetOffset = (_o.Target == null) ? 0 : TTargetEntityUnion.Pack(builder, _o.Target);
			return ISkiConfigType.CreateISkiConfigType(builder, _o.Type, target_type, targetOffset);
		}

		// Token: 0x04012BA1 RID: 76705
		private Table __p;
	}
}
