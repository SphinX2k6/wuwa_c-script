using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200126A RID: 4714
	[NetMessage(EMessageId.SpecialItemUnEquipRequest)]
	public sealed class SpecialItemUnEquipRequest : IMessage<SpecialItemUnEquipRequest>, IMessage, IEquatable<SpecialItemUnEquipRequest>, IDeepCloneable<SpecialItemUnEquipRequest>, IBufferMessage
	{
		// Token: 0x060191CA RID: 102858 RVA: 0x003A7239 File Offset: 0x003A5439
		[NullableContext(1)]
		public static SpecialItemUnEquipRequest Create()
		{
			return new SpecialItemUnEquipRequest();
		}

		// Token: 0x170054B2 RID: 21682
		// (get) Token: 0x060191CB RID: 102859 RVA: 0x003A7240 File Offset: 0x003A5440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170054B3 RID: 21683
		// (get) Token: 0x060191CC RID: 102860 RVA: 0x003A7243 File Offset: 0x003A5443
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpecialItemUnEquipRequest.Descriptor;
			}
		}

		// Token: 0x060191CD RID: 102861 RVA: 0x003A724A File Offset: 0x003A544A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpecialItemUnEquipRequest()
		{
		}

		// Token: 0x060191CE RID: 102862 RVA: 0x003A7252 File Offset: 0x003A5452
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpecialItemUnEquipRequest(SpecialItemUnEquipRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060191CF RID: 102863 RVA: 0x003A726B File Offset: 0x003A546B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpecialItemUnEquipRequest Clone()
		{
			return new SpecialItemUnEquipRequest(this);
		}

		// Token: 0x060191D0 RID: 102864 RVA: 0x003A7273 File Offset: 0x003A5473
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpecialItemUnEquipRequest);
		}

		// Token: 0x060191D1 RID: 102865 RVA: 0x003A7281 File Offset: 0x003A5481
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpecialItemUnEquipRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060191D2 RID: 102866 RVA: 0x003A72A0 File Offset: 0x003A54A0
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

		// Token: 0x060191D3 RID: 102867 RVA: 0x003A72C6 File Offset: 0x003A54C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060191D4 RID: 102868 RVA: 0x003A72D3 File Offset: 0x003A54D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060191D5 RID: 102869 RVA: 0x003A72DC File Offset: 0x003A54DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060191D6 RID: 102870 RVA: 0x003A72F4 File Offset: 0x003A54F4
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

		// Token: 0x060191D7 RID: 102871 RVA: 0x003A731A File Offset: 0x003A551A
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

		// Token: 0x060191D8 RID: 102872 RVA: 0x003A7337 File Offset: 0x003A5537
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060191D9 RID: 102873 RVA: 0x003A7340 File Offset: 0x003A5540
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

		// Token: 0x040093D8 RID: 37848
		private UnknownFieldSet _unknownFields;
	}
}
