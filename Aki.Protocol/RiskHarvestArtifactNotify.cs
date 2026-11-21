using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F45 RID: 3909
	[NetMessage(EMessageId.RiskHarvestArtifactNotify)]
	public sealed class RiskHarvestArtifactNotify : IMessage<RiskHarvestArtifactNotify>, IMessage, IEquatable<RiskHarvestArtifactNotify>, IDeepCloneable<RiskHarvestArtifactNotify>, IBufferMessage
	{
		// Token: 0x06014F0B RID: 85771 RVA: 0x0030A638 File Offset: 0x00308838
		[NullableContext(1)]
		public static RiskHarvestArtifactNotify Create()
		{
			return new RiskHarvestArtifactNotify();
		}

		// Token: 0x170045AE RID: 17838
		// (get) Token: 0x06014F0C RID: 85772 RVA: 0x0030A63F File Offset: 0x0030883F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170045AF RID: 17839
		// (get) Token: 0x06014F0D RID: 85773 RVA: 0x0030A642 File Offset: 0x00308842
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RiskHarvestArtifactNotify.Descriptor;
			}
		}

		// Token: 0x06014F0E RID: 85774 RVA: 0x0030A649 File Offset: 0x00308849
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestArtifactNotify()
		{
		}

		// Token: 0x06014F0F RID: 85775 RVA: 0x0030A651 File Offset: 0x00308851
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestArtifactNotify(RiskHarvestArtifactNotify other) : this()
		{
			this.artifactInfo_ = ((other.artifactInfo_ != null) ? other.artifactInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014F10 RID: 85776 RVA: 0x0030A686 File Offset: 0x00308886
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestArtifactNotify Clone()
		{
			return new RiskHarvestArtifactNotify(this);
		}

		// Token: 0x170045B0 RID: 17840
		// (get) Token: 0x06014F11 RID: 85777 RVA: 0x0030A68E File Offset: 0x0030888E
		// (set) Token: 0x06014F12 RID: 85778 RVA: 0x0030A696 File Offset: 0x00308896
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestInstArtifactInfo ArtifactInfo
		{
			get
			{
				return this.artifactInfo_;
			}
			set
			{
				this.artifactInfo_ = value;
			}
		}

		// Token: 0x06014F13 RID: 85779 RVA: 0x0030A69F File Offset: 0x0030889F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RiskHarvestArtifactNotify);
		}

		// Token: 0x06014F14 RID: 85780 RVA: 0x0030A6AD File Offset: 0x003088AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RiskHarvestArtifactNotify other)
		{
			return other != null && (other == this || (object.Equals(this.ArtifactInfo, other.ArtifactInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014F15 RID: 85781 RVA: 0x0030A6E0 File Offset: 0x003088E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.artifactInfo_ != null)
			{
				num ^= this.ArtifactInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014F16 RID: 85782 RVA: 0x0030A71C File Offset: 0x0030891C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014F17 RID: 85783 RVA: 0x0030A729 File Offset: 0x00308929
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014F18 RID: 85784 RVA: 0x0030A732 File Offset: 0x00308932
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.artifactInfo_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.ArtifactInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014F19 RID: 85785 RVA: 0x0030A764 File Offset: 0x00308964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.artifactInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ArtifactInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014F1A RID: 85786 RVA: 0x0030A7A4 File Offset: 0x003089A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RiskHarvestArtifactNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.artifactInfo_ != null)
			{
				if (this.artifactInfo_ == null)
				{
					this.ArtifactInfo = new RiskHarvestInstArtifactInfo();
				}
				this.ArtifactInfo.MergeFrom(other.ArtifactInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014F1B RID: 85787 RVA: 0x0030A7F8 File Offset: 0x003089F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014F1C RID: 85788 RVA: 0x0030A804 File Offset: 0x00308A04
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
				if (num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.artifactInfo_ == null)
					{
						this.ArtifactInfo = new RiskHarvestInstArtifactInfo();
					}
					input.ReadMessage(this.ArtifactInfo);
				}
			}
		}

		// Token: 0x04007EBA RID: 32442
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007EBB RID: 32443
		public const int ArtifactInfoFieldNumber = 11;

		// Token: 0x04007EBC RID: 32444
		private RiskHarvestInstArtifactInfo artifactInfo_;
	}
}
