using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000600 RID: 1536
	[NetMessage(EMessageId.FollowDetectionTargetUpdateNotify)]
	public sealed class FollowDetectionTargetUpdateNotify : IMessage<FollowDetectionTargetUpdateNotify>, IMessage, IEquatable<FollowDetectionTargetUpdateNotify>, IDeepCloneable<FollowDetectionTargetUpdateNotify>, IBufferMessage
	{
		// Token: 0x06008E60 RID: 36448 RVA: 0x001595C9 File Offset: 0x001577C9
		[NullableContext(1)]
		public static FollowDetectionTargetUpdateNotify Create()
		{
			return new FollowDetectionTargetUpdateNotify();
		}

		// Token: 0x17001C3D RID: 7229
		// (get) Token: 0x06008E61 RID: 36449 RVA: 0x001595D0 File Offset: 0x001577D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C3E RID: 7230
		// (get) Token: 0x06008E62 RID: 36450 RVA: 0x001595D3 File Offset: 0x001577D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FollowDetectionTargetUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06008E63 RID: 36451 RVA: 0x001595DA File Offset: 0x001577DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FollowDetectionTargetUpdateNotify()
		{
		}

		// Token: 0x06008E64 RID: 36452 RVA: 0x001595ED File Offset: 0x001577ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FollowDetectionTargetUpdateNotify(FollowDetectionTargetUpdateNotify other) : this()
		{
			this.detectionTarget_ = other.detectionTarget_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008E65 RID: 36453 RVA: 0x00159617 File Offset: 0x00157817
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FollowDetectionTargetUpdateNotify Clone()
		{
			return new FollowDetectionTargetUpdateNotify(this);
		}

		// Token: 0x17001C3F RID: 7231
		// (get) Token: 0x06008E66 RID: 36454 RVA: 0x0015961F File Offset: 0x0015781F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DetectionTarget> DetectionTarget
		{
			get
			{
				return this.detectionTarget_;
			}
		}

		// Token: 0x06008E67 RID: 36455 RVA: 0x00159627 File Offset: 0x00157827
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FollowDetectionTargetUpdateNotify);
		}

		// Token: 0x06008E68 RID: 36456 RVA: 0x00159635 File Offset: 0x00157835
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FollowDetectionTargetUpdateNotify other)
		{
			return other != null && (other == this || (this.detectionTarget_.Equals(other.detectionTarget_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008E69 RID: 36457 RVA: 0x00159668 File Offset: 0x00157868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.detectionTarget_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008E6A RID: 36458 RVA: 0x0015969C File Offset: 0x0015789C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008E6B RID: 36459 RVA: 0x001596A9 File Offset: 0x001578A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008E6C RID: 36460 RVA: 0x001596B2 File Offset: 0x001578B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.detectionTarget_.WriteTo(ref output, FollowDetectionTargetUpdateNotify._repeated_detectionTarget_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008E6D RID: 36461 RVA: 0x001596DC File Offset: 0x001578DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.detectionTarget_.CalculateSize(FollowDetectionTargetUpdateNotify._repeated_detectionTarget_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008E6E RID: 36462 RVA: 0x00159715 File Offset: 0x00157915
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FollowDetectionTargetUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.detectionTarget_.Add(other.detectionTarget_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008E6F RID: 36463 RVA: 0x00159743 File Offset: 0x00157943
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008E70 RID: 36464 RVA: 0x0015974C File Offset: 0x0015794C
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
				if (num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.detectionTarget_.AddEntriesFrom(ref input, FollowDetectionTargetUpdateNotify._repeated_detectionTarget_codec);
				}
			}
		}

		// Token: 0x040045AE RID: 17838
		private UnknownFieldSet _unknownFields;

		// Token: 0x040045AF RID: 17839
		public const int DetectionTargetFieldNumber = 15;

		// Token: 0x040045B0 RID: 17840
		private static readonly FieldCodec<DetectionTarget> _repeated_detectionTarget_codec = FieldCodec.ForMessage<DetectionTarget>(122U, Aki.Protocol.DetectionTarget.Parser);

		// Token: 0x040045B1 RID: 17841
		private readonly RepeatedField<DetectionTarget> detectionTarget_ = new RepeatedField<DetectionTarget>();
	}
}
