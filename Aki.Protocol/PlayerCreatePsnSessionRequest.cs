using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D74 RID: 3444
	[NetMessage(EMessageId.PlayerCreatePsnSessionRequest)]
	public sealed class PlayerCreatePsnSessionRequest : IMessage<PlayerCreatePsnSessionRequest>, IMessage, IEquatable<PlayerCreatePsnSessionRequest>, IDeepCloneable<PlayerCreatePsnSessionRequest>, IBufferMessage
	{
		// Token: 0x0601296C RID: 76140 RVA: 0x002B69F8 File Offset: 0x002B4BF8
		[NullableContext(1)]
		public static PlayerCreatePsnSessionRequest Create()
		{
			return new PlayerCreatePsnSessionRequest();
		}

		// Token: 0x17003DA2 RID: 15778
		// (get) Token: 0x0601296D RID: 76141 RVA: 0x002B69FF File Offset: 0x002B4BFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003DA3 RID: 15779
		// (get) Token: 0x0601296E RID: 76142 RVA: 0x002B6A02 File Offset: 0x002B4C02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerCreatePsnSessionRequest.Descriptor;
			}
		}

		// Token: 0x0601296F RID: 76143 RVA: 0x002B6A09 File Offset: 0x002B4C09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerCreatePsnSessionRequest()
		{
		}

		// Token: 0x06012970 RID: 76144 RVA: 0x002B6A1C File Offset: 0x002B4C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerCreatePsnSessionRequest(PlayerCreatePsnSessionRequest other) : this()
		{
			this.psnSessionId_ = other.psnSessionId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012971 RID: 76145 RVA: 0x002B6A41 File Offset: 0x002B4C41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerCreatePsnSessionRequest Clone()
		{
			return new PlayerCreatePsnSessionRequest(this);
		}

		// Token: 0x17003DA4 RID: 15780
		// (get) Token: 0x06012972 RID: 76146 RVA: 0x002B6A49 File Offset: 0x002B4C49
		// (set) Token: 0x06012973 RID: 76147 RVA: 0x002B6A51 File Offset: 0x002B4C51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string PsnSessionId
		{
			get
			{
				return this.psnSessionId_;
			}
			set
			{
				this.psnSessionId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06012974 RID: 76148 RVA: 0x002B6A64 File Offset: 0x002B4C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerCreatePsnSessionRequest);
		}

		// Token: 0x06012975 RID: 76149 RVA: 0x002B6A72 File Offset: 0x002B4C72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerCreatePsnSessionRequest other)
		{
			return other != null && (other == this || (!(this.PsnSessionId != other.PsnSessionId) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012976 RID: 76150 RVA: 0x002B6AA8 File Offset: 0x002B4CA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PsnSessionId.Length != 0)
			{
				num ^= this.PsnSessionId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012977 RID: 76151 RVA: 0x002B6AE9 File Offset: 0x002B4CE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012978 RID: 76152 RVA: 0x002B6AF6 File Offset: 0x002B4CF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012979 RID: 76153 RVA: 0x002B6AFF File Offset: 0x002B4CFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PsnSessionId.Length != 0)
			{
				output.WriteRawTag(66);
				output.WriteString(this.PsnSessionId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601297A RID: 76154 RVA: 0x002B6B38 File Offset: 0x002B4D38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PsnSessionId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.PsnSessionId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601297B RID: 76155 RVA: 0x002B6B7B File Offset: 0x002B4D7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerCreatePsnSessionRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PsnSessionId.Length != 0)
			{
				this.PsnSessionId = other.PsnSessionId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601297C RID: 76156 RVA: 0x002B6BB1 File Offset: 0x002B4DB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601297D RID: 76157 RVA: 0x002B6BBC File Offset: 0x002B4DBC
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
					this.PsnSessionId = input.ReadString();
				}
			}
		}

		// Token: 0x040073C5 RID: 29637
		private UnknownFieldSet _unknownFields;

		// Token: 0x040073C6 RID: 29638
		public const int PsnSessionIdFieldNumber = 8;

		// Token: 0x040073C7 RID: 29639
		private string psnSessionId_ = "";
	}
}
