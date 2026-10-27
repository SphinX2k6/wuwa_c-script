using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000111 RID: 273
	public sealed class ArrayIntDouble : IMessage<ArrayIntDouble>, IMessage, IEquatable<ArrayIntDouble>, IDeepCloneable<ArrayIntDouble>, IBufferMessage
	{
		// Token: 0x0600259F RID: 9631 RVA: 0x000644F9 File Offset: 0x000626F9
		[NullableContext(1)]
		public static ArrayIntDouble Create()
		{
			return new ArrayIntDouble();
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x060025A0 RID: 9632 RVA: 0x00064500 File Offset: 0x00062700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ArrayIntDouble> Parser
		{
			get
			{
				return ArrayIntDouble._parser;
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x060025A1 RID: 9633 RVA: 0x00064507 File Offset: 0x00062707
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x060025A2 RID: 9634 RVA: 0x0006450A File Offset: 0x0006270A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ArrayIntDouble.Descriptor;
			}
		}

		// Token: 0x060025A3 RID: 9635 RVA: 0x00064511 File Offset: 0x00062711
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArrayIntDouble()
		{
		}

		// Token: 0x060025A4 RID: 9636 RVA: 0x00064519 File Offset: 0x00062719
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArrayIntDouble(ArrayIntDouble other) : this()
		{
			this.key_ = other.key_;
			this.value_ = other.value_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060025A5 RID: 9637 RVA: 0x0006454A File Offset: 0x0006274A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArrayIntDouble Clone()
		{
			return new ArrayIntDouble(this);
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x060025A6 RID: 9638 RVA: 0x00064552 File Offset: 0x00062752
		// (set) Token: 0x060025A7 RID: 9639 RVA: 0x0006455A File Offset: 0x0006275A
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

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x060025A8 RID: 9640 RVA: 0x00064563 File Offset: 0x00062763
		// (set) Token: 0x060025A9 RID: 9641 RVA: 0x0006456B File Offset: 0x0006276B
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

		// Token: 0x060025AA RID: 9642 RVA: 0x00064574 File Offset: 0x00062774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ArrayIntDouble);
		}

		// Token: 0x060025AB RID: 9643 RVA: 0x00064584 File Offset: 0x00062784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ArrayIntDouble other)
		{
			return other != null && (other == this || (this.Key == other.Key && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Value, other.Value) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060025AC RID: 9644 RVA: 0x000645D8 File Offset: 0x000627D8
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

		// Token: 0x060025AD RID: 9645 RVA: 0x0006463B File Offset: 0x0006283B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060025AE RID: 9646 RVA: 0x00064648 File Offset: 0x00062848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060025AF RID: 9647 RVA: 0x00064654 File Offset: 0x00062854
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

		// Token: 0x060025B0 RID: 9648 RVA: 0x000646B8 File Offset: 0x000628B8
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

		// Token: 0x060025B1 RID: 9649 RVA: 0x0006470C File Offset: 0x0006290C
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

		// Token: 0x060025B2 RID: 9650 RVA: 0x00064765 File Offset: 0x00062965
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060025B3 RID: 9651 RVA: 0x00064770 File Offset: 0x00062970
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

		// Token: 0x040025D8 RID: 9688
		private static readonly MessageParser<ArrayIntDouble> _parser = new MessageParser<ArrayIntDouble>(() => new ArrayIntDouble());

		// Token: 0x040025D9 RID: 9689
		private UnknownFieldSet _unknownFields;

		// Token: 0x040025DA RID: 9690
		public const int KeyFieldNumber = 1;

		// Token: 0x040025DB RID: 9691
		private int key_;

		// Token: 0x040025DC RID: 9692
		public const int ValueFieldNumber = 2;

		// Token: 0x040025DD RID: 9693
		private double value_;
	}
}
