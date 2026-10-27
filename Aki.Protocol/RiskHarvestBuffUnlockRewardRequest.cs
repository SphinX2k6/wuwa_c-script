using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F59 RID: 3929
	[NetMessage(EMessageId.RiskHarvestBuffUnlockRewardRequest)]
	public sealed class RiskHarvestBuffUnlockRewardRequest : IMessage<RiskHarvestBuffUnlockRewardRequest>, IMessage, IEquatable<RiskHarvestBuffUnlockRewardRequest>, IDeepCloneable<RiskHarvestBuffUnlockRewardRequest>, IBufferMessage
	{
		// Token: 0x06015038 RID: 86072 RVA: 0x0030C4AD File Offset: 0x0030A6AD
		[NullableContext(1)]
		public static RiskHarvestBuffUnlockRewardRequest Create()
		{
			return new RiskHarvestBuffUnlockRewardRequest();
		}

		// Token: 0x170045E4 RID: 17892
		// (get) Token: 0x06015039 RID: 86073 RVA: 0x0030C4B4 File Offset: 0x0030A6B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170045E5 RID: 17893
		// (get) Token: 0x0601503A RID: 86074 RVA: 0x0030C4B7 File Offset: 0x0030A6B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RiskHarvestBuffUnlockRewardRequest.Descriptor;
			}
		}

		// Token: 0x0601503B RID: 86075 RVA: 0x0030C4BE File Offset: 0x0030A6BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestBuffUnlockRewardRequest()
		{
		}

		// Token: 0x0601503C RID: 86076 RVA: 0x0030C4C6 File Offset: 0x0030A6C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestBuffUnlockRewardRequest(RiskHarvestBuffUnlockRewardRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601503D RID: 86077 RVA: 0x0030C4EB File Offset: 0x0030A6EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestBuffUnlockRewardRequest Clone()
		{
			return new RiskHarvestBuffUnlockRewardRequest(this);
		}

		// Token: 0x170045E6 RID: 17894
		// (get) Token: 0x0601503E RID: 86078 RVA: 0x0030C4F3 File Offset: 0x0030A6F3
		// (set) Token: 0x0601503F RID: 86079 RVA: 0x0030C4FB File Offset: 0x0030A6FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x06015040 RID: 86080 RVA: 0x0030C504 File Offset: 0x0030A704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RiskHarvestBuffUnlockRewardRequest);
		}

		// Token: 0x06015041 RID: 86081 RVA: 0x0030C512 File Offset: 0x0030A712
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RiskHarvestBuffUnlockRewardRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015042 RID: 86082 RVA: 0x0030C540 File Offset: 0x0030A740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015043 RID: 86083 RVA: 0x0030C57F File Offset: 0x0030A77F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015044 RID: 86084 RVA: 0x0030C58C File Offset: 0x0030A78C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015045 RID: 86085 RVA: 0x0030C595 File Offset: 0x0030A795
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015046 RID: 86086 RVA: 0x0030C5C8 File Offset: 0x0030A7C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015047 RID: 86087 RVA: 0x0030C606 File Offset: 0x0030A806
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RiskHarvestBuffUnlockRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015048 RID: 86088 RVA: 0x0030C637 File Offset: 0x0030A837
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015049 RID: 86089 RVA: 0x0030C640 File Offset: 0x0030A840
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007E9D RID: 32413
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007E9E RID: 32414
		public const int IdFieldNumber = 4;

		// Token: 0x04007E9F RID: 32415
		private int id_;
	}
}
