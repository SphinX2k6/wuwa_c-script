using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004043 RID: 16451
	public struct IRelativeTipsActorTransformResult : IFlatbufferObject
	{
		// Token: 0x17006FCD RID: 28621
		// (get) Token: 0x0601697B RID: 92539 RVA: 0x0033B486 File Offset: 0x00339686
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601697C RID: 92540 RVA: 0x0033B493 File Offset: 0x00339693
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601697D RID: 92541 RVA: 0x0033B49C File Offset: 0x0033969C
		public static IRelativeTipsActorTransformResult GetRootAsIRelativeTipsActorTransformResult(ByteBuffer _bb)
		{
			return IRelativeTipsActorTransformResult.GetRootAsIRelativeTipsActorTransformResult(_bb, default(IRelativeTipsActorTransformResult));
		}

		// Token: 0x0601697E RID: 92542 RVA: 0x0033B4B8 File Offset: 0x003396B8
		public static IRelativeTipsActorTransformResult GetRootAsIRelativeTipsActorTransformResult(ByteBuffer _bb, IRelativeTipsActorTransformResult obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601697F RID: 92543 RVA: 0x0033B4D5 File Offset: 0x003396D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016980 RID: 92544 RVA: 0x0033B4E4 File Offset: 0x003396E4
		public IRelativeTipsActorTransformResult __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006FCE RID: 28622
		// (get) Token: 0x06016981 RID: 92545 RVA: 0x0033B4F4 File Offset: 0x003396F4
		public bool IsSuccess
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006FCF RID: 28623
		// (get) Token: 0x06016982 RID: 92546 RVA: 0x0033B534 File Offset: 0x00339734
		public string Reason
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06016983 RID: 92547 RVA: 0x0033B56B File Offset: 0x0033976B
		public Span<byte> GetReasonBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06016984 RID: 92548 RVA: 0x0033B57A File Offset: 0x0033977A
		public byte[] GetReasonArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17006FD0 RID: 28624
		// (get) Token: 0x06016985 RID: 92549 RVA: 0x0033B588 File Offset: 0x00339788
		public ETipsActorTransformType Type
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ETipsActorTransformType.Absolute;
				}
				return (ETipsActorTransformType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006FD1 RID: 28625
		// (get) Token: 0x06016986 RID: 92550 RVA: 0x0033B5C4 File Offset: 0x003397C4
		public IShapeTransform? TransformWorld
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IShapeTransform?(default(IShapeTransform).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17006FD2 RID: 28626
		// (get) Token: 0x06016987 RID: 92551 RVA: 0x0033B624 File Offset: 0x00339824
		public IHollowTipsActorComponent? HollowTipsActorComponent
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IHollowTipsActorComponent?(default(IHollowTipsActorComponent).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17006FD3 RID: 28627
		// (get) Token: 0x06016988 RID: 92552 RVA: 0x0033B684 File Offset: 0x00339884
		public IShapeTransform? TransformEntity
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new IShapeTransform?(default(IShapeTransform).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06016989 RID: 92553 RVA: 0x0033B6E2 File Offset: 0x003398E2
		public static Offset<IRelativeTipsActorTransformResult> CreateIRelativeTipsActorTransformResult(FlatBufferBuilder builder, bool IsSuccess = false, StringOffset ReasonOffset = default(StringOffset), ETipsActorTransformType Type = ETipsActorTransformType.Absolute, Offset<IShapeTransform> TransformWorldOffset = default(Offset<IShapeTransform>), Offset<IHollowTipsActorComponent> HollowTipsActorComponentOffset = default(Offset<IHollowTipsActorComponent>), Offset<IShapeTransform> TransformEntityOffset = default(Offset<IShapeTransform>))
		{
			builder.StartTable(6);
			IRelativeTipsActorTransformResult.AddTransformEntity(builder, TransformEntityOffset);
			IRelativeTipsActorTransformResult.AddHollowTipsActorComponent(builder, HollowTipsActorComponentOffset);
			IRelativeTipsActorTransformResult.AddTransformWorld(builder, TransformWorldOffset);
			IRelativeTipsActorTransformResult.AddReason(builder, ReasonOffset);
			IRelativeTipsActorTransformResult.AddType(builder, Type);
			IRelativeTipsActorTransformResult.AddIsSuccess(builder, IsSuccess);
			return IRelativeTipsActorTransformResult.EndIRelativeTipsActorTransformResult(builder);
		}

		// Token: 0x0601698A RID: 92554 RVA: 0x0033B71E File Offset: 0x0033991E
		public static void StartIRelativeTipsActorTransformResult(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601698B RID: 92555 RVA: 0x0033B727 File Offset: 0x00339927
		public static void AddIsSuccess(FlatBufferBuilder builder, bool isSuccess)
		{
			builder.AddBool(0, isSuccess, false);
		}

		// Token: 0x0601698C RID: 92556 RVA: 0x0033B732 File Offset: 0x00339932
		public static void AddReason(FlatBufferBuilder builder, StringOffset reasonOffset)
		{
			builder.AddOffset(1, reasonOffset.Value, 0);
		}

		// Token: 0x0601698D RID: 92557 RVA: 0x0033B742 File Offset: 0x00339942
		public static void AddType(FlatBufferBuilder builder, ETipsActorTransformType type)
		{
			builder.AddByte(2, (byte)type, 0);
		}

		// Token: 0x0601698E RID: 92558 RVA: 0x0033B74D File Offset: 0x0033994D
		public static void AddTransformWorld(FlatBufferBuilder builder, Offset<IShapeTransform> transformWorldOffset)
		{
			builder.AddOffset(3, transformWorldOffset.Value, 0);
		}

		// Token: 0x0601698F RID: 92559 RVA: 0x0033B75D File Offset: 0x0033995D
		public static void AddHollowTipsActorComponent(FlatBufferBuilder builder, Offset<IHollowTipsActorComponent> hollowTipsActorComponentOffset)
		{
			builder.AddOffset(4, hollowTipsActorComponentOffset.Value, 0);
		}

		// Token: 0x06016990 RID: 92560 RVA: 0x0033B76D File Offset: 0x0033996D
		public static void AddTransformEntity(FlatBufferBuilder builder, Offset<IShapeTransform> transformEntityOffset)
		{
			builder.AddOffset(5, transformEntityOffset.Value, 0);
		}

		// Token: 0x06016991 RID: 92561 RVA: 0x0033B77D File Offset: 0x0033997D
		public static Offset<IRelativeTipsActorTransformResult> EndIRelativeTipsActorTransformResult(FlatBufferBuilder builder)
		{
			return new Offset<IRelativeTipsActorTransformResult>(builder.EndTable());
		}

		// Token: 0x06016992 RID: 92562 RVA: 0x0033B78C File Offset: 0x0033998C
		public IRelativeTipsActorTransformResultT UnPack()
		{
			IRelativeTipsActorTransformResultT relativeTipsActorTransformResultT = new IRelativeTipsActorTransformResultT();
			this.UnPackTo(relativeTipsActorTransformResultT);
			return relativeTipsActorTransformResultT;
		}

		// Token: 0x06016993 RID: 92563 RVA: 0x0033B7A8 File Offset: 0x003399A8
		public void UnPackTo(IRelativeTipsActorTransformResultT _o)
		{
			_o.IsSuccess = this.IsSuccess;
			_o.Reason = this.Reason;
			_o.Type = this.Type;
			_o.TransformWorld = ((this.TransformWorld != null) ? this.TransformWorld.Value.UnPack() : null);
			_o.HollowTipsActorComponent = ((this.HollowTipsActorComponent != null) ? this.HollowTipsActorComponent.Value.UnPack() : null);
			_o.TransformEntity = ((this.TransformEntity != null) ? this.TransformEntity.Value.UnPack() : null);
		}

		// Token: 0x06016994 RID: 92564 RVA: 0x0033B868 File Offset: 0x00339A68
		public static Offset<IRelativeTipsActorTransformResult> Pack(FlatBufferBuilder builder, IRelativeTipsActorTransformResultT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRelativeTipsActorTransformResult>);
			}
			StringOffset reasonOffset = (_o.Reason == null) ? default(StringOffset) : builder.CreateString(_o.Reason);
			Offset<IShapeTransform> transformWorldOffset = (_o.TransformWorld == null) ? default(Offset<IShapeTransform>) : IShapeTransform.Pack(builder, _o.TransformWorld);
			Offset<IHollowTipsActorComponent> hollowTipsActorComponentOffset = (_o.HollowTipsActorComponent == null) ? default(Offset<IHollowTipsActorComponent>) : IHollowTipsActorComponent.Pack(builder, _o.HollowTipsActorComponent);
			Offset<IShapeTransform> transformEntityOffset = (_o.TransformEntity == null) ? default(Offset<IShapeTransform>) : IShapeTransform.Pack(builder, _o.TransformEntity);
			return IRelativeTipsActorTransformResult.CreateIRelativeTipsActorTransformResult(builder, _o.IsSuccess, reasonOffset, _o.Type, transformWorldOffset, hollowTipsActorComponentOffset, transformEntityOffset);
		}

		// Token: 0x0400BBC1 RID: 48065
		private Table __p;
	}
}
