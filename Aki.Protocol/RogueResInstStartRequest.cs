using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FE0 RID: 4064
	[NetMessage(EMessageId.RogueResInstStartRequest)]
	public sealed class RogueResInstStartRequest : IMessage<RogueResInstStartRequest>, IMessage, IEquatable<RogueResInstStartRequest>, IDeepCloneable<RogueResInstStartRequest>, IBufferMessage
	{
		// Token: 0x06015C1B RID: 89115 RVA: 0x00329D03 File Offset: 0x00327F03
		[NullableContext(1)]
		public static RogueResInstStartRequest Create()
		{
			return new RogueResInstStartRequest();
		}

		// Token: 0x170048AA RID: 18602
		// (get) Token: 0x06015C1C RID: 89116 RVA: 0x00329D0A File Offset: 0x00327F0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170048AB RID: 18603
		// (get) Token: 0x06015C1D RID: 89117 RVA: 0x00329D0D File Offset: 0x00327F0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResInstStartRequest.Descriptor;
			}
		}

		// Token: 0x06015C1E RID: 89118 RVA: 0x00329D14 File Offset: 0x00327F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResInstStartRequest()
		{
		}

		// Token: 0x06015C1F RID: 89119 RVA: 0x00329D1C File Offset: 0x00327F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResInstStartRequest(RogueResInstStartRequest other) : this()
		{
			this.instId_ = other.instId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015C20 RID: 89120 RVA: 0x00329D41 File Offset: 0x00327F41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResInstStartRequest Clone()
		{
			return new RogueResInstStartRequest(this);
		}

		// Token: 0x170048AC RID: 18604
		// (get) Token: 0x06015C21 RID: 89121 RVA: 0x00329D49 File Offset: 0x00327F49
		// (set) Token: 0x06015C22 RID: 89122 RVA: 0x00329D51 File Offset: 0x00327F51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x06015C23 RID: 89123 RVA: 0x00329D5A File Offset: 0x00327F5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResInstStartRequest);
		}

		// Token: 0x06015C24 RID: 89124 RVA: 0x00329D68 File Offset: 0x00327F68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResInstStartRequest other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015C25 RID: 89125 RVA: 0x00329D98 File Offset: 0x00327F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015C26 RID: 89126 RVA: 0x00329DD7 File Offset: 0x00327FD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015C27 RID: 89127 RVA: 0x00329DE4 File Offset: 0x00327FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015C28 RID: 89128 RVA: 0x00329DED File Offset: 0x00327FED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.InstId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015C29 RID: 89129 RVA: 0x00329E20 File Offset: 0x00328020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015C2A RID: 89130 RVA: 0x00329E5E File Offset: 0x0032805E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResInstStartRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015C2B RID: 89131 RVA: 0x00329E8F File Offset: 0x0032808F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015C2C RID: 89132 RVA: 0x00329E98 File Offset: 0x00328098
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.InstId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008319 RID: 33561
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400831A RID: 33562
		public const int InstIdFieldNumber = 2;

		// Token: 0x0400831B RID: 33563
		private int instId_;
	}
}
