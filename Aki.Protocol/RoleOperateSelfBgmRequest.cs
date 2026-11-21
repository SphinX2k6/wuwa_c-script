using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001083 RID: 4227
	[NetMessage(EMessageId.RoleOperateSelfBgmRequest)]
	public sealed class RoleOperateSelfBgmRequest : IMessage<RoleOperateSelfBgmRequest>, IMessage, IEquatable<RoleOperateSelfBgmRequest>, IDeepCloneable<RoleOperateSelfBgmRequest>, IBufferMessage
	{
		// Token: 0x060169C3 RID: 92611 RVA: 0x0034A163 File Offset: 0x00348363
		[NullableContext(1)]
		public static RoleOperateSelfBgmRequest Create()
		{
			return new RoleOperateSelfBgmRequest();
		}

		// Token: 0x17004BC5 RID: 19397
		// (get) Token: 0x060169C4 RID: 92612 RVA: 0x0034A16A File Offset: 0x0034836A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004BC6 RID: 19398
		// (get) Token: 0x060169C5 RID: 92613 RVA: 0x0034A16D File Offset: 0x0034836D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleOperateSelfBgmRequest.Descriptor;
			}
		}

		// Token: 0x060169C6 RID: 92614 RVA: 0x0034A174 File Offset: 0x00348374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleOperateSelfBgmRequest()
		{
		}

		// Token: 0x060169C7 RID: 92615 RVA: 0x0034A17C File Offset: 0x0034837C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleOperateSelfBgmRequest(RoleOperateSelfBgmRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this.isOpen_ = other.isOpen_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060169C8 RID: 92616 RVA: 0x0034A1AD File Offset: 0x003483AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleOperateSelfBgmRequest Clone()
		{
			return new RoleOperateSelfBgmRequest(this);
		}

		// Token: 0x17004BC7 RID: 19399
		// (get) Token: 0x060169C9 RID: 92617 RVA: 0x0034A1B5 File Offset: 0x003483B5
		// (set) Token: 0x060169CA RID: 92618 RVA: 0x0034A1BD File Offset: 0x003483BD
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

		// Token: 0x17004BC8 RID: 19400
		// (get) Token: 0x060169CB RID: 92619 RVA: 0x0034A1C6 File Offset: 0x003483C6
		// (set) Token: 0x060169CC RID: 92620 RVA: 0x0034A1CE File Offset: 0x003483CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsOpen
		{
			get
			{
				return this.isOpen_;
			}
			set
			{
				this.isOpen_ = value;
			}
		}

		// Token: 0x060169CD RID: 92621 RVA: 0x0034A1D7 File Offset: 0x003483D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleOperateSelfBgmRequest);
		}

		// Token: 0x060169CE RID: 92622 RVA: 0x0034A1E5 File Offset: 0x003483E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleOperateSelfBgmRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.IsOpen == other.IsOpen && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060169CF RID: 92623 RVA: 0x0034A224 File Offset: 0x00348424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.IsOpen)
			{
				num ^= this.IsOpen.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060169D0 RID: 92624 RVA: 0x0034A27C File Offset: 0x0034847C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060169D1 RID: 92625 RVA: 0x0034A289 File Offset: 0x00348489
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060169D2 RID: 92626 RVA: 0x0034A294 File Offset: 0x00348494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsOpen)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsOpen);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060169D3 RID: 92627 RVA: 0x0034A2F0 File Offset: 0x003484F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.IsOpen)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060169D4 RID: 92628 RVA: 0x0034A33C File Offset: 0x0034853C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleOperateSelfBgmRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.IsOpen)
			{
				this.IsOpen = other.IsOpen;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060169D5 RID: 92629 RVA: 0x0034A38C File Offset: 0x0034858C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060169D6 RID: 92630 RVA: 0x0034A398 File Offset: 0x00348598
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
				if (num != 24U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.RoleId = input.ReadInt32();
					}
				}
				else
				{
					this.IsOpen = input.ReadBool();
				}
			}
		}

		// Token: 0x0400879E RID: 34718
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400879F RID: 34719
		public const int RoleIdFieldNumber = 15;

		// Token: 0x040087A0 RID: 34720
		private int roleId_;

		// Token: 0x040087A1 RID: 34721
		public const int IsOpenFieldNumber = 3;

		// Token: 0x040087A2 RID: 34722
		private bool isOpen_;
	}
}
