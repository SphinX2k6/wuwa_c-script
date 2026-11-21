using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AC1 RID: 2753
	[NetMessage(EMessageId.MowTowerSettlementResponse)]
	public sealed class MowTowerSettlementResponse : IMessage<MowTowerSettlementResponse>, IMessage, IEquatable<MowTowerSettlementResponse>, IDeepCloneable<MowTowerSettlementResponse>, IBufferMessage
	{
		// Token: 0x0600F00B RID: 61451 RVA: 0x0023199E File Offset: 0x0022FB9E
		[NullableContext(1)]
		public static MowTowerSettlementResponse Create()
		{
			return new MowTowerSettlementResponse();
		}

		// Token: 0x170030DF RID: 12511
		// (get) Token: 0x0600F00C RID: 61452 RVA: 0x002319A5 File Offset: 0x0022FBA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170030E0 RID: 12512
		// (get) Token: 0x0600F00D RID: 61453 RVA: 0x002319A8 File Offset: 0x0022FBA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MowTowerSettlementResponse.Descriptor;
			}
		}

		// Token: 0x0600F00E RID: 61454 RVA: 0x002319AF File Offset: 0x0022FBAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerSettlementResponse()
		{
		}

		// Token: 0x0600F00F RID: 61455 RVA: 0x002319B7 File Offset: 0x0022FBB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerSettlementResponse(MowTowerSettlementResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F010 RID: 61456 RVA: 0x002319DC File Offset: 0x0022FBDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerSettlementResponse Clone()
		{
			return new MowTowerSettlementResponse(this);
		}

		// Token: 0x170030E1 RID: 12513
		// (get) Token: 0x0600F011 RID: 61457 RVA: 0x002319E4 File Offset: 0x0022FBE4
		// (set) Token: 0x0600F012 RID: 61458 RVA: 0x002319EC File Offset: 0x0022FBEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x0600F013 RID: 61459 RVA: 0x002319F5 File Offset: 0x0022FBF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MowTowerSettlementResponse);
		}

		// Token: 0x0600F014 RID: 61460 RVA: 0x00231A03 File Offset: 0x0022FC03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MowTowerSettlementResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F015 RID: 61461 RVA: 0x00231A34 File Offset: 0x0022FC34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F016 RID: 61462 RVA: 0x00231A79 File Offset: 0x0022FC79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F017 RID: 61463 RVA: 0x00231A86 File Offset: 0x0022FC86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F018 RID: 61464 RVA: 0x00231A8F File Offset: 0x0022FC8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F019 RID: 61465 RVA: 0x00231AC4 File Offset: 0x0022FCC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F01A RID: 61466 RVA: 0x00231B02 File Offset: 0x0022FD02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MowTowerSettlementResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F01B RID: 61467 RVA: 0x00231B33 File Offset: 0x0022FD33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F01C RID: 61468 RVA: 0x00231B3C File Offset: 0x0022FD3C
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400617C RID: 24956
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400617D RID: 24957
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x0400617E RID: 24958
		private ErrorCode errorCode_;
	}
}
