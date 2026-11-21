using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FBC RID: 20412
	public struct ICheckPlayerFaceToCondition : IFlatbufferObject
	{
		// Token: 0x17009200 RID: 37376
		// (get) Token: 0x0601FD1D RID: 130333 RVA: 0x0046B97E File Offset: 0x00469B7E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FD1E RID: 130334 RVA: 0x0046B98B File Offset: 0x00469B8B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FD1F RID: 130335 RVA: 0x0046B994 File Offset: 0x00469B94
		public static ICheckPlayerFaceToCondition GetRootAsICheckPlayerFaceToCondition(ByteBuffer _bb)
		{
			return ICheckPlayerFaceToCondition.GetRootAsICheckPlayerFaceToCondition(_bb, default(ICheckPlayerFaceToCondition));
		}

		// Token: 0x0601FD20 RID: 130336 RVA: 0x0046B9B0 File Offset: 0x00469BB0
		public static ICheckPlayerFaceToCondition GetRootAsICheckPlayerFaceToCondition(ByteBuffer _bb, ICheckPlayerFaceToCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FD21 RID: 130337 RVA: 0x0046B9CD File Offset: 0x00469BCD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FD22 RID: 130338 RVA: 0x0046B9DC File Offset: 0x00469BDC
		public ICheckPlayerFaceToCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009201 RID: 37377
		// (get) Token: 0x0601FD23 RID: 130339 RVA: 0x0046B9EC File Offset: 0x00469BEC
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

		// Token: 0x17009202 RID: 37378
		// (get) Token: 0x0601FD24 RID: 130340 RVA: 0x0046BA28 File Offset: 0x00469C28
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

		// Token: 0x0601FD25 RID: 130341 RVA: 0x0046BA64 File Offset: 0x00469C64
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601FD26 RID: 130342 RVA: 0x0046BAA8 File Offset: 0x00469CA8
		public IPlayerEntity TargetAsIPlayerEntity()
		{
			return this.Target<IPlayerEntity>().Value;
		}

		// Token: 0x0601FD27 RID: 130343 RVA: 0x0046BAC4 File Offset: 0x00469CC4
		public ISelfEntity TargetAsISelfEntity()
		{
			return this.Target<ISelfEntity>().Value;
		}

		// Token: 0x0601FD28 RID: 130344 RVA: 0x0046BAE0 File Offset: 0x00469CE0
		public ITargetEntity TargetAsITargetEntity()
		{
			return this.Target<ITargetEntity>().Value;
		}

		// Token: 0x0601FD29 RID: 130345 RVA: 0x0046BAFC File Offset: 0x00469CFC
		public ITriggeredEntity TargetAsITriggeredEntity()
		{
			return this.Target<ITriggeredEntity>().Value;
		}

		// Token: 0x17009203 RID: 37379
		// (get) Token: 0x0601FD2A RID: 130346 RVA: 0x0046BB18 File Offset: 0x00469D18
		public float AngleInterval
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601FD2B RID: 130347 RVA: 0x0046BB59 File Offset: 0x00469D59
		public static Offset<ICheckPlayerFaceToCondition> CreateICheckPlayerFaceToCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, TTargetEntity Target_type = TTargetEntity.NONE, int TargetOffset = 0, float AngleInterval = 0f)
		{
			builder.StartTable(4);
			ICheckPlayerFaceToCondition.AddAngleInterval(builder, AngleInterval);
			ICheckPlayerFaceToCondition.AddTarget(builder, TargetOffset);
			ICheckPlayerFaceToCondition.AddTargetType(builder, Target_type);
			ICheckPlayerFaceToCondition.AddType(builder, Type);
			return ICheckPlayerFaceToCondition.EndICheckPlayerFaceToCondition(builder);
		}

		// Token: 0x0601FD2C RID: 130348 RVA: 0x0046BB85 File Offset: 0x00469D85
		public static void StartICheckPlayerFaceToCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601FD2D RID: 130349 RVA: 0x0046BB8E File Offset: 0x00469D8E
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FD2E RID: 130350 RVA: 0x0046BB99 File Offset: 0x00469D99
		public static void AddTargetType(FlatBufferBuilder builder, TTargetEntity targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x0601FD2F RID: 130351 RVA: 0x0046BBA4 File Offset: 0x00469DA4
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(2, targetOffset, 0);
		}

		// Token: 0x0601FD30 RID: 130352 RVA: 0x0046BBAF File Offset: 0x00469DAF
		public static void AddAngleInterval(FlatBufferBuilder builder, float angleInterval)
		{
			builder.AddFloat(3, angleInterval, 0.0);
		}

		// Token: 0x0601FD31 RID: 130353 RVA: 0x0046BBC2 File Offset: 0x00469DC2
		public static Offset<ICheckPlayerFaceToCondition> EndICheckPlayerFaceToCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckPlayerFaceToCondition>(builder.EndTable());
		}

		// Token: 0x0601FD32 RID: 130354 RVA: 0x0046BBD0 File Offset: 0x00469DD0
		public ICheckPlayerFaceToConditionT UnPack()
		{
			ICheckPlayerFaceToConditionT checkPlayerFaceToConditionT = new ICheckPlayerFaceToConditionT();
			this.UnPackTo(checkPlayerFaceToConditionT);
			return checkPlayerFaceToConditionT;
		}

		// Token: 0x0601FD33 RID: 130355 RVA: 0x0046BBEC File Offset: 0x00469DEC
		public void UnPackTo(ICheckPlayerFaceToConditionT _o)
		{
			_o.Type = this.Type;
			_o.Target = new TTargetEntityUnion();
			_o.Target.Type = this.TargetType;
			switch (this.TargetType)
			{
			case TTargetEntity.IPlayerEntity:
				_o.Target.Value = ((this.Target<IPlayerEntity>() != null) ? this.Target<IPlayerEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ISelfEntity:
				_o.Target.Value = ((this.Target<ISelfEntity>() != null) ? this.Target<ISelfEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ITargetEntity:
				_o.Target.Value = ((this.Target<ITargetEntity>() != null) ? this.Target<ITargetEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ITriggeredEntity:
				_o.Target.Value = ((this.Target<ITriggeredEntity>() != null) ? this.Target<ITriggeredEntity>().Value.UnPack() : null);
				break;
			}
			_o.AngleInterval = this.AngleInterval;
		}

		// Token: 0x0601FD34 RID: 130356 RVA: 0x0046BD34 File Offset: 0x00469F34
		public static Offset<ICheckPlayerFaceToCondition> Pack(FlatBufferBuilder builder, ICheckPlayerFaceToConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckPlayerFaceToCondition>);
			}
			TTargetEntity target_type = (_o.Target == null) ? TTargetEntity.NONE : _o.Target.Type;
			int targetOffset = (_o.Target == null) ? 0 : TTargetEntityUnion.Pack(builder, _o.Target);
			return ICheckPlayerFaceToCondition.CreateICheckPlayerFaceToCondition(builder, _o.Type, target_type, targetOffset, _o.AngleInterval);
		}

		// Token: 0x0400DE62 RID: 56930
		private Table __p;
	}
}
