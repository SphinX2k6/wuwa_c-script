using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200127A RID: 4730
	[NetMessage(EMessageId.SkillNotify)]
	public sealed class SkillNotify : IMessage<SkillNotify>, IMessage, IEquatable<SkillNotify>, IDeepCloneable<SkillNotify>, IBufferMessage
	{
		// Token: 0x0601940F RID: 103439 RVA: 0x003AF136 File Offset: 0x003AD336
		[NullableContext(1)]
		public static SkillNotify Create()
		{
			return new SkillNotify();
		}

		// Token: 0x1700556A RID: 21866
		// (get) Token: 0x06019410 RID: 103440 RVA: 0x003AF13D File Offset: 0x003AD33D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700556B RID: 21867
		// (get) Token: 0x06019411 RID: 103441 RVA: 0x003AF140 File Offset: 0x003AD340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SkillNotify.Descriptor;
			}
		}

		// Token: 0x06019412 RID: 103442 RVA: 0x003AF147 File Offset: 0x003AD347
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillNotify()
		{
		}

		// Token: 0x06019413 RID: 103443 RVA: 0x003AF150 File Offset: 0x003AD350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillNotify(SkillNotify other) : this()
		{
			this.useSkillInfo_ = ((other.useSkillInfo_ != null) ? other.useSkillInfo_.Clone() : null);
			this.skillNodeInfos_ = ((other.skillNodeInfos_ != null) ? other.skillNodeInfos_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019414 RID: 103444 RVA: 0x003AF1AC File Offset: 0x003AD3AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillNotify Clone()
		{
			return new SkillNotify(this);
		}

		// Token: 0x1700556C RID: 21868
		// (get) Token: 0x06019415 RID: 103445 RVA: 0x003AF1B4 File Offset: 0x003AD3B4
		// (set) Token: 0x06019416 RID: 103446 RVA: 0x003AF1BC File Offset: 0x003AD3BC
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

		// Token: 0x1700556D RID: 21869
		// (get) Token: 0x06019417 RID: 103447 RVA: 0x003AF1C5 File Offset: 0x003AD3C5
		// (set) Token: 0x06019418 RID: 103448 RVA: 0x003AF1CD File Offset: 0x003AD3CD
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

		// Token: 0x06019419 RID: 103449 RVA: 0x003AF1D6 File Offset: 0x003AD3D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SkillNotify);
		}

		// Token: 0x0601941A RID: 103450 RVA: 0x003AF1E4 File Offset: 0x003AD3E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SkillNotify other)
		{
			return other != null && (other == this || (object.Equals(this.UseSkillInfo, other.UseSkillInfo) && object.Equals(this.SkillNodeInfos, other.SkillNodeInfos) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601941B RID: 103451 RVA: 0x003AF238 File Offset: 0x003AD438
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

		// Token: 0x0601941C RID: 103452 RVA: 0x003AF28A File Offset: 0x003AD48A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601941D RID: 103453 RVA: 0x003AF297 File Offset: 0x003AD497
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601941E RID: 103454 RVA: 0x003AF2A0 File Offset: 0x003AD4A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.skillNodeInfos_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.SkillNodeInfos);
			}
			if (this.useSkillInfo_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.UseSkillInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601941F RID: 103455 RVA: 0x003AF2FC File Offset: 0x003AD4FC
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

		// Token: 0x06019420 RID: 103456 RVA: 0x003AF354 File Offset: 0x003AD554
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

		// Token: 0x06019421 RID: 103457 RVA: 0x003AF3D4 File Offset: 0x003AD5D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019422 RID: 103458 RVA: 0x003AF3E0 File Offset: 0x003AD5E0
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
				if (num != 50U)
				{
					if (num != 58U)
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

		// Token: 0x0400957E RID: 38270
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400957F RID: 38271
		public const int UseSkillInfoFieldNumber = 7;

		// Token: 0x04009580 RID: 38272
		private UseSkillInformation useSkillInfo_;

		// Token: 0x04009581 RID: 38273
		public const int SkillNodeInfosFieldNumber = 6;

		// Token: 0x04009582 RID: 38274
		private SkillNodeInfo skillNodeInfos_;
	}
}
