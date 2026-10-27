using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E5A RID: 3674
	public sealed class RacingBetsDungeonStart : IMessage<RacingBetsDungeonStart>, IMessage, IEquatable<RacingBetsDungeonStart>, IDeepCloneable<RacingBetsDungeonStart>, IBufferMessage
	{
		// Token: 0x06013B86 RID: 80774 RVA: 0x002DDA55 File Offset: 0x002DBC55
		[NullableContext(1)]
		public static RacingBetsDungeonStart Create()
		{
			return new RacingBetsDungeonStart();
		}

		// Token: 0x17004170 RID: 16752
		// (get) Token: 0x06013B87 RID: 80775 RVA: 0x002DDA5C File Offset: 0x002DBC5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004171 RID: 16753
		// (get) Token: 0x06013B88 RID: 80776 RVA: 0x002DDA5F File Offset: 0x002DBC5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsDungeonStart.Descriptor;
			}
		}

		// Token: 0x06013B89 RID: 80777 RVA: 0x002DDA66 File Offset: 0x002DBC66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDungeonStart()
		{
		}

		// Token: 0x06013B8A RID: 80778 RVA: 0x002DDA6E File Offset: 0x002DBC6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDungeonStart(RacingBetsDungeonStart other) : this()
		{
			this.legMatchId_ = other.legMatchId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013B8B RID: 80779 RVA: 0x002DDA93 File Offset: 0x002DBC93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDungeonStart Clone()
		{
			return new RacingBetsDungeonStart(this);
		}

		// Token: 0x17004172 RID: 16754
		// (get) Token: 0x06013B8C RID: 80780 RVA: 0x002DDA9B File Offset: 0x002DBC9B
		// (set) Token: 0x06013B8D RID: 80781 RVA: 0x002DDAA3 File Offset: 0x002DBCA3
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

		// Token: 0x06013B8E RID: 80782 RVA: 0x002DDAAC File Offset: 0x002DBCAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsDungeonStart);
		}

		// Token: 0x06013B8F RID: 80783 RVA: 0x002DDABA File Offset: 0x002DBCBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsDungeonStart other)
		{
			return other != null && (other == this || (this.LegMatchId == other.LegMatchId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013B90 RID: 80784 RVA: 0x002DDAE8 File Offset: 0x002DBCE8
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

		// Token: 0x06013B91 RID: 80785 RVA: 0x002DDB27 File Offset: 0x002DBD27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013B92 RID: 80786 RVA: 0x002DDB34 File Offset: 0x002DBD34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013B93 RID: 80787 RVA: 0x002DDB3D File Offset: 0x002DBD3D
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

		// Token: 0x06013B94 RID: 80788 RVA: 0x002DDB70 File Offset: 0x002DBD70
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

		// Token: 0x06013B95 RID: 80789 RVA: 0x002DDBAE File Offset: 0x002DBDAE
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

		// Token: 0x06013B96 RID: 80790 RVA: 0x002DDBDF File Offset: 0x002DBDDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013B97 RID: 80791 RVA: 0x002DDBE8 File Offset: 0x002DBDE8
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

		// Token: 0x04007894 RID: 30868
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007895 RID: 30869
		public const int LegMatchIdFieldNumber = 1;

		// Token: 0x04007896 RID: 30870
		private int legMatchId_;
	}
}
