using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AD1 RID: 2769
	[NetMessage(EMessageId.MowTowerSettlementRequest)]
	public sealed class MowTowerSettlementRequest : IMessage<MowTowerSettlementRequest>, IMessage, IEquatable<MowTowerSettlementRequest>, IDeepCloneable<MowTowerSettlementRequest>, IBufferMessage
	{
		// Token: 0x0600F115 RID: 61717 RVA: 0x00233A70 File Offset: 0x00231C70
		[NullableContext(1)]
		public static MowTowerSettlementRequest Create()
		{
			return new MowTowerSettlementRequest();
		}

		// Token: 0x1700311B RID: 12571
		// (get) Token: 0x0600F116 RID: 61718 RVA: 0x00233A77 File Offset: 0x00231C77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700311C RID: 12572
		// (get) Token: 0x0600F117 RID: 61719 RVA: 0x00233A7A File Offset: 0x00231C7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MowTowerSettlementRequest.Descriptor;
			}
		}

		// Token: 0x0600F118 RID: 61720 RVA: 0x00233A81 File Offset: 0x00231C81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerSettlementRequest()
		{
		}

		// Token: 0x0600F119 RID: 61721 RVA: 0x00233A89 File Offset: 0x00231C89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerSettlementRequest(MowTowerSettlementRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F11A RID: 61722 RVA: 0x00233AA2 File Offset: 0x00231CA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerSettlementRequest Clone()
		{
			return new MowTowerSettlementRequest(this);
		}

		// Token: 0x0600F11B RID: 61723 RVA: 0x00233AAA File Offset: 0x00231CAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MowTowerSettlementRequest);
		}

		// Token: 0x0600F11C RID: 61724 RVA: 0x00233AB8 File Offset: 0x00231CB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MowTowerSettlementRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600F11D RID: 61725 RVA: 0x00233AD8 File Offset: 0x00231CD8
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

		// Token: 0x0600F11E RID: 61726 RVA: 0x00233AFE File Offset: 0x00231CFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F11F RID: 61727 RVA: 0x00233B0B File Offset: 0x00231D0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F120 RID: 61728 RVA: 0x00233B14 File Offset: 0x00231D14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F121 RID: 61729 RVA: 0x00233B2C File Offset: 0x00231D2C
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

		// Token: 0x0600F122 RID: 61730 RVA: 0x00233B52 File Offset: 0x00231D52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MowTowerSettlementRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F123 RID: 61731 RVA: 0x00233B6F File Offset: 0x00231D6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F124 RID: 61732 RVA: 0x00233B78 File Offset: 0x00231D78
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

		// Token: 0x04006172 RID: 24946
		private UnknownFieldSet _unknownFields;
	}
}
