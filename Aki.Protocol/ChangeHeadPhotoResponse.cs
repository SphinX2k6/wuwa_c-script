using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000251 RID: 593
	[NetMessage(EMessageId.ChangeHeadPhotoResponse)]
	public sealed class ChangeHeadPhotoResponse : IMessage<ChangeHeadPhotoResponse>, IMessage, IEquatable<ChangeHeadPhotoResponse>, IDeepCloneable<ChangeHeadPhotoResponse>, IBufferMessage
	{
		// Token: 0x06003F31 RID: 16177 RVA: 0x0009B92D File Offset: 0x00099B2D
		[NullableContext(1)]
		public static ChangeHeadPhotoResponse Create()
		{
			return new ChangeHeadPhotoResponse();
		}

		// Token: 0x17000A93 RID: 2707
		// (get) Token: 0x06003F32 RID: 16178 RVA: 0x0009B934 File Offset: 0x00099B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A94 RID: 2708
		// (get) Token: 0x06003F33 RID: 16179 RVA: 0x0009B937 File Offset: 0x00099B37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeHeadPhotoResponse.Descriptor;
			}
		}

		// Token: 0x06003F34 RID: 16180 RVA: 0x0009B93E File Offset: 0x00099B3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeHeadPhotoResponse()
		{
		}

		// Token: 0x06003F35 RID: 16181 RVA: 0x0009B946 File Offset: 0x00099B46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeHeadPhotoResponse(ChangeHeadPhotoResponse other) : this()
		{
			this.headPhotoId_ = other.headPhotoId_;
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003F36 RID: 16182 RVA: 0x0009B977 File Offset: 0x00099B77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeHeadPhotoResponse Clone()
		{
			return new ChangeHeadPhotoResponse(this);
		}

		// Token: 0x17000A95 RID: 2709
		// (get) Token: 0x06003F37 RID: 16183 RVA: 0x0009B97F File Offset: 0x00099B7F
		// (set) Token: 0x06003F38 RID: 16184 RVA: 0x0009B987 File Offset: 0x00099B87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HeadPhotoId
		{
			get
			{
				return this.headPhotoId_;
			}
			set
			{
				this.headPhotoId_ = value;
			}
		}

		// Token: 0x17000A96 RID: 2710
		// (get) Token: 0x06003F39 RID: 16185 RVA: 0x0009B990 File Offset: 0x00099B90
		// (set) Token: 0x06003F3A RID: 16186 RVA: 0x0009B998 File Offset: 0x00099B98
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

		// Token: 0x06003F3B RID: 16187 RVA: 0x0009B9A1 File Offset: 0x00099BA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeHeadPhotoResponse);
		}

		// Token: 0x06003F3C RID: 16188 RVA: 0x0009B9AF File Offset: 0x00099BAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeHeadPhotoResponse other)
		{
			return other != null && (other == this || (this.HeadPhotoId == other.HeadPhotoId && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003F3D RID: 16189 RVA: 0x0009B9F0 File Offset: 0x00099BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HeadPhotoId != 0)
			{
				num ^= this.HeadPhotoId.GetHashCode();
			}
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

		// Token: 0x06003F3E RID: 16190 RVA: 0x0009BA4E File Offset: 0x00099C4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003F3F RID: 16191 RVA: 0x0009BA5B File Offset: 0x00099C5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003F40 RID: 16192 RVA: 0x0009BA64 File Offset: 0x00099C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.HeadPhotoId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.HeadPhotoId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003F41 RID: 16193 RVA: 0x0009BAC0 File Offset: 0x00099CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HeadPhotoId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HeadPhotoId);
			}
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

		// Token: 0x06003F42 RID: 16194 RVA: 0x0009BB18 File Offset: 0x00099D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangeHeadPhotoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HeadPhotoId != 0)
			{
				this.HeadPhotoId = other.HeadPhotoId;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003F43 RID: 16195 RVA: 0x0009BB68 File Offset: 0x00099D68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003F44 RID: 16196 RVA: 0x0009BB74 File Offset: 0x00099D74
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
				if (num != 24U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.HeadPhotoId = input.ReadInt32();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002D0F RID: 11535
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D10 RID: 11536
		public const int HeadPhotoIdFieldNumber = 15;

		// Token: 0x04002D11 RID: 11537
		private int headPhotoId_;

		// Token: 0x04002D12 RID: 11538
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04002D13 RID: 11539
		private ErrorCode errorCode_;
	}
}
