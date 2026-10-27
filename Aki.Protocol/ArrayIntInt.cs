using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000112 RID: 274
	public sealed class ArrayIntInt : IMessage<ArrayIntInt>, IMessage, IEquatable<ArrayIntInt>, IDeepCloneable<ArrayIntInt>, IBufferMessage
	{
		// Token: 0x060025B5 RID: 9653 RVA: 0x000647E3 File Offset: 0x000629E3
		[NullableContext(1)]
		public static ArrayIntInt Create()
		{
			return new ArrayIntInt();
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x060025B6 RID: 9654 RVA: 0x000647EA File Offset: 0x000629EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ArrayIntInt> Parser
		{
			get
			{
				return ArrayIntInt._parser;
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x060025B7 RID: 9655 RVA: 0x000647F1 File Offset: 0x000629F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x060025B8 RID: 9656 RVA: 0x000647F4 File Offset: 0x000629F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ArrayIntInt.Descriptor;
			}
		}

		// Token: 0x060025B9 RID: 9657 RVA: 0x000647FB File Offset: 0x000629FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArrayIntInt()
		{
		}

		// Token: 0x060025BA RID: 9658 RVA: 0x00064803 File Offset: 0x00062A03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArrayIntInt(ArrayIntInt other) : this()
		{
			this.key_ = other.key_;
			this.value_ = other.value_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060025BB RID: 9659 RVA: 0x00064834 File Offset: 0x00062A34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArrayIntInt Clone()
		{
			return new ArrayIntInt(this);
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x060025BC RID: 9660 RVA: 0x0006483C File Offset: 0x00062A3C
		// (set) Token: 0x060025BD RID: 9661 RVA: 0x00064844 File Offset: 0x00062A44
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

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x060025BE RID: 9662 RVA: 0x0006484D File Offset: 0x00062A4D
		// (set) Token: 0x060025BF RID: 9663 RVA: 0x00064855 File Offset: 0x00062A55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Value
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

		// Token: 0x060025C0 RID: 9664 RVA: 0x0006485E File Offset: 0x00062A5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ArrayIntInt);
		}

		// Token: 0x060025C1 RID: 9665 RVA: 0x0006486C File Offset: 0x00062A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ArrayIntInt other)
		{
			return other != null && (other == this || (this.Key == other.Key && this.Value == other.Value && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060025C2 RID: 9666 RVA: 0x000648AC File Offset: 0x00062AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Key != 0)
			{
				num ^= this.Key.GetHashCode();
			}
			if (this.Value != 0)
			{
				num ^= this.Value.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060025C3 RID: 9667 RVA: 0x00064904 File Offset: 0x00062B04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060025C4 RID: 9668 RVA: 0x00064911 File Offset: 0x00062B11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060025C5 RID: 9669 RVA: 0x0006491C File Offset: 0x00062B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Key != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Key);
			}
			if (this.Value != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Value);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060025C6 RID: 9670 RVA: 0x00064974 File Offset: 0x00062B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Key != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Key);
			}
			if (this.Value != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Value);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060025C7 RID: 9671 RVA: 0x000649CC File Offset: 0x00062BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ArrayIntInt other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Key != 0)
			{
				this.Key = other.Key;
			}
			if (other.Value != 0)
			{
				this.Value = other.Value;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060025C8 RID: 9672 RVA: 0x00064A1C File Offset: 0x00062C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060025C9 RID: 9673 RVA: 0x00064A28 File Offset: 0x00062C28
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Value = input.ReadInt32();
					}
				}
				else
				{
					this.Key = input.ReadInt32();
				}
			}
		}

		// Token: 0x040025DE RID: 9694
		private static readonly MessageParser<ArrayIntInt> _parser = new MessageParser<ArrayIntInt>(() => new ArrayIntInt());

		// Token: 0x040025DF RID: 9695
		private UnknownFieldSet _unknownFields;

		// Token: 0x040025E0 RID: 9696
		public const int KeyFieldNumber = 1;

		// Token: 0x040025E1 RID: 9697
		private int key_;

		// Token: 0x040025E2 RID: 9698
		public const int ValueFieldNumber = 2;

		// Token: 0x040025E3 RID: 9699
		private int value_;
	}
}
