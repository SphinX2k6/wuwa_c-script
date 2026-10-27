using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000747 RID: 1863
	[NetMessage(EMessageId.HarvestActivityPointResponse)]
	public sealed class HarvestActivityPointResponse : IMessage<HarvestActivityPointResponse>, IMessage, IEquatable<HarvestActivityPointResponse>, IDeepCloneable<HarvestActivityPointResponse>, IBufferMessage
	{
		// Token: 0x0600A8BA RID: 43194 RVA: 0x00195D64 File Offset: 0x00193F64
		[NullableContext(1)]
		public static HarvestActivityPointResponse Create()
		{
			return new HarvestActivityPointResponse();
		}

		// Token: 0x170021ED RID: 8685
		// (get) Token: 0x0600A8BB RID: 43195 RVA: 0x00195D6B File Offset: 0x00193F6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170021EE RID: 8686
		// (get) Token: 0x0600A8BC RID: 43196 RVA: 0x00195D6E File Offset: 0x00193F6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HarvestActivityPointResponse.Descriptor;
			}
		}

		// Token: 0x0600A8BD RID: 43197 RVA: 0x00195D75 File Offset: 0x00193F75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityPointResponse()
		{
		}

		// Token: 0x0600A8BE RID: 43198 RVA: 0x00195D88 File Offset: 0x00193F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityPointResponse(HarvestActivityPointResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.itemMap_ = other.itemMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A8BF RID: 43199 RVA: 0x00195DBE File Offset: 0x00193FBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityPointResponse Clone()
		{
			return new HarvestActivityPointResponse(this);
		}

		// Token: 0x170021EF RID: 8687
		// (get) Token: 0x0600A8C0 RID: 43200 RVA: 0x00195DC6 File Offset: 0x00193FC6
		// (set) Token: 0x0600A8C1 RID: 43201 RVA: 0x00195DCE File Offset: 0x00193FCE
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

		// Token: 0x170021F0 RID: 8688
		// (get) Token: 0x0600A8C2 RID: 43202 RVA: 0x00195DD7 File Offset: 0x00193FD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ItemMap
		{
			get
			{
				return this.itemMap_;
			}
		}

		// Token: 0x0600A8C3 RID: 43203 RVA: 0x00195DDF File Offset: 0x00193FDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HarvestActivityPointResponse);
		}

		// Token: 0x0600A8C4 RID: 43204 RVA: 0x00195DF0 File Offset: 0x00193FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HarvestActivityPointResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.ItemMap.Equals(other.ItemMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A8C5 RID: 43205 RVA: 0x00195E40 File Offset: 0x00194040
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

		// Token: 0x0600A8C6 RID: 43206 RVA: 0x00195E93 File Offset: 0x00194093
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A8C7 RID: 43207 RVA: 0x00195EA0 File Offset: 0x001940A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A8C8 RID: 43208 RVA: 0x00195EAC File Offset: 0x001940AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.itemMap_.WriteTo(ref output, HarvestActivityPointResponse._map_itemMap_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A8C9 RID: 43209 RVA: 0x00195EFC File Offset: 0x001940FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.itemMap_.CalculateSize(HarvestActivityPointResponse._map_itemMap_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A8CA RID: 43210 RVA: 0x00195F50 File Offset: 0x00194150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HarvestActivityPointResponse other)
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

		// Token: 0x0600A8CB RID: 43211 RVA: 0x00195F9D File Offset: 0x0019419D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A8CC RID: 43212 RVA: 0x00195FA8 File Offset: 0x001941A8
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
				if (num != 26U)
				{
					if (num != 80U)
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
					this.itemMap_.AddEntriesFrom(ref input, HarvestActivityPointResponse._map_itemMap_codec);
				}
			}
		}

		// Token: 0x04004CEA RID: 19690
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004CEB RID: 19691
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04004CEC RID: 19692
		private ErrorCode errorCode_;

		// Token: 0x04004CED RID: 19693
		public const int ItemMapFieldNumber = 3;

		// Token: 0x04004CEE RID: 19694
		private static readonly MapField<int, int>.Codec _map_itemMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 26U);

		// Token: 0x04004CEF RID: 19695
		private readonly MapField<int, int> itemMap_ = new MapField<int, int>();
	}
}
