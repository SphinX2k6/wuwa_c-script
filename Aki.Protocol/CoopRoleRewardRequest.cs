using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002FD RID: 765
	[NetMessage(EMessageId.CoopRoleRewardRequest)]
	public sealed class CoopRoleRewardRequest : IMessage<CoopRoleRewardRequest>, IMessage, IEquatable<CoopRoleRewardRequest>, IDeepCloneable<CoopRoleRewardRequest>, IBufferMessage
	{
		// Token: 0x06004D63 RID: 19811 RVA: 0x000BC3F8 File Offset: 0x000BA5F8
		[NullableContext(1)]
		public static CoopRoleRewardRequest Create()
		{
			return new CoopRoleRewardRequest();
		}

		// Token: 0x17000DB0 RID: 3504
		// (get) Token: 0x06004D64 RID: 19812 RVA: 0x000BC3FF File Offset: 0x000BA5FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000DB1 RID: 3505
		// (get) Token: 0x06004D65 RID: 19813 RVA: 0x000BC402 File Offset: 0x000BA602
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CoopRoleRewardRequest.Descriptor;
			}
		}

		// Token: 0x06004D66 RID: 19814 RVA: 0x000BC409 File Offset: 0x000BA609
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CoopRoleRewardRequest()
		{
		}

		// Token: 0x06004D67 RID: 19815 RVA: 0x000BC411 File Offset: 0x000BA611
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CoopRoleRewardRequest(CoopRoleRewardRequest other) : this()
		{
			this.coopId_ = other.coopId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004D68 RID: 19816 RVA: 0x000BC436 File Offset: 0x000BA636
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CoopRoleRewardRequest Clone()
		{
			return new CoopRoleRewardRequest(this);
		}

		// Token: 0x17000DB2 RID: 3506
		// (get) Token: 0x06004D69 RID: 19817 RVA: 0x000BC43E File Offset: 0x000BA63E
		// (set) Token: 0x06004D6A RID: 19818 RVA: 0x000BC446 File Offset: 0x000BA646
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CoopId
		{
			get
			{
				return this.coopId_;
			}
			set
			{
				this.coopId_ = value;
			}
		}

		// Token: 0x06004D6B RID: 19819 RVA: 0x000BC44F File Offset: 0x000BA64F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CoopRoleRewardRequest);
		}

		// Token: 0x06004D6C RID: 19820 RVA: 0x000BC45D File Offset: 0x000BA65D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CoopRoleRewardRequest other)
		{
			return other != null && (other == this || (this.CoopId == other.CoopId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004D6D RID: 19821 RVA: 0x000BC48C File Offset: 0x000BA68C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CoopId != 0)
			{
				num ^= this.CoopId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004D6E RID: 19822 RVA: 0x000BC4CB File Offset: 0x000BA6CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004D6F RID: 19823 RVA: 0x000BC4D8 File Offset: 0x000BA6D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004D70 RID: 19824 RVA: 0x000BC4E1 File Offset: 0x000BA6E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CoopId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.CoopId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004D71 RID: 19825 RVA: 0x000BC514 File Offset: 0x000BA714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CoopId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CoopId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004D72 RID: 19826 RVA: 0x000BC552 File Offset: 0x000BA752
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CoopRoleRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CoopId != 0)
			{
				this.CoopId = other.CoopId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004D73 RID: 19827 RVA: 0x000BC583 File Offset: 0x000BA783
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004D74 RID: 19828 RVA: 0x000BC58C File Offset: 0x000BA78C
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.CoopId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400314B RID: 12619
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400314C RID: 12620
		public const int CoopIdFieldNumber = 13;

		// Token: 0x0400314D RID: 12621
		private int coopId_;
	}
}
