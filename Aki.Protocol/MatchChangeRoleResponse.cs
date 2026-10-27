using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009B6 RID: 2486
	[NetMessage(EMessageId.MatchChangeRoleResponse)]
	public sealed class MatchChangeRoleResponse : IMessage<MatchChangeRoleResponse>, IMessage, IEquatable<MatchChangeRoleResponse>, IDeepCloneable<MatchChangeRoleResponse>, IBufferMessage
	{
		// Token: 0x0600DA27 RID: 55847 RVA: 0x00200925 File Offset: 0x001FEB25
		[NullableContext(1)]
		public static MatchChangeRoleResponse Create()
		{
			return new MatchChangeRoleResponse();
		}

		// Token: 0x17002C2F RID: 11311
		// (get) Token: 0x0600DA28 RID: 55848 RVA: 0x0020092C File Offset: 0x001FEB2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C30 RID: 11312
		// (get) Token: 0x0600DA29 RID: 55849 RVA: 0x0020092F File Offset: 0x001FEB2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchChangeRoleResponse.Descriptor;
			}
		}

		// Token: 0x0600DA2A RID: 55850 RVA: 0x00200936 File Offset: 0x001FEB36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangeRoleResponse()
		{
		}

		// Token: 0x0600DA2B RID: 55851 RVA: 0x0020093E File Offset: 0x001FEB3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangeRoleResponse(MatchChangeRoleResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DA2C RID: 55852 RVA: 0x00200963 File Offset: 0x001FEB63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangeRoleResponse Clone()
		{
			return new MatchChangeRoleResponse(this);
		}

		// Token: 0x17002C31 RID: 11313
		// (get) Token: 0x0600DA2D RID: 55853 RVA: 0x0020096B File Offset: 0x001FEB6B
		// (set) Token: 0x0600DA2E RID: 55854 RVA: 0x00200973 File Offset: 0x001FEB73
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

		// Token: 0x0600DA2F RID: 55855 RVA: 0x0020097C File Offset: 0x001FEB7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchChangeRoleResponse);
		}

		// Token: 0x0600DA30 RID: 55856 RVA: 0x0020098A File Offset: 0x001FEB8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchChangeRoleResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DA31 RID: 55857 RVA: 0x002009B8 File Offset: 0x001FEBB8
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

		// Token: 0x0600DA32 RID: 55858 RVA: 0x002009FD File Offset: 0x001FEBFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DA33 RID: 55859 RVA: 0x00200A0A File Offset: 0x001FEC0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DA34 RID: 55860 RVA: 0x00200A13 File Offset: 0x001FEC13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DA35 RID: 55861 RVA: 0x00200A48 File Offset: 0x001FEC48
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

		// Token: 0x0600DA36 RID: 55862 RVA: 0x00200A86 File Offset: 0x001FEC86
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

		// Token: 0x0600DA37 RID: 55863 RVA: 0x00200AB7 File Offset: 0x001FECB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DA38 RID: 55864 RVA: 0x00200AC0 File Offset: 0x001FECC0
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005AA6 RID: 23206
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005AA7 RID: 23207
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04005AA8 RID: 23208
		private ErrorCode errorCode_;
	}
}
