using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AE7 RID: 19175
	public struct ICheckPlayerFaceToCondition : IFlatbufferObject
	{
		// Token: 0x17008B09 RID: 35593
		// (get) Token: 0x0601E208 RID: 123400 RVA: 0x00439CD2 File Offset: 0x00437ED2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E209 RID: 123401 RVA: 0x00439CDF File Offset: 0x00437EDF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E20A RID: 123402 RVA: 0x00439CE8 File Offset: 0x00437EE8
		public static ICheckPlayerFaceToCondition GetRootAsICheckPlayerFaceToCondition(ByteBuffer _bb)
		{
			return ICheckPlayerFaceToCondition.GetRootAsICheckPlayerFaceToCondition(_bb, default(ICheckPlayerFaceToCondition));
		}

		// Token: 0x0601E20B RID: 123403 RVA: 0x00439D04 File Offset: 0x00437F04
		public static ICheckPlayerFaceToCondition GetRootAsICheckPlayerFaceToCondition(ByteBuffer _bb, ICheckPlayerFaceToCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E20C RID: 123404 RVA: 0x00439D21 File Offset: 0x00437F21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E20D RID: 123405 RVA: 0x00439D30 File Offset: 0x00437F30
		public ICheckPlayerFaceToCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008B0A RID: 35594
		// (get) Token: 0x0601E20E RID: 123406 RVA: 0x00439D40 File Offset: 0x00437F40
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

		// Token: 0x17008B0B RID: 35595
		// (get) Token: 0x0601E20F RID: 123407 RVA: 0x00439D7C File Offset: 0x00437F7C
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

		// Token: 0x0601E210 RID: 123408 RVA: 0x00439DB8 File Offset: 0x00437FB8
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601E211 RID: 123409 RVA: 0x00439DFC File Offset: 0x00437FFC
		public IPlayerEntity TargetAsIPlayerEntity()
		{
			return this.Target<IPlayerEntity>().Value;
		}

		// Token: 0x0601E212 RID: 123410 RVA: 0x00439E18 File Offset: 0x00438018
		public ISelfEntity TargetAsISelfEntity()
		{
			return this.Target<ISelfEntity>().Value;
		}

		// Token: 0x0601E213 RID: 123411 RVA: 0x00439E34 File Offset: 0x00438034
		public ITargetEntity TargetAsITargetEntity()
		{
			return this.Target<ITargetEntity>().Value;
		}

		// Token: 0x0601E214 RID: 123412 RVA: 0x00439E50 File Offset: 0x00438050
		public ITriggeredEntity TargetAsITriggeredEntity()
		{
			return this.Target<ITriggeredEntity>().Value;
		}

		// Token: 0x17008B0C RID: 35596
		// (get) Token: 0x0601E215 RID: 123413 RVA: 0x00439E6C File Offset: 0x0043806C
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

		// Token: 0x0601E216 RID: 123414 RVA: 0x00439EAD File Offset: 0x004380AD
		public static Offset<ICheckPlayerFaceToCondition> CreateICheckPlayerFaceToCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, TTargetEntity Target_type = TTargetEntity.NONE, int TargetOffset = 0, float AngleInterval = 0f)
		{
			builder.StartTable(4);
			ICheckPlayerFaceToCondition.AddAngleInterval(builder, AngleInterval);
			ICheckPlayerFaceToCondition.AddTarget(builder, TargetOffset);
			ICheckPlayerFaceToCondition.AddTargetType(builder, Target_type);
			ICheckPlayerFaceToCondition.AddType(builder, Type);
			return ICheckPlayerFaceToCondition.EndICheckPlayerFaceToCondition(builder);
		}

		// Token: 0x0601E217 RID: 123415 RVA: 0x00439ED9 File Offset: 0x004380D9
		public static void StartICheckPlayerFaceToCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601E218 RID: 123416 RVA: 0x00439EE2 File Offset: 0x004380E2
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E219 RID: 123417 RVA: 0x00439EED File Offset: 0x004380ED
		public static void AddTargetType(FlatBufferBuilder builder, TTargetEntity targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x0601E21A RID: 123418 RVA: 0x00439EF8 File Offset: 0x004380F8
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(2, targetOffset, 0);
		}

		// Token: 0x0601E21B RID: 123419 RVA: 0x00439F03 File Offset: 0x00438103
		public static void AddAngleInterval(FlatBufferBuilder builder, float angleInterval)
		{
			builder.AddFloat(3, angleInterval, 0.0);
		}

		// Token: 0x0601E21C RID: 123420 RVA: 0x00439F16 File Offset: 0x00438116
		public static Offset<ICheckPlayerFaceToCondition> EndICheckPlayerFaceToCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckPlayerFaceToCondition>(builder.EndTable());
		}

		// Token: 0x0601E21D RID: 123421 RVA: 0x00439F24 File Offset: 0x00438124
		public ICheckPlayerFaceToConditionT UnPack()
		{
			ICheckPlayerFaceToConditionT checkPlayerFaceToConditionT = new ICheckPlayerFaceToConditionT();
			this.UnPackTo(checkPlayerFaceToConditionT);
			return checkPlayerFaceToConditionT;
		}

		// Token: 0x0601E21E RID: 123422 RVA: 0x00439F40 File Offset: 0x00438140
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

		// Token: 0x0601E21F RID: 123423 RVA: 0x0043A088 File Offset: 0x00438288
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

		// Token: 0x0400D377 RID: 54135
		private Table __p;
	}
}
