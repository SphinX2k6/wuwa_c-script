using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E71 RID: 3697
	public sealed class RacingBetsPromoteInfo : IMessage<RacingBetsPromoteInfo>, IMessage, IEquatable<RacingBetsPromoteInfo>, IDeepCloneable<RacingBetsPromoteInfo>, IBufferMessage
	{
		// Token: 0x06013DC7 RID: 81351 RVA: 0x002E480C File Offset: 0x002E2A0C
		[NullableContext(1)]
		public static RacingBetsPromoteInfo Create()
		{
			return new RacingBetsPromoteInfo();
		}

		// Token: 0x1700420D RID: 16909
		// (get) Token: 0x06013DC8 RID: 81352 RVA: 0x002E4813 File Offset: 0x002E2A13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700420E RID: 16910
		// (get) Token: 0x06013DC9 RID: 81353 RVA: 0x002E4816 File Offset: 0x002E2A16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsPromoteInfo.Descriptor;
			}
		}

		// Token: 0x06013DCA RID: 81354 RVA: 0x002E481D File Offset: 0x002E2A1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsPromoteInfo()
		{
		}

		// Token: 0x06013DCB RID: 81355 RVA: 0x002E4830 File Offset: 0x002E2A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsPromoteInfo(RacingBetsPromoteInfo other) : this()
		{
			this.groupMatchId_ = other.groupMatchId_;
			this.dangoId_ = other.dangoId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013DCC RID: 81356 RVA: 0x002E4866 File Offset: 0x002E2A66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsPromoteInfo Clone()
		{
			return new RacingBetsPromoteInfo(this);
		}

		// Token: 0x1700420F RID: 16911
		// (get) Token: 0x06013DCD RID: 81357 RVA: 0x002E486E File Offset: 0x002E2A6E
		// (set) Token: 0x06013DCE RID: 81358 RVA: 0x002E4876 File Offset: 0x002E2A76
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

		// Token: 0x17004210 RID: 16912
		// (get) Token: 0x06013DCF RID: 81359 RVA: 0x002E487F File Offset: 0x002E2A7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DangoId
		{
			get
			{
				return this.dangoId_;
			}
		}

		// Token: 0x06013DD0 RID: 81360 RVA: 0x002E4887 File Offset: 0x002E2A87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsPromoteInfo);
		}

		// Token: 0x06013DD1 RID: 81361 RVA: 0x002E4898 File Offset: 0x002E2A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsPromoteInfo other)
		{
			return other != null && (other == this || (this.GroupMatchId == other.GroupMatchId && this.dangoId_.Equals(other.dangoId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013DD2 RID: 81362 RVA: 0x002E48E8 File Offset: 0x002E2AE8
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

		// Token: 0x06013DD3 RID: 81363 RVA: 0x002E4935 File Offset: 0x002E2B35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013DD4 RID: 81364 RVA: 0x002E4942 File Offset: 0x002E2B42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013DD5 RID: 81365 RVA: 0x002E494C File Offset: 0x002E2B4C
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

		// Token: 0x06013DD6 RID: 81366 RVA: 0x002E499C File Offset: 0x002E2B9C
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

		// Token: 0x06013DD7 RID: 81367 RVA: 0x002E49F0 File Offset: 0x002E2BF0
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

		// Token: 0x06013DD8 RID: 81368 RVA: 0x002E4A3D File Offset: 0x002E2C3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013DD9 RID: 81369 RVA: 0x002E4A48 File Offset: 0x002E2C48
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

		// Token: 0x04007979 RID: 31097
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400797A RID: 31098
		public const int GroupMatchIdFieldNumber = 1;

		// Token: 0x0400797B RID: 31099
		private int groupMatchId_;

		// Token: 0x0400797C RID: 31100
		public const int DangoIdFieldNumber = 2;

		// Token: 0x0400797D RID: 31101
		private static readonly FieldCodec<int> _repeated_dangoId_codec = FieldCodec.ForInt32(18U);

		// Token: 0x0400797E RID: 31102
		private readonly RepeatedField<int> dangoId_ = new RepeatedField<int>();
	}
}
