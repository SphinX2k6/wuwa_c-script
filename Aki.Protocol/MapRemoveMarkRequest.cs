using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000993 RID: 2451
	[NetMessage(EMessageId.MapRemoveMarkRequest)]
	public sealed class MapRemoveMarkRequest : IMessage<MapRemoveMarkRequest>, IMessage, IEquatable<MapRemoveMarkRequest>, IDeepCloneable<MapRemoveMarkRequest>, IBufferMessage
	{
		// Token: 0x0600D764 RID: 55140 RVA: 0x001FAB9C File Offset: 0x001F8D9C
		[NullableContext(1)]
		public static MapRemoveMarkRequest Create()
		{
			return new MapRemoveMarkRequest();
		}

		// Token: 0x17002B9D RID: 11165
		// (get) Token: 0x0600D765 RID: 55141 RVA: 0x001FABA3 File Offset: 0x001F8DA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B9E RID: 11166
		// (get) Token: 0x0600D766 RID: 55142 RVA: 0x001FABA6 File Offset: 0x001F8DA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapRemoveMarkRequest.Descriptor;
			}
		}

		// Token: 0x0600D767 RID: 55143 RVA: 0x001FABAD File Offset: 0x001F8DAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapRemoveMarkRequest()
		{
		}

		// Token: 0x0600D768 RID: 55144 RVA: 0x001FABC0 File Offset: 0x001F8DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapRemoveMarkRequest(MapRemoveMarkRequest other) : this()
		{
			this.markIds_ = other.markIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D769 RID: 55145 RVA: 0x001FABEA File Offset: 0x001F8DEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapRemoveMarkRequest Clone()
		{
			return new MapRemoveMarkRequest(this);
		}

		// Token: 0x17002B9F RID: 11167
		// (get) Token: 0x0600D76A RID: 55146 RVA: 0x001FABF2 File Offset: 0x001F8DF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MarkIds
		{
			get
			{
				return this.markIds_;
			}
		}

		// Token: 0x0600D76B RID: 55147 RVA: 0x001FABFA File Offset: 0x001F8DFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapRemoveMarkRequest);
		}

		// Token: 0x0600D76C RID: 55148 RVA: 0x001FAC08 File Offset: 0x001F8E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapRemoveMarkRequest other)
		{
			return other != null && (other == this || (this.markIds_.Equals(other.markIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D76D RID: 55149 RVA: 0x001FAC3C File Offset: 0x001F8E3C
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

		// Token: 0x0600D76E RID: 55150 RVA: 0x001FAC70 File Offset: 0x001F8E70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D76F RID: 55151 RVA: 0x001FAC7D File Offset: 0x001F8E7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D770 RID: 55152 RVA: 0x001FAC86 File Offset: 0x001F8E86
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

		// Token: 0x0600D771 RID: 55153 RVA: 0x001FACB0 File Offset: 0x001F8EB0
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

		// Token: 0x0600D772 RID: 55154 RVA: 0x001FACE9 File Offset: 0x001F8EE9
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

		// Token: 0x0600D773 RID: 55155 RVA: 0x001FAD17 File Offset: 0x001F8F17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D774 RID: 55156 RVA: 0x001FAD20 File Offset: 0x001F8F20
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
				if (num != 56U && num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.markIds_.AddEntriesFrom(ref input, MapRemoveMarkRequest._repeated_markIds_codec);
				}
			}
		}

		// Token: 0x040059E8 RID: 23016
		private UnknownFieldSet _unknownFields;

		// Token: 0x040059E9 RID: 23017
		public const int MarkIdsFieldNumber = 7;

		// Token: 0x040059EA RID: 23018
		private static readonly FieldCodec<int> _repeated_markIds_codec = FieldCodec.ForInt32(58U);

		// Token: 0x040059EB RID: 23019
		private readonly RepeatedField<int> markIds_ = new RepeatedField<int>();
	}
}
