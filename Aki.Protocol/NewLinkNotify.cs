using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B0A RID: 2826
	[NetMessage(EMessageId.NewLinkNotify)]
	public sealed class NewLinkNotify : IMessage<NewLinkNotify>, IMessage, IEquatable<NewLinkNotify>, IDeepCloneable<NewLinkNotify>, IBufferMessage
	{
		// Token: 0x0600F5B8 RID: 62904 RVA: 0x0023D962 File Offset: 0x0023BB62
		[NullableContext(1)]
		public static NewLinkNotify Create()
		{
			return new NewLinkNotify();
		}

		// Token: 0x17003204 RID: 12804
		// (get) Token: 0x0600F5B9 RID: 62905 RVA: 0x0023D969 File Offset: 0x0023BB69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003205 RID: 12805
		// (get) Token: 0x0600F5BA RID: 62906 RVA: 0x0023D96C File Offset: 0x0023BB6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewLinkNotify.Descriptor;
			}
		}

		// Token: 0x0600F5BB RID: 62907 RVA: 0x0023D973 File Offset: 0x0023BB73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewLinkNotify()
		{
		}

		// Token: 0x0600F5BC RID: 62908 RVA: 0x0023D97B File Offset: 0x0023BB7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewLinkNotify(NewLinkNotify other) : this()
		{
			this.linkId_ = other.linkId_;
			this.current_ = other.current_;
			this.playerId_ = other.playerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F5BD RID: 62909 RVA: 0x0023D9B8 File Offset: 0x0023BBB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewLinkNotify Clone()
		{
			return new NewLinkNotify(this);
		}

		// Token: 0x17003206 RID: 12806
		// (get) Token: 0x0600F5BE RID: 62910 RVA: 0x0023D9C0 File Offset: 0x0023BBC0
		// (set) Token: 0x0600F5BF RID: 62911 RVA: 0x0023D9C8 File Offset: 0x0023BBC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LinkId
		{
			get
			{
				return this.linkId_;
			}
			set
			{
				this.linkId_ = value;
			}
		}

		// Token: 0x17003207 RID: 12807
		// (get) Token: 0x0600F5C0 RID: 62912 RVA: 0x0023D9D1 File Offset: 0x0023BBD1
		// (set) Token: 0x0600F5C1 RID: 62913 RVA: 0x0023D9D9 File Offset: 0x0023BBD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ENewLinkStage Current
		{
			get
			{
				return this.current_;
			}
			set
			{
				this.current_ = value;
			}
		}

		// Token: 0x17003208 RID: 12808
		// (get) Token: 0x0600F5C2 RID: 62914 RVA: 0x0023D9E2 File Offset: 0x0023BBE2
		// (set) Token: 0x0600F5C3 RID: 62915 RVA: 0x0023D9EA File Offset: 0x0023BBEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x0600F5C4 RID: 62916 RVA: 0x0023D9F3 File Offset: 0x0023BBF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewLinkNotify);
		}

		// Token: 0x0600F5C5 RID: 62917 RVA: 0x0023DA04 File Offset: 0x0023BC04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewLinkNotify other)
		{
			return other != null && (other == this || (this.LinkId == other.LinkId && this.Current == other.Current && this.PlayerId == other.PlayerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F5C6 RID: 62918 RVA: 0x0023DA60 File Offset: 0x0023BC60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LinkId != 0)
			{
				num ^= this.LinkId.GetHashCode();
			}
			if (this.Current != ENewLinkStage.NewLinkStageNone)
			{
				int num2 = num;
				ENewLinkStage enewLinkStage = this.Current;
				num = (num2 ^ enewLinkStage.GetHashCode());
			}
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F5C7 RID: 62919 RVA: 0x0023DAD7 File Offset: 0x0023BCD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F5C8 RID: 62920 RVA: 0x0023DAE4 File Offset: 0x0023BCE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F5C9 RID: 62921 RVA: 0x0023DAF0 File Offset: 0x0023BCF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Current != ENewLinkStage.NewLinkStageNone)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Current);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.PlayerId);
			}
			if (this.LinkId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.LinkId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F5CA RID: 62922 RVA: 0x0023DB64 File Offset: 0x0023BD64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LinkId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LinkId);
			}
			if (this.Current != ENewLinkStage.NewLinkStageNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Current);
			}
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F5CB RID: 62923 RVA: 0x0023DBD4 File Offset: 0x0023BDD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewLinkNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LinkId != 0)
			{
				this.LinkId = other.LinkId;
			}
			if (other.Current != ENewLinkStage.NewLinkStageNone)
			{
				this.Current = other.Current;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F5CC RID: 62924 RVA: 0x0023DC38 File Offset: 0x0023BE38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F5CD RID: 62925 RVA: 0x0023DC44 File Offset: 0x0023BE44
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
				if (num != 8U)
				{
					if (num != 24U)
					{
						if (num != 80U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.LinkId = input.ReadInt32();
						}
					}
					else
					{
						this.PlayerId = input.ReadInt32();
					}
				}
				else
				{
					this.Current = (ENewLinkStage)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006316 RID: 25366
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006317 RID: 25367
		public const int LinkIdFieldNumber = 10;

		// Token: 0x04006318 RID: 25368
		private int linkId_;

		// Token: 0x04006319 RID: 25369
		public const int CurrentFieldNumber = 1;

		// Token: 0x0400631A RID: 25370
		private ENewLinkStage current_;

		// Token: 0x0400631B RID: 25371
		public const int PlayerIdFieldNumber = 3;

		// Token: 0x0400631C RID: 25372
		private int playerId_;
	}
}
