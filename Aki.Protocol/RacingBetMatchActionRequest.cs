using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E3C RID: 3644
	[NetMessage(EMessageId.RacingBetMatchActionRequest)]
	public sealed class RacingBetMatchActionRequest : IMessage<RacingBetMatchActionRequest>, IMessage, IEquatable<RacingBetMatchActionRequest>, IDeepCloneable<RacingBetMatchActionRequest>, IBufferMessage
	{
		// Token: 0x060138F9 RID: 80121 RVA: 0x002D7938 File Offset: 0x002D5B38
		[NullableContext(1)]
		public static RacingBetMatchActionRequest Create()
		{
			return new RacingBetMatchActionRequest();
		}

		// Token: 0x170040DB RID: 16603
		// (get) Token: 0x060138FA RID: 80122 RVA: 0x002D793F File Offset: 0x002D5B3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170040DC RID: 16604
		// (get) Token: 0x060138FB RID: 80123 RVA: 0x002D7942 File Offset: 0x002D5B42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetMatchActionRequest.Descriptor;
			}
		}

		// Token: 0x060138FC RID: 80124 RVA: 0x002D7949 File Offset: 0x002D5B49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetMatchActionRequest()
		{
		}

		// Token: 0x060138FD RID: 80125 RVA: 0x002D7951 File Offset: 0x002D5B51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetMatchActionRequest(RacingBetMatchActionRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.legMatchId_ = other.legMatchId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060138FE RID: 80126 RVA: 0x002D7982 File Offset: 0x002D5B82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetMatchActionRequest Clone()
		{
			return new RacingBetMatchActionRequest(this);
		}

		// Token: 0x170040DD RID: 16605
		// (get) Token: 0x060138FF RID: 80127 RVA: 0x002D798A File Offset: 0x002D5B8A
		// (set) Token: 0x06013900 RID: 80128 RVA: 0x002D7992 File Offset: 0x002D5B92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x170040DE RID: 16606
		// (get) Token: 0x06013901 RID: 80129 RVA: 0x002D799B File Offset: 0x002D5B9B
		// (set) Token: 0x06013902 RID: 80130 RVA: 0x002D79A3 File Offset: 0x002D5BA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LegMatchId
		{
			get
			{
				return this.legMatchId_;
			}
			set
			{
				this.legMatchId_ = value;
			}
		}

		// Token: 0x06013903 RID: 80131 RVA: 0x002D79AC File Offset: 0x002D5BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetMatchActionRequest);
		}

		// Token: 0x06013904 RID: 80132 RVA: 0x002D79BA File Offset: 0x002D5BBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetMatchActionRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.LegMatchId == other.LegMatchId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013905 RID: 80133 RVA: 0x002D79F8 File Offset: 0x002D5BF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.LegMatchId != 0)
			{
				num ^= this.LegMatchId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013906 RID: 80134 RVA: 0x002D7A50 File Offset: 0x002D5C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013907 RID: 80135 RVA: 0x002D7A5D File Offset: 0x002D5C5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013908 RID: 80136 RVA: 0x002D7A68 File Offset: 0x002D5C68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ActivityId);
			}
			if (this.LegMatchId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.LegMatchId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013909 RID: 80137 RVA: 0x002D7AC4 File Offset: 0x002D5CC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.LegMatchId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LegMatchId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601390A RID: 80138 RVA: 0x002D7B1C File Offset: 0x002D5D1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetMatchActionRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.LegMatchId != 0)
			{
				this.LegMatchId = other.LegMatchId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601390B RID: 80139 RVA: 0x002D7B6C File Offset: 0x002D5D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601390C RID: 80140 RVA: 0x002D7B78 File Offset: 0x002D5D78
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
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.LegMatchId = input.ReadInt32();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040077B5 RID: 30645
		private UnknownFieldSet _unknownFields;

		// Token: 0x040077B6 RID: 30646
		public const int ActivityIdFieldNumber = 3;

		// Token: 0x040077B7 RID: 30647
		private int activityId_;

		// Token: 0x040077B8 RID: 30648
		public const int LegMatchIdFieldNumber = 12;

		// Token: 0x040077B9 RID: 30649
		private int legMatchId_;
	}
}
