using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009A5 RID: 2469
	[NetMessage(EMessageId.MatchChangeRoleResponse)]
	public sealed class MatchChangeRoleResponse : IMessage<MatchChangeRoleResponse>, IMessage, IEquatable<MatchChangeRoleResponse>, IDeepCloneable<MatchChangeRoleResponse>, IBufferMessage
	{
		// Token: 0x0600D90D RID: 55565 RVA: 0x001FE731 File Offset: 0x001FC931
		[NullableContext(1)]
		public static MatchChangeRoleResponse Create()
		{
			return new MatchChangeRoleResponse();
		}

		// Token: 0x17002BF1 RID: 11249
		// (get) Token: 0x0600D90E RID: 55566 RVA: 0x001FE738 File Offset: 0x001FC938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002BF2 RID: 11250
		// (get) Token: 0x0600D90F RID: 55567 RVA: 0x001FE73B File Offset: 0x001FC93B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchChangeRoleResponse.Descriptor;
			}
		}

		// Token: 0x0600D910 RID: 55568 RVA: 0x001FE742 File Offset: 0x001FC942
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangeRoleResponse()
		{
		}

		// Token: 0x0600D911 RID: 55569 RVA: 0x001FE74A File Offset: 0x001FC94A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangeRoleResponse(MatchChangeRoleResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D912 RID: 55570 RVA: 0x001FE76F File Offset: 0x001FC96F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangeRoleResponse Clone()
		{
			return new MatchChangeRoleResponse(this);
		}

		// Token: 0x17002BF3 RID: 11251
		// (get) Token: 0x0600D913 RID: 55571 RVA: 0x001FE777 File Offset: 0x001FC977
		// (set) Token: 0x0600D914 RID: 55572 RVA: 0x001FE77F File Offset: 0x001FC97F
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

		// Token: 0x0600D915 RID: 55573 RVA: 0x001FE788 File Offset: 0x001FC988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchChangeRoleResponse);
		}

		// Token: 0x0600D916 RID: 55574 RVA: 0x001FE796 File Offset: 0x001FC996
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchChangeRoleResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D917 RID: 55575 RVA: 0x001FE7C4 File Offset: 0x001FC9C4
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

		// Token: 0x0600D918 RID: 55576 RVA: 0x001FE809 File Offset: 0x001FCA09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D919 RID: 55577 RVA: 0x001FE816 File Offset: 0x001FCA16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D91A RID: 55578 RVA: 0x001FE81F File Offset: 0x001FCA1F
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

		// Token: 0x0600D91B RID: 55579 RVA: 0x001FE854 File Offset: 0x001FCA54
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

		// Token: 0x0600D91C RID: 55580 RVA: 0x001FE892 File Offset: 0x001FCA92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MatchChangeRoleResponse other)
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

		// Token: 0x0600D91D RID: 55581 RVA: 0x001FE8C3 File Offset: 0x001FCAC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D91E RID: 55582 RVA: 0x001FE8CC File Offset: 0x001FCACC
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

		// Token: 0x04005AAF RID: 23215
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005AB0 RID: 23216
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04005AB1 RID: 23217
		private ErrorCode errorCode_;
	}
}
