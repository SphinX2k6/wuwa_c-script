using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000983 RID: 2435
	[NetMessage(EMessageId.MapRemoveMarkResponse)]
	public sealed class MapRemoveMarkResponse : IMessage<MapRemoveMarkResponse>, IMessage, IEquatable<MapRemoveMarkResponse>, IDeepCloneable<MapRemoveMarkResponse>, IBufferMessage
	{
		// Token: 0x0600D65C RID: 54876 RVA: 0x001F8B8D File Offset: 0x001F6D8D
		[NullableContext(1)]
		public static MapRemoveMarkResponse Create()
		{
			return new MapRemoveMarkResponse();
		}

		// Token: 0x17002B62 RID: 11106
		// (get) Token: 0x0600D65D RID: 54877 RVA: 0x001F8B94 File Offset: 0x001F6D94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B63 RID: 11107
		// (get) Token: 0x0600D65E RID: 54878 RVA: 0x001F8B97 File Offset: 0x001F6D97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapRemoveMarkResponse.Descriptor;
			}
		}

		// Token: 0x0600D65F RID: 54879 RVA: 0x001F8B9E File Offset: 0x001F6D9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapRemoveMarkResponse()
		{
		}

		// Token: 0x0600D660 RID: 54880 RVA: 0x001F8BB1 File Offset: 0x001F6DB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapRemoveMarkResponse(MapRemoveMarkResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.markIds_ = other.markIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D661 RID: 54881 RVA: 0x001F8BE7 File Offset: 0x001F6DE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapRemoveMarkResponse Clone()
		{
			return new MapRemoveMarkResponse(this);
		}

		// Token: 0x17002B64 RID: 11108
		// (get) Token: 0x0600D662 RID: 54882 RVA: 0x001F8BEF File Offset: 0x001F6DEF
		// (set) Token: 0x0600D663 RID: 54883 RVA: 0x001F8BF7 File Offset: 0x001F6DF7
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

		// Token: 0x17002B65 RID: 11109
		// (get) Token: 0x0600D664 RID: 54884 RVA: 0x001F8C00 File Offset: 0x001F6E00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MarkIds
		{
			get
			{
				return this.markIds_;
			}
		}

		// Token: 0x0600D665 RID: 54885 RVA: 0x001F8C08 File Offset: 0x001F6E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapRemoveMarkResponse);
		}

		// Token: 0x0600D666 RID: 54886 RVA: 0x001F8C18 File Offset: 0x001F6E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapRemoveMarkResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.markIds_.Equals(other.markIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D667 RID: 54887 RVA: 0x001F8C68 File Offset: 0x001F6E68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.markIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D668 RID: 54888 RVA: 0x001F8CBB File Offset: 0x001F6EBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D669 RID: 54889 RVA: 0x001F8CC8 File Offset: 0x001F6EC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D66A RID: 54890 RVA: 0x001F8CD4 File Offset: 0x001F6ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.markIds_.WriteTo(ref output, MapRemoveMarkResponse._repeated_markIds_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D66B RID: 54891 RVA: 0x001F8D24 File Offset: 0x001F6F24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.markIds_.CalculateSize(MapRemoveMarkResponse._repeated_markIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D66C RID: 54892 RVA: 0x001F8D78 File Offset: 0x001F6F78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MapRemoveMarkResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.markIds_.Add(other.markIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D66D RID: 54893 RVA: 0x001F8DC5 File Offset: 0x001F6FC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D66E RID: 54894 RVA: 0x001F8DD0 File Offset: 0x001F6FD0
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
				if (num != 16U && num != 18U)
				{
					if (num != 72U)
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
					this.markIds_.AddEntriesFrom(ref input, MapRemoveMarkResponse._repeated_markIds_codec);
				}
			}
		}

		// Token: 0x040059F5 RID: 23029
		private UnknownFieldSet _unknownFields;

		// Token: 0x040059F6 RID: 23030
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x040059F7 RID: 23031
		private ErrorCode errorCode_;

		// Token: 0x040059F8 RID: 23032
		public const int MarkIdsFieldNumber = 2;

		// Token: 0x040059F9 RID: 23033
		private static readonly FieldCodec<int> _repeated_markIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x040059FA RID: 23034
		private readonly RepeatedField<int> markIds_ = new RepeatedField<int>();
	}
}
