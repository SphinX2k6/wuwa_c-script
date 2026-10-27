using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000165 RID: 357
	[NetMessage(EMessageId.BathPhotoResponse)]
	public sealed class BathPhotoResponse : IMessage<BathPhotoResponse>, IMessage, IEquatable<BathPhotoResponse>, IDeepCloneable<BathPhotoResponse>, IBufferMessage
	{
		// Token: 0x06002C77 RID: 11383 RVA: 0x0007395E File Offset: 0x00071B5E
		[NullableContext(1)]
		public static BathPhotoResponse Create()
		{
			return new BathPhotoResponse();
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x06002C78 RID: 11384 RVA: 0x00073965 File Offset: 0x00071B65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x06002C79 RID: 11385 RVA: 0x00073968 File Offset: 0x00071B68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BathPhotoResponse.Descriptor;
			}
		}

		// Token: 0x06002C7A RID: 11386 RVA: 0x0007396F File Offset: 0x00071B6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BathPhotoResponse()
		{
		}

		// Token: 0x06002C7B RID: 11387 RVA: 0x00073977 File Offset: 0x00071B77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BathPhotoResponse(BathPhotoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002C7C RID: 11388 RVA: 0x0007399C File Offset: 0x00071B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BathPhotoResponse Clone()
		{
			return new BathPhotoResponse(this);
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x06002C7D RID: 11389 RVA: 0x000739A4 File Offset: 0x00071BA4
		// (set) Token: 0x06002C7E RID: 11390 RVA: 0x000739AC File Offset: 0x00071BAC
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

		// Token: 0x06002C7F RID: 11391 RVA: 0x000739B5 File Offset: 0x00071BB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BathPhotoResponse);
		}

		// Token: 0x06002C80 RID: 11392 RVA: 0x000739C3 File Offset: 0x00071BC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BathPhotoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002C81 RID: 11393 RVA: 0x000739F4 File Offset: 0x00071BF4
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

		// Token: 0x06002C82 RID: 11394 RVA: 0x00073A39 File Offset: 0x00071C39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002C83 RID: 11395 RVA: 0x00073A46 File Offset: 0x00071C46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002C84 RID: 11396 RVA: 0x00073A4F File Offset: 0x00071C4F
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

		// Token: 0x06002C85 RID: 11397 RVA: 0x00073A84 File Offset: 0x00071C84
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

		// Token: 0x06002C86 RID: 11398 RVA: 0x00073AC2 File Offset: 0x00071CC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BathPhotoResponse other)
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

		// Token: 0x06002C87 RID: 11399 RVA: 0x00073AF3 File Offset: 0x00071CF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002C88 RID: 11400 RVA: 0x00073AFC File Offset: 0x00071CFC
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

		// Token: 0x040027F6 RID: 10230
		private UnknownFieldSet _unknownFields;

		// Token: 0x040027F7 RID: 10231
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x040027F8 RID: 10232
		private ErrorCode errorCode_;
	}
}
