using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AC0 RID: 2752
	[NetMessage(EMessageId.MowTowerSettlementRequest)]
	public sealed class MowTowerSettlementRequest : IMessage<MowTowerSettlementRequest>, IMessage, IEquatable<MowTowerSettlementRequest>, IDeepCloneable<MowTowerSettlementRequest>, IBufferMessage
	{
		// Token: 0x0600EFFB RID: 61435 RVA: 0x00231865 File Offset: 0x0022FA65
		[NullableContext(1)]
		public static MowTowerSettlementRequest Create()
		{
			return new MowTowerSettlementRequest();
		}

		// Token: 0x170030DD RID: 12509
		// (get) Token: 0x0600EFFC RID: 61436 RVA: 0x0023186C File Offset: 0x0022FA6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170030DE RID: 12510
		// (get) Token: 0x0600EFFD RID: 61437 RVA: 0x0023186F File Offset: 0x0022FA6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MowTowerSettlementRequest.Descriptor;
			}
		}

		// Token: 0x0600EFFE RID: 61438 RVA: 0x00231876 File Offset: 0x0022FA76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerSettlementRequest()
		{
		}

		// Token: 0x0600EFFF RID: 61439 RVA: 0x0023187E File Offset: 0x0022FA7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerSettlementRequest(MowTowerSettlementRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F000 RID: 61440 RVA: 0x00231897 File Offset: 0x0022FA97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerSettlementRequest Clone()
		{
			return new MowTowerSettlementRequest(this);
		}

		// Token: 0x0600F001 RID: 61441 RVA: 0x0023189F File Offset: 0x0022FA9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MowTowerSettlementRequest);
		}

		// Token: 0x0600F002 RID: 61442 RVA: 0x002318AD File Offset: 0x0022FAAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MowTowerSettlementRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600F003 RID: 61443 RVA: 0x002318CC File Offset: 0x0022FACC
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

		// Token: 0x0600F004 RID: 61444 RVA: 0x002318F2 File Offset: 0x0022FAF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F005 RID: 61445 RVA: 0x002318FF File Offset: 0x0022FAFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F006 RID: 61446 RVA: 0x00231908 File Offset: 0x0022FB08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F007 RID: 61447 RVA: 0x00231920 File Offset: 0x0022FB20
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

		// Token: 0x0600F008 RID: 61448 RVA: 0x00231946 File Offset: 0x0022FB46
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

		// Token: 0x0600F009 RID: 61449 RVA: 0x00231963 File Offset: 0x0022FB63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F00A RID: 61450 RVA: 0x0023196C File Offset: 0x0022FB6C
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

		// Token: 0x0400617B RID: 24955
		private UnknownFieldSet _unknownFields;
	}
}
