using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D97 RID: 3479
	[NetMessage(EMessageId.PlayerRenameNotify)]
	public sealed class PlayerRenameNotify : IMessage<PlayerRenameNotify>, IMessage, IEquatable<PlayerRenameNotify>, IDeepCloneable<PlayerRenameNotify>, IBufferMessage
	{
		// Token: 0x06012C48 RID: 76872 RVA: 0x002BD239 File Offset: 0x002BB439
		[NullableContext(1)]
		public static PlayerRenameNotify Create()
		{
			return new PlayerRenameNotify();
		}

		// Token: 0x17003E40 RID: 15936
		// (get) Token: 0x06012C49 RID: 76873 RVA: 0x002BD240 File Offset: 0x002BB440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E41 RID: 15937
		// (get) Token: 0x06012C4A RID: 76874 RVA: 0x002BD243 File Offset: 0x002BB443
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerRenameNotify.Descriptor;
			}
		}

		// Token: 0x06012C4B RID: 76875 RVA: 0x002BD24A File Offset: 0x002BB44A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerRenameNotify()
		{
		}

		// Token: 0x06012C4C RID: 76876 RVA: 0x002BD25D File Offset: 0x002BB45D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerRenameNotify(PlayerRenameNotify other) : this()
		{
			this.name_ = other.name_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012C4D RID: 76877 RVA: 0x002BD282 File Offset: 0x002BB482
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerRenameNotify Clone()
		{
			return new PlayerRenameNotify(this);
		}

		// Token: 0x17003E42 RID: 15938
		// (get) Token: 0x06012C4E RID: 76878 RVA: 0x002BD28A File Offset: 0x002BB48A
		// (set) Token: 0x06012C4F RID: 76879 RVA: 0x002BD292 File Offset: 0x002BB492
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name
		{
			get
			{
				return this.name_;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06012C50 RID: 76880 RVA: 0x002BD2A5 File Offset: 0x002BB4A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerRenameNotify);
		}

		// Token: 0x06012C51 RID: 76881 RVA: 0x002BD2B3 File Offset: 0x002BB4B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerRenameNotify other)
		{
			return other != null && (other == this || (!(this.Name != other.Name) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012C52 RID: 76882 RVA: 0x002BD2E8 File Offset: 0x002BB4E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012C53 RID: 76883 RVA: 0x002BD329 File Offset: 0x002BB529
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012C54 RID: 76884 RVA: 0x002BD336 File Offset: 0x002BB536
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012C55 RID: 76885 RVA: 0x002BD33F File Offset: 0x002BB53F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(this.Name);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012C56 RID: 76886 RVA: 0x002BD378 File Offset: 0x002BB578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012C57 RID: 76887 RVA: 0x002BD3BB File Offset: 0x002BB5BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerRenameNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012C58 RID: 76888 RVA: 0x002BD3F1 File Offset: 0x002BB5F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012C59 RID: 76889 RVA: 0x002BD3FC File Offset: 0x002BB5FC
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
				if (num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Name = input.ReadString();
				}
			}
		}

		// Token: 0x0400749E RID: 29854
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400749F RID: 29855
		public const int NameFieldNumber = 3;

		// Token: 0x040074A0 RID: 29856
		private string name_ = "";
	}
}
