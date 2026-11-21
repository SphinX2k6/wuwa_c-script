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
		// Token: 0x06002340 RID: 9024 RVA: 0x0005E1F5 File Offset: 0x0005C3F5
		[NullableContext(1)]
		public static AnimStateChangeInfo Create()
		{
			return new AnimStateChangeInfo();
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06002341 RID: 9025 RVA: 0x0005E1FC File Offset: 0x0005C3FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AnimStateChangeInfo> Parser
		{
			get
			{
				return AnimStateChangeInfo._parser;
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06002342 RID: 9026 RVA: 0x0005E203 File Offset: 0x0005C403
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06002343 RID: 9027 RVA: 0x0005E206 File Offset: 0x0005C406
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AnimStateChangeInfo.Descriptor;
			}
		}

		// Token: 0x06002344 RID: 9028 RVA: 0x0005E20D File Offset: 0x0005C40D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimStateChangeInfo()
		{
		}

		// Token: 0x06002345 RID: 9029 RVA: 0x0005E22C File Offset: 0x0005C42C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimStateChangeInfo(AnimStateChangeInfo other) : this()
		{
			this.states_ = other.states_.Clone();
			this.specialStates_ = other.specialStates_.Clone();
			this.modelId_ = other.modelId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002346 RID: 9030 RVA: 0x0005E27E File Offset: 0x0005C47E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimStateChangeInfo Clone()
		{
			return new AnimStateChangeInfo(this);
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06002347 RID: 9031 RVA: 0x0005E286 File Offset: 0x0005C486
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> States
		{
			get
			{
				return this.states_;
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06002348 RID: 9032 RVA: 0x0005E28E File Offset: 0x0005C48E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SpecialStates
		{
			get
			{
				return this.specialStates_;
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06002349 RID: 9033 RVA: 0x0005E296 File Offset: 0x0005C496
		// (set) Token: 0x0600234A RID: 9034 RVA: 0x0005E29E File Offset: 0x0005C49E
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

		// Token: 0x0600234B RID: 9035 RVA: 0x0005E2A7 File Offset: 0x0005C4A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AnimStateChangeInfo);
		}

		// Token: 0x0600234C RID: 9036 RVA: 0x0005E2B8 File Offset: 0x0005C4B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AnimStateChangeInfo other)
		{
			return other != null && (other == this || (this.states_.Equals(other.states_) && this.specialStates_.Equals(other.specialStates_) && this.ModelId == other.ModelId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600234D RID: 9037 RVA: 0x0005E31C File Offset: 0x0005C51C
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

		// Token: 0x0600234E RID: 9038 RVA: 0x0005E377 File Offset: 0x0005C577
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600234F RID: 9039 RVA: 0x0005E384 File Offset: 0x0005C584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002350 RID: 9040 RVA: 0x0005E390 File Offset: 0x0005C590
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

		// Token: 0x06002351 RID: 9041 RVA: 0x0005E3F0 File Offset: 0x0005C5F0
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

		// Token: 0x06002352 RID: 9042 RVA: 0x0005E454 File Offset: 0x0005C654
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

		// Token: 0x06002353 RID: 9043 RVA: 0x0005E4B2 File Offset: 0x0005C6B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002354 RID: 9044 RVA: 0x0005E4BC File Offset: 0x0005C6BC
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

		// Token: 0x0400252C RID: 9516
		private static readonly MessageParser<AnimStateChangeInfo> _parser = new MessageParser<AnimStateChangeInfo>(() => new AnimStateChangeInfo());

		// Token: 0x0400252D RID: 9517
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400252E RID: 9518
		public const int StatesFieldNumber = 1;

		// Token: 0x0400252F RID: 9519
		private static readonly FieldCodec<int> _repeated_states_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04002530 RID: 9520
		private readonly RepeatedField<int> states_ = new RepeatedField<int>();

		// Token: 0x04002531 RID: 9521
		public const int SpecialStatesFieldNumber = 2;

		// Token: 0x04002532 RID: 9522
		private static readonly FieldCodec<int> _repeated_specialStates_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04002533 RID: 9523
		private readonly RepeatedField<int> specialStates_ = new RepeatedField<int>();

		// Token: 0x04002534 RID: 9524
		public const int ModelIdFieldNumber = 3;

		// Token: 0x04002535 RID: 9525
		private int modelId_;
	}
}
