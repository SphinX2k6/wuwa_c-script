using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001430 RID: 5168
	[NetMessage(EMessageId.TrapDefenseMonsterConsecutiveKillsNotify)]
	public sealed class TrapDefenseMonsterConsecutiveKillsNotify : IMessage<TrapDefenseMonsterConsecutiveKillsNotify>, IMessage, IEquatable<TrapDefenseMonsterConsecutiveKillsNotify>, IDeepCloneable<TrapDefenseMonsterConsecutiveKillsNotify>, IBufferMessage
	{
		// Token: 0x0601B615 RID: 112149 RVA: 0x003F70FE File Offset: 0x003F52FE
		[NullableContext(1)]
		public static TrapDefenseMonsterConsecutiveKillsNotify Create()
		{
			return new TrapDefenseMonsterConsecutiveKillsNotify();
		}

		// Token: 0x17005C53 RID: 23635
		// (get) Token: 0x0601B616 RID: 112150 RVA: 0x003F7105 File Offset: 0x003F5305
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C54 RID: 23636
		// (get) Token: 0x0601B617 RID: 112151 RVA: 0x003F7108 File Offset: 0x003F5308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseMonsterConsecutiveKillsNotify.Descriptor;
			}
		}

		// Token: 0x0601B618 RID: 112152 RVA: 0x003F710F File Offset: 0x003F530F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseMonsterConsecutiveKillsNotify()
		{
		}

		// Token: 0x0601B619 RID: 112153 RVA: 0x003F7117 File Offset: 0x003F5317
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseMonsterConsecutiveKillsNotify(TrapDefenseMonsterConsecutiveKillsNotify other) : this()
		{
			this.consecutiveKillCount_ = other.consecutiveKillCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B61A RID: 112154 RVA: 0x003F713C File Offset: 0x003F533C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseMonsterConsecutiveKillsNotify Clone()
		{
			return new TrapDefenseMonsterConsecutiveKillsNotify(this);
		}

		// Token: 0x17005C55 RID: 23637
		// (get) Token: 0x0601B61B RID: 112155 RVA: 0x003F7144 File Offset: 0x003F5344
		// (set) Token: 0x0601B61C RID: 112156 RVA: 0x003F714C File Offset: 0x003F534C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConsecutiveKillCount
		{
			get
			{
				return this.consecutiveKillCount_;
			}
			set
			{
				this.consecutiveKillCount_ = value;
			}
		}

		// Token: 0x0601B61D RID: 112157 RVA: 0x003F7155 File Offset: 0x003F5355
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseMonsterConsecutiveKillsNotify);
		}

		// Token: 0x0601B61E RID: 112158 RVA: 0x003F7163 File Offset: 0x003F5363
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseMonsterConsecutiveKillsNotify other)
		{
			return other != null && (other == this || (this.ConsecutiveKillCount == other.ConsecutiveKillCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B61F RID: 112159 RVA: 0x003F7194 File Offset: 0x003F5394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConsecutiveKillCount != 0)
			{
				num ^= this.ConsecutiveKillCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B620 RID: 112160 RVA: 0x003F71D3 File Offset: 0x003F53D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B621 RID: 112161 RVA: 0x003F71E0 File Offset: 0x003F53E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B622 RID: 112162 RVA: 0x003F71E9 File Offset: 0x003F53E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConsecutiveKillCount != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ConsecutiveKillCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B623 RID: 112163 RVA: 0x003F721C File Offset: 0x003F541C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConsecutiveKillCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConsecutiveKillCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B624 RID: 112164 RVA: 0x003F725A File Offset: 0x003F545A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseMonsterConsecutiveKillsNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConsecutiveKillCount != 0)
			{
				this.ConsecutiveKillCount = other.ConsecutiveKillCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B625 RID: 112165 RVA: 0x003F728B File Offset: 0x003F548B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B626 RID: 112166 RVA: 0x003F7294 File Offset: 0x003F5494
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ConsecutiveKillCount = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009E14 RID: 40468
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009E15 RID: 40469
		public const int ConsecutiveKillCountFieldNumber = 3;

		// Token: 0x04009E16 RID: 40470
		private int consecutiveKillCount_;
	}
}
