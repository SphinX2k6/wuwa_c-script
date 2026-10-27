using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200100D RID: 4109
	[NetMessage(EMessageId.RogueResTaskAwardRequest)]
	public sealed class RogueResTaskAwardRequest : IMessage<RogueResTaskAwardRequest>, IMessage, IEquatable<RogueResTaskAwardRequest>, IDeepCloneable<RogueResTaskAwardRequest>, IBufferMessage
	{
		// Token: 0x06015F8D RID: 89997 RVA: 0x00331CF1 File Offset: 0x0032FEF1
		[NullableContext(1)]
		public static RogueResTaskAwardRequest Create()
		{
			return new RogueResTaskAwardRequest();
		}

		// Token: 0x17004971 RID: 18801
		// (get) Token: 0x06015F8E RID: 89998 RVA: 0x00331CF8 File Offset: 0x0032FEF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004972 RID: 18802
		// (get) Token: 0x06015F8F RID: 89999 RVA: 0x00331CFB File Offset: 0x0032FEFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResTaskAwardRequest.Descriptor;
			}
		}

		// Token: 0x06015F90 RID: 90000 RVA: 0x00331D02 File Offset: 0x0032FF02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResTaskAwardRequest()
		{
		}

		// Token: 0x06015F91 RID: 90001 RVA: 0x00331D0A File Offset: 0x0032FF0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResTaskAwardRequest(RogueResTaskAwardRequest other) : this()
		{
			this.configId_ = other.configId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015F92 RID: 90002 RVA: 0x00331D2F File Offset: 0x0032FF2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResTaskAwardRequest Clone()
		{
			return new RogueResTaskAwardRequest(this);
		}

		// Token: 0x17004973 RID: 18803
		// (get) Token: 0x06015F93 RID: 90003 RVA: 0x00331D37 File Offset: 0x0032FF37
		// (set) Token: 0x06015F94 RID: 90004 RVA: 0x00331D3F File Offset: 0x0032FF3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x06015F95 RID: 90005 RVA: 0x00331D48 File Offset: 0x0032FF48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResTaskAwardRequest);
		}

		// Token: 0x06015F96 RID: 90006 RVA: 0x00331D56 File Offset: 0x0032FF56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResTaskAwardRequest other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015F97 RID: 90007 RVA: 0x00331D84 File Offset: 0x0032FF84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015F98 RID: 90008 RVA: 0x00331DC3 File Offset: 0x0032FFC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015F99 RID: 90009 RVA: 0x00331DD0 File Offset: 0x0032FFD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015F9A RID: 90010 RVA: 0x00331DD9 File Offset: 0x0032FFD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015F9B RID: 90011 RVA: 0x00331E0C File Offset: 0x0033000C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015F9C RID: 90012 RVA: 0x00331E4A File Offset: 0x0033004A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResTaskAwardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015F9D RID: 90013 RVA: 0x00331E7B File Offset: 0x0033007B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015F9E RID: 90014 RVA: 0x00331E84 File Offset: 0x00330084
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040083D6 RID: 33750
		private UnknownFieldSet _unknownFields;

		// Token: 0x040083D7 RID: 33751
		public const int ConfigIdFieldNumber = 6;

		// Token: 0x040083D8 RID: 33752
		private int configId_;
	}
}
