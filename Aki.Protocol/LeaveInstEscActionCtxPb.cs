using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008D8 RID: 2264
	public sealed class LeaveInstEscActionCtxPb : IMessage<LeaveInstEscActionCtxPb>, IMessage, IEquatable<LeaveInstEscActionCtxPb>, IDeepCloneable<LeaveInstEscActionCtxPb>, IBufferMessage
	{
		// Token: 0x0600C8AA RID: 51370 RVA: 0x001DAA79 File Offset: 0x001D8C79
		[NullableContext(1)]
		public static LeaveInstEscActionCtxPb Create()
		{
			return new LeaveInstEscActionCtxPb();
		}

		// Token: 0x17002882 RID: 10370
		// (get) Token: 0x0600C8AB RID: 51371 RVA: 0x001DAA80 File Offset: 0x001D8C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002883 RID: 10371
		// (get) Token: 0x0600C8AC RID: 51372 RVA: 0x001DAA83 File Offset: 0x001D8C83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LeaveInstEscActionCtxPb.Descriptor;
			}
		}

		// Token: 0x0600C8AD RID: 51373 RVA: 0x001DAA8A File Offset: 0x001D8C8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveInstEscActionCtxPb()
		{
		}

		// Token: 0x0600C8AE RID: 51374 RVA: 0x001DAA92 File Offset: 0x001D8C92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveInstEscActionCtxPb(LeaveInstEscActionCtxPb other) : this()
		{
			this.instConfigId_ = other.instConfigId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C8AF RID: 51375 RVA: 0x001DAAB7 File Offset: 0x001D8CB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveInstEscActionCtxPb Clone()
		{
			return new LeaveInstEscActionCtxPb(this);
		}

		// Token: 0x17002884 RID: 10372
		// (get) Token: 0x0600C8B0 RID: 51376 RVA: 0x001DAABF File Offset: 0x001D8CBF
		// (set) Token: 0x0600C8B1 RID: 51377 RVA: 0x001DAAC7 File Offset: 0x001D8CC7
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

		// Token: 0x0600C8B2 RID: 51378 RVA: 0x001DAAD0 File Offset: 0x001D8CD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LeaveInstEscActionCtxPb);
		}

		// Token: 0x0600C8B3 RID: 51379 RVA: 0x001DAADE File Offset: 0x001D8CDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LeaveInstEscActionCtxPb other)
		{
			return other != null && (other == this || (this.InstConfigId == other.InstConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C8B4 RID: 51380 RVA: 0x001DAB0C File Offset: 0x001D8D0C
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

		// Token: 0x0600C8B5 RID: 51381 RVA: 0x001DAB4B File Offset: 0x001D8D4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C8B6 RID: 51382 RVA: 0x001DAB58 File Offset: 0x001D8D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C8B7 RID: 51383 RVA: 0x001DAB61 File Offset: 0x001D8D61
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

		// Token: 0x0600C8B8 RID: 51384 RVA: 0x001DAB94 File Offset: 0x001D8D94
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

		// Token: 0x0600C8B9 RID: 51385 RVA: 0x001DABD2 File Offset: 0x001D8DD2
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

		// Token: 0x0600C8BA RID: 51386 RVA: 0x001DAC03 File Offset: 0x001D8E03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C8BB RID: 51387 RVA: 0x001DAC0C File Offset: 0x001D8E0C
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

		// Token: 0x0400560B RID: 22027
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400560C RID: 22028
		public const int InstConfigIdFieldNumber = 1;

		// Token: 0x0400560D RID: 22029
		private int instConfigId_;
	}
}
