using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200110D RID: 4365
	public sealed class RoleVoice : IMessage<RoleVoice>, IMessage, IEquatable<RoleVoice>, IDeepCloneable<RoleVoice>, IBufferMessage
	{
		// Token: 0x06017549 RID: 95561 RVA: 0x00365129 File Offset: 0x00363329
		[NullableContext(1)]
		public static RoleVoice Create()
		{
			return new RoleVoice();
		}

		// Token: 0x17004E63 RID: 20067
		// (get) Token: 0x0601754A RID: 95562 RVA: 0x00365130 File Offset: 0x00363330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoleVoice> Parser
		{
			get
			{
				return RoleVoice._parser;
			}
		}

		// Token: 0x17004E64 RID: 20068
		// (get) Token: 0x0601754B RID: 95563 RVA: 0x00365137 File Offset: 0x00363337
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E65 RID: 20069
		// (get) Token: 0x0601754C RID: 95564 RVA: 0x0036513A File Offset: 0x0036333A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleVoice.Descriptor;
			}
		}

		// Token: 0x0601754D RID: 95565 RVA: 0x00365141 File Offset: 0x00363341
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleVoice()
		{
		}

		// Token: 0x0601754E RID: 95566 RVA: 0x00365149 File Offset: 0x00363349
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleVoice(RoleVoice other) : this()
		{
			this.roleId_ = other.roleId_;
			this.voiceId_ = other.voiceId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601754F RID: 95567 RVA: 0x0036517A File Offset: 0x0036337A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleVoice Clone()
		{
			return new RoleVoice(this);
		}

		// Token: 0x17004E66 RID: 20070
		// (get) Token: 0x06017550 RID: 95568 RVA: 0x00365182 File Offset: 0x00363382
		// (set) Token: 0x06017551 RID: 95569 RVA: 0x0036518A File Offset: 0x0036338A
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

		// Token: 0x17004E67 RID: 20071
		// (get) Token: 0x06017552 RID: 95570 RVA: 0x00365193 File Offset: 0x00363393
		// (set) Token: 0x06017553 RID: 95571 RVA: 0x0036519B File Offset: 0x0036339B
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

		// Token: 0x06017554 RID: 95572 RVA: 0x003651A4 File Offset: 0x003633A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleVoice);
		}

		// Token: 0x06017555 RID: 95573 RVA: 0x003651B2 File Offset: 0x003633B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleVoice other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.VoiceId == other.VoiceId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017556 RID: 95574 RVA: 0x003651F0 File Offset: 0x003633F0
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

		// Token: 0x06017557 RID: 95575 RVA: 0x00365248 File Offset: 0x00363448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017558 RID: 95576 RVA: 0x00365255 File Offset: 0x00363455
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017559 RID: 95577 RVA: 0x00365260 File Offset: 0x00363460
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

		// Token: 0x0601755A RID: 95578 RVA: 0x003652B8 File Offset: 0x003634B8
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

		// Token: 0x0601755B RID: 95579 RVA: 0x00365310 File Offset: 0x00363510
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

		// Token: 0x0601755C RID: 95580 RVA: 0x00365360 File Offset: 0x00363560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601755D RID: 95581 RVA: 0x0036536C File Offset: 0x0036356C
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

		// Token: 0x04008B6C RID: 35692
		private static readonly MessageParser<RoleVoice> _parser = new MessageParser<RoleVoice>(() => new RoleVoice());

		// Token: 0x04008B6D RID: 35693
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008B6E RID: 35694
		public const int RoleIdFieldNumber = 1;

		// Token: 0x04008B6F RID: 35695
		private int roleId_;

		// Token: 0x04008B70 RID: 35696
		public const int VoiceIdFieldNumber = 2;

		// Token: 0x04008B71 RID: 35697
		private int voiceId_;
	}
}
