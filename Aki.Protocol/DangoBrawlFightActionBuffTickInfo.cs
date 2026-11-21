using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000352 RID: 850
	public sealed class DangoBrawlFightActionBuffTickInfo : IMessage<DangoBrawlFightActionBuffTickInfo>, IMessage, IEquatable<DangoBrawlFightActionBuffTickInfo>, IDeepCloneable<DangoBrawlFightActionBuffTickInfo>, IBufferMessage
	{
		// Token: 0x06005526 RID: 21798 RVA: 0x000CFB16 File Offset: 0x000CDD16
		[NullableContext(1)]
		public static DangoBrawlFightActionBuffTickInfo Create()
		{
			return new DangoBrawlFightActionBuffTickInfo();
		}

		// Token: 0x17000F85 RID: 3973
		// (get) Token: 0x06005527 RID: 21799 RVA: 0x000CFB1D File Offset: 0x000CDD1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F86 RID: 3974
		// (get) Token: 0x06005528 RID: 21800 RVA: 0x000CFB20 File Offset: 0x000CDD20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlFightActionBuffTickInfo.Descriptor;
			}
		}

		// Token: 0x06005529 RID: 21801 RVA: 0x000CFB27 File Offset: 0x000CDD27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionBuffTickInfo()
		{
		}

		// Token: 0x0600552A RID: 21802 RVA: 0x000CFB30 File Offset: 0x000CDD30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionBuffTickInfo(DangoBrawlFightActionBuffTickInfo other) : this()
		{
			this.buffUId_ = other.buffUId_;
			this.damageInfo_ = ((other.damageInfo_ != null) ? other.damageInfo_.Clone() : null);
			this.nextReadyMs_ = other.nextReadyMs_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600552B RID: 21803 RVA: 0x000CFB88 File Offset: 0x000CDD88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionBuffTickInfo Clone()
		{
			return new DangoBrawlFightActionBuffTickInfo(this);
		}

		// Token: 0x17000F87 RID: 3975
		// (get) Token: 0x0600552C RID: 21804 RVA: 0x000CFB90 File Offset: 0x000CDD90
		// (set) Token: 0x0600552D RID: 21805 RVA: 0x000CFB98 File Offset: 0x000CDD98
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

		// Token: 0x17000F88 RID: 3976
		// (get) Token: 0x0600552E RID: 21806 RVA: 0x000CFBA1 File Offset: 0x000CDDA1
		// (set) Token: 0x0600552F RID: 21807 RVA: 0x000CFBA9 File Offset: 0x000CDDA9
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

		// Token: 0x17000F89 RID: 3977
		// (get) Token: 0x06005530 RID: 21808 RVA: 0x000CFBB2 File Offset: 0x000CDDB2
		// (set) Token: 0x06005531 RID: 21809 RVA: 0x000CFBBA File Offset: 0x000CDDBA
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

		// Token: 0x06005532 RID: 21810 RVA: 0x000CFBC3 File Offset: 0x000CDDC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlFightActionBuffTickInfo);
		}

		// Token: 0x06005533 RID: 21811 RVA: 0x000CFBD4 File Offset: 0x000CDDD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlFightActionBuffTickInfo other)
		{
			return other != null && (other == this || (this.BuffUId == other.BuffUId && object.Equals(this.DamageInfo, other.DamageInfo) && this.NextReadyMs == other.NextReadyMs && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005534 RID: 21812 RVA: 0x000CFC34 File Offset: 0x000CDE34
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

		// Token: 0x06005535 RID: 21813 RVA: 0x000CFCA2 File Offset: 0x000CDEA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005536 RID: 21814 RVA: 0x000CFCAF File Offset: 0x000CDEAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005537 RID: 21815 RVA: 0x000CFCB8 File Offset: 0x000CDEB8
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

		// Token: 0x06005538 RID: 21816 RVA: 0x000CFD2C File Offset: 0x000CDF2C
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

		// Token: 0x06005539 RID: 21817 RVA: 0x000CFD9C File Offset: 0x000CDF9C
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

		// Token: 0x0600553A RID: 21818 RVA: 0x000CFE18 File Offset: 0x000CE018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600553B RID: 21819 RVA: 0x000CFE24 File Offset: 0x000CE024
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

		// Token: 0x04003458 RID: 13400
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003459 RID: 13401
		public const int BuffUIdFieldNumber = 1;

		// Token: 0x0400345A RID: 13402
		private int buffUId_;

		// Token: 0x0400345B RID: 13403
		public const int DamageInfoFieldNumber = 2;

		// Token: 0x0400345C RID: 13404
		private DangoBrawlDamageInfo damageInfo_;

		// Token: 0x0400345D RID: 13405
		public const int NextReadyMsFieldNumber = 3;

		// Token: 0x0400345E RID: 13406
		private int nextReadyMs_;
	}
}
