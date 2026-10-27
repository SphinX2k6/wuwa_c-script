using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CFE RID: 3326
	[NetMessage(EMessageId.PhantomReturnResponse)]
	public sealed class PhantomReturnResponse : IMessage<PhantomReturnResponse>, IMessage, IEquatable<PhantomReturnResponse>, IDeepCloneable<PhantomReturnResponse>, IBufferMessage
	{
		// Token: 0x06011FB0 RID: 73648 RVA: 0x002A1095 File Offset: 0x0029F295
		[NullableContext(1)]
		public static PhantomReturnResponse Create()
		{
			return new PhantomReturnResponse();
		}

		// Token: 0x17003B95 RID: 15253
		// (get) Token: 0x06011FB1 RID: 73649 RVA: 0x002A109C File Offset: 0x0029F29C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B96 RID: 15254
		// (get) Token: 0x06011FB2 RID: 73650 RVA: 0x002A109F File Offset: 0x0029F29F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomReturnResponse.Descriptor;
			}
		}

		// Token: 0x06011FB3 RID: 73651 RVA: 0x002A10A6 File Offset: 0x0029F2A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomReturnResponse()
		{
		}

		// Token: 0x06011FB4 RID: 73652 RVA: 0x002A10B9 File Offset: 0x0029F2B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomReturnResponse(PhantomReturnResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.itemMap_ = other.itemMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011FB5 RID: 73653 RVA: 0x002A10EF File Offset: 0x0029F2EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomReturnResponse Clone()
		{
			return new PhantomReturnResponse(this);
		}

		// Token: 0x17003B97 RID: 15255
		// (get) Token: 0x06011FB6 RID: 73654 RVA: 0x002A10F7 File Offset: 0x0029F2F7
		// (set) Token: 0x06011FB7 RID: 73655 RVA: 0x002A10FF File Offset: 0x0029F2FF
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

		// Token: 0x17003B98 RID: 15256
		// (get) Token: 0x06011FB8 RID: 73656 RVA: 0x002A1108 File Offset: 0x0029F308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ItemMap
		{
			get
			{
				return this.itemMap_;
			}
		}

		// Token: 0x06011FB9 RID: 73657 RVA: 0x002A1110 File Offset: 0x0029F310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomReturnResponse);
		}

		// Token: 0x06011FBA RID: 73658 RVA: 0x002A1120 File Offset: 0x0029F320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomReturnResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.ItemMap.Equals(other.ItemMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011FBB RID: 73659 RVA: 0x002A1170 File Offset: 0x0029F370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.ItemMap.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011FBC RID: 73660 RVA: 0x002A11C3 File Offset: 0x0029F3C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011FBD RID: 73661 RVA: 0x002A11D0 File Offset: 0x0029F3D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011FBE RID: 73662 RVA: 0x002A11DC File Offset: 0x0029F3DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.itemMap_.WriteTo(ref output, PhantomReturnResponse._map_itemMap_codec);
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

		// Token: 0x06011FBF RID: 73663 RVA: 0x002A122C File Offset: 0x0029F42C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.itemMap_.CalculateSize(PhantomReturnResponse._map_itemMap_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011FC0 RID: 73664 RVA: 0x002A1280 File Offset: 0x0029F480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomReturnResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.itemMap_.MergeFrom(other.itemMap_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011FC1 RID: 73665 RVA: 0x002A12CD File Offset: 0x0029F4CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011FC2 RID: 73666 RVA: 0x002A12D8 File Offset: 0x0029F4D8
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
				if (num != 18U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.itemMap_.AddEntriesFrom(ref input, PhantomReturnResponse._map_itemMap_codec);
				}
			}
		}

		// Token: 0x040070B0 RID: 28848
		private UnknownFieldSet _unknownFields;

		// Token: 0x040070B1 RID: 28849
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x040070B2 RID: 28850
		private ErrorCode errorCode_;

		// Token: 0x040070B3 RID: 28851
		public const int ItemMapFieldNumber = 2;

		// Token: 0x040070B4 RID: 28852
		private static readonly MapField<int, int>.Codec _map_itemMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 18U);

		// Token: 0x040070B5 RID: 28853
		private readonly MapField<int, int> itemMap_ = new MapField<int, int>();
	}
}
