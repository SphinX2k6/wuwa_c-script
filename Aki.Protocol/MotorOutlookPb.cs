using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A8D RID: 2701
	public sealed class MotorOutlookPb : IMessage<MotorOutlookPb>, IMessage, IEquatable<MotorOutlookPb>, IDeepCloneable<MotorOutlookPb>, IBufferMessage
	{
		// Token: 0x0600EB3E RID: 60222 RVA: 0x0022563E File Offset: 0x0022383E
		[NullableContext(1)]
		public static MotorOutlookPb Create()
		{
			return new MotorOutlookPb();
		}

		// Token: 0x17002FBF RID: 12223
		// (get) Token: 0x0600EB3F RID: 60223 RVA: 0x00225645 File Offset: 0x00223845
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002FC0 RID: 12224
		// (get) Token: 0x0600EB40 RID: 60224 RVA: 0x00225648 File Offset: 0x00223848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorOutlookPb.Descriptor;
			}
		}

		// Token: 0x0600EB41 RID: 60225 RVA: 0x0022564F File Offset: 0x0022384F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookPb()
		{
		}

		// Token: 0x0600EB42 RID: 60226 RVA: 0x00225664 File Offset: 0x00223864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookPb(MotorOutlookPb other) : this()
		{
			this.motorOutlookOwned_ = ((other.motorOutlookOwned_ != null) ? other.motorOutlookOwned_.Clone() : null);
			this.motorOutlookEquipped_ = ((other.motorOutlookEquipped_ != null) ? other.motorOutlookEquipped_.Clone() : null);
			this.motorOutlookPreset_ = ((other.motorOutlookPreset_ != null) ? other.motorOutlookPreset_.Clone() : null);
			this.latestMotorSkinSuit_ = other.latestMotorSkinSuit_.Clone();
			this.sceneInUse_ = other.sceneInUse_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EB43 RID: 60227 RVA: 0x002256F9 File Offset: 0x002238F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookPb Clone()
		{
			return new MotorOutlookPb(this);
		}

		// Token: 0x17002FC1 RID: 12225
		// (get) Token: 0x0600EB44 RID: 60228 RVA: 0x00225701 File Offset: 0x00223901
		// (set) Token: 0x0600EB45 RID: 60229 RVA: 0x00225709 File Offset: 0x00223909
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookOwnedPb MotorOutlookOwned
		{
			get
			{
				return this.motorOutlookOwned_;
			}
			set
			{
				this.motorOutlookOwned_ = value;
			}
		}

		// Token: 0x17002FC2 RID: 12226
		// (get) Token: 0x0600EB46 RID: 60230 RVA: 0x00225712 File Offset: 0x00223912
		// (set) Token: 0x0600EB47 RID: 60231 RVA: 0x0022571A File Offset: 0x0022391A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookEquippedPb MotorOutlookEquipped
		{
			get
			{
				return this.motorOutlookEquipped_;
			}
			set
			{
				this.motorOutlookEquipped_ = value;
			}
		}

		// Token: 0x17002FC3 RID: 12227
		// (get) Token: 0x0600EB48 RID: 60232 RVA: 0x00225723 File Offset: 0x00223923
		// (set) Token: 0x0600EB49 RID: 60233 RVA: 0x0022572B File Offset: 0x0022392B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookPlayerPresetPb MotorOutlookPreset
		{
			get
			{
				return this.motorOutlookPreset_;
			}
			set
			{
				this.motorOutlookPreset_ = value;
			}
		}

		// Token: 0x17002FC4 RID: 12228
		// (get) Token: 0x0600EB4A RID: 60234 RVA: 0x00225734 File Offset: 0x00223934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorOutlookEquippedPb> LatestMotorSkinSuit
		{
			get
			{
				return this.latestMotorSkinSuit_;
			}
		}

		// Token: 0x17002FC5 RID: 12229
		// (get) Token: 0x0600EB4B RID: 60235 RVA: 0x0022573C File Offset: 0x0022393C
		// (set) Token: 0x0600EB4C RID: 60236 RVA: 0x00225744 File Offset: 0x00223944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SceneInUse
		{
			get
			{
				return this.sceneInUse_;
			}
			set
			{
				this.sceneInUse_ = value;
			}
		}

		// Token: 0x0600EB4D RID: 60237 RVA: 0x0022574D File Offset: 0x0022394D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorOutlookPb);
		}

		// Token: 0x0600EB4E RID: 60238 RVA: 0x0022575C File Offset: 0x0022395C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorOutlookPb other)
		{
			return other != null && (other == this || (object.Equals(this.MotorOutlookOwned, other.MotorOutlookOwned) && object.Equals(this.MotorOutlookEquipped, other.MotorOutlookEquipped) && object.Equals(this.MotorOutlookPreset, other.MotorOutlookPreset) && this.latestMotorSkinSuit_.Equals(other.latestMotorSkinSuit_) && this.SceneInUse == other.SceneInUse && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EB4F RID: 60239 RVA: 0x002257EC File Offset: 0x002239EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.motorOutlookOwned_ != null)
			{
				num ^= this.MotorOutlookOwned.GetHashCode();
			}
			if (this.motorOutlookEquipped_ != null)
			{
				num ^= this.MotorOutlookEquipped.GetHashCode();
			}
			if (this.motorOutlookPreset_ != null)
			{
				num ^= this.MotorOutlookPreset.GetHashCode();
			}
			num ^= this.latestMotorSkinSuit_.GetHashCode();
			if (this.SceneInUse != 0)
			{
				num ^= this.SceneInUse.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600EB50 RID: 60240 RVA: 0x0022587B File Offset: 0x00223A7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EB51 RID: 60241 RVA: 0x00225888 File Offset: 0x00223A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EB52 RID: 60242 RVA: 0x00225894 File Offset: 0x00223A94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.motorOutlookOwned_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.MotorOutlookOwned);
			}
			if (this.motorOutlookEquipped_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.MotorOutlookEquipped);
			}
			if (this.motorOutlookPreset_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.MotorOutlookPreset);
			}
			this.latestMotorSkinSuit_.WriteTo(ref output, MotorOutlookPb._repeated_latestMotorSkinSuit_codec);
			if (this.SceneInUse != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.SceneInUse);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EB53 RID: 60243 RVA: 0x00225938 File Offset: 0x00223B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.motorOutlookOwned_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MotorOutlookOwned);
			}
			if (this.motorOutlookEquipped_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MotorOutlookEquipped);
			}
			if (this.motorOutlookPreset_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MotorOutlookPreset);
			}
			num += this.latestMotorSkinSuit_.CalculateSize(MotorOutlookPb._repeated_latestMotorSkinSuit_codec);
			if (this.SceneInUse != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SceneInUse);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600EB54 RID: 60244 RVA: 0x002259D4 File Offset: 0x00223BD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorOutlookPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.motorOutlookOwned_ != null)
			{
				if (this.motorOutlookOwned_ == null)
				{
					this.MotorOutlookOwned = new MotorOutlookOwnedPb();
				}
				this.MotorOutlookOwned.MergeFrom(other.MotorOutlookOwned);
			}
			if (other.motorOutlookEquipped_ != null)
			{
				if (this.motorOutlookEquipped_ == null)
				{
					this.MotorOutlookEquipped = new MotorOutlookEquippedPb();
				}
				this.MotorOutlookEquipped.MergeFrom(other.MotorOutlookEquipped);
			}
			if (other.motorOutlookPreset_ != null)
			{
				if (this.motorOutlookPreset_ == null)
				{
					this.MotorOutlookPreset = new MotorOutlookPlayerPresetPb();
				}
				this.MotorOutlookPreset.MergeFrom(other.MotorOutlookPreset);
			}
			this.latestMotorSkinSuit_.Add(other.latestMotorSkinSuit_);
			if (other.SceneInUse != 0)
			{
				this.SceneInUse = other.SceneInUse;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600EB55 RID: 60245 RVA: 0x00225AA5 File Offset: 0x00223CA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EB56 RID: 60246 RVA: 0x00225AB0 File Offset: 0x00223CB0
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
				if (num <= 18U)
				{
					if (num == 10U)
					{
						if (this.motorOutlookOwned_ == null)
						{
							this.MotorOutlookOwned = new MotorOutlookOwnedPb();
						}
						input.ReadMessage(this.MotorOutlookOwned);
						continue;
					}
					if (num == 18U)
					{
						if (this.motorOutlookEquipped_ == null)
						{
							this.MotorOutlookEquipped = new MotorOutlookEquippedPb();
						}
						input.ReadMessage(this.MotorOutlookEquipped);
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						if (this.motorOutlookPreset_ == null)
						{
							this.MotorOutlookPreset = new MotorOutlookPlayerPresetPb();
						}
						input.ReadMessage(this.MotorOutlookPreset);
						continue;
					}
					if (num == 34U)
					{
						this.latestMotorSkinSuit_.AddEntriesFrom(ref input, MotorOutlookPb._repeated_latestMotorSkinSuit_codec);
						continue;
					}
					if (num == 40U)
					{
						this.SceneInUse = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005F72 RID: 24434
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005F73 RID: 24435
		public const int MotorOutlookOwnedFieldNumber = 1;

		// Token: 0x04005F74 RID: 24436
		private MotorOutlookOwnedPb motorOutlookOwned_;

		// Token: 0x04005F75 RID: 24437
		public const int MotorOutlookEquippedFieldNumber = 2;

		// Token: 0x04005F76 RID: 24438
		private MotorOutlookEquippedPb motorOutlookEquipped_;

		// Token: 0x04005F77 RID: 24439
		public const int MotorOutlookPresetFieldNumber = 3;

		// Token: 0x04005F78 RID: 24440
		private MotorOutlookPlayerPresetPb motorOutlookPreset_;

		// Token: 0x04005F79 RID: 24441
		public const int LatestMotorSkinSuitFieldNumber = 4;

		// Token: 0x04005F7A RID: 24442
		private static readonly FieldCodec<MotorOutlookEquippedPb> _repeated_latestMotorSkinSuit_codec = FieldCodec.ForMessage<MotorOutlookEquippedPb>(34U, MotorOutlookEquippedPb.Parser);

		// Token: 0x04005F7B RID: 24443
		private readonly RepeatedField<MotorOutlookEquippedPb> latestMotorSkinSuit_ = new RepeatedField<MotorOutlookEquippedPb>();

		// Token: 0x04005F7C RID: 24444
		public const int SceneInUseFieldNumber = 5;

		// Token: 0x04005F7D RID: 24445
		private int sceneInUse_;
	}
}
