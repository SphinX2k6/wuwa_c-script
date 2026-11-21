using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000161 RID: 353
	[NetMessage(EMessageId.BatchMaterialReplaceResponse)]
	public sealed class BatchMaterialReplaceResponse : IMessage<BatchMaterialReplaceResponse>, IMessage, IEquatable<BatchMaterialReplaceResponse>, IDeepCloneable<BatchMaterialReplaceResponse>, IBufferMessage
	{
		// Token: 0x06002C6B RID: 11371 RVA: 0x00073E91 File Offset: 0x00072091
		[NullableContext(1)]
		public static BatchMaterialReplaceResponse Create()
		{
			return new BatchMaterialReplaceResponse();
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x06002C6C RID: 11372 RVA: 0x00073E98 File Offset: 0x00072098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x06002C6D RID: 11373 RVA: 0x00073E9B File Offset: 0x0007209B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BatchMaterialReplaceResponse.Descriptor;
			}
		}

		// Token: 0x06002C6E RID: 11374 RVA: 0x00073EA2 File Offset: 0x000720A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BatchMaterialReplaceResponse()
		{
		}

		// Token: 0x06002C6F RID: 11375 RVA: 0x00073EAA File Offset: 0x000720AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BatchMaterialReplaceResponse(BatchMaterialReplaceResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002C70 RID: 11376 RVA: 0x00073ECF File Offset: 0x000720CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BatchMaterialReplaceResponse Clone()
		{
			return new BatchMaterialReplaceResponse(this);
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x06002C71 RID: 11377 RVA: 0x00073ED7 File Offset: 0x000720D7
		// (set) Token: 0x06002C72 RID: 11378 RVA: 0x00073EDF File Offset: 0x000720DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x06002C73 RID: 11379 RVA: 0x00073EE8 File Offset: 0x000720E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BatchMaterialReplaceResponse);
		}

		// Token: 0x06002C74 RID: 11380 RVA: 0x00073EF6 File Offset: 0x000720F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BatchMaterialReplaceResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002C75 RID: 11381 RVA: 0x00073F24 File Offset: 0x00072124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002C76 RID: 11382 RVA: 0x00073F69 File Offset: 0x00072169
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002C77 RID: 11383 RVA: 0x00073F76 File Offset: 0x00072176
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002C78 RID: 11384 RVA: 0x00073F7F File Offset: 0x0007217F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002C79 RID: 11385 RVA: 0x00073FB4 File Offset: 0x000721B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002C7A RID: 11386 RVA: 0x00073FF2 File Offset: 0x000721F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BatchMaterialReplaceResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002C7B RID: 11387 RVA: 0x00074023 File Offset: 0x00072223
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002C7C RID: 11388 RVA: 0x0007402C File Offset: 0x0007222C
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
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400284D RID: 10317
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400284E RID: 10318
		public const int CodeFieldNumber = 12;

		// Token: 0x0400284F RID: 10319
		private ErrorCode code_;
	}
}
