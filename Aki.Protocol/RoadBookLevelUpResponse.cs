using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F5F RID: 3935
	[NetMessage(EMessageId.RoadBookLevelUpResponse)]
	public sealed class RoadBookLevelUpResponse : IMessage<RoadBookLevelUpResponse>, IMessage, IEquatable<RoadBookLevelUpResponse>, IDeepCloneable<RoadBookLevelUpResponse>, IBufferMessage
	{
		// Token: 0x06015118 RID: 86296 RVA: 0x0030EA4A File Offset: 0x0030CC4A
		[NullableContext(1)]
		public static RoadBookLevelUpResponse Create()
		{
			return new RoadBookLevelUpResponse();
		}

		// Token: 0x1700461B RID: 17947
		// (get) Token: 0x06015119 RID: 86297 RVA: 0x0030EA51 File Offset: 0x0030CC51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700461C RID: 17948
		// (get) Token: 0x0601511A RID: 86298 RVA: 0x0030EA54 File Offset: 0x0030CC54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoadBookLevelUpResponse.Descriptor;
			}
		}

		// Token: 0x0601511B RID: 86299 RVA: 0x0030EA5B File Offset: 0x0030CC5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookLevelUpResponse()
		{
		}

		// Token: 0x0601511C RID: 86300 RVA: 0x0030EA63 File Offset: 0x0030CC63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookLevelUpResponse(RoadBookLevelUpResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601511D RID: 86301 RVA: 0x0030EA88 File Offset: 0x0030CC88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookLevelUpResponse Clone()
		{
			return new RoadBookLevelUpResponse(this);
		}

		// Token: 0x1700461D RID: 17949
		// (get) Token: 0x0601511E RID: 86302 RVA: 0x0030EA90 File Offset: 0x0030CC90
		// (set) Token: 0x0601511F RID: 86303 RVA: 0x0030EA98 File Offset: 0x0030CC98
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

		// Token: 0x06015120 RID: 86304 RVA: 0x0030EAA1 File Offset: 0x0030CCA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoadBookLevelUpResponse);
		}

		// Token: 0x06015121 RID: 86305 RVA: 0x0030EAAF File Offset: 0x0030CCAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoadBookLevelUpResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015122 RID: 86306 RVA: 0x0030EAE0 File Offset: 0x0030CCE0
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

		// Token: 0x06015123 RID: 86307 RVA: 0x0030EB25 File Offset: 0x0030CD25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015124 RID: 86308 RVA: 0x0030EB32 File Offset: 0x0030CD32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015125 RID: 86309 RVA: 0x0030EB3B File Offset: 0x0030CD3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015126 RID: 86310 RVA: 0x0030EB70 File Offset: 0x0030CD70
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

		// Token: 0x06015127 RID: 86311 RVA: 0x0030EBAE File Offset: 0x0030CDAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoadBookLevelUpResponse other)
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

		// Token: 0x06015128 RID: 86312 RVA: 0x0030EBDF File Offset: 0x0030CDDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015129 RID: 86313 RVA: 0x0030EBE8 File Offset: 0x0030CDE8
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007F42 RID: 32578
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007F43 RID: 32579
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04007F44 RID: 32580
		private ErrorCode errorCode_;
	}
}
