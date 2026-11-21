using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200050D RID: 1293
	[NetMessage(EMessageId.FarmGoldLevelPlayRepeatedRequest)]
	public sealed class FarmGoldLevelPlayRepeatedRequest : IMessage<FarmGoldLevelPlayRepeatedRequest>, IMessage, IEquatable<FarmGoldLevelPlayRepeatedRequest>, IDeepCloneable<FarmGoldLevelPlayRepeatedRequest>, IBufferMessage
	{
		// Token: 0x060079F2 RID: 31218 RVA: 0x001288FC File Offset: 0x00126AFC
		[NullableContext(1)]
		public static FarmGoldLevelPlayRepeatedRequest Create()
		{
			return new FarmGoldLevelPlayRepeatedRequest();
		}

		// Token: 0x170017A2 RID: 6050
		// (get) Token: 0x060079F3 RID: 31219 RVA: 0x00128903 File Offset: 0x00126B03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170017A3 RID: 6051
		// (get) Token: 0x060079F4 RID: 31220 RVA: 0x00128906 File Offset: 0x00126B06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FarmGoldLevelPlayRepeatedRequest.Descriptor;
			}
		}

		// Token: 0x060079F5 RID: 31221 RVA: 0x0012890D File Offset: 0x00126B0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldLevelPlayRepeatedRequest()
		{
		}

		// Token: 0x060079F6 RID: 31222 RVA: 0x00128920 File Offset: 0x00126B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldLevelPlayRepeatedRequest(FarmGoldLevelPlayRepeatedRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.instIdList_ = other.instIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060079F7 RID: 31223 RVA: 0x00128956 File Offset: 0x00126B56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldLevelPlayRepeatedRequest Clone()
		{
			return new FarmGoldLevelPlayRepeatedRequest(this);
		}

		// Token: 0x170017A4 RID: 6052
		// (get) Token: 0x060079F8 RID: 31224 RVA: 0x0012895E File Offset: 0x00126B5E
		// (set) Token: 0x060079F9 RID: 31225 RVA: 0x00128966 File Offset: 0x00126B66
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

		// Token: 0x170017A5 RID: 6053
		// (get) Token: 0x060079FA RID: 31226 RVA: 0x0012896F File Offset: 0x00126B6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> InstIdList
		{
			get
			{
				return this.instIdList_;
			}
		}

		// Token: 0x060079FB RID: 31227 RVA: 0x00128977 File Offset: 0x00126B77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FarmGoldLevelPlayRepeatedRequest);
		}

		// Token: 0x060079FC RID: 31228 RVA: 0x00128988 File Offset: 0x00126B88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FarmGoldLevelPlayRepeatedRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.instIdList_.Equals(other.instIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060079FD RID: 31229 RVA: 0x001289D8 File Offset: 0x00126BD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.instIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060079FE RID: 31230 RVA: 0x00128A25 File Offset: 0x00126C25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060079FF RID: 31231 RVA: 0x00128A32 File Offset: 0x00126C32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007A00 RID: 31232 RVA: 0x00128A3C File Offset: 0x00126C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.instIdList_.WriteTo(ref output, FarmGoldLevelPlayRepeatedRequest._repeated_instIdList_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007A01 RID: 31233 RVA: 0x00128A8C File Offset: 0x00126C8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.instIdList_.CalculateSize(FarmGoldLevelPlayRepeatedRequest._repeated_instIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007A02 RID: 31234 RVA: 0x00128AE0 File Offset: 0x00126CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FarmGoldLevelPlayRepeatedRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.instIdList_.Add(other.instIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007A03 RID: 31235 RVA: 0x00128B2D File Offset: 0x00126D2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007A04 RID: 31236 RVA: 0x00128B38 File Offset: 0x00126D38
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
				if (num != 96U && num != 98U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.instIdList_.AddEntriesFrom(ref input, FarmGoldLevelPlayRepeatedRequest._repeated_instIdList_codec);
				}
			}
		}

		// Token: 0x04003F20 RID: 16160
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F21 RID: 16161
		public const int ActivityIdFieldNumber = 15;

		// Token: 0x04003F22 RID: 16162
		private int activityId_;

		// Token: 0x04003F23 RID: 16163
		public const int InstIdListFieldNumber = 12;

		// Token: 0x04003F24 RID: 16164
		private static readonly FieldCodec<int> _repeated_instIdList_codec = FieldCodec.ForInt32(98U);

		// Token: 0x04003F25 RID: 16165
		private readonly RepeatedField<int> instIdList_ = new RepeatedField<int>();
	}
}
