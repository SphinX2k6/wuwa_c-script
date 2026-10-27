using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001058 RID: 4184
	[NetMessage(EMessageId.RoleBreakThroughViewRequest)]
	public sealed class RoleBreakThroughViewRequest : IMessage<RoleBreakThroughViewRequest>, IMessage, IEquatable<RoleBreakThroughViewRequest>, IDeepCloneable<RoleBreakThroughViewRequest>, IBufferMessage
	{
		// Token: 0x060165B4 RID: 91572 RVA: 0x0033FA8D File Offset: 0x0033DC8D
		[NullableContext(1)]
		public static RoleBreakThroughViewRequest Create()
		{
			return new RoleBreakThroughViewRequest();
		}

		// Token: 0x17004AC9 RID: 19145
		// (get) Token: 0x060165B5 RID: 91573 RVA: 0x0033FA94 File Offset: 0x0033DC94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004ACA RID: 19146
		// (get) Token: 0x060165B6 RID: 91574 RVA: 0x0033FA97 File Offset: 0x0033DC97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleBreakThroughViewRequest.Descriptor;
			}
		}

		// Token: 0x060165B7 RID: 91575 RVA: 0x0033FA9E File Offset: 0x0033DC9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleBreakThroughViewRequest()
		{
		}

		// Token: 0x060165B8 RID: 91576 RVA: 0x0033FAA6 File Offset: 0x0033DCA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleBreakThroughViewRequest(RoleBreakThroughViewRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060165B9 RID: 91577 RVA: 0x0033FACB File Offset: 0x0033DCCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleBreakThroughViewRequest Clone()
		{
			return new RoleBreakThroughViewRequest(this);
		}

		// Token: 0x17004ACB RID: 19147
		// (get) Token: 0x060165BA RID: 91578 RVA: 0x0033FAD3 File Offset: 0x0033DCD3
		// (set) Token: 0x060165BB RID: 91579 RVA: 0x0033FADB File Offset: 0x0033DCDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x060165BC RID: 91580 RVA: 0x0033FAE4 File Offset: 0x0033DCE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleBreakThroughViewRequest);
		}

		// Token: 0x060165BD RID: 91581 RVA: 0x0033FAF2 File Offset: 0x0033DCF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleBreakThroughViewRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060165BE RID: 91582 RVA: 0x0033FB20 File Offset: 0x0033DD20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060165BF RID: 91583 RVA: 0x0033FB5F File Offset: 0x0033DD5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060165C0 RID: 91584 RVA: 0x0033FB6C File Offset: 0x0033DD6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060165C1 RID: 91585 RVA: 0x0033FB75 File Offset: 0x0033DD75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060165C2 RID: 91586 RVA: 0x0033FBA8 File Offset: 0x0033DDA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060165C3 RID: 91587 RVA: 0x0033FBE6 File Offset: 0x0033DDE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleBreakThroughViewRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060165C4 RID: 91588 RVA: 0x0033FC17 File Offset: 0x0033DE17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060165C5 RID: 91589 RVA: 0x0033FC20 File Offset: 0x0033DE20
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040085B6 RID: 34230
		private UnknownFieldSet _unknownFields;

		// Token: 0x040085B7 RID: 34231
		public const int RoleIdFieldNumber = 8;

		// Token: 0x040085B8 RID: 34232
		private int roleId_;
	}
}
