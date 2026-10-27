using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000847 RID: 2119
	[NetMessage(EMessageId.ItemDecomposeResponse)]
	public sealed class ItemDecomposeResponse : IMessage<ItemDecomposeResponse>, IMessage, IEquatable<ItemDecomposeResponse>, IDeepCloneable<ItemDecomposeResponse>, IBufferMessage
	{
		// Token: 0x0600BD1C RID: 48412 RVA: 0x001C1CFD File Offset: 0x001BFEFD
		[NullableContext(1)]
		public static ItemDecomposeResponse Create()
		{
			return new ItemDecomposeResponse();
		}

		// Token: 0x1700262F RID: 9775
		// (get) Token: 0x0600BD1D RID: 48413 RVA: 0x001C1D04 File Offset: 0x001BFF04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002630 RID: 9776
		// (get) Token: 0x0600BD1E RID: 48414 RVA: 0x001C1D07 File Offset: 0x001BFF07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemDecomposeResponse.Descriptor;
			}
		}

		// Token: 0x0600BD1F RID: 48415 RVA: 0x001C1D0E File Offset: 0x001BFF0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemDecomposeResponse()
		{
		}

		// Token: 0x0600BD20 RID: 48416 RVA: 0x001C1D16 File Offset: 0x001BFF16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemDecomposeResponse(ItemDecomposeResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BD21 RID: 48417 RVA: 0x001C1D3B File Offset: 0x001BFF3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemDecomposeResponse Clone()
		{
			return new ItemDecomposeResponse(this);
		}

		// Token: 0x17002631 RID: 9777
		// (get) Token: 0x0600BD22 RID: 48418 RVA: 0x001C1D43 File Offset: 0x001BFF43
		// (set) Token: 0x0600BD23 RID: 48419 RVA: 0x001C1D4B File Offset: 0x001BFF4B
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

		// Token: 0x0600BD24 RID: 48420 RVA: 0x001C1D54 File Offset: 0x001BFF54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemDecomposeResponse);
		}

		// Token: 0x0600BD25 RID: 48421 RVA: 0x001C1D62 File Offset: 0x001BFF62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemDecomposeResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BD26 RID: 48422 RVA: 0x001C1D90 File Offset: 0x001BFF90
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

		// Token: 0x0600BD27 RID: 48423 RVA: 0x001C1DD5 File Offset: 0x001BFFD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BD28 RID: 48424 RVA: 0x001C1DE2 File Offset: 0x001BFFE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BD29 RID: 48425 RVA: 0x001C1DEB File Offset: 0x001BFFEB
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

		// Token: 0x0600BD2A RID: 48426 RVA: 0x001C1E20 File Offset: 0x001C0020
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

		// Token: 0x0600BD2B RID: 48427 RVA: 0x001C1E5E File Offset: 0x001C005E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ItemDecomposeResponse other)
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

		// Token: 0x0600BD2C RID: 48428 RVA: 0x001C1E8F File Offset: 0x001C008F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BD2D RID: 48429 RVA: 0x001C1E98 File Offset: 0x001C0098
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

		// Token: 0x040052B3 RID: 21171
		private UnknownFieldSet _unknownFields;

		// Token: 0x040052B4 RID: 21172
		public const int ErrCodeFieldNumber = 6;

		// Token: 0x040052B5 RID: 21173
		private ErrorCode errCode_;
	}
}
