using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B18 RID: 27416
	public struct ICommonTipTriggerDelegation : IFlatbufferObject
	{
		// Token: 0x1700C955 RID: 51541
		// (get) Token: 0x0602F23A RID: 193082 RVA: 0x0066D7AD File Offset: 0x0066B9AD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F23B RID: 193083 RVA: 0x0066D7BA File Offset: 0x0066B9BA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F23C RID: 193084 RVA: 0x0066D7C4 File Offset: 0x0066B9C4
		public static ICommonTipTriggerDelegation GetRootAsICommonTipTriggerDelegation(ByteBuffer _bb)
		{
			return ICommonTipTriggerDelegation.GetRootAsICommonTipTriggerDelegation(_bb, default(ICommonTipTriggerDelegation));
		}

		// Token: 0x0602F23D RID: 193085 RVA: 0x0066D7E0 File Offset: 0x0066B9E0
		public static ICommonTipTriggerDelegation GetRootAsICommonTipTriggerDelegation(ByteBuffer _bb, ICommonTipTriggerDelegation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F23E RID: 193086 RVA: 0x0066D7FD File Offset: 0x0066B9FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F23F RID: 193087 RVA: 0x0066D80C File Offset: 0x0066BA0C
		public ICommonTipTriggerDelegation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C956 RID: 51542
		// (get) Token: 0x0602F240 RID: 193088 RVA: 0x0066D81C File Offset: 0x0066BA1C
		public ECommonTipType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECommonTipType.ChallengeCondition;
				}
				return (ECommonTipType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C957 RID: 51543
		// (get) Token: 0x0602F241 RID: 193089 RVA: 0x0066D858 File Offset: 0x0066BA58
		public string TidMainText
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

		// Token: 0x0602F242 RID: 193090 RVA: 0x0066D88F File Offset: 0x0066BA8F
		public Span<byte> GetTidMainTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602F243 RID: 193091 RVA: 0x0066D89E File Offset: 0x0066BA9E
		public byte[] GetTidMainTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700C958 RID: 51544
		// (get) Token: 0x0602F244 RID: 193092 RVA: 0x0066D8AC File Offset: 0x0066BAAC
		public string TidSubText
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F245 RID: 193093 RVA: 0x0066D8E3 File Offset: 0x0066BAE3
		public Span<byte> GetTidSubTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602F246 RID: 193094 RVA: 0x0066D8F2 File Offset: 0x0066BAF2
		public byte[] GetTidSubTextArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0602F247 RID: 193095 RVA: 0x0066D900 File Offset: 0x0066BB00
		public static Offset<ICommonTipTriggerDelegation> CreateICommonTipTriggerDelegation(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, StringOffset TidMainTextOffset = default(StringOffset), StringOffset TidSubTextOffset = default(StringOffset))
		{
			builder.StartTable(3);
			ICommonTipTriggerDelegation.AddTidSubText(builder, TidSubTextOffset);
			ICommonTipTriggerDelegation.AddTidMainText(builder, TidMainTextOffset);
			ICommonTipTriggerDelegation.AddType(builder, Type);
			return ICommonTipTriggerDelegation.EndICommonTipTriggerDelegation(builder);
		}

		// Token: 0x0602F248 RID: 193096 RVA: 0x0066D924 File Offset: 0x0066BB24
		public static void StartICommonTipTriggerDelegation(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602F249 RID: 193097 RVA: 0x0066D92D File Offset: 0x0066BB2D
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F24A RID: 193098 RVA: 0x0066D938 File Offset: 0x0066BB38
		public static void AddTidMainText(FlatBufferBuilder builder, StringOffset tidMainTextOffset)
		{
			builder.AddOffset(1, tidMainTextOffset.Value, 0);
		}

		// Token: 0x0602F24B RID: 193099 RVA: 0x0066D948 File Offset: 0x0066BB48
		public static void AddTidSubText(FlatBufferBuilder builder, StringOffset tidSubTextOffset)
		{
			builder.AddOffset(2, tidSubTextOffset.Value, 0);
		}

		// Token: 0x0602F24C RID: 193100 RVA: 0x0066D958 File Offset: 0x0066BB58
		public static Offset<ICommonTipTriggerDelegation> EndICommonTipTriggerDelegation(FlatBufferBuilder builder)
		{
			return new Offset<ICommonTipTriggerDelegation>(builder.EndTable());
		}

		// Token: 0x0602F24D RID: 193101 RVA: 0x0066D968 File Offset: 0x0066BB68
		public ICommonTipTriggerDelegationT UnPack()
		{
			ICommonTipTriggerDelegationT commonTipTriggerDelegationT = new ICommonTipTriggerDelegationT();
			this.UnPackTo(commonTipTriggerDelegationT);
			return commonTipTriggerDelegationT;
		}

		// Token: 0x0602F24E RID: 193102 RVA: 0x0066D983 File Offset: 0x0066BB83
		public void UnPackTo(ICommonTipTriggerDelegationT _o)
		{
			_o.Type = this.Type;
			_o.TidMainText = this.TidMainText;
			_o.TidSubText = this.TidSubText;
		}

		// Token: 0x0602F24F RID: 193103 RVA: 0x0066D9AC File Offset: 0x0066BBAC
		public static Offset<ICommonTipTriggerDelegation> Pack(FlatBufferBuilder builder, ICommonTipTriggerDelegationT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonTipTriggerDelegation>);
			}
			StringOffset tidMainTextOffset = (_o.TidMainText == null) ? default(StringOffset) : builder.CreateString(_o.TidMainText);
			StringOffset tidSubTextOffset = (_o.TidSubText == null) ? default(StringOffset) : builder.CreateString(_o.TidSubText);
			return ICommonTipTriggerDelegation.CreateICommonTipTriggerDelegation(builder, _o.Type, tidMainTextOffset, tidSubTextOffset);
		}

		// Token: 0x040118CC RID: 71884
		private Table __p;
	}
}
