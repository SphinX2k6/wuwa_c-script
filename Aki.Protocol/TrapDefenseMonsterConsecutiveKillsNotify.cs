using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014A3 RID: 5283
	[NetMessage(EMessageId.TrapDefenseMonsterConsecutiveKillsNotify)]
	public sealed class TrapDefenseMonsterConsecutiveKillsNotify : IMessage<TrapDefenseMonsterConsecutiveKillsNotify>, IMessage, IEquatable<TrapDefenseMonsterConsecutiveKillsNotify>, IDeepCloneable<TrapDefenseMonsterConsecutiveKillsNotify>, IBufferMessage
	{
		// Token: 0x0601C0A0 RID: 114848 RVA: 0x004123D2 File Offset: 0x004105D2
		[NullableContext(1)]
		public static TrapDefenseMonsterConsecutiveKillsNotify Create()
		{
			return new TrapDefenseMonsterConsecutiveKillsNotify();
		}

		// Token: 0x17005EE8 RID: 24296
		// (get) Token: 0x0601C0A1 RID: 114849 RVA: 0x004123D9 File Offset: 0x004105D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005EE9 RID: 24297
		// (get) Token: 0x0601C0A2 RID: 114850 RVA: 0x004123DC File Offset: 0x004105DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseMonsterConsecutiveKillsNotify.Descriptor;
			}
		}

		// Token: 0x0601C0A3 RID: 114851 RVA: 0x004123E3 File Offset: 0x004105E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseMonsterConsecutiveKillsNotify()
		{
		}

		// Token: 0x0601C0A4 RID: 114852 RVA: 0x004123EB File Offset: 0x004105EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseMonsterConsecutiveKillsNotify(TrapDefenseMonsterConsecutiveKillsNotify other) : this()
		{
			this.consecutiveKillCount_ = other.consecutiveKillCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C0A5 RID: 114853 RVA: 0x00412410 File Offset: 0x00410610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseMonsterConsecutiveKillsNotify Clone()
		{
			return new TrapDefenseMonsterConsecutiveKillsNotify(this);
		}

		// Token: 0x17005EEA RID: 24298
		// (get) Token: 0x0601C0A6 RID: 114854 RVA: 0x00412418 File Offset: 0x00410618
		// (set) Token: 0x0601C0A7 RID: 114855 RVA: 0x00412420 File Offset: 0x00410620
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

		// Token: 0x0601C0A8 RID: 114856 RVA: 0x00412429 File Offset: 0x00410629
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseMonsterConsecutiveKillsNotify);
		}

		// Token: 0x0601C0A9 RID: 114857 RVA: 0x00412437 File Offset: 0x00410637
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseMonsterConsecutiveKillsNotify other)
		{
			return other != null && (other == this || (this.ConsecutiveKillCount == other.ConsecutiveKillCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C0AA RID: 114858 RVA: 0x00412468 File Offset: 0x00410668
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

		// Token: 0x0601C0AB RID: 114859 RVA: 0x004124A7 File Offset: 0x004106A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C0AC RID: 114860 RVA: 0x004124B4 File Offset: 0x004106B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C0AD RID: 114861 RVA: 0x004124BD File Offset: 0x004106BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConsecutiveKillCount != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ConsecutiveKillCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C0AE RID: 114862 RVA: 0x004124F0 File Offset: 0x004106F0
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

		// Token: 0x0601C0AF RID: 114863 RVA: 0x0041252E File Offset: 0x0041072E
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

		// Token: 0x0601C0B0 RID: 114864 RVA: 0x0041255F File Offset: 0x0041075F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C0B1 RID: 114865 RVA: 0x00412568 File Offset: 0x00410768
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ConsecutiveKillCount = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A25B RID: 41563
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A25C RID: 41564
		public const int ConsecutiveKillCountFieldNumber = 14;

		// Token: 0x0400A25D RID: 41565
		private int consecutiveKillCount_;
	}
}
