using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001267 RID: 4711
	[NetMessage(EMessageId.SpecialItemEquipRequest)]
	public sealed class SpecialItemEquipRequest : IMessage<SpecialItemEquipRequest>, IMessage, IEquatable<SpecialItemEquipRequest>, IDeepCloneable<SpecialItemEquipRequest>, IBufferMessage
	{
		// Token: 0x06019194 RID: 102804 RVA: 0x003A6CA7 File Offset: 0x003A4EA7
		[NullableContext(1)]
		public static SpecialItemEquipRequest Create()
		{
			return new SpecialItemEquipRequest();
		}

		// Token: 0x170054A9 RID: 21673
		// (get) Token: 0x06019195 RID: 102805 RVA: 0x003A6CAE File Offset: 0x003A4EAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170054AA RID: 21674
		// (get) Token: 0x06019196 RID: 102806 RVA: 0x003A6CB1 File Offset: 0x003A4EB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpecialItemEquipRequest.Descriptor;
			}
		}

		// Token: 0x06019197 RID: 102807 RVA: 0x003A6CB8 File Offset: 0x003A4EB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpecialItemEquipRequest()
		{
		}

		// Token: 0x06019198 RID: 102808 RVA: 0x003A6CC0 File Offset: 0x003A4EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpecialItemEquipRequest(SpecialItemEquipRequest other) : this()
		{
			this.itemId_ = other.itemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019199 RID: 102809 RVA: 0x003A6CE5 File Offset: 0x003A4EE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpecialItemEquipRequest Clone()
		{
			return new SpecialItemEquipRequest(this);
		}

		// Token: 0x170054AB RID: 21675
		// (get) Token: 0x0601919A RID: 102810 RVA: 0x003A6CED File Offset: 0x003A4EED
		// (set) Token: 0x0601919B RID: 102811 RVA: 0x003A6CF5 File Offset: 0x003A4EF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x0601919C RID: 102812 RVA: 0x003A6CFE File Offset: 0x003A4EFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpecialItemEquipRequest);
		}

		// Token: 0x0601919D RID: 102813 RVA: 0x003A6D0C File Offset: 0x003A4F0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpecialItemEquipRequest other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601919E RID: 102814 RVA: 0x003A6D3C File Offset: 0x003A4F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601919F RID: 102815 RVA: 0x003A6D7B File Offset: 0x003A4F7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060191A0 RID: 102816 RVA: 0x003A6D88 File Offset: 0x003A4F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060191A1 RID: 102817 RVA: 0x003A6D91 File Offset: 0x003A4F91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060191A2 RID: 102818 RVA: 0x003A6DC4 File Offset: 0x003A4FC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060191A3 RID: 102819 RVA: 0x003A6E02 File Offset: 0x003A5002
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpecialItemEquipRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060191A4 RID: 102820 RVA: 0x003A6E33 File Offset: 0x003A5033
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060191A5 RID: 102821 RVA: 0x003A6E3C File Offset: 0x003A503C
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040093CF RID: 37839
		private UnknownFieldSet _unknownFields;

		// Token: 0x040093D0 RID: 37840
		public const int ItemIdFieldNumber = 2;

		// Token: 0x040093D1 RID: 37841
		private int itemId_;
	}
}
