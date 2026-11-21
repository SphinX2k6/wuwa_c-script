using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001E9 RID: 489
	[NetMessage(EMessageId.BrochureRewardResponse)]
	public sealed class BrochureRewardResponse : IMessage<BrochureRewardResponse>, IMessage, IEquatable<BrochureRewardResponse>, IDeepCloneable<BrochureRewardResponse>, IBufferMessage
	{
		// Token: 0x0600370E RID: 14094 RVA: 0x0008A376 File Offset: 0x00088576
		[NullableContext(1)]
		public static BrochureRewardResponse Create()
		{
			return new BrochureRewardResponse();
		}

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x0600370F RID: 14095 RVA: 0x0008A37D File Offset: 0x0008857D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x06003710 RID: 14096 RVA: 0x0008A380 File Offset: 0x00088580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BrochureRewardResponse.Descriptor;
			}
		}

		// Token: 0x06003711 RID: 14097 RVA: 0x0008A387 File Offset: 0x00088587
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BrochureRewardResponse()
		{
		}

		// Token: 0x06003712 RID: 14098 RVA: 0x0008A38F File Offset: 0x0008858F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BrochureRewardResponse(BrochureRewardResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003713 RID: 14099 RVA: 0x0008A3B4 File Offset: 0x000885B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BrochureRewardResponse Clone()
		{
			return new BrochureRewardResponse(this);
		}

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x06003714 RID: 14100 RVA: 0x0008A3BC File Offset: 0x000885BC
		// (set) Token: 0x06003715 RID: 14101 RVA: 0x0008A3C4 File Offset: 0x000885C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x06003716 RID: 14102 RVA: 0x0008A3CD File Offset: 0x000885CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BrochureRewardResponse);
		}

		// Token: 0x06003717 RID: 14103 RVA: 0x0008A3DB File Offset: 0x000885DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BrochureRewardResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003718 RID: 14104 RVA: 0x0008A40C File Offset: 0x0008860C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003719 RID: 14105 RVA: 0x0008A451 File Offset: 0x00088651
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600371A RID: 14106 RVA: 0x0008A45E File Offset: 0x0008865E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600371B RID: 14107 RVA: 0x0008A467 File Offset: 0x00088667
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600371C RID: 14108 RVA: 0x0008A49C File Offset: 0x0008869C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600371D RID: 14109 RVA: 0x0008A4DA File Offset: 0x000886DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BrochureRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600371E RID: 14110 RVA: 0x0008A50B File Offset: 0x0008870B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600371F RID: 14111 RVA: 0x0008A514 File Offset: 0x00088714
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002B22 RID: 11042
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B23 RID: 11043
		public const int ErrCodeFieldNumber = 4;

		// Token: 0x04002B24 RID: 11044
		private ErrorCode errCode_;
	}
}
