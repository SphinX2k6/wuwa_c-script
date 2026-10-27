using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ED8 RID: 3800
	[NetMessage(EMessageId.RegressActivityTrialRoleUpdateNotify)]
	public sealed class RegressActivityTrialRoleUpdateNotify : IMessage<RegressActivityTrialRoleUpdateNotify>, IMessage, IEquatable<RegressActivityTrialRoleUpdateNotify>, IDeepCloneable<RegressActivityTrialRoleUpdateNotify>, IBufferMessage
	{
		// Token: 0x060145E3 RID: 83427 RVA: 0x002F5971 File Offset: 0x002F3B71
		[NullableContext(1)]
		public static RegressActivityTrialRoleUpdateNotify Create()
		{
			return new RegressActivityTrialRoleUpdateNotify();
		}

		// Token: 0x170043B5 RID: 17333
		// (get) Token: 0x060145E4 RID: 83428 RVA: 0x002F5978 File Offset: 0x002F3B78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170043B6 RID: 17334
		// (get) Token: 0x060145E5 RID: 83429 RVA: 0x002F597B File Offset: 0x002F3B7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RegressActivityTrialRoleUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060145E6 RID: 83430 RVA: 0x002F5982 File Offset: 0x002F3B82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressActivityTrialRoleUpdateNotify()
		{
		}

		// Token: 0x060145E7 RID: 83431 RVA: 0x002F5998 File Offset: 0x002F3B98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressActivityTrialRoleUpdateNotify(RegressActivityTrialRoleUpdateNotify other) : this()
		{
			this.trialRoleId_ = other.trialRoleId_.Clone();
			this.curUseRoleInfo_ = ((other.curUseRoleInfo_ != null) ? other.curUseRoleInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060145E8 RID: 83432 RVA: 0x002F59E9 File Offset: 0x002F3BE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressActivityTrialRoleUpdateNotify Clone()
		{
			return new RegressActivityTrialRoleUpdateNotify(this);
		}

		// Token: 0x170043B7 RID: 17335
		// (get) Token: 0x060145E9 RID: 83433 RVA: 0x002F59F1 File Offset: 0x002F3BF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TrialRoleId
		{
			get
			{
				return this.trialRoleId_;
			}
		}

		// Token: 0x170043B8 RID: 17336
		// (get) Token: 0x060145EA RID: 83434 RVA: 0x002F59F9 File Offset: 0x002F3BF9
		// (set) Token: 0x060145EB RID: 83435 RVA: 0x002F5A01 File Offset: 0x002F3C01
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

		// Token: 0x060145EC RID: 83436 RVA: 0x002F5A0A File Offset: 0x002F3C0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RegressActivityTrialRoleUpdateNotify);
		}

		// Token: 0x060145ED RID: 83437 RVA: 0x002F5A18 File Offset: 0x002F3C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RegressActivityTrialRoleUpdateNotify other)
		{
			return other != null && (other == this || (this.trialRoleId_.Equals(other.trialRoleId_) && object.Equals(this.CurUseRoleInfo, other.CurUseRoleInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060145EE RID: 83438 RVA: 0x002F5A6C File Offset: 0x002F3C6C
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

		// Token: 0x060145EF RID: 83439 RVA: 0x002F5AB6 File Offset: 0x002F3CB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060145F0 RID: 83440 RVA: 0x002F5AC3 File Offset: 0x002F3CC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060145F1 RID: 83441 RVA: 0x002F5ACC File Offset: 0x002F3CCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.curUseRoleInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.CurUseRoleInfo);
			}
			this.trialRoleId_.WriteTo(ref output, RegressActivityTrialRoleUpdateNotify._repeated_trialRoleId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060145F2 RID: 83442 RVA: 0x002F5B1C File Offset: 0x002F3D1C
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

		// Token: 0x060145F3 RID: 83443 RVA: 0x002F5B70 File Offset: 0x002F3D70
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

		// Token: 0x060145F4 RID: 83444 RVA: 0x002F5BD5 File Offset: 0x002F3DD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060145F5 RID: 83445 RVA: 0x002F5BE0 File Offset: 0x002F3DE0
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
				if (num != 10U)
				{
					if (num != 64U && num != 66U)
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

		// Token: 0x04007BA0 RID: 31648
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007BA1 RID: 31649
		public const int TrialRoleIdFieldNumber = 8;

		// Token: 0x04007BA2 RID: 31650
		private static readonly FieldCodec<int> _repeated_trialRoleId_codec = FieldCodec.ForInt32(66U);

		// Token: 0x04007BA3 RID: 31651
		private readonly RepeatedField<int> trialRoleId_ = new RepeatedField<int>();

		// Token: 0x04007BA4 RID: 31652
		public const int CurUseRoleInfoFieldNumber = 1;

		// Token: 0x04007BA5 RID: 31653
		private roleInfo curUseRoleInfo_;
	}
}
