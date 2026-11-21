using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000113 RID: 275
	public sealed class ArrayIntDouble : IMessage<ArrayIntDouble>, IMessage, IEquatable<ArrayIntDouble>, IDeepCloneable<ArrayIntDouble>, IBufferMessage
	{
		// Token: 0x060025FE RID: 9726 RVA: 0x0006551D File Offset: 0x0006371D
		[NullableContext(1)]
		public static ArrayIntDouble Create()
		{
			return new ArrayIntDouble();
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x060025FF RID: 9727 RVA: 0x00065524 File Offset: 0x00063724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ArrayIntDouble> Parser
		{
			get
			{
				return ArrayIntDouble._parser;
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06002600 RID: 9728 RVA: 0x0006552B File Offset: 0x0006372B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06002601 RID: 9729 RVA: 0x0006552E File Offset: 0x0006372E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ArrayIntDouble.Descriptor;
			}
		}

		// Token: 0x06002602 RID: 9730 RVA: 0x00065535 File Offset: 0x00063735
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArrayIntDouble()
		{
		}

		// Token: 0x06002603 RID: 9731 RVA: 0x0006553D File Offset: 0x0006373D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArrayIntDouble(ArrayIntDouble other) : this()
		{
			this.key_ = other.key_;
			this.value_ = other.value_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002604 RID: 9732 RVA: 0x0006556E File Offset: 0x0006376E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArrayIntDouble Clone()
		{
			return new ArrayIntDouble(this);
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06002605 RID: 9733 RVA: 0x00065576 File Offset: 0x00063776
		// (set) Token: 0x06002606 RID: 9734 RVA: 0x0006557E File Offset: 0x0006377E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Key
		{
			get
			{
				return this.key_;
			}
			set
			{
				this.key_ = value;
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06002607 RID: 9735 RVA: 0x00065587 File Offset: 0x00063787
		// (set) Token: 0x06002608 RID: 9736 RVA: 0x0006558F File Offset: 0x0006378F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double Value
		{
			get
			{
				return this.value_;
			}
			set
			{
				this.value_ = value;
			}
		}

		// Token: 0x06002609 RID: 9737 RVA: 0x00065598 File Offset: 0x00063798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ArrayIntDouble);
		}

		// Token: 0x0600260A RID: 9738 RVA: 0x000655A8 File Offset: 0x000637A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ArrayIntDouble other)
		{
			return other != null && (other == this || (this.Key == other.Key && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Value, other.Value) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600260B RID: 9739 RVA: 0x000655FC File Offset: 0x000637FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Key != 0)
			{
				num ^= this.Key.GetHashCode();
			}
			if (this.Value != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.Value);
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600260C RID: 9740 RVA: 0x0006565F File Offset: 0x0006385F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600260D RID: 9741 RVA: 0x0006566C File Offset: 0x0006386C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600260E RID: 9742 RVA: 0x00065678 File Offset: 0x00063878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Key != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Key);
			}
			if (this.Value != 0.0)
			{
				output.WriteRawTag(17);
				output.WriteDouble(this.Value);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600260F RID: 9743 RVA: 0x000656DC File Offset: 0x000638DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Key != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Key);
			}
			if (this.Value != 0.0)
			{
				num += 9;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002610 RID: 9744 RVA: 0x00065730 File Offset: 0x00063930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ArrayIntDouble other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Key != 0)
			{
				this.Key = other.Key;
			}
			if (other.Value != 0.0)
			{
				this.Value = other.Value;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002611 RID: 9745 RVA: 0x00065789 File Offset: 0x00063989
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002612 RID: 9746 RVA: 0x00065794 File Offset: 0x00063994
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
					if (num != 17U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Value = input.ReadDouble();
					}
				}
				else
				{
					this.Key = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002643 RID: 9795
		private static readonly MessageParser<ArrayIntDouble> _parser = new MessageParser<ArrayIntDouble>(() => new ArrayIntDouble());

		// Token: 0x04002644 RID: 9796
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002645 RID: 9797
		public const int KeyFieldNumber = 1;

		// Token: 0x04002646 RID: 9798
		private int key_;

		// Token: 0x04002647 RID: 9799
		public const int ValueFieldNumber = 2;

		// Token: 0x04002648 RID: 9800
		private double value_;
	}
}
