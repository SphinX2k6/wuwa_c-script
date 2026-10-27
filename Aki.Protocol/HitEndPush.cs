using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000750 RID: 1872
	[NetMessage(EMessageId.HitEndPush)]
	public sealed class HitEndPush : IMessage<HitEndPush>, IMessage, IEquatable<HitEndPush>, IDeepCloneable<HitEndPush>, IBufferMessage
	{
		// Token: 0x0600A96E RID: 43374 RVA: 0x001973BA File Offset: 0x001955BA
		[NullableContext(1)]
		public static HitEndPush Create()
		{
			return new HitEndPush();
		}

		// Token: 0x17002211 RID: 8721
		// (get) Token: 0x0600A96F RID: 43375 RVA: 0x001973C1 File Offset: 0x001955C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002212 RID: 8722
		// (get) Token: 0x0600A970 RID: 43376 RVA: 0x001973C4 File Offset: 0x001955C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HitEndPush.Descriptor;
			}
		}

		// Token: 0x0600A971 RID: 43377 RVA: 0x001973CB File Offset: 0x001955CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HitEndPush()
		{
		}

		// Token: 0x0600A972 RID: 43378 RVA: 0x001973D4 File Offset: 0x001955D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HitEndPush(HitEndPush other) : this()
		{
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this.targetId_ = other.targetId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A973 RID: 43379 RVA: 0x00197420 File Offset: 0x00195620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HitEndPush Clone()
		{
			return new HitEndPush(this);
		}

		// Token: 0x17002213 RID: 8723
		// (get) Token: 0x0600A974 RID: 43380 RVA: 0x00197428 File Offset: 0x00195628
		// (set) Token: 0x0600A975 RID: 43381 RVA: 0x00197430 File Offset: 0x00195630
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

		// Token: 0x17002214 RID: 8724
		// (get) Token: 0x0600A976 RID: 43382 RVA: 0x00197439 File Offset: 0x00195639
		// (set) Token: 0x0600A977 RID: 43383 RVA: 0x00197441 File Offset: 0x00195641
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TargetId
		{
			get
			{
				return this.targetId_;
			}
			set
			{
				this.targetId_ = value;
			}
		}

		// Token: 0x0600A978 RID: 43384 RVA: 0x0019744A File Offset: 0x0019564A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HitEndPush);
		}

		// Token: 0x0600A979 RID: 43385 RVA: 0x00197458 File Offset: 0x00195658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HitEndPush other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && this.TargetId == other.TargetId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A97A RID: 43386 RVA: 0x001974A8 File Offset: 0x001956A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.combatCommon_ != null)
			{
				num ^= this.CombatCommon.GetHashCode();
			}
			if (this.TargetId != 0L)
			{
				num ^= this.TargetId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A97B RID: 43387 RVA: 0x001974FD File Offset: 0x001956FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A97C RID: 43388 RVA: 0x0019750A File Offset: 0x0019570A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A97D RID: 43389 RVA: 0x00197514 File Offset: 0x00195714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetId != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.TargetId);
			}
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.CombatCommon);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A97E RID: 43390 RVA: 0x00197570 File Offset: 0x00195770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.combatCommon_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CombatCommon);
			}
			if (this.TargetId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TargetId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A97F RID: 43391 RVA: 0x001975C8 File Offset: 0x001957C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HitEndPush other)
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
			if (other.TargetId != 0L)
			{
				this.TargetId = other.TargetId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A980 RID: 43392 RVA: 0x00197630 File Offset: 0x00195830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A981 RID: 43393 RVA: 0x0019763C File Offset: 0x0019583C
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
				if (num != 104U)
				{
					if (num != 114U)
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
					this.TargetId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04004D16 RID: 19734
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D17 RID: 19735
		public const int CombatCommonFieldNumber = 14;

		// Token: 0x04004D18 RID: 19736
		private CombatCommon combatCommon_;

		// Token: 0x04004D19 RID: 19737
		public const int TargetIdFieldNumber = 13;

		// Token: 0x04004D1A RID: 19738
		private long targetId_;
	}
}
