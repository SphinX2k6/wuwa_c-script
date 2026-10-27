using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000283 RID: 643
	[NetMessage(EMessageId.CheckGearResponse)]
	public sealed class CheckGearResponse : IMessage<CheckGearResponse>, IMessage, IEquatable<CheckGearResponse>, IDeepCloneable<CheckGearResponse>, IBufferMessage
	{
		// Token: 0x06004356 RID: 17238 RVA: 0x000A526D File Offset: 0x000A346D
		[NullableContext(1)]
		public static CheckGearResponse Create()
		{
			return new CheckGearResponse();
		}

		// Token: 0x17000B7A RID: 2938
		// (get) Token: 0x06004357 RID: 17239 RVA: 0x000A5274 File Offset: 0x000A3474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B7B RID: 2939
		// (get) Token: 0x06004358 RID: 17240 RVA: 0x000A5277 File Offset: 0x000A3477
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CheckGearResponse.Descriptor;
			}
		}

		// Token: 0x06004359 RID: 17241 RVA: 0x000A527E File Offset: 0x000A347E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CheckGearResponse()
		{
		}

		// Token: 0x0600435A RID: 17242 RVA: 0x000A5286 File Offset: 0x000A3486
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CheckGearResponse(CheckGearResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600435B RID: 17243 RVA: 0x000A52AB File Offset: 0x000A34AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CheckGearResponse Clone()
		{
			return new CheckGearResponse(this);
		}

		// Token: 0x17000B7C RID: 2940
		// (get) Token: 0x0600435C RID: 17244 RVA: 0x000A52B3 File Offset: 0x000A34B3
		// (set) Token: 0x0600435D RID: 17245 RVA: 0x000A52BB File Offset: 0x000A34BB
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

		// Token: 0x0600435E RID: 17246 RVA: 0x000A52C4 File Offset: 0x000A34C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CheckGearResponse);
		}

		// Token: 0x0600435F RID: 17247 RVA: 0x000A52D2 File Offset: 0x000A34D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CheckGearResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004360 RID: 17248 RVA: 0x000A5300 File Offset: 0x000A3500
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

		// Token: 0x06004361 RID: 17249 RVA: 0x000A5345 File Offset: 0x000A3545
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004362 RID: 17250 RVA: 0x000A5352 File Offset: 0x000A3552
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004363 RID: 17251 RVA: 0x000A535B File Offset: 0x000A355B
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

		// Token: 0x06004364 RID: 17252 RVA: 0x000A5390 File Offset: 0x000A3590
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

		// Token: 0x06004365 RID: 17253 RVA: 0x000A53CE File Offset: 0x000A35CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CheckGearResponse other)
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

		// Token: 0x06004366 RID: 17254 RVA: 0x000A53FF File Offset: 0x000A35FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004367 RID: 17255 RVA: 0x000A5408 File Offset: 0x000A3608
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

		// Token: 0x04002E50 RID: 11856
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E51 RID: 11857
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04002E52 RID: 11858
		private ErrorCode errorCode_;
	}
}
