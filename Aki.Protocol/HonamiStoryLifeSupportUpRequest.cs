using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000785 RID: 1925
	[NetMessage(EMessageId.HonamiStoryLifeSupportUpRequest)]
	public sealed class HonamiStoryLifeSupportUpRequest : IMessage<HonamiStoryLifeSupportUpRequest>, IMessage, IEquatable<HonamiStoryLifeSupportUpRequest>, IDeepCloneable<HonamiStoryLifeSupportUpRequest>, IBufferMessage
	{
		// Token: 0x0600ADEB RID: 44523 RVA: 0x001A20E3 File Offset: 0x001A02E3
		[NullableContext(1)]
		public static HonamiStoryLifeSupportUpRequest Create()
		{
			return new HonamiStoryLifeSupportUpRequest();
		}

		// Token: 0x17002318 RID: 8984
		// (get) Token: 0x0600ADEC RID: 44524 RVA: 0x001A20EA File Offset: 0x001A02EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002319 RID: 8985
		// (get) Token: 0x0600ADED RID: 44525 RVA: 0x001A20ED File Offset: 0x001A02ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryLifeSupportUpRequest.Descriptor;
			}
		}

		// Token: 0x0600ADEE RID: 44526 RVA: 0x001A20F4 File Offset: 0x001A02F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryLifeSupportUpRequest()
		{
		}

		// Token: 0x0600ADEF RID: 44527 RVA: 0x001A20FC File Offset: 0x001A02FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryLifeSupportUpRequest(HonamiStoryLifeSupportUpRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ADF0 RID: 44528 RVA: 0x001A2121 File Offset: 0x001A0321
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryLifeSupportUpRequest Clone()
		{
			return new HonamiStoryLifeSupportUpRequest(this);
		}

		// Token: 0x1700231A RID: 8986
		// (get) Token: 0x0600ADF1 RID: 44529 RVA: 0x001A2129 File Offset: 0x001A0329
		// (set) Token: 0x0600ADF2 RID: 44530 RVA: 0x001A2131 File Offset: 0x001A0331
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

		// Token: 0x0600ADF3 RID: 44531 RVA: 0x001A213A File Offset: 0x001A033A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryLifeSupportUpRequest);
		}

		// Token: 0x0600ADF4 RID: 44532 RVA: 0x001A2148 File Offset: 0x001A0348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryLifeSupportUpRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ADF5 RID: 44533 RVA: 0x001A2178 File Offset: 0x001A0378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0600ADF6 RID: 44534 RVA: 0x001A21B7 File Offset: 0x001A03B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600ADF7 RID: 44535 RVA: 0x001A21C4 File Offset: 0x001A03C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ADF8 RID: 44536 RVA: 0x001A21CD File Offset: 0x001A03CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ADF9 RID: 44537 RVA: 0x001A2200 File Offset: 0x001A0400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0600ADFA RID: 44538 RVA: 0x001A223E File Offset: 0x001A043E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryLifeSupportUpRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600ADFB RID: 44539 RVA: 0x001A226F File Offset: 0x001A046F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ADFC RID: 44540 RVA: 0x001A2278 File Offset: 0x001A0478
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004E99 RID: 20121
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E9A RID: 20122
		public const int ActivityIdFieldNumber = 12;

		// Token: 0x04004E9B RID: 20123
		private int activityId_;
	}
}
