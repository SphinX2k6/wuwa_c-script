using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CEC RID: 3308
	[NetMessage(EMessageId.PhantomReturnPreviewResponse)]
	public sealed class PhantomReturnPreviewResponse : IMessage<PhantomReturnPreviewResponse>, IMessage, IEquatable<PhantomReturnPreviewResponse>, IDeepCloneable<PhantomReturnPreviewResponse>, IBufferMessage
	{
		// Token: 0x06011E8E RID: 73358 RVA: 0x0029EFDD File Offset: 0x0029D1DD
		[NullableContext(1)]
		public static PhantomReturnPreviewResponse Create()
		{
			return new PhantomReturnPreviewResponse();
		}

		// Token: 0x17003B59 RID: 15193
		// (get) Token: 0x06011E8F RID: 73359 RVA: 0x0029EFE4 File Offset: 0x0029D1E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B5A RID: 15194
		// (get) Token: 0x06011E90 RID: 73360 RVA: 0x0029EFE7 File Offset: 0x0029D1E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomReturnPreviewResponse.Descriptor;
			}
		}

		// Token: 0x06011E91 RID: 73361 RVA: 0x0029EFEE File Offset: 0x0029D1EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomReturnPreviewResponse()
		{
		}

		// Token: 0x06011E92 RID: 73362 RVA: 0x0029F001 File Offset: 0x0029D201
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomReturnPreviewResponse(PhantomReturnPreviewResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.itemMap_ = other.itemMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011E93 RID: 73363 RVA: 0x0029F037 File Offset: 0x0029D237
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomReturnPreviewResponse Clone()
		{
			return new PhantomReturnPreviewResponse(this);
		}

		// Token: 0x17003B5B RID: 15195
		// (get) Token: 0x06011E94 RID: 73364 RVA: 0x0029F03F File Offset: 0x0029D23F
		// (set) Token: 0x06011E95 RID: 73365 RVA: 0x0029F047 File Offset: 0x0029D247
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

		// Token: 0x17003B5C RID: 15196
		// (get) Token: 0x06011E96 RID: 73366 RVA: 0x0029F050 File Offset: 0x0029D250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ItemMap
		{
			get
			{
				return this.itemMap_;
			}
		}

		// Token: 0x06011E97 RID: 73367 RVA: 0x0029F058 File Offset: 0x0029D258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomReturnPreviewResponse);
		}

		// Token: 0x06011E98 RID: 73368 RVA: 0x0029F068 File Offset: 0x0029D268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomReturnPreviewResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.ItemMap.Equals(other.ItemMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011E99 RID: 73369 RVA: 0x0029F0B8 File Offset: 0x0029D2B8
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

		// Token: 0x06011E9A RID: 73370 RVA: 0x0029F10B File Offset: 0x0029D30B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011E9B RID: 73371 RVA: 0x0029F118 File Offset: 0x0029D318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011E9C RID: 73372 RVA: 0x0029F124 File Offset: 0x0029D324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.itemMap_.WriteTo(ref output, PhantomReturnPreviewResponse._map_itemMap_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011E9D RID: 73373 RVA: 0x0029F174 File Offset: 0x0029D374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.itemMap_.CalculateSize(PhantomReturnPreviewResponse._map_itemMap_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011E9E RID: 73374 RVA: 0x0029F1C8 File Offset: 0x0029D3C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomReturnPreviewResponse other)
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

		// Token: 0x06011E9F RID: 73375 RVA: 0x0029F215 File Offset: 0x0029D415
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011EA0 RID: 73376 RVA: 0x0029F220 File Offset: 0x0029D420
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
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.itemMap_.AddEntriesFrom(ref input, PhantomReturnPreviewResponse._map_itemMap_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040070BE RID: 28862
		private UnknownFieldSet _unknownFields;

		// Token: 0x040070BF RID: 28863
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x040070C0 RID: 28864
		private ErrorCode errorCode_;

		// Token: 0x040070C1 RID: 28865
		public const int ItemMapFieldNumber = 11;

		// Token: 0x040070C2 RID: 28866
		private static readonly MapField<int, int>.Codec _map_itemMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 90U);

		// Token: 0x040070C3 RID: 28867
		private readonly MapField<int, int> itemMap_ = new MapField<int, int>();
	}
}
