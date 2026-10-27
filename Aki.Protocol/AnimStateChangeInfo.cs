using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000F6 RID: 246
	public sealed class AnimStateChangeInfo : IMessage<AnimStateChangeInfo>, IMessage, IEquatable<AnimStateChangeInfo>, IDeepCloneable<AnimStateChangeInfo>, IBufferMessage
	{
		// Token: 0x06002309 RID: 8969 RVA: 0x0005D725 File Offset: 0x0005B925
		[NullableContext(1)]
		public static AnimStateChangeInfo Create()
		{
			return new AnimStateChangeInfo();
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x0600230A RID: 8970 RVA: 0x0005D72C File Offset: 0x0005B92C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AnimStateChangeInfo> Parser
		{
			get
			{
				return AnimStateChangeInfo._parser;
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x0600230B RID: 8971 RVA: 0x0005D733 File Offset: 0x0005B933
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x0600230C RID: 8972 RVA: 0x0005D736 File Offset: 0x0005B936
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AnimStateChangeInfo.Descriptor;
			}
		}

		// Token: 0x0600230D RID: 8973 RVA: 0x0005D73D File Offset: 0x0005B93D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimStateChangeInfo()
		{
		}

		// Token: 0x0600230E RID: 8974 RVA: 0x0005D75C File Offset: 0x0005B95C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimStateChangeInfo(AnimStateChangeInfo other) : this()
		{
			this.states_ = other.states_.Clone();
			this.specialStates_ = other.specialStates_.Clone();
			this.modelId_ = other.modelId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600230F RID: 8975 RVA: 0x0005D7AE File Offset: 0x0005B9AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimStateChangeInfo Clone()
		{
			return new AnimStateChangeInfo(this);
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06002310 RID: 8976 RVA: 0x0005D7B6 File Offset: 0x0005B9B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> States
		{
			get
			{
				return this.states_;
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06002311 RID: 8977 RVA: 0x0005D7BE File Offset: 0x0005B9BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SpecialStates
		{
			get
			{
				return this.specialStates_;
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06002312 RID: 8978 RVA: 0x0005D7C6 File Offset: 0x0005B9C6
		// (set) Token: 0x06002313 RID: 8979 RVA: 0x0005D7CE File Offset: 0x0005B9CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ModelId
		{
			get
			{
				return this.modelId_;
			}
			set
			{
				this.modelId_ = value;
			}
		}

		// Token: 0x06002314 RID: 8980 RVA: 0x0005D7D7 File Offset: 0x0005B9D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AnimStateChangeInfo);
		}

		// Token: 0x06002315 RID: 8981 RVA: 0x0005D7E8 File Offset: 0x0005B9E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AnimStateChangeInfo other)
		{
			return other != null && (other == this || (this.states_.Equals(other.states_) && this.specialStates_.Equals(other.specialStates_) && this.ModelId == other.ModelId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002316 RID: 8982 RVA: 0x0005D84C File Offset: 0x0005BA4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.states_.GetHashCode();
			num ^= this.specialStates_.GetHashCode();
			if (this.ModelId != 0)
			{
				num ^= this.ModelId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002317 RID: 8983 RVA: 0x0005D8A7 File Offset: 0x0005BAA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002318 RID: 8984 RVA: 0x0005D8B4 File Offset: 0x0005BAB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002319 RID: 8985 RVA: 0x0005D8C0 File Offset: 0x0005BAC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.states_.WriteTo(ref output, AnimStateChangeInfo._repeated_states_codec);
			this.specialStates_.WriteTo(ref output, AnimStateChangeInfo._repeated_specialStates_codec);
			if (this.ModelId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ModelId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600231A RID: 8986 RVA: 0x0005D920 File Offset: 0x0005BB20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.states_.CalculateSize(AnimStateChangeInfo._repeated_states_codec);
			num += this.specialStates_.CalculateSize(AnimStateChangeInfo._repeated_specialStates_codec);
			if (this.ModelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ModelId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600231B RID: 8987 RVA: 0x0005D984 File Offset: 0x0005BB84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AnimStateChangeInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.states_.Add(other.states_);
			this.specialStates_.Add(other.specialStates_);
			if (other.ModelId != 0)
			{
				this.ModelId = other.ModelId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600231C RID: 8988 RVA: 0x0005D9E2 File Offset: 0x0005BBE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600231D RID: 8989 RVA: 0x0005D9EC File Offset: 0x0005BBEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num <= 10U)
				{
					if (num == 8U || num == 10U)
					{
						this.states_.AddEntriesFrom(ref input, AnimStateChangeInfo._repeated_states_codec);
						continue;
					}
				}
				else
				{
					if (num == 16U || num == 18U)
					{
						this.specialStates_.AddEntriesFrom(ref input, AnimStateChangeInfo._repeated_specialStates_codec);
						continue;
					}
					if (num == 24U)
					{
						this.ModelId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040024CD RID: 9421
		private static readonly MessageParser<AnimStateChangeInfo> _parser = new MessageParser<AnimStateChangeInfo>(() => new AnimStateChangeInfo());

		// Token: 0x040024CE RID: 9422
		private UnknownFieldSet _unknownFields;

		// Token: 0x040024CF RID: 9423
		public const int StatesFieldNumber = 1;

		// Token: 0x040024D0 RID: 9424
		private static readonly FieldCodec<int> _repeated_states_codec = FieldCodec.ForInt32(10U);

		// Token: 0x040024D1 RID: 9425
		private readonly RepeatedField<int> states_ = new RepeatedField<int>();

		// Token: 0x040024D2 RID: 9426
		public const int SpecialStatesFieldNumber = 2;

		// Token: 0x040024D3 RID: 9427
		private static readonly FieldCodec<int> _repeated_specialStates_codec = FieldCodec.ForInt32(18U);

		// Token: 0x040024D4 RID: 9428
		private readonly RepeatedField<int> specialStates_ = new RepeatedField<int>();

		// Token: 0x040024D5 RID: 9429
		public const int ModelIdFieldNumber = 3;

		// Token: 0x040024D6 RID: 9430
		private int modelId_;
	}
}
