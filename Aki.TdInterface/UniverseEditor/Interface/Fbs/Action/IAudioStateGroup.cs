using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006820 RID: 26656
	public struct IAudioStateGroup : IFlatbufferObject
	{
		// Token: 0x1700C3FF RID: 50175
		// (get) Token: 0x0602D8C9 RID: 186569 RVA: 0x0063BDD0 File Offset: 0x00639FD0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D8CA RID: 186570 RVA: 0x0063BDDD File Offset: 0x00639FDD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D8CB RID: 186571 RVA: 0x0063BDE4 File Offset: 0x00639FE4
		public static IAudioStateGroup GetRootAsIAudioStateGroup(ByteBuffer _bb)
		{
			return IAudioStateGroup.GetRootAsIAudioStateGroup(_bb, default(IAudioStateGroup));
		}

		// Token: 0x0602D8CC RID: 186572 RVA: 0x0063BE00 File Offset: 0x0063A000
		public static IAudioStateGroup GetRootAsIAudioStateGroup(ByteBuffer _bb, IAudioStateGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D8CD RID: 186573 RVA: 0x0063BE1D File Offset: 0x0063A01D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D8CE RID: 186574 RVA: 0x0063BE2C File Offset: 0x0063A02C
		public IAudioStateGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C400 RID: 50176
		// (get) Token: 0x0602D8CF RID: 186575 RVA: 0x0063BE3C File Offset: 0x0063A03C
		public string Group
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D8D0 RID: 186576 RVA: 0x0063BE73 File Offset: 0x0063A073
		public Span<byte> GetGroupBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602D8D1 RID: 186577 RVA: 0x0063BE82 File Offset: 0x0063A082
		public byte[] GetGroupArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0602D8D2 RID: 186578 RVA: 0x0063BE90 File Offset: 0x0063A090
		public string States(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C401 RID: 50177
		// (get) Token: 0x0602D8D3 RID: 186579 RVA: 0x0063BECC File Offset: 0x0063A0CC
		public int StatesLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602D8D4 RID: 186580 RVA: 0x0063BEF7 File Offset: 0x0063A0F7
		public static Offset<IAudioStateGroup> CreateIAudioStateGroup(FlatBufferBuilder builder, StringOffset GroupOffset = default(StringOffset), VectorOffset StatesOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IAudioStateGroup.AddStates(builder, StatesOffset);
			IAudioStateGroup.AddGroup(builder, GroupOffset);
			return IAudioStateGroup.EndIAudioStateGroup(builder);
		}

		// Token: 0x0602D8D5 RID: 186581 RVA: 0x0063BF14 File Offset: 0x0063A114
		public static void StartIAudioStateGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602D8D6 RID: 186582 RVA: 0x0063BF1D File Offset: 0x0063A11D
		public static void AddGroup(FlatBufferBuilder builder, StringOffset groupOffset)
		{
			builder.AddOffset(0, groupOffset.Value, 0);
		}

		// Token: 0x0602D8D7 RID: 186583 RVA: 0x0063BF2D File Offset: 0x0063A12D
		public static void AddStates(FlatBufferBuilder builder, VectorOffset statesOffset)
		{
			builder.AddOffset(1, statesOffset.Value, 0);
		}

		// Token: 0x0602D8D8 RID: 186584 RVA: 0x0063BF40 File Offset: 0x0063A140
		public static VectorOffset CreateStatesVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602D8D9 RID: 186585 RVA: 0x0063BF80 File Offset: 0x0063A180
		public static VectorOffset CreateStatesVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602D8DA RID: 186586 RVA: 0x0063BF9A File Offset: 0x0063A19A
		public static VectorOffset CreateStatesVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602D8DB RID: 186587 RVA: 0x0063BFB8 File Offset: 0x0063A1B8
		public static VectorOffset CreateStatesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602D8DC RID: 186588 RVA: 0x0063BFD1 File Offset: 0x0063A1D1
		public static void StartStatesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602D8DD RID: 186589 RVA: 0x0063BFDC File Offset: 0x0063A1DC
		public static Offset<IAudioStateGroup> EndIAudioStateGroup(FlatBufferBuilder builder)
		{
			return new Offset<IAudioStateGroup>(builder.EndTable());
		}

		// Token: 0x0602D8DE RID: 186590 RVA: 0x0063BFEC File Offset: 0x0063A1EC
		public IAudioStateGroupT UnPack()
		{
			IAudioStateGroupT audioStateGroupT = new IAudioStateGroupT();
			this.UnPackTo(audioStateGroupT);
			return audioStateGroupT;
		}

		// Token: 0x0602D8DF RID: 186591 RVA: 0x0063C008 File Offset: 0x0063A208
		public void UnPackTo(IAudioStateGroupT _o)
		{
			_o.Group = this.Group;
			_o.States = new List<string>();
			for (int i = 0; i < this.StatesLength; i++)
			{
				_o.States.Add(this.States(i));
			}
		}

		// Token: 0x0602D8E0 RID: 186592 RVA: 0x0063C050 File Offset: 0x0063A250
		public static Offset<IAudioStateGroup> Pack(FlatBufferBuilder builder, IAudioStateGroupT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAudioStateGroup>);
			}
			StringOffset groupOffset = (_o.Group == null) ? default(StringOffset) : builder.CreateString(_o.Group);
			VectorOffset statesOffset = default(VectorOffset);
			if (_o.States != null)
			{
				StringOffset[] array = new StringOffset[_o.States.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.States[i]);
				}
				statesOffset = IAudioStateGroup.CreateStatesVector(builder, array);
			}
			return IAudioStateGroup.CreateIAudioStateGroup(builder, groupOffset, statesOffset);
		}

		// Token: 0x040114E3 RID: 70883
		private Table __p;
	}
}
