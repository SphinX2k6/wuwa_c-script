using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200123D RID: 4669
	[NetMessage(EMessageId.SkillNotify)]
	public sealed class SkillNotify : IMessage<SkillNotify>, IMessage, IEquatable<SkillNotify>, IDeepCloneable<SkillNotify>, IBufferMessage
	{
		// Token: 0x06018E25 RID: 101925 RVA: 0x0039F1D6 File Offset: 0x0039D3D6
		[NullableContext(1)]
		public static SkillNotify Create()
		{
			return new SkillNotify();
		}

		// Token: 0x170053EB RID: 21483
		// (get) Token: 0x06018E26 RID: 101926 RVA: 0x0039F1DD File Offset: 0x0039D3DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170053EC RID: 21484
		// (get) Token: 0x06018E27 RID: 101927 RVA: 0x0039F1E0 File Offset: 0x0039D3E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SkillNotify.Descriptor;
			}
		}

		// Token: 0x06018E28 RID: 101928 RVA: 0x0039F1E7 File Offset: 0x0039D3E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillNotify()
		{
		}

		// Token: 0x06018E29 RID: 101929 RVA: 0x0039F1F0 File Offset: 0x0039D3F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillNotify(SkillNotify other) : this()
		{
			this.useSkillInfo_ = ((other.useSkillInfo_ != null) ? other.useSkillInfo_.Clone() : null);
			this.skillNodeInfos_ = ((other.skillNodeInfos_ != null) ? other.skillNodeInfos_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018E2A RID: 101930 RVA: 0x0039F24C File Offset: 0x0039D44C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillNotify Clone()
		{
			return new SkillNotify(this);
		}

		// Token: 0x170053ED RID: 21485
		// (get) Token: 0x06018E2B RID: 101931 RVA: 0x0039F254 File Offset: 0x0039D454
		// (set) Token: 0x06018E2C RID: 101932 RVA: 0x0039F25C File Offset: 0x0039D45C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillInformation UseSkillInfo
		{
			get
			{
				return this.useSkillInfo_;
			}
			set
			{
				this.useSkillInfo_ = value;
			}
		}

		// Token: 0x170053EE RID: 21486
		// (get) Token: 0x06018E2D RID: 101933 RVA: 0x0039F265 File Offset: 0x0039D465
		// (set) Token: 0x06018E2E RID: 101934 RVA: 0x0039F26D File Offset: 0x0039D46D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillNodeInfo SkillNodeInfos
		{
			get
			{
				return this.skillNodeInfos_;
			}
			set
			{
				this.skillNodeInfos_ = value;
			}
		}

		// Token: 0x06018E2F RID: 101935 RVA: 0x0039F276 File Offset: 0x0039D476
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SkillNotify);
		}

		// Token: 0x06018E30 RID: 101936 RVA: 0x0039F284 File Offset: 0x0039D484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SkillNotify other)
		{
			return other != null && (other == this || (object.Equals(this.UseSkillInfo, other.UseSkillInfo) && object.Equals(this.SkillNodeInfos, other.SkillNodeInfos) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018E31 RID: 101937 RVA: 0x0039F2D8 File Offset: 0x0039D4D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.useSkillInfo_ != null)
			{
				num ^= this.UseSkillInfo.GetHashCode();
			}
			if (this.skillNodeInfos_ != null)
			{
				num ^= this.SkillNodeInfos.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018E32 RID: 101938 RVA: 0x0039F32A File Offset: 0x0039D52A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018E33 RID: 101939 RVA: 0x0039F337 File Offset: 0x0039D537
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018E34 RID: 101940 RVA: 0x0039F340 File Offset: 0x0039D540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.skillNodeInfos_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.SkillNodeInfos);
			}
			if (this.useSkillInfo_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.UseSkillInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018E35 RID: 101941 RVA: 0x0039F39C File Offset: 0x0039D59C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.useSkillInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.UseSkillInfo);
			}
			if (this.skillNodeInfos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SkillNodeInfos);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018E36 RID: 101942 RVA: 0x0039F3F4 File Offset: 0x0039D5F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SkillNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.useSkillInfo_ != null)
			{
				if (this.useSkillInfo_ == null)
				{
					this.UseSkillInfo = new UseSkillInformation();
				}
				this.UseSkillInfo.MergeFrom(other.UseSkillInfo);
			}
			if (other.skillNodeInfos_ != null)
			{
				if (this.skillNodeInfos_ == null)
				{
					this.SkillNodeInfos = new SkillNodeInfo();
				}
				this.SkillNodeInfos.MergeFrom(other.SkillNodeInfos);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018E37 RID: 101943 RVA: 0x0039F474 File Offset: 0x0039D674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018E38 RID: 101944 RVA: 0x0039F480 File Offset: 0x0039D680
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
				if (num != 82U)
				{
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.useSkillInfo_ == null)
						{
							this.UseSkillInfo = new UseSkillInformation();
						}
						input.ReadMessage(this.UseSkillInfo);
					}
				}
				else
				{
					if (this.skillNodeInfos_ == null)
					{
						this.SkillNodeInfos = new SkillNodeInfo();
					}
					input.ReadMessage(this.SkillNodeInfos);
				}
			}
		}

		// Token: 0x040092CC RID: 37580
		private UnknownFieldSet _unknownFields;

		// Token: 0x040092CD RID: 37581
		public const int UseSkillInfoFieldNumber = 13;

		// Token: 0x040092CE RID: 37582
		private UseSkillInformation useSkillInfo_;

		// Token: 0x040092CF RID: 37583
		public const int SkillNodeInfosFieldNumber = 10;

		// Token: 0x040092D0 RID: 37584
		private SkillNodeInfo skillNodeInfos_;
	}
}
