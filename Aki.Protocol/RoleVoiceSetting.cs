using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010D4 RID: 4308
	public sealed class RoleVoiceSetting : IMessage<RoleVoiceSetting>, IMessage, IEquatable<RoleVoiceSetting>, IDeepCloneable<RoleVoiceSetting>, IBufferMessage
	{
		// Token: 0x06016FBE RID: 94142 RVA: 0x00356087 File Offset: 0x00354287
		[NullableContext(1)]
		public static RoleVoiceSetting Create()
		{
			return new RoleVoiceSetting();
		}

		// Token: 0x17004CFC RID: 19708
		// (get) Token: 0x06016FBF RID: 94143 RVA: 0x0035608E File Offset: 0x0035428E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoleVoiceSetting> Parser
		{
			get
			{
				return RoleVoiceSetting._parser;
			}
		}

		// Token: 0x17004CFD RID: 19709
		// (get) Token: 0x06016FC0 RID: 94144 RVA: 0x00356095 File Offset: 0x00354295
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004CFE RID: 19710
		// (get) Token: 0x06016FC1 RID: 94145 RVA: 0x00356098 File Offset: 0x00354298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleVoiceSetting.Descriptor;
			}
		}

		// Token: 0x06016FC2 RID: 94146 RVA: 0x0035609F File Offset: 0x0035429F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleVoiceSetting()
		{
		}

		// Token: 0x06016FC3 RID: 94147 RVA: 0x003560A7 File Offset: 0x003542A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleVoiceSetting(RoleVoiceSetting other) : this()
		{
			this.roleId_ = other.roleId_;
			this.voiceLanguage_ = other.voiceLanguage_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016FC4 RID: 94148 RVA: 0x003560D8 File Offset: 0x003542D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleVoiceSetting Clone()
		{
			return new RoleVoiceSetting(this);
		}

		// Token: 0x17004CFF RID: 19711
		// (get) Token: 0x06016FC5 RID: 94149 RVA: 0x003560E0 File Offset: 0x003542E0
		// (set) Token: 0x06016FC6 RID: 94150 RVA: 0x003560E8 File Offset: 0x003542E8
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

		// Token: 0x17004D00 RID: 19712
		// (get) Token: 0x06016FC7 RID: 94151 RVA: 0x003560F1 File Offset: 0x003542F1
		// (set) Token: 0x06016FC8 RID: 94152 RVA: 0x003560F9 File Offset: 0x003542F9
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

		// Token: 0x06016FC9 RID: 94153 RVA: 0x00356102 File Offset: 0x00354302
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleVoiceSetting);
		}

		// Token: 0x06016FCA RID: 94154 RVA: 0x00356110 File Offset: 0x00354310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleVoiceSetting other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.VoiceLanguage == other.VoiceLanguage && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016FCB RID: 94155 RVA: 0x00356150 File Offset: 0x00354350
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

		// Token: 0x06016FCC RID: 94156 RVA: 0x003561A8 File Offset: 0x003543A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016FCD RID: 94157 RVA: 0x003561B5 File Offset: 0x003543B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016FCE RID: 94158 RVA: 0x003561C0 File Offset: 0x003543C0
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

		// Token: 0x06016FCF RID: 94159 RVA: 0x00356218 File Offset: 0x00354418
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

		// Token: 0x06016FD0 RID: 94160 RVA: 0x00356270 File Offset: 0x00354470
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

		// Token: 0x06016FD1 RID: 94161 RVA: 0x003562C0 File Offset: 0x003544C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016FD2 RID: 94162 RVA: 0x003562CC File Offset: 0x003544CC
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

		// Token: 0x040088DF RID: 35039
		private static readonly MessageParser<RoleVoiceSetting> _parser = new MessageParser<RoleVoiceSetting>(() => new RoleVoiceSetting());

		// Token: 0x040088E0 RID: 35040
		private UnknownFieldSet _unknownFields;

		// Token: 0x040088E1 RID: 35041
		public const int RoleIdFieldNumber = 1;

		// Token: 0x040088E2 RID: 35042
		private int roleId_;

		// Token: 0x040088E3 RID: 35043
		public const int VoiceLanguageFieldNumber = 2;

		// Token: 0x040088E4 RID: 35044
		private int voiceLanguage_;
	}
}
