using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000786 RID: 1926
	[NetMessage(EMessageId.HonamiStoryResidentTaskRewardRequest)]
	public sealed class HonamiStoryResidentTaskRewardRequest : IMessage<HonamiStoryResidentTaskRewardRequest>, IMessage, IEquatable<HonamiStoryResidentTaskRewardRequest>, IDeepCloneable<HonamiStoryResidentTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x0600AE2F RID: 44591 RVA: 0x001A29D5 File Offset: 0x001A0BD5
		[NullableContext(1)]
		public static HonamiStoryResidentTaskRewardRequest Create()
		{
			return new HonamiStoryResidentTaskRewardRequest();
		}

		// Token: 0x1700231E RID: 8990
		// (get) Token: 0x0600AE30 RID: 44592 RVA: 0x001A29DC File Offset: 0x001A0BDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700231F RID: 8991
		// (get) Token: 0x0600AE31 RID: 44593 RVA: 0x001A29DF File Offset: 0x001A0BDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryResidentTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600AE32 RID: 44594 RVA: 0x001A29E6 File Offset: 0x001A0BE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryResidentTaskRewardRequest()
		{
		}

		// Token: 0x0600AE33 RID: 44595 RVA: 0x001A29F9 File Offset: 0x001A0BF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryResidentTaskRewardRequest(HonamiStoryResidentTaskRewardRequest other) : this()
		{
			this.residentTaskIds_ = other.residentTaskIds_.Clone();
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AE34 RID: 44596 RVA: 0x001A2A2F File Offset: 0x001A0C2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryResidentTaskRewardRequest Clone()
		{
			return new HonamiStoryResidentTaskRewardRequest(this);
		}

		// Token: 0x17002320 RID: 8992
		// (get) Token: 0x0600AE35 RID: 44597 RVA: 0x001A2A37 File Offset: 0x001A0C37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ResidentTaskIds
		{
			get
			{
				return this.residentTaskIds_;
			}
		}

		// Token: 0x17002321 RID: 8993
		// (get) Token: 0x0600AE36 RID: 44598 RVA: 0x001A2A3F File Offset: 0x001A0C3F
		// (set) Token: 0x0600AE37 RID: 44599 RVA: 0x001A2A47 File Offset: 0x001A0C47
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

		// Token: 0x0600AE38 RID: 44600 RVA: 0x001A2A50 File Offset: 0x001A0C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryResidentTaskRewardRequest);
		}

		// Token: 0x0600AE39 RID: 44601 RVA: 0x001A2A60 File Offset: 0x001A0C60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryResidentTaskRewardRequest other)
		{
			return other != null && (other == this || (this.residentTaskIds_.Equals(other.residentTaskIds_) && this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AE3A RID: 44602 RVA: 0x001A2AB0 File Offset: 0x001A0CB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.residentTaskIds_.GetHashCode();
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

		// Token: 0x0600AE3B RID: 44603 RVA: 0x001A2AFD File Offset: 0x001A0CFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AE3C RID: 44604 RVA: 0x001A2B0A File Offset: 0x001A0D0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AE3D RID: 44605 RVA: 0x001A2B14 File Offset: 0x001A0D14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ActivityId);
			}
			this.residentTaskIds_.WriteTo(ref output, HonamiStoryResidentTaskRewardRequest._repeated_residentTaskIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AE3E RID: 44606 RVA: 0x001A2B64 File Offset: 0x001A0D64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.residentTaskIds_.CalculateSize(HonamiStoryResidentTaskRewardRequest._repeated_residentTaskIds_codec);
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

		// Token: 0x0600AE3F RID: 44607 RVA: 0x001A2BB8 File Offset: 0x001A0DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryResidentTaskRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.residentTaskIds_.Add(other.residentTaskIds_);
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AE40 RID: 44608 RVA: 0x001A2C05 File Offset: 0x001A0E05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AE41 RID: 44609 RVA: 0x001A2C10 File Offset: 0x001A0E10
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
				if (num != 8U)
				{
					if (num != 56U && num != 58U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.residentTaskIds_.AddEntriesFrom(ref input, HonamiStoryResidentTaskRewardRequest._repeated_residentTaskIds_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004EF8 RID: 20216
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004EF9 RID: 20217
		public const int ResidentTaskIdsFieldNumber = 7;

		// Token: 0x04004EFA RID: 20218
		private static readonly FieldCodec<int> _repeated_residentTaskIds_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04004EFB RID: 20219
		private readonly RepeatedField<int> residentTaskIds_ = new RepeatedField<int>();

		// Token: 0x04004EFC RID: 20220
		public const int ActivityIdFieldNumber = 1;

		// Token: 0x04004EFD RID: 20221
		private int activityId_;
	}
}
