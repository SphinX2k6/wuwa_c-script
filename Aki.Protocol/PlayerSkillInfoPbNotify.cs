using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DA0 RID: 3488
	[NetMessage(EMessageId.PlayerSkillInfoPbNotify)]
	public sealed class PlayerSkillInfoPbNotify : IMessage<PlayerSkillInfoPbNotify>, IMessage, IEquatable<PlayerSkillInfoPbNotify>, IDeepCloneable<PlayerSkillInfoPbNotify>, IBufferMessage
	{
		// Token: 0x06012D20 RID: 77088 RVA: 0x002BF747 File Offset: 0x002BD947
		[NullableContext(1)]
		public static PlayerSkillInfoPbNotify Create()
		{
			return new PlayerSkillInfoPbNotify();
		}

		// Token: 0x17003E79 RID: 15993
		// (get) Token: 0x06012D21 RID: 77089 RVA: 0x002BF74E File Offset: 0x002BD94E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E7A RID: 15994
		// (get) Token: 0x06012D22 RID: 77090 RVA: 0x002BF751 File Offset: 0x002BD951
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerSkillInfoPbNotify.Descriptor;
			}
		}

		// Token: 0x06012D23 RID: 77091 RVA: 0x002BF758 File Offset: 0x002BD958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerSkillInfoPbNotify()
		{
		}

		// Token: 0x06012D24 RID: 77092 RVA: 0x002BF760 File Offset: 0x002BD960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerSkillInfoPbNotify(PlayerSkillInfoPbNotify other) : this()
		{
			this.playerSkillInfoPb_ = ((other.playerSkillInfoPb_ != null) ? other.playerSkillInfoPb_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012D25 RID: 77093 RVA: 0x002BF795 File Offset: 0x002BD995
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerSkillInfoPbNotify Clone()
		{
			return new PlayerSkillInfoPbNotify(this);
		}

		// Token: 0x17003E7B RID: 15995
		// (get) Token: 0x06012D26 RID: 77094 RVA: 0x002BF79D File Offset: 0x002BD99D
		// (set) Token: 0x06012D27 RID: 77095 RVA: 0x002BF7A5 File Offset: 0x002BD9A5
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

		// Token: 0x06012D28 RID: 77096 RVA: 0x002BF7AE File Offset: 0x002BD9AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerSkillInfoPbNotify);
		}

		// Token: 0x06012D29 RID: 77097 RVA: 0x002BF7BC File Offset: 0x002BD9BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerSkillInfoPbNotify other)
		{
			return other != null && (other == this || (object.Equals(this.PlayerSkillInfoPb, other.PlayerSkillInfoPb) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012D2A RID: 77098 RVA: 0x002BF7F0 File Offset: 0x002BD9F0
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

		// Token: 0x06012D2B RID: 77099 RVA: 0x002BF82C File Offset: 0x002BDA2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012D2C RID: 77100 RVA: 0x002BF839 File Offset: 0x002BDA39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012D2D RID: 77101 RVA: 0x002BF842 File Offset: 0x002BDA42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.playerSkillInfoPb_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.PlayerSkillInfoPb);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012D2E RID: 77102 RVA: 0x002BF874 File Offset: 0x002BDA74
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

		// Token: 0x06012D2F RID: 77103 RVA: 0x002BF8B4 File Offset: 0x002BDAB4
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

		// Token: 0x06012D30 RID: 77104 RVA: 0x002BF908 File Offset: 0x002BDB08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012D31 RID: 77105 RVA: 0x002BF914 File Offset: 0x002BDB14
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
				if (num != 98U)
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

		// Token: 0x040074FC RID: 29948
		private UnknownFieldSet _unknownFields;

		// Token: 0x040074FD RID: 29949
		public const int PlayerSkillInfoPbFieldNumber = 12;

		// Token: 0x040074FE RID: 29950
		private PlayerSkillInfoPb playerSkillInfoPb_;
	}
}
