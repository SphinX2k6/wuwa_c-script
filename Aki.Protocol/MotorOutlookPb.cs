using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A7C RID: 2684
	public sealed class MotorOutlookPb : IMessage<MotorOutlookPb>, IMessage, IEquatable<MotorOutlookPb>, IDeepCloneable<MotorOutlookPb>, IBufferMessage
	{
		// Token: 0x0600EA24 RID: 59940 RVA: 0x00223442 File Offset: 0x00221642
		[NullableContext(1)]
		public static MotorOutlookPb Create()
		{
			return new MotorOutlookPb();
		}

		// Token: 0x17002F81 RID: 12161
		// (get) Token: 0x0600EA25 RID: 59941 RVA: 0x00223449 File Offset: 0x00221649
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F82 RID: 12162
		// (get) Token: 0x0600EA26 RID: 59942 RVA: 0x0022344C File Offset: 0x0022164C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorOutlookPb.Descriptor;
			}
		}

		// Token: 0x0600EA27 RID: 59943 RVA: 0x00223453 File Offset: 0x00221653
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookPb()
		{
		}

		// Token: 0x0600EA28 RID: 59944 RVA: 0x00223468 File Offset: 0x00221668
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

		// Token: 0x0600EA29 RID: 59945 RVA: 0x002234FD File Offset: 0x002216FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookPb Clone()
		{
			return new MotorOutlookPb(this);
		}

		// Token: 0x17002F83 RID: 12163
		// (get) Token: 0x0600EA2A RID: 59946 RVA: 0x00223505 File Offset: 0x00221705
		// (set) Token: 0x0600EA2B RID: 59947 RVA: 0x0022350D File Offset: 0x0022170D
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

		// Token: 0x17002F84 RID: 12164
		// (get) Token: 0x0600EA2C RID: 59948 RVA: 0x00223516 File Offset: 0x00221716
		// (set) Token: 0x0600EA2D RID: 59949 RVA: 0x0022351E File Offset: 0x0022171E
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

		// Token: 0x17002F85 RID: 12165
		// (get) Token: 0x0600EA2E RID: 59950 RVA: 0x00223527 File Offset: 0x00221727
		// (set) Token: 0x0600EA2F RID: 59951 RVA: 0x0022352F File Offset: 0x0022172F
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

		// Token: 0x17002F86 RID: 12166
		// (get) Token: 0x0600EA30 RID: 59952 RVA: 0x00223538 File Offset: 0x00221738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorOutlookEquippedPb> LatestMotorSkinSuit
		{
			get
			{
				return this.latestMotorSkinSuit_;
			}
		}

		// Token: 0x17002F87 RID: 12167
		// (get) Token: 0x0600EA31 RID: 59953 RVA: 0x00223540 File Offset: 0x00221740
		// (set) Token: 0x0600EA32 RID: 59954 RVA: 0x00223548 File Offset: 0x00221748
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

		// Token: 0x0600EA33 RID: 59955 RVA: 0x00223551 File Offset: 0x00221751
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorOutlookPb);
		}

		// Token: 0x0600EA34 RID: 59956 RVA: 0x00223560 File Offset: 0x00221760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorOutlookPb other)
		{
			return other != null && (other == this || (object.Equals(this.MotorOutlookOwned, other.MotorOutlookOwned) && object.Equals(this.MotorOutlookEquipped, other.MotorOutlookEquipped) && object.Equals(this.MotorOutlookPreset, other.MotorOutlookPreset) && this.latestMotorSkinSuit_.Equals(other.latestMotorSkinSuit_) && this.SceneInUse == other.SceneInUse && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EA35 RID: 59957 RVA: 0x002235F0 File Offset: 0x002217F0
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

		// Token: 0x0600EA36 RID: 59958 RVA: 0x0022367F File Offset: 0x0022187F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EA37 RID: 59959 RVA: 0x0022368C File Offset: 0x0022188C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EA38 RID: 59960 RVA: 0x00223698 File Offset: 0x00221898
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

		// Token: 0x0600EA39 RID: 59961 RVA: 0x0022373C File Offset: 0x0022193C
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

		// Token: 0x0600EA3A RID: 59962 RVA: 0x002237D8 File Offset: 0x002219D8
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

		// Token: 0x0600EA3B RID: 59963 RVA: 0x002238A9 File Offset: 0x00221AA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EA3C RID: 59964 RVA: 0x002238B4 File Offset: 0x00221AB4
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

		// Token: 0x04005F7B RID: 24443
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005F7C RID: 24444
		public const int MotorOutlookOwnedFieldNumber = 1;

		// Token: 0x04005F7D RID: 24445
		private MotorOutlookOwnedPb motorOutlookOwned_;

		// Token: 0x04005F7E RID: 24446
		public const int MotorOutlookEquippedFieldNumber = 2;

		// Token: 0x04005F7F RID: 24447
		private MotorOutlookEquippedPb motorOutlookEquipped_;

		// Token: 0x04005F80 RID: 24448
		public const int MotorOutlookPresetFieldNumber = 3;

		// Token: 0x04005F81 RID: 24449
		private MotorOutlookPlayerPresetPb motorOutlookPreset_;

		// Token: 0x04005F82 RID: 24450
		public const int LatestMotorSkinSuitFieldNumber = 4;

		// Token: 0x04005F83 RID: 24451
		private static readonly FieldCodec<MotorOutlookEquippedPb> _repeated_latestMotorSkinSuit_codec = FieldCodec.ForMessage<MotorOutlookEquippedPb>(34U, MotorOutlookEquippedPb.Parser);

		// Token: 0x04005F84 RID: 24452
		private readonly RepeatedField<MotorOutlookEquippedPb> latestMotorSkinSuit_ = new RepeatedField<MotorOutlookEquippedPb>();

		// Token: 0x04005F85 RID: 24453
		public const int SceneInUseFieldNumber = 5;

		// Token: 0x04005F86 RID: 24454
		private int sceneInUse_;
	}
}
