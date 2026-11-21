using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200110C RID: 4364
	[NetMessage(EMessageId.RoleUpdateDevelopTargetResponse)]
	public sealed class RoleUpdateDevelopTargetResponse : IMessage<RoleUpdateDevelopTargetResponse>, IMessage, IEquatable<RoleUpdateDevelopTargetResponse>, IDeepCloneable<RoleUpdateDevelopTargetResponse>, IBufferMessage
	{
		// Token: 0x06017537 RID: 95543 RVA: 0x00364F47 File Offset: 0x00363147
		[NullableContext(1)]
		public static RoleUpdateDevelopTargetResponse Create()
		{
			return new RoleUpdateDevelopTargetResponse();
		}

		// Token: 0x17004E60 RID: 20064
		// (get) Token: 0x06017538 RID: 95544 RVA: 0x00364F4E File Offset: 0x0036314E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E61 RID: 20065
		// (get) Token: 0x06017539 RID: 95545 RVA: 0x00364F51 File Offset: 0x00363151
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleUpdateDevelopTargetResponse.Descriptor;
			}
		}

		// Token: 0x0601753A RID: 95546 RVA: 0x00364F58 File Offset: 0x00363158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleUpdateDevelopTargetResponse()
		{
		}

		// Token: 0x0601753B RID: 95547 RVA: 0x00364F60 File Offset: 0x00363160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleUpdateDevelopTargetResponse(RoleUpdateDevelopTargetResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601753C RID: 95548 RVA: 0x00364F85 File Offset: 0x00363185
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleUpdateDevelopTargetResponse Clone()
		{
			return new RoleUpdateDevelopTargetResponse(this);
		}

		// Token: 0x17004E62 RID: 20066
		// (get) Token: 0x0601753D RID: 95549 RVA: 0x00364F8D File Offset: 0x0036318D
		// (set) Token: 0x0601753E RID: 95550 RVA: 0x00364F95 File Offset: 0x00363195
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

		// Token: 0x0601753F RID: 95551 RVA: 0x00364F9E File Offset: 0x0036319E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleUpdateDevelopTargetResponse);
		}

		// Token: 0x06017540 RID: 95552 RVA: 0x00364FAC File Offset: 0x003631AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleUpdateDevelopTargetResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017541 RID: 95553 RVA: 0x00364FDC File Offset: 0x003631DC
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

		// Token: 0x06017542 RID: 95554 RVA: 0x00365021 File Offset: 0x00363221
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017543 RID: 95555 RVA: 0x0036502E File Offset: 0x0036322E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017544 RID: 95556 RVA: 0x00365037 File Offset: 0x00363237
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017545 RID: 95557 RVA: 0x0036506C File Offset: 0x0036326C
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

		// Token: 0x06017546 RID: 95558 RVA: 0x003650AA File Offset: 0x003632AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleUpdateDevelopTargetResponse other)
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

		// Token: 0x06017547 RID: 95559 RVA: 0x003650DB File Offset: 0x003632DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017548 RID: 95560 RVA: 0x003650E4 File Offset: 0x003632E4
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008B69 RID: 35689
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008B6A RID: 35690
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04008B6B RID: 35691
		private ErrorCode errorCode_;
	}
}
