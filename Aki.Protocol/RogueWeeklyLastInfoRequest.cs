using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200103D RID: 4157
	[NetMessage(EMessageId.RogueWeeklyLastInfoRequest)]
	public sealed class RogueWeeklyLastInfoRequest : IMessage<RogueWeeklyLastInfoRequest>, IMessage, IEquatable<RogueWeeklyLastInfoRequest>, IDeepCloneable<RogueWeeklyLastInfoRequest>, IBufferMessage
	{
		// Token: 0x06016374 RID: 90996 RVA: 0x0033A494 File Offset: 0x00338694
		[NullableContext(1)]
		public static RogueWeeklyLastInfoRequest Create()
		{
			return new RogueWeeklyLastInfoRequest();
		}

		// Token: 0x17004A46 RID: 19014
		// (get) Token: 0x06016375 RID: 90997 RVA: 0x0033A49B File Offset: 0x0033869B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A47 RID: 19015
		// (get) Token: 0x06016376 RID: 90998 RVA: 0x0033A49E File Offset: 0x0033869E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyLastInfoRequest.Descriptor;
			}
		}

		// Token: 0x06016377 RID: 90999 RVA: 0x0033A4A5 File Offset: 0x003386A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyLastInfoRequest()
		{
		}

		// Token: 0x06016378 RID: 91000 RVA: 0x0033A4AD File Offset: 0x003386AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyLastInfoRequest(RogueWeeklyLastInfoRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016379 RID: 91001 RVA: 0x0033A4D2 File Offset: 0x003386D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyLastInfoRequest Clone()
		{
			return new RogueWeeklyLastInfoRequest(this);
		}

		// Token: 0x17004A48 RID: 19016
		// (get) Token: 0x0601637A RID: 91002 RVA: 0x0033A4DA File Offset: 0x003386DA
		// (set) Token: 0x0601637B RID: 91003 RVA: 0x0033A4E2 File Offset: 0x003386E2
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

		// Token: 0x0601637C RID: 91004 RVA: 0x0033A4EB File Offset: 0x003386EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyLastInfoRequest);
		}

		// Token: 0x0601637D RID: 91005 RVA: 0x0033A4F9 File Offset: 0x003386F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyLastInfoRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601637E RID: 91006 RVA: 0x0033A528 File Offset: 0x00338728
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

		// Token: 0x0601637F RID: 91007 RVA: 0x0033A567 File Offset: 0x00338767
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016380 RID: 91008 RVA: 0x0033A574 File Offset: 0x00338774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016381 RID: 91009 RVA: 0x0033A57D File Offset: 0x0033877D
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

		// Token: 0x06016382 RID: 91010 RVA: 0x0033A5B0 File Offset: 0x003387B0
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

		// Token: 0x06016383 RID: 91011 RVA: 0x0033A5EE File Offset: 0x003387EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWeeklyLastInfoRequest other)
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

		// Token: 0x06016384 RID: 91012 RVA: 0x0033A61F File Offset: 0x0033881F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016385 RID: 91013 RVA: 0x0033A628 File Offset: 0x00338828
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

		// Token: 0x040084F3 RID: 34035
		private UnknownFieldSet _unknownFields;

		// Token: 0x040084F4 RID: 34036
		public const int ActivityIdFieldNumber = 12;

		// Token: 0x040084F5 RID: 34037
		private int activityId_;
	}
}
