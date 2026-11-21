using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200033D RID: 829
	[NetMessage(EMessageId.DangoBrawlBagOperateResponse)]
	public sealed class DangoBrawlBagOperateResponse : IMessage<DangoBrawlBagOperateResponse>, IMessage, IEquatable<DangoBrawlBagOperateResponse>, IDeepCloneable<DangoBrawlBagOperateResponse>, IBufferMessage
	{
		// Token: 0x06005366 RID: 21350 RVA: 0x000CBC91 File Offset: 0x000C9E91
		[NullableContext(1)]
		public static DangoBrawlBagOperateResponse Create()
		{
			return new DangoBrawlBagOperateResponse();
		}

		// Token: 0x17000F23 RID: 3875
		// (get) Token: 0x06005367 RID: 21351 RVA: 0x000CBC98 File Offset: 0x000C9E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F24 RID: 3876
		// (get) Token: 0x06005368 RID: 21352 RVA: 0x000CBC9B File Offset: 0x000C9E9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlBagOperateResponse.Descriptor;
			}
		}

		// Token: 0x06005369 RID: 21353 RVA: 0x000CBCA2 File Offset: 0x000C9EA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlBagOperateResponse()
		{
		}

		// Token: 0x0600536A RID: 21354 RVA: 0x000CBCAA File Offset: 0x000C9EAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlBagOperateResponse(DangoBrawlBagOperateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600536B RID: 21355 RVA: 0x000CBCCF File Offset: 0x000C9ECF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlBagOperateResponse Clone()
		{
			return new DangoBrawlBagOperateResponse(this);
		}

		// Token: 0x17000F25 RID: 3877
		// (get) Token: 0x0600536C RID: 21356 RVA: 0x000CBCD7 File Offset: 0x000C9ED7
		// (set) Token: 0x0600536D RID: 21357 RVA: 0x000CBCDF File Offset: 0x000C9EDF
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

		// Token: 0x0600536E RID: 21358 RVA: 0x000CBCE8 File Offset: 0x000C9EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlBagOperateResponse);
		}

		// Token: 0x0600536F RID: 21359 RVA: 0x000CBCF6 File Offset: 0x000C9EF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlBagOperateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005370 RID: 21360 RVA: 0x000CBD24 File Offset: 0x000C9F24
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

		// Token: 0x06005371 RID: 21361 RVA: 0x000CBD69 File Offset: 0x000C9F69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005372 RID: 21362 RVA: 0x000CBD76 File Offset: 0x000C9F76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005373 RID: 21363 RVA: 0x000CBD7F File Offset: 0x000C9F7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005374 RID: 21364 RVA: 0x000CBDB4 File Offset: 0x000C9FB4
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

		// Token: 0x06005375 RID: 21365 RVA: 0x000CBDF2 File Offset: 0x000C9FF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlBagOperateResponse other)
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

		// Token: 0x06005376 RID: 21366 RVA: 0x000CBE23 File Offset: 0x000CA023
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005377 RID: 21367 RVA: 0x000CBE2C File Offset: 0x000CA02C
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040033D3 RID: 13267
		private UnknownFieldSet _unknownFields;

		// Token: 0x040033D4 RID: 13268
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x040033D5 RID: 13269
		private ErrorCode errorCode_;
	}
}
