using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008E9 RID: 2281
	public sealed class LeaveInstEscActionCtxPb : IMessage<LeaveInstEscActionCtxPb>, IMessage, IEquatable<LeaveInstEscActionCtxPb>, IDeepCloneable<LeaveInstEscActionCtxPb>, IBufferMessage
	{
		// Token: 0x0600C9C6 RID: 51654 RVA: 0x001DCD55 File Offset: 0x001DAF55
		[NullableContext(1)]
		public static LeaveInstEscActionCtxPb Create()
		{
			return new LeaveInstEscActionCtxPb();
		}

		// Token: 0x170028C1 RID: 10433
		// (get) Token: 0x0600C9C7 RID: 51655 RVA: 0x001DCD5C File Offset: 0x001DAF5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170028C2 RID: 10434
		// (get) Token: 0x0600C9C8 RID: 51656 RVA: 0x001DCD5F File Offset: 0x001DAF5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LeaveInstEscActionCtxPb.Descriptor;
			}
		}

		// Token: 0x0600C9C9 RID: 51657 RVA: 0x001DCD66 File Offset: 0x001DAF66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveInstEscActionCtxPb()
		{
		}

		// Token: 0x0600C9CA RID: 51658 RVA: 0x001DCD6E File Offset: 0x001DAF6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveInstEscActionCtxPb(LeaveInstEscActionCtxPb other) : this()
		{
			this.instConfigId_ = other.instConfigId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C9CB RID: 51659 RVA: 0x001DCD93 File Offset: 0x001DAF93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveInstEscActionCtxPb Clone()
		{
			return new LeaveInstEscActionCtxPb(this);
		}

		// Token: 0x170028C3 RID: 10435
		// (get) Token: 0x0600C9CC RID: 51660 RVA: 0x001DCD9B File Offset: 0x001DAF9B
		// (set) Token: 0x0600C9CD RID: 51661 RVA: 0x001DCDA3 File Offset: 0x001DAFA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstConfigId
		{
			get
			{
				return this.instConfigId_;
			}
			set
			{
				this.instConfigId_ = value;
			}
		}

		// Token: 0x0600C9CE RID: 51662 RVA: 0x001DCDAC File Offset: 0x001DAFAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LeaveInstEscActionCtxPb);
		}

		// Token: 0x0600C9CF RID: 51663 RVA: 0x001DCDBA File Offset: 0x001DAFBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LeaveInstEscActionCtxPb other)
		{
			return other != null && (other == this || (this.InstConfigId == other.InstConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C9D0 RID: 51664 RVA: 0x001DCDE8 File Offset: 0x001DAFE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstConfigId != 0)
			{
				num ^= this.InstConfigId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C9D1 RID: 51665 RVA: 0x001DCE27 File Offset: 0x001DB027
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C9D2 RID: 51666 RVA: 0x001DCE34 File Offset: 0x001DB034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C9D3 RID: 51667 RVA: 0x001DCE3D File Offset: 0x001DB03D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.InstConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C9D4 RID: 51668 RVA: 0x001DCE70 File Offset: 0x001DB070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstConfigId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C9D5 RID: 51669 RVA: 0x001DCEAE File Offset: 0x001DB0AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LeaveInstEscActionCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstConfigId != 0)
			{
				this.InstConfigId = other.InstConfigId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C9D6 RID: 51670 RVA: 0x001DCEDF File Offset: 0x001DB0DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C9D7 RID: 51671 RVA: 0x001DCEE8 File Offset: 0x001DB0E8
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.InstConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005604 RID: 22020
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005605 RID: 22021
		public const int InstConfigIdFieldNumber = 1;

		// Token: 0x04005606 RID: 22022
		private int instConfigId_;
	}
}
