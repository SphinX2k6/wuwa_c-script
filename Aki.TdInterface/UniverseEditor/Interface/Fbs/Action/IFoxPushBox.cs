using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EF3 RID: 28403
	public struct IFoxPushBox : IFlatbufferObject
	{
		// Token: 0x1700D046 RID: 53318
		// (get) Token: 0x06031249 RID: 201289 RVA: 0x006A95C8 File Offset: 0x006A77C8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603124A RID: 201290 RVA: 0x006A95D5 File Offset: 0x006A77D5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603124B RID: 201291 RVA: 0x006A95DC File Offset: 0x006A77DC
		public static IFoxPushBox GetRootAsIFoxPushBox(ByteBuffer _bb)
		{
			return IFoxPushBox.GetRootAsIFoxPushBox(_bb, default(IFoxPushBox));
		}

		// Token: 0x0603124C RID: 201292 RVA: 0x006A95F8 File Offset: 0x006A77F8
		public static IFoxPushBox GetRootAsIFoxPushBox(ByteBuffer _bb, IFoxPushBox obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603124D RID: 201293 RVA: 0x006A9615 File Offset: 0x006A7815
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603124E RID: 201294 RVA: 0x006A9624 File Offset: 0x006A7824
		public IFoxPushBox __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D047 RID: 53319
		// (get) Token: 0x0603124F RID: 201295 RVA: 0x006A9634 File Offset: 0x006A7834
		public ELeisureInteract Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELeisureInteract.CustomSkill;
				}
				return (ELeisureInteract)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D048 RID: 53320
		// (get) Token: 0x06031250 RID: 201296 RVA: 0x006A9670 File Offset: 0x006A7870
		public int EntityId
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

		// Token: 0x1700D049 RID: 53321
		// (get) Token: 0x06031251 RID: 201297 RVA: 0x006A96AC File Offset: 0x006A78AC
		public int CollisionRadius
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D04A RID: 53322
		// (get) Token: 0x06031252 RID: 201298 RVA: 0x006A96E8 File Offset: 0x006A78E8
		public int SplineEntityId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D04B RID: 53323
		// (get) Token: 0x06031253 RID: 201299 RVA: 0x006A9728 File Offset: 0x006A7928
		public string SendEntityEventOnSplineFinish
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031254 RID: 201300 RVA: 0x006A9760 File Offset: 0x006A7960
		public Span<byte> GetSendEntityEventOnSplineFinishBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06031255 RID: 201301 RVA: 0x006A9770 File Offset: 0x006A7970
		public byte[] GetSendEntityEventOnSplineFinishArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x06031256 RID: 201302 RVA: 0x006A977F File Offset: 0x006A797F
		public static Offset<IFoxPushBox> CreateIFoxPushBox(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill, int EntityId = 0, int CollisionRadius = 0, int SplineEntityId = 0, StringOffset SendEntityEventOnSplineFinishOffset = default(StringOffset))
		{
			builder.StartTable(5);
			IFoxPushBox.AddSendEntityEventOnSplineFinish(builder, SendEntityEventOnSplineFinishOffset);
			IFoxPushBox.AddSplineEntityId(builder, SplineEntityId);
			IFoxPushBox.AddCollisionRadius(builder, CollisionRadius);
			IFoxPushBox.AddEntityId(builder, EntityId);
			IFoxPushBox.AddType(builder, Type);
			return IFoxPushBox.EndIFoxPushBox(builder);
		}

		// Token: 0x06031257 RID: 201303 RVA: 0x006A97B3 File Offset: 0x006A79B3
		public static void StartIFoxPushBox(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06031258 RID: 201304 RVA: 0x006A97BC File Offset: 0x006A79BC
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031259 RID: 201305 RVA: 0x006A97C7 File Offset: 0x006A79C7
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0603125A RID: 201306 RVA: 0x006A97D2 File Offset: 0x006A79D2
		public static void AddCollisionRadius(FlatBufferBuilder builder, int collisionRadius)
		{
			builder.AddInt(2, collisionRadius, 0);
		}

		// Token: 0x0603125B RID: 201307 RVA: 0x006A97DD File Offset: 0x006A79DD
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(3, splineEntityId, 0);
		}

		// Token: 0x0603125C RID: 201308 RVA: 0x006A97E8 File Offset: 0x006A79E8
		public static void AddSendEntityEventOnSplineFinish(FlatBufferBuilder builder, StringOffset sendEntityEventOnSplineFinishOffset)
		{
			builder.AddOffset(4, sendEntityEventOnSplineFinishOffset.Value, 0);
		}

		// Token: 0x0603125D RID: 201309 RVA: 0x006A97F8 File Offset: 0x006A79F8
		public static Offset<IFoxPushBox> EndIFoxPushBox(FlatBufferBuilder builder)
		{
			return new Offset<IFoxPushBox>(builder.EndTable());
		}

		// Token: 0x0603125E RID: 201310 RVA: 0x006A9808 File Offset: 0x006A7A08
		public IFoxPushBoxT UnPack()
		{
			IFoxPushBoxT foxPushBoxT = new IFoxPushBoxT();
			this.UnPackTo(foxPushBoxT);
			return foxPushBoxT;
		}

		// Token: 0x0603125F RID: 201311 RVA: 0x006A9823 File Offset: 0x006A7A23
		public void UnPackTo(IFoxPushBoxT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.CollisionRadius = this.CollisionRadius;
			_o.SplineEntityId = this.SplineEntityId;
			_o.SendEntityEventOnSplineFinish = this.SendEntityEventOnSplineFinish;
		}

		// Token: 0x06031260 RID: 201312 RVA: 0x006A9864 File Offset: 0x006A7A64
		public static Offset<IFoxPushBox> Pack(FlatBufferBuilder builder, IFoxPushBoxT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFoxPushBox>);
			}
			StringOffset sendEntityEventOnSplineFinishOffset = (_o.SendEntityEventOnSplineFinish == null) ? default(StringOffset) : builder.CreateString(_o.SendEntityEventOnSplineFinish);
			return IFoxPushBox.CreateIFoxPushBox(builder, _o.Type, _o.EntityId, _o.CollisionRadius, _o.SplineEntityId, sendEntityEventOnSplineFinishOffset);
		}

		// Token: 0x04011DF5 RID: 73205
		private Table __p;
	}
}
