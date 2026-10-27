using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D67 RID: 3431
	[NetMessage(EMessageId.PinballTeamReviveRequest)]
	public sealed class PinballTeamReviveRequest : IMessage<PinballTeamReviveRequest>, IMessage, IEquatable<PinballTeamReviveRequest>, IDeepCloneable<PinballTeamReviveRequest>, IBufferMessage
	{
		// Token: 0x06012802 RID: 75778 RVA: 0x002B2E91 File Offset: 0x002B1091
		[NullableContext(1)]
		public static PinballTeamReviveRequest Create()
		{
			return new PinballTeamReviveRequest();
		}

		// Token: 0x17003D52 RID: 15698
		// (get) Token: 0x06012803 RID: 75779 RVA: 0x002B2E98 File Offset: 0x002B1098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D53 RID: 15699
		// (get) Token: 0x06012804 RID: 75780 RVA: 0x002B2E9B File Offset: 0x002B109B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballTeamReviveRequest.Descriptor;
			}
		}

		// Token: 0x06012805 RID: 75781 RVA: 0x002B2EA2 File Offset: 0x002B10A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballTeamReviveRequest()
		{
		}

		// Token: 0x06012806 RID: 75782 RVA: 0x002B2EAA File Offset: 0x002B10AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballTeamReviveRequest(PinballTeamReviveRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012807 RID: 75783 RVA: 0x002B2EC3 File Offset: 0x002B10C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballTeamReviveRequest Clone()
		{
			return new PinballTeamReviveRequest(this);
		}

		// Token: 0x06012808 RID: 75784 RVA: 0x002B2ECB File Offset: 0x002B10CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballTeamReviveRequest);
		}

		// Token: 0x06012809 RID: 75785 RVA: 0x002B2ED9 File Offset: 0x002B10D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballTeamReviveRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601280A RID: 75786 RVA: 0x002B2EF8 File Offset: 0x002B10F8
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

		// Token: 0x0601280B RID: 75787 RVA: 0x002B2F1E File Offset: 0x002B111E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601280C RID: 75788 RVA: 0x002B2F2B File Offset: 0x002B112B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601280D RID: 75789 RVA: 0x002B2F34 File Offset: 0x002B1134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601280E RID: 75790 RVA: 0x002B2F4C File Offset: 0x002B114C
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

		// Token: 0x0601280F RID: 75791 RVA: 0x002B2F72 File Offset: 0x002B1172
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballTeamReviveRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012810 RID: 75792 RVA: 0x002B2F8F File Offset: 0x002B118F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012811 RID: 75793 RVA: 0x002B2F98 File Offset: 0x002B1198
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

		// Token: 0x04007304 RID: 29444
		private UnknownFieldSet _unknownFields;
	}
}
