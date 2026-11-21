using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001048 RID: 4168
	[NetMessage(EMessageId.RoleBreakThroughViewRequest)]
	public sealed class RoleBreakThroughViewRequest : IMessage<RoleBreakThroughViewRequest>, IMessage, IEquatable<RoleBreakThroughViewRequest>, IDeepCloneable<RoleBreakThroughViewRequest>, IBufferMessage
	{
		// Token: 0x060164CF RID: 91343 RVA: 0x0033E3B9 File Offset: 0x0033C5B9
		[NullableContext(1)]
		public static RoleBreakThroughViewRequest Create()
		{
			return new RoleBreakThroughViewRequest();
		}

		// Token: 0x17004A9F RID: 19103
		// (get) Token: 0x060164D0 RID: 91344 RVA: 0x0033E3C0 File Offset: 0x0033C5C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004AA0 RID: 19104
		// (get) Token: 0x060164D1 RID: 91345 RVA: 0x0033E3C3 File Offset: 0x0033C5C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleBreakThroughViewRequest.Descriptor;
			}
		}

		// Token: 0x060164D2 RID: 91346 RVA: 0x0033E3CA File Offset: 0x0033C5CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleBreakThroughViewRequest()
		{
		}

		// Token: 0x060164D3 RID: 91347 RVA: 0x0033E3D2 File Offset: 0x0033C5D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleBreakThroughViewRequest(RoleBreakThroughViewRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060164D4 RID: 91348 RVA: 0x0033E3F7 File Offset: 0x0033C5F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleBreakThroughViewRequest Clone()
		{
			return new RoleBreakThroughViewRequest(this);
		}

		// Token: 0x17004AA1 RID: 19105
		// (get) Token: 0x060164D5 RID: 91349 RVA: 0x0033E3FF File Offset: 0x0033C5FF
		// (set) Token: 0x060164D6 RID: 91350 RVA: 0x0033E407 File Offset: 0x0033C607
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

		// Token: 0x060164D7 RID: 91351 RVA: 0x0033E410 File Offset: 0x0033C610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleBreakThroughViewRequest);
		}

		// Token: 0x060164D8 RID: 91352 RVA: 0x0033E41E File Offset: 0x0033C61E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleBreakThroughViewRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060164D9 RID: 91353 RVA: 0x0033E44C File Offset: 0x0033C64C
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

		// Token: 0x060164DA RID: 91354 RVA: 0x0033E48B File Offset: 0x0033C68B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060164DB RID: 91355 RVA: 0x0033E498 File Offset: 0x0033C698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060164DC RID: 91356 RVA: 0x0033E4A1 File Offset: 0x0033C6A1
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

		// Token: 0x060164DD RID: 91357 RVA: 0x0033E4D4 File Offset: 0x0033C6D4
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

		// Token: 0x060164DE RID: 91358 RVA: 0x0033E512 File Offset: 0x0033C712
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

		// Token: 0x060164DF RID: 91359 RVA: 0x0033E543 File Offset: 0x0033C743
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060164E0 RID: 91360 RVA: 0x0033E54C File Offset: 0x0033C74C
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

		// Token: 0x040085E0 RID: 34272
		private UnknownFieldSet _unknownFields;

		// Token: 0x040085E1 RID: 34273
		public const int RoleIdFieldNumber = 8;

		// Token: 0x040085E2 RID: 34274
		private int roleId_;
	}
}
