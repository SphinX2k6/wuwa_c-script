using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010AD RID: 4269
	[NetMessage(EMessageId.RoleShowListUpdateResponse)]
	public sealed class RoleShowListUpdateResponse : IMessage<RoleShowListUpdateResponse>, IMessage, IEquatable<RoleShowListUpdateResponse>, IDeepCloneable<RoleShowListUpdateResponse>, IBufferMessage
	{
		// Token: 0x06016CB5 RID: 93365 RVA: 0x0034FD21 File Offset: 0x0034DF21
		[NullableContext(1)]
		public static RoleShowListUpdateResponse Create()
		{
			return new RoleShowListUpdateResponse();
		}

		// Token: 0x17004C5F RID: 19551
		// (get) Token: 0x06016CB6 RID: 93366 RVA: 0x0034FD28 File Offset: 0x0034DF28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C60 RID: 19552
		// (get) Token: 0x06016CB7 RID: 93367 RVA: 0x0034FD2B File Offset: 0x0034DF2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleShowListUpdateResponse.Descriptor;
			}
		}

		// Token: 0x06016CB8 RID: 93368 RVA: 0x0034FD32 File Offset: 0x0034DF32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleShowListUpdateResponse()
		{
		}

		// Token: 0x06016CB9 RID: 93369 RVA: 0x0034FD3A File Offset: 0x0034DF3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleShowListUpdateResponse(RoleShowListUpdateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016CBA RID: 93370 RVA: 0x0034FD5F File Offset: 0x0034DF5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleShowListUpdateResponse Clone()
		{
			return new RoleShowListUpdateResponse(this);
		}

		// Token: 0x17004C61 RID: 19553
		// (get) Token: 0x06016CBB RID: 93371 RVA: 0x0034FD67 File Offset: 0x0034DF67
		// (set) Token: 0x06016CBC RID: 93372 RVA: 0x0034FD6F File Offset: 0x0034DF6F
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

		// Token: 0x06016CBD RID: 93373 RVA: 0x0034FD78 File Offset: 0x0034DF78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleShowListUpdateResponse);
		}

		// Token: 0x06016CBE RID: 93374 RVA: 0x0034FD86 File Offset: 0x0034DF86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleShowListUpdateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016CBF RID: 93375 RVA: 0x0034FDB4 File Offset: 0x0034DFB4
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

		// Token: 0x06016CC0 RID: 93376 RVA: 0x0034FDF9 File Offset: 0x0034DFF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016CC1 RID: 93377 RVA: 0x0034FE06 File Offset: 0x0034E006
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016CC2 RID: 93378 RVA: 0x0034FE0F File Offset: 0x0034E00F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016CC3 RID: 93379 RVA: 0x0034FE44 File Offset: 0x0034E044
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

		// Token: 0x06016CC4 RID: 93380 RVA: 0x0034FE82 File Offset: 0x0034E082
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

		// Token: 0x06016CC5 RID: 93381 RVA: 0x0034FEB3 File Offset: 0x0034E0B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016CC6 RID: 93382 RVA: 0x0034FEBC File Offset: 0x0034E0BC
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008810 RID: 34832
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008811 RID: 34833
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04008812 RID: 34834
		private ErrorCode errorCode_;
	}
}
