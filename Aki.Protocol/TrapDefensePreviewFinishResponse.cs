using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014A8 RID: 5288
	[NetMessage(EMessageId.TrapDefensePreviewFinishResponse)]
	public sealed class TrapDefensePreviewFinishResponse : IMessage<TrapDefensePreviewFinishResponse>, IMessage, IEquatable<TrapDefensePreviewFinishResponse>, IDeepCloneable<TrapDefensePreviewFinishResponse>, IBufferMessage
	{
		// Token: 0x0601C0FF RID: 114943 RVA: 0x00412F0E File Offset: 0x0041110E
		[NullableContext(1)]
		public static TrapDefensePreviewFinishResponse Create()
		{
			return new TrapDefensePreviewFinishResponse();
		}

		// Token: 0x17005EFA RID: 24314
		// (get) Token: 0x0601C100 RID: 114944 RVA: 0x00412F15 File Offset: 0x00411115
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005EFB RID: 24315
		// (get) Token: 0x0601C101 RID: 114945 RVA: 0x00412F18 File Offset: 0x00411118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefensePreviewFinishResponse.Descriptor;
			}
		}

		// Token: 0x0601C102 RID: 114946 RVA: 0x00412F1F File Offset: 0x0041111F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefensePreviewFinishResponse()
		{
		}

		// Token: 0x0601C103 RID: 114947 RVA: 0x00412F27 File Offset: 0x00411127
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefensePreviewFinishResponse(TrapDefensePreviewFinishResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C104 RID: 114948 RVA: 0x00412F4C File Offset: 0x0041114C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefensePreviewFinishResponse Clone()
		{
			return new TrapDefensePreviewFinishResponse(this);
		}

		// Token: 0x17005EFC RID: 24316
		// (get) Token: 0x0601C105 RID: 114949 RVA: 0x00412F54 File Offset: 0x00411154
		// (set) Token: 0x0601C106 RID: 114950 RVA: 0x00412F5C File Offset: 0x0041115C
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

		// Token: 0x0601C107 RID: 114951 RVA: 0x00412F65 File Offset: 0x00411165
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefensePreviewFinishResponse);
		}

		// Token: 0x0601C108 RID: 114952 RVA: 0x00412F73 File Offset: 0x00411173
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefensePreviewFinishResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C109 RID: 114953 RVA: 0x00412FA4 File Offset: 0x004111A4
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

		// Token: 0x0601C10A RID: 114954 RVA: 0x00412FE9 File Offset: 0x004111E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C10B RID: 114955 RVA: 0x00412FF6 File Offset: 0x004111F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C10C RID: 114956 RVA: 0x00412FFF File Offset: 0x004111FF
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

		// Token: 0x0601C10D RID: 114957 RVA: 0x00413034 File Offset: 0x00411234
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

		// Token: 0x0601C10E RID: 114958 RVA: 0x00413072 File Offset: 0x00411272
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefensePreviewFinishResponse other)
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

		// Token: 0x0601C10F RID: 114959 RVA: 0x004130A3 File Offset: 0x004112A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C110 RID: 114960 RVA: 0x004130AC File Offset: 0x004112AC
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

		// Token: 0x0400A271 RID: 41585
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A272 RID: 41586
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x0400A273 RID: 41587
		private ErrorCode errorCode_;
	}
}
