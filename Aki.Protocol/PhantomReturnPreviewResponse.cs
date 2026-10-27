using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CFC RID: 3324
	[NetMessage(EMessageId.PhantomReturnPreviewResponse)]
	public sealed class PhantomReturnPreviewResponse : IMessage<PhantomReturnPreviewResponse>, IMessage, IEquatable<PhantomReturnPreviewResponse>, IDeepCloneable<PhantomReturnPreviewResponse>, IBufferMessage
	{
		// Token: 0x06011F8A RID: 73610 RVA: 0x002A0BF5 File Offset: 0x0029EDF5
		[NullableContext(1)]
		public static PhantomReturnPreviewResponse Create()
		{
			return new PhantomReturnPreviewResponse();
		}

		// Token: 0x17003B8E RID: 15246
		// (get) Token: 0x06011F8B RID: 73611 RVA: 0x002A0BFC File Offset: 0x0029EDFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B8F RID: 15247
		// (get) Token: 0x06011F8C RID: 73612 RVA: 0x002A0BFF File Offset: 0x0029EDFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomReturnPreviewResponse.Descriptor;
			}
		}

		// Token: 0x06011F8D RID: 73613 RVA: 0x002A0C06 File Offset: 0x0029EE06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomReturnPreviewResponse()
		{
		}

		// Token: 0x06011F8E RID: 73614 RVA: 0x002A0C19 File Offset: 0x0029EE19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomReturnPreviewResponse(PhantomReturnPreviewResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.itemMap_ = other.itemMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011F8F RID: 73615 RVA: 0x002A0C4F File Offset: 0x0029EE4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomReturnPreviewResponse Clone()
		{
			return new PhantomReturnPreviewResponse(this);
		}

		// Token: 0x17003B90 RID: 15248
		// (get) Token: 0x06011F90 RID: 73616 RVA: 0x002A0C57 File Offset: 0x0029EE57
		// (set) Token: 0x06011F91 RID: 73617 RVA: 0x002A0C5F File Offset: 0x0029EE5F
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

		// Token: 0x17003B91 RID: 15249
		// (get) Token: 0x06011F92 RID: 73618 RVA: 0x002A0C68 File Offset: 0x0029EE68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ItemMap
		{
			get
			{
				return this.itemMap_;
			}
		}

		// Token: 0x06011F93 RID: 73619 RVA: 0x002A0C70 File Offset: 0x0029EE70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomReturnPreviewResponse);
		}

		// Token: 0x06011F94 RID: 73620 RVA: 0x002A0C80 File Offset: 0x0029EE80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomReturnPreviewResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.ItemMap.Equals(other.ItemMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011F95 RID: 73621 RVA: 0x002A0CD0 File Offset: 0x0029EED0
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

		// Token: 0x06011F96 RID: 73622 RVA: 0x002A0D23 File Offset: 0x0029EF23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011F97 RID: 73623 RVA: 0x002A0D30 File Offset: 0x0029EF30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011F98 RID: 73624 RVA: 0x002A0D3C File Offset: 0x0029EF3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.itemMap_.WriteTo(ref output, PhantomReturnPreviewResponse._map_itemMap_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011F99 RID: 73625 RVA: 0x002A0D8C File Offset: 0x0029EF8C
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

		// Token: 0x06011F9A RID: 73626 RVA: 0x002A0DE0 File Offset: 0x0029EFE0
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

		// Token: 0x06011F9B RID: 73627 RVA: 0x002A0E2D File Offset: 0x0029F02D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011F9C RID: 73628 RVA: 0x002A0E38 File Offset: 0x0029F038
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
				if (num != 56U)
				{
					if (num != 114U)
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

		// Token: 0x040070A6 RID: 28838
		private UnknownFieldSet _unknownFields;

		// Token: 0x040070A7 RID: 28839
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x040070A8 RID: 28840
		private ErrorCode errorCode_;

		// Token: 0x040070A9 RID: 28841
		public const int ItemMapFieldNumber = 14;

		// Token: 0x040070AA RID: 28842
		private static readonly MapField<int, int>.Codec _map_itemMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 114U);

		// Token: 0x040070AB RID: 28843
		private readonly MapField<int, int> itemMap_ = new MapField<int, int>();
	}
}
