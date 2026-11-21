using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A08 RID: 2568
	[NetMessage(EMessageId.MoralePosResponse)]
	public sealed class MoralePosResponse : IMessage<MoralePosResponse>, IMessage, IEquatable<MoralePosResponse>, IDeepCloneable<MoralePosResponse>, IBufferMessage
	{
		// Token: 0x0600E100 RID: 57600 RVA: 0x0020FBBA File Offset: 0x0020DDBA
		[NullableContext(1)]
		public static MoralePosResponse Create()
		{
			return new MoralePosResponse();
		}

		// Token: 0x17002D9D RID: 11677
		// (get) Token: 0x0600E101 RID: 57601 RVA: 0x0020FBC1 File Offset: 0x0020DDC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D9E RID: 11678
		// (get) Token: 0x0600E102 RID: 57602 RVA: 0x0020FBC4 File Offset: 0x0020DDC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MoralePosResponse.Descriptor;
			}
		}

		// Token: 0x0600E103 RID: 57603 RVA: 0x0020FBCB File Offset: 0x0020DDCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoralePosResponse()
		{
		}

		// Token: 0x0600E104 RID: 57604 RVA: 0x0020FBD3 File Offset: 0x0020DDD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoralePosResponse(MoralePosResponse other) : this()
		{
			this.areaPos_ = other.areaPos_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E105 RID: 57605 RVA: 0x0020FBF8 File Offset: 0x0020DDF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoralePosResponse Clone()
		{
			return new MoralePosResponse(this);
		}

		// Token: 0x17002D9F RID: 11679
		// (get) Token: 0x0600E106 RID: 57606 RVA: 0x0020FC00 File Offset: 0x0020DE00
		// (set) Token: 0x0600E107 RID: 57607 RVA: 0x0020FC08 File Offset: 0x0020DE08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AreaPos
		{
			get
			{
				return this.areaPos_;
			}
			set
			{
				this.areaPos_ = value;
			}
		}

		// Token: 0x0600E108 RID: 57608 RVA: 0x0020FC11 File Offset: 0x0020DE11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MoralePosResponse);
		}

		// Token: 0x0600E109 RID: 57609 RVA: 0x0020FC1F File Offset: 0x0020DE1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MoralePosResponse other)
		{
			return other != null && (other == this || (this.AreaPos == other.AreaPos && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E10A RID: 57610 RVA: 0x0020FC50 File Offset: 0x0020DE50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AreaPos != 0)
			{
				num ^= this.AreaPos.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E10B RID: 57611 RVA: 0x0020FC8F File Offset: 0x0020DE8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E10C RID: 57612 RVA: 0x0020FC9C File Offset: 0x0020DE9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E10D RID: 57613 RVA: 0x0020FCA5 File Offset: 0x0020DEA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AreaPos != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.AreaPos);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E10E RID: 57614 RVA: 0x0020FCD8 File Offset: 0x0020DED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AreaPos != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AreaPos);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E10F RID: 57615 RVA: 0x0020FD16 File Offset: 0x0020DF16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MoralePosResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AreaPos != 0)
			{
				this.AreaPos = other.AreaPos;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E110 RID: 57616 RVA: 0x0020FD47 File Offset: 0x0020DF47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E111 RID: 57617 RVA: 0x0020FD50 File Offset: 0x0020DF50
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.AreaPos = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005CE8 RID: 23784
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005CE9 RID: 23785
		public const int AreaPosFieldNumber = 8;

		// Token: 0x04005CEA RID: 23786
		private int areaPos_;
	}
}
