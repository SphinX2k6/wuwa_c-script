using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010E4 RID: 4324
	[NetMessage(EMessageId.RollBlockResetGamePlayRequest)]
	public sealed class RollBlockResetGamePlayRequest : IMessage<RollBlockResetGamePlayRequest>, IMessage, IEquatable<RollBlockResetGamePlayRequest>, IDeepCloneable<RollBlockResetGamePlayRequest>, IBufferMessage
	{
		// Token: 0x06017105 RID: 94469 RVA: 0x00358DF0 File Offset: 0x00356FF0
		[NullableContext(1)]
		public static RollBlockResetGamePlayRequest Create()
		{
			return new RollBlockResetGamePlayRequest();
		}

		// Token: 0x17004D41 RID: 19777
		// (get) Token: 0x06017106 RID: 94470 RVA: 0x00358DF7 File Offset: 0x00356FF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D42 RID: 19778
		// (get) Token: 0x06017107 RID: 94471 RVA: 0x00358DFA File Offset: 0x00356FFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RollBlockResetGamePlayRequest.Descriptor;
			}
		}

		// Token: 0x06017108 RID: 94472 RVA: 0x00358E01 File Offset: 0x00357001
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockResetGamePlayRequest()
		{
		}

		// Token: 0x06017109 RID: 94473 RVA: 0x00358E09 File Offset: 0x00357009
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockResetGamePlayRequest(RollBlockResetGamePlayRequest other) : this()
		{
			this.incId_ = other.incId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601710A RID: 94474 RVA: 0x00358E2E File Offset: 0x0035702E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockResetGamePlayRequest Clone()
		{
			return new RollBlockResetGamePlayRequest(this);
		}

		// Token: 0x17004D43 RID: 19779
		// (get) Token: 0x0601710B RID: 94475 RVA: 0x00358E36 File Offset: 0x00357036
		// (set) Token: 0x0601710C RID: 94476 RVA: 0x00358E3E File Offset: 0x0035703E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x0601710D RID: 94477 RVA: 0x00358E47 File Offset: 0x00357047
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RollBlockResetGamePlayRequest);
		}

		// Token: 0x0601710E RID: 94478 RVA: 0x00358E55 File Offset: 0x00357055
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RollBlockResetGamePlayRequest other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601710F RID: 94479 RVA: 0x00358E84 File Offset: 0x00357084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017110 RID: 94480 RVA: 0x00358EC3 File Offset: 0x003570C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017111 RID: 94481 RVA: 0x00358ED0 File Offset: 0x003570D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017112 RID: 94482 RVA: 0x00358ED9 File Offset: 0x003570D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.IncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017113 RID: 94483 RVA: 0x00358F0C File Offset: 0x0035710C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017114 RID: 94484 RVA: 0x00358F4A File Offset: 0x0035714A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RollBlockResetGamePlayRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017115 RID: 94485 RVA: 0x00358F7B File Offset: 0x0035717B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017116 RID: 94486 RVA: 0x00358F84 File Offset: 0x00357184
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
					this.IncId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400893A RID: 35130
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400893B RID: 35131
		public const int IncIdFieldNumber = 14;

		// Token: 0x0400893C RID: 35132
		private int incId_;
	}
}
