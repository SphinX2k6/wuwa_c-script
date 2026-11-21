using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D95 RID: 3477
	[NetMessage(EMessageId.PlayerRebackSceneNotify)]
	public sealed class PlayerRebackSceneNotify : IMessage<PlayerRebackSceneNotify>, IMessage, IEquatable<PlayerRebackSceneNotify>, IDeepCloneable<PlayerRebackSceneNotify>, IBufferMessage
	{
		// Token: 0x06012C24 RID: 76836 RVA: 0x002BCE88 File Offset: 0x002BB088
		[NullableContext(1)]
		public static PlayerRebackSceneNotify Create()
		{
			return new PlayerRebackSceneNotify();
		}

		// Token: 0x17003E3A RID: 15930
		// (get) Token: 0x06012C25 RID: 76837 RVA: 0x002BCE8F File Offset: 0x002BB08F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E3B RID: 15931
		// (get) Token: 0x06012C26 RID: 76838 RVA: 0x002BCE92 File Offset: 0x002BB092
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerRebackSceneNotify.Descriptor;
			}
		}

		// Token: 0x06012C27 RID: 76839 RVA: 0x002BCE99 File Offset: 0x002BB099
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerRebackSceneNotify()
		{
		}

		// Token: 0x06012C28 RID: 76840 RVA: 0x002BCEA1 File Offset: 0x002BB0A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerRebackSceneNotify(PlayerRebackSceneNotify other) : this()
		{
			this.curControlEntityId_ = other.curControlEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012C29 RID: 76841 RVA: 0x002BCEC6 File Offset: 0x002BB0C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerRebackSceneNotify Clone()
		{
			return new PlayerRebackSceneNotify(this);
		}

		// Token: 0x17003E3C RID: 15932
		// (get) Token: 0x06012C2A RID: 76842 RVA: 0x002BCECE File Offset: 0x002BB0CE
		// (set) Token: 0x06012C2B RID: 76843 RVA: 0x002BCED6 File Offset: 0x002BB0D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CurControlEntityId
		{
			get
			{
				return this.curControlEntityId_;
			}
			set
			{
				this.curControlEntityId_ = value;
			}
		}

		// Token: 0x06012C2C RID: 76844 RVA: 0x002BCEDF File Offset: 0x002BB0DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerRebackSceneNotify);
		}

		// Token: 0x06012C2D RID: 76845 RVA: 0x002BCEED File Offset: 0x002BB0ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerRebackSceneNotify other)
		{
			return other != null && (other == this || (this.CurControlEntityId == other.CurControlEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012C2E RID: 76846 RVA: 0x002BCF1C File Offset: 0x002BB11C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CurControlEntityId != 0L)
			{
				num ^= this.CurControlEntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012C2F RID: 76847 RVA: 0x002BCF5B File Offset: 0x002BB15B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012C30 RID: 76848 RVA: 0x002BCF68 File Offset: 0x002BB168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012C31 RID: 76849 RVA: 0x002BCF71 File Offset: 0x002BB171
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurControlEntityId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.CurControlEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012C32 RID: 76850 RVA: 0x002BCFA4 File Offset: 0x002BB1A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurControlEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CurControlEntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012C33 RID: 76851 RVA: 0x002BCFE2 File Offset: 0x002BB1E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerRebackSceneNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CurControlEntityId != 0L)
			{
				this.CurControlEntityId = other.CurControlEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012C34 RID: 76852 RVA: 0x002BD013 File Offset: 0x002BB213
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012C35 RID: 76853 RVA: 0x002BD01C File Offset: 0x002BB21C
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.CurControlEntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04007498 RID: 29848
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007499 RID: 29849
		public const int CurControlEntityIdFieldNumber = 3;

		// Token: 0x0400749A RID: 29850
		private long curControlEntityId_;
	}
}
