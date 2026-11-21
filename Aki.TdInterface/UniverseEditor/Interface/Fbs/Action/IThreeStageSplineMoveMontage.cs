using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BC0 RID: 31680
	public struct IThreeStageSplineMoveMontage : IFlatbufferObject
	{
		// Token: 0x1700ED5F RID: 60767
		// (get) Token: 0x060391A8 RID: 233896 RVA: 0x007B7B56 File Offset: 0x007B5D56
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060391A9 RID: 233897 RVA: 0x007B7B63 File Offset: 0x007B5D63
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060391AA RID: 233898 RVA: 0x007B7B6C File Offset: 0x007B5D6C
		public static IThreeStageSplineMoveMontage GetRootAsIThreeStageSplineMoveMontage(ByteBuffer _bb)
		{
			return IThreeStageSplineMoveMontage.GetRootAsIThreeStageSplineMoveMontage(_bb, default(IThreeStageSplineMoveMontage));
		}

		// Token: 0x060391AB RID: 233899 RVA: 0x007B7B88 File Offset: 0x007B5D88
		public static IThreeStageSplineMoveMontage GetRootAsIThreeStageSplineMoveMontage(ByteBuffer _bb, IThreeStageSplineMoveMontage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060391AC RID: 233900 RVA: 0x007B7BA5 File Offset: 0x007B5DA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060391AD RID: 233901 RVA: 0x007B7BB4 File Offset: 0x007B5DB4
		public IThreeStageSplineMoveMontage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ED60 RID: 60768
		// (get) Token: 0x060391AE RID: 233902 RVA: 0x007B7BC4 File Offset: 0x007B5DC4
		public ESplineMoveMontageType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESplineMoveMontageType.ThreeStageMontage;
				}
				return (ESplineMoveMontageType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700ED61 RID: 60769
		// (get) Token: 0x060391AF RID: 233903 RVA: 0x007B7C00 File Offset: 0x007B5E00
		public string MontagePath
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

		// Token: 0x060391B0 RID: 233904 RVA: 0x007B7C37 File Offset: 0x007B5E37
		public Span<byte> GetMontagePathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060391B1 RID: 233905 RVA: 0x007B7C46 File Offset: 0x007B5E46
		public byte[] GetMontagePathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060391B2 RID: 233906 RVA: 0x007B7C54 File Offset: 0x007B5E54
		public static Offset<IThreeStageSplineMoveMontage> CreateIThreeStageSplineMoveMontage(FlatBufferBuilder builder, ESplineMoveMontageType Type = ESplineMoveMontageType.ThreeStageMontage, StringOffset MontagePathOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IThreeStageSplineMoveMontage.AddMontagePath(builder, MontagePathOffset);
			IThreeStageSplineMoveMontage.AddType(builder, Type);
			return IThreeStageSplineMoveMontage.EndIThreeStageSplineMoveMontage(builder);
		}

		// Token: 0x060391B3 RID: 233907 RVA: 0x007B7C71 File Offset: 0x007B5E71
		public static void StartIThreeStageSplineMoveMontage(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060391B4 RID: 233908 RVA: 0x007B7C7A File Offset: 0x007B5E7A
		public static void AddType(FlatBufferBuilder builder, ESplineMoveMontageType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060391B5 RID: 233909 RVA: 0x007B7C85 File Offset: 0x007B5E85
		public static void AddMontagePath(FlatBufferBuilder builder, StringOffset montagePathOffset)
		{
			builder.AddOffset(1, montagePathOffset.Value, 0);
		}

		// Token: 0x060391B6 RID: 233910 RVA: 0x007B7C95 File Offset: 0x007B5E95
		public static Offset<IThreeStageSplineMoveMontage> EndIThreeStageSplineMoveMontage(FlatBufferBuilder builder)
		{
			return new Offset<IThreeStageSplineMoveMontage>(builder.EndTable());
		}

		// Token: 0x060391B7 RID: 233911 RVA: 0x007B7CA4 File Offset: 0x007B5EA4
		public IThreeStageSplineMoveMontageT UnPack()
		{
			IThreeStageSplineMoveMontageT threeStageSplineMoveMontageT = new IThreeStageSplineMoveMontageT();
			this.UnPackTo(threeStageSplineMoveMontageT);
			return threeStageSplineMoveMontageT;
		}

		// Token: 0x060391B8 RID: 233912 RVA: 0x007B7CBF File Offset: 0x007B5EBF
		public void UnPackTo(IThreeStageSplineMoveMontageT _o)
		{
			_o.Type = this.Type;
			_o.MontagePath = this.MontagePath;
		}

		// Token: 0x060391B9 RID: 233913 RVA: 0x007B7CDC File Offset: 0x007B5EDC
		public static Offset<IThreeStageSplineMoveMontage> Pack(FlatBufferBuilder builder, IThreeStageSplineMoveMontageT _o)
		{
			if (_o == null)
			{
				return default(Offset<IThreeStageSplineMoveMontage>);
			}
			StringOffset montagePathOffset = (_o.MontagePath == null) ? default(StringOffset) : builder.CreateString(_o.MontagePath);
			return IThreeStageSplineMoveMontage.CreateIThreeStageSplineMoveMontage(builder, _o.Type, montagePathOffset);
		}

		// Token: 0x04013248 RID: 78408
		private Table __p;
	}
}
