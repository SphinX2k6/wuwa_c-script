using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000838 RID: 2104
	[NetMessage(EMessageId.ItemDisuseResponse)]
	public sealed class ItemDisuseResponse : IMessage<ItemDisuseResponse>, IMessage, IEquatable<ItemDisuseResponse>, IDeepCloneable<ItemDisuseResponse>, IBufferMessage
	{
		// Token: 0x0600BC27 RID: 48167 RVA: 0x001BFEA3 File Offset: 0x001BE0A3
		[NullableContext(1)]
		public static ItemDisuseResponse Create()
		{
			return new ItemDisuseResponse();
		}

		// Token: 0x170025F8 RID: 9720
		// (get) Token: 0x0600BC28 RID: 48168 RVA: 0x001BFEAA File Offset: 0x001BE0AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170025F9 RID: 9721
		// (get) Token: 0x0600BC29 RID: 48169 RVA: 0x001BFEAD File Offset: 0x001BE0AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemDisuseResponse.Descriptor;
			}
		}

		// Token: 0x0600BC2A RID: 48170 RVA: 0x001BFEB4 File Offset: 0x001BE0B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemDisuseResponse()
		{
		}

		// Token: 0x0600BC2B RID: 48171 RVA: 0x001BFEBC File Offset: 0x001BE0BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemDisuseResponse(ItemDisuseResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BC2C RID: 48172 RVA: 0x001BFEE1 File Offset: 0x001BE0E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemDisuseResponse Clone()
		{
			return new ItemDisuseResponse(this);
		}

		// Token: 0x170025FA RID: 9722
		// (get) Token: 0x0600BC2D RID: 48173 RVA: 0x001BFEE9 File Offset: 0x001BE0E9
		// (set) Token: 0x0600BC2E RID: 48174 RVA: 0x001BFEF1 File Offset: 0x001BE0F1
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

		// Token: 0x0600BC2F RID: 48175 RVA: 0x001BFEFA File Offset: 0x001BE0FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemDisuseResponse);
		}

		// Token: 0x0600BC30 RID: 48176 RVA: 0x001BFF08 File Offset: 0x001BE108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemDisuseResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BC31 RID: 48177 RVA: 0x001BFF38 File Offset: 0x001BE138
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

		// Token: 0x0600BC32 RID: 48178 RVA: 0x001BFF7D File Offset: 0x001BE17D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BC33 RID: 48179 RVA: 0x001BFF8A File Offset: 0x001BE18A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BC34 RID: 48180 RVA: 0x001BFF93 File Offset: 0x001BE193
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BC35 RID: 48181 RVA: 0x001BFFC8 File Offset: 0x001BE1C8
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

		// Token: 0x0600BC36 RID: 48182 RVA: 0x001C0006 File Offset: 0x001BE206
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ItemDisuseResponse other)
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

		// Token: 0x0600BC37 RID: 48183 RVA: 0x001C0037 File Offset: 0x001BE237
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BC38 RID: 48184 RVA: 0x001C0040 File Offset: 0x001BE240
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
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040052C3 RID: 21187
		private UnknownFieldSet _unknownFields;

		// Token: 0x040052C4 RID: 21188
		public const int ErrCodeFieldNumber = 6;

		// Token: 0x040052C5 RID: 21189
		private ErrorCode errCode_;
	}
}
