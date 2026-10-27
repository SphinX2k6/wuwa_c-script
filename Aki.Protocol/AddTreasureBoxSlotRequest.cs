using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000B4 RID: 180
	[NetMessage(EMessageId.AddTreasureBoxSlotRequest)]
	public sealed class AddTreasureBoxSlotRequest : IMessage<AddTreasureBoxSlotRequest>, IMessage, IEquatable<AddTreasureBoxSlotRequest>, IDeepCloneable<AddTreasureBoxSlotRequest>, IBufferMessage
	{
		// Token: 0x06001DCB RID: 7627 RVA: 0x00051C27 File Offset: 0x0004FE27
		[NullableContext(1)]
		public static AddTreasureBoxSlotRequest Create()
		{
			return new AddTreasureBoxSlotRequest();
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06001DCC RID: 7628 RVA: 0x00051C2E File Offset: 0x0004FE2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06001DCD RID: 7629 RVA: 0x00051C31 File Offset: 0x0004FE31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddTreasureBoxSlotRequest.Descriptor;
			}
		}

		// Token: 0x06001DCE RID: 7630 RVA: 0x00051C38 File Offset: 0x0004FE38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddTreasureBoxSlotRequest()
		{
		}

		// Token: 0x06001DCF RID: 7631 RVA: 0x00051C40 File Offset: 0x0004FE40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddTreasureBoxSlotRequest(AddTreasureBoxSlotRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001DD0 RID: 7632 RVA: 0x00051C59 File Offset: 0x0004FE59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddTreasureBoxSlotRequest Clone()
		{
			return new AddTreasureBoxSlotRequest(this);
		}

		// Token: 0x06001DD1 RID: 7633 RVA: 0x00051C61 File Offset: 0x0004FE61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddTreasureBoxSlotRequest);
		}

		// Token: 0x06001DD2 RID: 7634 RVA: 0x00051C6F File Offset: 0x0004FE6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddTreasureBoxSlotRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06001DD3 RID: 7635 RVA: 0x00051C90 File Offset: 0x0004FE90
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

		// Token: 0x06001DD4 RID: 7636 RVA: 0x00051CB6 File Offset: 0x0004FEB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001DD5 RID: 7637 RVA: 0x00051CC3 File Offset: 0x0004FEC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001DD6 RID: 7638 RVA: 0x00051CCC File Offset: 0x0004FECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001DD7 RID: 7639 RVA: 0x00051CE4 File Offset: 0x0004FEE4
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

		// Token: 0x06001DD8 RID: 7640 RVA: 0x00051D0A File Offset: 0x0004FF0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AddTreasureBoxSlotRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001DD9 RID: 7641 RVA: 0x00051D27 File Offset: 0x0004FF27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001DDA RID: 7642 RVA: 0x00051D30 File Offset: 0x0004FF30
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

		// Token: 0x04002334 RID: 9012
		private UnknownFieldSet _unknownFields;
	}
}
