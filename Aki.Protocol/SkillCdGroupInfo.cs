using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001272 RID: 4722
	public sealed class SkillCdGroupInfo : IMessage<SkillCdGroupInfo>, IMessage, IEquatable<SkillCdGroupInfo>, IDeepCloneable<SkillCdGroupInfo>, IBufferMessage
	{
		// Token: 0x06019357 RID: 103255 RVA: 0x003AD424 File Offset: 0x003AB624
		[NullableContext(1)]
		public static SkillCdGroupInfo Create()
		{
			return new SkillCdGroupInfo();
		}

		// Token: 0x1700553C RID: 21820
		// (get) Token: 0x06019358 RID: 103256 RVA: 0x003AD42B File Offset: 0x003AB62B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SkillCdGroupInfo> Parser
		{
			get
			{
				return SkillCdGroupInfo._parser;
			}
		}

		// Token: 0x1700553D RID: 21821
		// (get) Token: 0x06019359 RID: 103257 RVA: 0x003AD432 File Offset: 0x003AB632
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700553E RID: 21822
		// (get) Token: 0x0601935A RID: 103258 RVA: 0x003AD435 File Offset: 0x003AB635
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SkillCdGroupInfo.Descriptor;
			}
		}

		// Token: 0x0601935B RID: 103259 RVA: 0x003AD43C File Offset: 0x003AB63C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillCdGroupInfo()
		{
		}

		// Token: 0x0601935C RID: 103260 RVA: 0x003AD444 File Offset: 0x003AB644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillCdGroupInfo(SkillCdGroupInfo other) : this()
		{
			this.shareGroupId_ = other.shareGroupId_;
			this.skillCdInfo_ = ((other.skillCdInfo_ != null) ? other.skillCdInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601935D RID: 103261 RVA: 0x003AD490 File Offset: 0x003AB690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillCdGroupInfo Clone()
		{
			return new SkillCdGroupInfo(this);
		}

		// Token: 0x1700553F RID: 21823
		// (get) Token: 0x0601935E RID: 103262 RVA: 0x003AD498 File Offset: 0x003AB698
		// (set) Token: 0x0601935F RID: 103263 RVA: 0x003AD4A0 File Offset: 0x003AB6A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ShareGroupId
		{
			get
			{
				return this.shareGroupId_;
			}
			set
			{
				this.shareGroupId_ = value;
			}
		}

		// Token: 0x17005540 RID: 21824
		// (get) Token: 0x06019360 RID: 103264 RVA: 0x003AD4A9 File Offset: 0x003AB6A9
		// (set) Token: 0x06019361 RID: 103265 RVA: 0x003AD4B1 File Offset: 0x003AB6B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillCdInfo SkillCdInfo
		{
			get
			{
				return this.skillCdInfo_;
			}
			set
			{
				this.skillCdInfo_ = value;
			}
		}

		// Token: 0x06019362 RID: 103266 RVA: 0x003AD4BA File Offset: 0x003AB6BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SkillCdGroupInfo);
		}

		// Token: 0x06019363 RID: 103267 RVA: 0x003AD4C8 File Offset: 0x003AB6C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SkillCdGroupInfo other)
		{
			return other != null && (other == this || (this.ShareGroupId == other.ShareGroupId && object.Equals(this.SkillCdInfo, other.SkillCdInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019364 RID: 103268 RVA: 0x003AD518 File Offset: 0x003AB718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ShareGroupId != 0)
			{
				num ^= this.ShareGroupId.GetHashCode();
			}
			if (this.skillCdInfo_ != null)
			{
				num ^= this.SkillCdInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019365 RID: 103269 RVA: 0x003AD56D File Offset: 0x003AB76D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019366 RID: 103270 RVA: 0x003AD57A File Offset: 0x003AB77A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019367 RID: 103271 RVA: 0x003AD584 File Offset: 0x003AB784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ShareGroupId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ShareGroupId);
			}
			if (this.skillCdInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.SkillCdInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019368 RID: 103272 RVA: 0x003AD5DC File Offset: 0x003AB7DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ShareGroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ShareGroupId);
			}
			if (this.skillCdInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SkillCdInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019369 RID: 103273 RVA: 0x003AD634 File Offset: 0x003AB834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SkillCdGroupInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ShareGroupId != 0)
			{
				this.ShareGroupId = other.ShareGroupId;
			}
			if (other.skillCdInfo_ != null)
			{
				if (this.skillCdInfo_ == null)
				{
					this.SkillCdInfo = new SkillCdInfo();
				}
				this.SkillCdInfo.MergeFrom(other.SkillCdInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601936A RID: 103274 RVA: 0x003AD69C File Offset: 0x003AB89C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601936B RID: 103275 RVA: 0x003AD6A8 File Offset: 0x003AB8A8
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
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.skillCdInfo_ == null)
						{
							this.SkillCdInfo = new SkillCdInfo();
						}
						input.ReadMessage(this.SkillCdInfo);
					}
				}
				else
				{
					this.ShareGroupId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009538 RID: 38200
		private static readonly MessageParser<SkillCdGroupInfo> _parser = new MessageParser<SkillCdGroupInfo>(() => new SkillCdGroupInfo());

		// Token: 0x04009539 RID: 38201
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400953A RID: 38202
		public const int ShareGroupIdFieldNumber = 1;

		// Token: 0x0400953B RID: 38203
		private int shareGroupId_;

		// Token: 0x0400953C RID: 38204
		public const int SkillCdInfoFieldNumber = 2;

		// Token: 0x0400953D RID: 38205
		private SkillCdInfo skillCdInfo_;
	}
}
