using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012D6 RID: 4822
	[NetMessage(EMessageId.SpecialItemEquipRequest)]
	public sealed class SpecialItemEquipRequest : IMessage<SpecialItemEquipRequest>, IMessage, IEquatable<SpecialItemEquipRequest>, IDeepCloneable<SpecialItemEquipRequest>, IBufferMessage
	{
		// Token: 0x06019BCA RID: 105418 RVA: 0x003C13EB File Offset: 0x003BF5EB
		[NullableContext(1)]
		public static SpecialItemEquipRequest Create()
		{
			return new SpecialItemEquipRequest();
		}

		// Token: 0x1700572A RID: 22314
		// (get) Token: 0x06019BCB RID: 105419 RVA: 0x003C13F2 File Offset: 0x003BF5F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700572B RID: 22315
		// (get) Token: 0x06019BCC RID: 105420 RVA: 0x003C13F5 File Offset: 0x003BF5F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpecialItemEquipRequest.Descriptor;
			}
		}

		// Token: 0x06019BCD RID: 105421 RVA: 0x003C13FC File Offset: 0x003BF5FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpecialItemEquipRequest()
		{
		}

		// Token: 0x06019BCE RID: 105422 RVA: 0x003C1404 File Offset: 0x003BF604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpecialItemEquipRequest(SpecialItemEquipRequest other) : this()
		{
			this.itemId_ = other.itemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019BCF RID: 105423 RVA: 0x003C1429 File Offset: 0x003BF629
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpecialItemEquipRequest Clone()
		{
			return new SpecialItemEquipRequest(this);
		}

		// Token: 0x1700572C RID: 22316
		// (get) Token: 0x06019BD0 RID: 105424 RVA: 0x003C1431 File Offset: 0x003BF631
		// (set) Token: 0x06019BD1 RID: 105425 RVA: 0x003C1439 File Offset: 0x003BF639
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

		// Token: 0x06019BD2 RID: 105426 RVA: 0x003C1442 File Offset: 0x003BF642
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpecialItemEquipRequest);
		}

		// Token: 0x06019BD3 RID: 105427 RVA: 0x003C1450 File Offset: 0x003BF650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpecialItemEquipRequest other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019BD4 RID: 105428 RVA: 0x003C1480 File Offset: 0x003BF680
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

		// Token: 0x06019BD5 RID: 105429 RVA: 0x003C14BF File Offset: 0x003BF6BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019BD6 RID: 105430 RVA: 0x003C14CC File Offset: 0x003BF6CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019BD7 RID: 105431 RVA: 0x003C14D5 File Offset: 0x003BF6D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019BD8 RID: 105432 RVA: 0x003C1508 File Offset: 0x003BF708
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

		// Token: 0x06019BD9 RID: 105433 RVA: 0x003C1546 File Offset: 0x003BF746
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

		// Token: 0x06019BDA RID: 105434 RVA: 0x003C1577 File Offset: 0x003BF777
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019BDB RID: 105435 RVA: 0x003C1580 File Offset: 0x003BF780
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040097F9 RID: 38905
		private UnknownFieldSet _unknownFields;

		// Token: 0x040097FA RID: 38906
		public const int ItemIdFieldNumber = 9;

		// Token: 0x040097FB RID: 38907
		private int itemId_;
	}
}
