using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000744 RID: 1860
	[NetMessage(EMessageId.HarvestActivityLevelResponse)]
	public sealed class HarvestActivityLevelResponse : IMessage<HarvestActivityLevelResponse>, IMessage, IEquatable<HarvestActivityLevelResponse>, IDeepCloneable<HarvestActivityLevelResponse>, IBufferMessage
	{
		// Token: 0x0600A87E RID: 43134 RVA: 0x00195564 File Offset: 0x00193764
		[NullableContext(1)]
		public static HarvestActivityLevelResponse Create()
		{
			return new HarvestActivityLevelResponse();
		}

		// Token: 0x170021E1 RID: 8673
		// (get) Token: 0x0600A87F RID: 43135 RVA: 0x0019556B File Offset: 0x0019376B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170021E2 RID: 8674
		// (get) Token: 0x0600A880 RID: 43136 RVA: 0x0019556E File Offset: 0x0019376E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HarvestActivityLevelResponse.Descriptor;
			}
		}

		// Token: 0x0600A881 RID: 43137 RVA: 0x00195575 File Offset: 0x00193775
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityLevelResponse()
		{
		}

		// Token: 0x0600A882 RID: 43138 RVA: 0x00195588 File Offset: 0x00193788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityLevelResponse(HarvestActivityLevelResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.itemMap_ = other.itemMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A883 RID: 43139 RVA: 0x001955BE File Offset: 0x001937BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityLevelResponse Clone()
		{
			return new HarvestActivityLevelResponse(this);
		}

		// Token: 0x170021E3 RID: 8675
		// (get) Token: 0x0600A884 RID: 43140 RVA: 0x001955C6 File Offset: 0x001937C6
		// (set) Token: 0x0600A885 RID: 43141 RVA: 0x001955CE File Offset: 0x001937CE
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

		// Token: 0x170021E4 RID: 8676
		// (get) Token: 0x0600A886 RID: 43142 RVA: 0x001955D7 File Offset: 0x001937D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ItemMap
		{
			get
			{
				return this.itemMap_;
			}
		}

		// Token: 0x0600A887 RID: 43143 RVA: 0x001955DF File Offset: 0x001937DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HarvestActivityLevelResponse);
		}

		// Token: 0x0600A888 RID: 43144 RVA: 0x001955F0 File Offset: 0x001937F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HarvestActivityLevelResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.ItemMap.Equals(other.ItemMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A889 RID: 43145 RVA: 0x00195640 File Offset: 0x00193840
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

		// Token: 0x0600A88A RID: 43146 RVA: 0x00195693 File Offset: 0x00193893
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A88B RID: 43147 RVA: 0x001956A0 File Offset: 0x001938A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A88C RID: 43148 RVA: 0x001956AC File Offset: 0x001938AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.itemMap_.WriteTo(ref output, HarvestActivityLevelResponse._map_itemMap_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A88D RID: 43149 RVA: 0x001956FC File Offset: 0x001938FC
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

		// Token: 0x0600A88E RID: 43150 RVA: 0x00195750 File Offset: 0x00193950
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

		// Token: 0x0600A88F RID: 43151 RVA: 0x0019579D File Offset: 0x0019399D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A890 RID: 43152 RVA: 0x001957A8 File Offset: 0x001939A8
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
				if (num != 90U)
				{
					if (num != 96U)
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
					this.itemMap_.AddEntriesFrom(ref input, HarvestActivityLevelResponse._map_itemMap_codec);
				}
			}
		}

		// Token: 0x04004CD9 RID: 19673
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004CDA RID: 19674
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04004CDB RID: 19675
		private ErrorCode errorCode_;

		// Token: 0x04004CDC RID: 19676
		public const int ItemMapFieldNumber = 11;

		// Token: 0x04004CDD RID: 19677
		private static readonly MapField<int, int>.Codec _map_itemMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 90U);

		// Token: 0x04004CDE RID: 19678
		private readonly MapField<int, int> itemMap_ = new MapField<int, int>();
	}
}
