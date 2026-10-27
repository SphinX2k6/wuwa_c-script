using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B23 RID: 19235
	public struct ICheckSceneItemDirectionCondition : IFlatbufferObject
	{
		// Token: 0x17008B84 RID: 35716
		// (get) Token: 0x0601E416 RID: 123926 RVA: 0x0043D9F8 File Offset: 0x0043BBF8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E417 RID: 123927 RVA: 0x0043DA05 File Offset: 0x0043BC05
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E418 RID: 123928 RVA: 0x0043DA0C File Offset: 0x0043BC0C
		public static ICheckSceneItemDirectionCondition GetRootAsICheckSceneItemDirectionCondition(ByteBuffer _bb)
		{
			return ICheckSceneItemDirectionCondition.GetRootAsICheckSceneItemDirectionCondition(_bb, default(ICheckSceneItemDirectionCondition));
		}

		// Token: 0x0601E419 RID: 123929 RVA: 0x0043DA28 File Offset: 0x0043BC28
		public static ICheckSceneItemDirectionCondition GetRootAsICheckSceneItemDirectionCondition(ByteBuffer _bb, ICheckSceneItemDirectionCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E41A RID: 123930 RVA: 0x0043DA45 File Offset: 0x0043BC45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E41B RID: 123931 RVA: 0x0043DA54 File Offset: 0x0043BC54
		public ICheckSceneItemDirectionCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008B85 RID: 35717
		// (get) Token: 0x0601E41C RID: 123932 RVA: 0x0043DA64 File Offset: 0x0043BC64
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

		// Token: 0x17008B86 RID: 35718
		// (get) Token: 0x0601E41D RID: 123933 RVA: 0x0043DAA0 File Offset: 0x0043BCA0
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

		// Token: 0x0601E41E RID: 123934 RVA: 0x0043DADC File Offset: 0x0043BCDC
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601E41F RID: 123935 RVA: 0x0043DB20 File Offset: 0x0043BD20
		public IPlayerEntity TargetAsIPlayerEntity()
		{
			return this.Target<IPlayerEntity>().Value;
		}

		// Token: 0x0601E420 RID: 123936 RVA: 0x0043DB3C File Offset: 0x0043BD3C
		public ISelfEntity TargetAsISelfEntity()
		{
			return this.Target<ISelfEntity>().Value;
		}

		// Token: 0x0601E421 RID: 123937 RVA: 0x0043DB58 File Offset: 0x0043BD58
		public ITargetEntity TargetAsITargetEntity()
		{
			return this.Target<ITargetEntity>().Value;
		}

		// Token: 0x0601E422 RID: 123938 RVA: 0x0043DB74 File Offset: 0x0043BD74
		public ITriggeredEntity TargetAsITriggeredEntity()
		{
			return this.Target<ITriggeredEntity>().Value;
		}

		// Token: 0x17008B87 RID: 35719
		// (get) Token: 0x0601E423 RID: 123939 RVA: 0x0043DB90 File Offset: 0x0043BD90
		public string RotatePoint
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E424 RID: 123940 RVA: 0x0043DBC8 File Offset: 0x0043BDC8
		public Span<byte> GetRotatePointBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0601E425 RID: 123941 RVA: 0x0043DBD8 File Offset: 0x0043BDD8
		public byte[] GetRotatePointArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x17008B88 RID: 35720
		// (get) Token: 0x0601E426 RID: 123942 RVA: 0x0043DBE8 File Offset: 0x0043BDE8
		public IVectorInfo? Direction
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17008B89 RID: 35721
		// (get) Token: 0x0601E427 RID: 123943 RVA: 0x0043DC48 File Offset: 0x0043BE48
		public float AngleInterval
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E428 RID: 123944 RVA: 0x0043DC89 File Offset: 0x0043BE89
		public static Offset<ICheckSceneItemDirectionCondition> CreateICheckSceneItemDirectionCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, TTargetEntity Target_type = TTargetEntity.NONE, int TargetOffset = 0, StringOffset RotatePointOffset = default(StringOffset), Offset<IVectorInfo> DirectionOffset = default(Offset<IVectorInfo>), float AngleInterval = 0f)
		{
			builder.StartTable(6);
			ICheckSceneItemDirectionCondition.AddAngleInterval(builder, AngleInterval);
			ICheckSceneItemDirectionCondition.AddDirection(builder, DirectionOffset);
			ICheckSceneItemDirectionCondition.AddRotatePoint(builder, RotatePointOffset);
			ICheckSceneItemDirectionCondition.AddTarget(builder, TargetOffset);
			ICheckSceneItemDirectionCondition.AddTargetType(builder, Target_type);
			ICheckSceneItemDirectionCondition.AddType(builder, Type);
			return ICheckSceneItemDirectionCondition.EndICheckSceneItemDirectionCondition(builder);
		}

		// Token: 0x0601E429 RID: 123945 RVA: 0x0043DCC5 File Offset: 0x0043BEC5
		public static void StartICheckSceneItemDirectionCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601E42A RID: 123946 RVA: 0x0043DCCE File Offset: 0x0043BECE
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E42B RID: 123947 RVA: 0x0043DCD9 File Offset: 0x0043BED9
		public static void AddTargetType(FlatBufferBuilder builder, TTargetEntity targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x0601E42C RID: 123948 RVA: 0x0043DCE4 File Offset: 0x0043BEE4
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(2, targetOffset, 0);
		}

		// Token: 0x0601E42D RID: 123949 RVA: 0x0043DCEF File Offset: 0x0043BEEF
		public static void AddRotatePoint(FlatBufferBuilder builder, StringOffset rotatePointOffset)
		{
			builder.AddOffset(3, rotatePointOffset.Value, 0);
		}

		// Token: 0x0601E42E RID: 123950 RVA: 0x0043DCFF File Offset: 0x0043BEFF
		public static void AddDirection(FlatBufferBuilder builder, Offset<IVectorInfo> directionOffset)
		{
			builder.AddOffset(4, directionOffset.Value, 0);
		}

		// Token: 0x0601E42F RID: 123951 RVA: 0x0043DD0F File Offset: 0x0043BF0F
		public static void AddAngleInterval(FlatBufferBuilder builder, float angleInterval)
		{
			builder.AddFloat(5, angleInterval, 0.0);
		}

		// Token: 0x0601E430 RID: 123952 RVA: 0x0043DD22 File Offset: 0x0043BF22
		public static Offset<ICheckSceneItemDirectionCondition> EndICheckSceneItemDirectionCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckSceneItemDirectionCondition>(builder.EndTable());
		}

		// Token: 0x0601E431 RID: 123953 RVA: 0x0043DD30 File Offset: 0x0043BF30
		public ICheckSceneItemDirectionConditionT UnPack()
		{
			ICheckSceneItemDirectionConditionT checkSceneItemDirectionConditionT = new ICheckSceneItemDirectionConditionT();
			this.UnPackTo(checkSceneItemDirectionConditionT);
			return checkSceneItemDirectionConditionT;
		}

		// Token: 0x0601E432 RID: 123954 RVA: 0x0043DD4C File Offset: 0x0043BF4C
		public void UnPackTo(ICheckSceneItemDirectionConditionT _o)
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
			_o.RotatePoint = this.RotatePoint;
			_o.Direction = ((this.Direction != null) ? this.Direction.Value.UnPack() : null);
			_o.AngleInterval = this.AngleInterval;
		}

		// Token: 0x0601E433 RID: 123955 RVA: 0x0043DED0 File Offset: 0x0043C0D0
		public static Offset<ICheckSceneItemDirectionCondition> Pack(FlatBufferBuilder builder, ICheckSceneItemDirectionConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckSceneItemDirectionCondition>);
			}
			TTargetEntity target_type = (_o.Target == null) ? TTargetEntity.NONE : _o.Target.Type;
			int targetOffset = (_o.Target == null) ? 0 : TTargetEntityUnion.Pack(builder, _o.Target);
			StringOffset rotatePointOffset = (_o.RotatePoint == null) ? default(StringOffset) : builder.CreateString(_o.RotatePoint);
			Offset<IVectorInfo> directionOffset = (_o.Direction == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Direction);
			return ICheckSceneItemDirectionCondition.CreateICheckSceneItemDirectionCondition(builder, _o.Type, target_type, targetOffset, rotatePointOffset, directionOffset, _o.AngleInterval);
		}

		// Token: 0x0400D3C4 RID: 54212
		private Table __p;
	}
}
