using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200012A RID: 298
	public sealed class AttributeEventEffectData : IMessage<AttributeEventEffectData>, IMessage, IEquatable<AttributeEventEffectData>, IDeepCloneable<AttributeEventEffectData>, IBufferMessage
	{
		// Token: 0x060027EA RID: 10218 RVA: 0x00069A57 File Offset: 0x00067C57
		[NullableContext(1)]
		public static AttributeEventEffectData Create()
		{
			return new AttributeEventEffectData();
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x060027EB RID: 10219 RVA: 0x00069A5E File Offset: 0x00067C5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x060027EC RID: 10220 RVA: 0x00069A61 File Offset: 0x00067C61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AttributeEventEffectData.Descriptor;
			}
		}

		// Token: 0x060027ED RID: 10221 RVA: 0x00069A68 File Offset: 0x00067C68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttributeEventEffectData()
		{
		}

		// Token: 0x060027EE RID: 10222 RVA: 0x00069A7B File Offset: 0x00067C7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttributeEventEffectData(AttributeEventEffectData other) : this()
		{
			this.triggeredActiveHandles_ = other.triggeredActiveHandles_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060027EF RID: 10223 RVA: 0x00069AA5 File Offset: 0x00067CA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttributeEventEffectData Clone()
		{
			return new AttributeEventEffectData(this);
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x060027F0 RID: 10224 RVA: 0x00069AAD File Offset: 0x00067CAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TriggeredActiveHandles
		{
			get
			{
				return this.triggeredActiveHandles_;
			}
		}

		// Token: 0x060027F1 RID: 10225 RVA: 0x00069AB5 File Offset: 0x00067CB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AttributeEventEffectData);
		}

		// Token: 0x060027F2 RID: 10226 RVA: 0x00069AC3 File Offset: 0x00067CC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AttributeEventEffectData other)
		{
			return other != null && (other == this || (this.triggeredActiveHandles_.Equals(other.triggeredActiveHandles_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060027F3 RID: 10227 RVA: 0x00069AF8 File Offset: 0x00067CF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.triggeredActiveHandles_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060027F4 RID: 10228 RVA: 0x00069B2C File Offset: 0x00067D2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060027F5 RID: 10229 RVA: 0x00069B39 File Offset: 0x00067D39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060027F6 RID: 10230 RVA: 0x00069B42 File Offset: 0x00067D42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.triggeredActiveHandles_.WriteTo(ref output, AttributeEventEffectData._repeated_triggeredActiveHandles_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060027F7 RID: 10231 RVA: 0x00069B6C File Offset: 0x00067D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.triggeredActiveHandles_.CalculateSize(AttributeEventEffectData._repeated_triggeredActiveHandles_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060027F8 RID: 10232 RVA: 0x00069BA5 File Offset: 0x00067DA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AttributeEventEffectData other)
		{
			if (other == null)
			{
				return;
			}
			this.triggeredActiveHandles_.Add(other.triggeredActiveHandles_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060027F9 RID: 10233 RVA: 0x00069BD3 File Offset: 0x00067DD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060027FA RID: 10234 RVA: 0x00069BDC File Offset: 0x00067DDC
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
					this.triggeredActiveHandles_.AddEntriesFrom(ref input, AttributeEventEffectData._repeated_triggeredActiveHandles_codec);
				}
			}
		}

		// Token: 0x040026D5 RID: 9941
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026D6 RID: 9942
		public const int TriggeredActiveHandlesFieldNumber = 1;

		// Token: 0x040026D7 RID: 9943
		private static readonly FieldCodec<int> _repeated_triggeredActiveHandles_codec = FieldCodec.ForInt32(10U);

		// Token: 0x040026D8 RID: 9944
		private readonly RepeatedField<int> triggeredActiveHandles_ = new RepeatedField<int>();
	}
}
