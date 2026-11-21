using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011FF RID: 4607
	[NetMessage(EMessageId.ServerCommandNotify)]
	public sealed class ServerCommandNotify : IMessage<ServerCommandNotify>, IMessage, IEquatable<ServerCommandNotify>, IDeepCloneable<ServerCommandNotify>, IBufferMessage
	{
		// Token: 0x060189EF RID: 100847 RVA: 0x003977E5 File Offset: 0x003959E5
		[NullableContext(1)]
		public static ServerCommandNotify Create()
		{
			return new ServerCommandNotify();
		}

		// Token: 0x1700532C RID: 21292
		// (get) Token: 0x060189F0 RID: 100848 RVA: 0x003977EC File Offset: 0x003959EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700532D RID: 21293
		// (get) Token: 0x060189F1 RID: 100849 RVA: 0x003977EF File Offset: 0x003959EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ServerCommandNotify.Descriptor;
			}
		}

		// Token: 0x060189F2 RID: 100850 RVA: 0x003977F6 File Offset: 0x003959F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ServerCommandNotify()
		{
		}

		// Token: 0x060189F3 RID: 100851 RVA: 0x00397809 File Offset: 0x00395A09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ServerCommandNotify(ServerCommandNotify other) : this()
		{
			this.cmd_ = other.cmd_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060189F4 RID: 100852 RVA: 0x0039782E File Offset: 0x00395A2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ServerCommandNotify Clone()
		{
			return new ServerCommandNotify(this);
		}

		// Token: 0x1700532E RID: 21294
		// (get) Token: 0x060189F5 RID: 100853 RVA: 0x00397836 File Offset: 0x00395A36
		// (set) Token: 0x060189F6 RID: 100854 RVA: 0x0039783E File Offset: 0x00395A3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Cmd
		{
			get
			{
				return this.cmd_;
			}
			set
			{
				this.cmd_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x060189F7 RID: 100855 RVA: 0x00397851 File Offset: 0x00395A51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ServerCommandNotify);
		}

		// Token: 0x060189F8 RID: 100856 RVA: 0x0039785F File Offset: 0x00395A5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ServerCommandNotify other)
		{
			return other != null && (other == this || (!(this.Cmd != other.Cmd) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060189F9 RID: 100857 RVA: 0x00397894 File Offset: 0x00395A94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Cmd.Length != 0)
			{
				num ^= this.Cmd.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060189FA RID: 100858 RVA: 0x003978D5 File Offset: 0x00395AD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060189FB RID: 100859 RVA: 0x003978E2 File Offset: 0x00395AE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060189FC RID: 100860 RVA: 0x003978EB File Offset: 0x00395AEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Cmd.Length != 0)
			{
				output.WriteRawTag(66);
				output.WriteString(this.Cmd);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060189FD RID: 100861 RVA: 0x00397924 File Offset: 0x00395B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Cmd.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Cmd);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060189FE RID: 100862 RVA: 0x00397967 File Offset: 0x00395B67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ServerCommandNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Cmd.Length != 0)
			{
				this.Cmd = other.Cmd;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060189FF RID: 100863 RVA: 0x0039799D File Offset: 0x00395B9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018A00 RID: 100864 RVA: 0x003979A8 File Offset: 0x00395BA8
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
				if (num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Cmd = input.ReadString();
				}
			}
		}

		// Token: 0x04009266 RID: 37478
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009267 RID: 37479
		public const int CmdFieldNumber = 8;

		// Token: 0x04009268 RID: 37480
		private string cmd_ = "";
	}
}
