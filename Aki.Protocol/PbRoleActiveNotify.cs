using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C0C RID: 3084
	[NetMessage(EMessageId.PbRoleActiveNotify)]
	public sealed class PbRoleActiveNotify : IMessage<PbRoleActiveNotify>, IMessage, IEquatable<PbRoleActiveNotify>, IDeepCloneable<PbRoleActiveNotify>, IBufferMessage
	{
		// Token: 0x06010BE6 RID: 68582 RVA: 0x00273BDF File Offset: 0x00271DDF
		[NullableContext(1)]
		public static PbRoleActiveNotify Create()
		{
			return new PbRoleActiveNotify();
		}

		// Token: 0x17003740 RID: 14144
		// (get) Token: 0x06010BE7 RID: 68583 RVA: 0x00273BE6 File Offset: 0x00271DE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003741 RID: 14145
		// (get) Token: 0x06010BE8 RID: 68584 RVA: 0x00273BE9 File Offset: 0x00271DE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PbRoleActiveNotify.Descriptor;
			}
		}

		// Token: 0x06010BE9 RID: 68585 RVA: 0x00273BF0 File Offset: 0x00271DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbRoleActiveNotify()
		{
		}

		// Token: 0x06010BEA RID: 68586 RVA: 0x00273BF8 File Offset: 0x00271DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbRoleActiveNotify(PbRoleActiveNotify other) : this()
		{
			this.role_ = ((other.role_ != null) ? other.role_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010BEB RID: 68587 RVA: 0x00273C2D File Offset: 0x00271E2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbRoleActiveNotify Clone()
		{
			return new PbRoleActiveNotify(this);
		}

		// Token: 0x17003742 RID: 14146
		// (get) Token: 0x06010BEC RID: 68588 RVA: 0x00273C35 File Offset: 0x00271E35
		// (set) Token: 0x06010BED RID: 68589 RVA: 0x00273C3D File Offset: 0x00271E3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public roleInfo Role
		{
			get
			{
				return this.role_;
			}
			set
			{
				this.role_ = value;
			}
		}

		// Token: 0x06010BEE RID: 68590 RVA: 0x00273C46 File Offset: 0x00271E46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PbRoleActiveNotify);
		}

		// Token: 0x06010BEF RID: 68591 RVA: 0x00273C54 File Offset: 0x00271E54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PbRoleActiveNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Role, other.Role) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010BF0 RID: 68592 RVA: 0x00273C88 File Offset: 0x00271E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.role_ != null)
			{
				num ^= this.Role.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010BF1 RID: 68593 RVA: 0x00273CC4 File Offset: 0x00271EC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010BF2 RID: 68594 RVA: 0x00273CD1 File Offset: 0x00271ED1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010BF3 RID: 68595 RVA: 0x00273CDA File Offset: 0x00271EDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.role_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.Role);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010BF4 RID: 68596 RVA: 0x00273D0C File Offset: 0x00271F0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.role_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Role);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010BF5 RID: 68597 RVA: 0x00273D4C File Offset: 0x00271F4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PbRoleActiveNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.role_ != null)
			{
				if (this.role_ == null)
				{
					this.Role = new roleInfo();
				}
				this.Role.MergeFrom(other.Role);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010BF6 RID: 68598 RVA: 0x00273DA0 File Offset: 0x00271FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010BF7 RID: 68599 RVA: 0x00273DAC File Offset: 0x00271FAC
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
				if (num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.role_ == null)
					{
						this.Role = new roleInfo();
					}
					input.ReadMessage(this.Role);
				}
			}
		}

		// Token: 0x04006A63 RID: 27235
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006A64 RID: 27236
		public const int RoleFieldNumber = 6;

		// Token: 0x04006A65 RID: 27237
		private roleInfo role_;
	}
}
