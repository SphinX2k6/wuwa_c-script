using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000994 RID: 2452
	[NetMessage(EMessageId.MapRemoveMarkResponse)]
	public sealed class MapRemoveMarkResponse : IMessage<MapRemoveMarkResponse>, IMessage, IEquatable<MapRemoveMarkResponse>, IDeepCloneable<MapRemoveMarkResponse>, IBufferMessage
	{
		// Token: 0x0600D776 RID: 55158 RVA: 0x001FAD7D File Offset: 0x001F8F7D
		[NullableContext(1)]
		public static MapRemoveMarkResponse Create()
		{
			return new MapRemoveMarkResponse();
		}

		// Token: 0x17002BA0 RID: 11168
		// (get) Token: 0x0600D777 RID: 55159 RVA: 0x001FAD84 File Offset: 0x001F8F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002BA1 RID: 11169
		// (get) Token: 0x0600D778 RID: 55160 RVA: 0x001FAD87 File Offset: 0x001F8F87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapRemoveMarkResponse.Descriptor;
			}
		}

		// Token: 0x0600D779 RID: 55161 RVA: 0x001FAD8E File Offset: 0x001F8F8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapRemoveMarkResponse()
		{
		}

		// Token: 0x0600D77A RID: 55162 RVA: 0x001FADA1 File Offset: 0x001F8FA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapRemoveMarkResponse(MapRemoveMarkResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.markIds_ = other.markIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D77B RID: 55163 RVA: 0x001FADD7 File Offset: 0x001F8FD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapRemoveMarkResponse Clone()
		{
			return new MapRemoveMarkResponse(this);
		}

		// Token: 0x17002BA2 RID: 11170
		// (get) Token: 0x0600D77C RID: 55164 RVA: 0x001FADDF File Offset: 0x001F8FDF
		// (set) Token: 0x0600D77D RID: 55165 RVA: 0x001FADE7 File Offset: 0x001F8FE7
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

		// Token: 0x17002BA3 RID: 11171
		// (get) Token: 0x0600D77E RID: 55166 RVA: 0x001FADF0 File Offset: 0x001F8FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MarkIds
		{
			get
			{
				return this.markIds_;
			}
		}

		// Token: 0x0600D77F RID: 55167 RVA: 0x001FADF8 File Offset: 0x001F8FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapRemoveMarkResponse);
		}

		// Token: 0x0600D780 RID: 55168 RVA: 0x001FAE08 File Offset: 0x001F9008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapRemoveMarkResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.markIds_.Equals(other.markIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D781 RID: 55169 RVA: 0x001FAE58 File Offset: 0x001F9058
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

		// Token: 0x0600D782 RID: 55170 RVA: 0x001FAEAB File Offset: 0x001F90AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D783 RID: 55171 RVA: 0x001FAEB8 File Offset: 0x001F90B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D784 RID: 55172 RVA: 0x001FAEC4 File Offset: 0x001F90C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.markIds_.WriteTo(ref output, MapRemoveMarkResponse._repeated_markIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D785 RID: 55173 RVA: 0x001FAF14 File Offset: 0x001F9114
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

		// Token: 0x0600D786 RID: 55174 RVA: 0x001FAF68 File Offset: 0x001F9168
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

		// Token: 0x0600D787 RID: 55175 RVA: 0x001FAFB5 File Offset: 0x001F91B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D788 RID: 55176 RVA: 0x001FAFC0 File Offset: 0x001F91C0
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
				if (num != 8U)
				{
					if (num != 72U && num != 74U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.markIds_.AddEntriesFrom(ref input, MapRemoveMarkResponse._repeated_markIds_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040059EC RID: 23020
		private UnknownFieldSet _unknownFields;

		// Token: 0x040059ED RID: 23021
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x040059EE RID: 23022
		private ErrorCode errorCode_;

		// Token: 0x040059EF RID: 23023
		public const int MarkIdsFieldNumber = 9;

		// Token: 0x040059F0 RID: 23024
		private static readonly FieldCodec<int> _repeated_markIds_codec = FieldCodec.ForInt32(74U);

		// Token: 0x040059F1 RID: 23025
		private readonly RepeatedField<int> markIds_ = new RepeatedField<int>();
	}
}
