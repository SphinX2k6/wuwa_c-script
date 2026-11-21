using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000982 RID: 2434
	[NetMessage(EMessageId.MapRemoveMarkRequest)]
	public sealed class MapRemoveMarkRequest : IMessage<MapRemoveMarkRequest>, IMessage, IEquatable<MapRemoveMarkRequest>, IDeepCloneable<MapRemoveMarkRequest>, IBufferMessage
	{
		// Token: 0x0600D64A RID: 54858 RVA: 0x001F89AC File Offset: 0x001F6BAC
		[NullableContext(1)]
		public static MapRemoveMarkRequest Create()
		{
			return new MapRemoveMarkRequest();
		}

		// Token: 0x17002B5F RID: 11103
		// (get) Token: 0x0600D64B RID: 54859 RVA: 0x001F89B3 File Offset: 0x001F6BB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B60 RID: 11104
		// (get) Token: 0x0600D64C RID: 54860 RVA: 0x001F89B6 File Offset: 0x001F6BB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapRemoveMarkRequest.Descriptor;
			}
		}

		// Token: 0x0600D64D RID: 54861 RVA: 0x001F89BD File Offset: 0x001F6BBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapRemoveMarkRequest()
		{
		}

		// Token: 0x0600D64E RID: 54862 RVA: 0x001F89D0 File Offset: 0x001F6BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapRemoveMarkRequest(MapRemoveMarkRequest other) : this()
		{
			this.markIds_ = other.markIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D64F RID: 54863 RVA: 0x001F89FA File Offset: 0x001F6BFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapRemoveMarkRequest Clone()
		{
			return new MapRemoveMarkRequest(this);
		}

		// Token: 0x17002B61 RID: 11105
		// (get) Token: 0x0600D650 RID: 54864 RVA: 0x001F8A02 File Offset: 0x001F6C02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MarkIds
		{
			get
			{
				return this.markIds_;
			}
		}

		// Token: 0x0600D651 RID: 54865 RVA: 0x001F8A0A File Offset: 0x001F6C0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapRemoveMarkRequest);
		}

		// Token: 0x0600D652 RID: 54866 RVA: 0x001F8A18 File Offset: 0x001F6C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapRemoveMarkRequest other)
		{
			return other != null && (other == this || (this.markIds_.Equals(other.markIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D653 RID: 54867 RVA: 0x001F8A4C File Offset: 0x001F6C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.markIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D654 RID: 54868 RVA: 0x001F8A80 File Offset: 0x001F6C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D655 RID: 54869 RVA: 0x001F8A8D File Offset: 0x001F6C8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D656 RID: 54870 RVA: 0x001F8A96 File Offset: 0x001F6C96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.markIds_.WriteTo(ref output, MapRemoveMarkRequest._repeated_markIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D657 RID: 54871 RVA: 0x001F8AC0 File Offset: 0x001F6CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.markIds_.CalculateSize(MapRemoveMarkRequest._repeated_markIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D658 RID: 54872 RVA: 0x001F8AF9 File Offset: 0x001F6CF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MapRemoveMarkRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.markIds_.Add(other.markIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D659 RID: 54873 RVA: 0x001F8B27 File Offset: 0x001F6D27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D65A RID: 54874 RVA: 0x001F8B30 File Offset: 0x001F6D30
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
				if (num != 112U && num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.markIds_.AddEntriesFrom(ref input, MapRemoveMarkRequest._repeated_markIds_codec);
				}
			}
		}

		// Token: 0x040059F1 RID: 23025
		private UnknownFieldSet _unknownFields;

		// Token: 0x040059F2 RID: 23026
		public const int MarkIdsFieldNumber = 14;

		// Token: 0x040059F3 RID: 23027
		private static readonly FieldCodec<int> _repeated_markIds_codec = FieldCodec.ForInt32(114U);

		// Token: 0x040059F4 RID: 23028
		private readonly RepeatedField<int> markIds_ = new RepeatedField<int>();
	}
}
