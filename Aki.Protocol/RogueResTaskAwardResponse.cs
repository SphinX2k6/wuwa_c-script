using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FFE RID: 4094
	[NetMessage(EMessageId.RogueResTaskAwardResponse)]
	public sealed class RogueResTaskAwardResponse : IMessage<RogueResTaskAwardResponse>, IMessage, IEquatable<RogueResTaskAwardResponse>, IDeepCloneable<RogueResTaskAwardResponse>, IBufferMessage
	{
		// Token: 0x06015EBA RID: 89786 RVA: 0x0033080D File Offset: 0x0032EA0D
		[NullableContext(1)]
		public static RogueResTaskAwardResponse Create()
		{
			return new RogueResTaskAwardResponse();
		}

		// Token: 0x1700494A RID: 18762
		// (get) Token: 0x06015EBB RID: 89787 RVA: 0x00330814 File Offset: 0x0032EA14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700494B RID: 18763
		// (get) Token: 0x06015EBC RID: 89788 RVA: 0x00330817 File Offset: 0x0032EA17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResTaskAwardResponse.Descriptor;
			}
		}

		// Token: 0x06015EBD RID: 89789 RVA: 0x0033081E File Offset: 0x0032EA1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResTaskAwardResponse()
		{
		}

		// Token: 0x06015EBE RID: 89790 RVA: 0x00330826 File Offset: 0x0032EA26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResTaskAwardResponse(RogueResTaskAwardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015EBF RID: 89791 RVA: 0x0033084B File Offset: 0x0032EA4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResTaskAwardResponse Clone()
		{
			return new RogueResTaskAwardResponse(this);
		}

		// Token: 0x1700494C RID: 18764
		// (get) Token: 0x06015EC0 RID: 89792 RVA: 0x00330853 File Offset: 0x0032EA53
		// (set) Token: 0x06015EC1 RID: 89793 RVA: 0x0033085B File Offset: 0x0032EA5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x06015EC2 RID: 89794 RVA: 0x00330864 File Offset: 0x0032EA64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResTaskAwardResponse);
		}

		// Token: 0x06015EC3 RID: 89795 RVA: 0x00330872 File Offset: 0x0032EA72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResTaskAwardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015EC4 RID: 89796 RVA: 0x003308A0 File Offset: 0x0032EAA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015EC5 RID: 89797 RVA: 0x003308E5 File Offset: 0x0032EAE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015EC6 RID: 89798 RVA: 0x003308F2 File Offset: 0x0032EAF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015EC7 RID: 89799 RVA: 0x003308FB File Offset: 0x0032EAFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015EC8 RID: 89800 RVA: 0x00330930 File Offset: 0x0032EB30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015EC9 RID: 89801 RVA: 0x0033096E File Offset: 0x0032EB6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResTaskAwardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015ECA RID: 89802 RVA: 0x0033099F File Offset: 0x0032EB9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015ECB RID: 89803 RVA: 0x003309A8 File Offset: 0x0032EBA8
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008403 RID: 33795
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008404 RID: 33796
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04008405 RID: 33797
		private ErrorCode errorCode_;
	}
}
