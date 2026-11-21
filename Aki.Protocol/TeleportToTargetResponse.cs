using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013B3 RID: 5043
	[NetMessage(EMessageId.TeleportToTargetResponse)]
	public sealed class TeleportToTargetResponse : IMessage<TeleportToTargetResponse>, IMessage, IEquatable<TeleportToTargetResponse>, IDeepCloneable<TeleportToTargetResponse>, IBufferMessage
	{
		// Token: 0x0601AD64 RID: 109924 RVA: 0x003E86E3 File Offset: 0x003E68E3
		[NullableContext(1)]
		public static TeleportToTargetResponse Create()
		{
			return new TeleportToTargetResponse();
		}

		// Token: 0x17005ADD RID: 23261
		// (get) Token: 0x0601AD65 RID: 109925 RVA: 0x003E86EA File Offset: 0x003E68EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005ADE RID: 23262
		// (get) Token: 0x0601AD66 RID: 109926 RVA: 0x003E86ED File Offset: 0x003E68ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeleportToTargetResponse.Descriptor;
			}
		}

		// Token: 0x0601AD67 RID: 109927 RVA: 0x003E86F4 File Offset: 0x003E68F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportToTargetResponse()
		{
		}

		// Token: 0x0601AD68 RID: 109928 RVA: 0x003E86FC File Offset: 0x003E68FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportToTargetResponse(TeleportToTargetResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AD69 RID: 109929 RVA: 0x003E8721 File Offset: 0x003E6921
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportToTargetResponse Clone()
		{
			return new TeleportToTargetResponse(this);
		}

		// Token: 0x17005ADF RID: 23263
		// (get) Token: 0x0601AD6A RID: 109930 RVA: 0x003E8729 File Offset: 0x003E6929
		// (set) Token: 0x0601AD6B RID: 109931 RVA: 0x003E8731 File Offset: 0x003E6931
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

		// Token: 0x0601AD6C RID: 109932 RVA: 0x003E873A File Offset: 0x003E693A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeleportToTargetResponse);
		}

		// Token: 0x0601AD6D RID: 109933 RVA: 0x003E8748 File Offset: 0x003E6948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeleportToTargetResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AD6E RID: 109934 RVA: 0x003E8778 File Offset: 0x003E6978
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

		// Token: 0x0601AD6F RID: 109935 RVA: 0x003E87BD File Offset: 0x003E69BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AD70 RID: 109936 RVA: 0x003E87CA File Offset: 0x003E69CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AD71 RID: 109937 RVA: 0x003E87D3 File Offset: 0x003E69D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AD72 RID: 109938 RVA: 0x003E8808 File Offset: 0x003E6A08
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

		// Token: 0x0601AD73 RID: 109939 RVA: 0x003E8846 File Offset: 0x003E6A46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeleportToTargetResponse other)
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

		// Token: 0x0601AD74 RID: 109940 RVA: 0x003E8877 File Offset: 0x003E6A77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AD75 RID: 109941 RVA: 0x003E8880 File Offset: 0x003E6A80
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009CF9 RID: 40185
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009CFA RID: 40186
		public const int ErrCodeFieldNumber = 15;

		// Token: 0x04009CFB RID: 40187
		private ErrorCode errCode_;
	}
}
