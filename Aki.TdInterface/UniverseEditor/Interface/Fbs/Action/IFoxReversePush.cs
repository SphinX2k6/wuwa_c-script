using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EF9 RID: 28409
	public struct IFoxReversePush : IFlatbufferObject
	{
		// Token: 0x1700D054 RID: 53332
		// (get) Token: 0x0603127F RID: 201343 RVA: 0x006A9B1D File Offset: 0x006A7D1D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031280 RID: 201344 RVA: 0x006A9B2A File Offset: 0x006A7D2A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031281 RID: 201345 RVA: 0x006A9B34 File Offset: 0x006A7D34
		public static IFoxReversePush GetRootAsIFoxReversePush(ByteBuffer _bb)
		{
			return IFoxReversePush.GetRootAsIFoxReversePush(_bb, default(IFoxReversePush));
		}

		// Token: 0x06031282 RID: 201346 RVA: 0x006A9B50 File Offset: 0x006A7D50
		public static IFoxReversePush GetRootAsIFoxReversePush(ByteBuffer _bb, IFoxReversePush obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031283 RID: 201347 RVA: 0x006A9B6D File Offset: 0x006A7D6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031284 RID: 201348 RVA: 0x006A9B7C File Offset: 0x006A7D7C
		public IFoxReversePush __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D055 RID: 53333
		// (get) Token: 0x06031285 RID: 201349 RVA: 0x006A9B8C File Offset: 0x006A7D8C
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

		// Token: 0x1700D056 RID: 53334
		// (get) Token: 0x06031286 RID: 201350 RVA: 0x006A9BC8 File Offset: 0x006A7DC8
		public int SplineEntityId
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

		// Token: 0x1700D057 RID: 53335
		// (get) Token: 0x06031287 RID: 201351 RVA: 0x006A9C04 File Offset: 0x006A7E04
		public int SeqEntityId
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

		// Token: 0x1700D058 RID: 53336
		// (get) Token: 0x06031288 RID: 201352 RVA: 0x006A9C40 File Offset: 0x006A7E40
		public string SliderTag
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

		// Token: 0x06031289 RID: 201353 RVA: 0x006A9C78 File Offset: 0x006A7E78
		public Span<byte> GetSliderTagBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0603128A RID: 201354 RVA: 0x006A9C88 File Offset: 0x006A7E88
		public byte[] GetSliderTagArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700D059 RID: 53337
		// (get) Token: 0x0603128B RID: 201355 RVA: 0x006A9C98 File Offset: 0x006A7E98
		public float Radius
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603128C RID: 201356 RVA: 0x006A9CD9 File Offset: 0x006A7ED9
		public static Offset<IFoxReversePush> CreateIFoxReversePush(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill, int SplineEntityId = 0, int SeqEntityId = 0, StringOffset SliderTagOffset = default(StringOffset), float Radius = 0f)
		{
			builder.StartTable(5);
			IFoxReversePush.AddRadius(builder, Radius);
			IFoxReversePush.AddSliderTag(builder, SliderTagOffset);
			IFoxReversePush.AddSeqEntityId(builder, SeqEntityId);
			IFoxReversePush.AddSplineEntityId(builder, SplineEntityId);
			IFoxReversePush.AddType(builder, Type);
			return IFoxReversePush.EndIFoxReversePush(builder);
		}

		// Token: 0x0603128D RID: 201357 RVA: 0x006A9D0D File Offset: 0x006A7F0D
		public static void StartIFoxReversePush(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0603128E RID: 201358 RVA: 0x006A9D16 File Offset: 0x006A7F16
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603128F RID: 201359 RVA: 0x006A9D21 File Offset: 0x006A7F21
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(1, splineEntityId, 0);
		}

		// Token: 0x06031290 RID: 201360 RVA: 0x006A9D2C File Offset: 0x006A7F2C
		public static void AddSeqEntityId(FlatBufferBuilder builder, int seqEntityId)
		{
			builder.AddInt(2, seqEntityId, 0);
		}

		// Token: 0x06031291 RID: 201361 RVA: 0x006A9D37 File Offset: 0x006A7F37
		public static void AddSliderTag(FlatBufferBuilder builder, StringOffset sliderTagOffset)
		{
			builder.AddOffset(3, sliderTagOffset.Value, 0);
		}

		// Token: 0x06031292 RID: 201362 RVA: 0x006A9D47 File Offset: 0x006A7F47
		public static void AddRadius(FlatBufferBuilder builder, float radius)
		{
			builder.AddFloat(4, radius, 0.0);
		}

		// Token: 0x06031293 RID: 201363 RVA: 0x006A9D5A File Offset: 0x006A7F5A
		public static Offset<IFoxReversePush> EndIFoxReversePush(FlatBufferBuilder builder)
		{
			return new Offset<IFoxReversePush>(builder.EndTable());
		}

		// Token: 0x06031294 RID: 201364 RVA: 0x006A9D68 File Offset: 0x006A7F68
		public IFoxReversePushT UnPack()
		{
			IFoxReversePushT foxReversePushT = new IFoxReversePushT();
			this.UnPackTo(foxReversePushT);
			return foxReversePushT;
		}

		// Token: 0x06031295 RID: 201365 RVA: 0x006A9D83 File Offset: 0x006A7F83
		public void UnPackTo(IFoxReversePushT _o)
		{
			_o.Type = this.Type;
			_o.SplineEntityId = this.SplineEntityId;
			_o.SeqEntityId = this.SeqEntityId;
			_o.SliderTag = this.SliderTag;
			_o.Radius = this.Radius;
		}

		// Token: 0x06031296 RID: 201366 RVA: 0x006A9DC4 File Offset: 0x006A7FC4
		public static Offset<IFoxReversePush> Pack(FlatBufferBuilder builder, IFoxReversePushT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFoxReversePush>);
			}
			StringOffset sliderTagOffset = (_o.SliderTag == null) ? default(StringOffset) : builder.CreateString(_o.SliderTag);
			return IFoxReversePush.CreateIFoxReversePush(builder, _o.Type, _o.SplineEntityId, _o.SeqEntityId, sliderTagOffset, _o.Radius);
		}

		// Token: 0x04011DFD RID: 73213
		private Table __p;
	}
}
