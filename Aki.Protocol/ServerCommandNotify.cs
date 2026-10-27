using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011C5 RID: 4549
	[NetMessage(EMessageId.ServerCommandNotify)]
	public sealed class ServerCommandNotify : IMessage<ServerCommandNotify>, IMessage, IEquatable<ServerCommandNotify>, IDeepCloneable<ServerCommandNotify>, IBufferMessage
	{
		// Token: 0x0601844E RID: 99406 RVA: 0x003884B1 File Offset: 0x003866B1
		[NullableContext(1)]
		public static ServerCommandNotify Create()
		{
			return new ServerCommandNotify();
		}

		// Token: 0x170051C0 RID: 20928
		// (get) Token: 0x0601844F RID: 99407 RVA: 0x003884B8 File Offset: 0x003866B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170051C1 RID: 20929
		// (get) Token: 0x06018450 RID: 99408 RVA: 0x003884BB File Offset: 0x003866BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ServerCommandNotify.Descriptor;
			}
		}

		// Token: 0x06018451 RID: 99409 RVA: 0x003884C2 File Offset: 0x003866C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ServerCommandNotify()
		{
		}

		// Token: 0x06018452 RID: 99410 RVA: 0x003884D5 File Offset: 0x003866D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ServerCommandNotify(ServerCommandNotify other) : this()
		{
			this.cmd_ = other.cmd_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018453 RID: 99411 RVA: 0x003884FA File Offset: 0x003866FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ServerCommandNotify Clone()
		{
			return new ServerCommandNotify(this);
		}

		// Token: 0x170051C2 RID: 20930
		// (get) Token: 0x06018454 RID: 99412 RVA: 0x00388502 File Offset: 0x00386702
		// (set) Token: 0x06018455 RID: 99413 RVA: 0x0038850A File Offset: 0x0038670A
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

		// Token: 0x06018456 RID: 99414 RVA: 0x0038851D File Offset: 0x0038671D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ServerCommandNotify);
		}

		// Token: 0x06018457 RID: 99415 RVA: 0x0038852B File Offset: 0x0038672B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ServerCommandNotify other)
		{
			return other != null && (other == this || (!(this.Cmd != other.Cmd) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018458 RID: 99416 RVA: 0x00388560 File Offset: 0x00386760
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

		// Token: 0x06018459 RID: 99417 RVA: 0x003885A1 File Offset: 0x003867A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601845A RID: 99418 RVA: 0x003885AE File Offset: 0x003867AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601845B RID: 99419 RVA: 0x003885B7 File Offset: 0x003867B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Cmd.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.Cmd);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601845C RID: 99420 RVA: 0x003885F0 File Offset: 0x003867F0
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

		// Token: 0x0601845D RID: 99421 RVA: 0x00388633 File Offset: 0x00386833
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

		// Token: 0x0601845E RID: 99422 RVA: 0x00388669 File Offset: 0x00386869
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601845F RID: 99423 RVA: 0x00388674 File Offset: 0x00386874
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
				if (num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Cmd = input.ReadString();
				}
			}
		}

		// Token: 0x04008FD3 RID: 36819
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008FD4 RID: 36820
		public const int CmdFieldNumber = 6;

		// Token: 0x04008FD5 RID: 36821
		private string cmd_ = "";
	}
}
