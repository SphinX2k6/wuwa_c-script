using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D8F RID: 3471
	[NetMessage(EMessageId.PlayerNetStateS2cNotify)]
	public sealed class PlayerNetStateS2cNotify : IMessage<PlayerNetStateS2cNotify>, IMessage, IEquatable<PlayerNetStateS2cNotify>, IDeepCloneable<PlayerNetStateS2cNotify>, IBufferMessage
	{
		// Token: 0x06012BB6 RID: 76726 RVA: 0x002BC1D1 File Offset: 0x002BA3D1
		[NullableContext(1)]
		public static PlayerNetStateS2cNotify Create()
		{
			return new PlayerNetStateS2cNotify();
		}

		// Token: 0x17003E27 RID: 15911
		// (get) Token: 0x06012BB7 RID: 76727 RVA: 0x002BC1D8 File Offset: 0x002BA3D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E28 RID: 15912
		// (get) Token: 0x06012BB8 RID: 76728 RVA: 0x002BC1DB File Offset: 0x002BA3DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerNetStateS2cNotify.Descriptor;
			}
		}

		// Token: 0x06012BB9 RID: 76729 RVA: 0x002BC1E2 File Offset: 0x002BA3E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerNetStateS2cNotify()
		{
		}

		// Token: 0x06012BBA RID: 76730 RVA: 0x002BC1EA File Offset: 0x002BA3EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerNetStateS2cNotify(PlayerNetStateS2cNotify other) : this()
		{
			this.uid_ = other.uid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012BBB RID: 76731 RVA: 0x002BC20F File Offset: 0x002BA40F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerNetStateS2cNotify Clone()
		{
			return new PlayerNetStateS2cNotify(this);
		}

		// Token: 0x17003E29 RID: 15913
		// (get) Token: 0x06012BBC RID: 76732 RVA: 0x002BC217 File Offset: 0x002BA417
		// (set) Token: 0x06012BBD RID: 76733 RVA: 0x002BC21F File Offset: 0x002BA41F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Uid
		{
			get
			{
				return this.uid_;
			}
			set
			{
				this.uid_ = value;
			}
		}

		// Token: 0x06012BBE RID: 76734 RVA: 0x002BC228 File Offset: 0x002BA428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerNetStateS2cNotify);
		}

		// Token: 0x06012BBF RID: 76735 RVA: 0x002BC236 File Offset: 0x002BA436
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerNetStateS2cNotify other)
		{
			return other != null && (other == this || (this.Uid == other.Uid && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012BC0 RID: 76736 RVA: 0x002BC264 File Offset: 0x002BA464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Uid != 0L)
			{
				num ^= this.Uid.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012BC1 RID: 76737 RVA: 0x002BC2A3 File Offset: 0x002BA4A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012BC2 RID: 76738 RVA: 0x002BC2B0 File Offset: 0x002BA4B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012BC3 RID: 76739 RVA: 0x002BC2B9 File Offset: 0x002BA4B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Uid != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.Uid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012BC4 RID: 76740 RVA: 0x002BC2EC File Offset: 0x002BA4EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Uid != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Uid);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012BC5 RID: 76741 RVA: 0x002BC32A File Offset: 0x002BA52A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerNetStateS2cNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Uid != 0L)
			{
				this.Uid = other.Uid;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012BC6 RID: 76742 RVA: 0x002BC35B File Offset: 0x002BA55B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012BC7 RID: 76743 RVA: 0x002BC364 File Offset: 0x002BA564
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Uid = input.ReadInt64();
				}
			}
		}

		// Token: 0x04007483 RID: 29827
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007484 RID: 29828
		public const int UidFieldNumber = 8;

		// Token: 0x04007485 RID: 29829
		private long uid_;
	}
}
