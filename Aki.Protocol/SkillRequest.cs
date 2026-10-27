using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200123F RID: 4671
	[NetMessage(EMessageId.SkillRequest)]
	public sealed class SkillRequest : IMessage<SkillRequest>, IMessage, IEquatable<SkillRequest>, IDeepCloneable<SkillRequest>, IBufferMessage
	{
		// Token: 0x06018E55 RID: 101973 RVA: 0x0039FA3C File Offset: 0x0039DC3C
		[NullableContext(1)]
		public static SkillRequest Create()
		{
			return new SkillRequest();
		}

		// Token: 0x170053F7 RID: 21495
		// (get) Token: 0x06018E56 RID: 101974 RVA: 0x0039FA43 File Offset: 0x0039DC43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170053F8 RID: 21496
		// (get) Token: 0x06018E57 RID: 101975 RVA: 0x0039FA46 File Offset: 0x0039DC46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SkillRequest.Descriptor;
			}
		}

		// Token: 0x06018E58 RID: 101976 RVA: 0x0039FA4D File Offset: 0x0039DC4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillRequest()
		{
		}

		// Token: 0x06018E59 RID: 101977 RVA: 0x0039FA58 File Offset: 0x0039DC58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillRequest(SkillRequest other) : this()
		{
			this.useSkillInfo_ = ((other.useSkillInfo_ != null) ? other.useSkillInfo_.Clone() : null);
			this.skillNodeInfos_ = ((other.skillNodeInfos_ != null) ? other.skillNodeInfos_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018E5A RID: 101978 RVA: 0x0039FAB4 File Offset: 0x0039DCB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillRequest Clone()
		{
			return new SkillRequest(this);
		}

		// Token: 0x170053F9 RID: 21497
		// (get) Token: 0x06018E5B RID: 101979 RVA: 0x0039FABC File Offset: 0x0039DCBC
		// (set) Token: 0x06018E5C RID: 101980 RVA: 0x0039FAC4 File Offset: 0x0039DCC4
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

		// Token: 0x170053FA RID: 21498
		// (get) Token: 0x06018E5D RID: 101981 RVA: 0x0039FACD File Offset: 0x0039DCCD
		// (set) Token: 0x06018E5E RID: 101982 RVA: 0x0039FAD5 File Offset: 0x0039DCD5
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

		// Token: 0x06018E5F RID: 101983 RVA: 0x0039FADE File Offset: 0x0039DCDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SkillRequest);
		}

		// Token: 0x06018E60 RID: 101984 RVA: 0x0039FAEC File Offset: 0x0039DCEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SkillRequest other)
		{
			return other != null && (other == this || (object.Equals(this.UseSkillInfo, other.UseSkillInfo) && object.Equals(this.SkillNodeInfos, other.SkillNodeInfos) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018E61 RID: 101985 RVA: 0x0039FB40 File Offset: 0x0039DD40
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

		// Token: 0x06018E62 RID: 101986 RVA: 0x0039FB92 File Offset: 0x0039DD92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018E63 RID: 101987 RVA: 0x0039FB9F File Offset: 0x0039DD9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018E64 RID: 101988 RVA: 0x0039FBA8 File Offset: 0x0039DDA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.skillNodeInfos_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.SkillNodeInfos);
			}
			if (this.useSkillInfo_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.UseSkillInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018E65 RID: 101989 RVA: 0x0039FC04 File Offset: 0x0039DE04
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

		// Token: 0x06018E66 RID: 101990 RVA: 0x0039FC5C File Offset: 0x0039DE5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SkillRequest other)
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

		// Token: 0x06018E67 RID: 101991 RVA: 0x0039FCDC File Offset: 0x0039DEDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018E68 RID: 101992 RVA: 0x0039FCE8 File Offset: 0x0039DEE8
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
				if (num != 58U)
				{
					if (num != 98U)
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

		// Token: 0x040092DE RID: 37598
		private UnknownFieldSet _unknownFields;

		// Token: 0x040092DF RID: 37599
		public const int UseSkillInfoFieldNumber = 12;

		// Token: 0x040092E0 RID: 37600
		private UseSkillInformation useSkillInfo_;

		// Token: 0x040092E1 RID: 37601
		public const int SkillNodeInfosFieldNumber = 7;

		// Token: 0x040092E2 RID: 37602
		private SkillNodeInfo skillNodeInfos_;
	}
}
