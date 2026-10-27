using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A97 RID: 2711
	[NetMessage(EMessageId.MotorParkourLevelRewardUpdateNotify)]
	public sealed class MotorParkourLevelRewardUpdateNotify : IMessage<MotorParkourLevelRewardUpdateNotify>, IMessage, IEquatable<MotorParkourLevelRewardUpdateNotify>, IDeepCloneable<MotorParkourLevelRewardUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600EC0E RID: 60430 RVA: 0x00227590 File Offset: 0x00225790
		[NullableContext(1)]
		public static MotorParkourLevelRewardUpdateNotify Create()
		{
			return new MotorParkourLevelRewardUpdateNotify();
		}

		// Token: 0x17002FEE RID: 12270
		// (get) Token: 0x0600EC0F RID: 60431 RVA: 0x00227597 File Offset: 0x00225797
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002FEF RID: 12271
		// (get) Token: 0x0600EC10 RID: 60432 RVA: 0x0022759A File Offset: 0x0022579A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorParkourLevelRewardUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600EC11 RID: 60433 RVA: 0x002275A1 File Offset: 0x002257A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorParkourLevelRewardUpdateNotify()
		{
		}

		// Token: 0x0600EC12 RID: 60434 RVA: 0x002275B4 File Offset: 0x002257B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorParkourLevelRewardUpdateNotify(MotorParkourLevelRewardUpdateNotify other) : this()
		{
			this.motorParkourLevelInfos_ = other.motorParkourLevelInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EC13 RID: 60435 RVA: 0x002275DE File Offset: 0x002257DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorParkourLevelRewardUpdateNotify Clone()
		{
			return new MotorParkourLevelRewardUpdateNotify(this);
		}

		// Token: 0x17002FF0 RID: 12272
		// (get) Token: 0x0600EC14 RID: 60436 RVA: 0x002275E6 File Offset: 0x002257E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorParkourLevelInfo> MotorParkourLevelInfos
		{
			get
			{
				return this.motorParkourLevelInfos_;
			}
		}

		// Token: 0x0600EC15 RID: 60437 RVA: 0x002275EE File Offset: 0x002257EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorParkourLevelRewardUpdateNotify);
		}

		// Token: 0x0600EC16 RID: 60438 RVA: 0x002275FC File Offset: 0x002257FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorParkourLevelRewardUpdateNotify other)
		{
			return other != null && (other == this || (this.motorParkourLevelInfos_.Equals(other.motorParkourLevelInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EC17 RID: 60439 RVA: 0x00227630 File Offset: 0x00225830
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

		// Token: 0x0600EC18 RID: 60440 RVA: 0x00227664 File Offset: 0x00225864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EC19 RID: 60441 RVA: 0x00227671 File Offset: 0x00225871
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EC1A RID: 60442 RVA: 0x0022767A File Offset: 0x0022587A
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

		// Token: 0x0600EC1B RID: 60443 RVA: 0x002276A4 File Offset: 0x002258A4
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

		// Token: 0x0600EC1C RID: 60444 RVA: 0x002276DD File Offset: 0x002258DD
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

		// Token: 0x0600EC1D RID: 60445 RVA: 0x0022770B File Offset: 0x0022590B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EC1E RID: 60446 RVA: 0x00227714 File Offset: 0x00225914
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
				if (num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.motorParkourLevelInfos_.AddEntriesFrom(ref input, MotorParkourLevelRewardUpdateNotify._repeated_motorParkourLevelInfos_codec);
				}
			}
		}

		// Token: 0x04005FBB RID: 24507
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005FBC RID: 24508
		public const int MotorParkourLevelInfosFieldNumber = 9;

		// Token: 0x04005FBD RID: 24509
		private static readonly FieldCodec<MotorParkourLevelInfo> _repeated_motorParkourLevelInfos_codec = FieldCodec.ForMessage<MotorParkourLevelInfo>(74U, MotorParkourLevelInfo.Parser);

		// Token: 0x04005FBE RID: 24510
		private readonly RepeatedField<MotorParkourLevelInfo> motorParkourLevelInfos_ = new RepeatedField<MotorParkourLevelInfo>();
	}
}
