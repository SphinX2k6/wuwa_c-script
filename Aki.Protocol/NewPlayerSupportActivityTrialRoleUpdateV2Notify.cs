using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B0E RID: 2830
	[NetMessage(EMessageId.NewPlayerSupportActivityTrialRoleUpdateV2Notify)]
	public sealed class NewPlayerSupportActivityTrialRoleUpdateV2Notify : IMessage<NewPlayerSupportActivityTrialRoleUpdateV2Notify>, IMessage, IEquatable<NewPlayerSupportActivityTrialRoleUpdateV2Notify>, IDeepCloneable<NewPlayerSupportActivityTrialRoleUpdateV2Notify>, IBufferMessage
	{
		// Token: 0x0600F60D RID: 62989 RVA: 0x0023E663 File Offset: 0x0023C863
		[NullableContext(1)]
		public static NewPlayerSupportActivityTrialRoleUpdateV2Notify Create()
		{
			return new NewPlayerSupportActivityTrialRoleUpdateV2Notify();
		}

		// Token: 0x17003217 RID: 12823
		// (get) Token: 0x0600F60E RID: 62990 RVA: 0x0023E66A File Offset: 0x0023C86A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003218 RID: 12824
		// (get) Token: 0x0600F60F RID: 62991 RVA: 0x0023E66D File Offset: 0x0023C86D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewPlayerSupportActivityTrialRoleUpdateV2Notify.Descriptor;
			}
		}

		// Token: 0x0600F610 RID: 62992 RVA: 0x0023E674 File Offset: 0x0023C874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportActivityTrialRoleUpdateV2Notify()
		{
		}

		// Token: 0x0600F611 RID: 62993 RVA: 0x0023E688 File Offset: 0x0023C888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportActivityTrialRoleUpdateV2Notify(NewPlayerSupportActivityTrialRoleUpdateV2Notify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.trialRoleId_ = other.trialRoleId_.Clone();
			this.curUseRoleInfo_ = ((other.curUseRoleInfo_ != null) ? other.curUseRoleInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F612 RID: 62994 RVA: 0x0023E6E5 File Offset: 0x0023C8E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportActivityTrialRoleUpdateV2Notify Clone()
		{
			return new NewPlayerSupportActivityTrialRoleUpdateV2Notify(this);
		}

		// Token: 0x17003219 RID: 12825
		// (get) Token: 0x0600F613 RID: 62995 RVA: 0x0023E6ED File Offset: 0x0023C8ED
		// (set) Token: 0x0600F614 RID: 62996 RVA: 0x0023E6F5 File Offset: 0x0023C8F5
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

		// Token: 0x1700321A RID: 12826
		// (get) Token: 0x0600F615 RID: 62997 RVA: 0x0023E6FE File Offset: 0x0023C8FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TrialRoleId
		{
			get
			{
				return this.trialRoleId_;
			}
		}

		// Token: 0x1700321B RID: 12827
		// (get) Token: 0x0600F616 RID: 62998 RVA: 0x0023E706 File Offset: 0x0023C906
		// (set) Token: 0x0600F617 RID: 62999 RVA: 0x0023E70E File Offset: 0x0023C90E
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

		// Token: 0x0600F618 RID: 63000 RVA: 0x0023E717 File Offset: 0x0023C917
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewPlayerSupportActivityTrialRoleUpdateV2Notify);
		}

		// Token: 0x0600F619 RID: 63001 RVA: 0x0023E728 File Offset: 0x0023C928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewPlayerSupportActivityTrialRoleUpdateV2Notify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.trialRoleId_.Equals(other.trialRoleId_) && object.Equals(this.CurUseRoleInfo, other.CurUseRoleInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F61A RID: 63002 RVA: 0x0023E78C File Offset: 0x0023C98C
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

		// Token: 0x0600F61B RID: 63003 RVA: 0x0023E7EF File Offset: 0x0023C9EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F61C RID: 63004 RVA: 0x0023E7FC File Offset: 0x0023C9FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F61D RID: 63005 RVA: 0x0023E808 File Offset: 0x0023CA08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.curUseRoleInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.CurUseRoleInfo);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.ActivityId);
			}
			this.trialRoleId_.WriteTo(ref output, NewPlayerSupportActivityTrialRoleUpdateV2Notify._repeated_trialRoleId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F61E RID: 63006 RVA: 0x0023E874 File Offset: 0x0023CA74
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

		// Token: 0x0600F61F RID: 63007 RVA: 0x0023E8E0 File Offset: 0x0023CAE0
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

		// Token: 0x0600F620 RID: 63008 RVA: 0x0023E959 File Offset: 0x0023CB59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F621 RID: 63009 RVA: 0x0023E964 File Offset: 0x0023CB64
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
				if (num <= 72U)
				{
					if (num == 18U)
					{
						if (this.curUseRoleInfo_ == null)
						{
							this.CurUseRoleInfo = new roleInfo();
						}
						input.ReadMessage(this.CurUseRoleInfo);
						continue;
					}
					if (num == 72U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
				}
				else if (num == 120U || num == 122U)
				{
					this.trialRoleId_.AddEntriesFrom(ref input, NewPlayerSupportActivityTrialRoleUpdateV2Notify._repeated_trialRoleId_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006334 RID: 25396
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006335 RID: 25397
		public const int ActivityIdFieldNumber = 9;

		// Token: 0x04006336 RID: 25398
		private int activityId_;

		// Token: 0x04006337 RID: 25399
		public const int TrialRoleIdFieldNumber = 15;

		// Token: 0x04006338 RID: 25400
		private static readonly FieldCodec<int> _repeated_trialRoleId_codec = FieldCodec.ForInt32(122U);

		// Token: 0x04006339 RID: 25401
		private readonly RepeatedField<int> trialRoleId_ = new RepeatedField<int>();

		// Token: 0x0400633A RID: 25402
		public const int CurUseRoleInfoFieldNumber = 2;

		// Token: 0x0400633B RID: 25403
		private roleInfo curUseRoleInfo_;
	}
}
