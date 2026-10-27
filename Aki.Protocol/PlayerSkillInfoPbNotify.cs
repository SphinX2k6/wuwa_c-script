using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DB0 RID: 3504
	[NetMessage(EMessageId.PlayerSkillInfoPbNotify)]
	public sealed class PlayerSkillInfoPbNotify : IMessage<PlayerSkillInfoPbNotify>, IMessage, IEquatable<PlayerSkillInfoPbNotify>, IDeepCloneable<PlayerSkillInfoPbNotify>, IBufferMessage
	{
		// Token: 0x06012E1C RID: 77340 RVA: 0x002C136B File Offset: 0x002BF56B
		[NullableContext(1)]
		public static PlayerSkillInfoPbNotify Create()
		{
			return new PlayerSkillInfoPbNotify();
		}

		// Token: 0x17003EAE RID: 16046
		// (get) Token: 0x06012E1D RID: 77341 RVA: 0x002C1372 File Offset: 0x002BF572
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003EAF RID: 16047
		// (get) Token: 0x06012E1E RID: 77342 RVA: 0x002C1375 File Offset: 0x002BF575
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerSkillInfoPbNotify.Descriptor;
			}
		}

		// Token: 0x06012E1F RID: 77343 RVA: 0x002C137C File Offset: 0x002BF57C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerSkillInfoPbNotify()
		{
		}

		// Token: 0x06012E20 RID: 77344 RVA: 0x002C1384 File Offset: 0x002BF584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerSkillInfoPbNotify(PlayerSkillInfoPbNotify other) : this()
		{
			this.playerSkillInfoPb_ = ((other.playerSkillInfoPb_ != null) ? other.playerSkillInfoPb_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012E21 RID: 77345 RVA: 0x002C13B9 File Offset: 0x002BF5B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerSkillInfoPbNotify Clone()
		{
			return new PlayerSkillInfoPbNotify(this);
		}

		// Token: 0x17003EB0 RID: 16048
		// (get) Token: 0x06012E22 RID: 77346 RVA: 0x002C13C1 File Offset: 0x002BF5C1
		// (set) Token: 0x06012E23 RID: 77347 RVA: 0x002C13C9 File Offset: 0x002BF5C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerSkillInfoPb PlayerSkillInfoPb
		{
			get
			{
				return this.playerSkillInfoPb_;
			}
			set
			{
				this.playerSkillInfoPb_ = value;
			}
		}

		// Token: 0x06012E24 RID: 77348 RVA: 0x002C13D2 File Offset: 0x002BF5D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerSkillInfoPbNotify);
		}

		// Token: 0x06012E25 RID: 77349 RVA: 0x002C13E0 File Offset: 0x002BF5E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerSkillInfoPbNotify other)
		{
			return other != null && (other == this || (object.Equals(this.PlayerSkillInfoPb, other.PlayerSkillInfoPb) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012E26 RID: 77350 RVA: 0x002C1414 File Offset: 0x002BF614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.playerSkillInfoPb_ != null)
			{
				num ^= this.PlayerSkillInfoPb.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012E27 RID: 77351 RVA: 0x002C1450 File Offset: 0x002BF650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012E28 RID: 77352 RVA: 0x002C145D File Offset: 0x002BF65D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012E29 RID: 77353 RVA: 0x002C1466 File Offset: 0x002BF666
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.playerSkillInfoPb_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.PlayerSkillInfoPb);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012E2A RID: 77354 RVA: 0x002C1498 File Offset: 0x002BF698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.playerSkillInfoPb_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PlayerSkillInfoPb);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012E2B RID: 77355 RVA: 0x002C14D8 File Offset: 0x002BF6D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerSkillInfoPbNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.playerSkillInfoPb_ != null)
			{
				if (this.playerSkillInfoPb_ == null)
				{
					this.PlayerSkillInfoPb = new PlayerSkillInfoPb();
				}
				this.PlayerSkillInfoPb.MergeFrom(other.PlayerSkillInfoPb);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012E2C RID: 77356 RVA: 0x002C152C File Offset: 0x002BF72C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012E2D RID: 77357 RVA: 0x002C1538 File Offset: 0x002BF738
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
					if (this.playerSkillInfoPb_ == null)
					{
						this.PlayerSkillInfoPb = new PlayerSkillInfoPb();
					}
					input.ReadMessage(this.PlayerSkillInfoPb);
				}
			}
		}

		// Token: 0x040074E4 RID: 29924
		private UnknownFieldSet _unknownFields;

		// Token: 0x040074E5 RID: 29925
		public const int PlayerSkillInfoPbFieldNumber = 3;

		// Token: 0x040074E6 RID: 29926
		private PlayerSkillInfoPb playerSkillInfoPb_;
	}
}
