using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200128C RID: 4748
	[NetMessage(EMessageId.SlashAndTowerResetResponse)]
	public sealed class SlashAndTowerResetResponse : IMessage<SlashAndTowerResetResponse>, IMessage, IEquatable<SlashAndTowerResetResponse>, IDeepCloneable<SlashAndTowerResetResponse>, IBufferMessage
	{
		// Token: 0x06019577 RID: 103799 RVA: 0x003B211D File Offset: 0x003B031D
		[NullableContext(1)]
		public static SlashAndTowerResetResponse Create()
		{
			return new SlashAndTowerResetResponse();
		}

		// Token: 0x170055B4 RID: 21940
		// (get) Token: 0x06019578 RID: 103800 RVA: 0x003B2124 File Offset: 0x003B0324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170055B5 RID: 21941
		// (get) Token: 0x06019579 RID: 103801 RVA: 0x003B2127 File Offset: 0x003B0327
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SlashAndTowerResetResponse.Descriptor;
			}
		}

		// Token: 0x0601957A RID: 103802 RVA: 0x003B212E File Offset: 0x003B032E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerResetResponse()
		{
		}

		// Token: 0x0601957B RID: 103803 RVA: 0x003B2136 File Offset: 0x003B0336
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerResetResponse(SlashAndTowerResetResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601957C RID: 103804 RVA: 0x003B215B File Offset: 0x003B035B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerResetResponse Clone()
		{
			return new SlashAndTowerResetResponse(this);
		}

		// Token: 0x170055B6 RID: 21942
		// (get) Token: 0x0601957D RID: 103805 RVA: 0x003B2163 File Offset: 0x003B0363
		// (set) Token: 0x0601957E RID: 103806 RVA: 0x003B216B File Offset: 0x003B036B
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

		// Token: 0x0601957F RID: 103807 RVA: 0x003B2174 File Offset: 0x003B0374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SlashAndTowerResetResponse);
		}

		// Token: 0x06019580 RID: 103808 RVA: 0x003B2182 File Offset: 0x003B0382
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SlashAndTowerResetResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019581 RID: 103809 RVA: 0x003B21B0 File Offset: 0x003B03B0
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

		// Token: 0x06019582 RID: 103810 RVA: 0x003B21F5 File Offset: 0x003B03F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019583 RID: 103811 RVA: 0x003B2202 File Offset: 0x003B0402
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019584 RID: 103812 RVA: 0x003B220B File Offset: 0x003B040B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019585 RID: 103813 RVA: 0x003B2240 File Offset: 0x003B0440
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

		// Token: 0x06019586 RID: 103814 RVA: 0x003B227E File Offset: 0x003B047E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SlashAndTowerResetResponse other)
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

		// Token: 0x06019587 RID: 103815 RVA: 0x003B22AF File Offset: 0x003B04AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019588 RID: 103816 RVA: 0x003B22B8 File Offset: 0x003B04B8
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040095E3 RID: 38371
		private UnknownFieldSet _unknownFields;

		// Token: 0x040095E4 RID: 38372
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x040095E5 RID: 38373
		private ErrorCode errorCode_;
	}
}
