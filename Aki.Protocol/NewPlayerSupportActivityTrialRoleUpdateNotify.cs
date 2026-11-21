using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B0D RID: 2829
	[NetMessage(EMessageId.NewPlayerSupportActivityTrialRoleUpdateNotify)]
	public sealed class NewPlayerSupportActivityTrialRoleUpdateNotify : IMessage<NewPlayerSupportActivityTrialRoleUpdateNotify>, IMessage, IEquatable<NewPlayerSupportActivityTrialRoleUpdateNotify>, IDeepCloneable<NewPlayerSupportActivityTrialRoleUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600F5F9 RID: 62969 RVA: 0x0023E371 File Offset: 0x0023C571
		[NullableContext(1)]
		public static NewPlayerSupportActivityTrialRoleUpdateNotify Create()
		{
			return new NewPlayerSupportActivityTrialRoleUpdateNotify();
		}

		// Token: 0x17003213 RID: 12819
		// (get) Token: 0x0600F5FA RID: 62970 RVA: 0x0023E378 File Offset: 0x0023C578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003214 RID: 12820
		// (get) Token: 0x0600F5FB RID: 62971 RVA: 0x0023E37B File Offset: 0x0023C57B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewPlayerSupportActivityTrialRoleUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600F5FC RID: 62972 RVA: 0x0023E382 File Offset: 0x0023C582
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportActivityTrialRoleUpdateNotify()
		{
		}

		// Token: 0x0600F5FD RID: 62973 RVA: 0x0023E398 File Offset: 0x0023C598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportActivityTrialRoleUpdateNotify(NewPlayerSupportActivityTrialRoleUpdateNotify other) : this()
		{
			this.trialRoleId_ = other.trialRoleId_.Clone();
			this.curUseRoleInfo_ = ((other.curUseRoleInfo_ != null) ? other.curUseRoleInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F5FE RID: 62974 RVA: 0x0023E3E9 File Offset: 0x0023C5E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportActivityTrialRoleUpdateNotify Clone()
		{
			return new NewPlayerSupportActivityTrialRoleUpdateNotify(this);
		}

		// Token: 0x17003215 RID: 12821
		// (get) Token: 0x0600F5FF RID: 62975 RVA: 0x0023E3F1 File Offset: 0x0023C5F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TrialRoleId
		{
			get
			{
				return this.trialRoleId_;
			}
		}

		// Token: 0x17003216 RID: 12822
		// (get) Token: 0x0600F600 RID: 62976 RVA: 0x0023E3F9 File Offset: 0x0023C5F9
		// (set) Token: 0x0600F601 RID: 62977 RVA: 0x0023E401 File Offset: 0x0023C601
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

		// Token: 0x0600F602 RID: 62978 RVA: 0x0023E40A File Offset: 0x0023C60A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewPlayerSupportActivityTrialRoleUpdateNotify);
		}

		// Token: 0x0600F603 RID: 62979 RVA: 0x0023E418 File Offset: 0x0023C618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewPlayerSupportActivityTrialRoleUpdateNotify other)
		{
			return other != null && (other == this || (this.trialRoleId_.Equals(other.trialRoleId_) && object.Equals(this.CurUseRoleInfo, other.CurUseRoleInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F604 RID: 62980 RVA: 0x0023E46C File Offset: 0x0023C66C
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

		// Token: 0x0600F605 RID: 62981 RVA: 0x0023E4B6 File Offset: 0x0023C6B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F606 RID: 62982 RVA: 0x0023E4C3 File Offset: 0x0023C6C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F607 RID: 62983 RVA: 0x0023E4CC File Offset: 0x0023C6CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.trialRoleId_.WriteTo(ref output, NewPlayerSupportActivityTrialRoleUpdateNotify._repeated_trialRoleId_codec);
			if (this.curUseRoleInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.CurUseRoleInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F608 RID: 62984 RVA: 0x0023E51C File Offset: 0x0023C71C
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

		// Token: 0x0600F609 RID: 62985 RVA: 0x0023E570 File Offset: 0x0023C770
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

		// Token: 0x0600F60A RID: 62986 RVA: 0x0023E5D5 File Offset: 0x0023C7D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F60B RID: 62987 RVA: 0x0023E5E0 File Offset: 0x0023C7E0
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
				if (num != 64U && num != 66U)
				{
					if (num != 82U)
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

		// Token: 0x0400632E RID: 25390
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400632F RID: 25391
		public const int TrialRoleIdFieldNumber = 8;

		// Token: 0x04006330 RID: 25392
		private static readonly FieldCodec<int> _repeated_trialRoleId_codec = FieldCodec.ForInt32(66U);

		// Token: 0x04006331 RID: 25393
		private readonly RepeatedField<int> trialRoleId_ = new RepeatedField<int>();

		// Token: 0x04006332 RID: 25394
		public const int CurUseRoleInfoFieldNumber = 10;

		// Token: 0x04006333 RID: 25395
		private roleInfo curUseRoleInfo_;
	}
}
