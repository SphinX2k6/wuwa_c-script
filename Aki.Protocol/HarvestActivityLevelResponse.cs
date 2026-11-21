using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000730 RID: 1840
	[NetMessage(EMessageId.HarvestActivityLevelResponse)]
	public sealed class HarvestActivityLevelResponse : IMessage<HarvestActivityLevelResponse>, IMessage, IEquatable<HarvestActivityLevelResponse>, IDeepCloneable<HarvestActivityLevelResponse>, IBufferMessage
	{
		// Token: 0x0600A728 RID: 42792 RVA: 0x00192B38 File Offset: 0x00190D38
		[NullableContext(1)]
		public static HarvestActivityLevelResponse Create()
		{
			return new HarvestActivityLevelResponse();
		}

		// Token: 0x17002197 RID: 8599
		// (get) Token: 0x0600A729 RID: 42793 RVA: 0x00192B3F File Offset: 0x00190D3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002198 RID: 8600
		// (get) Token: 0x0600A72A RID: 42794 RVA: 0x00192B42 File Offset: 0x00190D42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HarvestActivityLevelResponse.Descriptor;
			}
		}

		// Token: 0x0600A72B RID: 42795 RVA: 0x00192B49 File Offset: 0x00190D49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityLevelResponse()
		{
		}

		// Token: 0x0600A72C RID: 42796 RVA: 0x00192B5C File Offset: 0x00190D5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityLevelResponse(HarvestActivityLevelResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.itemMap_ = other.itemMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A72D RID: 42797 RVA: 0x00192B92 File Offset: 0x00190D92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityLevelResponse Clone()
		{
			return new HarvestActivityLevelResponse(this);
		}

		// Token: 0x17002199 RID: 8601
		// (get) Token: 0x0600A72E RID: 42798 RVA: 0x00192B9A File Offset: 0x00190D9A
		// (set) Token: 0x0600A72F RID: 42799 RVA: 0x00192BA2 File Offset: 0x00190DA2
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

		// Token: 0x1700219A RID: 8602
		// (get) Token: 0x0600A730 RID: 42800 RVA: 0x00192BAB File Offset: 0x00190DAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ItemMap
		{
			get
			{
				return this.itemMap_;
			}
		}

		// Token: 0x0600A731 RID: 42801 RVA: 0x00192BB3 File Offset: 0x00190DB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HarvestActivityLevelResponse);
		}

		// Token: 0x0600A732 RID: 42802 RVA: 0x00192BC4 File Offset: 0x00190DC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HarvestActivityLevelResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.ItemMap.Equals(other.ItemMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A733 RID: 42803 RVA: 0x00192C14 File Offset: 0x00190E14
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

		// Token: 0x0600A734 RID: 42804 RVA: 0x00192C67 File Offset: 0x00190E67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A735 RID: 42805 RVA: 0x00192C74 File Offset: 0x00190E74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A736 RID: 42806 RVA: 0x00192C80 File Offset: 0x00190E80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.itemMap_.WriteTo(ref output, HarvestActivityLevelResponse._map_itemMap_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A737 RID: 42807 RVA: 0x00192CD0 File Offset: 0x00190ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.itemMap_.CalculateSize(HarvestActivityLevelResponse._map_itemMap_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A738 RID: 42808 RVA: 0x00192D24 File Offset: 0x00190F24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HarvestActivityLevelResponse other)
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

		// Token: 0x0600A739 RID: 42809 RVA: 0x00192D71 File Offset: 0x00190F71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A73A RID: 42810 RVA: 0x00192D7C File Offset: 0x00190F7C
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
					if (num != 34U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.itemMap_.AddEntriesFrom(ref input, HarvestActivityLevelResponse._map_itemMap_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004CD2 RID: 19666
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004CD3 RID: 19667
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04004CD4 RID: 19668
		private ErrorCode errorCode_;

		// Token: 0x04004CD5 RID: 19669
		public const int ItemMapFieldNumber = 4;

		// Token: 0x04004CD6 RID: 19670
		private static readonly MapField<int, int>.Codec _map_itemMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 34U);

		// Token: 0x04004CD7 RID: 19671
		private readonly MapField<int, int> itemMap_ = new MapField<int, int>();
	}
}
