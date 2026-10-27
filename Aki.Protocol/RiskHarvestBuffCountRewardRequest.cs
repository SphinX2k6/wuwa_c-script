using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F56 RID: 3926
	[NetMessage(EMessageId.RiskHarvestBuffCountRewardRequest)]
	public sealed class RiskHarvestBuffCountRewardRequest : IMessage<RiskHarvestBuffCountRewardRequest>, IMessage, IEquatable<RiskHarvestBuffCountRewardRequest>, IDeepCloneable<RiskHarvestBuffCountRewardRequest>, IBufferMessage
	{
		// Token: 0x06015002 RID: 86018 RVA: 0x0030BF18 File Offset: 0x0030A118
		[NullableContext(1)]
		public static RiskHarvestBuffCountRewardRequest Create()
		{
			return new RiskHarvestBuffCountRewardRequest();
		}

		// Token: 0x170045DB RID: 17883
		// (get) Token: 0x06015003 RID: 86019 RVA: 0x0030BF1F File Offset: 0x0030A11F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170045DC RID: 17884
		// (get) Token: 0x06015004 RID: 86020 RVA: 0x0030BF22 File Offset: 0x0030A122
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RiskHarvestBuffCountRewardRequest.Descriptor;
			}
		}

		// Token: 0x06015005 RID: 86021 RVA: 0x0030BF29 File Offset: 0x0030A129
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestBuffCountRewardRequest()
		{
		}

		// Token: 0x06015006 RID: 86022 RVA: 0x0030BF31 File Offset: 0x0030A131
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestBuffCountRewardRequest(RiskHarvestBuffCountRewardRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015007 RID: 86023 RVA: 0x0030BF56 File Offset: 0x0030A156
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestBuffCountRewardRequest Clone()
		{
			return new RiskHarvestBuffCountRewardRequest(this);
		}

		// Token: 0x170045DD RID: 17885
		// (get) Token: 0x06015008 RID: 86024 RVA: 0x0030BF5E File Offset: 0x0030A15E
		// (set) Token: 0x06015009 RID: 86025 RVA: 0x0030BF66 File Offset: 0x0030A166
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

		// Token: 0x0601500A RID: 86026 RVA: 0x0030BF6F File Offset: 0x0030A16F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RiskHarvestBuffCountRewardRequest);
		}

		// Token: 0x0601500B RID: 86027 RVA: 0x0030BF7D File Offset: 0x0030A17D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RiskHarvestBuffCountRewardRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601500C RID: 86028 RVA: 0x0030BFAC File Offset: 0x0030A1AC
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

		// Token: 0x0601500D RID: 86029 RVA: 0x0030BFEB File Offset: 0x0030A1EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601500E RID: 86030 RVA: 0x0030BFF8 File Offset: 0x0030A1F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601500F RID: 86031 RVA: 0x0030C001 File Offset: 0x0030A201
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

		// Token: 0x06015010 RID: 86032 RVA: 0x0030C034 File Offset: 0x0030A234
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

		// Token: 0x06015011 RID: 86033 RVA: 0x0030C072 File Offset: 0x0030A272
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

		// Token: 0x06015012 RID: 86034 RVA: 0x0030C0A3 File Offset: 0x0030A2A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015013 RID: 86035 RVA: 0x0030C0AC File Offset: 0x0030A2AC
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

		// Token: 0x04007E93 RID: 32403
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007E94 RID: 32404
		public const int IdFieldNumber = 14;

		// Token: 0x04007E95 RID: 32405
		private int id_;
	}
}
