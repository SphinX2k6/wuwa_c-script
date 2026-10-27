using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200039B RID: 923
	[NetMessage(EMessageId.DarkTideBagSortResponse)]
	public sealed class DarkTideBagSortResponse : IMessage<DarkTideBagSortResponse>, IMessage, IEquatable<DarkTideBagSortResponse>, IDeepCloneable<DarkTideBagSortResponse>, IBufferMessage
	{
		// Token: 0x06005B05 RID: 23301 RVA: 0x000DD7BF File Offset: 0x000DB9BF
		[NullableContext(1)]
		public static DarkTideBagSortResponse Create()
		{
			return new DarkTideBagSortResponse();
		}

		// Token: 0x170010DA RID: 4314
		// (get) Token: 0x06005B06 RID: 23302 RVA: 0x000DD7C6 File Offset: 0x000DB9C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170010DB RID: 4315
		// (get) Token: 0x06005B07 RID: 23303 RVA: 0x000DD7C9 File Offset: 0x000DB9C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DarkTideBagSortResponse.Descriptor;
			}
		}

		// Token: 0x06005B08 RID: 23304 RVA: 0x000DD7D0 File Offset: 0x000DB9D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideBagSortResponse()
		{
		}

		// Token: 0x06005B09 RID: 23305 RVA: 0x000DD7D8 File Offset: 0x000DB9D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideBagSortResponse(DarkTideBagSortResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005B0A RID: 23306 RVA: 0x000DD7FD File Offset: 0x000DB9FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideBagSortResponse Clone()
		{
			return new DarkTideBagSortResponse(this);
		}

		// Token: 0x170010DC RID: 4316
		// (get) Token: 0x06005B0B RID: 23307 RVA: 0x000DD805 File Offset: 0x000DBA05
		// (set) Token: 0x06005B0C RID: 23308 RVA: 0x000DD80D File Offset: 0x000DBA0D
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

		// Token: 0x06005B0D RID: 23309 RVA: 0x000DD816 File Offset: 0x000DBA16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DarkTideBagSortResponse);
		}

		// Token: 0x06005B0E RID: 23310 RVA: 0x000DD824 File Offset: 0x000DBA24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DarkTideBagSortResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005B0F RID: 23311 RVA: 0x000DD854 File Offset: 0x000DBA54
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

		// Token: 0x06005B10 RID: 23312 RVA: 0x000DD899 File Offset: 0x000DBA99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005B11 RID: 23313 RVA: 0x000DD8A6 File Offset: 0x000DBAA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005B12 RID: 23314 RVA: 0x000DD8AF File Offset: 0x000DBAAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005B13 RID: 23315 RVA: 0x000DD8E4 File Offset: 0x000DBAE4
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

		// Token: 0x06005B14 RID: 23316 RVA: 0x000DD922 File Offset: 0x000DBB22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DarkTideBagSortResponse other)
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

		// Token: 0x06005B15 RID: 23317 RVA: 0x000DD953 File Offset: 0x000DBB53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005B16 RID: 23318 RVA: 0x000DD95C File Offset: 0x000DBB5C
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040035E6 RID: 13798
		private UnknownFieldSet _unknownFields;

		// Token: 0x040035E7 RID: 13799
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x040035E8 RID: 13800
		private ErrorCode errorCode_;
	}
}
