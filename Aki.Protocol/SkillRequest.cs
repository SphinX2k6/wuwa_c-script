using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200127C RID: 4732
	[NetMessage(EMessageId.SkillRequest)]
	public sealed class SkillRequest : IMessage<SkillRequest>, IMessage, IEquatable<SkillRequest>, IDeepCloneable<SkillRequest>, IBufferMessage
	{
		// Token: 0x0601943F RID: 103487 RVA: 0x003AF99C File Offset: 0x003ADB9C
		[NullableContext(1)]
		public static SkillRequest Create()
		{
			return new SkillRequest();
		}

		// Token: 0x17005576 RID: 21878
		// (get) Token: 0x06019440 RID: 103488 RVA: 0x003AF9A3 File Offset: 0x003ADBA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005577 RID: 21879
		// (get) Token: 0x06019441 RID: 103489 RVA: 0x003AF9A6 File Offset: 0x003ADBA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SkillRequest.Descriptor;
			}
		}

		// Token: 0x06019442 RID: 103490 RVA: 0x003AF9AD File Offset: 0x003ADBAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillRequest()
		{
		}

		// Token: 0x06019443 RID: 103491 RVA: 0x003AF9B8 File Offset: 0x003ADBB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillRequest(SkillRequest other) : this()
		{
			this.useSkillInfo_ = ((other.useSkillInfo_ != null) ? other.useSkillInfo_.Clone() : null);
			this.skillNodeInfos_ = ((other.skillNodeInfos_ != null) ? other.skillNodeInfos_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019444 RID: 103492 RVA: 0x003AFA14 File Offset: 0x003ADC14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillRequest Clone()
		{
			return new SkillRequest(this);
		}

		// Token: 0x17005578 RID: 21880
		// (get) Token: 0x06019445 RID: 103493 RVA: 0x003AFA1C File Offset: 0x003ADC1C
		// (set) Token: 0x06019446 RID: 103494 RVA: 0x003AFA24 File Offset: 0x003ADC24
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

		// Token: 0x17005579 RID: 21881
		// (get) Token: 0x06019447 RID: 103495 RVA: 0x003AFA2D File Offset: 0x003ADC2D
		// (set) Token: 0x06019448 RID: 103496 RVA: 0x003AFA35 File Offset: 0x003ADC35
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

		// Token: 0x06019449 RID: 103497 RVA: 0x003AFA3E File Offset: 0x003ADC3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SkillRequest);
		}

		// Token: 0x0601944A RID: 103498 RVA: 0x003AFA4C File Offset: 0x003ADC4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SkillRequest other)
		{
			return other != null && (other == this || (object.Equals(this.UseSkillInfo, other.UseSkillInfo) && object.Equals(this.SkillNodeInfos, other.SkillNodeInfos) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601944B RID: 103499 RVA: 0x003AFAA0 File Offset: 0x003ADCA0
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

		// Token: 0x0601944C RID: 103500 RVA: 0x003AFAF2 File Offset: 0x003ADCF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601944D RID: 103501 RVA: 0x003AFAFF File Offset: 0x003ADCFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601944E RID: 103502 RVA: 0x003AFB08 File Offset: 0x003ADD08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.skillNodeInfos_ != null)
			{
				output.WriteRawTag(26);
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

		// Token: 0x0601944F RID: 103503 RVA: 0x003AFB64 File Offset: 0x003ADD64
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

		// Token: 0x06019450 RID: 103504 RVA: 0x003AFBBC File Offset: 0x003ADDBC
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

		// Token: 0x06019451 RID: 103505 RVA: 0x003AFC3C File Offset: 0x003ADE3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019452 RID: 103506 RVA: 0x003AFC48 File Offset: 0x003ADE48
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

		// Token: 0x04009590 RID: 38288
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009591 RID: 38289
		public const int UseSkillInfoFieldNumber = 12;

		// Token: 0x04009592 RID: 38290
		private UseSkillInformation useSkillInfo_;

		// Token: 0x04009593 RID: 38291
		public const int SkillNodeInfosFieldNumber = 3;

		// Token: 0x04009594 RID: 38292
		private SkillNodeInfo skillNodeInfos_;
	}
}
