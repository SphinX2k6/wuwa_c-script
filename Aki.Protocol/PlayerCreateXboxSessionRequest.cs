using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D86 RID: 3462
	[NetMessage(EMessageId.PlayerCreateXboxSessionRequest)]
	public sealed class PlayerCreateXboxSessionRequest : IMessage<PlayerCreateXboxSessionRequest>, IMessage, IEquatable<PlayerCreateXboxSessionRequest>, IDeepCloneable<PlayerCreateXboxSessionRequest>, IBufferMessage
	{
		// Token: 0x06012A8A RID: 76426 RVA: 0x002B895A File Offset: 0x002B6B5A
		[NullableContext(1)]
		public static PlayerCreateXboxSessionRequest Create()
		{
			return new PlayerCreateXboxSessionRequest();
		}

		// Token: 0x17003DDC RID: 15836
		// (get) Token: 0x06012A8B RID: 76427 RVA: 0x002B8961 File Offset: 0x002B6B61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003DDD RID: 15837
		// (get) Token: 0x06012A8C RID: 76428 RVA: 0x002B8964 File Offset: 0x002B6B64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerCreateXboxSessionRequest.Descriptor;
			}
		}

		// Token: 0x06012A8D RID: 76429 RVA: 0x002B896B File Offset: 0x002B6B6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerCreateXboxSessionRequest()
		{
		}

		// Token: 0x06012A8E RID: 76430 RVA: 0x002B897E File Offset: 0x002B6B7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerCreateXboxSessionRequest(PlayerCreateXboxSessionRequest other) : this()
		{
			this.xboxSessionId_ = other.xboxSessionId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012A8F RID: 76431 RVA: 0x002B89A3 File Offset: 0x002B6BA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerCreateXboxSessionRequest Clone()
		{
			return new PlayerCreateXboxSessionRequest(this);
		}

		// Token: 0x17003DDE RID: 15838
		// (get) Token: 0x06012A90 RID: 76432 RVA: 0x002B89AB File Offset: 0x002B6BAB
		// (set) Token: 0x06012A91 RID: 76433 RVA: 0x002B89B3 File Offset: 0x002B6BB3
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

		// Token: 0x06012A92 RID: 76434 RVA: 0x002B89C6 File Offset: 0x002B6BC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerCreateXboxSessionRequest);
		}

		// Token: 0x06012A93 RID: 76435 RVA: 0x002B89D4 File Offset: 0x002B6BD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerCreateXboxSessionRequest other)
		{
			return other != null && (other == this || (!(this.XboxSessionId != other.XboxSessionId) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012A94 RID: 76436 RVA: 0x002B8A08 File Offset: 0x002B6C08
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

		// Token: 0x06012A95 RID: 76437 RVA: 0x002B8A49 File Offset: 0x002B6C49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012A96 RID: 76438 RVA: 0x002B8A56 File Offset: 0x002B6C56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012A97 RID: 76439 RVA: 0x002B8A5F File Offset: 0x002B6C5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.XboxSessionId.Length != 0)
			{
				output.WriteRawTag(106);
				output.WriteString(this.XboxSessionId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012A98 RID: 76440 RVA: 0x002B8A98 File Offset: 0x002B6C98
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

		// Token: 0x06012A99 RID: 76441 RVA: 0x002B8ADB File Offset: 0x002B6CDB
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

		// Token: 0x06012A9A RID: 76442 RVA: 0x002B8B11 File Offset: 0x002B6D11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012A9B RID: 76443 RVA: 0x002B8B1C File Offset: 0x002B6D1C
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
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.XboxSessionId = input.ReadString();
				}
			}
		}

		// Token: 0x040073B1 RID: 29617
		private UnknownFieldSet _unknownFields;

		// Token: 0x040073B2 RID: 29618
		public const int XboxSessionIdFieldNumber = 13;

		// Token: 0x040073B3 RID: 29619
		private string xboxSessionId_ = "";
	}
}
