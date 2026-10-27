using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000781 RID: 1921
	[NetMessage(EMessageId.HonamiStoryItemCollectionResponse)]
	public sealed class HonamiStoryItemCollectionResponse : IMessage<HonamiStoryItemCollectionResponse>, IMessage, IEquatable<HonamiStoryItemCollectionResponse>, IDeepCloneable<HonamiStoryItemCollectionResponse>, IBufferMessage
	{
		// Token: 0x0600AD92 RID: 44434 RVA: 0x001A134C File Offset: 0x0019F54C
		[NullableContext(1)]
		public static HonamiStoryItemCollectionResponse Create()
		{
			return new HonamiStoryItemCollectionResponse();
		}

		// Token: 0x17002303 RID: 8963
		// (get) Token: 0x0600AD93 RID: 44435 RVA: 0x001A1353 File Offset: 0x0019F553
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002304 RID: 8964
		// (get) Token: 0x0600AD94 RID: 44436 RVA: 0x001A1356 File Offset: 0x0019F556
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryItemCollectionResponse.Descriptor;
			}
		}

		// Token: 0x0600AD95 RID: 44437 RVA: 0x001A135D File Offset: 0x0019F55D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryItemCollectionResponse()
		{
		}

		// Token: 0x0600AD96 RID: 44438 RVA: 0x001A1370 File Offset: 0x0019F570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryItemCollectionResponse(HonamiStoryItemCollectionResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.honamiStoryItemCollectionId_ = other.honamiStoryItemCollectionId_.Clone();
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AD97 RID: 44439 RVA: 0x001A13BD File Offset: 0x0019F5BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryItemCollectionResponse Clone()
		{
			return new HonamiStoryItemCollectionResponse(this);
		}

		// Token: 0x17002305 RID: 8965
		// (get) Token: 0x0600AD98 RID: 44440 RVA: 0x001A13C5 File Offset: 0x0019F5C5
		// (set) Token: 0x0600AD99 RID: 44441 RVA: 0x001A13CD File Offset: 0x0019F5CD
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

		// Token: 0x17002306 RID: 8966
		// (get) Token: 0x0600AD9A RID: 44442 RVA: 0x001A13D6 File Offset: 0x0019F5D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> HonamiStoryItemCollectionId
		{
			get
			{
				return this.honamiStoryItemCollectionId_;
			}
		}

		// Token: 0x17002307 RID: 8967
		// (get) Token: 0x0600AD9B RID: 44443 RVA: 0x001A13DE File Offset: 0x0019F5DE
		// (set) Token: 0x0600AD9C RID: 44444 RVA: 0x001A13E6 File Offset: 0x0019F5E6
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

		// Token: 0x0600AD9D RID: 44445 RVA: 0x001A13EF File Offset: 0x0019F5EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryItemCollectionResponse);
		}

		// Token: 0x0600AD9E RID: 44446 RVA: 0x001A1400 File Offset: 0x0019F600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryItemCollectionResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.honamiStoryItemCollectionId_.Equals(other.honamiStoryItemCollectionId_) && this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AD9F RID: 44447 RVA: 0x001A1460 File Offset: 0x0019F660
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

		// Token: 0x0600ADA0 RID: 44448 RVA: 0x001A14CC File Offset: 0x0019F6CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600ADA1 RID: 44449 RVA: 0x001A14D9 File Offset: 0x0019F6D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ADA2 RID: 44450 RVA: 0x001A14E4 File Offset: 0x0019F6E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ActivityId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.honamiStoryItemCollectionId_.WriteTo(ref output, HonamiStoryItemCollectionResponse._repeated_honamiStoryItemCollectionId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ADA3 RID: 44451 RVA: 0x001A1550 File Offset: 0x0019F750
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

		// Token: 0x0600ADA4 RID: 44452 RVA: 0x001A15BC File Offset: 0x0019F7BC
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

		// Token: 0x0600ADA5 RID: 44453 RVA: 0x001A161D File Offset: 0x0019F81D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ADA6 RID: 44454 RVA: 0x001A1628 File Offset: 0x0019F828
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
				if (num <= 80U)
				{
					if (num == 48U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				else if (num == 96U || num == 98U)
				{
					this.honamiStoryItemCollectionId_.AddEntriesFrom(ref input, HonamiStoryItemCollectionResponse._repeated_honamiStoryItemCollectionId_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004E7C RID: 20092
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E7D RID: 20093
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04004E7E RID: 20094
		private ErrorCode errorCode_;

		// Token: 0x04004E7F RID: 20095
		public const int HonamiStoryItemCollectionIdFieldNumber = 12;

		// Token: 0x04004E80 RID: 20096
		private static readonly FieldCodec<int> _repeated_honamiStoryItemCollectionId_codec = FieldCodec.ForInt32(98U);

		// Token: 0x04004E81 RID: 20097
		private readonly RepeatedField<int> honamiStoryItemCollectionId_ = new RepeatedField<int>();

		// Token: 0x04004E82 RID: 20098
		public const int ActivityIdFieldNumber = 6;

		// Token: 0x04004E83 RID: 20099
		private int activityId_;
	}
}
