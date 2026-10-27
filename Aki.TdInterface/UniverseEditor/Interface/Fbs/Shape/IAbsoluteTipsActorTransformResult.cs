using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003BE0 RID: 15328
	public struct IAbsoluteTipsActorTransformResult : IFlatbufferObject
	{
		// Token: 0x17006922 RID: 26914
		// (get) Token: 0x06015113 RID: 86291 RVA: 0x0030DB56 File Offset: 0x0030BD56
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015114 RID: 86292 RVA: 0x0030DB63 File Offset: 0x0030BD63
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015115 RID: 86293 RVA: 0x0030DB6C File Offset: 0x0030BD6C
		public static IAbsoluteTipsActorTransformResult GetRootAsIAbsoluteTipsActorTransformResult(ByteBuffer _bb)
		{
			return IAbsoluteTipsActorTransformResult.GetRootAsIAbsoluteTipsActorTransformResult(_bb, default(IAbsoluteTipsActorTransformResult));
		}

		// Token: 0x06015116 RID: 86294 RVA: 0x0030DB88 File Offset: 0x0030BD88
		public static IAbsoluteTipsActorTransformResult GetRootAsIAbsoluteTipsActorTransformResult(ByteBuffer _bb, IAbsoluteTipsActorTransformResult obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015117 RID: 86295 RVA: 0x0030DBA5 File Offset: 0x0030BDA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015118 RID: 86296 RVA: 0x0030DBB4 File Offset: 0x0030BDB4
		public IAbsoluteTipsActorTransformResult __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006923 RID: 26915
		// (get) Token: 0x06015119 RID: 86297 RVA: 0x0030DBC4 File Offset: 0x0030BDC4
		public bool IsSuccess
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006924 RID: 26916
		// (get) Token: 0x0601511A RID: 86298 RVA: 0x0030DC04 File Offset: 0x0030BE04
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

		// Token: 0x0601511B RID: 86299 RVA: 0x0030DC3B File Offset: 0x0030BE3B
		public Span<byte> GetReasonBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601511C RID: 86300 RVA: 0x0030DC4A File Offset: 0x0030BE4A
		public byte[] GetReasonArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17006925 RID: 26917
		// (get) Token: 0x0601511D RID: 86301 RVA: 0x0030DC58 File Offset: 0x0030BE58
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

		// Token: 0x17006926 RID: 26918
		// (get) Token: 0x0601511E RID: 86302 RVA: 0x0030DC94 File Offset: 0x0030BE94
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

		// Token: 0x17006927 RID: 26919
		// (get) Token: 0x0601511F RID: 86303 RVA: 0x0030DCF4 File Offset: 0x0030BEF4
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

		// Token: 0x06015120 RID: 86304 RVA: 0x0030DD52 File Offset: 0x0030BF52
		public static Offset<IAbsoluteTipsActorTransformResult> CreateIAbsoluteTipsActorTransformResult(FlatBufferBuilder builder, bool IsSuccess = false, StringOffset ReasonOffset = default(StringOffset), ETipsActorTransformType Type = ETipsActorTransformType.Absolute, Offset<IShapeTransform> TransformWorldOffset = default(Offset<IShapeTransform>), Offset<IHollowTipsActorComponent> HollowTipsActorComponentOffset = default(Offset<IHollowTipsActorComponent>))
		{
			builder.StartTable(5);
			IAbsoluteTipsActorTransformResult.AddHollowTipsActorComponent(builder, HollowTipsActorComponentOffset);
			IAbsoluteTipsActorTransformResult.AddTransformWorld(builder, TransformWorldOffset);
			IAbsoluteTipsActorTransformResult.AddReason(builder, ReasonOffset);
			IAbsoluteTipsActorTransformResult.AddType(builder, Type);
			IAbsoluteTipsActorTransformResult.AddIsSuccess(builder, IsSuccess);
			return IAbsoluteTipsActorTransformResult.EndIAbsoluteTipsActorTransformResult(builder);
		}

		// Token: 0x06015121 RID: 86305 RVA: 0x0030DD86 File Offset: 0x0030BF86
		public static void StartIAbsoluteTipsActorTransformResult(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06015122 RID: 86306 RVA: 0x0030DD8F File Offset: 0x0030BF8F
		public static void AddIsSuccess(FlatBufferBuilder builder, bool isSuccess)
		{
			builder.AddBool(0, isSuccess, false);
		}

		// Token: 0x06015123 RID: 86307 RVA: 0x0030DD9A File Offset: 0x0030BF9A
		public static void AddReason(FlatBufferBuilder builder, StringOffset reasonOffset)
		{
			builder.AddOffset(1, reasonOffset.Value, 0);
		}

		// Token: 0x06015124 RID: 86308 RVA: 0x0030DDAA File Offset: 0x0030BFAA
		public static void AddType(FlatBufferBuilder builder, ETipsActorTransformType type)
		{
			builder.AddByte(2, (byte)type, 0);
		}

		// Token: 0x06015125 RID: 86309 RVA: 0x0030DDB5 File Offset: 0x0030BFB5
		public static void AddTransformWorld(FlatBufferBuilder builder, Offset<IShapeTransform> transformWorldOffset)
		{
			builder.AddOffset(3, transformWorldOffset.Value, 0);
		}

		// Token: 0x06015126 RID: 86310 RVA: 0x0030DDC5 File Offset: 0x0030BFC5
		public static void AddHollowTipsActorComponent(FlatBufferBuilder builder, Offset<IHollowTipsActorComponent> hollowTipsActorComponentOffset)
		{
			builder.AddOffset(4, hollowTipsActorComponentOffset.Value, 0);
		}

		// Token: 0x06015127 RID: 86311 RVA: 0x0030DDD5 File Offset: 0x0030BFD5
		public static Offset<IAbsoluteTipsActorTransformResult> EndIAbsoluteTipsActorTransformResult(FlatBufferBuilder builder)
		{
			return new Offset<IAbsoluteTipsActorTransformResult>(builder.EndTable());
		}

		// Token: 0x06015128 RID: 86312 RVA: 0x0030DDE4 File Offset: 0x0030BFE4
		public IAbsoluteTipsActorTransformResultT UnPack()
		{
			IAbsoluteTipsActorTransformResultT absoluteTipsActorTransformResultT = new IAbsoluteTipsActorTransformResultT();
			this.UnPackTo(absoluteTipsActorTransformResultT);
			return absoluteTipsActorTransformResultT;
		}

		// Token: 0x06015129 RID: 86313 RVA: 0x0030DE00 File Offset: 0x0030C000
		public void UnPackTo(IAbsoluteTipsActorTransformResultT _o)
		{
			_o.IsSuccess = this.IsSuccess;
			_o.Reason = this.Reason;
			_o.Type = this.Type;
			_o.TransformWorld = ((this.TransformWorld != null) ? this.TransformWorld.Value.UnPack() : null);
			_o.HollowTipsActorComponent = ((this.HollowTipsActorComponent != null) ? this.HollowTipsActorComponent.Value.UnPack() : null);
		}

		// Token: 0x0601512A RID: 86314 RVA: 0x0030DE90 File Offset: 0x0030C090
		public static Offset<IAbsoluteTipsActorTransformResult> Pack(FlatBufferBuilder builder, IAbsoluteTipsActorTransformResultT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAbsoluteTipsActorTransformResult>);
			}
			StringOffset reasonOffset = (_o.Reason == null) ? default(StringOffset) : builder.CreateString(_o.Reason);
			Offset<IShapeTransform> transformWorldOffset = (_o.TransformWorld == null) ? default(Offset<IShapeTransform>) : IShapeTransform.Pack(builder, _o.TransformWorld);
			Offset<IHollowTipsActorComponent> hollowTipsActorComponentOffset = (_o.HollowTipsActorComponent == null) ? default(Offset<IHollowTipsActorComponent>) : IHollowTipsActorComponent.Pack(builder, _o.HollowTipsActorComponent);
			return IAbsoluteTipsActorTransformResult.CreateIAbsoluteTipsActorTransformResult(builder, _o.IsSuccess, reasonOffset, _o.Type, transformWorldOffset, hollowTipsActorComponentOffset);
		}

		// Token: 0x0400B1A0 RID: 45472
		private Table __p;
	}
}
