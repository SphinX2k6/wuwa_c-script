using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000754 RID: 1876
	[NetMessage(EMessageId.HitNotify)]
	public sealed class HitNotify : IMessage<HitNotify>, IMessage, IEquatable<HitNotify>, IDeepCloneable<HitNotify>, IBufferMessage
	{
		// Token: 0x0600A9E2 RID: 43490 RVA: 0x00198BBE File Offset: 0x00196DBE
		[NullableContext(1)]
		public static HitNotify Create()
		{
			return new HitNotify();
		}

		// Token: 0x17002233 RID: 8755
		// (get) Token: 0x0600A9E3 RID: 43491 RVA: 0x00198BC5 File Offset: 0x00196DC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002234 RID: 8756
		// (get) Token: 0x0600A9E4 RID: 43492 RVA: 0x00198BC8 File Offset: 0x00196DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HitNotify.Descriptor;
			}
		}

		// Token: 0x0600A9E5 RID: 43493 RVA: 0x00198BCF File Offset: 0x00196DCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HitNotify()
		{
		}

		// Token: 0x0600A9E6 RID: 43494 RVA: 0x00198BD8 File Offset: 0x00196DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HitNotify(HitNotify other) : this()
		{
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this.hitInfo_ = ((other.hitInfo_ != null) ? other.hitInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A9E7 RID: 43495 RVA: 0x00198C34 File Offset: 0x00196E34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HitNotify Clone()
		{
			return new HitNotify(this);
		}

		// Token: 0x17002235 RID: 8757
		// (get) Token: 0x0600A9E8 RID: 43496 RVA: 0x00198C3C File Offset: 0x00196E3C
		// (set) Token: 0x0600A9E9 RID: 43497 RVA: 0x00198C44 File Offset: 0x00196E44
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

		// Token: 0x17002236 RID: 8758
		// (get) Token: 0x0600A9EA RID: 43498 RVA: 0x00198C4D File Offset: 0x00196E4D
		// (set) Token: 0x0600A9EB RID: 43499 RVA: 0x00198C55 File Offset: 0x00196E55
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

		// Token: 0x0600A9EC RID: 43500 RVA: 0x00198C5E File Offset: 0x00196E5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HitNotify);
		}

		// Token: 0x0600A9ED RID: 43501 RVA: 0x00198C6C File Offset: 0x00196E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HitNotify other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && object.Equals(this.HitInfo, other.HitInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A9EE RID: 43502 RVA: 0x00198CC0 File Offset: 0x00196EC0
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

		// Token: 0x0600A9EF RID: 43503 RVA: 0x00198D12 File Offset: 0x00196F12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A9F0 RID: 43504 RVA: 0x00198D1F File Offset: 0x00196F1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A9F1 RID: 43505 RVA: 0x00198D28 File Offset: 0x00196F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.CombatCommon);
			}
			if (this.hitInfo_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.HitInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A9F2 RID: 43506 RVA: 0x00198D84 File Offset: 0x00196F84
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

		// Token: 0x0600A9F3 RID: 43507 RVA: 0x00198DDC File Offset: 0x00196FDC
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

		// Token: 0x0600A9F4 RID: 43508 RVA: 0x00198E5C File Offset: 0x0019705C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A9F5 RID: 43509 RVA: 0x00198E68 File Offset: 0x00197068
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
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					if (this.combatCommon_ == null)
					{
						this.CombatCommon = new CombatCommon();
					}
					input.ReadMessage(this.CombatCommon);
				}
			}
		}

		// Token: 0x04004D4E RID: 19790
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D4F RID: 19791
		public const int CombatCommonFieldNumber = 3;

		// Token: 0x04004D50 RID: 19792
		private CombatCommon combatCommon_;

		// Token: 0x04004D51 RID: 19793
		public const int HitInfoFieldNumber = 11;

		// Token: 0x04004D52 RID: 19794
		private HitInformation hitInfo_;
	}
}
