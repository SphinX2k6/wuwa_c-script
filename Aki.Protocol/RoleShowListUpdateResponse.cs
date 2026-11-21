using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200109D RID: 4253
	[NetMessage(EMessageId.RoleShowListUpdateResponse)]
	public sealed class RoleShowListUpdateResponse : IMessage<RoleShowListUpdateResponse>, IMessage, IEquatable<RoleShowListUpdateResponse>, IDeepCloneable<RoleShowListUpdateResponse>, IBufferMessage
	{
		// Token: 0x06016BD0 RID: 93136 RVA: 0x0034E645 File Offset: 0x0034C845
		[NullableContext(1)]
		public static RoleShowListUpdateResponse Create()
		{
			return new RoleShowListUpdateResponse();
		}

		// Token: 0x17004C35 RID: 19509
		// (get) Token: 0x06016BD1 RID: 93137 RVA: 0x0034E64C File Offset: 0x0034C84C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C36 RID: 19510
		// (get) Token: 0x06016BD2 RID: 93138 RVA: 0x0034E64F File Offset: 0x0034C84F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleShowListUpdateResponse.Descriptor;
			}
		}

		// Token: 0x06016BD3 RID: 93139 RVA: 0x0034E656 File Offset: 0x0034C856
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleShowListUpdateResponse()
		{
		}

		// Token: 0x06016BD4 RID: 93140 RVA: 0x0034E65E File Offset: 0x0034C85E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleShowListUpdateResponse(RoleShowListUpdateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016BD5 RID: 93141 RVA: 0x0034E683 File Offset: 0x0034C883
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleShowListUpdateResponse Clone()
		{
			return new RoleShowListUpdateResponse(this);
		}

		// Token: 0x17004C37 RID: 19511
		// (get) Token: 0x06016BD6 RID: 93142 RVA: 0x0034E68B File Offset: 0x0034C88B
		// (set) Token: 0x06016BD7 RID: 93143 RVA: 0x0034E693 File Offset: 0x0034C893
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

		// Token: 0x06016BD8 RID: 93144 RVA: 0x0034E69C File Offset: 0x0034C89C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleShowListUpdateResponse);
		}

		// Token: 0x06016BD9 RID: 93145 RVA: 0x0034E6AA File Offset: 0x0034C8AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleShowListUpdateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016BDA RID: 93146 RVA: 0x0034E6D8 File Offset: 0x0034C8D8
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

		// Token: 0x06016BDB RID: 93147 RVA: 0x0034E71D File Offset: 0x0034C91D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016BDC RID: 93148 RVA: 0x0034E72A File Offset: 0x0034C92A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016BDD RID: 93149 RVA: 0x0034E733 File Offset: 0x0034C933
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016BDE RID: 93150 RVA: 0x0034E768 File Offset: 0x0034C968
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

		// Token: 0x06016BDF RID: 93151 RVA: 0x0034E7A6 File Offset: 0x0034C9A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleShowListUpdateResponse other)
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

		// Token: 0x06016BE0 RID: 93152 RVA: 0x0034E7D7 File Offset: 0x0034C9D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016BE1 RID: 93153 RVA: 0x0034E7E0 File Offset: 0x0034C9E0
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400883A RID: 34874
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400883B RID: 34875
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x0400883C RID: 34876
		private ErrorCode errorCode_;
	}
}
