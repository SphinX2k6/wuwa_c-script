using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EC8 RID: 3784
	[NetMessage(EMessageId.RegressActivityTrialRoleUpdateNotify)]
	public sealed class RegressActivityTrialRoleUpdateNotify : IMessage<RegressActivityTrialRoleUpdateNotify>, IMessage, IEquatable<RegressActivityTrialRoleUpdateNotify>, IDeepCloneable<RegressActivityTrialRoleUpdateNotify>, IBufferMessage
	{
		// Token: 0x060144FE RID: 83198 RVA: 0x002F42BD File Offset: 0x002F24BD
		[NullableContext(1)]
		public static RegressActivityTrialRoleUpdateNotify Create()
		{
			return new RegressActivityTrialRoleUpdateNotify();
		}

		// Token: 0x1700438B RID: 17291
		// (get) Token: 0x060144FF RID: 83199 RVA: 0x002F42C4 File Offset: 0x002F24C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700438C RID: 17292
		// (get) Token: 0x06014500 RID: 83200 RVA: 0x002F42C7 File Offset: 0x002F24C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RegressActivityTrialRoleUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06014501 RID: 83201 RVA: 0x002F42CE File Offset: 0x002F24CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressActivityTrialRoleUpdateNotify()
		{
		}

		// Token: 0x06014502 RID: 83202 RVA: 0x002F42E4 File Offset: 0x002F24E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressActivityTrialRoleUpdateNotify(RegressActivityTrialRoleUpdateNotify other) : this()
		{
			this.trialRoleId_ = other.trialRoleId_.Clone();
			this.curUseRoleInfo_ = ((other.curUseRoleInfo_ != null) ? other.curUseRoleInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014503 RID: 83203 RVA: 0x002F4335 File Offset: 0x002F2535
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressActivityTrialRoleUpdateNotify Clone()
		{
			return new RegressActivityTrialRoleUpdateNotify(this);
		}

		// Token: 0x1700438D RID: 17293
		// (get) Token: 0x06014504 RID: 83204 RVA: 0x002F433D File Offset: 0x002F253D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TrialRoleId
		{
			get
			{
				return this.trialRoleId_;
			}
		}

		// Token: 0x1700438E RID: 17294
		// (get) Token: 0x06014505 RID: 83205 RVA: 0x002F4345 File Offset: 0x002F2545
		// (set) Token: 0x06014506 RID: 83206 RVA: 0x002F434D File Offset: 0x002F254D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public roleInfo CurUseRoleInfo
		{
			get
			{
				return this.curUseRoleInfo_;
			}
			set
			{
				this.curUseRoleInfo_ = value;
			}
		}

		// Token: 0x06014507 RID: 83207 RVA: 0x002F4356 File Offset: 0x002F2556
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RegressActivityTrialRoleUpdateNotify);
		}

		// Token: 0x06014508 RID: 83208 RVA: 0x002F4364 File Offset: 0x002F2564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RegressActivityTrialRoleUpdateNotify other)
		{
			return other != null && (other == this || (this.trialRoleId_.Equals(other.trialRoleId_) && object.Equals(this.CurUseRoleInfo, other.CurUseRoleInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014509 RID: 83209 RVA: 0x002F43B8 File Offset: 0x002F25B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.trialRoleId_.GetHashCode();
			if (this.curUseRoleInfo_ != null)
			{
				num ^= this.CurUseRoleInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601450A RID: 83210 RVA: 0x002F4402 File Offset: 0x002F2602
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601450B RID: 83211 RVA: 0x002F440F File Offset: 0x002F260F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601450C RID: 83212 RVA: 0x002F4418 File Offset: 0x002F2618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.curUseRoleInfo_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.CurUseRoleInfo);
			}
			this.trialRoleId_.WriteTo(ref output, RegressActivityTrialRoleUpdateNotify._repeated_trialRoleId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601450D RID: 83213 RVA: 0x002F4468 File Offset: 0x002F2668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.trialRoleId_.CalculateSize(RegressActivityTrialRoleUpdateNotify._repeated_trialRoleId_codec);
			if (this.curUseRoleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CurUseRoleInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601450E RID: 83214 RVA: 0x002F44BC File Offset: 0x002F26BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RegressActivityTrialRoleUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.trialRoleId_.Add(other.trialRoleId_);
			if (other.curUseRoleInfo_ != null)
			{
				if (this.curUseRoleInfo_ == null)
				{
					this.CurUseRoleInfo = new roleInfo();
				}
				this.CurUseRoleInfo.MergeFrom(other.CurUseRoleInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601450F RID: 83215 RVA: 0x002F4521 File Offset: 0x002F2721
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014510 RID: 83216 RVA: 0x002F452C File Offset: 0x002F272C
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
				if (num != 50U)
				{
					if (num != 72U && num != 74U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.trialRoleId_.AddEntriesFrom(ref input, RegressActivityTrialRoleUpdateNotify._repeated_trialRoleId_codec);
					}
				}
				else
				{
					if (this.curUseRoleInfo_ == null)
					{
						this.CurUseRoleInfo = new roleInfo();
					}
					input.ReadMessage(this.CurUseRoleInfo);
				}
			}
		}

		// Token: 0x04007BCA RID: 31690
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007BCB RID: 31691
		public const int TrialRoleIdFieldNumber = 9;

		// Token: 0x04007BCC RID: 31692
		private static readonly FieldCodec<int> _repeated_trialRoleId_codec = FieldCodec.ForInt32(74U);

		// Token: 0x04007BCD RID: 31693
		private readonly RepeatedField<int> trialRoleId_ = new RepeatedField<int>();

		// Token: 0x04007BCE RID: 31694
		public const int CurUseRoleInfoFieldNumber = 6;

		// Token: 0x04007BCF RID: 31695
		private roleInfo curUseRoleInfo_;
	}
}
