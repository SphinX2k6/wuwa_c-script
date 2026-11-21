using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200076D RID: 1901
	[NetMessage(EMessageId.HonamiStoryItemCollectionResponse)]
	public sealed class HonamiStoryItemCollectionResponse : IMessage<HonamiStoryItemCollectionResponse>, IMessage, IEquatable<HonamiStoryItemCollectionResponse>, IDeepCloneable<HonamiStoryItemCollectionResponse>, IBufferMessage
	{
		// Token: 0x0600AC3C RID: 44092 RVA: 0x0019E924 File Offset: 0x0019CB24
		[NullableContext(1)]
		public static HonamiStoryItemCollectionResponse Create()
		{
			return new HonamiStoryItemCollectionResponse();
		}

		// Token: 0x170022B9 RID: 8889
		// (get) Token: 0x0600AC3D RID: 44093 RVA: 0x0019E92B File Offset: 0x0019CB2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170022BA RID: 8890
		// (get) Token: 0x0600AC3E RID: 44094 RVA: 0x0019E92E File Offset: 0x0019CB2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryItemCollectionResponse.Descriptor;
			}
		}

		// Token: 0x0600AC3F RID: 44095 RVA: 0x0019E935 File Offset: 0x0019CB35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryItemCollectionResponse()
		{
		}

		// Token: 0x0600AC40 RID: 44096 RVA: 0x0019E948 File Offset: 0x0019CB48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryItemCollectionResponse(HonamiStoryItemCollectionResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.honamiStoryItemCollectionId_ = other.honamiStoryItemCollectionId_.Clone();
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AC41 RID: 44097 RVA: 0x0019E995 File Offset: 0x0019CB95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryItemCollectionResponse Clone()
		{
			return new HonamiStoryItemCollectionResponse(this);
		}

		// Token: 0x170022BB RID: 8891
		// (get) Token: 0x0600AC42 RID: 44098 RVA: 0x0019E99D File Offset: 0x0019CB9D
		// (set) Token: 0x0600AC43 RID: 44099 RVA: 0x0019E9A5 File Offset: 0x0019CBA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x170022BC RID: 8892
		// (get) Token: 0x0600AC44 RID: 44100 RVA: 0x0019E9AE File Offset: 0x0019CBAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> HonamiStoryItemCollectionId
		{
			get
			{
				return this.honamiStoryItemCollectionId_;
			}
		}

		// Token: 0x170022BD RID: 8893
		// (get) Token: 0x0600AC45 RID: 44101 RVA: 0x0019E9B6 File Offset: 0x0019CBB6
		// (set) Token: 0x0600AC46 RID: 44102 RVA: 0x0019E9BE File Offset: 0x0019CBBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x0600AC47 RID: 44103 RVA: 0x0019E9C7 File Offset: 0x0019CBC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryItemCollectionResponse);
		}

		// Token: 0x0600AC48 RID: 44104 RVA: 0x0019E9D8 File Offset: 0x0019CBD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryItemCollectionResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.honamiStoryItemCollectionId_.Equals(other.honamiStoryItemCollectionId_) && this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AC49 RID: 44105 RVA: 0x0019EA38 File Offset: 0x0019CC38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.honamiStoryItemCollectionId_.GetHashCode();
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AC4A RID: 44106 RVA: 0x0019EAA4 File Offset: 0x0019CCA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AC4B RID: 44107 RVA: 0x0019EAB1 File Offset: 0x0019CCB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AC4C RID: 44108 RVA: 0x0019EABC File Offset: 0x0019CCBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ActivityId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.honamiStoryItemCollectionId_.WriteTo(ref output, HonamiStoryItemCollectionResponse._repeated_honamiStoryItemCollectionId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AC4D RID: 44109 RVA: 0x0019EB28 File Offset: 0x0019CD28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.honamiStoryItemCollectionId_.CalculateSize(HonamiStoryItemCollectionResponse._repeated_honamiStoryItemCollectionId_codec);
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AC4E RID: 44110 RVA: 0x0019EB94 File Offset: 0x0019CD94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryItemCollectionResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.honamiStoryItemCollectionId_.Add(other.honamiStoryItemCollectionId_);
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AC4F RID: 44111 RVA: 0x0019EBF5 File Offset: 0x0019CDF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AC50 RID: 44112 RVA: 0x0019EC00 File Offset: 0x0019CE00
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
				if (num <= 40U)
				{
					if (num == 8U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				else if (num == 64U || num == 66U)
				{
					this.honamiStoryItemCollectionId_.AddEntriesFrom(ref input, HonamiStoryItemCollectionResponse._repeated_honamiStoryItemCollectionId_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004E75 RID: 20085
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E76 RID: 20086
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04004E77 RID: 20087
		private ErrorCode errorCode_;

		// Token: 0x04004E78 RID: 20088
		public const int HonamiStoryItemCollectionIdFieldNumber = 8;

		// Token: 0x04004E79 RID: 20089
		private static readonly FieldCodec<int> _repeated_honamiStoryItemCollectionId_codec = FieldCodec.ForInt32(66U);

		// Token: 0x04004E7A RID: 20090
		private readonly RepeatedField<int> honamiStoryItemCollectionId_ = new RepeatedField<int>();

		// Token: 0x04004E7B RID: 20091
		public const int ActivityIdFieldNumber = 1;

		// Token: 0x04004E7C RID: 20092
		private int activityId_;
	}
}
