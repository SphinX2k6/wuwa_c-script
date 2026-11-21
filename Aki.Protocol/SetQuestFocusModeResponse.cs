using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001217 RID: 4631
	[NetMessage(EMessageId.SetQuestFocusModeResponse)]
	public sealed class SetQuestFocusModeResponse : IMessage<SetQuestFocusModeResponse>, IMessage, IEquatable<SetQuestFocusModeResponse>, IDeepCloneable<SetQuestFocusModeResponse>, IBufferMessage
	{
		// Token: 0x06018BB5 RID: 101301 RVA: 0x0039AD69 File Offset: 0x00398F69
		[NullableContext(1)]
		public static SetQuestFocusModeResponse Create()
		{
			return new SetQuestFocusModeResponse();
		}

		// Token: 0x1700537F RID: 21375
		// (get) Token: 0x06018BB6 RID: 101302 RVA: 0x0039AD70 File Offset: 0x00398F70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005380 RID: 21376
		// (get) Token: 0x06018BB7 RID: 101303 RVA: 0x0039AD73 File Offset: 0x00398F73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetQuestFocusModeResponse.Descriptor;
			}
		}

		// Token: 0x06018BB8 RID: 101304 RVA: 0x0039AD7A File Offset: 0x00398F7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetQuestFocusModeResponse()
		{
		}

		// Token: 0x06018BB9 RID: 101305 RVA: 0x0039AD82 File Offset: 0x00398F82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetQuestFocusModeResponse(SetQuestFocusModeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018BBA RID: 101306 RVA: 0x0039ADA7 File Offset: 0x00398FA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetQuestFocusModeResponse Clone()
		{
			return new SetQuestFocusModeResponse(this);
		}

		// Token: 0x17005381 RID: 21377
		// (get) Token: 0x06018BBB RID: 101307 RVA: 0x0039ADAF File Offset: 0x00398FAF
		// (set) Token: 0x06018BBC RID: 101308 RVA: 0x0039ADB7 File Offset: 0x00398FB7
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

		// Token: 0x06018BBD RID: 101309 RVA: 0x0039ADC0 File Offset: 0x00398FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetQuestFocusModeResponse);
		}

		// Token: 0x06018BBE RID: 101310 RVA: 0x0039ADCE File Offset: 0x00398FCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetQuestFocusModeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018BBF RID: 101311 RVA: 0x0039ADFC File Offset: 0x00398FFC
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

		// Token: 0x06018BC0 RID: 101312 RVA: 0x0039AE41 File Offset: 0x00399041
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018BC1 RID: 101313 RVA: 0x0039AE4E File Offset: 0x0039904E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018BC2 RID: 101314 RVA: 0x0039AE57 File Offset: 0x00399057
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018BC3 RID: 101315 RVA: 0x0039AE8C File Offset: 0x0039908C
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

		// Token: 0x06018BC4 RID: 101316 RVA: 0x0039AECA File Offset: 0x003990CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetQuestFocusModeResponse other)
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

		// Token: 0x06018BC5 RID: 101317 RVA: 0x0039AEFB File Offset: 0x003990FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018BC6 RID: 101318 RVA: 0x0039AF04 File Offset: 0x00399104
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040092C4 RID: 37572
		private UnknownFieldSet _unknownFields;

		// Token: 0x040092C5 RID: 37573
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x040092C6 RID: 37574
		private ErrorCode errorCode_;
	}
}
