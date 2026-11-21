using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F49 RID: 3913
	[NetMessage(EMessageId.RiskHarvestBuffUnlockRewardRequest)]
	public sealed class RiskHarvestBuffUnlockRewardRequest : IMessage<RiskHarvestBuffUnlockRewardRequest>, IMessage, IEquatable<RiskHarvestBuffUnlockRewardRequest>, IDeepCloneable<RiskHarvestBuffUnlockRewardRequest>, IBufferMessage
	{
		// Token: 0x06014F53 RID: 85843 RVA: 0x0030ADF5 File Offset: 0x00308FF5
		[NullableContext(1)]
		public static RiskHarvestBuffUnlockRewardRequest Create()
		{
			return new RiskHarvestBuffUnlockRewardRequest();
		}

		// Token: 0x170045BA RID: 17850
		// (get) Token: 0x06014F54 RID: 85844 RVA: 0x0030ADFC File Offset: 0x00308FFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170045BB RID: 17851
		// (get) Token: 0x06014F55 RID: 85845 RVA: 0x0030ADFF File Offset: 0x00308FFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RiskHarvestBuffUnlockRewardRequest.Descriptor;
			}
		}

		// Token: 0x06014F56 RID: 85846 RVA: 0x0030AE06 File Offset: 0x00309006
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestBuffUnlockRewardRequest()
		{
		}

		// Token: 0x06014F57 RID: 85847 RVA: 0x0030AE0E File Offset: 0x0030900E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestBuffUnlockRewardRequest(RiskHarvestBuffUnlockRewardRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014F58 RID: 85848 RVA: 0x0030AE33 File Offset: 0x00309033
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestBuffUnlockRewardRequest Clone()
		{
			return new RiskHarvestBuffUnlockRewardRequest(this);
		}

		// Token: 0x170045BC RID: 17852
		// (get) Token: 0x06014F59 RID: 85849 RVA: 0x0030AE3B File Offset: 0x0030903B
		// (set) Token: 0x06014F5A RID: 85850 RVA: 0x0030AE43 File Offset: 0x00309043
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

		// Token: 0x06014F5B RID: 85851 RVA: 0x0030AE4C File Offset: 0x0030904C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RiskHarvestBuffUnlockRewardRequest);
		}

		// Token: 0x06014F5C RID: 85852 RVA: 0x0030AE5A File Offset: 0x0030905A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RiskHarvestBuffUnlockRewardRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014F5D RID: 85853 RVA: 0x0030AE88 File Offset: 0x00309088
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

		// Token: 0x06014F5E RID: 85854 RVA: 0x0030AEC7 File Offset: 0x003090C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014F5F RID: 85855 RVA: 0x0030AED4 File Offset: 0x003090D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014F60 RID: 85856 RVA: 0x0030AEDD File Offset: 0x003090DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014F61 RID: 85857 RVA: 0x0030AF10 File Offset: 0x00309110
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

		// Token: 0x06014F62 RID: 85858 RVA: 0x0030AF4E File Offset: 0x0030914E
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

		// Token: 0x06014F63 RID: 85859 RVA: 0x0030AF7F File Offset: 0x0030917F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014F64 RID: 85860 RVA: 0x0030AF88 File Offset: 0x00309188
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007EC7 RID: 32455
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007EC8 RID: 32456
		public const int IdFieldNumber = 14;

		// Token: 0x04007EC9 RID: 32457
		private int id_;
	}
}
