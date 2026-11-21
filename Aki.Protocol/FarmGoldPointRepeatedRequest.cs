using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000511 RID: 1297
	[NetMessage(EMessageId.FarmGoldPointRepeatedRequest)]
	public sealed class FarmGoldPointRepeatedRequest : IMessage<FarmGoldPointRepeatedRequest>, IMessage, IEquatable<FarmGoldPointRepeatedRequest>, IDeepCloneable<FarmGoldPointRepeatedRequest>, IBufferMessage
	{
		// Token: 0x06007A3E RID: 31294 RVA: 0x001291FD File Offset: 0x001273FD
		[NullableContext(1)]
		public static FarmGoldPointRepeatedRequest Create()
		{
			return new FarmGoldPointRepeatedRequest();
		}

		// Token: 0x170017B0 RID: 6064
		// (get) Token: 0x06007A3F RID: 31295 RVA: 0x00129204 File Offset: 0x00127404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170017B1 RID: 6065
		// (get) Token: 0x06007A40 RID: 31296 RVA: 0x00129207 File Offset: 0x00127407
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FarmGoldPointRepeatedRequest.Descriptor;
			}
		}

		// Token: 0x06007A41 RID: 31297 RVA: 0x0012920E File Offset: 0x0012740E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldPointRepeatedRequest()
		{
		}

		// Token: 0x06007A42 RID: 31298 RVA: 0x00129221 File Offset: 0x00127421
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldPointRepeatedRequest(FarmGoldPointRepeatedRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007A43 RID: 31299 RVA: 0x00129257 File Offset: 0x00127457
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldPointRepeatedRequest Clone()
		{
			return new FarmGoldPointRepeatedRequest(this);
		}

		// Token: 0x170017B2 RID: 6066
		// (get) Token: 0x06007A44 RID: 31300 RVA: 0x0012925F File Offset: 0x0012745F
		// (set) Token: 0x06007A45 RID: 31301 RVA: 0x00129267 File Offset: 0x00127467
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x170017B3 RID: 6067
		// (get) Token: 0x06007A46 RID: 31302 RVA: 0x00129270 File Offset: 0x00127470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x06007A47 RID: 31303 RVA: 0x00129278 File Offset: 0x00127478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FarmGoldPointRepeatedRequest);
		}

		// Token: 0x06007A48 RID: 31304 RVA: 0x00129288 File Offset: 0x00127488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FarmGoldPointRepeatedRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.ids_.Equals(other.ids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007A49 RID: 31305 RVA: 0x001292D8 File Offset: 0x001274D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.ids_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007A4A RID: 31306 RVA: 0x00129325 File Offset: 0x00127525
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007A4B RID: 31307 RVA: 0x00129332 File Offset: 0x00127532
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007A4C RID: 31308 RVA: 0x0012933C File Offset: 0x0012753C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.ActivityId);
			}
			this.ids_.WriteTo(ref output, FarmGoldPointRepeatedRequest._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007A4D RID: 31309 RVA: 0x0012938C File Offset: 0x0012758C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.ids_.CalculateSize(FarmGoldPointRepeatedRequest._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007A4E RID: 31310 RVA: 0x001293E0 File Offset: 0x001275E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FarmGoldPointRepeatedRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.ids_.Add(other.ids_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007A4F RID: 31311 RVA: 0x0012942D File Offset: 0x0012762D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007A50 RID: 31312 RVA: 0x00129438 File Offset: 0x00127638
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
				if (num != 64U)
				{
					if (num != 80U && num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ids_.AddEntriesFrom(ref input, FarmGoldPointRepeatedRequest._repeated_ids_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003F31 RID: 16177
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F32 RID: 16178
		public const int ActivityIdFieldNumber = 8;

		// Token: 0x04003F33 RID: 16179
		private int activityId_;

		// Token: 0x04003F34 RID: 16180
		public const int IdsFieldNumber = 10;

		// Token: 0x04003F35 RID: 16181
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(82U);

		// Token: 0x04003F36 RID: 16182
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();
	}
}
