using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006CD RID: 1741
	[NetMessage(EMessageId.GiantModelEnableNotify)]
	public sealed class GiantModelEnableNotify : IMessage<GiantModelEnableNotify>, IMessage, IEquatable<GiantModelEnableNotify>, IDeepCloneable<GiantModelEnableNotify>, IBufferMessage
	{
		// Token: 0x06009F60 RID: 40800 RVA: 0x001827F3 File Offset: 0x001809F3
		[NullableContext(1)]
		public static GiantModelEnableNotify Create()
		{
			return new GiantModelEnableNotify();
		}

		// Token: 0x17001FFF RID: 8191
		// (get) Token: 0x06009F61 RID: 40801 RVA: 0x001827FA File Offset: 0x001809FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002000 RID: 8192
		// (get) Token: 0x06009F62 RID: 40802 RVA: 0x001827FD File Offset: 0x001809FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GiantModelEnableNotify.Descriptor;
			}
		}

		// Token: 0x06009F63 RID: 40803 RVA: 0x00182804 File Offset: 0x00180A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantModelEnableNotify()
		{
		}

		// Token: 0x06009F64 RID: 40804 RVA: 0x0018280C File Offset: 0x00180A0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantModelEnableNotify(GiantModelEnableNotify other) : this()
		{
			this.enable_ = other.enable_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009F65 RID: 40805 RVA: 0x00182831 File Offset: 0x00180A31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantModelEnableNotify Clone()
		{
			return new GiantModelEnableNotify(this);
		}

		// Token: 0x17002001 RID: 8193
		// (get) Token: 0x06009F66 RID: 40806 RVA: 0x00182839 File Offset: 0x00180A39
		// (set) Token: 0x06009F67 RID: 40807 RVA: 0x00182841 File Offset: 0x00180A41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Enable
		{
			get
			{
				return this.enable_;
			}
			set
			{
				this.enable_ = value;
			}
		}

		// Token: 0x06009F68 RID: 40808 RVA: 0x0018284A File Offset: 0x00180A4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GiantModelEnableNotify);
		}

		// Token: 0x06009F69 RID: 40809 RVA: 0x00182858 File Offset: 0x00180A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GiantModelEnableNotify other)
		{
			return other != null && (other == this || (this.Enable == other.Enable && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009F6A RID: 40810 RVA: 0x00182888 File Offset: 0x00180A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Enable)
			{
				num ^= this.Enable.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009F6B RID: 40811 RVA: 0x001828C7 File Offset: 0x00180AC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009F6C RID: 40812 RVA: 0x001828D4 File Offset: 0x00180AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009F6D RID: 40813 RVA: 0x001828DD File Offset: 0x00180ADD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Enable)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.Enable);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009F6E RID: 40814 RVA: 0x00182910 File Offset: 0x00180B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Enable)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009F6F RID: 40815 RVA: 0x00182942 File Offset: 0x00180B42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GiantModelEnableNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Enable)
			{
				this.Enable = other.Enable;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009F70 RID: 40816 RVA: 0x00182973 File Offset: 0x00180B73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009F71 RID: 40817 RVA: 0x0018297C File Offset: 0x00180B7C
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Enable = input.ReadBool();
				}
			}
		}

		// Token: 0x04004AC0 RID: 19136
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004AC1 RID: 19137
		public const int EnableFieldNumber = 4;

		// Token: 0x04004AC2 RID: 19138
		private bool enable_;
	}
}
