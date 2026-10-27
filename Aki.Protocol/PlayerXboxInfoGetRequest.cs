using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DBF RID: 3519
	[NetMessage(EMessageId.PlayerXboxInfoGetRequest)]
	public sealed class PlayerXboxInfoGetRequest : IMessage<PlayerXboxInfoGetRequest>, IMessage, IEquatable<PlayerXboxInfoGetRequest>, IDeepCloneable<PlayerXboxInfoGetRequest>, IBufferMessage
	{
		// Token: 0x06012F41 RID: 77633 RVA: 0x002C38A6 File Offset: 0x002C1AA6
		[NullableContext(1)]
		public static PlayerXboxInfoGetRequest Create()
		{
			return new PlayerXboxInfoGetRequest();
		}

		// Token: 0x17003EE8 RID: 16104
		// (get) Token: 0x06012F42 RID: 77634 RVA: 0x002C38AD File Offset: 0x002C1AAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003EE9 RID: 16105
		// (get) Token: 0x06012F43 RID: 77635 RVA: 0x002C38B0 File Offset: 0x002C1AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerXboxInfoGetRequest.Descriptor;
			}
		}

		// Token: 0x06012F44 RID: 77636 RVA: 0x002C38B7 File Offset: 0x002C1AB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerXboxInfoGetRequest()
		{
		}

		// Token: 0x06012F45 RID: 77637 RVA: 0x002C38CA File Offset: 0x002C1ACA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerXboxInfoGetRequest(PlayerXboxInfoGetRequest other) : this()
		{
			this.xboxOnlineId_ = other.xboxOnlineId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012F46 RID: 77638 RVA: 0x002C38EF File Offset: 0x002C1AEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerXboxInfoGetRequest Clone()
		{
			return new PlayerXboxInfoGetRequest(this);
		}

		// Token: 0x17003EEA RID: 16106
		// (get) Token: 0x06012F47 RID: 77639 RVA: 0x002C38F7 File Offset: 0x002C1AF7
		// (set) Token: 0x06012F48 RID: 77640 RVA: 0x002C38FF File Offset: 0x002C1AFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string XboxOnlineId
		{
			get
			{
				return this.xboxOnlineId_;
			}
			set
			{
				this.xboxOnlineId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06012F49 RID: 77641 RVA: 0x002C3912 File Offset: 0x002C1B12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerXboxInfoGetRequest);
		}

		// Token: 0x06012F4A RID: 77642 RVA: 0x002C3920 File Offset: 0x002C1B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerXboxInfoGetRequest other)
		{
			return other != null && (other == this || (!(this.XboxOnlineId != other.XboxOnlineId) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012F4B RID: 77643 RVA: 0x002C3954 File Offset: 0x002C1B54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.XboxOnlineId.Length != 0)
			{
				num ^= this.XboxOnlineId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012F4C RID: 77644 RVA: 0x002C3995 File Offset: 0x002C1B95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012F4D RID: 77645 RVA: 0x002C39A2 File Offset: 0x002C1BA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012F4E RID: 77646 RVA: 0x002C39AB File Offset: 0x002C1BAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.XboxOnlineId.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(this.XboxOnlineId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012F4F RID: 77647 RVA: 0x002C39E4 File Offset: 0x002C1BE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.XboxOnlineId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.XboxOnlineId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012F50 RID: 77648 RVA: 0x002C3A27 File Offset: 0x002C1C27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerXboxInfoGetRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.XboxOnlineId.Length != 0)
			{
				this.XboxOnlineId = other.XboxOnlineId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012F51 RID: 77649 RVA: 0x002C3A5D File Offset: 0x002C1C5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012F52 RID: 77650 RVA: 0x002C3A68 File Offset: 0x002C1C68
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
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.XboxOnlineId = input.ReadString();
				}
			}
		}

		// Token: 0x04007532 RID: 30002
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007533 RID: 30003
		public const int XboxOnlineIdFieldNumber = 4;

		// Token: 0x04007534 RID: 30004
		private string xboxOnlineId_ = "";
	}
}
