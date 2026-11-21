using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F46 RID: 3910
	[NetMessage(EMessageId.RiskHarvestBuffCountRewardRequest)]
	public sealed class RiskHarvestBuffCountRewardRequest : IMessage<RiskHarvestBuffCountRewardRequest>, IMessage, IEquatable<RiskHarvestBuffCountRewardRequest>, IDeepCloneable<RiskHarvestBuffCountRewardRequest>, IBufferMessage
	{
		// Token: 0x06014F1D RID: 85789 RVA: 0x0030A85C File Offset: 0x00308A5C
		[NullableContext(1)]
		public static RiskHarvestBuffCountRewardRequest Create()
		{
			return new RiskHarvestBuffCountRewardRequest();
		}

		// Token: 0x170045B1 RID: 17841
		// (get) Token: 0x06014F1E RID: 85790 RVA: 0x0030A863 File Offset: 0x00308A63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170045B2 RID: 17842
		// (get) Token: 0x06014F1F RID: 85791 RVA: 0x0030A866 File Offset: 0x00308A66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RiskHarvestBuffCountRewardRequest.Descriptor;
			}
		}

		// Token: 0x06014F20 RID: 85792 RVA: 0x0030A86D File Offset: 0x00308A6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestBuffCountRewardRequest()
		{
		}

		// Token: 0x06014F21 RID: 85793 RVA: 0x0030A875 File Offset: 0x00308A75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestBuffCountRewardRequest(RiskHarvestBuffCountRewardRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014F22 RID: 85794 RVA: 0x0030A89A File Offset: 0x00308A9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestBuffCountRewardRequest Clone()
		{
			return new RiskHarvestBuffCountRewardRequest(this);
		}

		// Token: 0x170045B3 RID: 17843
		// (get) Token: 0x06014F23 RID: 85795 RVA: 0x0030A8A2 File Offset: 0x00308AA2
		// (set) Token: 0x06014F24 RID: 85796 RVA: 0x0030A8AA File Offset: 0x00308AAA
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

		// Token: 0x06014F25 RID: 85797 RVA: 0x0030A8B3 File Offset: 0x00308AB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RiskHarvestBuffCountRewardRequest);
		}

		// Token: 0x06014F26 RID: 85798 RVA: 0x0030A8C1 File Offset: 0x00308AC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RiskHarvestBuffCountRewardRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014F27 RID: 85799 RVA: 0x0030A8F0 File Offset: 0x00308AF0
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

		// Token: 0x06014F28 RID: 85800 RVA: 0x0030A92F File Offset: 0x00308B2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014F29 RID: 85801 RVA: 0x0030A93C File Offset: 0x00308B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014F2A RID: 85802 RVA: 0x0030A945 File Offset: 0x00308B45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014F2B RID: 85803 RVA: 0x0030A978 File Offset: 0x00308B78
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

		// Token: 0x06014F2C RID: 85804 RVA: 0x0030A9B6 File Offset: 0x00308BB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RiskHarvestBuffCountRewardRequest other)
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

		// Token: 0x06014F2D RID: 85805 RVA: 0x0030A9E7 File Offset: 0x00308BE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014F2E RID: 85806 RVA: 0x0030A9F0 File Offset: 0x00308BF0
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007EBD RID: 32445
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007EBE RID: 32446
		public const int IdFieldNumber = 5;

		// Token: 0x04007EBF RID: 32447
		private int id_;
	}
}
