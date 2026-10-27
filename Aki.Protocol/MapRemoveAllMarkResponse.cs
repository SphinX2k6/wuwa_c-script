using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000992 RID: 2450
	[NetMessage(EMessageId.MapRemoveAllMarkResponse)]
	public sealed class MapRemoveAllMarkResponse : IMessage<MapRemoveAllMarkResponse>, IMessage, IEquatable<MapRemoveAllMarkResponse>, IDeepCloneable<MapRemoveAllMarkResponse>, IBufferMessage
	{
		// Token: 0x0600D750 RID: 55120 RVA: 0x001FA8E9 File Offset: 0x001F8AE9
		[NullableContext(1)]
		public static MapRemoveAllMarkResponse Create()
		{
			return new MapRemoveAllMarkResponse();
		}

		// Token: 0x17002B99 RID: 11161
		// (get) Token: 0x0600D751 RID: 55121 RVA: 0x001FA8F0 File Offset: 0x001F8AF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B9A RID: 11162
		// (get) Token: 0x0600D752 RID: 55122 RVA: 0x001FA8F3 File Offset: 0x001F8AF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapRemoveAllMarkResponse.Descriptor;
			}
		}

		// Token: 0x0600D753 RID: 55123 RVA: 0x001FA8FA File Offset: 0x001F8AFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapRemoveAllMarkResponse()
		{
		}

		// Token: 0x0600D754 RID: 55124 RVA: 0x001FA90D File Offset: 0x001F8B0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapRemoveAllMarkResponse(MapRemoveAllMarkResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.markIdList_ = other.markIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D755 RID: 55125 RVA: 0x001FA943 File Offset: 0x001F8B43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapRemoveAllMarkResponse Clone()
		{
			return new MapRemoveAllMarkResponse(this);
		}

		// Token: 0x17002B9B RID: 11163
		// (get) Token: 0x0600D756 RID: 55126 RVA: 0x001FA94B File Offset: 0x001F8B4B
		// (set) Token: 0x0600D757 RID: 55127 RVA: 0x001FA953 File Offset: 0x001F8B53
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

		// Token: 0x17002B9C RID: 11164
		// (get) Token: 0x0600D758 RID: 55128 RVA: 0x001FA95C File Offset: 0x001F8B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MarkIdList
		{
			get
			{
				return this.markIdList_;
			}
		}

		// Token: 0x0600D759 RID: 55129 RVA: 0x001FA964 File Offset: 0x001F8B64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapRemoveAllMarkResponse);
		}

		// Token: 0x0600D75A RID: 55130 RVA: 0x001FA974 File Offset: 0x001F8B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapRemoveAllMarkResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.markIdList_.Equals(other.markIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D75B RID: 55131 RVA: 0x001FA9C4 File Offset: 0x001F8BC4
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

		// Token: 0x0600D75C RID: 55132 RVA: 0x001FAA17 File Offset: 0x001F8C17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D75D RID: 55133 RVA: 0x001FAA24 File Offset: 0x001F8C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D75E RID: 55134 RVA: 0x001FAA30 File Offset: 0x001F8C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.markIdList_.WriteTo(ref output, MapRemoveAllMarkResponse._repeated_markIdList_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D75F RID: 55135 RVA: 0x001FAA80 File Offset: 0x001F8C80
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

		// Token: 0x0600D760 RID: 55136 RVA: 0x001FAAD4 File Offset: 0x001F8CD4
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

		// Token: 0x0600D761 RID: 55137 RVA: 0x001FAB21 File Offset: 0x001F8D21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D762 RID: 55138 RVA: 0x001FAB2C File Offset: 0x001F8D2C
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
				if (num != 32U && num != 34U)
				{
					if (num != 64U)
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
					this.markIdList_.AddEntriesFrom(ref input, MapRemoveAllMarkResponse._repeated_markIdList_codec);
				}
			}
		}

		// Token: 0x040059E2 RID: 23010
		private UnknownFieldSet _unknownFields;

		// Token: 0x040059E3 RID: 23011
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x040059E4 RID: 23012
		private ErrorCode errorCode_;

		// Token: 0x040059E5 RID: 23013
		public const int MarkIdListFieldNumber = 4;

		// Token: 0x040059E6 RID: 23014
		private static readonly FieldCodec<int> _repeated_markIdList_codec = FieldCodec.ForInt32(34U);

		// Token: 0x040059E7 RID: 23015
		private readonly RepeatedField<int> markIdList_ = new RepeatedField<int>();
	}
}
