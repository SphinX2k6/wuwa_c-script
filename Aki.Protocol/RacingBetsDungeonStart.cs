using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E4A RID: 3658
	public sealed class RacingBetsDungeonStart : IMessage<RacingBetsDungeonStart>, IMessage, IEquatable<RacingBetsDungeonStart>, IDeepCloneable<RacingBetsDungeonStart>, IBufferMessage
	{
		// Token: 0x06013AA1 RID: 80545 RVA: 0x002DC399 File Offset: 0x002DA599
		[NullableContext(1)]
		public static RacingBetsDungeonStart Create()
		{
			return new RacingBetsDungeonStart();
		}

		// Token: 0x17004146 RID: 16710
		// (get) Token: 0x06013AA2 RID: 80546 RVA: 0x002DC3A0 File Offset: 0x002DA5A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004147 RID: 16711
		// (get) Token: 0x06013AA3 RID: 80547 RVA: 0x002DC3A3 File Offset: 0x002DA5A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsDungeonStart.Descriptor;
			}
		}

		// Token: 0x06013AA4 RID: 80548 RVA: 0x002DC3AA File Offset: 0x002DA5AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDungeonStart()
		{
		}

		// Token: 0x06013AA5 RID: 80549 RVA: 0x002DC3B2 File Offset: 0x002DA5B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDungeonStart(RacingBetsDungeonStart other) : this()
		{
			this.legMatchId_ = other.legMatchId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013AA6 RID: 80550 RVA: 0x002DC3D7 File Offset: 0x002DA5D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDungeonStart Clone()
		{
			return new RacingBetsDungeonStart(this);
		}

		// Token: 0x17004148 RID: 16712
		// (get) Token: 0x06013AA7 RID: 80551 RVA: 0x002DC3DF File Offset: 0x002DA5DF
		// (set) Token: 0x06013AA8 RID: 80552 RVA: 0x002DC3E7 File Offset: 0x002DA5E7
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

		// Token: 0x06013AA9 RID: 80553 RVA: 0x002DC3F0 File Offset: 0x002DA5F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsDungeonStart);
		}

		// Token: 0x06013AAA RID: 80554 RVA: 0x002DC3FE File Offset: 0x002DA5FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsDungeonStart other)
		{
			return other != null && (other == this || (this.LegMatchId == other.LegMatchId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013AAB RID: 80555 RVA: 0x002DC42C File Offset: 0x002DA62C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x06013AAC RID: 80556 RVA: 0x002DC46B File Offset: 0x002DA66B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013AAD RID: 80557 RVA: 0x002DC478 File Offset: 0x002DA678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013AAE RID: 80558 RVA: 0x002DC481 File Offset: 0x002DA681
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LegMatchId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LegMatchId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013AAF RID: 80559 RVA: 0x002DC4B4 File Offset: 0x002DA6B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x06013AB0 RID: 80560 RVA: 0x002DC4F2 File Offset: 0x002DA6F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsDungeonStart other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LegMatchId != 0)
			{
				this.LegMatchId = other.LegMatchId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013AB1 RID: 80561 RVA: 0x002DC523 File Offset: 0x002DA723
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013AB2 RID: 80562 RVA: 0x002DC52C File Offset: 0x002DA72C
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.LegMatchId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040078BE RID: 30910
		private UnknownFieldSet _unknownFields;

		// Token: 0x040078BF RID: 30911
		public const int LegMatchIdFieldNumber = 1;

		// Token: 0x040078C0 RID: 30912
		private int legMatchId_;
	}
}
