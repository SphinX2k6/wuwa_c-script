using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D92 RID: 3474
	[NetMessage(EMessageId.PlayerPsnInfoGetRequest)]
	public sealed class PlayerPsnInfoGetRequest : IMessage<PlayerPsnInfoGetRequest>, IMessage, IEquatable<PlayerPsnInfoGetRequest>, IDeepCloneable<PlayerPsnInfoGetRequest>, IBufferMessage
	{
		// Token: 0x06012BEA RID: 76778 RVA: 0x002BC6BE File Offset: 0x002BA8BE
		[NullableContext(1)]
		public static PlayerPsnInfoGetRequest Create()
		{
			return new PlayerPsnInfoGetRequest();
		}

		// Token: 0x17003E2F RID: 15919
		// (get) Token: 0x06012BEB RID: 76779 RVA: 0x002BC6C5 File Offset: 0x002BA8C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E30 RID: 15920
		// (get) Token: 0x06012BEC RID: 76780 RVA: 0x002BC6C8 File Offset: 0x002BA8C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerPsnInfoGetRequest.Descriptor;
			}
		}

		// Token: 0x06012BED RID: 76781 RVA: 0x002BC6CF File Offset: 0x002BA8CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerPsnInfoGetRequest()
		{
		}

		// Token: 0x06012BEE RID: 76782 RVA: 0x002BC6E2 File Offset: 0x002BA8E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerPsnInfoGetRequest(PlayerPsnInfoGetRequest other) : this()
		{
			this.psnOnlineId_ = other.psnOnlineId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012BEF RID: 76783 RVA: 0x002BC707 File Offset: 0x002BA907
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerPsnInfoGetRequest Clone()
		{
			return new PlayerPsnInfoGetRequest(this);
		}

		// Token: 0x17003E31 RID: 15921
		// (get) Token: 0x06012BF0 RID: 76784 RVA: 0x002BC70F File Offset: 0x002BA90F
		// (set) Token: 0x06012BF1 RID: 76785 RVA: 0x002BC717 File Offset: 0x002BA917
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string PsnOnlineId
		{
			get
			{
				return this.psnOnlineId_;
			}
			set
			{
				this.psnOnlineId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06012BF2 RID: 76786 RVA: 0x002BC72A File Offset: 0x002BA92A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerPsnInfoGetRequest);
		}

		// Token: 0x06012BF3 RID: 76787 RVA: 0x002BC738 File Offset: 0x002BA938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerPsnInfoGetRequest other)
		{
			return other != null && (other == this || (!(this.PsnOnlineId != other.PsnOnlineId) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012BF4 RID: 76788 RVA: 0x002BC76C File Offset: 0x002BA96C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PsnOnlineId.Length != 0)
			{
				num ^= this.PsnOnlineId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012BF5 RID: 76789 RVA: 0x002BC7AD File Offset: 0x002BA9AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012BF6 RID: 76790 RVA: 0x002BC7BA File Offset: 0x002BA9BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012BF7 RID: 76791 RVA: 0x002BC7C3 File Offset: 0x002BA9C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PsnOnlineId.Length != 0)
			{
				output.WriteRawTag(106);
				output.WriteString(this.PsnOnlineId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012BF8 RID: 76792 RVA: 0x002BC7FC File Offset: 0x002BA9FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PsnOnlineId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.PsnOnlineId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012BF9 RID: 76793 RVA: 0x002BC83F File Offset: 0x002BAA3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerPsnInfoGetRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PsnOnlineId.Length != 0)
			{
				this.PsnOnlineId = other.PsnOnlineId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012BFA RID: 76794 RVA: 0x002BC875 File Offset: 0x002BAA75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012BFB RID: 76795 RVA: 0x002BC880 File Offset: 0x002BAA80
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
					this.PsnOnlineId = input.ReadString();
				}
			}
		}

		// Token: 0x0400748B RID: 29835
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400748C RID: 29836
		public const int PsnOnlineIdFieldNumber = 13;

		// Token: 0x0400748D RID: 29837
		private string psnOnlineId_ = "";
	}
}
