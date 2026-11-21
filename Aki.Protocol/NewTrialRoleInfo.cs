using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B46 RID: 2886
	public sealed class NewTrialRoleInfo : IMessage<NewTrialRoleInfo>, IMessage, IEquatable<NewTrialRoleInfo>, IDeepCloneable<NewTrialRoleInfo>, IBufferMessage
	{
		// Token: 0x0600FA86 RID: 64134 RVA: 0x002486B7 File Offset: 0x002468B7
		[NullableContext(1)]
		public static NewTrialRoleInfo Create()
		{
			return new NewTrialRoleInfo();
		}

		// Token: 0x1700330D RID: 13069
		// (get) Token: 0x0600FA87 RID: 64135 RVA: 0x002486BE File Offset: 0x002468BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NewTrialRoleInfo> Parser
		{
			get
			{
				return NewTrialRoleInfo._parser;
			}
		}

		// Token: 0x1700330E RID: 13070
		// (get) Token: 0x0600FA88 RID: 64136 RVA: 0x002486C5 File Offset: 0x002468C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700330F RID: 13071
		// (get) Token: 0x0600FA89 RID: 64137 RVA: 0x002486C8 File Offset: 0x002468C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTrialRoleInfo.Descriptor;
			}
		}

		// Token: 0x0600FA8A RID: 64138 RVA: 0x002486CF File Offset: 0x002468CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTrialRoleInfo()
		{
		}

		// Token: 0x0600FA8B RID: 64139 RVA: 0x002486D7 File Offset: 0x002468D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTrialRoleInfo(NewTrialRoleInfo other) : this()
		{
			this.trialRoleId_ = other.trialRoleId_;
			this.worldLv_ = other.worldLv_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FA8C RID: 64140 RVA: 0x00248708 File Offset: 0x00246908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTrialRoleInfo Clone()
		{
			return new NewTrialRoleInfo(this);
		}

		// Token: 0x17003310 RID: 13072
		// (get) Token: 0x0600FA8D RID: 64141 RVA: 0x00248710 File Offset: 0x00246910
		// (set) Token: 0x0600FA8E RID: 64142 RVA: 0x00248718 File Offset: 0x00246918
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

		// Token: 0x17003311 RID: 13073
		// (get) Token: 0x0600FA8F RID: 64143 RVA: 0x00248721 File Offset: 0x00246921
		// (set) Token: 0x0600FA90 RID: 64144 RVA: 0x00248729 File Offset: 0x00246929
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WorldLv
		{
			get
			{
				return this.worldLv_;
			}
			set
			{
				this.worldLv_ = value;
			}
		}

		// Token: 0x0600FA91 RID: 64145 RVA: 0x00248732 File Offset: 0x00246932
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTrialRoleInfo);
		}

		// Token: 0x0600FA92 RID: 64146 RVA: 0x00248740 File Offset: 0x00246940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTrialRoleInfo other)
		{
			return other != null && (other == this || (this.TrialRoleId == other.TrialRoleId && this.WorldLv == other.WorldLv && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FA93 RID: 64147 RVA: 0x00248780 File Offset: 0x00246980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TrialRoleId != 0)
			{
				num ^= this.TrialRoleId.GetHashCode();
			}
			if (this.WorldLv != 0)
			{
				num ^= this.WorldLv.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FA94 RID: 64148 RVA: 0x002487D8 File Offset: 0x002469D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FA95 RID: 64149 RVA: 0x002487E5 File Offset: 0x002469E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FA96 RID: 64150 RVA: 0x002487F0 File Offset: 0x002469F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TrialRoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TrialRoleId);
			}
			if (this.WorldLv != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.WorldLv);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FA97 RID: 64151 RVA: 0x00248848 File Offset: 0x00246A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TrialRoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TrialRoleId);
			}
			if (this.WorldLv != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WorldLv);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FA98 RID: 64152 RVA: 0x002488A0 File Offset: 0x00246AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTrialRoleInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TrialRoleId != 0)
			{
				this.TrialRoleId = other.TrialRoleId;
			}
			if (other.WorldLv != 0)
			{
				this.WorldLv = other.WorldLv;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FA99 RID: 64153 RVA: 0x002488F0 File Offset: 0x00246AF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FA9A RID: 64154 RVA: 0x002488FC File Offset: 0x00246AFC
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.WorldLv = input.ReadInt32();
					}
				}
				else
				{
					this.TrialRoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006498 RID: 25752
		private static readonly MessageParser<NewTrialRoleInfo> _parser = new MessageParser<NewTrialRoleInfo>(() => new NewTrialRoleInfo());

		// Token: 0x04006499 RID: 25753
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400649A RID: 25754
		public const int TrialRoleIdFieldNumber = 1;

		// Token: 0x0400649B RID: 25755
		private int trialRoleId_;

		// Token: 0x0400649C RID: 25756
		public const int WorldLvFieldNumber = 2;

		// Token: 0x0400649D RID: 25757
		private int worldLv_;
	}
}
