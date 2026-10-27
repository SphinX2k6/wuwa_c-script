using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061B2 RID: 25010
	public struct IAudioStateGroup : IFlatbufferObject
	{
		// Token: 0x1700BA7C RID: 47740
		// (get) Token: 0x0602B182 RID: 176514 RVA: 0x005F135C File Offset: 0x005EF55C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B183 RID: 176515 RVA: 0x005F1369 File Offset: 0x005EF569
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B184 RID: 176516 RVA: 0x005F1370 File Offset: 0x005EF570
		public static IAudioStateGroup GetRootAsIAudioStateGroup(ByteBuffer _bb)
		{
			return IAudioStateGroup.GetRootAsIAudioStateGroup(_bb, default(IAudioStateGroup));
		}

		// Token: 0x0602B185 RID: 176517 RVA: 0x005F138C File Offset: 0x005EF58C
		public static IAudioStateGroup GetRootAsIAudioStateGroup(ByteBuffer _bb, IAudioStateGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B186 RID: 176518 RVA: 0x005F13A9 File Offset: 0x005EF5A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B187 RID: 176519 RVA: 0x005F13B8 File Offset: 0x005EF5B8
		public IAudioStateGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BA7D RID: 47741
		// (get) Token: 0x0602B188 RID: 176520 RVA: 0x005F13C8 File Offset: 0x005EF5C8
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

		// Token: 0x0602B189 RID: 176521 RVA: 0x005F13FF File Offset: 0x005EF5FF
		public Span<byte> GetGroupBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602B18A RID: 176522 RVA: 0x005F140E File Offset: 0x005EF60E
		public byte[] GetGroupArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0602B18B RID: 176523 RVA: 0x005F141C File Offset: 0x005EF61C
		public string States(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700BA7E RID: 47742
		// (get) Token: 0x0602B18C RID: 176524 RVA: 0x005F1458 File Offset: 0x005EF658
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

		// Token: 0x0602B18D RID: 176525 RVA: 0x005F1483 File Offset: 0x005EF683
		public static Offset<IAudioStateGroup> CreateIAudioStateGroup(FlatBufferBuilder builder, StringOffset GroupOffset = default(StringOffset), VectorOffset StatesOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IAudioStateGroup.AddStates(builder, StatesOffset);
			IAudioStateGroup.AddGroup(builder, GroupOffset);
			return IAudioStateGroup.EndIAudioStateGroup(builder);
		}

		// Token: 0x0602B18E RID: 176526 RVA: 0x005F14A0 File Offset: 0x005EF6A0
		public static void StartIAudioStateGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602B18F RID: 176527 RVA: 0x005F14A9 File Offset: 0x005EF6A9
		public static void AddGroup(FlatBufferBuilder builder, StringOffset groupOffset)
		{
			builder.AddOffset(0, groupOffset.Value, 0);
		}

		// Token: 0x0602B190 RID: 176528 RVA: 0x005F14B9 File Offset: 0x005EF6B9
		public static void AddStates(FlatBufferBuilder builder, VectorOffset statesOffset)
		{
			builder.AddOffset(1, statesOffset.Value, 0);
		}

		// Token: 0x0602B191 RID: 176529 RVA: 0x005F14CC File Offset: 0x005EF6CC
		public static VectorOffset CreateStatesVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602B192 RID: 176530 RVA: 0x005F150C File Offset: 0x005EF70C
		public static VectorOffset CreateStatesVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602B193 RID: 176531 RVA: 0x005F1526 File Offset: 0x005EF726
		public static VectorOffset CreateStatesVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602B194 RID: 176532 RVA: 0x005F1544 File Offset: 0x005EF744
		public static VectorOffset CreateStatesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602B195 RID: 176533 RVA: 0x005F155D File Offset: 0x005EF75D
		public static void StartStatesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602B196 RID: 176534 RVA: 0x005F1568 File Offset: 0x005EF768
		public static Offset<IAudioStateGroup> EndIAudioStateGroup(FlatBufferBuilder builder)
		{
			return new Offset<IAudioStateGroup>(builder.EndTable());
		}

		// Token: 0x0602B197 RID: 176535 RVA: 0x005F1578 File Offset: 0x005EF778
		public IAudioStateGroupT UnPack()
		{
			IAudioStateGroupT audioStateGroupT = new IAudioStateGroupT();
			this.UnPackTo(audioStateGroupT);
			return audioStateGroupT;
		}

		// Token: 0x0602B198 RID: 176536 RVA: 0x005F1594 File Offset: 0x005EF794
		public void UnPackTo(IAudioStateGroupT _o)
		{
			_o.Group = this.Group;
			_o.States = new List<string>();
			for (int i = 0; i < this.StatesLength; i++)
			{
				_o.States.Add(this.States(i));
			}
		}

		// Token: 0x0602B199 RID: 176537 RVA: 0x005F15DC File Offset: 0x005EF7DC
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

		// Token: 0x040106D1 RID: 67281
		private Table __p;
	}
}
