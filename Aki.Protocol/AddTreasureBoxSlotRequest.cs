using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000B5 RID: 181
	[NetMessage(EMessageId.AddTreasureBoxSlotRequest)]
	public sealed class AddTreasureBoxSlotRequest : IMessage<AddTreasureBoxSlotRequest>, IMessage, IEquatable<AddTreasureBoxSlotRequest>, IDeepCloneable<AddTreasureBoxSlotRequest>, IBufferMessage
	{
		// Token: 0x06001E14 RID: 7700 RVA: 0x000528DB File Offset: 0x00050ADB
		[NullableContext(1)]
		public static AddTreasureBoxSlotRequest Create()
		{
			return new AddTreasureBoxSlotRequest();
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06001E15 RID: 7701 RVA: 0x000528E2 File Offset: 0x00050AE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06001E16 RID: 7702 RVA: 0x000528E5 File Offset: 0x00050AE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddTreasureBoxSlotRequest.Descriptor;
			}
		}

		// Token: 0x06001E17 RID: 7703 RVA: 0x000528EC File Offset: 0x00050AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddTreasureBoxSlotRequest()
		{
		}

		// Token: 0x06001E18 RID: 7704 RVA: 0x000528F4 File Offset: 0x00050AF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddTreasureBoxSlotRequest(AddTreasureBoxSlotRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001E19 RID: 7705 RVA: 0x0005290D File Offset: 0x00050B0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddTreasureBoxSlotRequest Clone()
		{
			return new AddTreasureBoxSlotRequest(this);
		}

		// Token: 0x06001E1A RID: 7706 RVA: 0x00052915 File Offset: 0x00050B15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddTreasureBoxSlotRequest);
		}

		// Token: 0x06001E1B RID: 7707 RVA: 0x00052923 File Offset: 0x00050B23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddTreasureBoxSlotRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06001E1C RID: 7708 RVA: 0x00052944 File Offset: 0x00050B44
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

		// Token: 0x06001E1D RID: 7709 RVA: 0x0005296A File Offset: 0x00050B6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001E1E RID: 7710 RVA: 0x00052977 File Offset: 0x00050B77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001E1F RID: 7711 RVA: 0x00052980 File Offset: 0x00050B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001E20 RID: 7712 RVA: 0x00052998 File Offset: 0x00050B98
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

		// Token: 0x06001E21 RID: 7713 RVA: 0x000529BE File Offset: 0x00050BBE
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

		// Token: 0x06001E22 RID: 7714 RVA: 0x000529DB File Offset: 0x00050BDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001E23 RID: 7715 RVA: 0x000529E4 File Offset: 0x00050BE4
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

		// Token: 0x04002397 RID: 9111
		private UnknownFieldSet _unknownFields;
	}
}
