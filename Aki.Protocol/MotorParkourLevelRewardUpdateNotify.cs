using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A86 RID: 2694
	[NetMessage(EMessageId.MotorParkourLevelRewardUpdateNotify)]
	public sealed class MotorParkourLevelRewardUpdateNotify : IMessage<MotorParkourLevelRewardUpdateNotify>, IMessage, IEquatable<MotorParkourLevelRewardUpdateNotify>, IDeepCloneable<MotorParkourLevelRewardUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600EAF4 RID: 60148 RVA: 0x00225399 File Offset: 0x00223599
		[NullableContext(1)]
		public static MotorParkourLevelRewardUpdateNotify Create()
		{
			return new MotorParkourLevelRewardUpdateNotify();
		}

		// Token: 0x17002FB0 RID: 12208
		// (get) Token: 0x0600EAF5 RID: 60149 RVA: 0x002253A0 File Offset: 0x002235A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002FB1 RID: 12209
		// (get) Token: 0x0600EAF6 RID: 60150 RVA: 0x002253A3 File Offset: 0x002235A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorParkourLevelRewardUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600EAF7 RID: 60151 RVA: 0x002253AA File Offset: 0x002235AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorParkourLevelRewardUpdateNotify()
		{
		}

		// Token: 0x0600EAF8 RID: 60152 RVA: 0x002253BD File Offset: 0x002235BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorParkourLevelRewardUpdateNotify(MotorParkourLevelRewardUpdateNotify other) : this()
		{
			this.motorParkourLevelInfos_ = other.motorParkourLevelInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EAF9 RID: 60153 RVA: 0x002253E7 File Offset: 0x002235E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorParkourLevelRewardUpdateNotify Clone()
		{
			return new MotorParkourLevelRewardUpdateNotify(this);
		}

		// Token: 0x17002FB2 RID: 12210
		// (get) Token: 0x0600EAFA RID: 60154 RVA: 0x002253EF File Offset: 0x002235EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorParkourLevelInfo> MotorParkourLevelInfos
		{
			get
			{
				return this.motorParkourLevelInfos_;
			}
		}

		// Token: 0x0600EAFB RID: 60155 RVA: 0x002253F7 File Offset: 0x002235F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorParkourLevelRewardUpdateNotify);
		}

		// Token: 0x0600EAFC RID: 60156 RVA: 0x00225405 File Offset: 0x00223605
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorParkourLevelRewardUpdateNotify other)
		{
			return other != null && (other == this || (this.motorParkourLevelInfos_.Equals(other.motorParkourLevelInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EAFD RID: 60157 RVA: 0x00225438 File Offset: 0x00223638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.motorParkourLevelInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600EAFE RID: 60158 RVA: 0x0022546C File Offset: 0x0022366C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EAFF RID: 60159 RVA: 0x00225479 File Offset: 0x00223679
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EB00 RID: 60160 RVA: 0x00225482 File Offset: 0x00223682
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.motorParkourLevelInfos_.WriteTo(ref output, MotorParkourLevelRewardUpdateNotify._repeated_motorParkourLevelInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EB01 RID: 60161 RVA: 0x002254AC File Offset: 0x002236AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.motorParkourLevelInfos_.CalculateSize(MotorParkourLevelRewardUpdateNotify._repeated_motorParkourLevelInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600EB02 RID: 60162 RVA: 0x002254E5 File Offset: 0x002236E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorParkourLevelRewardUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.motorParkourLevelInfos_.Add(other.motorParkourLevelInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600EB03 RID: 60163 RVA: 0x00225513 File Offset: 0x00223713
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EB04 RID: 60164 RVA: 0x0022551C File Offset: 0x0022371C
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
				if (num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.motorParkourLevelInfos_.AddEntriesFrom(ref input, MotorParkourLevelRewardUpdateNotify._repeated_motorParkourLevelInfos_codec);
				}
			}
		}

		// Token: 0x04005FC4 RID: 24516
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005FC5 RID: 24517
		public const int MotorParkourLevelInfosFieldNumber = 12;

		// Token: 0x04005FC6 RID: 24518
		private static readonly FieldCodec<MotorParkourLevelInfo> _repeated_motorParkourLevelInfos_codec = FieldCodec.ForMessage<MotorParkourLevelInfo>(98U, MotorParkourLevelInfo.Parser);

		// Token: 0x04005FC7 RID: 24519
		private readonly RepeatedField<MotorParkourLevelInfo> motorParkourLevelInfos_ = new RepeatedField<MotorParkourLevelInfo>();
	}
}
