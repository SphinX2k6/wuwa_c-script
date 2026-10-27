using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F55 RID: 3925
	[NetMessage(EMessageId.RiskHarvestArtifactNotify)]
	public sealed class RiskHarvestArtifactNotify : IMessage<RiskHarvestArtifactNotify>, IMessage, IEquatable<RiskHarvestArtifactNotify>, IDeepCloneable<RiskHarvestArtifactNotify>, IBufferMessage
	{
		// Token: 0x06014FF0 RID: 86000 RVA: 0x0030BCF4 File Offset: 0x00309EF4
		[NullableContext(1)]
		public static RiskHarvestArtifactNotify Create()
		{
			return new RiskHarvestArtifactNotify();
		}

		// Token: 0x170045D8 RID: 17880
		// (get) Token: 0x06014FF1 RID: 86001 RVA: 0x0030BCFB File Offset: 0x00309EFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170045D9 RID: 17881
		// (get) Token: 0x06014FF2 RID: 86002 RVA: 0x0030BCFE File Offset: 0x00309EFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RiskHarvestArtifactNotify.Descriptor;
			}
		}

		// Token: 0x06014FF3 RID: 86003 RVA: 0x0030BD05 File Offset: 0x00309F05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestArtifactNotify()
		{
		}

		// Token: 0x06014FF4 RID: 86004 RVA: 0x0030BD0D File Offset: 0x00309F0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestArtifactNotify(RiskHarvestArtifactNotify other) : this()
		{
			this.artifactInfo_ = ((other.artifactInfo_ != null) ? other.artifactInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014FF5 RID: 86005 RVA: 0x0030BD42 File Offset: 0x00309F42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestArtifactNotify Clone()
		{
			return new RiskHarvestArtifactNotify(this);
		}

		// Token: 0x170045DA RID: 17882
		// (get) Token: 0x06014FF6 RID: 86006 RVA: 0x0030BD4A File Offset: 0x00309F4A
		// (set) Token: 0x06014FF7 RID: 86007 RVA: 0x0030BD52 File Offset: 0x00309F52
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

		// Token: 0x06014FF8 RID: 86008 RVA: 0x0030BD5B File Offset: 0x00309F5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RiskHarvestArtifactNotify);
		}

		// Token: 0x06014FF9 RID: 86009 RVA: 0x0030BD69 File Offset: 0x00309F69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RiskHarvestArtifactNotify other)
		{
			return other != null && (other == this || (object.Equals(this.ArtifactInfo, other.ArtifactInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014FFA RID: 86010 RVA: 0x0030BD9C File Offset: 0x00309F9C
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

		// Token: 0x06014FFB RID: 86011 RVA: 0x0030BDD8 File Offset: 0x00309FD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014FFC RID: 86012 RVA: 0x0030BDE5 File Offset: 0x00309FE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014FFD RID: 86013 RVA: 0x0030BDEE File Offset: 0x00309FEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.artifactInfo_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.ArtifactInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014FFE RID: 86014 RVA: 0x0030BE20 File Offset: 0x0030A020
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

		// Token: 0x06014FFF RID: 86015 RVA: 0x0030BE60 File Offset: 0x0030A060
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

		// Token: 0x06015000 RID: 86016 RVA: 0x0030BEB4 File Offset: 0x0030A0B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015001 RID: 86017 RVA: 0x0030BEC0 File Offset: 0x0030A0C0
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
				if (num != 42U)
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

		// Token: 0x04007E90 RID: 32400
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007E91 RID: 32401
		public const int ArtifactInfoFieldNumber = 5;

		// Token: 0x04007E92 RID: 32402
		private RiskHarvestInstArtifactInfo artifactInfo_;
	}
}
