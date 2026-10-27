using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000614 RID: 1556
	[NetMessage(EMessageId.FlySkinWearResponse)]
	public sealed class FlySkinWearResponse : IMessage<FlySkinWearResponse>, IMessage, IEquatable<FlySkinWearResponse>, IDeepCloneable<FlySkinWearResponse>, IBufferMessage
	{
		// Token: 0x06008FB6 RID: 36790 RVA: 0x0015BFF0 File Offset: 0x0015A1F0
		[NullableContext(1)]
		public static FlySkinWearResponse Create()
		{
			return new FlySkinWearResponse();
		}

		// Token: 0x17001C87 RID: 7303
		// (get) Token: 0x06008FB7 RID: 36791 RVA: 0x0015BFF7 File Offset: 0x0015A1F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C88 RID: 7304
		// (get) Token: 0x06008FB8 RID: 36792 RVA: 0x0015BFFA File Offset: 0x0015A1FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlySkinWearResponse.Descriptor;
			}
		}

		// Token: 0x06008FB9 RID: 36793 RVA: 0x0015C001 File Offset: 0x0015A201
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlySkinWearResponse()
		{
		}

		// Token: 0x06008FBA RID: 36794 RVA: 0x0015C009 File Offset: 0x0015A209
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlySkinWearResponse(FlySkinWearResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008FBB RID: 36795 RVA: 0x0015C02E File Offset: 0x0015A22E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlySkinWearResponse Clone()
		{
			return new FlySkinWearResponse(this);
		}

		// Token: 0x17001C89 RID: 7305
		// (get) Token: 0x06008FBC RID: 36796 RVA: 0x0015C036 File Offset: 0x0015A236
		// (set) Token: 0x06008FBD RID: 36797 RVA: 0x0015C03E File Offset: 0x0015A23E
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

		// Token: 0x06008FBE RID: 36798 RVA: 0x0015C047 File Offset: 0x0015A247
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlySkinWearResponse);
		}

		// Token: 0x06008FBF RID: 36799 RVA: 0x0015C055 File Offset: 0x0015A255
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlySkinWearResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008FC0 RID: 36800 RVA: 0x0015C084 File Offset: 0x0015A284
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

		// Token: 0x06008FC1 RID: 36801 RVA: 0x0015C0C9 File Offset: 0x0015A2C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008FC2 RID: 36802 RVA: 0x0015C0D6 File Offset: 0x0015A2D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008FC3 RID: 36803 RVA: 0x0015C0DF File Offset: 0x0015A2DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008FC4 RID: 36804 RVA: 0x0015C114 File Offset: 0x0015A314
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

		// Token: 0x06008FC5 RID: 36805 RVA: 0x0015C152 File Offset: 0x0015A352
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlySkinWearResponse other)
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

		// Token: 0x06008FC6 RID: 36806 RVA: 0x0015C183 File Offset: 0x0015A383
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008FC7 RID: 36807 RVA: 0x0015C18C File Offset: 0x0015A38C
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040045B5 RID: 17845
		private UnknownFieldSet _unknownFields;

		// Token: 0x040045B6 RID: 17846
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x040045B7 RID: 17847
		private ErrorCode errorCode_;
	}
}
