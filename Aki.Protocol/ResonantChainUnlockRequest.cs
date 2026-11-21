using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F1B RID: 3867
	[NetMessage(EMessageId.ResonantChainUnlockRequest)]
	public sealed class ResonantChainUnlockRequest : IMessage<ResonantChainUnlockRequest>, IMessage, IEquatable<ResonantChainUnlockRequest>, IDeepCloneable<ResonantChainUnlockRequest>, IBufferMessage
	{
		// Token: 0x06014B87 RID: 84871 RVA: 0x00302314 File Offset: 0x00300514
		[NullableContext(1)]
		public static ResonantChainUnlockRequest Create()
		{
			return new ResonantChainUnlockRequest();
		}

		// Token: 0x170044E1 RID: 17633
		// (get) Token: 0x06014B88 RID: 84872 RVA: 0x0030231B File Offset: 0x0030051B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170044E2 RID: 17634
		// (get) Token: 0x06014B89 RID: 84873 RVA: 0x0030231E File Offset: 0x0030051E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ResonantChainUnlockRequest.Descriptor;
			}
		}

		// Token: 0x06014B8A RID: 84874 RVA: 0x00302325 File Offset: 0x00300525
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResonantChainUnlockRequest()
		{
		}

		// Token: 0x06014B8B RID: 84875 RVA: 0x0030232D File Offset: 0x0030052D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResonantChainUnlockRequest(ResonantChainUnlockRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014B8C RID: 84876 RVA: 0x00302352 File Offset: 0x00300552
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResonantChainUnlockRequest Clone()
		{
			return new ResonantChainUnlockRequest(this);
		}

		// Token: 0x170044E3 RID: 17635
		// (get) Token: 0x06014B8D RID: 84877 RVA: 0x0030235A File Offset: 0x0030055A
		// (set) Token: 0x06014B8E RID: 84878 RVA: 0x00302362 File Offset: 0x00300562
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

		// Token: 0x06014B8F RID: 84879 RVA: 0x0030236B File Offset: 0x0030056B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ResonantChainUnlockRequest);
		}

		// Token: 0x06014B90 RID: 84880 RVA: 0x00302379 File Offset: 0x00300579
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ResonantChainUnlockRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014B91 RID: 84881 RVA: 0x003023A8 File Offset: 0x003005A8
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

		// Token: 0x06014B92 RID: 84882 RVA: 0x003023E7 File Offset: 0x003005E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014B93 RID: 84883 RVA: 0x003023F4 File Offset: 0x003005F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014B94 RID: 84884 RVA: 0x003023FD File Offset: 0x003005FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014B95 RID: 84885 RVA: 0x00302430 File Offset: 0x00300630
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

		// Token: 0x06014B96 RID: 84886 RVA: 0x0030246E File Offset: 0x0030066E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ResonantChainUnlockRequest other)
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

		// Token: 0x06014B97 RID: 84887 RVA: 0x0030249F File Offset: 0x0030069F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014B98 RID: 84888 RVA: 0x003024A8 File Offset: 0x003006A8
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
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007D91 RID: 32145
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D92 RID: 32146
		public const int RoleIdFieldNumber = 1;

		// Token: 0x04007D93 RID: 32147
		private int roleId_;
	}
}
