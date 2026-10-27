using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F60 RID: 3936
	[NetMessage(EMessageId.RiskHarvestInstRewardRequest)]
	public sealed class RiskHarvestInstRewardRequest : IMessage<RiskHarvestInstRewardRequest>, IMessage, IEquatable<RiskHarvestInstRewardRequest>, IDeepCloneable<RiskHarvestInstRewardRequest>, IBufferMessage
	{
		// Token: 0x060150D8 RID: 86232 RVA: 0x0030DD34 File Offset: 0x0030BF34
		[NullableContext(1)]
		public static RiskHarvestInstRewardRequest Create()
		{
			return new RiskHarvestInstRewardRequest();
		}

		// Token: 0x1700460B RID: 17931
		// (get) Token: 0x060150D9 RID: 86233 RVA: 0x0030DD3B File Offset: 0x0030BF3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700460C RID: 17932
		// (get) Token: 0x060150DA RID: 86234 RVA: 0x0030DD3E File Offset: 0x0030BF3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RiskHarvestInstRewardRequest.Descriptor;
			}
		}

		// Token: 0x060150DB RID: 86235 RVA: 0x0030DD45 File Offset: 0x0030BF45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestInstRewardRequest()
		{
		}

		// Token: 0x060150DC RID: 86236 RVA: 0x0030DD4D File Offset: 0x0030BF4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestInstRewardRequest(RiskHarvestInstRewardRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060150DD RID: 86237 RVA: 0x0030DD72 File Offset: 0x0030BF72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestInstRewardRequest Clone()
		{
			return new RiskHarvestInstRewardRequest(this);
		}

		// Token: 0x1700460D RID: 17933
		// (get) Token: 0x060150DE RID: 86238 RVA: 0x0030DD7A File Offset: 0x0030BF7A
		// (set) Token: 0x060150DF RID: 86239 RVA: 0x0030DD82 File Offset: 0x0030BF82
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

		// Token: 0x060150E0 RID: 86240 RVA: 0x0030DD8B File Offset: 0x0030BF8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RiskHarvestInstRewardRequest);
		}

		// Token: 0x060150E1 RID: 86241 RVA: 0x0030DD99 File Offset: 0x0030BF99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RiskHarvestInstRewardRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060150E2 RID: 86242 RVA: 0x0030DDC8 File Offset: 0x0030BFC8
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

		// Token: 0x060150E3 RID: 86243 RVA: 0x0030DE07 File Offset: 0x0030C007
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060150E4 RID: 86244 RVA: 0x0030DE14 File Offset: 0x0030C014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060150E5 RID: 86245 RVA: 0x0030DE1D File Offset: 0x0030C01D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060150E6 RID: 86246 RVA: 0x0030DE50 File Offset: 0x0030C050
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

		// Token: 0x060150E7 RID: 86247 RVA: 0x0030DE8E File Offset: 0x0030C08E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RiskHarvestInstRewardRequest other)
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

		// Token: 0x060150E8 RID: 86248 RVA: 0x0030DEBF File Offset: 0x0030C0BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060150E9 RID: 86249 RVA: 0x0030DEC8 File Offset: 0x0030C0C8
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007ED8 RID: 32472
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007ED9 RID: 32473
		public const int IdFieldNumber = 7;

		// Token: 0x04007EDA RID: 32474
		private int id_;
	}
}
