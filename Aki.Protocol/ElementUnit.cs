using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000418 RID: 1048
	public sealed class ElementUnit : IMessage<ElementUnit>, IMessage, IEquatable<ElementUnit>, IDeepCloneable<ElementUnit>, IBufferMessage
	{
		// Token: 0x0600652F RID: 25903 RVA: 0x000F3E08 File Offset: 0x000F2008
		[NullableContext(1)]
		public static ElementUnit Create()
		{
			return new ElementUnit();
		}

		// Token: 0x170012F7 RID: 4855
		// (get) Token: 0x06006530 RID: 25904 RVA: 0x000F3E0F File Offset: 0x000F200F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ElementUnit> Parser
		{
			get
			{
				return ElementUnit._parser;
			}
		}

		// Token: 0x170012F8 RID: 4856
		// (get) Token: 0x06006531 RID: 25905 RVA: 0x000F3E16 File Offset: 0x000F2016
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170012F9 RID: 4857
		// (get) Token: 0x06006532 RID: 25906 RVA: 0x000F3E19 File Offset: 0x000F2019
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ElementUnit.Descriptor;
			}
		}

		// Token: 0x06006533 RID: 25907 RVA: 0x000F3E20 File Offset: 0x000F2020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ElementUnit()
		{
		}

		// Token: 0x06006534 RID: 25908 RVA: 0x000F3E28 File Offset: 0x000F2028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ElementUnit(ElementUnit other) : this()
		{
			this.elementId_ = other.elementId_;
			this.count_ = other.count_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006535 RID: 25909 RVA: 0x000F3E59 File Offset: 0x000F2059
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ElementUnit Clone()
		{
			return new ElementUnit(this);
		}

		// Token: 0x170012FA RID: 4858
		// (get) Token: 0x06006536 RID: 25910 RVA: 0x000F3E61 File Offset: 0x000F2061
		// (set) Token: 0x06006537 RID: 25911 RVA: 0x000F3E69 File Offset: 0x000F2069
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

		// Token: 0x170012FB RID: 4859
		// (get) Token: 0x06006538 RID: 25912 RVA: 0x000F3E72 File Offset: 0x000F2072
		// (set) Token: 0x06006539 RID: 25913 RVA: 0x000F3E7A File Offset: 0x000F207A
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

		// Token: 0x0600653A RID: 25914 RVA: 0x000F3E83 File Offset: 0x000F2083
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ElementUnit);
		}

		// Token: 0x0600653B RID: 25915 RVA: 0x000F3E91 File Offset: 0x000F2091
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ElementUnit other)
		{
			return other != null && (other == this || (this.ElementId == other.ElementId && this.Count == other.Count && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600653C RID: 25916 RVA: 0x000F3ED0 File Offset: 0x000F20D0
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

		// Token: 0x0600653D RID: 25917 RVA: 0x000F3F28 File Offset: 0x000F2128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600653E RID: 25918 RVA: 0x000F3F35 File Offset: 0x000F2135
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600653F RID: 25919 RVA: 0x000F3F40 File Offset: 0x000F2140
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

		// Token: 0x06006540 RID: 25920 RVA: 0x000F3F98 File Offset: 0x000F2198
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

		// Token: 0x06006541 RID: 25921 RVA: 0x000F3FF0 File Offset: 0x000F21F0
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

		// Token: 0x06006542 RID: 25922 RVA: 0x000F4040 File Offset: 0x000F2240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006543 RID: 25923 RVA: 0x000F404C File Offset: 0x000F224C
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

		// Token: 0x04003922 RID: 14626
		private static readonly MessageParser<ElementUnit> _parser = new MessageParser<ElementUnit>(() => new ElementUnit());

		// Token: 0x04003923 RID: 14627
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003924 RID: 14628
		public const int ElementIdFieldNumber = 1;

		// Token: 0x04003925 RID: 14629
		private int elementId_;

		// Token: 0x04003926 RID: 14630
		public const int CountFieldNumber = 2;

		// Token: 0x04003927 RID: 14631
		private int count_;
	}
}
