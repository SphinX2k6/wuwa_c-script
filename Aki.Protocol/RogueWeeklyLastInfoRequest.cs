using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200102D RID: 4141
	[NetMessage(EMessageId.RogueWeeklyLastInfoRequest)]
	public sealed class RogueWeeklyLastInfoRequest : IMessage<RogueWeeklyLastInfoRequest>, IMessage, IEquatable<RogueWeeklyLastInfoRequest>, IDeepCloneable<RogueWeeklyLastInfoRequest>, IBufferMessage
	{
		// Token: 0x0601628F RID: 90767 RVA: 0x00338DC4 File Offset: 0x00336FC4
		[NullableContext(1)]
		public static RogueWeeklyLastInfoRequest Create()
		{
			return new RogueWeeklyLastInfoRequest();
		}

		// Token: 0x17004A1C RID: 18972
		// (get) Token: 0x06016290 RID: 90768 RVA: 0x00338DCB File Offset: 0x00336FCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A1D RID: 18973
		// (get) Token: 0x06016291 RID: 90769 RVA: 0x00338DCE File Offset: 0x00336FCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyLastInfoRequest.Descriptor;
			}
		}

		// Token: 0x06016292 RID: 90770 RVA: 0x00338DD5 File Offset: 0x00336FD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyLastInfoRequest()
		{
		}

		// Token: 0x06016293 RID: 90771 RVA: 0x00338DDD File Offset: 0x00336FDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyLastInfoRequest(RogueWeeklyLastInfoRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016294 RID: 90772 RVA: 0x00338E02 File Offset: 0x00337002
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyLastInfoRequest Clone()
		{
			return new RogueWeeklyLastInfoRequest(this);
		}

		// Token: 0x17004A1E RID: 18974
		// (get) Token: 0x06016295 RID: 90773 RVA: 0x00338E0A File Offset: 0x0033700A
		// (set) Token: 0x06016296 RID: 90774 RVA: 0x00338E12 File Offset: 0x00337012
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

		// Token: 0x06016297 RID: 90775 RVA: 0x00338E1B File Offset: 0x0033701B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyLastInfoRequest);
		}

		// Token: 0x06016298 RID: 90776 RVA: 0x00338E29 File Offset: 0x00337029
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyLastInfoRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016299 RID: 90777 RVA: 0x00338E58 File Offset: 0x00337058
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

		// Token: 0x0601629A RID: 90778 RVA: 0x00338E97 File Offset: 0x00337097
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601629B RID: 90779 RVA: 0x00338EA4 File Offset: 0x003370A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601629C RID: 90780 RVA: 0x00338EAD File Offset: 0x003370AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601629D RID: 90781 RVA: 0x00338EE0 File Offset: 0x003370E0
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

		// Token: 0x0601629E RID: 90782 RVA: 0x00338F1E File Offset: 0x0033711E
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

		// Token: 0x0601629F RID: 90783 RVA: 0x00338F4F File Offset: 0x0033714F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060162A0 RID: 90784 RVA: 0x00338F58 File Offset: 0x00337158
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400851D RID: 34077
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400851E RID: 34078
		public const int ActivityIdFieldNumber = 14;

		// Token: 0x0400851F RID: 34079
		private int activityId_;
	}
}
