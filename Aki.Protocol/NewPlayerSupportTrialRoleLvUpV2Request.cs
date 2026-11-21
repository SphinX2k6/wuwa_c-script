using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B18 RID: 2840
	[NetMessage(EMessageId.NewPlayerSupportTrialRoleLvUpV2Request)]
	public sealed class NewPlayerSupportTrialRoleLvUpV2Request : IMessage<NewPlayerSupportTrialRoleLvUpV2Request>, IMessage, IEquatable<NewPlayerSupportTrialRoleLvUpV2Request>, IDeepCloneable<NewPlayerSupportTrialRoleLvUpV2Request>, IBufferMessage
	{
		// Token: 0x0600F6EA RID: 63210 RVA: 0x002408EE File Offset: 0x0023EAEE
		[NullableContext(1)]
		public static NewPlayerSupportTrialRoleLvUpV2Request Create()
		{
			return new NewPlayerSupportTrialRoleLvUpV2Request();
		}

		// Token: 0x1700324A RID: 12874
		// (get) Token: 0x0600F6EB RID: 63211 RVA: 0x002408F5 File Offset: 0x0023EAF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700324B RID: 12875
		// (get) Token: 0x0600F6EC RID: 63212 RVA: 0x002408F8 File Offset: 0x0023EAF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewPlayerSupportTrialRoleLvUpV2Request.Descriptor;
			}
		}

		// Token: 0x0600F6ED RID: 63213 RVA: 0x002408FF File Offset: 0x0023EAFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportTrialRoleLvUpV2Request()
		{
		}

		// Token: 0x0600F6EE RID: 63214 RVA: 0x00240907 File Offset: 0x0023EB07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportTrialRoleLvUpV2Request(NewPlayerSupportTrialRoleLvUpV2Request other) : this()
		{
			this.trialRoleId_ = other.trialRoleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F6EF RID: 63215 RVA: 0x0024092C File Offset: 0x0023EB2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportTrialRoleLvUpV2Request Clone()
		{
			return new NewPlayerSupportTrialRoleLvUpV2Request(this);
		}

		// Token: 0x1700324C RID: 12876
		// (get) Token: 0x0600F6F0 RID: 63216 RVA: 0x00240934 File Offset: 0x0023EB34
		// (set) Token: 0x0600F6F1 RID: 63217 RVA: 0x0024093C File Offset: 0x0023EB3C
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

		// Token: 0x0600F6F2 RID: 63218 RVA: 0x00240945 File Offset: 0x0023EB45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewPlayerSupportTrialRoleLvUpV2Request);
		}

		// Token: 0x0600F6F3 RID: 63219 RVA: 0x00240953 File Offset: 0x0023EB53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewPlayerSupportTrialRoleLvUpV2Request other)
		{
			return other != null && (other == this || (this.TrialRoleId == other.TrialRoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F6F4 RID: 63220 RVA: 0x00240984 File Offset: 0x0023EB84
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

		// Token: 0x0600F6F5 RID: 63221 RVA: 0x002409C3 File Offset: 0x0023EBC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F6F6 RID: 63222 RVA: 0x002409D0 File Offset: 0x0023EBD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F6F7 RID: 63223 RVA: 0x002409D9 File Offset: 0x0023EBD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TrialRoleId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.TrialRoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F6F8 RID: 63224 RVA: 0x00240A0C File Offset: 0x0023EC0C
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

		// Token: 0x0600F6F9 RID: 63225 RVA: 0x00240A4A File Offset: 0x0023EC4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewPlayerSupportTrialRoleLvUpV2Request other)
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

		// Token: 0x0600F6FA RID: 63226 RVA: 0x00240A7B File Offset: 0x0023EC7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F6FB RID: 63227 RVA: 0x00240A84 File Offset: 0x0023EC84
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TrialRoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006381 RID: 25473
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006382 RID: 25474
		public const int TrialRoleIdFieldNumber = 9;

		// Token: 0x04006383 RID: 25475
		private int trialRoleId_;
	}
}
