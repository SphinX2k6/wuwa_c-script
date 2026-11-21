using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200110E RID: 4366
	public sealed class RoleVoiceSetting : IMessage<RoleVoiceSetting>, IMessage, IEquatable<RoleVoiceSetting>, IDeepCloneable<RoleVoiceSetting>, IBufferMessage
	{
		// Token: 0x0601755F RID: 95583 RVA: 0x003653DF File Offset: 0x003635DF
		[NullableContext(1)]
		public static RoleVoiceSetting Create()
		{
			return new RoleVoiceSetting();
		}

		// Token: 0x17004E68 RID: 20072
		// (get) Token: 0x06017560 RID: 95584 RVA: 0x003653E6 File Offset: 0x003635E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoleVoiceSetting> Parser
		{
			get
			{
				return RoleVoiceSetting._parser;
			}
		}

		// Token: 0x17004E69 RID: 20073
		// (get) Token: 0x06017561 RID: 95585 RVA: 0x003653ED File Offset: 0x003635ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E6A RID: 20074
		// (get) Token: 0x06017562 RID: 95586 RVA: 0x003653F0 File Offset: 0x003635F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleVoiceSetting.Descriptor;
			}
		}

		// Token: 0x06017563 RID: 95587 RVA: 0x003653F7 File Offset: 0x003635F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleVoiceSetting()
		{
		}

		// Token: 0x06017564 RID: 95588 RVA: 0x003653FF File Offset: 0x003635FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleVoiceSetting(RoleVoiceSetting other) : this()
		{
			this.roleId_ = other.roleId_;
			this.voiceLanguage_ = other.voiceLanguage_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017565 RID: 95589 RVA: 0x00365430 File Offset: 0x00363630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleVoiceSetting Clone()
		{
			return new RoleVoiceSetting(this);
		}

		// Token: 0x17004E6B RID: 20075
		// (get) Token: 0x06017566 RID: 95590 RVA: 0x00365438 File Offset: 0x00363638
		// (set) Token: 0x06017567 RID: 95591 RVA: 0x00365440 File Offset: 0x00363640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x17004E6C RID: 20076
		// (get) Token: 0x06017568 RID: 95592 RVA: 0x00365449 File Offset: 0x00363649
		// (set) Token: 0x06017569 RID: 95593 RVA: 0x00365451 File Offset: 0x00363651
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int VoiceLanguage
		{
			get
			{
				return this.voiceLanguage_;
			}
			set
			{
				this.voiceLanguage_ = value;
			}
		}

		// Token: 0x0601756A RID: 95594 RVA: 0x0036545A File Offset: 0x0036365A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleVoiceSetting);
		}

		// Token: 0x0601756B RID: 95595 RVA: 0x00365468 File Offset: 0x00363668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleVoiceSetting other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.VoiceLanguage == other.VoiceLanguage && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601756C RID: 95596 RVA: 0x003654A8 File Offset: 0x003636A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.VoiceLanguage != 0)
			{
				num ^= this.VoiceLanguage.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601756D RID: 95597 RVA: 0x00365500 File Offset: 0x00363700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601756E RID: 95598 RVA: 0x0036550D File Offset: 0x0036370D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601756F RID: 95599 RVA: 0x00365518 File Offset: 0x00363718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			if (this.VoiceLanguage != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.VoiceLanguage);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017570 RID: 95600 RVA: 0x00365570 File Offset: 0x00363770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.VoiceLanguage != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.VoiceLanguage);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017571 RID: 95601 RVA: 0x003655C8 File Offset: 0x003637C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleVoiceSetting other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.VoiceLanguage != 0)
			{
				this.VoiceLanguage = other.VoiceLanguage;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017572 RID: 95602 RVA: 0x00365618 File Offset: 0x00363818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017573 RID: 95603 RVA: 0x00365624 File Offset: 0x00363824
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
						this.VoiceLanguage = input.ReadInt32();
					}
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008B72 RID: 35698
		private static readonly MessageParser<RoleVoiceSetting> _parser = new MessageParser<RoleVoiceSetting>(() => new RoleVoiceSetting());

		// Token: 0x04008B73 RID: 35699
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008B74 RID: 35700
		public const int RoleIdFieldNumber = 1;

		// Token: 0x04008B75 RID: 35701
		private int roleId_;

		// Token: 0x04008B76 RID: 35702
		public const int VoiceLanguageFieldNumber = 2;

		// Token: 0x04008B77 RID: 35703
		private int voiceLanguage_;
	}
}
