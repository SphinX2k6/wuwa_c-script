using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010D3 RID: 4307
	public sealed class RoleVoice : IMessage<RoleVoice>, IMessage, IEquatable<RoleVoice>, IDeepCloneable<RoleVoice>, IBufferMessage
	{
		// Token: 0x06016FA8 RID: 94120 RVA: 0x00355DD1 File Offset: 0x00353FD1
		[NullableContext(1)]
		public static RoleVoice Create()
		{
			return new RoleVoice();
		}

		// Token: 0x17004CF7 RID: 19703
		// (get) Token: 0x06016FA9 RID: 94121 RVA: 0x00355DD8 File Offset: 0x00353FD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoleVoice> Parser
		{
			get
			{
				return RoleVoice._parser;
			}
		}

		// Token: 0x17004CF8 RID: 19704
		// (get) Token: 0x06016FAA RID: 94122 RVA: 0x00355DDF File Offset: 0x00353FDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004CF9 RID: 19705
		// (get) Token: 0x06016FAB RID: 94123 RVA: 0x00355DE2 File Offset: 0x00353FE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleVoice.Descriptor;
			}
		}

		// Token: 0x06016FAC RID: 94124 RVA: 0x00355DE9 File Offset: 0x00353FE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleVoice()
		{
		}

		// Token: 0x06016FAD RID: 94125 RVA: 0x00355DF1 File Offset: 0x00353FF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleVoice(RoleVoice other) : this()
		{
			this.roleId_ = other.roleId_;
			this.voiceId_ = other.voiceId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016FAE RID: 94126 RVA: 0x00355E22 File Offset: 0x00354022
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleVoice Clone()
		{
			return new RoleVoice(this);
		}

		// Token: 0x17004CFA RID: 19706
		// (get) Token: 0x06016FAF RID: 94127 RVA: 0x00355E2A File Offset: 0x0035402A
		// (set) Token: 0x06016FB0 RID: 94128 RVA: 0x00355E32 File Offset: 0x00354032
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

		// Token: 0x17004CFB RID: 19707
		// (get) Token: 0x06016FB1 RID: 94129 RVA: 0x00355E3B File Offset: 0x0035403B
		// (set) Token: 0x06016FB2 RID: 94130 RVA: 0x00355E43 File Offset: 0x00354043
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int VoiceId
		{
			get
			{
				return this.voiceId_;
			}
			set
			{
				this.voiceId_ = value;
			}
		}

		// Token: 0x06016FB3 RID: 94131 RVA: 0x00355E4C File Offset: 0x0035404C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleVoice);
		}

		// Token: 0x06016FB4 RID: 94132 RVA: 0x00355E5A File Offset: 0x0035405A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleVoice other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.VoiceId == other.VoiceId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016FB5 RID: 94133 RVA: 0x00355E98 File Offset: 0x00354098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.VoiceId != 0)
			{
				num ^= this.VoiceId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016FB6 RID: 94134 RVA: 0x00355EF0 File Offset: 0x003540F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016FB7 RID: 94135 RVA: 0x00355EFD File Offset: 0x003540FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016FB8 RID: 94136 RVA: 0x00355F08 File Offset: 0x00354108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			if (this.VoiceId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.VoiceId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016FB9 RID: 94137 RVA: 0x00355F60 File Offset: 0x00354160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.VoiceId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.VoiceId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016FBA RID: 94138 RVA: 0x00355FB8 File Offset: 0x003541B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleVoice other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.VoiceId != 0)
			{
				this.VoiceId = other.VoiceId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016FBB RID: 94139 RVA: 0x00356008 File Offset: 0x00354208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016FBC RID: 94140 RVA: 0x00356014 File Offset: 0x00354214
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
						this.VoiceId = input.ReadInt32();
					}
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040088D9 RID: 35033
		private static readonly MessageParser<RoleVoice> _parser = new MessageParser<RoleVoice>(() => new RoleVoice());

		// Token: 0x040088DA RID: 35034
		private UnknownFieldSet _unknownFields;

		// Token: 0x040088DB RID: 35035
		public const int RoleIdFieldNumber = 1;

		// Token: 0x040088DC RID: 35036
		private int roleId_;

		// Token: 0x040088DD RID: 35037
		public const int VoiceIdFieldNumber = 2;

		// Token: 0x040088DE RID: 35038
		private int voiceId_;
	}
}
