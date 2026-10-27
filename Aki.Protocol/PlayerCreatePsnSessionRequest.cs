using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D84 RID: 3460
	[NetMessage(EMessageId.PlayerCreatePsnSessionRequest)]
	public sealed class PlayerCreatePsnSessionRequest : IMessage<PlayerCreatePsnSessionRequest>, IMessage, IEquatable<PlayerCreatePsnSessionRequest>, IDeepCloneable<PlayerCreatePsnSessionRequest>, IBufferMessage
	{
		// Token: 0x06012A68 RID: 76392 RVA: 0x002B8618 File Offset: 0x002B6818
		[NullableContext(1)]
		public static PlayerCreatePsnSessionRequest Create()
		{
			return new PlayerCreatePsnSessionRequest();
		}

		// Token: 0x17003DD7 RID: 15831
		// (get) Token: 0x06012A69 RID: 76393 RVA: 0x002B861F File Offset: 0x002B681F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003DD8 RID: 15832
		// (get) Token: 0x06012A6A RID: 76394 RVA: 0x002B8622 File Offset: 0x002B6822
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerCreatePsnSessionRequest.Descriptor;
			}
		}

		// Token: 0x06012A6B RID: 76395 RVA: 0x002B8629 File Offset: 0x002B6829
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerCreatePsnSessionRequest()
		{
		}

		// Token: 0x06012A6C RID: 76396 RVA: 0x002B863C File Offset: 0x002B683C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerCreatePsnSessionRequest(PlayerCreatePsnSessionRequest other) : this()
		{
			this.psnSessionId_ = other.psnSessionId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012A6D RID: 76397 RVA: 0x002B8661 File Offset: 0x002B6861
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerCreatePsnSessionRequest Clone()
		{
			return new PlayerCreatePsnSessionRequest(this);
		}

		// Token: 0x17003DD9 RID: 15833
		// (get) Token: 0x06012A6E RID: 76398 RVA: 0x002B8669 File Offset: 0x002B6869
		// (set) Token: 0x06012A6F RID: 76399 RVA: 0x002B8671 File Offset: 0x002B6871
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

		// Token: 0x06012A70 RID: 76400 RVA: 0x002B8684 File Offset: 0x002B6884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerCreatePsnSessionRequest);
		}

		// Token: 0x06012A71 RID: 76401 RVA: 0x002B8692 File Offset: 0x002B6892
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerCreatePsnSessionRequest other)
		{
			return other != null && (other == this || (!(this.PsnSessionId != other.PsnSessionId) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012A72 RID: 76402 RVA: 0x002B86C8 File Offset: 0x002B68C8
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

		// Token: 0x06012A73 RID: 76403 RVA: 0x002B8709 File Offset: 0x002B6909
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012A74 RID: 76404 RVA: 0x002B8716 File Offset: 0x002B6916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012A75 RID: 76405 RVA: 0x002B871F File Offset: 0x002B691F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PsnSessionId.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.PsnSessionId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012A76 RID: 76406 RVA: 0x002B8758 File Offset: 0x002B6958
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

		// Token: 0x06012A77 RID: 76407 RVA: 0x002B879B File Offset: 0x002B699B
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

		// Token: 0x06012A78 RID: 76408 RVA: 0x002B87D1 File Offset: 0x002B69D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012A79 RID: 76409 RVA: 0x002B87DC File Offset: 0x002B69DC
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
					this.PsnSessionId = input.ReadString();
				}
			}
		}

		// Token: 0x040073AD RID: 29613
		private UnknownFieldSet _unknownFields;

		// Token: 0x040073AE RID: 29614
		public const int PsnSessionIdFieldNumber = 6;

		// Token: 0x040073AF RID: 29615
		private string psnSessionId_ = "";
	}
}
