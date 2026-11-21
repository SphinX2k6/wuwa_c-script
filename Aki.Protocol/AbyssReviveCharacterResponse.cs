using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200003C RID: 60
	[NetMessage(EMessageId.AbyssReviveCharacterResponse)]
	public sealed class AbyssReviveCharacterResponse : IMessage<AbyssReviveCharacterResponse>, IMessage, IEquatable<AbyssReviveCharacterResponse>, IDeepCloneable<AbyssReviveCharacterResponse>, IBufferMessage
	{
		// Token: 0x0600136B RID: 4971 RVA: 0x00034BB4 File Offset: 0x00032DB4
		[NullableContext(1)]
		public static AbyssReviveCharacterResponse Create()
		{
			return new AbyssReviveCharacterResponse();
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x0600136C RID: 4972 RVA: 0x00034BBB File Offset: 0x00032DBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600136D RID: 4973 RVA: 0x00034BBE File Offset: 0x00032DBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssReviveCharacterResponse.Descriptor;
			}
		}

		// Token: 0x0600136E RID: 4974 RVA: 0x00034BC5 File Offset: 0x00032DC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssReviveCharacterResponse()
		{
		}

		// Token: 0x0600136F RID: 4975 RVA: 0x00034BCD File Offset: 0x00032DCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssReviveCharacterResponse(AbyssReviveCharacterResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001370 RID: 4976 RVA: 0x00034BF2 File Offset: 0x00032DF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssReviveCharacterResponse Clone()
		{
			return new AbyssReviveCharacterResponse(this);
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06001371 RID: 4977 RVA: 0x00034BFA File Offset: 0x00032DFA
		// (set) Token: 0x06001372 RID: 4978 RVA: 0x00034C02 File Offset: 0x00032E02
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

		// Token: 0x06001373 RID: 4979 RVA: 0x00034C0B File Offset: 0x00032E0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssReviveCharacterResponse);
		}

		// Token: 0x06001374 RID: 4980 RVA: 0x00034C19 File Offset: 0x00032E19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssReviveCharacterResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001375 RID: 4981 RVA: 0x00034C48 File Offset: 0x00032E48
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

		// Token: 0x06001376 RID: 4982 RVA: 0x00034C8D File Offset: 0x00032E8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001377 RID: 4983 RVA: 0x00034C9A File Offset: 0x00032E9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001378 RID: 4984 RVA: 0x00034CA3 File Offset: 0x00032EA3
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

		// Token: 0x06001379 RID: 4985 RVA: 0x00034CD8 File Offset: 0x00032ED8
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

		// Token: 0x0600137A RID: 4986 RVA: 0x00034D16 File Offset: 0x00032F16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssReviveCharacterResponse other)
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

		// Token: 0x0600137B RID: 4987 RVA: 0x00034D47 File Offset: 0x00032F47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600137C RID: 4988 RVA: 0x00034D50 File Offset: 0x00032F50
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

		// Token: 0x0400205A RID: 8282
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400205B RID: 8283
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x0400205C RID: 8284
		private ErrorCode errorCode_;
	}
}
