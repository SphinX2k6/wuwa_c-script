using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B1B RID: 2843
	[NetMessage(EMessageId.NewLinkNotify)]
	public sealed class NewLinkNotify : IMessage<NewLinkNotify>, IMessage, IEquatable<NewLinkNotify>, IDeepCloneable<NewLinkNotify>, IBufferMessage
	{
		// Token: 0x0600F6D2 RID: 63186 RVA: 0x0023FB76 File Offset: 0x0023DD76
		[NullableContext(1)]
		public static NewLinkNotify Create()
		{
			return new NewLinkNotify();
		}

		// Token: 0x17003242 RID: 12866
		// (get) Token: 0x0600F6D3 RID: 63187 RVA: 0x0023FB7D File Offset: 0x0023DD7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003243 RID: 12867
		// (get) Token: 0x0600F6D4 RID: 63188 RVA: 0x0023FB80 File Offset: 0x0023DD80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewLinkNotify.Descriptor;
			}
		}

		// Token: 0x0600F6D5 RID: 63189 RVA: 0x0023FB87 File Offset: 0x0023DD87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewLinkNotify()
		{
		}

		// Token: 0x0600F6D6 RID: 63190 RVA: 0x0023FB8F File Offset: 0x0023DD8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewLinkNotify(NewLinkNotify other) : this()
		{
			this.linkId_ = other.linkId_;
			this.current_ = other.current_;
			this.playerId_ = other.playerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F6D7 RID: 63191 RVA: 0x0023FBCC File Offset: 0x0023DDCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewLinkNotify Clone()
		{
			return new NewLinkNotify(this);
		}

		// Token: 0x17003244 RID: 12868
		// (get) Token: 0x0600F6D8 RID: 63192 RVA: 0x0023FBD4 File Offset: 0x0023DDD4
		// (set) Token: 0x0600F6D9 RID: 63193 RVA: 0x0023FBDC File Offset: 0x0023DDDC
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

		// Token: 0x17003245 RID: 12869
		// (get) Token: 0x0600F6DA RID: 63194 RVA: 0x0023FBE5 File Offset: 0x0023DDE5
		// (set) Token: 0x0600F6DB RID: 63195 RVA: 0x0023FBED File Offset: 0x0023DDED
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

		// Token: 0x17003246 RID: 12870
		// (get) Token: 0x0600F6DC RID: 63196 RVA: 0x0023FBF6 File Offset: 0x0023DDF6
		// (set) Token: 0x0600F6DD RID: 63197 RVA: 0x0023FBFE File Offset: 0x0023DDFE
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

		// Token: 0x0600F6DE RID: 63198 RVA: 0x0023FC07 File Offset: 0x0023DE07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewLinkNotify);
		}

		// Token: 0x0600F6DF RID: 63199 RVA: 0x0023FC18 File Offset: 0x0023DE18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewLinkNotify other)
		{
			return other != null && (other == this || (this.LinkId == other.LinkId && this.Current == other.Current && this.PlayerId == other.PlayerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F6E0 RID: 63200 RVA: 0x0023FC74 File Offset: 0x0023DE74
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

		// Token: 0x0600F6E1 RID: 63201 RVA: 0x0023FCEB File Offset: 0x0023DEEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F6E2 RID: 63202 RVA: 0x0023FCF8 File Offset: 0x0023DEF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F6E3 RID: 63203 RVA: 0x0023FD04 File Offset: 0x0023DF04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.PlayerId);
			}
			if (this.LinkId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.LinkId);
			}
			if (this.Current != ENewLinkStage.NewLinkStageNone)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.Current);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F6E4 RID: 63204 RVA: 0x0023FD7C File Offset: 0x0023DF7C
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

		// Token: 0x0600F6E5 RID: 63205 RVA: 0x0023FDEC File Offset: 0x0023DFEC
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

		// Token: 0x0600F6E6 RID: 63206 RVA: 0x0023FE50 File Offset: 0x0023E050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F6E7 RID: 63207 RVA: 0x0023FE5C File Offset: 0x0023E05C
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
				if (num != 16U)
				{
					if (num != 40U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Current = (ENewLinkStage)input.ReadEnum();
						}
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
		}

		// Token: 0x0400630D RID: 25357
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400630E RID: 25358
		public const int LinkIdFieldNumber = 5;

		// Token: 0x0400630F RID: 25359
		private int linkId_;

		// Token: 0x04006310 RID: 25360
		public const int CurrentFieldNumber = 13;

		// Token: 0x04006311 RID: 25361
		private ENewLinkStage current_;

		// Token: 0x04006312 RID: 25362
		public const int PlayerIdFieldNumber = 2;

		// Token: 0x04006313 RID: 25363
		private int playerId_;
	}
}
