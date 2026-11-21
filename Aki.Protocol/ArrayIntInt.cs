using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000114 RID: 276
	public sealed class ArrayIntInt : IMessage<ArrayIntInt>, IMessage, IEquatable<ArrayIntInt>, IDeepCloneable<ArrayIntInt>, IBufferMessage
	{
		// Token: 0x06002614 RID: 9748 RVA: 0x00065807 File Offset: 0x00063A07
		[NullableContext(1)]
		public static ArrayIntInt Create()
		{
			return new ArrayIntInt();
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06002615 RID: 9749 RVA: 0x0006580E File Offset: 0x00063A0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ArrayIntInt> Parser
		{
			get
			{
				return ArrayIntInt._parser;
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06002616 RID: 9750 RVA: 0x00065815 File Offset: 0x00063A15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06002617 RID: 9751 RVA: 0x00065818 File Offset: 0x00063A18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ArrayIntInt.Descriptor;
			}
		}

		// Token: 0x06002618 RID: 9752 RVA: 0x0006581F File Offset: 0x00063A1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArrayIntInt()
		{
		}

		// Token: 0x06002619 RID: 9753 RVA: 0x00065827 File Offset: 0x00063A27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArrayIntInt(ArrayIntInt other) : this()
		{
			this.key_ = other.key_;
			this.value_ = other.value_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600261A RID: 9754 RVA: 0x00065858 File Offset: 0x00063A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArrayIntInt Clone()
		{
			return new ArrayIntInt(this);
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x0600261B RID: 9755 RVA: 0x00065860 File Offset: 0x00063A60
		// (set) Token: 0x0600261C RID: 9756 RVA: 0x00065868 File Offset: 0x00063A68
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

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x0600261D RID: 9757 RVA: 0x00065871 File Offset: 0x00063A71
		// (set) Token: 0x0600261E RID: 9758 RVA: 0x00065879 File Offset: 0x00063A79
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

		// Token: 0x0600261F RID: 9759 RVA: 0x00065882 File Offset: 0x00063A82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ArrayIntInt);
		}

		// Token: 0x06002620 RID: 9760 RVA: 0x00065890 File Offset: 0x00063A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ArrayIntInt other)
		{
			return other != null && (other == this || (this.Key == other.Key && this.Value == other.Value && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002621 RID: 9761 RVA: 0x000658D0 File Offset: 0x00063AD0
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

		// Token: 0x06002622 RID: 9762 RVA: 0x00065928 File Offset: 0x00063B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002623 RID: 9763 RVA: 0x00065935 File Offset: 0x00063B35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002624 RID: 9764 RVA: 0x00065940 File Offset: 0x00063B40
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

		// Token: 0x06002625 RID: 9765 RVA: 0x00065998 File Offset: 0x00063B98
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

		// Token: 0x06002626 RID: 9766 RVA: 0x000659F0 File Offset: 0x00063BF0
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

		// Token: 0x06002627 RID: 9767 RVA: 0x00065A40 File Offset: 0x00063C40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002628 RID: 9768 RVA: 0x00065A4C File Offset: 0x00063C4C
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

		// Token: 0x04002649 RID: 9801
		private static readonly MessageParser<ArrayIntInt> _parser = new MessageParser<ArrayIntInt>(() => new ArrayIntInt());

		// Token: 0x0400264A RID: 9802
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400264B RID: 9803
		public const int KeyFieldNumber = 1;

		// Token: 0x0400264C RID: 9804
		private int key_;

		// Token: 0x0400264D RID: 9805
		public const int ValueFieldNumber = 2;

		// Token: 0x0400264E RID: 9806
		private int value_;
	}
}
