using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A64 RID: 2660
	[NetMessage(EMessageId.MotorFightSelectBuffGateRequest)]
	public sealed class MotorFightSelectBuffGateRequest : IMessage<MotorFightSelectBuffGateRequest>, IMessage, IEquatable<MotorFightSelectBuffGateRequest>, IDeepCloneable<MotorFightSelectBuffGateRequest>, IBufferMessage
	{
		// Token: 0x0600E810 RID: 59408 RVA: 0x0021E8DD File Offset: 0x0021CADD
		[NullableContext(1)]
		public static MotorFightSelectBuffGateRequest Create()
		{
			return new MotorFightSelectBuffGateRequest();
		}

		// Token: 0x17002F18 RID: 12056
		// (get) Token: 0x0600E811 RID: 59409 RVA: 0x0021E8E4 File Offset: 0x0021CAE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F19 RID: 12057
		// (get) Token: 0x0600E812 RID: 59410 RVA: 0x0021E8E7 File Offset: 0x0021CAE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightSelectBuffGateRequest.Descriptor;
			}
		}

		// Token: 0x0600E813 RID: 59411 RVA: 0x0021E8EE File Offset: 0x0021CAEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightSelectBuffGateRequest()
		{
		}

		// Token: 0x0600E814 RID: 59412 RVA: 0x0021E904 File Offset: 0x0021CB04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightSelectBuffGateRequest(MotorFightSelectBuffGateRequest other) : this()
		{
			this.subLevelIndex_ = other.subLevelIndex_;
			this.waveGroupIndex_ = other.waveGroupIndex_;
			this.buffGateId_ = other.buffGateId_;
			this.buffIds_ = other.buffIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E815 RID: 59413 RVA: 0x0021E95D File Offset: 0x0021CB5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightSelectBuffGateRequest Clone()
		{
			return new MotorFightSelectBuffGateRequest(this);
		}

		// Token: 0x17002F1A RID: 12058
		// (get) Token: 0x0600E816 RID: 59414 RVA: 0x0021E965 File Offset: 0x0021CB65
		// (set) Token: 0x0600E817 RID: 59415 RVA: 0x0021E96D File Offset: 0x0021CB6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SubLevelIndex
		{
			get
			{
				return this.subLevelIndex_;
			}
			set
			{
				this.subLevelIndex_ = value;
			}
		}

		// Token: 0x17002F1B RID: 12059
		// (get) Token: 0x0600E818 RID: 59416 RVA: 0x0021E976 File Offset: 0x0021CB76
		// (set) Token: 0x0600E819 RID: 59417 RVA: 0x0021E97E File Offset: 0x0021CB7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WaveGroupIndex
		{
			get
			{
				return this.waveGroupIndex_;
			}
			set
			{
				this.waveGroupIndex_ = value;
			}
		}

		// Token: 0x17002F1C RID: 12060
		// (get) Token: 0x0600E81A RID: 59418 RVA: 0x0021E987 File Offset: 0x0021CB87
		// (set) Token: 0x0600E81B RID: 59419 RVA: 0x0021E98F File Offset: 0x0021CB8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BuffGateId
		{
			get
			{
				return this.buffGateId_;
			}
			set
			{
				this.buffGateId_ = value;
			}
		}

		// Token: 0x17002F1D RID: 12061
		// (get) Token: 0x0600E81C RID: 59420 RVA: 0x0021E998 File Offset: 0x0021CB98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> BuffIds
		{
			get
			{
				return this.buffIds_;
			}
		}

		// Token: 0x0600E81D RID: 59421 RVA: 0x0021E9A0 File Offset: 0x0021CBA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightSelectBuffGateRequest);
		}

		// Token: 0x0600E81E RID: 59422 RVA: 0x0021E9B0 File Offset: 0x0021CBB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightSelectBuffGateRequest other)
		{
			return other != null && (other == this || (this.SubLevelIndex == other.SubLevelIndex && this.WaveGroupIndex == other.WaveGroupIndex && this.BuffGateId == other.BuffGateId && this.buffIds_.Equals(other.buffIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E81F RID: 59423 RVA: 0x0021EA20 File Offset: 0x0021CC20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SubLevelIndex != 0)
			{
				num ^= this.SubLevelIndex.GetHashCode();
			}
			if (this.WaveGroupIndex != 0)
			{
				num ^= this.WaveGroupIndex.GetHashCode();
			}
			if (this.BuffGateId != 0)
			{
				num ^= this.BuffGateId.GetHashCode();
			}
			num ^= this.buffIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E820 RID: 59424 RVA: 0x0021EA9F File Offset: 0x0021CC9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E821 RID: 59425 RVA: 0x0021EAAC File Offset: 0x0021CCAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E822 RID: 59426 RVA: 0x0021EAB8 File Offset: 0x0021CCB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BuffGateId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.BuffGateId);
			}
			if (this.WaveGroupIndex != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.WaveGroupIndex);
			}
			this.buffIds_.WriteTo(ref output, MotorFightSelectBuffGateRequest._repeated_buffIds_codec);
			if (this.SubLevelIndex != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.SubLevelIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E823 RID: 59427 RVA: 0x0021EB40 File Offset: 0x0021CD40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SubLevelIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SubLevelIndex);
			}
			if (this.WaveGroupIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WaveGroupIndex);
			}
			if (this.BuffGateId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BuffGateId);
			}
			num += this.buffIds_.CalculateSize(MotorFightSelectBuffGateRequest._repeated_buffIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E824 RID: 59428 RVA: 0x0021EBC4 File Offset: 0x0021CDC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightSelectBuffGateRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SubLevelIndex != 0)
			{
				this.SubLevelIndex = other.SubLevelIndex;
			}
			if (other.WaveGroupIndex != 0)
			{
				this.WaveGroupIndex = other.WaveGroupIndex;
			}
			if (other.BuffGateId != 0)
			{
				this.BuffGateId = other.BuffGateId;
			}
			this.buffIds_.Add(other.buffIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E825 RID: 59429 RVA: 0x0021EC39 File Offset: 0x0021CE39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E826 RID: 59430 RVA: 0x0021EC44 File Offset: 0x0021CE44
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.BuffGateId = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.WaveGroupIndex = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U || num == 106U)
					{
						this.buffIds_.AddEntriesFrom(ref input, MotorFightSelectBuffGateRequest._repeated_buffIds_codec);
						continue;
					}
					if (num == 120U)
					{
						this.SubLevelIndex = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005E8E RID: 24206
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005E8F RID: 24207
		public const int SubLevelIndexFieldNumber = 15;

		// Token: 0x04005E90 RID: 24208
		private int subLevelIndex_;

		// Token: 0x04005E91 RID: 24209
		public const int WaveGroupIndexFieldNumber = 3;

		// Token: 0x04005E92 RID: 24210
		private int waveGroupIndex_;

		// Token: 0x04005E93 RID: 24211
		public const int BuffGateIdFieldNumber = 1;

		// Token: 0x04005E94 RID: 24212
		private int buffGateId_;

		// Token: 0x04005E95 RID: 24213
		public const int BuffIdsFieldNumber = 13;

		// Token: 0x04005E96 RID: 24214
		private static readonly FieldCodec<int> _repeated_buffIds_codec = FieldCodec.ForInt32(106U);

		// Token: 0x04005E97 RID: 24215
		private readonly RepeatedField<int> buffIds_ = new RepeatedField<int>();
	}
}
