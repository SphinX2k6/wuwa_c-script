using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012D0 RID: 4816
	[NetMessage(EMessageId.SurvivorsMonsterConsecutiveKillsNotify)]
	public sealed class SurvivorsMonsterConsecutiveKillsNotify : IMessage<SurvivorsMonsterConsecutiveKillsNotify>, IMessage, IEquatable<SurvivorsMonsterConsecutiveKillsNotify>, IDeepCloneable<SurvivorsMonsterConsecutiveKillsNotify>, IBufferMessage
	{
		// Token: 0x060199F9 RID: 104953 RVA: 0x003B9A1C File Offset: 0x003B7C1C
		[NullableContext(1)]
		public static SurvivorsMonsterConsecutiveKillsNotify Create()
		{
			return new SurvivorsMonsterConsecutiveKillsNotify();
		}

		// Token: 0x17005672 RID: 22130
		// (get) Token: 0x060199FA RID: 104954 RVA: 0x003B9A23 File Offset: 0x003B7C23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005673 RID: 22131
		// (get) Token: 0x060199FB RID: 104955 RVA: 0x003B9A26 File Offset: 0x003B7C26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsMonsterConsecutiveKillsNotify.Descriptor;
			}
		}

		// Token: 0x060199FC RID: 104956 RVA: 0x003B9A2D File Offset: 0x003B7C2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsMonsterConsecutiveKillsNotify()
		{
		}

		// Token: 0x060199FD RID: 104957 RVA: 0x003B9A35 File Offset: 0x003B7C35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsMonsterConsecutiveKillsNotify(SurvivorsMonsterConsecutiveKillsNotify other) : this()
		{
			this.consecutiveKillCount_ = other.consecutiveKillCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060199FE RID: 104958 RVA: 0x003B9A5A File Offset: 0x003B7C5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsMonsterConsecutiveKillsNotify Clone()
		{
			return new SurvivorsMonsterConsecutiveKillsNotify(this);
		}

		// Token: 0x17005674 RID: 22132
		// (get) Token: 0x060199FF RID: 104959 RVA: 0x003B9A62 File Offset: 0x003B7C62
		// (set) Token: 0x06019A00 RID: 104960 RVA: 0x003B9A6A File Offset: 0x003B7C6A
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

		// Token: 0x06019A01 RID: 104961 RVA: 0x003B9A73 File Offset: 0x003B7C73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsMonsterConsecutiveKillsNotify);
		}

		// Token: 0x06019A02 RID: 104962 RVA: 0x003B9A81 File Offset: 0x003B7C81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsMonsterConsecutiveKillsNotify other)
		{
			return other != null && (other == this || (this.ConsecutiveKillCount == other.ConsecutiveKillCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019A03 RID: 104963 RVA: 0x003B9AB0 File Offset: 0x003B7CB0
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

		// Token: 0x06019A04 RID: 104964 RVA: 0x003B9AEF File Offset: 0x003B7CEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019A05 RID: 104965 RVA: 0x003B9AFC File Offset: 0x003B7CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019A06 RID: 104966 RVA: 0x003B9B05 File Offset: 0x003B7D05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConsecutiveKillCount != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ConsecutiveKillCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019A07 RID: 104967 RVA: 0x003B9B38 File Offset: 0x003B7D38
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

		// Token: 0x06019A08 RID: 104968 RVA: 0x003B9B76 File Offset: 0x003B7D76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsMonsterConsecutiveKillsNotify other)
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

		// Token: 0x06019A09 RID: 104969 RVA: 0x003B9BA7 File Offset: 0x003B7DA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019A0A RID: 104970 RVA: 0x003B9BB0 File Offset: 0x003B7DB0
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ConsecutiveKillCount = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009648 RID: 38472
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009649 RID: 38473
		public const int ConsecutiveKillCountFieldNumber = 2;

		// Token: 0x0400964A RID: 38474
		private int consecutiveKillCount_;
	}
}
