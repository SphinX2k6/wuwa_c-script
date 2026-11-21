using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001404 RID: 5124
	[NetMessage(EMessageId.TotalTopUpScoreInfoRequest)]
	public sealed class TotalTopUpScoreInfoRequest : IMessage<TotalTopUpScoreInfoRequest>, IMessage, IEquatable<TotalTopUpScoreInfoRequest>, IDeepCloneable<TotalTopUpScoreInfoRequest>, IBufferMessage
	{
		// Token: 0x0601B3DD RID: 111581 RVA: 0x003F67CC File Offset: 0x003F49CC
		[NullableContext(1)]
		public static TotalTopUpScoreInfoRequest Create()
		{
			return new TotalTopUpScoreInfoRequest();
		}

		// Token: 0x17005C37 RID: 23607
		// (get) Token: 0x0601B3DE RID: 111582 RVA: 0x003F67D3 File Offset: 0x003F49D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C38 RID: 23608
		// (get) Token: 0x0601B3DF RID: 111583 RVA: 0x003F67D6 File Offset: 0x003F49D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TotalTopUpScoreInfoRequest.Descriptor;
			}
		}

		// Token: 0x0601B3E0 RID: 111584 RVA: 0x003F67DD File Offset: 0x003F49DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TotalTopUpScoreInfoRequest()
		{
		}

		// Token: 0x0601B3E1 RID: 111585 RVA: 0x003F67E5 File Offset: 0x003F49E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TotalTopUpScoreInfoRequest(TotalTopUpScoreInfoRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B3E2 RID: 111586 RVA: 0x003F680A File Offset: 0x003F4A0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TotalTopUpScoreInfoRequest Clone()
		{
			return new TotalTopUpScoreInfoRequest(this);
		}

		// Token: 0x17005C39 RID: 23609
		// (get) Token: 0x0601B3E3 RID: 111587 RVA: 0x003F6812 File Offset: 0x003F4A12
		// (set) Token: 0x0601B3E4 RID: 111588 RVA: 0x003F681A File Offset: 0x003F4A1A
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

		// Token: 0x0601B3E5 RID: 111589 RVA: 0x003F6823 File Offset: 0x003F4A23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TotalTopUpScoreInfoRequest);
		}

		// Token: 0x0601B3E6 RID: 111590 RVA: 0x003F6831 File Offset: 0x003F4A31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TotalTopUpScoreInfoRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B3E7 RID: 111591 RVA: 0x003F6860 File Offset: 0x003F4A60
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

		// Token: 0x0601B3E8 RID: 111592 RVA: 0x003F689F File Offset: 0x003F4A9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B3E9 RID: 111593 RVA: 0x003F68AC File Offset: 0x003F4AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B3EA RID: 111594 RVA: 0x003F68B5 File Offset: 0x003F4AB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B3EB RID: 111595 RVA: 0x003F68E8 File Offset: 0x003F4AE8
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

		// Token: 0x0601B3EC RID: 111596 RVA: 0x003F6926 File Offset: 0x003F4B26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TotalTopUpScoreInfoRequest other)
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

		// Token: 0x0601B3ED RID: 111597 RVA: 0x003F6957 File Offset: 0x003F4B57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B3EE RID: 111598 RVA: 0x003F6960 File Offset: 0x003F4B60
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009ECC RID: 40652
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009ECD RID: 40653
		public const int ActivityIdFieldNumber = 6;

		// Token: 0x04009ECE RID: 40654
		private int activityId_;
	}
}
