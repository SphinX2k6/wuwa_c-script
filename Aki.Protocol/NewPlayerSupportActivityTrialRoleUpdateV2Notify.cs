using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B1F RID: 2847
	[NetMessage(EMessageId.NewPlayerSupportActivityTrialRoleUpdateV2Notify)]
	public sealed class NewPlayerSupportActivityTrialRoleUpdateV2Notify : IMessage<NewPlayerSupportActivityTrialRoleUpdateV2Notify>, IMessage, IEquatable<NewPlayerSupportActivityTrialRoleUpdateV2Notify>, IDeepCloneable<NewPlayerSupportActivityTrialRoleUpdateV2Notify>, IBufferMessage
	{
		// Token: 0x0600F727 RID: 63271 RVA: 0x0024087B File Offset: 0x0023EA7B
		[NullableContext(1)]
		public static NewPlayerSupportActivityTrialRoleUpdateV2Notify Create()
		{
			return new NewPlayerSupportActivityTrialRoleUpdateV2Notify();
		}

		// Token: 0x17003255 RID: 12885
		// (get) Token: 0x0600F728 RID: 63272 RVA: 0x00240882 File Offset: 0x0023EA82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003256 RID: 12886
		// (get) Token: 0x0600F729 RID: 63273 RVA: 0x00240885 File Offset: 0x0023EA85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewPlayerSupportActivityTrialRoleUpdateV2Notify.Descriptor;
			}
		}

		// Token: 0x0600F72A RID: 63274 RVA: 0x0024088C File Offset: 0x0023EA8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportActivityTrialRoleUpdateV2Notify()
		{
		}

		// Token: 0x0600F72B RID: 63275 RVA: 0x002408A0 File Offset: 0x0023EAA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportActivityTrialRoleUpdateV2Notify(NewPlayerSupportActivityTrialRoleUpdateV2Notify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.trialRoleId_ = other.trialRoleId_.Clone();
			this.curUseRoleInfo_ = ((other.curUseRoleInfo_ != null) ? other.curUseRoleInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F72C RID: 63276 RVA: 0x002408FD File Offset: 0x0023EAFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportActivityTrialRoleUpdateV2Notify Clone()
		{
			return new NewPlayerSupportActivityTrialRoleUpdateV2Notify(this);
		}

		// Token: 0x17003257 RID: 12887
		// (get) Token: 0x0600F72D RID: 63277 RVA: 0x00240905 File Offset: 0x0023EB05
		// (set) Token: 0x0600F72E RID: 63278 RVA: 0x0024090D File Offset: 0x0023EB0D
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

		// Token: 0x17003258 RID: 12888
		// (get) Token: 0x0600F72F RID: 63279 RVA: 0x00240916 File Offset: 0x0023EB16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TrialRoleId
		{
			get
			{
				return this.trialRoleId_;
			}
		}

		// Token: 0x17003259 RID: 12889
		// (get) Token: 0x0600F730 RID: 63280 RVA: 0x0024091E File Offset: 0x0023EB1E
		// (set) Token: 0x0600F731 RID: 63281 RVA: 0x00240926 File Offset: 0x0023EB26
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

		// Token: 0x0600F732 RID: 63282 RVA: 0x0024092F File Offset: 0x0023EB2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewPlayerSupportActivityTrialRoleUpdateV2Notify);
		}

		// Token: 0x0600F733 RID: 63283 RVA: 0x00240940 File Offset: 0x0023EB40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewPlayerSupportActivityTrialRoleUpdateV2Notify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.trialRoleId_.Equals(other.trialRoleId_) && object.Equals(this.CurUseRoleInfo, other.CurUseRoleInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F734 RID: 63284 RVA: 0x002409A4 File Offset: 0x0023EBA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
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

		// Token: 0x0600F735 RID: 63285 RVA: 0x00240A07 File Offset: 0x0023EC07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F736 RID: 63286 RVA: 0x00240A14 File Offset: 0x0023EC14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F737 RID: 63287 RVA: 0x00240A20 File Offset: 0x0023EC20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ActivityId);
			}
			this.trialRoleId_.WriteTo(ref output, NewPlayerSupportActivityTrialRoleUpdateV2Notify._repeated_trialRoleId_codec);
			if (this.curUseRoleInfo_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.CurUseRoleInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F738 RID: 63288 RVA: 0x00240A8C File Offset: 0x0023EC8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.trialRoleId_.CalculateSize(NewPlayerSupportActivityTrialRoleUpdateV2Notify._repeated_trialRoleId_codec);
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

		// Token: 0x0600F739 RID: 63289 RVA: 0x00240AF8 File Offset: 0x0023ECF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewPlayerSupportActivityTrialRoleUpdateV2Notify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
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

		// Token: 0x0600F73A RID: 63290 RVA: 0x00240B71 File Offset: 0x0023ED71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F73B RID: 63291 RVA: 0x00240B7C File Offset: 0x0023ED7C
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
				if (num <= 32U)
				{
					if (num == 8U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						goto IL_45;
					}
				}
				else
				{
					if (num == 34U)
					{
						goto IL_45;
					}
					if (num == 58U)
					{
						if (this.curUseRoleInfo_ == null)
						{
							this.CurUseRoleInfo = new roleInfo();
						}
						input.ReadMessage(this.CurUseRoleInfo);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_45:
				this.trialRoleId_.AddEntriesFrom(ref input, NewPlayerSupportActivityTrialRoleUpdateV2Notify._repeated_trialRoleId_codec);
			}
		}

		// Token: 0x0400632B RID: 25387
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400632C RID: 25388
		public const int ActivityIdFieldNumber = 1;

		// Token: 0x0400632D RID: 25389
		private int activityId_;

		// Token: 0x0400632E RID: 25390
		public const int TrialRoleIdFieldNumber = 4;

		// Token: 0x0400632F RID: 25391
		private static readonly FieldCodec<int> _repeated_trialRoleId_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04006330 RID: 25392
		private readonly RepeatedField<int> trialRoleId_ = new RepeatedField<int>();

		// Token: 0x04006331 RID: 25393
		public const int CurUseRoleInfoFieldNumber = 7;

		// Token: 0x04006332 RID: 25394
		private roleInfo curUseRoleInfo_;
	}
}
