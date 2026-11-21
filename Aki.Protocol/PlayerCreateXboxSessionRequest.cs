using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D76 RID: 3446
	[NetMessage(EMessageId.PlayerCreateXboxSessionRequest)]
	public sealed class PlayerCreateXboxSessionRequest : IMessage<PlayerCreateXboxSessionRequest>, IMessage, IEquatable<PlayerCreateXboxSessionRequest>, IDeepCloneable<PlayerCreateXboxSessionRequest>, IBufferMessage
	{
		// Token: 0x0601298E RID: 76174 RVA: 0x002B6D3A File Offset: 0x002B4F3A
		[NullableContext(1)]
		public static PlayerCreateXboxSessionRequest Create()
		{
			return new PlayerCreateXboxSessionRequest();
		}

		// Token: 0x17003DA7 RID: 15783
		// (get) Token: 0x0601298F RID: 76175 RVA: 0x002B6D41 File Offset: 0x002B4F41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003DA8 RID: 15784
		// (get) Token: 0x06012990 RID: 76176 RVA: 0x002B6D44 File Offset: 0x002B4F44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerCreateXboxSessionRequest.Descriptor;
			}
		}

		// Token: 0x06012991 RID: 76177 RVA: 0x002B6D4B File Offset: 0x002B4F4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerCreateXboxSessionRequest()
		{
		}

		// Token: 0x06012992 RID: 76178 RVA: 0x002B6D5E File Offset: 0x002B4F5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerCreateXboxSessionRequest(PlayerCreateXboxSessionRequest other) : this()
		{
			this.xboxSessionId_ = other.xboxSessionId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012993 RID: 76179 RVA: 0x002B6D83 File Offset: 0x002B4F83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerCreateXboxSessionRequest Clone()
		{
			return new PlayerCreateXboxSessionRequest(this);
		}

		// Token: 0x17003DA9 RID: 15785
		// (get) Token: 0x06012994 RID: 76180 RVA: 0x002B6D8B File Offset: 0x002B4F8B
		// (set) Token: 0x06012995 RID: 76181 RVA: 0x002B6D93 File Offset: 0x002B4F93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string XboxSessionId
		{
			get
			{
				return this.xboxSessionId_;
			}
			set
			{
				this.xboxSessionId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06012996 RID: 76182 RVA: 0x002B6DA6 File Offset: 0x002B4FA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerCreateXboxSessionRequest);
		}

		// Token: 0x06012997 RID: 76183 RVA: 0x002B6DB4 File Offset: 0x002B4FB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerCreateXboxSessionRequest other)
		{
			return other != null && (other == this || (!(this.XboxSessionId != other.XboxSessionId) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012998 RID: 76184 RVA: 0x002B6DE8 File Offset: 0x002B4FE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.XboxSessionId.Length != 0)
			{
				num ^= this.XboxSessionId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012999 RID: 76185 RVA: 0x002B6E29 File Offset: 0x002B5029
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601299A RID: 76186 RVA: 0x002B6E36 File Offset: 0x002B5036
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601299B RID: 76187 RVA: 0x002B6E3F File Offset: 0x002B503F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.XboxSessionId.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.XboxSessionId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601299C RID: 76188 RVA: 0x002B6E78 File Offset: 0x002B5078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.XboxSessionId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.XboxSessionId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601299D RID: 76189 RVA: 0x002B6EBB File Offset: 0x002B50BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerCreateXboxSessionRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.XboxSessionId.Length != 0)
			{
				this.XboxSessionId = other.XboxSessionId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601299E RID: 76190 RVA: 0x002B6EF1 File Offset: 0x002B50F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601299F RID: 76191 RVA: 0x002B6EFC File Offset: 0x002B50FC
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
				if (num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.XboxSessionId = input.ReadString();
				}
			}
		}

		// Token: 0x040073C9 RID: 29641
		private UnknownFieldSet _unknownFields;

		// Token: 0x040073CA RID: 29642
		public const int XboxSessionIdFieldNumber = 2;

		// Token: 0x040073CB RID: 29643
		private string xboxSessionId_ = "";
	}
}
