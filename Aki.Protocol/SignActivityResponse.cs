using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001219 RID: 4633
	[NetMessage(EMessageId.SignActivityResponse)]
	public sealed class SignActivityResponse : IMessage<SignActivityResponse>, IMessage, IEquatable<SignActivityResponse>, IDeepCloneable<SignActivityResponse>, IBufferMessage
	{
		// Token: 0x06018B05 RID: 101125 RVA: 0x00397140 File Offset: 0x00395340
		[NullableContext(1)]
		public static SignActivityResponse Create()
		{
			return new SignActivityResponse();
		}

		// Token: 0x1700532D RID: 21293
		// (get) Token: 0x06018B06 RID: 101126 RVA: 0x00397147 File Offset: 0x00395347
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700532E RID: 21294
		// (get) Token: 0x06018B07 RID: 101127 RVA: 0x0039714A File Offset: 0x0039534A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SignActivityResponse.Descriptor;
			}
		}

		// Token: 0x06018B08 RID: 101128 RVA: 0x00397151 File Offset: 0x00395351
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignActivityResponse()
		{
		}

		// Token: 0x06018B09 RID: 101129 RVA: 0x00397164 File Offset: 0x00395364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignActivityResponse(SignActivityResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.itemMap_ = other.itemMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018B0A RID: 101130 RVA: 0x0039719A File Offset: 0x0039539A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignActivityResponse Clone()
		{
			return new SignActivityResponse(this);
		}

		// Token: 0x1700532F RID: 21295
		// (get) Token: 0x06018B0B RID: 101131 RVA: 0x003971A2 File Offset: 0x003953A2
		// (set) Token: 0x06018B0C RID: 101132 RVA: 0x003971AA File Offset: 0x003953AA
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

		// Token: 0x17005330 RID: 21296
		// (get) Token: 0x06018B0D RID: 101133 RVA: 0x003971B3 File Offset: 0x003953B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ItemMap
		{
			get
			{
				return this.itemMap_;
			}
		}

		// Token: 0x06018B0E RID: 101134 RVA: 0x003971BB File Offset: 0x003953BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SignActivityResponse);
		}

		// Token: 0x06018B0F RID: 101135 RVA: 0x003971CC File Offset: 0x003953CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SignActivityResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.ItemMap.Equals(other.ItemMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018B10 RID: 101136 RVA: 0x0039721C File Offset: 0x0039541C
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

		// Token: 0x06018B11 RID: 101137 RVA: 0x0039726F File Offset: 0x0039546F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018B12 RID: 101138 RVA: 0x0039727C File Offset: 0x0039547C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018B13 RID: 101139 RVA: 0x00397288 File Offset: 0x00395488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.itemMap_.WriteTo(ref output, SignActivityResponse._map_itemMap_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018B14 RID: 101140 RVA: 0x003972D8 File Offset: 0x003954D8
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

		// Token: 0x06018B15 RID: 101141 RVA: 0x0039732C File Offset: 0x0039552C
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

		// Token: 0x06018B16 RID: 101142 RVA: 0x00397379 File Offset: 0x00395579
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018B17 RID: 101143 RVA: 0x00397384 File Offset: 0x00395584
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
					if (num != 114U)
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

		// Token: 0x040091C5 RID: 37317
		private UnknownFieldSet _unknownFields;

		// Token: 0x040091C6 RID: 37318
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x040091C7 RID: 37319
		private ErrorCode errorCode_;

		// Token: 0x040091C8 RID: 37320
		public const int ItemMapFieldNumber = 14;

		// Token: 0x040091C9 RID: 37321
		private static readonly MapField<int, int>.Codec _map_itemMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 114U);

		// Token: 0x040091CA RID: 37322
		private readonly MapField<int, int> itemMap_ = new MapField<int, int>();
	}
}
