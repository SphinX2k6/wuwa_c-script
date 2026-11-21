using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000981 RID: 2433
	[NetMessage(EMessageId.MapRemoveAllMarkResponse)]
	public sealed class MapRemoveAllMarkResponse : IMessage<MapRemoveAllMarkResponse>, IMessage, IEquatable<MapRemoveAllMarkResponse>, IDeepCloneable<MapRemoveAllMarkResponse>, IBufferMessage
	{
		// Token: 0x0600D636 RID: 54838 RVA: 0x001F86F9 File Offset: 0x001F68F9
		[NullableContext(1)]
		public static MapRemoveAllMarkResponse Create()
		{
			return new MapRemoveAllMarkResponse();
		}

		// Token: 0x17002B5B RID: 11099
		// (get) Token: 0x0600D637 RID: 54839 RVA: 0x001F8700 File Offset: 0x001F6900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B5C RID: 11100
		// (get) Token: 0x0600D638 RID: 54840 RVA: 0x001F8703 File Offset: 0x001F6903
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapRemoveAllMarkResponse.Descriptor;
			}
		}

		// Token: 0x0600D639 RID: 54841 RVA: 0x001F870A File Offset: 0x001F690A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapRemoveAllMarkResponse()
		{
		}

		// Token: 0x0600D63A RID: 54842 RVA: 0x001F871D File Offset: 0x001F691D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapRemoveAllMarkResponse(MapRemoveAllMarkResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.markIdList_ = other.markIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D63B RID: 54843 RVA: 0x001F8753 File Offset: 0x001F6953
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapRemoveAllMarkResponse Clone()
		{
			return new MapRemoveAllMarkResponse(this);
		}

		// Token: 0x17002B5D RID: 11101
		// (get) Token: 0x0600D63C RID: 54844 RVA: 0x001F875B File Offset: 0x001F695B
		// (set) Token: 0x0600D63D RID: 54845 RVA: 0x001F8763 File Offset: 0x001F6963
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

		// Token: 0x17002B5E RID: 11102
		// (get) Token: 0x0600D63E RID: 54846 RVA: 0x001F876C File Offset: 0x001F696C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MarkIdList
		{
			get
			{
				return this.markIdList_;
			}
		}

		// Token: 0x0600D63F RID: 54847 RVA: 0x001F8774 File Offset: 0x001F6974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapRemoveAllMarkResponse);
		}

		// Token: 0x0600D640 RID: 54848 RVA: 0x001F8784 File Offset: 0x001F6984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapRemoveAllMarkResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.markIdList_.Equals(other.markIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D641 RID: 54849 RVA: 0x001F87D4 File Offset: 0x001F69D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.markIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D642 RID: 54850 RVA: 0x001F8827 File Offset: 0x001F6A27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D643 RID: 54851 RVA: 0x001F8834 File Offset: 0x001F6A34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D644 RID: 54852 RVA: 0x001F8840 File Offset: 0x001F6A40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.markIdList_.WriteTo(ref output, MapRemoveAllMarkResponse._repeated_markIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D645 RID: 54853 RVA: 0x001F8890 File Offset: 0x001F6A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.markIdList_.CalculateSize(MapRemoveAllMarkResponse._repeated_markIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D646 RID: 54854 RVA: 0x001F88E4 File Offset: 0x001F6AE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MapRemoveAllMarkResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.markIdList_.Add(other.markIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D647 RID: 54855 RVA: 0x001F8931 File Offset: 0x001F6B31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D648 RID: 54856 RVA: 0x001F893C File Offset: 0x001F6B3C
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
				if (num != 64U)
				{
					if (num != 80U && num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.markIdList_.AddEntriesFrom(ref input, MapRemoveAllMarkResponse._repeated_markIdList_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040059EB RID: 23019
		private UnknownFieldSet _unknownFields;

		// Token: 0x040059EC RID: 23020
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x040059ED RID: 23021
		private ErrorCode errorCode_;

		// Token: 0x040059EE RID: 23022
		public const int MarkIdListFieldNumber = 10;

		// Token: 0x040059EF RID: 23023
		private static readonly FieldCodec<int> _repeated_markIdList_codec = FieldCodec.ForInt32(82U);

		// Token: 0x040059F0 RID: 23024
		private readonly RepeatedField<int> markIdList_ = new RepeatedField<int>();
	}
}
