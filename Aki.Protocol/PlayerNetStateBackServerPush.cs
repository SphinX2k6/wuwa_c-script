using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D9C RID: 3484
	[NetMessage(EMessageId.PlayerNetStateBackServerPush)]
	public sealed class PlayerNetStateBackServerPush : IMessage<PlayerNetStateBackServerPush>, IMessage, IEquatable<PlayerNetStateBackServerPush>, IDeepCloneable<PlayerNetStateBackServerPush>, IBufferMessage
	{
		// Token: 0x06012C7A RID: 76922 RVA: 0x002BD7A5 File Offset: 0x002BB9A5
		[NullableContext(1)]
		public static PlayerNetStateBackServerPush Create()
		{
			return new PlayerNetStateBackServerPush();
		}

		// Token: 0x17003E52 RID: 15954
		// (get) Token: 0x06012C7B RID: 76923 RVA: 0x002BD7AC File Offset: 0x002BB9AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E53 RID: 15955
		// (get) Token: 0x06012C7C RID: 76924 RVA: 0x002BD7AF File Offset: 0x002BB9AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerNetStateBackServerPush.Descriptor;
			}
		}

		// Token: 0x06012C7D RID: 76925 RVA: 0x002BD7B6 File Offset: 0x002BB9B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerNetStateBackServerPush()
		{
		}

		// Token: 0x06012C7E RID: 76926 RVA: 0x002BD7BE File Offset: 0x002BB9BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerNetStateBackServerPush(PlayerNetStateBackServerPush other) : this()
		{
			this.uid_ = other.uid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012C7F RID: 76927 RVA: 0x002BD7E3 File Offset: 0x002BB9E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerNetStateBackServerPush Clone()
		{
			return new PlayerNetStateBackServerPush(this);
		}

		// Token: 0x17003E54 RID: 15956
		// (get) Token: 0x06012C80 RID: 76928 RVA: 0x002BD7EB File Offset: 0x002BB9EB
		// (set) Token: 0x06012C81 RID: 76929 RVA: 0x002BD7F3 File Offset: 0x002BB9F3
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

		// Token: 0x06012C82 RID: 76930 RVA: 0x002BD7FC File Offset: 0x002BB9FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerNetStateBackServerPush);
		}

		// Token: 0x06012C83 RID: 76931 RVA: 0x002BD80A File Offset: 0x002BBA0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerNetStateBackServerPush other)
		{
			return other != null && (other == this || (this.Uid == other.Uid && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012C84 RID: 76932 RVA: 0x002BD838 File Offset: 0x002BBA38
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

		// Token: 0x06012C85 RID: 76933 RVA: 0x002BD877 File Offset: 0x002BBA77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012C86 RID: 76934 RVA: 0x002BD884 File Offset: 0x002BBA84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012C87 RID: 76935 RVA: 0x002BD88D File Offset: 0x002BBA8D
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

		// Token: 0x06012C88 RID: 76936 RVA: 0x002BD8C0 File Offset: 0x002BBAC0
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

		// Token: 0x06012C89 RID: 76937 RVA: 0x002BD8FE File Offset: 0x002BBAFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerNetStateBackServerPush other)
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

		// Token: 0x06012C8A RID: 76938 RVA: 0x002BD92F File Offset: 0x002BBB2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012C8B RID: 76939 RVA: 0x002BD938 File Offset: 0x002BBB38
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

		// Token: 0x04007460 RID: 29792
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007461 RID: 29793
		public const int UidFieldNumber = 8;

		// Token: 0x04007462 RID: 29794
		private long uid_;
	}
}
