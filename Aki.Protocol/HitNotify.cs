using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000740 RID: 1856
	[NetMessage(EMessageId.HitNotify)]
	public sealed class HitNotify : IMessage<HitNotify>, IMessage, IEquatable<HitNotify>, IDeepCloneable<HitNotify>, IBufferMessage
	{
		// Token: 0x0600A88C RID: 43148 RVA: 0x00196196 File Offset: 0x00194396
		[NullableContext(1)]
		public static HitNotify Create()
		{
			return new HitNotify();
		}

		// Token: 0x170021E9 RID: 8681
		// (get) Token: 0x0600A88D RID: 43149 RVA: 0x0019619D File Offset: 0x0019439D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170021EA RID: 8682
		// (get) Token: 0x0600A88E RID: 43150 RVA: 0x001961A0 File Offset: 0x001943A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HitNotify.Descriptor;
			}
		}

		// Token: 0x0600A88F RID: 43151 RVA: 0x001961A7 File Offset: 0x001943A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HitNotify()
		{
		}

		// Token: 0x0600A890 RID: 43152 RVA: 0x001961B0 File Offset: 0x001943B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HitNotify(HitNotify other) : this()
		{
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this.hitInfo_ = ((other.hitInfo_ != null) ? other.hitInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A891 RID: 43153 RVA: 0x0019620C File Offset: 0x0019440C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HitNotify Clone()
		{
			return new HitNotify(this);
		}

		// Token: 0x170021EB RID: 8683
		// (get) Token: 0x0600A892 RID: 43154 RVA: 0x00196214 File Offset: 0x00194414
		// (set) Token: 0x0600A893 RID: 43155 RVA: 0x0019621C File Offset: 0x0019441C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatCommon CombatCommon
		{
			get
			{
				return this.combatCommon_;
			}
			set
			{
				this.combatCommon_ = value;
			}
		}

		// Token: 0x170021EC RID: 8684
		// (get) Token: 0x0600A894 RID: 43156 RVA: 0x00196225 File Offset: 0x00194425
		// (set) Token: 0x0600A895 RID: 43157 RVA: 0x0019622D File Offset: 0x0019442D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HitInformation HitInfo
		{
			get
			{
				return this.hitInfo_;
			}
			set
			{
				this.hitInfo_ = value;
			}
		}

		// Token: 0x0600A896 RID: 43158 RVA: 0x00196236 File Offset: 0x00194436
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HitNotify);
		}

		// Token: 0x0600A897 RID: 43159 RVA: 0x00196244 File Offset: 0x00194444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HitNotify other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && object.Equals(this.HitInfo, other.HitInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A898 RID: 43160 RVA: 0x00196298 File Offset: 0x00194498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.combatCommon_ != null)
			{
				num ^= this.CombatCommon.GetHashCode();
			}
			if (this.hitInfo_ != null)
			{
				num ^= this.HitInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A899 RID: 43161 RVA: 0x001962EA File Offset: 0x001944EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A89A RID: 43162 RVA: 0x001962F7 File Offset: 0x001944F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A89B RID: 43163 RVA: 0x00196300 File Offset: 0x00194500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.hitInfo_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.HitInfo);
			}
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.CombatCommon);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A89C RID: 43164 RVA: 0x0019635C File Offset: 0x0019455C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.combatCommon_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CombatCommon);
			}
			if (this.hitInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HitInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A89D RID: 43165 RVA: 0x001963B4 File Offset: 0x001945B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HitNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.combatCommon_ != null)
			{
				if (this.combatCommon_ == null)
				{
					this.CombatCommon = new CombatCommon();
				}
				this.CombatCommon.MergeFrom(other.CombatCommon);
			}
			if (other.hitInfo_ != null)
			{
				if (this.hitInfo_ == null)
				{
					this.HitInfo = new HitInformation();
				}
				this.HitInfo.MergeFrom(other.HitInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A89E RID: 43166 RVA: 0x00196434 File Offset: 0x00194634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A89F RID: 43167 RVA: 0x00196440 File Offset: 0x00194640
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
				if (num != 74U)
				{
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.combatCommon_ == null)
						{
							this.CombatCommon = new CombatCommon();
						}
						input.ReadMessage(this.CombatCommon);
					}
				}
				else
				{
					if (this.hitInfo_ == null)
					{
						this.HitInfo = new HitInformation();
					}
					input.ReadMessage(this.HitInfo);
				}
			}
		}

		// Token: 0x04004D47 RID: 19783
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D48 RID: 19784
		public const int CombatCommonFieldNumber = 13;

		// Token: 0x04004D49 RID: 19785
		private CombatCommon combatCommon_;

		// Token: 0x04004D4A RID: 19786
		public const int HitInfoFieldNumber = 9;

		// Token: 0x04004D4B RID: 19787
		private HitInformation hitInfo_;
	}
}
