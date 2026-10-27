using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001160 RID: 4448
	public sealed class SceneItemAttributeComponentPb : IMessage<SceneItemAttributeComponentPb>, IMessage, IEquatable<SceneItemAttributeComponentPb>, IDeepCloneable<SceneItemAttributeComponentPb>, IBufferMessage
	{
		// Token: 0x06017B67 RID: 97127 RVA: 0x00371AB3 File Offset: 0x0036FCB3
		[NullableContext(1)]
		public static SceneItemAttributeComponentPb Create()
		{
			return new SceneItemAttributeComponentPb();
		}

		// Token: 0x17004FA2 RID: 20386
		// (get) Token: 0x06017B68 RID: 97128 RVA: 0x00371ABA File Offset: 0x0036FCBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004FA3 RID: 20387
		// (get) Token: 0x06017B69 RID: 97129 RVA: 0x00371ABD File Offset: 0x0036FCBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemAttributeComponentPb.Descriptor;
			}
		}

		// Token: 0x06017B6A RID: 97130 RVA: 0x00371AC4 File Offset: 0x0036FCC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemAttributeComponentPb()
		{
		}

		// Token: 0x06017B6B RID: 97131 RVA: 0x00371AD7 File Offset: 0x0036FCD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemAttributeComponentPb(SceneItemAttributeComponentPb other) : this()
		{
			this.attributeIds_ = other.attributeIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017B6C RID: 97132 RVA: 0x00371B01 File Offset: 0x0036FD01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemAttributeComponentPb Clone()
		{
			return new SceneItemAttributeComponentPb(this);
		}

		// Token: 0x17004FA4 RID: 20388
		// (get) Token: 0x06017B6D RID: 97133 RVA: 0x00371B09 File Offset: 0x0036FD09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> AttributeIds
		{
			get
			{
				return this.attributeIds_;
			}
		}

		// Token: 0x06017B6E RID: 97134 RVA: 0x00371B11 File Offset: 0x0036FD11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemAttributeComponentPb);
		}

		// Token: 0x06017B6F RID: 97135 RVA: 0x00371B1F File Offset: 0x0036FD1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemAttributeComponentPb other)
		{
			return other != null && (other == this || (this.attributeIds_.Equals(other.attributeIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017B70 RID: 97136 RVA: 0x00371B54 File Offset: 0x0036FD54
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

		// Token: 0x06017B71 RID: 97137 RVA: 0x00371B88 File Offset: 0x0036FD88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017B72 RID: 97138 RVA: 0x00371B95 File Offset: 0x0036FD95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017B73 RID: 97139 RVA: 0x00371B9E File Offset: 0x0036FD9E
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

		// Token: 0x06017B74 RID: 97140 RVA: 0x00371BC8 File Offset: 0x0036FDC8
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

		// Token: 0x06017B75 RID: 97141 RVA: 0x00371C01 File Offset: 0x0036FE01
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

		// Token: 0x06017B76 RID: 97142 RVA: 0x00371C2F File Offset: 0x0036FE2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017B77 RID: 97143 RVA: 0x00371C38 File Offset: 0x0036FE38
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

		// Token: 0x04008CCB RID: 36043
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008CCC RID: 36044
		public const int AttributeIdsFieldNumber = 1;

		// Token: 0x04008CCD RID: 36045
		private static readonly FieldCodec<int> _repeated_attributeIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04008CCE RID: 36046
		private readonly RepeatedField<int> attributeIds_ = new RepeatedField<int>();
	}
}
