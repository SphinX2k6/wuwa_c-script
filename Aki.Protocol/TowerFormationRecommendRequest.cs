using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013BA RID: 5050
	[NetMessage(EMessageId.TowerFormationRecommendRequest)]
	public sealed class TowerFormationRecommendRequest : IMessage<TowerFormationRecommendRequest>, IMessage, IEquatable<TowerFormationRecommendRequest>, IDeepCloneable<TowerFormationRecommendRequest>, IBufferMessage
	{
		// Token: 0x0601ACA8 RID: 109736 RVA: 0x003E28ED File Offset: 0x003E0AED
		[NullableContext(1)]
		public static TowerFormationRecommendRequest Create()
		{
			return new TowerFormationRecommendRequest();
		}

		// Token: 0x17005A5C RID: 23132
		// (get) Token: 0x0601ACA9 RID: 109737 RVA: 0x003E28F4 File Offset: 0x003E0AF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A5D RID: 23133
		// (get) Token: 0x0601ACAA RID: 109738 RVA: 0x003E28F7 File Offset: 0x003E0AF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerFormationRecommendRequest.Descriptor;
			}
		}

		// Token: 0x0601ACAB RID: 109739 RVA: 0x003E28FE File Offset: 0x003E0AFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerFormationRecommendRequest()
		{
		}

		// Token: 0x0601ACAC RID: 109740 RVA: 0x003E2906 File Offset: 0x003E0B06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerFormationRecommendRequest(TowerFormationRecommendRequest other) : this()
		{
			this.towerConfigId_ = other.towerConfigId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601ACAD RID: 109741 RVA: 0x003E292B File Offset: 0x003E0B2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerFormationRecommendRequest Clone()
		{
			return new TowerFormationRecommendRequest(this);
		}

		// Token: 0x17005A5E RID: 23134
		// (get) Token: 0x0601ACAE RID: 109742 RVA: 0x003E2933 File Offset: 0x003E0B33
		// (set) Token: 0x0601ACAF RID: 109743 RVA: 0x003E293B File Offset: 0x003E0B3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TowerConfigId
		{
			get
			{
				return this.towerConfigId_;
			}
			set
			{
				this.towerConfigId_ = value;
			}
		}

		// Token: 0x0601ACB0 RID: 109744 RVA: 0x003E2944 File Offset: 0x003E0B44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerFormationRecommendRequest);
		}

		// Token: 0x0601ACB1 RID: 109745 RVA: 0x003E2952 File Offset: 0x003E0B52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerFormationRecommendRequest other)
		{
			return other != null && (other == this || (this.TowerConfigId == other.TowerConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601ACB2 RID: 109746 RVA: 0x003E2980 File Offset: 0x003E0B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TowerConfigId != 0)
			{
				num ^= this.TowerConfigId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601ACB3 RID: 109747 RVA: 0x003E29BF File Offset: 0x003E0BBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601ACB4 RID: 109748 RVA: 0x003E29CC File Offset: 0x003E0BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601ACB5 RID: 109749 RVA: 0x003E29D5 File Offset: 0x003E0BD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TowerConfigId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.TowerConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601ACB6 RID: 109750 RVA: 0x003E2A08 File Offset: 0x003E0C08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TowerConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TowerConfigId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601ACB7 RID: 109751 RVA: 0x003E2A46 File Offset: 0x003E0C46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerFormationRecommendRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TowerConfigId != 0)
			{
				this.TowerConfigId = other.TowerConfigId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601ACB8 RID: 109752 RVA: 0x003E2A77 File Offset: 0x003E0C77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601ACB9 RID: 109753 RVA: 0x003E2A80 File Offset: 0x003E0C80
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
					this.TowerConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009B8B RID: 39819
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009B8C RID: 39820
		public const int TowerConfigIdFieldNumber = 14;

		// Token: 0x04009B8D RID: 39821
		private int towerConfigId_;
	}
}
