using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012D9 RID: 4825
	[NetMessage(EMessageId.SpecialItemUnEquipRequest)]
	public sealed class SpecialItemUnEquipRequest : IMessage<SpecialItemUnEquipRequest>, IMessage, IEquatable<SpecialItemUnEquipRequest>, IDeepCloneable<SpecialItemUnEquipRequest>, IBufferMessage
	{
		// Token: 0x06019C00 RID: 105472 RVA: 0x003C197D File Offset: 0x003BFB7D
		[NullableContext(1)]
		public static SpecialItemUnEquipRequest Create()
		{
			return new SpecialItemUnEquipRequest();
		}

		// Token: 0x17005733 RID: 22323
		// (get) Token: 0x06019C01 RID: 105473 RVA: 0x003C1984 File Offset: 0x003BFB84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005734 RID: 22324
		// (get) Token: 0x06019C02 RID: 105474 RVA: 0x003C1987 File Offset: 0x003BFB87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpecialItemUnEquipRequest.Descriptor;
			}
		}

		// Token: 0x06019C03 RID: 105475 RVA: 0x003C198E File Offset: 0x003BFB8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpecialItemUnEquipRequest()
		{
		}

		// Token: 0x06019C04 RID: 105476 RVA: 0x003C1996 File Offset: 0x003BFB96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpecialItemUnEquipRequest(SpecialItemUnEquipRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019C05 RID: 105477 RVA: 0x003C19AF File Offset: 0x003BFBAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpecialItemUnEquipRequest Clone()
		{
			return new SpecialItemUnEquipRequest(this);
		}

		// Token: 0x06019C06 RID: 105478 RVA: 0x003C19B7 File Offset: 0x003BFBB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpecialItemUnEquipRequest);
		}

		// Token: 0x06019C07 RID: 105479 RVA: 0x003C19C5 File Offset: 0x003BFBC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpecialItemUnEquipRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06019C08 RID: 105480 RVA: 0x003C19E4 File Offset: 0x003BFBE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019C09 RID: 105481 RVA: 0x003C1A0A File Offset: 0x003BFC0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019C0A RID: 105482 RVA: 0x003C1A17 File Offset: 0x003BFC17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019C0B RID: 105483 RVA: 0x003C1A20 File Offset: 0x003BFC20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019C0C RID: 105484 RVA: 0x003C1A38 File Offset: 0x003BFC38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019C0D RID: 105485 RVA: 0x003C1A5E File Offset: 0x003BFC5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpecialItemUnEquipRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019C0E RID: 105486 RVA: 0x003C1A7B File Offset: 0x003BFC7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019C0F RID: 105487 RVA: 0x003C1A84 File Offset: 0x003BFC84
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009802 RID: 38914
		private UnknownFieldSet _unknownFields;
	}
}
