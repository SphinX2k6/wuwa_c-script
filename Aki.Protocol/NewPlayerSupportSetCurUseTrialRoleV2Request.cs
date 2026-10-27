using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B25 RID: 2853
	[NetMessage(EMessageId.NewPlayerSupportSetCurUseTrialRoleV2Request)]
	public sealed class NewPlayerSupportSetCurUseTrialRoleV2Request : IMessage<NewPlayerSupportSetCurUseTrialRoleV2Request>, IMessage, IEquatable<NewPlayerSupportSetCurUseTrialRoleV2Request>, IDeepCloneable<NewPlayerSupportSetCurUseTrialRoleV2Request>, IBufferMessage
	{
		// Token: 0x0600F7B0 RID: 63408 RVA: 0x00241EE9 File Offset: 0x002400E9
		[NullableContext(1)]
		public static NewPlayerSupportSetCurUseTrialRoleV2Request Create()
		{
			return new NewPlayerSupportSetCurUseTrialRoleV2Request();
		}

		// Token: 0x17003276 RID: 12918
		// (get) Token: 0x0600F7B1 RID: 63409 RVA: 0x00241EF0 File Offset: 0x002400F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003277 RID: 12919
		// (get) Token: 0x0600F7B2 RID: 63410 RVA: 0x00241EF3 File Offset: 0x002400F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewPlayerSupportSetCurUseTrialRoleV2Request.Descriptor;
			}
		}

		// Token: 0x0600F7B3 RID: 63411 RVA: 0x00241EFA File Offset: 0x002400FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportSetCurUseTrialRoleV2Request()
		{
		}

		// Token: 0x0600F7B4 RID: 63412 RVA: 0x00241F02 File Offset: 0x00240102
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportSetCurUseTrialRoleV2Request(NewPlayerSupportSetCurUseTrialRoleV2Request other) : this()
		{
			this.trialRoleId_ = other.trialRoleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F7B5 RID: 63413 RVA: 0x00241F27 File Offset: 0x00240127
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportSetCurUseTrialRoleV2Request Clone()
		{
			return new NewPlayerSupportSetCurUseTrialRoleV2Request(this);
		}

		// Token: 0x17003278 RID: 12920
		// (get) Token: 0x0600F7B6 RID: 63414 RVA: 0x00241F2F File Offset: 0x0024012F
		// (set) Token: 0x0600F7B7 RID: 63415 RVA: 0x00241F37 File Offset: 0x00240137
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TrialRoleId
		{
			get
			{
				return this.trialRoleId_;
			}
			set
			{
				this.trialRoleId_ = value;
			}
		}

		// Token: 0x0600F7B8 RID: 63416 RVA: 0x00241F40 File Offset: 0x00240140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewPlayerSupportSetCurUseTrialRoleV2Request);
		}

		// Token: 0x0600F7B9 RID: 63417 RVA: 0x00241F4E File Offset: 0x0024014E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewPlayerSupportSetCurUseTrialRoleV2Request other)
		{
			return other != null && (other == this || (this.TrialRoleId == other.TrialRoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F7BA RID: 63418 RVA: 0x00241F7C File Offset: 0x0024017C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TrialRoleId != 0)
			{
				num ^= this.TrialRoleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F7BB RID: 63419 RVA: 0x00241FBB File Offset: 0x002401BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F7BC RID: 63420 RVA: 0x00241FC8 File Offset: 0x002401C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F7BD RID: 63421 RVA: 0x00241FD1 File Offset: 0x002401D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TrialRoleId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.TrialRoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F7BE RID: 63422 RVA: 0x00242004 File Offset: 0x00240204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TrialRoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TrialRoleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F7BF RID: 63423 RVA: 0x00242042 File Offset: 0x00240242
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewPlayerSupportSetCurUseTrialRoleV2Request other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TrialRoleId != 0)
			{
				this.TrialRoleId = other.TrialRoleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F7C0 RID: 63424 RVA: 0x00242073 File Offset: 0x00240273
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F7C1 RID: 63425 RVA: 0x0024207C File Offset: 0x0024027C
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TrialRoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006360 RID: 25440
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006361 RID: 25441
		public const int TrialRoleIdFieldNumber = 13;

		// Token: 0x04006362 RID: 25442
		private int trialRoleId_;
	}
}
