using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B1E RID: 2846
	[NetMessage(EMessageId.NewPlayerSupportActivityTrialRoleUpdateNotify)]
	public sealed class NewPlayerSupportActivityTrialRoleUpdateNotify : IMessage<NewPlayerSupportActivityTrialRoleUpdateNotify>, IMessage, IEquatable<NewPlayerSupportActivityTrialRoleUpdateNotify>, IDeepCloneable<NewPlayerSupportActivityTrialRoleUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600F713 RID: 63251 RVA: 0x00240589 File Offset: 0x0023E789
		[NullableContext(1)]
		public static NewPlayerSupportActivityTrialRoleUpdateNotify Create()
		{
			return new NewPlayerSupportActivityTrialRoleUpdateNotify();
		}

		// Token: 0x17003251 RID: 12881
		// (get) Token: 0x0600F714 RID: 63252 RVA: 0x00240590 File Offset: 0x0023E790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003252 RID: 12882
		// (get) Token: 0x0600F715 RID: 63253 RVA: 0x00240593 File Offset: 0x0023E793
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewPlayerSupportActivityTrialRoleUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600F716 RID: 63254 RVA: 0x0024059A File Offset: 0x0023E79A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportActivityTrialRoleUpdateNotify()
		{
		}

		// Token: 0x0600F717 RID: 63255 RVA: 0x002405B0 File Offset: 0x0023E7B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportActivityTrialRoleUpdateNotify(NewPlayerSupportActivityTrialRoleUpdateNotify other) : this()
		{
			this.trialRoleId_ = other.trialRoleId_.Clone();
			this.curUseRoleInfo_ = ((other.curUseRoleInfo_ != null) ? other.curUseRoleInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F718 RID: 63256 RVA: 0x00240601 File Offset: 0x0023E801
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportActivityTrialRoleUpdateNotify Clone()
		{
			return new NewPlayerSupportActivityTrialRoleUpdateNotify(this);
		}

		// Token: 0x17003253 RID: 12883
		// (get) Token: 0x0600F719 RID: 63257 RVA: 0x00240609 File Offset: 0x0023E809
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TrialRoleId
		{
			get
			{
				return this.trialRoleId_;
			}
		}

		// Token: 0x17003254 RID: 12884
		// (get) Token: 0x0600F71A RID: 63258 RVA: 0x00240611 File Offset: 0x0023E811
		// (set) Token: 0x0600F71B RID: 63259 RVA: 0x00240619 File Offset: 0x0023E819
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

		// Token: 0x0600F71C RID: 63260 RVA: 0x00240622 File Offset: 0x0023E822
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewPlayerSupportActivityTrialRoleUpdateNotify);
		}

		// Token: 0x0600F71D RID: 63261 RVA: 0x00240630 File Offset: 0x0023E830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewPlayerSupportActivityTrialRoleUpdateNotify other)
		{
			return other != null && (other == this || (this.trialRoleId_.Equals(other.trialRoleId_) && object.Equals(this.CurUseRoleInfo, other.CurUseRoleInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F71E RID: 63262 RVA: 0x00240684 File Offset: 0x0023E884
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

		// Token: 0x0600F71F RID: 63263 RVA: 0x002406CE File Offset: 0x0023E8CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F720 RID: 63264 RVA: 0x002406DB File Offset: 0x0023E8DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F721 RID: 63265 RVA: 0x002406E4 File Offset: 0x0023E8E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.trialRoleId_.WriteTo(ref output, NewPlayerSupportActivityTrialRoleUpdateNotify._repeated_trialRoleId_codec);
			if (this.curUseRoleInfo_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.CurUseRoleInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F722 RID: 63266 RVA: 0x00240734 File Offset: 0x0023E934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.trialRoleId_.CalculateSize(NewPlayerSupportActivityTrialRoleUpdateNotify._repeated_trialRoleId_codec);
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

		// Token: 0x0600F723 RID: 63267 RVA: 0x00240788 File Offset: 0x0023E988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewPlayerSupportActivityTrialRoleUpdateNotify other)
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

		// Token: 0x0600F724 RID: 63268 RVA: 0x002407ED File Offset: 0x0023E9ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F725 RID: 63269 RVA: 0x002407F8 File Offset: 0x0023E9F8
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
				if (num != 16U && num != 18U)
				{
					if (num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.trialRoleId_.AddEntriesFrom(ref input, NewPlayerSupportActivityTrialRoleUpdateNotify._repeated_trialRoleId_codec);
				}
			}
		}

		// Token: 0x04006325 RID: 25381
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006326 RID: 25382
		public const int TrialRoleIdFieldNumber = 2;

		// Token: 0x04006327 RID: 25383
		private static readonly FieldCodec<int> _repeated_trialRoleId_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04006328 RID: 25384
		private readonly RepeatedField<int> trialRoleId_ = new RepeatedField<int>();

		// Token: 0x04006329 RID: 25385
		public const int CurUseRoleInfoFieldNumber = 12;

		// Token: 0x0400632A RID: 25386
		private roleInfo curUseRoleInfo_;
	}
}
