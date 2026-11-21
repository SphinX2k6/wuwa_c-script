using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200119A RID: 4506
	public sealed class SceneItemAttributeComponentPb : IMessage<SceneItemAttributeComponentPb>, IMessage, IEquatable<SceneItemAttributeComponentPb>, IDeepCloneable<SceneItemAttributeComponentPb>, IBufferMessage
	{
		// Token: 0x06018108 RID: 98568 RVA: 0x00380E03 File Offset: 0x0037F003
		[NullableContext(1)]
		public static SceneItemAttributeComponentPb Create()
		{
			return new SceneItemAttributeComponentPb();
		}

		// Token: 0x1700510E RID: 20750
		// (get) Token: 0x06018109 RID: 98569 RVA: 0x00380E0A File Offset: 0x0037F00A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700510F RID: 20751
		// (get) Token: 0x0601810A RID: 98570 RVA: 0x00380E0D File Offset: 0x0037F00D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemAttributeComponentPb.Descriptor;
			}
		}

		// Token: 0x0601810B RID: 98571 RVA: 0x00380E14 File Offset: 0x0037F014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemAttributeComponentPb()
		{
		}

		// Token: 0x0601810C RID: 98572 RVA: 0x00380E27 File Offset: 0x0037F027
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemAttributeComponentPb(SceneItemAttributeComponentPb other) : this()
		{
			this.attributeIds_ = other.attributeIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601810D RID: 98573 RVA: 0x00380E51 File Offset: 0x0037F051
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemAttributeComponentPb Clone()
		{
			return new SceneItemAttributeComponentPb(this);
		}

		// Token: 0x17005110 RID: 20752
		// (get) Token: 0x0601810E RID: 98574 RVA: 0x00380E59 File Offset: 0x0037F059
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> AttributeIds
		{
			get
			{
				return this.attributeIds_;
			}
		}

		// Token: 0x0601810F RID: 98575 RVA: 0x00380E61 File Offset: 0x0037F061
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemAttributeComponentPb);
		}

		// Token: 0x06018110 RID: 98576 RVA: 0x00380E6F File Offset: 0x0037F06F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemAttributeComponentPb other)
		{
			return other != null && (other == this || (this.attributeIds_.Equals(other.attributeIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018111 RID: 98577 RVA: 0x00380EA4 File Offset: 0x0037F0A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.attributeIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018112 RID: 98578 RVA: 0x00380ED8 File Offset: 0x0037F0D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018113 RID: 98579 RVA: 0x00380EE5 File Offset: 0x0037F0E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018114 RID: 98580 RVA: 0x00380EEE File Offset: 0x0037F0EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.attributeIds_.WriteTo(ref output, SceneItemAttributeComponentPb._repeated_attributeIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018115 RID: 98581 RVA: 0x00380F18 File Offset: 0x0037F118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.attributeIds_.CalculateSize(SceneItemAttributeComponentPb._repeated_attributeIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018116 RID: 98582 RVA: 0x00380F51 File Offset: 0x0037F151
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneItemAttributeComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			this.attributeIds_.Add(other.attributeIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018117 RID: 98583 RVA: 0x00380F7F File Offset: 0x0037F17F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018118 RID: 98584 RVA: 0x00380F88 File Offset: 0x0037F188
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
				if (num != 8U && num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.attributeIds_.AddEntriesFrom(ref input, SceneItemAttributeComponentPb._repeated_attributeIds_codec);
				}
			}
		}

		// Token: 0x04008F5E RID: 36702
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008F5F RID: 36703
		public const int AttributeIdsFieldNumber = 1;

		// Token: 0x04008F60 RID: 36704
		private static readonly FieldCodec<int> _repeated_attributeIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04008F61 RID: 36705
		private readonly RepeatedField<int> attributeIds_ = new RepeatedField<int>();
	}
}
