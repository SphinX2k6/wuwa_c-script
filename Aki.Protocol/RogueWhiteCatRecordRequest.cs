using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001042 RID: 4162
	[NetMessage(EMessageId.RogueWhiteCatRecordRequest)]
	public sealed class RogueWhiteCatRecordRequest : IMessage<RogueWhiteCatRecordRequest>, IMessage, IEquatable<RogueWhiteCatRecordRequest>, IDeepCloneable<RogueWhiteCatRecordRequest>, IBufferMessage
	{
		// Token: 0x0601644B RID: 91211 RVA: 0x0033D051 File Offset: 0x0033B251
		[NullableContext(1)]
		public static RogueWhiteCatRecordRequest Create()
		{
			return new RogueWhiteCatRecordRequest();
		}

		// Token: 0x17004A81 RID: 19073
		// (get) Token: 0x0601644C RID: 91212 RVA: 0x0033D058 File Offset: 0x0033B258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A82 RID: 19074
		// (get) Token: 0x0601644D RID: 91213 RVA: 0x0033D05B File Offset: 0x0033B25B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWhiteCatRecordRequest.Descriptor;
			}
		}

		// Token: 0x0601644E RID: 91214 RVA: 0x0033D062 File Offset: 0x0033B262
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWhiteCatRecordRequest()
		{
		}

		// Token: 0x0601644F RID: 91215 RVA: 0x0033D06A File Offset: 0x0033B26A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWhiteCatRecordRequest(RogueWhiteCatRecordRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.value_ = other.value_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016450 RID: 91216 RVA: 0x0033D09B File Offset: 0x0033B29B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWhiteCatRecordRequest Clone()
		{
			return new RogueWhiteCatRecordRequest(this);
		}

		// Token: 0x17004A83 RID: 19075
		// (get) Token: 0x06016451 RID: 91217 RVA: 0x0033D0A3 File Offset: 0x0033B2A3
		// (set) Token: 0x06016452 RID: 91218 RVA: 0x0033D0AB File Offset: 0x0033B2AB
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

		// Token: 0x17004A84 RID: 19076
		// (get) Token: 0x06016453 RID: 91219 RVA: 0x0033D0B4 File Offset: 0x0033B2B4
		// (set) Token: 0x06016454 RID: 91220 RVA: 0x0033D0BC File Offset: 0x0033B2BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Value
		{
			get
			{
				return this.value_;
			}
			set
			{
				this.value_ = value;
			}
		}

		// Token: 0x06016455 RID: 91221 RVA: 0x0033D0C5 File Offset: 0x0033B2C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWhiteCatRecordRequest);
		}

		// Token: 0x06016456 RID: 91222 RVA: 0x0033D0D3 File Offset: 0x0033B2D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWhiteCatRecordRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.Value == other.Value && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016457 RID: 91223 RVA: 0x0033D114 File Offset: 0x0033B314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.Value != 0)
			{
				num ^= this.Value.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016458 RID: 91224 RVA: 0x0033D16C File Offset: 0x0033B36C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016459 RID: 91225 RVA: 0x0033D179 File Offset: 0x0033B379
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601645A RID: 91226 RVA: 0x0033D184 File Offset: 0x0033B384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ActivityId);
			}
			if (this.Value != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.Value);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601645B RID: 91227 RVA: 0x0033D1E0 File Offset: 0x0033B3E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.Value != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Value);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601645C RID: 91228 RVA: 0x0033D238 File Offset: 0x0033B438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWhiteCatRecordRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.Value != 0)
			{
				this.Value = other.Value;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601645D RID: 91229 RVA: 0x0033D288 File Offset: 0x0033B488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601645E RID: 91230 RVA: 0x0033D294 File Offset: 0x0033B494
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
				if (num != 24U)
				{
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Value = input.ReadInt32();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040085B6 RID: 34230
		private UnknownFieldSet _unknownFields;

		// Token: 0x040085B7 RID: 34231
		public const int ActivityIdFieldNumber = 3;

		// Token: 0x040085B8 RID: 34232
		private int activityId_;

		// Token: 0x040085B9 RID: 34233
		public const int ValueFieldNumber = 8;

		// Token: 0x040085BA RID: 34234
		private int value_;
	}
}
