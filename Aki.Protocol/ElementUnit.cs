using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200042F RID: 1071
	public sealed class ElementUnit : IMessage<ElementUnit>, IMessage, IEquatable<ElementUnit>, IDeepCloneable<ElementUnit>, IBufferMessage
	{
		// Token: 0x060066BF RID: 26303 RVA: 0x000F6F7C File Offset: 0x000F517C
		[NullableContext(1)]
		public static ElementUnit Create()
		{
			return new ElementUnit();
		}

		// Token: 0x1700134C RID: 4940
		// (get) Token: 0x060066C0 RID: 26304 RVA: 0x000F6F83 File Offset: 0x000F5183
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ElementUnit> Parser
		{
			get
			{
				return ElementUnit._parser;
			}
		}

		// Token: 0x1700134D RID: 4941
		// (get) Token: 0x060066C1 RID: 26305 RVA: 0x000F6F8A File Offset: 0x000F518A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700134E RID: 4942
		// (get) Token: 0x060066C2 RID: 26306 RVA: 0x000F6F8D File Offset: 0x000F518D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ElementUnit.Descriptor;
			}
		}

		// Token: 0x060066C3 RID: 26307 RVA: 0x000F6F94 File Offset: 0x000F5194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ElementUnit()
		{
		}

		// Token: 0x060066C4 RID: 26308 RVA: 0x000F6F9C File Offset: 0x000F519C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ElementUnit(ElementUnit other) : this()
		{
			this.elementId_ = other.elementId_;
			this.count_ = other.count_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060066C5 RID: 26309 RVA: 0x000F6FCD File Offset: 0x000F51CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ElementUnit Clone()
		{
			return new ElementUnit(this);
		}

		// Token: 0x1700134F RID: 4943
		// (get) Token: 0x060066C6 RID: 26310 RVA: 0x000F6FD5 File Offset: 0x000F51D5
		// (set) Token: 0x060066C7 RID: 26311 RVA: 0x000F6FDD File Offset: 0x000F51DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ElementId
		{
			get
			{
				return this.elementId_;
			}
			set
			{
				this.elementId_ = value;
			}
		}

		// Token: 0x17001350 RID: 4944
		// (get) Token: 0x060066C8 RID: 26312 RVA: 0x000F6FE6 File Offset: 0x000F51E6
		// (set) Token: 0x060066C9 RID: 26313 RVA: 0x000F6FEE File Offset: 0x000F51EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x060066CA RID: 26314 RVA: 0x000F6FF7 File Offset: 0x000F51F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ElementUnit);
		}

		// Token: 0x060066CB RID: 26315 RVA: 0x000F7005 File Offset: 0x000F5205
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ElementUnit other)
		{
			return other != null && (other == this || (this.ElementId == other.ElementId && this.Count == other.Count && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060066CC RID: 26316 RVA: 0x000F7044 File Offset: 0x000F5244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ElementId != 0)
			{
				num ^= this.ElementId.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060066CD RID: 26317 RVA: 0x000F709C File Offset: 0x000F529C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060066CE RID: 26318 RVA: 0x000F70A9 File Offset: 0x000F52A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060066CF RID: 26319 RVA: 0x000F70B4 File Offset: 0x000F52B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ElementId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ElementId);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Count);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060066D0 RID: 26320 RVA: 0x000F710C File Offset: 0x000F530C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ElementId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ElementId);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060066D1 RID: 26321 RVA: 0x000F7164 File Offset: 0x000F5364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ElementUnit other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ElementId != 0)
			{
				this.ElementId = other.ElementId;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060066D2 RID: 26322 RVA: 0x000F71B4 File Offset: 0x000F53B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060066D3 RID: 26323 RVA: 0x000F71C0 File Offset: 0x000F53C0
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
						this.Count = input.ReadInt32();
					}
				}
				else
				{
					this.ElementId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003935 RID: 14645
		private static readonly MessageParser<ElementUnit> _parser = new MessageParser<ElementUnit>(() => new ElementUnit());

		// Token: 0x04003936 RID: 14646
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003937 RID: 14647
		public const int ElementIdFieldNumber = 1;

		// Token: 0x04003938 RID: 14648
		private int elementId_;

		// Token: 0x04003939 RID: 14649
		public const int CountFieldNumber = 2;

		// Token: 0x0400393A RID: 14650
		private int count_;
	}
}
