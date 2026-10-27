using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200034A RID: 842
	public sealed class DangoBrawlFightActionBuffTickInfo : IMessage<DangoBrawlFightActionBuffTickInfo>, IMessage, IEquatable<DangoBrawlFightActionBuffTickInfo>, IDeepCloneable<DangoBrawlFightActionBuffTickInfo>, IBufferMessage
	{
		// Token: 0x06005439 RID: 21561 RVA: 0x000CD48A File Offset: 0x000CB68A
		[NullableContext(1)]
		public static DangoBrawlFightActionBuffTickInfo Create()
		{
			return new DangoBrawlFightActionBuffTickInfo();
		}

		// Token: 0x17000F54 RID: 3924
		// (get) Token: 0x0600543A RID: 21562 RVA: 0x000CD491 File Offset: 0x000CB691
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F55 RID: 3925
		// (get) Token: 0x0600543B RID: 21563 RVA: 0x000CD494 File Offset: 0x000CB694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlFightActionBuffTickInfo.Descriptor;
			}
		}

		// Token: 0x0600543C RID: 21564 RVA: 0x000CD49B File Offset: 0x000CB69B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionBuffTickInfo()
		{
		}

		// Token: 0x0600543D RID: 21565 RVA: 0x000CD4A4 File Offset: 0x000CB6A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionBuffTickInfo(DangoBrawlFightActionBuffTickInfo other) : this()
		{
			this.buffUId_ = other.buffUId_;
			this.damageInfo_ = ((other.damageInfo_ != null) ? other.damageInfo_.Clone() : null);
			this.nextReadyMs_ = other.nextReadyMs_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600543E RID: 21566 RVA: 0x000CD4FC File Offset: 0x000CB6FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionBuffTickInfo Clone()
		{
			return new DangoBrawlFightActionBuffTickInfo(this);
		}

		// Token: 0x17000F56 RID: 3926
		// (get) Token: 0x0600543F RID: 21567 RVA: 0x000CD504 File Offset: 0x000CB704
		// (set) Token: 0x06005440 RID: 21568 RVA: 0x000CD50C File Offset: 0x000CB70C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BuffUId
		{
			get
			{
				return this.buffUId_;
			}
			set
			{
				this.buffUId_ = value;
			}
		}

		// Token: 0x17000F57 RID: 3927
		// (get) Token: 0x06005441 RID: 21569 RVA: 0x000CD515 File Offset: 0x000CB715
		// (set) Token: 0x06005442 RID: 21570 RVA: 0x000CD51D File Offset: 0x000CB71D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlDamageInfo DamageInfo
		{
			get
			{
				return this.damageInfo_;
			}
			set
			{
				this.damageInfo_ = value;
			}
		}

		// Token: 0x17000F58 RID: 3928
		// (get) Token: 0x06005443 RID: 21571 RVA: 0x000CD526 File Offset: 0x000CB726
		// (set) Token: 0x06005444 RID: 21572 RVA: 0x000CD52E File Offset: 0x000CB72E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NextReadyMs
		{
			get
			{
				return this.nextReadyMs_;
			}
			set
			{
				this.nextReadyMs_ = value;
			}
		}

		// Token: 0x06005445 RID: 21573 RVA: 0x000CD537 File Offset: 0x000CB737
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlFightActionBuffTickInfo);
		}

		// Token: 0x06005446 RID: 21574 RVA: 0x000CD548 File Offset: 0x000CB748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlFightActionBuffTickInfo other)
		{
			return other != null && (other == this || (this.BuffUId == other.BuffUId && object.Equals(this.DamageInfo, other.DamageInfo) && this.NextReadyMs == other.NextReadyMs && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005447 RID: 21575 RVA: 0x000CD5A8 File Offset: 0x000CB7A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BuffUId != 0)
			{
				num ^= this.BuffUId.GetHashCode();
			}
			if (this.damageInfo_ != null)
			{
				num ^= this.DamageInfo.GetHashCode();
			}
			if (this.NextReadyMs != 0)
			{
				num ^= this.NextReadyMs.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005448 RID: 21576 RVA: 0x000CD616 File Offset: 0x000CB816
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005449 RID: 21577 RVA: 0x000CD623 File Offset: 0x000CB823
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600544A RID: 21578 RVA: 0x000CD62C File Offset: 0x000CB82C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BuffUId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.BuffUId);
			}
			if (this.damageInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.DamageInfo);
			}
			if (this.NextReadyMs != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.NextReadyMs);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600544B RID: 21579 RVA: 0x000CD6A0 File Offset: 0x000CB8A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BuffUId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BuffUId);
			}
			if (this.damageInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DamageInfo);
			}
			if (this.NextReadyMs != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NextReadyMs);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600544C RID: 21580 RVA: 0x000CD710 File Offset: 0x000CB910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlFightActionBuffTickInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BuffUId != 0)
			{
				this.BuffUId = other.BuffUId;
			}
			if (other.damageInfo_ != null)
			{
				if (this.damageInfo_ == null)
				{
					this.DamageInfo = new DangoBrawlDamageInfo();
				}
				this.DamageInfo.MergeFrom(other.DamageInfo);
			}
			if (other.NextReadyMs != 0)
			{
				this.NextReadyMs = other.NextReadyMs;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600544D RID: 21581 RVA: 0x000CD78C File Offset: 0x000CB98C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600544E RID: 21582 RVA: 0x000CD798 File Offset: 0x000CB998
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.NextReadyMs = input.ReadInt32();
						}
					}
					else
					{
						if (this.damageInfo_ == null)
						{
							this.DamageInfo = new DangoBrawlDamageInfo();
						}
						input.ReadMessage(this.DamageInfo);
					}
				}
				else
				{
					this.BuffUId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040033BC RID: 13244
		private UnknownFieldSet _unknownFields;

		// Token: 0x040033BD RID: 13245
		public const int BuffUIdFieldNumber = 1;

		// Token: 0x040033BE RID: 13246
		private int buffUId_;

		// Token: 0x040033BF RID: 13247
		public const int DamageInfoFieldNumber = 2;

		// Token: 0x040033C0 RID: 13248
		private DangoBrawlDamageInfo damageInfo_;

		// Token: 0x040033C1 RID: 13249
		public const int NextReadyMsFieldNumber = 3;

		// Token: 0x040033C2 RID: 13250
		private int nextReadyMs_;
	}
}
