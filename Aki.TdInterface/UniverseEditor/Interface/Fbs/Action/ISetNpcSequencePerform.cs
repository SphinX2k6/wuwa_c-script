using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007809 RID: 30729
	public struct ISetNpcSequencePerform : IFlatbufferObject
	{
		// Token: 0x1700E13A RID: 57658
		// (get) Token: 0x06035FD5 RID: 221141 RVA: 0x0073B4D7 File Offset: 0x007396D7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035FD6 RID: 221142 RVA: 0x0073B4E4 File Offset: 0x007396E4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035FD7 RID: 221143 RVA: 0x0073B4EC File Offset: 0x007396EC
		public static ISetNpcSequencePerform GetRootAsISetNpcSequencePerform(ByteBuffer _bb)
		{
			return ISetNpcSequencePerform.GetRootAsISetNpcSequencePerform(_bb, default(ISetNpcSequencePerform));
		}

		// Token: 0x06035FD8 RID: 221144 RVA: 0x0073B508 File Offset: 0x00739708
		public static ISetNpcSequencePerform GetRootAsISetNpcSequencePerform(ByteBuffer _bb, ISetNpcSequencePerform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035FD9 RID: 221145 RVA: 0x0073B525 File Offset: 0x00739725
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035FDA RID: 221146 RVA: 0x0073B534 File Offset: 0x00739734
		public ISetNpcSequencePerform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E13B RID: 57659
		// (get) Token: 0x06035FDB RID: 221147 RVA: 0x0073B544 File Offset: 0x00739744
		public ENpcGroupPerformType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENpcGroupPerformType.HandInHand;
				}
				return (ENpcGroupPerformType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E13C RID: 57660
		// (get) Token: 0x06035FDC RID: 221148 RVA: 0x0073B580 File Offset: 0x00739780
		public string Sequence
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

		// Token: 0x06035FDD RID: 221149 RVA: 0x0073B5B7 File Offset: 0x007397B7
		public Span<byte> GetSequenceBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06035FDE RID: 221150 RVA: 0x0073B5C6 File Offset: 0x007397C6
		public byte[] GetSequenceArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06035FDF RID: 221151 RVA: 0x0073B5D4 File Offset: 0x007397D4
		public INpcGroupSequencePlaySetting? PlaySettings(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new INpcGroupSequencePlaySetting?(default(INpcGroupSequencePlaySetting).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700E13D RID: 57661
		// (get) Token: 0x06035FE0 RID: 221152 RVA: 0x0073B634 File Offset: 0x00739834
		public int PlaySettingsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700E13E RID: 57662
		// (get) Token: 0x06035FE1 RID: 221153 RVA: 0x0073B660 File Offset: 0x00739860
		public INpcGroupSequenceStaticEntityBinding? Binding
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new INpcGroupSequenceStaticEntityBinding?(default(INpcGroupSequenceStaticEntityBinding).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06035FE2 RID: 221154 RVA: 0x0073B6C0 File Offset: 0x007398C0
		public INpcGroupSequenceBlendAnim? BlendOutAnim(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new INpcGroupSequenceBlendAnim?(default(INpcGroupSequenceBlendAnim).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700E13F RID: 57663
		// (get) Token: 0x06035FE3 RID: 221155 RVA: 0x0073B724 File Offset: 0x00739924
		public int BlendOutAnimLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700E140 RID: 57664
		// (get) Token: 0x06035FE4 RID: 221156 RVA: 0x0073B750 File Offset: 0x00739950
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035FE5 RID: 221157 RVA: 0x0073B78D File Offset: 0x0073998D
		public static Offset<ISetNpcSequencePerform> CreateISetNpcSequencePerform(FlatBufferBuilder builder, ENpcGroupPerformType Type = ENpcGroupPerformType.HandInHand, StringOffset SequenceOffset = default(StringOffset), VectorOffset PlaySettingsOffset = default(VectorOffset), Offset<INpcGroupSequenceStaticEntityBinding> BindingOffset = default(Offset<INpcGroupSequenceStaticEntityBinding>), VectorOffset BlendOutAnimOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(6);
			ISetNpcSequencePerform.AddBlendOutAnim(builder, BlendOutAnimOffset);
			ISetNpcSequencePerform.AddBinding(builder, BindingOffset);
			ISetNpcSequencePerform.AddPlaySettings(builder, PlaySettingsOffset);
			ISetNpcSequencePerform.AddSequence(builder, SequenceOffset);
			ISetNpcSequencePerform.AddNullMask(builder, NullMask);
			ISetNpcSequencePerform.AddType(builder, Type);
			return ISetNpcSequencePerform.EndISetNpcSequencePerform(builder);
		}

		// Token: 0x06035FE6 RID: 221158 RVA: 0x0073B7C9 File Offset: 0x007399C9
		public static void StartISetNpcSequencePerform(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06035FE7 RID: 221159 RVA: 0x0073B7D2 File Offset: 0x007399D2
		public static void AddType(FlatBufferBuilder builder, ENpcGroupPerformType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035FE8 RID: 221160 RVA: 0x0073B7DD File Offset: 0x007399DD
		public static void AddSequence(FlatBufferBuilder builder, StringOffset sequenceOffset)
		{
			builder.AddOffset(1, sequenceOffset.Value, 0);
		}

		// Token: 0x06035FE9 RID: 221161 RVA: 0x0073B7ED File Offset: 0x007399ED
		public static void AddPlaySettings(FlatBufferBuilder builder, VectorOffset playSettingsOffset)
		{
			builder.AddOffset(2, playSettingsOffset.Value, 0);
		}

		// Token: 0x06035FEA RID: 221162 RVA: 0x0073B800 File Offset: 0x00739A00
		public static VectorOffset CreatePlaySettingsVector(FlatBufferBuilder builder, Offset<INpcGroupSequencePlaySetting>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06035FEB RID: 221163 RVA: 0x0073B840 File Offset: 0x00739A40
		public static VectorOffset CreatePlaySettingsVectorBlock(FlatBufferBuilder builder, Offset<INpcGroupSequencePlaySetting>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<INpcGroupSequencePlaySetting>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035FEC RID: 221164 RVA: 0x0073B85A File Offset: 0x00739A5A
		public static VectorOffset CreatePlaySettingsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<INpcGroupSequencePlaySetting>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<INpcGroupSequencePlaySetting>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035FED RID: 221165 RVA: 0x0073B878 File Offset: 0x00739A78
		public static VectorOffset CreatePlaySettingsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<INpcGroupSequencePlaySetting>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06035FEE RID: 221166 RVA: 0x0073B891 File Offset: 0x00739A91
		public static void StartPlaySettingsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06035FEF RID: 221167 RVA: 0x0073B89C File Offset: 0x00739A9C
		public static void AddBinding(FlatBufferBuilder builder, Offset<INpcGroupSequenceStaticEntityBinding> bindingOffset)
		{
			builder.AddOffset(3, bindingOffset.Value, 0);
		}

		// Token: 0x06035FF0 RID: 221168 RVA: 0x0073B8AC File Offset: 0x00739AAC
		public static void AddBlendOutAnim(FlatBufferBuilder builder, VectorOffset blendOutAnimOffset)
		{
			builder.AddOffset(4, blendOutAnimOffset.Value, 0);
		}

		// Token: 0x06035FF1 RID: 221169 RVA: 0x0073B8BC File Offset: 0x00739ABC
		public static VectorOffset CreateBlendOutAnimVector(FlatBufferBuilder builder, Offset<INpcGroupSequenceBlendAnim>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06035FF2 RID: 221170 RVA: 0x0073B8FC File Offset: 0x00739AFC
		public static VectorOffset CreateBlendOutAnimVectorBlock(FlatBufferBuilder builder, Offset<INpcGroupSequenceBlendAnim>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<INpcGroupSequenceBlendAnim>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035FF3 RID: 221171 RVA: 0x0073B916 File Offset: 0x00739B16
		public static VectorOffset CreateBlendOutAnimVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<INpcGroupSequenceBlendAnim>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<INpcGroupSequenceBlendAnim>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035FF4 RID: 221172 RVA: 0x0073B934 File Offset: 0x00739B34
		public static VectorOffset CreateBlendOutAnimVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<INpcGroupSequenceBlendAnim>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06035FF5 RID: 221173 RVA: 0x0073B94D File Offset: 0x00739B4D
		public static void StartBlendOutAnimVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06035FF6 RID: 221174 RVA: 0x0073B958 File Offset: 0x00739B58
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06035FF7 RID: 221175 RVA: 0x0073B963 File Offset: 0x00739B63
		public static Offset<ISetNpcSequencePerform> EndISetNpcSequencePerform(FlatBufferBuilder builder)
		{
			return new Offset<ISetNpcSequencePerform>(builder.EndTable());
		}

		// Token: 0x06035FF8 RID: 221176 RVA: 0x0073B970 File Offset: 0x00739B70
		public ISetNpcSequencePerformT UnPack()
		{
			ISetNpcSequencePerformT setNpcSequencePerformT = new ISetNpcSequencePerformT();
			this.UnPackTo(setNpcSequencePerformT);
			return setNpcSequencePerformT;
		}

		// Token: 0x06035FF9 RID: 221177 RVA: 0x0073B98C File Offset: 0x00739B8C
		public void UnPackTo(ISetNpcSequencePerformT _o)
		{
			_o.Type = this.Type;
			_o.Sequence = this.Sequence;
			_o.PlaySettings = new List<INpcGroupSequencePlaySettingT>();
			for (int i = 0; i < this.PlaySettingsLength; i++)
			{
				_o.PlaySettings.Add((this.PlaySettings(i) != null) ? this.PlaySettings(i).Value.UnPack() : null);
			}
			_o.Binding = ((this.Binding != null) ? this.Binding.Value.UnPack() : null);
			_o.BlendOutAnim = new List<INpcGroupSequenceBlendAnimT>();
			for (int j = 0; j < this.BlendOutAnimLength; j++)
			{
				_o.BlendOutAnim.Add((this.BlendOutAnim(j) != null) ? this.BlendOutAnim(j).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06035FFA RID: 221178 RVA: 0x0073BA9C File Offset: 0x00739C9C
		public static Offset<ISetNpcSequencePerform> Pack(FlatBufferBuilder builder, ISetNpcSequencePerformT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetNpcSequencePerform>);
			}
			StringOffset sequenceOffset = (_o.Sequence == null) ? default(StringOffset) : builder.CreateString(_o.Sequence);
			VectorOffset playSettingsOffset = default(VectorOffset);
			if (_o.PlaySettings != null)
			{
				Offset<INpcGroupSequencePlaySetting>[] array = new Offset<INpcGroupSequencePlaySetting>[_o.PlaySettings.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = INpcGroupSequencePlaySetting.Pack(builder, _o.PlaySettings[i]);
				}
				playSettingsOffset = ISetNpcSequencePerform.CreatePlaySettingsVector(builder, array);
			}
			Offset<INpcGroupSequenceStaticEntityBinding> bindingOffset = (_o.Binding == null) ? default(Offset<INpcGroupSequenceStaticEntityBinding>) : INpcGroupSequenceStaticEntityBinding.Pack(builder, _o.Binding);
			VectorOffset blendOutAnimOffset = default(VectorOffset);
			if (_o.BlendOutAnim != null)
			{
				Offset<INpcGroupSequenceBlendAnim>[] array2 = new Offset<INpcGroupSequenceBlendAnim>[_o.BlendOutAnim.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = INpcGroupSequenceBlendAnim.Pack(builder, _o.BlendOutAnim[j]);
				}
				blendOutAnimOffset = ISetNpcSequencePerform.CreateBlendOutAnimVector(builder, array2);
			}
			return ISetNpcSequencePerform.CreateISetNpcSequencePerform(builder, _o.Type, sequenceOffset, playSettingsOffset, bindingOffset, blendOutAnimOffset, _o.NullMask);
		}

		// Token: 0x04012A62 RID: 76386
		private Table __p;
	}
}
