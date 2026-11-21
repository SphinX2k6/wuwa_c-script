using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F50 RID: 3920
	[NetMessage(EMessageId.RiskHarvestInstRewardRequest)]
	public sealed class RiskHarvestInstRewardRequest : IMessage<RiskHarvestInstRewardRequest>, IMessage, IEquatable<RiskHarvestInstRewardRequest>, IDeepCloneable<RiskHarvestInstRewardRequest>, IBufferMessage
	{
		// Token: 0x06014FF3 RID: 86003 RVA: 0x0030C684 File Offset: 0x0030A884
		[NullableContext(1)]
		public static RiskHarvestInstRewardRequest Create()
		{
			return new RiskHarvestInstRewardRequest();
		}

		// Token: 0x170045E1 RID: 17889
		// (get) Token: 0x06014FF4 RID: 86004 RVA: 0x0030C68B File Offset: 0x0030A88B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170045E2 RID: 17890
		// (get) Token: 0x06014FF5 RID: 86005 RVA: 0x0030C68E File Offset: 0x0030A88E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RiskHarvestInstRewardRequest.Descriptor;
			}
		}

		// Token: 0x06014FF6 RID: 86006 RVA: 0x0030C695 File Offset: 0x0030A895
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestInstRewardRequest()
		{
		}

		// Token: 0x06014FF7 RID: 86007 RVA: 0x0030C69D File Offset: 0x0030A89D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestInstRewardRequest(RiskHarvestInstRewardRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014FF8 RID: 86008 RVA: 0x0030C6C2 File Offset: 0x0030A8C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestInstRewardRequest Clone()
		{
			return new RiskHarvestInstRewardRequest(this);
		}

		// Token: 0x170045E3 RID: 17891
		// (get) Token: 0x06014FF9 RID: 86009 RVA: 0x0030C6CA File Offset: 0x0030A8CA
		// (set) Token: 0x06014FFA RID: 86010 RVA: 0x0030C6D2 File Offset: 0x0030A8D2
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

		// Token: 0x06014FFB RID: 86011 RVA: 0x0030C6DB File Offset: 0x0030A8DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RiskHarvestInstRewardRequest);
		}

		// Token: 0x06014FFC RID: 86012 RVA: 0x0030C6E9 File Offset: 0x0030A8E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RiskHarvestInstRewardRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014FFD RID: 86013 RVA: 0x0030C718 File Offset: 0x0030A918
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

		// Token: 0x06014FFE RID: 86014 RVA: 0x0030C757 File Offset: 0x0030A957
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014FFF RID: 86015 RVA: 0x0030C764 File Offset: 0x0030A964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015000 RID: 86016 RVA: 0x0030C76D File Offset: 0x0030A96D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015001 RID: 86017 RVA: 0x0030C7A0 File Offset: 0x0030A9A0
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

		// Token: 0x06015002 RID: 86018 RVA: 0x0030C7DE File Offset: 0x0030A9DE
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

		// Token: 0x06015003 RID: 86019 RVA: 0x0030C80F File Offset: 0x0030AA0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015004 RID: 86020 RVA: 0x0030C818 File Offset: 0x0030AA18
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007F02 RID: 32514
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007F03 RID: 32515
		public const int IdFieldNumber = 12;

		// Token: 0x04007F04 RID: 32516
		private int id_;
	}
}
