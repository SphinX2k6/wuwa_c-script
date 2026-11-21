using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007FA RID: 2042
	[NetMessage(EMessageId.InitRangeRequest)]
	public sealed class InitRangeRequest : IMessage<InitRangeRequest>, IMessage, IEquatable<InitRangeRequest>, IDeepCloneable<InitRangeRequest>, IBufferMessage
	{
		// Token: 0x0600B716 RID: 46870 RVA: 0x001B4A28 File Offset: 0x001B2C28
		[NullableContext(1)]
		public static InitRangeRequest Create()
		{
			return new InitRangeRequest();
		}

		// Token: 0x170024DD RID: 9437
		// (get) Token: 0x0600B717 RID: 46871 RVA: 0x001B4A2F File Offset: 0x001B2C2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170024DE RID: 9438
		// (get) Token: 0x0600B718 RID: 46872 RVA: 0x001B4A32 File Offset: 0x001B2C32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InitRangeRequest.Descriptor;
			}
		}

		// Token: 0x0600B719 RID: 46873 RVA: 0x001B4A39 File Offset: 0x001B2C39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InitRangeRequest()
		{
		}

		// Token: 0x0600B71A RID: 46874 RVA: 0x001B4A4C File Offset: 0x001B2C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InitRangeRequest(InitRangeRequest other) : this()
		{
			this.rangeEntityId_ = other.rangeEntityId_;
			this.inRangeEntityIds_ = other.inRangeEntityIds_.Clone();
			this.isPlayerInRange_ = other.isPlayerInRange_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B71B RID: 46875 RVA: 0x001B4A99 File Offset: 0x001B2C99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InitRangeRequest Clone()
		{
			return new InitRangeRequest(this);
		}

		// Token: 0x170024DF RID: 9439
		// (get) Token: 0x0600B71C RID: 46876 RVA: 0x001B4AA1 File Offset: 0x001B2CA1
		// (set) Token: 0x0600B71D RID: 46877 RVA: 0x001B4AA9 File Offset: 0x001B2CA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long RangeEntityId
		{
			get
			{
				return this.rangeEntityId_;
			}
			set
			{
				this.rangeEntityId_ = value;
			}
		}

		// Token: 0x170024E0 RID: 9440
		// (get) Token: 0x0600B71E RID: 46878 RVA: 0x001B4AB2 File Offset: 0x001B2CB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> InRangeEntityIds
		{
			get
			{
				return this.inRangeEntityIds_;
			}
		}

		// Token: 0x170024E1 RID: 9441
		// (get) Token: 0x0600B71F RID: 46879 RVA: 0x001B4ABA File Offset: 0x001B2CBA
		// (set) Token: 0x0600B720 RID: 46880 RVA: 0x001B4AC2 File Offset: 0x001B2CC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsPlayerInRange
		{
			get
			{
				return this.isPlayerInRange_;
			}
			set
			{
				this.isPlayerInRange_ = value;
			}
		}

		// Token: 0x0600B721 RID: 46881 RVA: 0x001B4ACB File Offset: 0x001B2CCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InitRangeRequest);
		}

		// Token: 0x0600B722 RID: 46882 RVA: 0x001B4ADC File Offset: 0x001B2CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InitRangeRequest other)
		{
			return other != null && (other == this || (this.RangeEntityId == other.RangeEntityId && this.inRangeEntityIds_.Equals(other.inRangeEntityIds_) && this.IsPlayerInRange == other.IsPlayerInRange && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B723 RID: 46883 RVA: 0x001B4B3C File Offset: 0x001B2D3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RangeEntityId != 0L)
			{
				num ^= this.RangeEntityId.GetHashCode();
			}
			num ^= this.inRangeEntityIds_.GetHashCode();
			if (this.IsPlayerInRange)
			{
				num ^= this.IsPlayerInRange.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B724 RID: 46884 RVA: 0x001B4BA2 File Offset: 0x001B2DA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B725 RID: 46885 RVA: 0x001B4BAF File Offset: 0x001B2DAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B726 RID: 46886 RVA: 0x001B4BB8 File Offset: 0x001B2DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RangeEntityId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.RangeEntityId);
			}
			this.inRangeEntityIds_.WriteTo(ref output, InitRangeRequest._repeated_inRangeEntityIds_codec);
			if (this.IsPlayerInRange)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.IsPlayerInRange);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B727 RID: 46887 RVA: 0x001B4C24 File Offset: 0x001B2E24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RangeEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.RangeEntityId);
			}
			num += this.inRangeEntityIds_.CalculateSize(InitRangeRequest._repeated_inRangeEntityIds_codec);
			if (this.IsPlayerInRange)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B728 RID: 46888 RVA: 0x001B4C84 File Offset: 0x001B2E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InitRangeRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RangeEntityId != 0L)
			{
				this.RangeEntityId = other.RangeEntityId;
			}
			this.inRangeEntityIds_.Add(other.inRangeEntityIds_);
			if (other.IsPlayerInRange)
			{
				this.IsPlayerInRange = other.IsPlayerInRange;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B729 RID: 46889 RVA: 0x001B4CE5 File Offset: 0x001B2EE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B72A RID: 46890 RVA: 0x001B4CF0 File Offset: 0x001B2EF0
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
				if (num <= 64U)
				{
					if (num == 32U)
					{
						this.RangeEntityId = input.ReadInt64();
						continue;
					}
					if (num == 64U)
					{
						goto IL_46;
					}
				}
				else
				{
					if (num == 66U)
					{
						goto IL_46;
					}
					if (num == 80U)
					{
						this.IsPlayerInRange = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_46:
				this.inRangeEntityIds_.AddEntriesFrom(ref input, InitRangeRequest._repeated_inRangeEntityIds_codec);
			}
		}

		// Token: 0x04005134 RID: 20788
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005135 RID: 20789
		public const int RangeEntityIdFieldNumber = 4;

		// Token: 0x04005136 RID: 20790
		private long rangeEntityId_;

		// Token: 0x04005137 RID: 20791
		public const int InRangeEntityIdsFieldNumber = 8;

		// Token: 0x04005138 RID: 20792
		private static readonly FieldCodec<long> _repeated_inRangeEntityIds_codec = FieldCodec.ForInt64(66U);

		// Token: 0x04005139 RID: 20793
		private readonly RepeatedField<long> inRangeEntityIds_ = new RepeatedField<long>();

		// Token: 0x0400513A RID: 20794
		public const int IsPlayerInRangeFieldNumber = 10;

		// Token: 0x0400513B RID: 20795
		private bool isPlayerInRange_;
	}
}
