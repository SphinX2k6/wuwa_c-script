using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200126E RID: 4718
	public sealed class SingleProcessedFoodFormulaInfo : IMessage<SingleProcessedFoodFormulaInfo>, IMessage, IEquatable<SingleProcessedFoodFormulaInfo>, IDeepCloneable<SingleProcessedFoodFormulaInfo>, IBufferMessage
	{
		// Token: 0x06019302 RID: 103170 RVA: 0x003AC72F File Offset: 0x003AA92F
		[NullableContext(1)]
		public static SingleProcessedFoodFormulaInfo Create()
		{
			return new SingleProcessedFoodFormulaInfo();
		}

		// Token: 0x17005528 RID: 21800
		// (get) Token: 0x06019303 RID: 103171 RVA: 0x003AC736 File Offset: 0x003AA936
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SingleProcessedFoodFormulaInfo> Parser
		{
			get
			{
				return SingleProcessedFoodFormulaInfo._parser;
			}
		}

		// Token: 0x17005529 RID: 21801
		// (get) Token: 0x06019304 RID: 103172 RVA: 0x003AC73D File Offset: 0x003AA93D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700552A RID: 21802
		// (get) Token: 0x06019305 RID: 103173 RVA: 0x003AC740 File Offset: 0x003AA940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SingleProcessedFoodFormulaInfo.Descriptor;
			}
		}

		// Token: 0x06019306 RID: 103174 RVA: 0x003AC747 File Offset: 0x003AA947
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SingleProcessedFoodFormulaInfo()
		{
		}

		// Token: 0x06019307 RID: 103175 RVA: 0x003AC768 File Offset: 0x003AA968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SingleProcessedFoodFormulaInfo(SingleProcessedFoodFormulaInfo other) : this()
		{
			this.id_ = other.id_;
			this.lockState_ = other.lockState_;
			this.interations_ = other.interations_.Clone();
			this.unlockParams_ = other.unlockParams_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019308 RID: 103176 RVA: 0x003AC7C6 File Offset: 0x003AA9C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SingleProcessedFoodFormulaInfo Clone()
		{
			return new SingleProcessedFoodFormulaInfo(this);
		}

		// Token: 0x1700552B RID: 21803
		// (get) Token: 0x06019309 RID: 103177 RVA: 0x003AC7CE File Offset: 0x003AA9CE
		// (set) Token: 0x0601930A RID: 103178 RVA: 0x003AC7D6 File Offset: 0x003AA9D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x1700552C RID: 21804
		// (get) Token: 0x0601930B RID: 103179 RVA: 0x003AC7DF File Offset: 0x003AA9DF
		// (set) Token: 0x0601930C RID: 103180 RVA: 0x003AC7E7 File Offset: 0x003AA9E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool LockState
		{
			get
			{
				return this.lockState_;
			}
			set
			{
				this.lockState_ = value;
			}
		}

		// Token: 0x1700552D RID: 21805
		// (get) Token: 0x0601930D RID: 103181 RVA: 0x003AC7F0 File Offset: 0x003AA9F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Interations
		{
			get
			{
				return this.interations_;
			}
		}

		// Token: 0x1700552E RID: 21806
		// (get) Token: 0x0601930E RID: 103182 RVA: 0x003AC7F8 File Offset: 0x003AA9F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockParams
		{
			get
			{
				return this.unlockParams_;
			}
		}

		// Token: 0x0601930F RID: 103183 RVA: 0x003AC800 File Offset: 0x003AAA00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SingleProcessedFoodFormulaInfo);
		}

		// Token: 0x06019310 RID: 103184 RVA: 0x003AC810 File Offset: 0x003AAA10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SingleProcessedFoodFormulaInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.LockState == other.LockState && this.interations_.Equals(other.interations_) && this.unlockParams_.Equals(other.unlockParams_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019311 RID: 103185 RVA: 0x003AC884 File Offset: 0x003AAA84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.LockState)
			{
				num ^= this.LockState.GetHashCode();
			}
			num ^= this.interations_.GetHashCode();
			num ^= this.unlockParams_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019312 RID: 103186 RVA: 0x003AC8F8 File Offset: 0x003AAAF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019313 RID: 103187 RVA: 0x003AC905 File Offset: 0x003AAB05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019314 RID: 103188 RVA: 0x003AC910 File Offset: 0x003AAB10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.LockState)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.LockState);
			}
			this.interations_.WriteTo(ref output, SingleProcessedFoodFormulaInfo._repeated_interations_codec);
			this.unlockParams_.WriteTo(ref output, SingleProcessedFoodFormulaInfo._repeated_unlockParams_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019315 RID: 103189 RVA: 0x003AC98C File Offset: 0x003AAB8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.LockState)
			{
				num += 2;
			}
			num += this.interations_.CalculateSize(SingleProcessedFoodFormulaInfo._repeated_interations_codec);
			num += this.unlockParams_.CalculateSize(SingleProcessedFoodFormulaInfo._repeated_unlockParams_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019316 RID: 103190 RVA: 0x003AC9FC File Offset: 0x003AABFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SingleProcessedFoodFormulaInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.LockState)
			{
				this.LockState = other.LockState;
			}
			this.interations_.Add(other.interations_);
			this.unlockParams_.Add(other.unlockParams_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019317 RID: 103191 RVA: 0x003ACA6E File Offset: 0x003AAC6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019318 RID: 103192 RVA: 0x003ACA78 File Offset: 0x003AAC78
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
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.LockState = input.ReadBool();
						continue;
					}
					if (num == 24U)
					{
						goto IL_5D;
					}
				}
				else
				{
					if (num == 26U)
					{
						goto IL_5D;
					}
					if (num == 32U || num == 34U)
					{
						this.unlockParams_.AddEntriesFrom(ref input, SingleProcessedFoodFormulaInfo._repeated_unlockParams_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_5D:
				this.interations_.AddEntriesFrom(ref input, SingleProcessedFoodFormulaInfo._repeated_interations_codec);
			}
		}

		// Token: 0x04009519 RID: 38169
		private static readonly MessageParser<SingleProcessedFoodFormulaInfo> _parser = new MessageParser<SingleProcessedFoodFormulaInfo>(() => new SingleProcessedFoodFormulaInfo());

		// Token: 0x0400951A RID: 38170
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400951B RID: 38171
		public const int IdFieldNumber = 1;

		// Token: 0x0400951C RID: 38172
		private int id_;

		// Token: 0x0400951D RID: 38173
		public const int LockStateFieldNumber = 2;

		// Token: 0x0400951E RID: 38174
		private bool lockState_;

		// Token: 0x0400951F RID: 38175
		public const int InterationsFieldNumber = 3;

		// Token: 0x04009520 RID: 38176
		private static readonly FieldCodec<int> _repeated_interations_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04009521 RID: 38177
		private readonly RepeatedField<int> interations_ = new RepeatedField<int>();

		// Token: 0x04009522 RID: 38178
		public const int UnlockParamsFieldNumber = 4;

		// Token: 0x04009523 RID: 38179
		private static readonly FieldCodec<int> _repeated_unlockParams_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04009524 RID: 38180
		private readonly RepeatedField<int> unlockParams_ = new RepeatedField<int>();
	}
}
