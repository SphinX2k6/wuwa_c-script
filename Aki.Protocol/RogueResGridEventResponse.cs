using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FE7 RID: 4071
	[NetMessage(EMessageId.RogueResGridEventResponse)]
	public sealed class RogueResGridEventResponse : IMessage<RogueResGridEventResponse>, IMessage, IEquatable<RogueResGridEventResponse>, IDeepCloneable<RogueResGridEventResponse>, IBufferMessage
	{
		// Token: 0x06015C33 RID: 89139 RVA: 0x0032910C File Offset: 0x0032730C
		[NullableContext(1)]
		public static RogueResGridEventResponse Create()
		{
			return new RogueResGridEventResponse();
		}

		// Token: 0x170048A2 RID: 18594
		// (get) Token: 0x06015C34 RID: 89140 RVA: 0x00329113 File Offset: 0x00327313
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170048A3 RID: 18595
		// (get) Token: 0x06015C35 RID: 89141 RVA: 0x00329116 File Offset: 0x00327316
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResGridEventResponse.Descriptor;
			}
		}

		// Token: 0x06015C36 RID: 89142 RVA: 0x0032911D File Offset: 0x0032731D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGridEventResponse()
		{
		}

		// Token: 0x06015C37 RID: 89143 RVA: 0x00329125 File Offset: 0x00327325
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGridEventResponse(RogueResGridEventResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015C38 RID: 89144 RVA: 0x0032914A File Offset: 0x0032734A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGridEventResponse Clone()
		{
			return new RogueResGridEventResponse(this);
		}

		// Token: 0x170048A4 RID: 18596
		// (get) Token: 0x06015C39 RID: 89145 RVA: 0x00329152 File Offset: 0x00327352
		// (set) Token: 0x06015C3A RID: 89146 RVA: 0x0032915A File Offset: 0x0032735A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x06015C3B RID: 89147 RVA: 0x00329163 File Offset: 0x00327363
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResGridEventResponse);
		}

		// Token: 0x06015C3C RID: 89148 RVA: 0x00329171 File Offset: 0x00327371
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResGridEventResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015C3D RID: 89149 RVA: 0x003291A0 File Offset: 0x003273A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015C3E RID: 89150 RVA: 0x003291E5 File Offset: 0x003273E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015C3F RID: 89151 RVA: 0x003291F2 File Offset: 0x003273F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015C40 RID: 89152 RVA: 0x003291FB File Offset: 0x003273FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015C41 RID: 89153 RVA: 0x00329230 File Offset: 0x00327430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015C42 RID: 89154 RVA: 0x0032926E File Offset: 0x0032746E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResGridEventResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015C43 RID: 89155 RVA: 0x0032929F File Offset: 0x0032749F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015C44 RID: 89156 RVA: 0x003292A8 File Offset: 0x003274A8
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
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400829E RID: 33438
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400829F RID: 33439
		public const int ErrCodeFieldNumber = 2;

		// Token: 0x040082A0 RID: 33440
		private ErrorCode errCode_;
	}
}
