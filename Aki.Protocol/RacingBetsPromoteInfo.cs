using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E61 RID: 3681
	public sealed class RacingBetsPromoteInfo : IMessage<RacingBetsPromoteInfo>, IMessage, IEquatable<RacingBetsPromoteInfo>, IDeepCloneable<RacingBetsPromoteInfo>, IBufferMessage
	{
		// Token: 0x06013CE2 RID: 81122 RVA: 0x002E314C File Offset: 0x002E134C
		[NullableContext(1)]
		public static RacingBetsPromoteInfo Create()
		{
			return new RacingBetsPromoteInfo();
		}

		// Token: 0x170041E3 RID: 16867
		// (get) Token: 0x06013CE3 RID: 81123 RVA: 0x002E3153 File Offset: 0x002E1353
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170041E4 RID: 16868
		// (get) Token: 0x06013CE4 RID: 81124 RVA: 0x002E3156 File Offset: 0x002E1356
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsPromoteInfo.Descriptor;
			}
		}

		// Token: 0x06013CE5 RID: 81125 RVA: 0x002E315D File Offset: 0x002E135D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsPromoteInfo()
		{
		}

		// Token: 0x06013CE6 RID: 81126 RVA: 0x002E3170 File Offset: 0x002E1370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsPromoteInfo(RacingBetsPromoteInfo other) : this()
		{
			this.groupMatchId_ = other.groupMatchId_;
			this.dangoId_ = other.dangoId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013CE7 RID: 81127 RVA: 0x002E31A6 File Offset: 0x002E13A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsPromoteInfo Clone()
		{
			return new RacingBetsPromoteInfo(this);
		}

		// Token: 0x170041E5 RID: 16869
		// (get) Token: 0x06013CE8 RID: 81128 RVA: 0x002E31AE File Offset: 0x002E13AE
		// (set) Token: 0x06013CE9 RID: 81129 RVA: 0x002E31B6 File Offset: 0x002E13B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GroupMatchId
		{
			get
			{
				return this.groupMatchId_;
			}
			set
			{
				this.groupMatchId_ = value;
			}
		}

		// Token: 0x170041E6 RID: 16870
		// (get) Token: 0x06013CEA RID: 81130 RVA: 0x002E31BF File Offset: 0x002E13BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DangoId
		{
			get
			{
				return this.dangoId_;
			}
		}

		// Token: 0x06013CEB RID: 81131 RVA: 0x002E31C7 File Offset: 0x002E13C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsPromoteInfo);
		}

		// Token: 0x06013CEC RID: 81132 RVA: 0x002E31D8 File Offset: 0x002E13D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsPromoteInfo other)
		{
			return other != null && (other == this || (this.GroupMatchId == other.GroupMatchId && this.dangoId_.Equals(other.dangoId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013CED RID: 81133 RVA: 0x002E3228 File Offset: 0x002E1428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GroupMatchId != 0)
			{
				num ^= this.GroupMatchId.GetHashCode();
			}
			num ^= this.dangoId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013CEE RID: 81134 RVA: 0x002E3275 File Offset: 0x002E1475
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013CEF RID: 81135 RVA: 0x002E3282 File Offset: 0x002E1482
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013CF0 RID: 81136 RVA: 0x002E328C File Offset: 0x002E148C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GroupMatchId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.GroupMatchId);
			}
			this.dangoId_.WriteTo(ref output, RacingBetsPromoteInfo._repeated_dangoId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013CF1 RID: 81137 RVA: 0x002E32DC File Offset: 0x002E14DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GroupMatchId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GroupMatchId);
			}
			num += this.dangoId_.CalculateSize(RacingBetsPromoteInfo._repeated_dangoId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013CF2 RID: 81138 RVA: 0x002E3330 File Offset: 0x002E1530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsPromoteInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GroupMatchId != 0)
			{
				this.GroupMatchId = other.GroupMatchId;
			}
			this.dangoId_.Add(other.dangoId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013CF3 RID: 81139 RVA: 0x002E337D File Offset: 0x002E157D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013CF4 RID: 81140 RVA: 0x002E3388 File Offset: 0x002E1588
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
					if (num != 16U && num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.dangoId_.AddEntriesFrom(ref input, RacingBetsPromoteInfo._repeated_dangoId_codec);
					}
				}
				else
				{
					this.GroupMatchId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040079A3 RID: 31139
		private UnknownFieldSet _unknownFields;

		// Token: 0x040079A4 RID: 31140
		public const int GroupMatchIdFieldNumber = 1;

		// Token: 0x040079A5 RID: 31141
		private int groupMatchId_;

		// Token: 0x040079A6 RID: 31142
		public const int DangoIdFieldNumber = 2;

		// Token: 0x040079A7 RID: 31143
		private static readonly FieldCodec<int> _repeated_dangoId_codec = FieldCodec.ForInt32(18U);

		// Token: 0x040079A8 RID: 31144
		private readonly RepeatedField<int> dangoId_ = new RepeatedField<int>();
	}
}
