using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D65 RID: 3429
	[NetMessage(EMessageId.PinballTeamDieRequest)]
	public sealed class PinballTeamDieRequest : IMessage<PinballTeamDieRequest>, IMessage, IEquatable<PinballTeamDieRequest>, IDeepCloneable<PinballTeamDieRequest>, IBufferMessage
	{
		// Token: 0x060127E0 RID: 75744 RVA: 0x002B2B75 File Offset: 0x002B0D75
		[NullableContext(1)]
		public static PinballTeamDieRequest Create()
		{
			return new PinballTeamDieRequest();
		}

		// Token: 0x17003D4D RID: 15693
		// (get) Token: 0x060127E1 RID: 75745 RVA: 0x002B2B7C File Offset: 0x002B0D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D4E RID: 15694
		// (get) Token: 0x060127E2 RID: 75746 RVA: 0x002B2B7F File Offset: 0x002B0D7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballTeamDieRequest.Descriptor;
			}
		}

		// Token: 0x060127E3 RID: 75747 RVA: 0x002B2B86 File Offset: 0x002B0D86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballTeamDieRequest()
		{
		}

		// Token: 0x060127E4 RID: 75748 RVA: 0x002B2B8E File Offset: 0x002B0D8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballTeamDieRequest(PinballTeamDieRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060127E5 RID: 75749 RVA: 0x002B2BA7 File Offset: 0x002B0DA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballTeamDieRequest Clone()
		{
			return new PinballTeamDieRequest(this);
		}

		// Token: 0x060127E6 RID: 75750 RVA: 0x002B2BAF File Offset: 0x002B0DAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballTeamDieRequest);
		}

		// Token: 0x060127E7 RID: 75751 RVA: 0x002B2BBD File Offset: 0x002B0DBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballTeamDieRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060127E8 RID: 75752 RVA: 0x002B2BDC File Offset: 0x002B0DDC
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

		// Token: 0x060127E9 RID: 75753 RVA: 0x002B2C02 File Offset: 0x002B0E02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060127EA RID: 75754 RVA: 0x002B2C0F File Offset: 0x002B0E0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060127EB RID: 75755 RVA: 0x002B2C18 File Offset: 0x002B0E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060127EC RID: 75756 RVA: 0x002B2C30 File Offset: 0x002B0E30
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

		// Token: 0x060127ED RID: 75757 RVA: 0x002B2C56 File Offset: 0x002B0E56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballTeamDieRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060127EE RID: 75758 RVA: 0x002B2C73 File Offset: 0x002B0E73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060127EF RID: 75759 RVA: 0x002B2C7C File Offset: 0x002B0E7C
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

		// Token: 0x04007300 RID: 29440
		private UnknownFieldSet _unknownFields;
	}
}
