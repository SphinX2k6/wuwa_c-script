using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200128F RID: 4751
	[NetMessage(EMessageId.SlashAndTowerSaveRecordResponse)]
	public sealed class SlashAndTowerSaveRecordResponse : IMessage<SlashAndTowerSaveRecordResponse>, IMessage, IEquatable<SlashAndTowerSaveRecordResponse>, IDeepCloneable<SlashAndTowerSaveRecordResponse>, IBufferMessage
	{
		// Token: 0x060195B9 RID: 103865 RVA: 0x003B2B41 File Offset: 0x003B0D41
		[NullableContext(1)]
		public static SlashAndTowerSaveRecordResponse Create()
		{
			return new SlashAndTowerSaveRecordResponse();
		}

		// Token: 0x170055C3 RID: 21955
		// (get) Token: 0x060195BA RID: 103866 RVA: 0x003B2B48 File Offset: 0x003B0D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170055C4 RID: 21956
		// (get) Token: 0x060195BB RID: 103867 RVA: 0x003B2B4B File Offset: 0x003B0D4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SlashAndTowerSaveRecordResponse.Descriptor;
			}
		}

		// Token: 0x060195BC RID: 103868 RVA: 0x003B2B52 File Offset: 0x003B0D52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerSaveRecordResponse()
		{
		}

		// Token: 0x060195BD RID: 103869 RVA: 0x003B2B5A File Offset: 0x003B0D5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerSaveRecordResponse(SlashAndTowerSaveRecordResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060195BE RID: 103870 RVA: 0x003B2B7F File Offset: 0x003B0D7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerSaveRecordResponse Clone()
		{
			return new SlashAndTowerSaveRecordResponse(this);
		}

		// Token: 0x170055C5 RID: 21957
		// (get) Token: 0x060195BF RID: 103871 RVA: 0x003B2B87 File Offset: 0x003B0D87
		// (set) Token: 0x060195C0 RID: 103872 RVA: 0x003B2B8F File Offset: 0x003B0D8F
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

		// Token: 0x060195C1 RID: 103873 RVA: 0x003B2B98 File Offset: 0x003B0D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SlashAndTowerSaveRecordResponse);
		}

		// Token: 0x060195C2 RID: 103874 RVA: 0x003B2BA6 File Offset: 0x003B0DA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SlashAndTowerSaveRecordResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060195C3 RID: 103875 RVA: 0x003B2BD4 File Offset: 0x003B0DD4
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

		// Token: 0x060195C4 RID: 103876 RVA: 0x003B2C19 File Offset: 0x003B0E19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060195C5 RID: 103877 RVA: 0x003B2C26 File Offset: 0x003B0E26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060195C6 RID: 103878 RVA: 0x003B2C2F File Offset: 0x003B0E2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060195C7 RID: 103879 RVA: 0x003B2C60 File Offset: 0x003B0E60
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

		// Token: 0x060195C8 RID: 103880 RVA: 0x003B2C9E File Offset: 0x003B0E9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SlashAndTowerSaveRecordResponse other)
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

		// Token: 0x060195C9 RID: 103881 RVA: 0x003B2CCF File Offset: 0x003B0ECF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060195CA RID: 103882 RVA: 0x003B2CD8 File Offset: 0x003B0ED8
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040095F8 RID: 38392
		private UnknownFieldSet _unknownFields;

		// Token: 0x040095F9 RID: 38393
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x040095FA RID: 38394
		private ErrorCode errorCode_;
	}
}
