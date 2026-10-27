using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ED9 RID: 3801
	[NetMessage(EMessageId.RegressBonusRequest)]
	public sealed class RegressBonusRequest : IMessage<RegressBonusRequest>, IMessage, IEquatable<RegressBonusRequest>, IDeepCloneable<RegressBonusRequest>, IBufferMessage
	{
		// Token: 0x060145F7 RID: 83447 RVA: 0x002F5C63 File Offset: 0x002F3E63
		[NullableContext(1)]
		public static RegressBonusRequest Create()
		{
			return new RegressBonusRequest();
		}

		// Token: 0x170043B9 RID: 17337
		// (get) Token: 0x060145F8 RID: 83448 RVA: 0x002F5C6A File Offset: 0x002F3E6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170043BA RID: 17338
		// (get) Token: 0x060145F9 RID: 83449 RVA: 0x002F5C6D File Offset: 0x002F3E6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RegressBonusRequest.Descriptor;
			}
		}

		// Token: 0x060145FA RID: 83450 RVA: 0x002F5C74 File Offset: 0x002F3E74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressBonusRequest()
		{
		}

		// Token: 0x060145FB RID: 83451 RVA: 0x002F5C87 File Offset: 0x002F3E87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressBonusRequest(RegressBonusRequest other) : this()
		{
			this.ids_ = other.ids_.Clone();
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060145FC RID: 83452 RVA: 0x002F5CBD File Offset: 0x002F3EBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressBonusRequest Clone()
		{
			return new RegressBonusRequest(this);
		}

		// Token: 0x170043BB RID: 17339
		// (get) Token: 0x060145FD RID: 83453 RVA: 0x002F5CC5 File Offset: 0x002F3EC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x170043BC RID: 17340
		// (get) Token: 0x060145FE RID: 83454 RVA: 0x002F5CCD File Offset: 0x002F3ECD
		// (set) Token: 0x060145FF RID: 83455 RVA: 0x002F5CD5 File Offset: 0x002F3ED5
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

		// Token: 0x06014600 RID: 83456 RVA: 0x002F5CDE File Offset: 0x002F3EDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RegressBonusRequest);
		}

		// Token: 0x06014601 RID: 83457 RVA: 0x002F5CEC File Offset: 0x002F3EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RegressBonusRequest other)
		{
			return other != null && (other == this || (this.ids_.Equals(other.ids_) && this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014602 RID: 83458 RVA: 0x002F5D3C File Offset: 0x002F3F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.ids_.GetHashCode();
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

		// Token: 0x06014603 RID: 83459 RVA: 0x002F5D89 File Offset: 0x002F3F89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014604 RID: 83460 RVA: 0x002F5D96 File Offset: 0x002F3F96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014605 RID: 83461 RVA: 0x002F5DA0 File Offset: 0x002F3FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ids_.WriteTo(ref output, RegressBonusRequest._repeated_ids_codec);
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

		// Token: 0x06014606 RID: 83462 RVA: 0x002F5DF0 File Offset: 0x002F3FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.ids_.CalculateSize(RegressBonusRequest._repeated_ids_codec);
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

		// Token: 0x06014607 RID: 83463 RVA: 0x002F5E44 File Offset: 0x002F4044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RegressBonusRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.ids_.Add(other.ids_);
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014608 RID: 83464 RVA: 0x002F5E91 File Offset: 0x002F4091
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014609 RID: 83465 RVA: 0x002F5E9C File Offset: 0x002F409C
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
				if (num != 88U && num != 90U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.ids_.AddEntriesFrom(ref input, RegressBonusRequest._repeated_ids_codec);
				}
			}
		}

		// Token: 0x04007BA6 RID: 31654
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007BA7 RID: 31655
		public const int IdsFieldNumber = 11;

		// Token: 0x04007BA8 RID: 31656
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(90U);

		// Token: 0x04007BA9 RID: 31657
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();

		// Token: 0x04007BAA RID: 31658
		public const int ActivityIdFieldNumber = 12;

		// Token: 0x04007BAB RID: 31659
		private int activityId_;
	}
}
