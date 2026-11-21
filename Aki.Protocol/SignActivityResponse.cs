using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001255 RID: 4693
	[NetMessage(EMessageId.SignActivityResponse)]
	public sealed class SignActivityResponse : IMessage<SignActivityResponse>, IMessage, IEquatable<SignActivityResponse>, IDeepCloneable<SignActivityResponse>, IBufferMessage
	{
		// Token: 0x060190DF RID: 102623 RVA: 0x003A6FE4 File Offset: 0x003A51E4
		[NullableContext(1)]
		public static SignActivityResponse Create()
		{
			return new SignActivityResponse();
		}

		// Token: 0x170054AA RID: 21674
		// (get) Token: 0x060190E0 RID: 102624 RVA: 0x003A6FEB File Offset: 0x003A51EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170054AB RID: 21675
		// (get) Token: 0x060190E1 RID: 102625 RVA: 0x003A6FEE File Offset: 0x003A51EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SignActivityResponse.Descriptor;
			}
		}

		// Token: 0x060190E2 RID: 102626 RVA: 0x003A6FF5 File Offset: 0x003A51F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignActivityResponse()
		{
		}

		// Token: 0x060190E3 RID: 102627 RVA: 0x003A7008 File Offset: 0x003A5208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignActivityResponse(SignActivityResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.itemMap_ = other.itemMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060190E4 RID: 102628 RVA: 0x003A703E File Offset: 0x003A523E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignActivityResponse Clone()
		{
			return new SignActivityResponse(this);
		}

		// Token: 0x170054AC RID: 21676
		// (get) Token: 0x060190E5 RID: 102629 RVA: 0x003A7046 File Offset: 0x003A5246
		// (set) Token: 0x060190E6 RID: 102630 RVA: 0x003A704E File Offset: 0x003A524E
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

		// Token: 0x170054AD RID: 21677
		// (get) Token: 0x060190E7 RID: 102631 RVA: 0x003A7057 File Offset: 0x003A5257
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ItemMap
		{
			get
			{
				return this.itemMap_;
			}
		}

		// Token: 0x060190E8 RID: 102632 RVA: 0x003A705F File Offset: 0x003A525F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SignActivityResponse);
		}

		// Token: 0x060190E9 RID: 102633 RVA: 0x003A7070 File Offset: 0x003A5270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SignActivityResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.ItemMap.Equals(other.ItemMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060190EA RID: 102634 RVA: 0x003A70C0 File Offset: 0x003A52C0
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

		// Token: 0x060190EB RID: 102635 RVA: 0x003A7113 File Offset: 0x003A5313
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060190EC RID: 102636 RVA: 0x003A7120 File Offset: 0x003A5320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060190ED RID: 102637 RVA: 0x003A712C File Offset: 0x003A532C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.itemMap_.WriteTo(ref output, SignActivityResponse._map_itemMap_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060190EE RID: 102638 RVA: 0x003A717C File Offset: 0x003A537C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.itemMap_.CalculateSize(SignActivityResponse._map_itemMap_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060190EF RID: 102639 RVA: 0x003A71D0 File Offset: 0x003A53D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SignActivityResponse other)
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

		// Token: 0x060190F0 RID: 102640 RVA: 0x003A721D File Offset: 0x003A541D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060190F1 RID: 102641 RVA: 0x003A7228 File Offset: 0x003A5428
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
					if (num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.itemMap_.AddEntriesFrom(ref input, SignActivityResponse._map_itemMap_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009476 RID: 38006
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009477 RID: 38007
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04009478 RID: 38008
		private ErrorCode errorCode_;

		// Token: 0x04009479 RID: 38009
		public const int ItemMapFieldNumber = 10;

		// Token: 0x0400947A RID: 38010
		private static readonly MapField<int, int>.Codec _map_itemMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 82U);

		// Token: 0x0400947B RID: 38011
		private readonly MapField<int, int> itemMap_ = new MapField<int, int>();
	}
}
