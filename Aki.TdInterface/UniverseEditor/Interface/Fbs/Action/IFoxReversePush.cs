using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006864 RID: 26724
	public struct IFoxReversePush : IFlatbufferObject
	{
		// Token: 0x1700C680 RID: 50816
		// (get) Token: 0x0602E999 RID: 190873 RVA: 0x0065B2B1 File Offset: 0x006594B1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E99A RID: 190874 RVA: 0x0065B2BE File Offset: 0x006594BE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E99B RID: 190875 RVA: 0x0065B2C8 File Offset: 0x006594C8
		public static IFoxReversePush GetRootAsIFoxReversePush(ByteBuffer _bb)
		{
			return IFoxReversePush.GetRootAsIFoxReversePush(_bb, default(IFoxReversePush));
		}

		// Token: 0x0602E99C RID: 190876 RVA: 0x0065B2E4 File Offset: 0x006594E4
		public static IFoxReversePush GetRootAsIFoxReversePush(ByteBuffer _bb, IFoxReversePush obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E99D RID: 190877 RVA: 0x0065B301 File Offset: 0x00659501
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E99E RID: 190878 RVA: 0x0065B310 File Offset: 0x00659510
		public IFoxReversePush __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C681 RID: 50817
		// (get) Token: 0x0602E99F RID: 190879 RVA: 0x0065B320 File Offset: 0x00659520
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

		// Token: 0x1700C682 RID: 50818
		// (get) Token: 0x0602E9A0 RID: 190880 RVA: 0x0065B35C File Offset: 0x0065955C
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

		// Token: 0x1700C683 RID: 50819
		// (get) Token: 0x0602E9A1 RID: 190881 RVA: 0x0065B398 File Offset: 0x00659598
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

		// Token: 0x1700C684 RID: 50820
		// (get) Token: 0x0602E9A2 RID: 190882 RVA: 0x0065B3D4 File Offset: 0x006595D4
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

		// Token: 0x0602E9A3 RID: 190883 RVA: 0x0065B40C File Offset: 0x0065960C
		public Span<byte> GetSliderTagBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0602E9A4 RID: 190884 RVA: 0x0065B41C File Offset: 0x0065961C
		public byte[] GetSliderTagArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700C685 RID: 50821
		// (get) Token: 0x0602E9A5 RID: 190885 RVA: 0x0065B42C File Offset: 0x0065962C
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

		// Token: 0x0602E9A6 RID: 190886 RVA: 0x0065B46D File Offset: 0x0065966D
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

		// Token: 0x0602E9A7 RID: 190887 RVA: 0x0065B4A1 File Offset: 0x006596A1
		public static void StartIFoxReversePush(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602E9A8 RID: 190888 RVA: 0x0065B4AA File Offset: 0x006596AA
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E9A9 RID: 190889 RVA: 0x0065B4B5 File Offset: 0x006596B5
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(1, splineEntityId, 0);
		}

		// Token: 0x0602E9AA RID: 190890 RVA: 0x0065B4C0 File Offset: 0x006596C0
		public static void AddSeqEntityId(FlatBufferBuilder builder, int seqEntityId)
		{
			builder.AddInt(2, seqEntityId, 0);
		}

		// Token: 0x0602E9AB RID: 190891 RVA: 0x0065B4CB File Offset: 0x006596CB
		public static void AddSliderTag(FlatBufferBuilder builder, StringOffset sliderTagOffset)
		{
			builder.AddOffset(3, sliderTagOffset.Value, 0);
		}

		// Token: 0x0602E9AC RID: 190892 RVA: 0x0065B4DB File Offset: 0x006596DB
		public static void AddRadius(FlatBufferBuilder builder, float radius)
		{
			builder.AddFloat(4, radius, 0.0);
		}

		// Token: 0x0602E9AD RID: 190893 RVA: 0x0065B4EE File Offset: 0x006596EE
		public static Offset<IFoxReversePush> EndIFoxReversePush(FlatBufferBuilder builder)
		{
			return new Offset<IFoxReversePush>(builder.EndTable());
		}

		// Token: 0x0602E9AE RID: 190894 RVA: 0x0065B4FC File Offset: 0x006596FC
		public IFoxReversePushT UnPack()
		{
			IFoxReversePushT foxReversePushT = new IFoxReversePushT();
			this.UnPackTo(foxReversePushT);
			return foxReversePushT;
		}

		// Token: 0x0602E9AF RID: 190895 RVA: 0x0065B517 File Offset: 0x00659717
		public void UnPackTo(IFoxReversePushT _o)
		{
			_o.Type = this.Type;
			_o.SplineEntityId = this.SplineEntityId;
			_o.SeqEntityId = this.SeqEntityId;
			_o.SliderTag = this.SliderTag;
			_o.Radius = this.Radius;
		}

		// Token: 0x0602E9B0 RID: 190896 RVA: 0x0065B558 File Offset: 0x00659758
		public static Offset<IFoxReversePush> Pack(FlatBufferBuilder builder, IFoxReversePushT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFoxReversePush>);
			}
			StringOffset sliderTagOffset = (_o.SliderTag == null) ? default(StringOffset) : builder.CreateString(_o.SliderTag);
			return IFoxReversePush.CreateIFoxReversePush(builder, _o.Type, _o.SplineEntityId, _o.SeqEntityId, sliderTagOffset, _o.Radius);
		}

		// Token: 0x04010FB3 RID: 69555
		private Table __p;
	}
}
